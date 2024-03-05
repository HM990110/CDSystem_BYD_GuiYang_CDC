using CDClassLibrary.Common;
using CDClassLibrary.Data;
using CDClassLibrary.Log;
using CDClassLibrary.Mes;
using CDClassLibrary.Stage.GlobalStruct;
using CDClassLibrary.Tools;

namespace CDClassLibrary.Stage
{
    [Serializable]
    public class ThreadStage
    {
        #region //变量、状态、结构体、运行数据

        public TDeviceType DeviceType = TDeviceType.CDC2;

        /// <summary>
        /// Run标记
        /// </summary>
        public bool FRunFlag = false;

        /// <summary>
        /// 启用标记
        /// </summary>
        public bool VacancyFlag = false;
        /// <summary>
        /// 手自动标记 true：自动；false：手动  
        /// </summary>
        public bool ManualAutoFlag = false;
        public bool ManualReservationFlag = false;

        public int FStageID;
        /// <summary>
        /// 列
        /// </summary>
        public int Col;
        /// <summary>
        /// 层
        /// </summary>
        public int Layer;
        /// <summary>
        /// 设备号
        /// </summary>
        public string FStageNo = string.Empty;
        public string IP = string.Empty;

        //{ 缓存数据 默认
        List<TRealTimeDataSave> saveRealTimeDatas = new();
        List<TChannelResultData> saveResultDatas = new();
        List<TSaveContactTestResultData> saveContactTestResultDatas = new();
        //}

        /// <summary>
        /// 操控版状态
        /// </summary>
        public TEnvData EnvData = new();
        public TEnvData EnvDataOld = new();
        public TEnvDataMCU EnvDataMCU = new();
        public TEnvDataMCU EnvDataMCUOld = new();

        /// <summary>
        /// 实时数据 
        /// </summary>
        public TRealTimeData RealTimeData = new();
        public TRealTimeData RealTimeDataOld = new();

        /// <summary>
        /// 当前流程
        /// </summary>
        public TProcessGroup ProcessGroup = new();

        /// <summary>
        /// 托盘信息
        /// </summary>
        public TTrayInfo TrayInfo = new();
        public string TRAYNOOld = "";

        // 上一次数据保存时间
        DateTime SaveDataTime = DateTime.Now;
        DateTime AddDataTime = DateTime.Now;
        //int SaveDataLastID = 0; 

        int StepNo = 0;

        /// <summary>
        /// 设备状态
        /// </summary> 
        public TStageState StageState { get; private set; }

        /// <summary>
        /// 流程阶段标记
        /// </summary>
        public TProcessFlag ProcessFlag { get; private set; }

        /// <summary>
        /// 当前数据存储位置
        /// </summary>
        public string DBPath = "";

        /// <summary>
        /// 通信错误次数
        /// </summary>
        int ConnectErrorCount = 0;

        DateTime StageSaveTime = DateTime.Now;

        #endregion

        public void ThreadStageInfo(int FStageID)
        {
            this.FRunFlag = true;
            this.ConnectErrorCount = 0;
            this.FStageID = FStageID;
            this.Col = FStageID / GlobalDefine.NUM_DEVICEPERLINE + GlobalDefine.DVSTNO;
            this.Layer = FStageID % GlobalDefine.NUM_DEVICEPERLINE + 1;
            this.FStageNo = GlobalDefine.LNSTNO.ToString().PadLeft(2, '0') + (Col).ToString().PadLeft(3, '0') + (Layer).ToString().PadLeft(2, '0');

            IP = GlobalDefine.IPs[FStageID];
            DeviceType = GlobalDefine.DeviceTypes[FStageID];
            VacancyFlag = GlobalDefine.VacancyFlags[FStageID];
            ManualAutoFlag = GlobalDefine.ManualAutoFlags[FStageID];
            GlobalParams.CommMCU[FStageID] = new ICommMCU(FStageNo, IP);
            EnvData.DeviceOnOff = false;
            EnvDataOld.DeviceOnOff = false;

            GlobalFunction.SendConfig(FStageID);
        }

        public void Run()
        {
            //try
            //{
            while (FRunFlag)
            {
                //如果设备未启用则等待
                if (!VacancyFlag)
                {
                    if (StageState != TStageState.ssVacancy)
                        StageState = TStageState.ssVacancy;
                    if (GlobalParams.CommMCU[FStageID].IsConnected())
                        GlobalParams.CommMCU[FStageID].CloseConn();
                    Thread.Sleep(Constants.ThreadStage.THREADDELAY_WAIT);
                    continue;
                }

                //如果设备启动则接收数据
                if (RefreshData())
                {
                    //设备异常检查
                    AbnormalInspect();

                    //流程状态控制
                    InspectionControl();

                    //定时保存设备数据
                    if ((StageState == TStageState.ssRunning) || (ProcessFlag == TProcessFlag.pfAutoInProc) || (ProcessFlag == TProcessFlag.pfManualInProc))
                    {
                        if ((DateTime.Now - StageSaveTime).TotalSeconds > Constants.ThreadStage.COUNT_SAVESTAGE)
                        {
                            SerializeStage();
                            StageSaveTime = DateTime.Now;
                        }
                    };

                    //线程等待
                    Thread.Sleep(Constants.ThreadStage.THREADDELAY_WORK);
                }
                else
                {
                    if (ConnectErrorCount > Constants.ThreadStage.COUNT_COMMERROR)
                    {
                        if (EnvData.DeviceOnOff != EnvDataOld.DeviceOnOff)
                        {
                            OperationRecords.WriteOperatingStatistic(FStageNo, "设备断电");
                            EnvDataOld.DeviceOnOff = EnvData.DeviceOnOff;
                        }

                        if (StageState != TStageState.ssOff || ProcessFlag != TProcessFlag.pfInit)
                        {
                            EnvData = new TEnvData();//初始状态  
                            EnvDataMCU = new TEnvDataMCU();//初始化MCU数据 
                            RealTimeData = new TRealTimeData();
                            StateChange(TStageState.ssOff, ProcessFlag);
                        };

                        //通讯中断后延长等待时间
                        Thread.Sleep(Constants.ThreadStage.THREADDELAY_WAIT);
                    }
                    else
                    {
                        ConnectErrorCount++;
                        Thread.Sleep(Constants.ThreadStage.THREADDELAY_WORK);
                    }
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("1044:" + ex.Message);
            //    GlobalFunction.AlarmLogAdd(FStageNo, "线程错误", "线程报告异常：" + ex.Message);
            //    if (FRunFlag)
            //        Thread.Sleep(Constants.ThreadStage.THREADDELAY_WAIT);
            //}

            //线程结束前序列化现场数据
            SerializeStage();
        }

        private bool RefreshData()
        {
            if (GlobalParams.CommMCU[FStageID].IsConnected())
            {
                //初始化下位机
                FirstStartUp();

                bool boo1 = GlobalDefine.OperationMode && RefreshEnvData();
                bool boo2 = RefreshRealData();
                return boo1 && boo2;
            }
            else
                return false;
        }

        void FirstStartUp()
        {
            if (ConnectErrorCount > 0)
            {
                //清除通讯错误次数
                ConnectErrorCount = 0;

                GlobalParams.CommMCU[FStageID] = new ICommMCU(FStageNo, IP);

                //校时、发送烟雾及温度报警设置值
                GlobalFunction.SendConfig(FStageID);
            }
        }

        private void AbnormalInspect()
        {
            //只在托盘进入及流程期间 \ 下位机自动状态 判断 
            if (StageState < TStageState.ssTrayIn || StageState > TStageState.ssProcessEnd || EnvData.McuWorkState == TMcuWorkState.Manual1 || EnvData.McuWorkState == TMcuWorkState.Manual2)
                return;

            //此处检查设备异常状态，包括温度、电压等  
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                //通道温度
                if (RealTimeData.ChannelRealTimeData[ChnNo].ChannelTemp >= GlobalDefine.ParameterLimit.Limits[FStageID].ATempLimit + 5 && RealTimeDataOld.ChannelRealTimeData[ChnNo].ChannelTemp >= GlobalDefine.ParameterLimit.Limits[FStageID].ATempLimit + 5)
                {
                    StateChange(TStageState.ssPCAlarm, ProcessFlag);
                    string tmpError = "通道" + (ChnNo + 1) + "通道温度异常：" + RealTimeData.ChannelRealTimeData[ChnNo].ChannelTemp;
                    GlobalFunction.AlarmLogAdd(FStageNo, "设备报警", tmpError);
                    return;
                }
                //电池温度
                if (RealTimeData.ChannelRealTimeData[ChnNo].CellTemp >= GlobalDefine.ParameterLimit.Limits[FStageID].ACellTempLimit + 5 && RealTimeDataOld.ChannelRealTimeData[ChnNo].CellTemp >= GlobalDefine.ParameterLimit.Limits[FStageID].ACellTempLimit + 5)
                {
                    StateChange(TStageState.ssPCAlarm, ProcessFlag);
                    string tmpError = "电池" + (ChnNo + 1) + "电池温度异常：" + RealTimeData.ChannelRealTimeData[ChnNo].CellTemp;
                    GlobalFunction.AlarmLogAdd(FStageNo, "设备报警", tmpError);
                    return;
                }
                //电池电压
                if (RealTimeData.ChannelRealTimeData[ChnNo].Volt >= Constants.ThreadStage.UPLIMIT_CELL_VOLTAGE && RealTimeDataOld.ChannelRealTimeData[ChnNo].Volt >= Constants.ThreadStage.UPLIMIT_CELL_VOLTAGE)
                {
                    StateChange(TStageState.ssPCAlarm, ProcessFlag);
                    string tmpError = "电池" + (ChnNo + 1) + "电压异常：" + RealTimeData.ChannelRealTimeData[ChnNo].Volt;
                    GlobalFunction.AlarmLogAdd(FStageNo, "设备报警", tmpError);
                    return;
                }
            }

            //流程步次保护参数判断
            CheckResultData();
        }

        /// <summary>
        /// 检测实时数据电芯状态
        /// </summary> 
        /// <returns></returns>
        public void CheckResultData()
        {
            if (RealTimeData.ProcessStatus is TProcessStatus.Running)
            {
                bool ISPCProtect = false;
                List<int> CellErrorCount = new();
                byte[] bytes = new byte[GlobalDefine.CHANNELS];
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    int ChnNos = RealTimeData.ChannelRealTimeData[ChnNo].ChnNo - 1;

                    if (StepNo < 0 || ChnNo < 0)
                        continue;

                    bytes[ChnNo] = RealTimeData.ChannelRealTimeData[ChnNo].ChnState;

                    if ((bytes[ChnNo] == 0x60) || (bytes[ChnNo] == 0x61))
                    {
                        continue;
                    }
                    if (bytes[ChnNo] == 0x00)
                    {
                        if (ProcessGroup.PCProtect.StepPCProtect[StepNo].IsValidFlag && RealTimeData.StepWorkTime > 3)
                        {
                            if (RealTimeData.ChannelRealTimeData[ChnNo].StepMode == ProcessGroup.Process.ProcStepRec[StepNo].StepMode)
                            {
                                if (ProcessGroup.PCProtect.StepPCProtect[StepNo].VoltageMin != 0 && RealTimeData.ChannelRealTimeData[ChnNo].Volt < ProcessGroup.PCProtect.StepPCProtect[StepNo].VoltageMin)
                                {
                                    bytes[ChnNo] = 0x64;
                                    ISPCProtect = true;
                                    CellErrorCount.Add(ChnNos);
                                }
                                else if (ProcessGroup.PCProtect.StepPCProtect[StepNo].VoltageMax != 0 && RealTimeData.ChannelRealTimeData[ChnNo].Volt > ProcessGroup.PCProtect.StepPCProtect[StepNo].VoltageMax)
                                {
                                    bytes[ChnNo] = 0x65;
                                    ISPCProtect = true;
                                    CellErrorCount.Add(ChnNos);
                                }
                                else if (RealTimeData.ChannelRealTimeData[ChnNo].StepMode != TStepMode.REST)
                                {
                                    if (ProcessGroup.PCProtect.StepPCProtect[StepNo].CurrentMin != 0 && RealTimeData.ChannelRealTimeData[ChnNo].Curre < ProcessGroup.PCProtect.StepPCProtect[StepNo].CurrentMin)
                                    {
                                        bytes[ChnNo] = 0x66;
                                        ISPCProtect = true;
                                        CellErrorCount.Add(ChnNos);
                                    }
                                    else if (ProcessGroup.PCProtect.StepPCProtect[StepNo].CurrentMax != 0 && RealTimeData.ChannelRealTimeData[ChnNo].Curre > ProcessGroup.PCProtect.StepPCProtect[StepNo].CurrentMax)
                                    {
                                        bytes[ChnNo] = 0x67;
                                        ISPCProtect = true;
                                        CellErrorCount.Add(ChnNos);
                                    }
                                }
                            }
                            else if (ProcessGroup.Process.ProcStepRec[StepNo].StepMode != TStepMode.REST && RealTimeData.ChannelRealTimeData[ChnNo].StepMode == TStepMode.WAIT && RealTimeData.ChannelRealTimeData[ChnNo].StepMode != RealTimeDataOld.ChannelRealTimeData[ChnNo].StepMode)
                            {
                                if (ProcessGroup.PCProtect.StepPCProtect[StepNo].CapacityMin != 0 && RealTimeData.ChannelRealTimeData[ChnNo].Capacity < ProcessGroup.PCProtect.StepPCProtect[StepNo].CapacityMin)
                                {
                                    bytes[ChnNo] = 0x68;
                                    ISPCProtect = true;
                                    CellErrorCount.Add(ChnNos);
                                }
                                else if (ProcessGroup.PCProtect.StepPCProtect[StepNo].CapacityMax != 0 && RealTimeData.ChannelRealTimeData[ChnNo].Capacity > ProcessGroup.PCProtect.StepPCProtect[StepNo].CapacityMax)
                                {
                                    bytes[ChnNo] = 0x69;
                                    ISPCProtect = true;
                                    CellErrorCount.Add(ChnNos);
                                }
                            }
                        }
                    }
                    else
                    {
                        CellErrorCount.Add(ChnNos);
                    }
                }
                if (ISPCProtect)
                {
                    ChannelProtectPC(bytes);
                }

                TrayInfo.NG_COUNT = CellErrorCount.Count;

                bool result = true;
                if (CellErrorCount.Count == TrayInfo.CELL_COUNT)
                {
                    result = false;
                    GlobalFunction.AlarmLogAdd(FStageNo, "流程中全盘NG");
                }
                else if (CellErrorCount.Count > ProcessGroup.DeviceNGLimit)
                {
                    result = false;
                    GlobalFunction.AlarmLogAdd(FStageNo, "流程中NG电池数量超出限制", "NG上限 " + ProcessGroup.DeviceNGLimit + "    NG电芯 " + CellErrorCount.Count);
                }
                if (!result)
                {
                    StateChange(TStageState.ssChargeDis, TProcessFlag.pfInProcNG);

                    for (int i = 0; i < CellErrorCount.Count; i++)
                        GlobalDefine.DeviceNGCount.NGCount[FStageID][CellErrorCount[i]]++;
                    GlobalFunction.SetNGCount();
                }
            }
        }

        /// <summary>
        /// 流程状态控制
        /// </summary>
        private void InspectionControl()
        {
            switch (StageState)
            {
                case TStageState.ssOff:
                case TStageState.ssVacancy:
                    StageState = TStageState.ssInit;
                    break;

                case TStageState.ssInit:
                    Init();
                    break;

                case TStageState.ssTrayIn:
                    TrayIn();
                    break;

                case TStageState.ssReady:
                    SwitchProcess();
                    break;
                case TStageState.ssWait:
                case TStageState.ssRunning:
                    SaveRealTimeData(false);
                    SwitchProcess();
                    break;

                case TStageState.ssProcessEnd:
                    CheckTrayOut();
                    break;

                case TStageState.ssWaitOutbound:
                    Outbound();
                    break;

                case TStageState.ssPowerDown:   //断电后恢复，需要人工手动操作
                    ContinueInspection();
                    break;
            }
        }

        /// <summary>
        /// 检查机构状态
        /// </summary>
        /// <returns></returns>
        private bool RefreshEnvData()
        {
            TEnvDataMCU tmpEnvDataMCU = new();

            //获取操控板数据
            if (!GlobalParams.CommMCU[FStageID].RecEnvData(ref tmpEnvDataMCU))
            {
                return false;
            }
            else
            {
                //保留上一次数据
                EnvDataMCUOld = EnvDataMCU;
                EnvDataOld = EnvData;

                //更新数据
                EnvDataMCU = tmpEnvDataMCU;
                EnvData = TStructConvert.ConvertTEnvData(EnvDataMCU);

                //记录上电
                if (EnvData.DeviceOnOff && !EnvDataOld.DeviceOnOff)
                    OperationRecords.WriteOperatingStatistic(FStageNo, "设备上电");

                //记录逆变器状态
                if (EnvData.InverterPowerState == TInverterPowerState.asNormal && EnvDataOld.InverterPowerState != TInverterPowerState.asNormal)
                    OperationRecords.WritePart(FStageNo, "逆变器");

                //记录探针使用次数
                if (EnvData.TrayState == TTrayState.dsDock && (EnvData.CylinderStatorState == TCylinderStatorState.dsDock && EnvDataOld.CylinderStatorState != TCylinderStatorState.dsDock))
                {
                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    {
                        if (TrayInfo.ChnState[ChnNo] != 0x60 || TrayInfo.ChnState[ChnNo] != 0x61)
                            GlobalDefine.DeviceNGCount.ContactCount[FStageID][ChnNo]++;
                    }
                };

                //记录报警
                if (GlobalDefine.OperationMode && !EnvData.SensorEMGAlarm)
                {
                    if (!GlobalDefine.ProcessFlagInProc.Contains(ProcessFlag))
                        StateChange(TStageState.ssEMG, ProcessFlag);
                    if (EnvDataMCUOld.SensorEMGAlarm != EnvDataMCU.SensorEMGAlarm)
                    {
                        string ErrorLog = "";
                        foreach (TSensorsEMGFault item in EnvData.SensorEMGAlarms)
                            ErrorLog += $"{GlobalFunction.GetValue(item)};";
                        GlobalFunction.AlarmLogAdd(FStageNo, "机构传感器报警", ErrorLog.Replace("\r\n", "、"));
                    }
                };

                //检查EMG状态  
                if (!EnvData.SeriousEMGState)
                {
                    if (EnvDataMCUOld.SeriousEMGState != EnvDataMCU.SeriousEMGState)
                    {
                        string ErrorLog = "";
                        foreach (TSeriousEMGFault item in EnvData.SeriousEMGStates)
                        {
                            ErrorLog += GlobalFunction.GetValue(item);
                            switch (item)
                            {
                                case TSeriousEMGFault.efTemp:
                                    for (int i = 0; i < EnvData.MechanicalTempValue.Length; i++)
                                        if (EnvData.MechanicalTempValue[i] > EnvData.MechanicalTempAlarmValue)
                                        {
                                            ErrorLog += $"{(i + 1)}.{EnvData.MechanicalTempValue[i]}℃；";
                                        }
                                    break;
                                case TSeriousEMGFault.efBoardTemp:
                                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                                        if (RealTimeData.ChannelRealTimeData[ChnNo].CellTemp > EnvData.BatteryTempAlarmValue)
                                        {
                                            ErrorLog += $"{(ChnNo + 1)}.{RealTimeData.ChannelRealTimeData[ChnNo].CellTemp}℃；";
                                        }
                                    break;
                                case TSeriousEMGFault.efSmog:
                                    for (int i = 0; i < EnvData.SmogStates.Length; i++)
                                        if (EnvData.SmogStates[i] == TSmogState.asAlarm)
                                        {
                                            ErrorLog += $"{(i + 1)}；";
                                        }
                                    break;
                                case TSeriousEMGFault.efFan:
                                    for (int i = 0; i < EnvData.FanStates.Length; i++)
                                    {
                                        if (EnvData.FanStates[i] == TFanState.fsError)
                                        {
                                            if (i < 4)
                                                ErrorLog += $"上{(i + 1)}；";
                                            else if (i < 8)
                                                ErrorLog += $"下{(i + 1 - 4)}；";
                                            else if (i < 14)
                                                ErrorLog += $"水{(i + 1 - 8)}；";
                                            else if (i < 15)
                                                ErrorLog += $"烟{(i + 1 - 14)}；";
                                            else
                                                ErrorLog += $"其他{(i + 1)}；";
                                        }
                                    }
                                    break;
                            }
                            ErrorLog += "\r\n";
                        }


                        if (EnvData.SeriousEMGStates.Contains(TSeriousEMGFault.efSmog) && (EnvData.SeriousEMGStates.Contains(TSeriousEMGFault.efTemp) || EnvData.SeriousEMGStates.Contains(TSeriousEMGFault.efBoardTemp)))
                        {
                            StateChange(TStageState.ssFireAlarm, ProcessFlag);
                            HttpWMS.NotifyWMSStandingFireAlarm(Col, Layer);
                        }
                        else if (EnvData.SeriousEMGStates.Contains(TSeriousEMGFault.efSmog))
                            StateChange(TStageState.ssSmoke, ProcessFlag);
                        else if (EnvData.SeriousEMGStates.Contains(TSeriousEMGFault.efTemp) || EnvData.SeriousEMGStates.Contains(TSeriousEMGFault.efBoardTemp))
                            StateChange(TStageState.ssTemp, ProcessFlag);

                        else if (EnvData.SeriousEMGStates.Contains(TSeriousEMGFault.efFromPC) || EnvData.SeriousEMGStates.Contains(TSeriousEMGFault.efManualPC))
                            StateChange(TStageState.ssPCAlarm, ProcessFlag);
                        else
                            StateChange(TStageState.ssEMG, ProcessFlag);
                        GlobalFunction.AlarmLogAdd(FStageNo, "机构严重故障状态", ErrorLog.Replace("\r\n", "、"));
                    };
                }

                else
                {
                    if (StageState != TStageState.ssPowerDown)
                    {
                        if (EnvData.PowerFailFlag == TPowerFailFlag.pfResumeError ||
                            (EnvData.PowerFailFlag == TPowerFailFlag.pfOccurred && EnvData.TrayState == TTrayState.dsUndock))
                        {
                            GlobalParams.CommMCU[FStageID].PowerFailControl(0xAA);
                        }
                        else if (EnvData.PowerFailFlag == TPowerFailFlag.pfOccurred && EnvData.TrayState == TTrayState.dsDock)
                        {
                            StateChange(TStageState.ssPowerDown, ProcessFlag);
                            GlobalFunction.AlarmLogAdd(FStageNo, "机构有可恢复掉电标记，请检查！");
                        }
                        else if (EnvData.TrayState != EnvDataOld.TrayState && EnvDataOld.TrayState != TTrayState.NO01)
                        {
                            if (EnvData.TrayState == TTrayState.dsUndock)
                            {
                                Alarm = false;
                                StateChange(TStageState.ssInit, TProcessFlag.pfInit);
                                GlobalFunction.RunLogAdd(FStageNo, "托盘流出", "<" + TRAYNOOld + ">托盘流出");
                                TRAYNOOld = "";
                                DBPath = "";
                            }
                            else if (EnvData.TrayState == TTrayState.dsDockError)
                            {
                                StateChange(TStageState.ssTrayError, ProcessFlag);
                                if (EnvDataOld.TrayState is not TTrayState.dsDock)
                                {
                                    Alarm = false;
                                    GlobalFunction.RunLogAdd(FStageNo, "托盘流入");
                                    TRAYNOOld = "";
                                }
                            }
                            else if (EnvData.TrayState == TTrayState.dsDock && (EnvDataOld.TrayState is not TTrayState.dsDockError))
                            {
                                GlobalFunction.RunLogAdd(FStageNo, "托盘流入");
                                TRAYNOOld = "";
                            }
                        }
                        else if (StageState == TStageState.ssTrayError)
                        {
                            if (EnvData.TrayState != TTrayState.dsDockError)
                            {
                                Alarm = false;
                                StateChange(TStageState.ssInit, TProcessFlag.pfInit);
                            }
                        }
                    }
                    else
                    {
                        if (EnvData.PowerFailFlag == TPowerFailFlag.pfInit || EnvData.PowerFailFlag == TPowerFailFlag.pfNormal)
                        {
                            Alarm = false;
                            StateChange(TStageState.ssInit, TProcessFlag.pfInit);
                        }
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// 获取实时数据
        /// </summary>
        /// <returns></returns>
        private bool RefreshRealData()
        {
            //初始化MCU数据 
            TRealTimeDataMCU RealTimeDataMCU = new();

            //获取实时数据  
            if (GlobalParams.CommMCU[FStageID].RecRealTimeData(ref RealTimeDataMCU))
            {
                //保留上一次数据
                RealTimeDataOld = RealTimeData;

                //更新数据
                RealTimeData = TStructConvert.ConvertTRealTimeData(RealTimeDataMCU);

                //判断状态
                if (RealTimeDataOld.ProcessStatus == TProcessStatus.Init && RealTimeData.ProcessStatus == TProcessStatus.Running)
                {
                    StateChange(TStageState.ssRunning, ManualAutoFlag ? TProcessFlag.pfAutoInProc : TProcessFlag.pfManualInProc);
                }
                else if (RealTimeDataOld.ProcessStatus == TProcessStatus.Init && RealTimeData.ProcessStatus == TProcessStatus.Suspend)
                {
                    StateChange(TStageState.ssWait, TProcessFlag.pfWaitProcStart);
                };

                return true;
            }
            else
            {
                return false;
            }
        }

        #region //初始状态
        /// <summary>
        /// 检查机构状态 -> 托盘进入
        /// 自动状态情况下使用
        /// </summary>
        public void Init()
        {
            //托盘、气缸、风机  到位
            if (EnvData.TrayState == TTrayState.dsDock && EnvDataOld.TrayState == TTrayState.dsDock)
            {
                StateChange(TStageState.ssTrayIn, ProcessFlag);
            }
        }
        #endregion

        #region //托盘进入
        /// <summary>
        /// 托盘进入 -> 流程准备
        /// </summary>
        public void TrayIn()
        {
            //如果是自动模式则向MES获取托盘信息及参数
            if (ManualAutoFlag)
            {
                if (EnvData.ForkState == TForkState.fsUndock)
                {
                    if ((EnvData.FireDoorL == TDoorState.dsDock && EnvData.FireDoorR == TDoorState.dsDock))
                    {
                        //获取流程 
                        if (TRAYNOOld == "")
                        {
                            RequestReleasePull = false;
                            UploadWarehouseTestResult = false;
                            this.ProcessGroup = new();
                            this.TrayInfo = new();

                            if (HttpWMS.RequetWarehouseCellBingAsset(Col, Layer))
                            {
                                if (ProcessGroup.IsEnabled)
                                {
                                    StateChange(TStageState.ssReady, TProcessFlag.pfReady);
                                    TRAYNOOld = TrayInfo.TRAY_NO;
                                }
                                else
                                {
                                    GlobalFunction.AlarmLogAdd(FStageNo, "流程未启用或异常", "<" + ProcessGroup.ProcessName + ">流程未启用或异常");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (StageState != TStageState.ssEMG)
                            StateChange(TStageState.ssEMG, TProcessFlag.pfReady);
                    }
                }
            }
        }

        #endregion

        #region //流程准备、流程等待、流程中
        /// <summary>
        /// 流程阶段选择
        /// </summary>
        private void SwitchProcess()
        {
            switch (ProcessFlag)
            {
                //1 初始状态
                case TProcessFlag.pfInit: break;
                //2 流程准备
                case TProcessFlag.pfReady: StageStateSsReady(); break;
                //3 流程获取或发送
                case TProcessFlag.pfWaitFixProc: FixProcess(); break;
                //无电池通道检测
                case TProcessFlag.pfNoCellCheck: NoCellCheck(); break;
                //OCV测试
                case TProcessFlag.pfWaitOCVTest: OCVTest(); break;
                //接触测试
                case TProcessFlag.pfWaitContactTest: ContactTest(); break;
                case TProcessFlag.pfInContactTest: InContactTest(); break;
                //流程启动
                case TProcessFlag.pfWaitProcStart: StartInspection(); break;
                //流程运行中
                case TProcessFlag.pfAutoInProc:
                case TProcessFlag.pfManualInProc: StepControl(); break;
                //流程自动停止
                case TProcessFlag.pfAutoProcEnd:
                case TProcessFlag.pfManualProcEnd: InspectionEnd(); break;

                default:
                    //错误处理
                    break;
            }
        }

        public void StageStateSsReady()
        {
            if (ChannelProtectPC(TrayInfo.ChnState) && ChannelNGLimitControl())
            {
                saveRealTimeDatas = new List<TRealTimeDataSave>();
                saveResultDatas = new List<TChannelResultData>();
                saveContactTestResultDatas = new List<TSaveContactTestResultData>();

                EnvData = new TEnvData();
                EnvDataOld = new TEnvData();
                EnvDataMCU = new TEnvDataMCU();
                EnvDataMCUOld = new TEnvDataMCU();
                RealTimeData = new TRealTimeData();
                RealTimeDataOld = new TRealTimeData();

                //SaveDataLastID = 0;

                Thread.Sleep(2000);
                StateChange(TStageState.ssReady, TProcessFlag.pfWaitFixProc);
            }
        }

        /// <summary>
        /// 通道NG上限
        /// </summary>
        private bool ChannelNGLimitControl()
        {
            bool boo = true;
            string ChannelNo = $"通道NG次数超过上限{GlobalDefine.DeviceNGCount.ChannelNGLimit}，通道：";
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                if (GlobalDefine.DeviceNGCount.NGCount[FStageID][ChnNo] > GlobalDefine.DeviceNGCount.ChannelNGLimit)
                {
                    boo = false;
                    ChannelNo += (ChnNo + 1).ToString() + "、";
                }
            };

            if (!boo)
            {
                StateChange(TStageState.ssPCAlarm, TProcessFlag.pfInProcNG);
                GlobalFunction.AlarmLogAdd(FStageNo, "设备报警", ChannelNo);
            };

            return boo;
        }

        /// <summary>
        /// 无电池检测
        /// </summary>
        private void NoCellCheck()
        {
            if (EnvData.ForkState == TForkState.fsUndock)
            {
                GlobalParams.CommMCU[FStageID].SystemOnOff(0x55);
                for (int i = 0; i <= 20; i++)
                {
                    if (StageState != TStageState.ssReady && ProcessFlag != TProcessFlag.pfNoCellCheck)
                    {
                        return;
                    }

                    if (i == 20)
                    {
                        StateChange(TStageState.ssEMG, TProcessFlag.pfInit);
                        GlobalFunction.AlarmLogAdd(FStageNo, "设备报警", "系统启动超时");
                        return;
                    }

                    if (RefreshData())
                    {
                        if (EnvData.CylinderStatorState == TCylinderStatorState.dsDock)
                        {
                            GlobalFunction.RunLogAdd(FStageNo, "充放电流程开始", "<" + TRAYNOOld + ">充放电流程开始");
                            break;
                        }
                    }
                    else
                    {
                        GlobalParams.CommMCU[FStageID].SystemOnOff(0xAA);
                        return;
                    }
                    Thread.Sleep(2000);
                }
                Thread.Sleep(2000);
            }
            else
            {
                GlobalParams.CommMCU[FStageID].SystemOnOff(0xAA);
                return;
            }

            if (GlobalDefine.OperationMode && (EnvData.McuWorkState == TMcuWorkState.Auto1 || EnvData.McuWorkState == TMcuWorkState.Auto1))
            {
                if (EnvData.CylinderStatorState == TCylinderStatorState.dsDock)
                {
                    if (RefreshRealData())
                    {
                        List<int> CellErrorCount = new();
                        for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                        {
                            if (TrayInfo.ChnState[ChnNo] == 0x60)
                            {
                                if (RealTimeData.ChannelRealTimeData[ChnNo].Volt > GlobalDefine.NOCellchannelVolt)
                                {
                                    CellErrorCount.Add(ChnNo + 1);
                                }
                            }
                        }
                        if (CellErrorCount.Count > 0)
                        {
                            string str = "通道";
                            foreach (var item in CellErrorCount)
                                str += item + "、";

                            StateChange(TStageState.ssChargeDis, TProcessFlag.pfNoCellCheckNG);
                            GlobalFunction.AlarmLogAdd(FStageNo, "设备报警", "无电池通道检测错误，" + str);
                        }
                        else
                        {
                            StateChange(TStageState.ssWait, TProcessFlag.pfWaitOCVTest);
                        }
                    }
                }
            }
            else
            {
                StateChange(TStageState.ssWait, TProcessFlag.pfWaitOCVTest);
            }
        }

        /// <summary>
        /// 整体发送流程，在设备无电池作业时使用，使用FFmtInfo中的通道启动信息
        /// </summary>
        private void FixProcess()
        {
            //SaveDataLastID = 0;

            DateTime dateTime = DateTime.Now;
            DBPath = GlobalDefine.DataPath + DeviceType.ToString() + (ManualAutoFlag ? GlobalDefine.AutoPath : GlobalDefine.ManualPath) + dateTime.Year + "\\" + dateTime.Month + "\\" + dateTime.Day;
            if (!Directory.Exists(DBPath))
                Directory.CreateDirectory(DBPath);
            //初始化ChannelInfo中的文件路径  

            string MissionID = TrayInfo.TRAY_NO + "_" + DeviceType.ToString() + "_" + FStageNo + "_" + dateTime.ToString("yyyyMMddHHmmss");
            DBPath = DBPath + "\\" + MissionID + ".db";

            TrayInfo.MissionID = MissionID;
            DatabaseOperations.CellTestRecordDataADD(DBPath, FStageNo, TrayInfo);
            if (DatabaseOperations.DataCreateTable(DBPath))
            {
                DatabaseOperations.TrayInfoINSERT(DBPath, FStageNo, TrayInfo, ProcessGroup);

                //下发流程  

                if (GlobalParams.CommMCU[FStageID].SchSend(ProcessGroup.Process) && ChannelProtectPC(TrayInfo.ChnState))
                {
                    if (ProcessGroup.ContactTestProcess.IsContactTest)
                    {
                        if (GlobalParams.CommMCU[FStageID].ContactTest(ProcessGroup.ContactTestProcess))
                        {

                            StateChange(TStageState.ssReady, TProcessFlag.pfNoCellCheck);
                        }
                        else
                        {
                            StateChange(TStageState.ssChargeDis, TProcessFlag.pfWaitFixProcNG);
                        }
                    }
                    else
                    {
                        StateChange(TStageState.ssReady, TProcessFlag.pfNoCellCheck);
                    }
                }
                else
                {
                    StateChange(TStageState.ssChargeDis, TProcessFlag.pfWaitFixProcNG);
                }
            }
            else
            {
                StateChange(TStageState.ssChargeDis, TProcessFlag.pfWaitFixProcNG);
                GlobalFunction.AlarmLogAdd(FStageNo, "流程启动失败", "创建数据文件失败！");
            }
        }

        /// <summary>
        /// OCV检测 流程开始前
        /// </summary>
        private void OCVTest()
        {
            RefreshEnvData();
            if (GlobalDefine.OperationMode && ProcessGroup.OCVTestSet.IsOCVTest)
            {
                //关闭气缸
                if (EnvData.McuWorkState == TMcuWorkState.Auto2 && EnvData.CylinderStatorState != TCylinderStatorState.dsDock)
                {
                    Thread.Sleep(2000);
                    return;
                }

                //判断结果 
                if (!CheckOCVData())
                {
                    StateChange(TStageState.ssChargeDis, TProcessFlag.pfWaitOCVTestNG);
                }
                else
                {
                    StateChange(TStageState.ssReady, TProcessFlag.pfWaitContactTest);
                }
            }
            else
            {
                StateChange(TStageState.ssReady, TProcessFlag.pfWaitContactTest);
            }
        }

        /// <summary>
        /// OCV检测 OCV电池状态
        /// </summary>
        /// <returns></returns>
        public bool CheckOCVData()
        {
            int Count = 0;
            List<int> CellErrorCount = new();

            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                if (TrayInfo.ChnState[ChnNo] != 0x60 && TrayInfo.ChnState[ChnNo] != 0x61)
                {
                    if (RealTimeData.ChannelRealTimeData[ChnNo].Volt < ProcessGroup.OCVTestSet.OCVMin)
                    {
                        CellErrorCount.Add(ChnNo);
                        TrayInfo.ChnState[ChnNo] = 0x62;
                    }
                    else if (RealTimeData.ChannelRealTimeData[ChnNo].Volt > ProcessGroup.OCVTestSet.OCVMax)
                    {
                        CellErrorCount.Add(ChnNo);
                        TrayInfo.ChnState[ChnNo] = 0x63;
                    }
                    Count++;
                }
            }
            bool result = true;
            if (CellErrorCount.Count == Count)
            {
                result = false;
                GlobalFunction.AlarmLogAdd(FStageNo, "OCV检测全盘NG");
            }
            else if (CellErrorCount.Count > ProcessGroup.DeviceNGLimit)
            {
                result = false;
                ManualAllChannelControl(TControlCommand.Stop);
                GlobalParams.CommMCU[FStageID].SystemOnOff(0xAA);
                GlobalFunction.AlarmLogAdd(FStageNo, "OCV检测NG电池数量超出限制", "NG上限 " + ProcessGroup.DeviceNGLimit + "    NG电芯 " + CellErrorCount.Count);
            }
            TrayInfo.NG_COUNT = CellErrorCount.Count;

            if (!result)
            {
                for (int i = 0; i < CellErrorCount.Count; i++)
                    GlobalDefine.DeviceNGCount.NGCount[FStageID][CellErrorCount[i]]++;
                GlobalFunction.SetNGCount();
            }
            ChannelProtectPC(TrayInfo.ChnState);
            return result;
        }

        /// <summary>
        /// 接触测试
        /// </summary>
        private void ContactTest()
        {
            if (GlobalDefine.OperationMode && ProcessGroup.ContactTestProcess.IsContactTest)
            {
                if (GlobalParams.CommMCU[FStageID].ChannelControl(ToChannelControl(TControlCommand.Contact)))
                {
                    StateChange(TStageState.ssRunning, TProcessFlag.pfInContactTest);
                }
                else
                {
                    StateChange(TStageState.ssOverTime, TProcessFlag.pfWaitContactTestNG);
                    GlobalFunction.AlarmLogAdd(FStageNo, "接触测试启动失败");
                }
            }
            else
            {
                StateChange(TStageState.ssRunning, TProcessFlag.pfWaitProcStart);
            }
        }

        /// <summary>
        /// 接触测试
        /// </summary>
        private void InContactTest()
        {
            if (RealTimeData.ContactTestFlag == TContactTestFlag.Complete)
            {
                TContactTestResultDataMCU ContactTestResultDataMCU = new();
                if (GlobalParams.CommMCU[FStageID].RecContactData(ref ContactTestResultDataMCU))
                {
                    TContactTestResultData ContactTestResultData = TStructConvert.ConvertTContactTestResultData(ContactTestResultDataMCU);
                    DatabaseOperations.ContactTestResultDataINSERT(DBPath, FStageNo, saveContactTestResultDatas, TRAYNOOld);
                    if (CheckContactTestResultData(ContactTestResultData))//NGCount
                    {
                        StateChange(TStageState.ssReady, TProcessFlag.pfWaitProcStart);
                    }
                    else
                    {
                        StateChange(TStageState.ssChargeDis, TProcessFlag.pfWaitContactTestNG);
                    }
                }
                else
                {
                    StateChange(TStageState.ssChargeDis, TProcessFlag.pfWaitContactTestNG);
                    GlobalFunction.AlarmLogAdd(FStageNo, "接触测试数据收取失败");
                    return;
                }
            }
            else if (RealTimeData.ContactTestFlag != TContactTestFlag.Init)
            {
                StateChange(TStageState.ssChargeDis, TProcessFlag.pfWaitContactTestNG);
                GlobalFunction.AlarmLogAdd(FStageNo, "接触测试启动失败");
            }
        }

        /// <summary>
        /// 接触测试电芯状态检测
        /// </summary>
        /// <param name="ContactTestResultData"></param>
        /// <returns></returns>
        public bool CheckContactTestResultData(TContactTestResultData ContactTestResultData)
        {
            int Count = 0;
            List<int> CellErrorCount = new();
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                if (TrayInfo.ChnState[ChnNo] != 0x60 && TrayInfo.ChnState[ChnNo] != 0x61)
                {
                    if (ContactTestResultData.ChannelContactTestResultData[ChnNo].ChnState != 0x00)
                    {
                        CellErrorCount.Add(ChnNo);
                        TrayInfo.ChnState[ChnNo] = ContactTestResultData.ChannelContactTestResultData[ChnNo].ChnState;
                    }
                    Count++;
                }
            }

            bool result = true;
            if (CellErrorCount.Count == Count)
            {
                result = false;
                TrayInfo.NG_COUNT = CellErrorCount.Count;
                GlobalFunction.AlarmLogAdd(FStageNo, "接触测试全盘NG");
            }
            else if (CellErrorCount.Count > ProcessGroup.DeviceNGLimit)
            {
                result = false;
                TrayInfo.NG_COUNT = CellErrorCount.Count;
                ManualAllChannelControl(TControlCommand.Stop);
                GlobalParams.CommMCU[FStageID].SystemOnOff(0xAA);
                GlobalFunction.AlarmLogAdd(FStageNo, "接触测试NG电池数量超出限制", "NG上限 " + ProcessGroup.DeviceNGLimit + "    NG电芯 " + CellErrorCount.Count);
            }

            if (!result)
            {
                for (int i = 0; i < CellErrorCount.Count; i++)
                {
                    GlobalDefine.DeviceNGCount.NGCount[FStageID][CellErrorCount[i]]++;
                }
                GlobalFunction.SetNGCount();
            }
            return result;
        }

        /// <summary>
        /// 流程启动
        /// </summary>
        private void StartInspection()
        {
            if (RealTimeData.WaitNext ||
                (!RealTimeData.WaitNext && RealTimeData.ProcessStatus != TProcessStatus.Running))
            {
                bool booResume = false;
                string lMessage = "";
                if (GlobalParams.CommMCU[FStageID].ChannelControl(ToChannelControl(TControlCommand.Resume)))
                {
                    //启动发送开始 
                    for (int i = 0; i < 20; i++)
                    {
                        if (ProcessFlag != TProcessFlag.pfWaitProcStart || StageState != TStageState.ssWait)
                            return;

                        Thread.Sleep(1000);
                        RefreshRealData();
                        if (RealTimeData.ProcessStatus == TProcessStatus.Running)
                        {
                            //启动成功 
                            booResume = true;
                            StateChange(TStageState.ssRunning, ManualAutoFlag ? TProcessFlag.pfAutoInProc : TProcessFlag.pfManualInProc);
                            OperationRecords.WriteOperatingStatistic(FStageNo, "充放电");
                            break;
                        }
                        else
                        {
                            lMessage = "流程启动超时。";
                        }
                    }
                    if (!booResume)
                    {
                        StateChange(TStageState.ssOverTime, TProcessFlag.pfWaitProcStartNG);
                        GlobalFunction.AlarmLogAdd(FStageNo, "流程启动超时", lMessage);
                    }
                }
                else
                {
                    StateChange(TStageState.ssOverTime, TProcessFlag.pfWaitProcStartNG);
                }
            }
            else
            {
                StateChange(TStageState.ssRunning, ManualAutoFlag ? TProcessFlag.pfAutoInProc : TProcessFlag.pfManualInProc);
            }
        }

        /// <summary>
        /// 检测运行状态  结束、转步
        /// </summary>
        private void StepControl()
        {
            if (StepNo != RealTimeData.StepNo - 1)
            {
                StepNo = RealTimeData.StepNo - 1;
            }
            //结束处理
            if (RealTimeData.ProcessStatus == TProcessStatus.Stop)
            {
                SaveRealTimeData(true);
                StateChange(StageState, TProcessFlag.pfAutoProcEnd);
            }
            //转步处理 WGL 2023.03.09
            else if (RealTimeData.WaitNext || RealTimeData.ProcessStatus == TProcessStatus.Suspend)
            {
                StateChange(TStageState.ssWait, TProcessFlag.pfWaitProcStart);
            }
        }

        /// <summary>
        /// 离线数据保存
        /// </summary>
        public void OfflineData()
        {
            TOfflineStateMCU OfflineStateMCU = new();
            if (GlobalParams.CommMCU[FStageID].OfflineState(ref OfflineStateMCU))
            {
                if (OfflineStateMCU.Flag == 0x55 && OfflineStateMCU.OfflineFileCount > 0)
                {
                    TSwitchModeMCU switchMode = new()
                    {
                        InOut = 1,
                        WorkModeMCU = 4,
                    };
                    if (GlobalParams.CommMCU[FStageID].SwitchMode(switchMode))
                    {
                        Thread.Sleep(3000);
                        int ErrorCount = 0;
                        for (int i = 0; i < OfflineStateMCU.OfflineFileCount; i++)
                        {
                            List<TRealTimeDataSave> RealTimeDataSaves = new();
                            if (GlobalParams.CommMCU[FStageID].OfflineData(ref RealTimeDataSaves, i))
                            {
                                foreach (var item in RealTimeDataSaves)
                                    saveRealTimeDatas.Add(item);
                            }
                            else
                            {
                                GlobalFunction.AlarmLogAdd(FStageNo, "离线数据收取错误");
                                if (ErrorCount < 3)
                                {
                                    ErrorCount++;
                                    i--;
                                }
                            }
                        }
                        DatabaseOperations.RealTimeDataINSERT(DBPath, FStageNo, saveRealTimeDatas);
                    }
                    switchMode.InOut = 0;
                    GlobalParams.CommMCU[FStageID].SwitchMode(switchMode);
                }
            }
        }

        /// <summary>
        /// 结果数据保存
        /// </summary>
        public bool SaveRecResultData()
        {
            int ResultFileCount = RealTimeData.ResultFileCount;
            for (int i = 0; i < ResultFileCount; i++)
            {
                TResultDataMCU ResultDataMCU = new();
                if (GlobalParams.CommMCU[FStageID].RecResultData(ref ResultDataMCU, (short)(i + 1)))
                {
                    TResultData ResultData = TStructConvert.ConvertTResultData(ResultDataMCU, i + 1, TrayInfo.STARTIME);
                    foreach (TChannelResultData Data in ResultData.ChannelResultData)
                    {
                        //if (Data.ChnNo != 0)
                        saveResultDatas.Add(Data);
                    }
                }
                else
                {
                    StateChange(TStageState.ssPCAlarm, TProcessFlag.pfEndNG);
                    return false;
                }
                Thread.Sleep(200);
            }
            if (DatabaseOperations.ResultDataINSERT(DBPath, FStageNo, saveResultDatas, TRAYNOOld))
            {
                int StepNoListCount = saveResultDatas.Where(x => x.StepNo == ProcessGroup.Process.StepCount).ToList().Count;
                saveResultDatas.Clear();

                TrayInfo.ENDTIME = DateTime.Now;
                if (ProcessFlag == TProcessFlag.pfAutoProcEnd)
                {
                    TrayInfo.AutoEnd = true;

                    if (StepNoListCount == 0)
                    {
                        GlobalFunction.AlarmLogAdd(FStageNo, "关键数据不全", "<" + TrayInfo.TRAY_NO + ">流程异常结束导致，关键数据不全");
                        return false;
                    }
                }

                if (ManualReservationFlag)
                {
                    ManualAutoFlag = false;
                    GlobalDefine.ManualAutoFlags[FStageID] = false;
                }

                if (ManualAutoFlag && ProcessFlag == TProcessFlag.pfAutoProcEnd)
                {
                    if (!SqlServerData.DataWrite(DBPath, DeviceType))
                    {
                        GlobalFunction.AlarmLogAdd(FStageNo, "数据上传失败", "<" + TrayInfo.TRAY_NO + ">数据上传失败");
                        return false;
                    }
                }

                saveResultDatas.Clear();
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    if (!(new byte[] { 0x60, 0x61 }).Contains(TrayInfo.ChnState[ChnNo]))
                        GlobalDefine.DeviceNGCount.RunCount[FStageID][ChnNo]++;
                }
                DatabaseOperations.TrayInfoUpdate(DBPath, FStageNo, TrayInfo);
                DatabaseOperations.CellTestRecordDataUpdate(FStageNo, TrayInfo);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 流程结束
        /// </summary>
        public void InspectionEnd()
        {
            Thread.Sleep(2000);
            OfflineData();

            if (EnvData.CylinderStatorState == TCylinderStatorState.dsDock)
            {
                ManualAllChannelControl(TControlCommand.Stop);
                GlobalParams.CommMCU[FStageID].SystemOnOff(0xAA);//汽缸张开
                GlobalParams.CommMCU[FStageID].CylinderStatorControl(0xAA);//汽缸张开
            }

            if (SaveRecResultData())
            {
                StateChange(TStageState.ssProcessEnd, ProcessFlag);
                SetNGCount();
            }
            else
            {
                StateChange(TStageState.ssPCAlarm, TProcessFlag.pfEndNG);
                //数据保存失败
            }
        }

        /// <summary>
        /// 更新NG状态
        /// </summary>
        public void SetNGCount()
        {
            if (GlobalDefine.OperationMode)
            {
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    if ((TrayInfo.ChnState[ChnNo] == 0x60) || (TrayInfo.ChnState[ChnNo] == 0x61) || (TrayInfo.ChnState[ChnNo] == 0x00))
                    {
                        continue;
                    }
                    else
                    {
                        GlobalDefine.DeviceNGCount.NGCount[FStageID][ChnNo]++;
                    }
                }
                GlobalFunction.SetNGCount();
            }
        }

        /// <summary>
        /// 上位机通道状态
        /// </summary>
        /// <returns></returns>
        public bool ChannelProtectPC(byte[] bytes)
        {
            TChannelProtect ChannelProtect = new()
            {
                PosSelected = bytes
            };
            if (GlobalParams.CommMCU[FStageID].SendChnState(ChannelProtect))
            {
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    TrayInfo.ChnState[ChnNo] = ChannelProtect.PosSelected[ChnNo];
                Thread.Sleep(50);
                return true;
            }
            else
            { return false; }
        }

        #endregion

        #region //保存数据

        /// <summary>
        /// 保存实时数据 120秒或30条数据保存一次
        /// </summary>
        /// <param name="b">是否强制保存</param>
        private void SaveRealTimeData(bool b = false)
        {
            TimeSpan Savetime = DateTime.Now - SaveDataTime;
            TimeSpan Addtime = DateTime.Now - AddDataTime;
            int SaveSeconds = Savetime.Hours * 3600 + Savetime.Minutes * 60 + Savetime.Seconds;
            int AddSeconds = Addtime.Hours * 3600 + Addtime.Minutes * 60 + Addtime.Seconds;


            bool CurreVoltInterval = false;


            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                if (Math.Abs(RealTimeData.ChannelRealTimeData[ChnNo].Volt - RealTimeDataOld.ChannelRealTimeData[ChnNo].Volt) > GlobalDefine.VoltInterval ||
                    Math.Abs(RealTimeData.ChannelRealTimeData[ChnNo].Curre - RealTimeDataOld.ChannelRealTimeData[ChnNo].Curre) > GlobalDefine.CurreInterval)
                {
                    CurreVoltInterval = true;
                    break;
                }
            }

            List<int> StatusChange = new();
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                if (RealTimeData.ChannelRealTimeData[ChnNo].ProcessStatus != RealTimeDataOld.ChannelRealTimeData[ChnNo].ProcessStatus)
                    StatusChange.Add(ChnNo);
            }

            if (AddSeconds >= GlobalDefine.UpdateInterval ||
                (RealTimeData.ProcessStatus == TProcessStatus.Suspend || RealTimeData.ProcessStatus == TProcessStatus.Stop) ||
                CurreVoltInterval || StatusChange.Count > 0)
            {
                if (RealTimeData.ProcessStatus != TProcessStatus.Init && RealTimeData.ProcessStatus != TProcessStatus.Stop)
                {
                    TSaveEnvData saveEnv = new()
                    {
                        ATemp = EnvData.MechanicalTempValue,
                    };
                    //SaveDataLastID++;
                    TRealTimeDataSave Data = SaveStructData.RealTimeDataSave(RealTimeData, saveEnv);
                    for (int i = 0; i < StatusChange.Count; i++)
                    {
                        Data.ChannelRealTimeData[i].ProcessStatus = RealTimeDataOld.ChannelRealTimeData[i].ProcessStatus;
                    }
                    saveRealTimeDatas.Add(Data);
                    AddDataTime = DateTime.Now;
                }
            }

            if (SaveSeconds > Constants.ThreadStage.TIME_INTERVAL_DATASAVE || (saveRealTimeDatas.Count > Constants.ThreadStage.DATA_COUNT_SAVE) || b)
            {
                //数据保存失败，报警
                if (!DatabaseOperations.RealTimeDataINSERT(DBPath, FStageNo, saveRealTimeDatas))
                {
                    saveRealTimeDatas.Clear();
                    SaveDataTime = DateTime.Now;
                    StateChange(TStageState.ssPCAlarm, ProcessFlag);
                }
                else
                {
                    saveRealTimeDatas.Clear();
                    SaveDataTime = DateTime.Now;
                }
            }
        }
        #endregion

        #region//取出托盘
        /// <summary>
        /// 通知取出托盘
        /// </summary>

        bool UploadWarehouseTestResult = false;
        bool RequestReleasePull = false;

        public void CheckTrayOut(bool boo强制出库 = false)
        {
            if ((EnvData.FireDoorL == TDoorState.dsDock && EnvData.FireDoorR == TDoorState.dsDock && !EnvData.ShieldedFireDoorSensor) || EnvData.ShieldedFireDoorSensor)
            {
                //通知下位机流程结束
                if (EnvData.CylinderStatorState == TCylinderStatorState.dsDock && EnvDataOld.CylinderStatorState == TCylinderStatorState.dsDock)
                {
                    ManualAllChannelControl(TControlCommand.Stop);
                    GlobalParams.CommMCU[FStageID].SystemOnOff(0xAA);
                }

                //自动模式通知MES取走托盘
                if ((ManualAutoFlag && ProcessFlag == TProcessFlag.pfAutoProcEnd) || boo强制出库)
                {
                    if (EnvData.CylinderStatorState != TCylinderStatorState.dsUndock)
                    {
                        Thread.Sleep(5000);
                        return;
                    }
                    if (EnvData.CylinderStatorState == TCylinderStatorState.dsUndock && EnvData.AutoDoorState == TDoorState.dsNull && EnvData.MechanicalWorkSate == TMechanicalWorkSate.Completion)
                    {
                        if (!UploadWarehouseTestResult)
                        {
                            //UploadWarehouseTestResult只能调用一次 
                            if (HttpWMS.UploadWarehouseTestResult(Col, Layer))
                            {
                                UploadWarehouseTestResult = true;
                                StateChange(TStageState.ssWaitOutbound, ProcessFlag);
                            }
                        }
                    }
                }
            }
        }

        private void Outbound()
        {
            //通知Mes，堆垛机取出托盘
            if (!RequestReleasePull)
            {
                //RequestReleasePull只能调用一次 
                if (HttpWMS.RequestReleasePull(Col, Layer, TrayInfo.TRAY_NO))
                {
                    RequestReleasePull = true;
                }
            }
            if (EnvData.CylinderStatorState == TCylinderStatorState.dsUndock &&
            EnvData.TrayState == TTrayState.dsUndock &&
            EnvData.ForkState == TForkState.fsUndock)
            {
                DBPath = "";
                TrayInfo = new();
                Alarm = false;
                StateChange(TStageState.ssInit, TProcessFlag.pfInit);
            }
        }
        #endregion

        #region //断电恢复
        public void Continue()
        {
            StateChange(TStageState.ssPowerDown, TProcessFlag.pfWaitContinue);
        }

        /// <summary>
        /// 断电恢复
        /// </summary>
        public void ContinueInspection()
        {
            if (ProcessFlag == TProcessFlag.pfWaitContinue)
            {
                /*
                //恢复前负压控制 WGL 2023.03.09
                if (!NegatPreTest())
                {
                    //断电恢复前负压控制失败
                    return;
                };
                */
                if (EnvData.ForkState == TForkState.fsDock)
                {
                    StateChange(TStageState.ssEMG, TProcessFlag.pfWaitContinueNG);
                    GlobalFunction.AlarmLogAdd(FStageNo, "断电恢复失败", "货叉传感器被挡住");
                    return;
                }

                if (GlobalParams.CommMCU[FStageID].SystemOnOff(0x55))
                {
                    bool b = false;
                    for (int i = 0; i < 20; i++)
                    {
                        if (ProcessFlag != TProcessFlag.pfWaitContinue || StageState != TStageState.ssPowerDown)
                            return;
                        RefreshEnvData();
                        Thread.Sleep(2000);
                        if (EnvData.CylinderStatorState == TCylinderStatorState.dsDock)
                        {
                            b = true;
                            break;
                        }
                    }
                    if (!b)
                    {
                        StateChange(TStageState.ssEMG, TProcessFlag.pfWaitContinueNG);
                        GlobalFunction.AlarmLogAdd(FStageNo, "断电恢复失败", "系统启动失败");
                        return;
                        //断电恢复失败
                    }
                }
                else
                {
                    StateChange(TStageState.ssEMG, TProcessFlag.pfWaitContinueNG);
                    GlobalFunction.AlarmLogAdd(FStageNo, "断电恢复失败", "系统启动失败");
                    return;
                }
                if (GlobalParams.CommMCU[FStageID].PowerFailControl(0x55))
                {
                    bool b = false;
                    for (int i = 0; i < 20; i++)
                    {
                        if (ProcessFlag != TProcessFlag.pfWaitContinue || StageState != TStageState.ssPowerDown)
                            return;

                        Thread.Sleep(2000);
                        RefreshRealData();
                        if (RealTimeData.ProcessStatus == TProcessStatus.Running)
                        {
                            b = true;
                            StateChange(TStageState.ssRunning, ManualAutoFlag ? TProcessFlag.pfAutoInProc : TProcessFlag.pfManualInProc);
                            GlobalFunction.RunLogAdd(FStageNo, "断电恢复成功");
                            break;
                        }
                    }
                    if (!b)
                    {
                        StateChange(TStageState.ssEMG, TProcessFlag.pfWaitContinueNG);
                        GlobalFunction.AlarmLogAdd(FStageNo, "断电恢复失败");
                    }
                }
                else
                {
                    StateChange(TStageState.ssEMG, TProcessFlag.pfWaitContinueNG);
                    GlobalFunction.AlarmLogAdd(FStageNo, "断电恢复失败");
                }
            }
        }

        #endregion

        /// <summary>
        /// 手动流程
        /// </summary>
        /// <param name="ProcessGroup"></param>
        /// <param name="trayInfo"></param>
        /// <returns></returns>
        public bool GainProcess(TProcessGroup ProcessGroup, TTrayInfo TrayInfo, ref string strMes)
        {
            if (GlobalDefine.OperationMode && !(StageState == TStageState.ssTrayIn || StageState == TStageState.ssProcessEnd))
            {
                strMes = "当前设备状态不能发送流程。";
                return false;
            }
            if (GlobalDefine.ProcessFlagInProc.Contains(ProcessFlag))
            {
                strMes = "流程已开始。";
                return false;
            }
            if (GlobalDefine.OperationMode && EnvData.ForkState == TForkState.fsDock)
            {
                strMes = "货叉传感器被挡住，禁止发送流程。";
                return false;
            }
            if (GlobalDefine.OperationMode && (EnvData.TrayState != TTrayState.dsDock || EnvData.CylinderStatorState == TCylinderStatorState.dsRunning))
            {
                strMes = "设备中托盘位置错误，或托盘处于运动中 。";
                return false;
            }
            if ((EnvData.FireDoorL == TDoorState.dsNull || EnvData.FireDoorR == TDoorState.dsNull) && !EnvData.ShieldedFireDoorSensor)
            {
                strMes = "安全门已打开，不能发送流程。";
                return false;
            }
            if (StageState == TStageState.ssPowerDown)
            {
                strMes = "设备有掉电标记。";
                return false;
            }
            StateChange(TStageState.ssReady, TProcessFlag.pfReady);

            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                ProcessGroup.Process.PosSelected[ChnNo] = TrayInfo.ChnState[ChnNo] == 0x00;

            this.TrayInfo = TrayInfo;
            this.ProcessGroup = ProcessGroup;
            return true;
        }

        bool Alarm = false;
        string SZB_STATUS_DATAParam4 = string.Empty;
        public void StateChange(TStageState tStageState, TProcessFlag tProcessFlag)
        {
            switch (tStageState)
            {
                case TStageState.ssEMG:
                case TStageState.ssPCAlarm:
                case TStageState.ssTemp:
                case TStageState.ssSmoke:
                case TStageState.ssOverTime:
                case TStageState.ssChargeDis:
                    //case TStageState.ssTrayError: 
                    ManualAllChannelControl(TControlCommand.Stop);
                    Thread.Sleep(1000);
                    GlobalParams.CommMCU[FStageID].SystemOnOff(0xAA);
                    if (!Alarm)
                    {
                        Alarm = true;
                        SaveRealTimeData(true);
                        SaveRecResultData();
                    }
                    break;
                default:
                    break;
            }

            ProcessFlag = tProcessFlag;
            StageState = tStageState;
            SerializeStage();
        }

        /// <summary>
        /// 通道控制
        /// </summary>
        /// <param name="control"></param>
        /// <param name="ChN"></param>
        public void ManualAllChannelControl(TControlCommand control, int ChN = 999)
        {
            if (ProcessFlag != TProcessFlag.pfInit)
                GlobalParams.CommMCU[FStageID].ChannelControl(ToChannelControl(control, ChN));
        }

        public TChannelControl ToChannelControl(TControlCommand command, int ChN = 999)
        {
            TChannelControl ChannelControl = new()
            {
                ControlCommand = command,
                //OperationMode = OperationMode ? TOperationMode.Production : TOperationMode.Test,
                OperationMode = TOperationMode.Production,
            };
            if (ChN == 999)
            {
                for (int i = 0; i < TrayInfo.ChnState.Length; i++)
                    ChannelControl.PosSelected[i] = TrayInfo.ChnState[i] == 0x00;
            }
            else
            {
                ChannelControl.PosSelected[ChN] = TrayInfo.ChnState[ChN] == 0x00;
            }
            return ChannelControl;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void StateInit()
        {
            if (EnvData.DeviceOnOff)
            {
                ManualAllChannelControl(TControlCommand.Stop);
                GlobalParams.CommMCU[FStageID].SystemOnOff(0xAA);
                GlobalParams.CommMCU[FStageID].AlarmClear(0x01);
                GlobalParams.CommMCU[FStageID].PowerFailControl(0xAA);

                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    if (!new byte[] { 0x60, 0x61, 0x00 }.Contains(TrayInfo.ChnState[ChnNo]))
                        TrayInfo.ChnState[ChnNo] = 0x00;
                Alarm = false;
                StateChange(TStageState.ssInit, TProcessFlag.pfInit);
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// 重新作业
        /// </summary>
        public bool ReAssignment(ref string strMes)
        {
            TrayInfo.STARTIME = DateTime.Now;
            TrayInfo.AutoFlag = ManualAutoFlag;
            TRAYNOOld = "";

            if (GlobalDefine.ProcessFlagInProc.Contains(ProcessFlag))
            {
                strMes = "流程已开始";
                return false;
            }
            if (ManualAutoFlag)
            {
                StateChange(TStageState.ssTrayIn, ProcessFlag);
                return true;
            }
            else
            {
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    if (!new byte[] { 0x60, 0x61, 0x00 }.Contains(TrayInfo.ChnState[ChnNo]))
                        TrayInfo.ChnState[ChnNo] = 0x00;
                return GainProcess(ProcessGroup, TrayInfo, ref strMes);
            }
        }

        /// <summary>
        /// 停止流程
        /// </summary>
        public void StopJob()
        {
            ManualAllChannelControl(TControlCommand.Stop);
            Thread.Sleep(1000);
            ProcessFlag = TProcessFlag.pfManualProcEnd;
        }

        /// <summary>
        /// 保存状态 保存当前结构体数据
        /// </summary> 
        public void SerializeStage()
        {
            lock (this)
            {
                try
                {
                    if (File.Exists(GlobalDefine.StagePath + FStageID + ".dat"))
                        File.Delete(GlobalDefine.StagePath + FStageID + ".dat");
                    SerializeFile.FileSerialize(GlobalDefine.StagePath + FStageID + ".dat", this);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("1042:" + ex.Message);
                    GlobalFunction.ErrorLogAdd(FStageNo, "保存设备数据异常", ex.Message);
                }
            }
        }

        /// <summary>
        /// 停止线程
        /// </summary> 
        public void StopStage()
        {
            FRunFlag = false;
            SerializeStage();
        }
    }
}