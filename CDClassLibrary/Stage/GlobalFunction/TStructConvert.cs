namespace CDClassLibrary.Stage
{
    public class TStructConvert
    {
        public static byte[] BitTobytes(bool[] bools)
        {
            byte[] bytes = new byte[bools.Length / 8];
            for (var i = 0; i < bytes.Length; i++)
            {
                byte result = 0;
                byte current = 1;
                for (int j = 0; j < 8; j++)
                {
                    if (bools[i * 8 + j])
                    {
                        result += current;
                    }
                    current *= 2;
                }
                bytes[i] = result;
            }
            return bytes;
        }

        public static int BitToint(bool[] bools)
        {
            byte[] bytes = new byte[4];
            for (var i = 3; i >= 0; i--)
            {
                byte result = 0;
                byte current = 1;
                for (int j = 0; j < 8; j++)
                {
                    if (bools[i * 8 + j])
                    {
                        result += current;
                    }
                    current *= 2;
                }
                bytes[i] = result;
            }
            return (int)BitConverter.ToUInt32(bytes, 0);
        }

        public static bool[] IntTobit(int Valew)
        {
            char[] chars = Convert.ToString(Valew, 2).PadLeft(32, '0').ToCharArray();
            bool[] b = new bool[32];
            for (int i = 31; i >= 0; i--)
            {
                b[i] = chars[i] == '1';
            }
            return b;
        }

        /// <summary>
        /// 毫秒
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="TdateTime"></param>
        /// <returns></returns>
        public static int BytesToDateTimeToInt(byte[] bytes, DateTime TdateTime)
        {
            string time = $"{bytes[9] * 256 + bytes[8]:0000}-{bytes[6]:00}-{bytes[5]:00} {bytes[4]:00}:{bytes[3]:00}:{bytes[2]:00}.{bytes[2] * 256 + bytes[1]:000}";
            if (time != "0000-00-00 00:00:00.000")
            {
                DateTime dateTime = Convert.ToDateTime(time);
                return TimeSpanTime(dateTime, TdateTime);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// date1-date2 毫秒 绝对值
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public static int TimeSpanTime(DateTime date1, DateTime date2)
        {
            TimeSpan time = date1 - date2;
            int N = time.Days * 24 * 3600 * 1000 + time.Hours * 3600 * 1000 + time.Minutes * 60 * 1000 + time.Seconds * 1000 + time.Milliseconds;
            return Math.Abs(N);
        }

        /// <summary>
        /// int转Time(00:00:00:000)
        /// </summary>
        /// <param name="Valew">毫秒</param>
        /// <returns></returns>
        public static string IntToTime(int Valew)
        {
            int DateF = Valew % 1000;
            Valew /= 1000;
            int DateH = Valew / 3600;
            int Datem = Valew % 3600 / 60;
            int Dates = Valew % 60;
            string time = $"{DateH:00}:{Datem:00}:{Dates:00}.{DateF:000}";
            return time;
        }

        public static TProcessMCU ConvertTProcessMCU(TProcess Process)
        {
            TChargeProtectMCU ChargeProtectMCU = new()
            {
                CapacityUpperLimit = (int)(Process.ChargeProtect.CapacityUpperLimit * 100),
                CCLackTime = Process.ChargeProtect.CCLackTime,
                CCOverTime = Process.ChargeProtect.CCOverTime,
                CheckTime = Process.ChargeProtect.CheckTime,
                CheckVoltUpperLimit = (int)(Process.ChargeProtect.CheckVoltUpperLimit * 100),
                ConstVoltDeviate = (int)(Process.ChargeProtect.ConstVoltDeviate * 100),
                CurreLowerLimit = (int)(Process.ChargeProtect.CurreLowerLimit * 100),
                CurreRiseContinueCount = Process.ChargeProtect.CurreRiseContinueCount,
                CurreRiseCumulateCount = Process.ChargeProtect.CurreRiseCumulateCount,
                CurreRiseLimit = (int)(Process.ChargeProtect.CurreRiseLimit * 100),
                CurreSwell = (int)(Process.ChargeProtect.CurreSwell * 100),
                IsValidFlag = BitToint(Process.ChargeProtect.IsValidFlag),
                NoVoltRiseLimit = (int)(Process.ChargeProtect.NoVoltRiseLimit * 100),
                NoVoltRiseTime = Process.ChargeProtect.NoVoltRiseTime,
                ReserveNull = new byte[8],
                SwellVoltRiseLimit = (int)(Process.ChargeProtect.SwellVoltRiseLimit * 100),
                SwellVoltRiseTime = Process.ChargeProtect.SwellVoltRiseTime,
                T1VoltLowerLimit = (int)(Process.ChargeProtect.T1VoltLowerLimit * 100),
                T1Time = Process.ChargeProtect.T1Time,
                T1VoltUpperLimit = (int)(Process.ChargeProtect.T1VoltUpperLimit * 100),
                T2VoltLowerLimit = (int)(Process.ChargeProtect.T2VoltLowerLimit * 100),
                T2Time = (int)(Process.ChargeProtect.T2Time * 100),
                T2VoltUpperLimit = (int)(Process.ChargeProtect.T2VoltUpperLimit * 100),
                T5CurreLowerLimit = (int)(Process.ChargeProtect.T5CurreLowerLimit * 100),
                T5CurreUpperLimit = (int)(Process.ChargeProtect.T5CurreUpperLimit * 100),
                T5Time = Process.ChargeProtect.T5Time * 100,
                TimeLimit = Process.ChargeProtect.TimeLimit * 100,
                VoltDropContinueCount = Process.ChargeProtect.VoltDropContinueCount * 100,
                VoltDropCumulateCount = Process.ChargeProtect.VoltDropCumulateCount * 100,
                VoltDropLimit = (int)(Process.ChargeProtect.VoltDropLimit * 100),
                VoltLowerLimit = (int)(Process.ChargeProtect.VoltLowerLimit * 100),
                VoltUpperLimit = (int)(Process.ChargeProtect.VoltUpperLimit * 100),
            };

            TDisChargeProtectMCU DisChargeProtectMCU = new()
            {
                CapacityLowerLimit = (int)(Process.DisChargeProtect.CapacityLowerLimit * 100),
                CapacityUpperLimit = (int)(Process.DisChargeProtect.CapacityUpperLimit * 100),
                CheckTime = Process.DisChargeProtect.CheckTime,
                CheckVoltLowerLimit = (int)(Process.DisChargeProtect.CheckVoltLowerLimit * 100),
                CheckVoltUpperLimit = (int)(Process.DisChargeProtect.CheckVoltUpperLimit * 100),
                ConnectVoltDeviate = (int)(Process.DisChargeProtect.ConnectVoltDeviate * 100),
                ConnectVoltToolarge = (int)(Process.DisChargeProtect.ConnectVoltToolarge * 100),
                CurreDeviate = (int)(Process.DisChargeProtect.CurreDeviate * 100),
                IsValidFlag = BitToint(Process.DisChargeProtect.IsValidFlag),
                NoVoltDropLimit = (int)(Process.DisChargeProtect.NoVoltDropLimit * 100),
                NoVoltDropTime = Process.DisChargeProtect.NoVoltDropTime,
                ReserveNull = new byte[56],
                SwellVoltDropLimit = ((int)Process.DisChargeProtect.SwellVoltDropLimit * 100),
                SwellVoltDropTime = Process.DisChargeProtect.SwellVoltDropTime,
                TimeLimit = Process.DisChargeProtect.TimeLimit,
                VoltLowerLimit = (int)(Process.DisChargeProtect.VoltLowerLimit * 100),
                VoltRiseContinueCount = Process.DisChargeProtect.VoltRiseContinueCount,
                VoltRiseCumulateCount = Process.DisChargeProtect.VoltRiseCumulateCount,
                VoltRiseLimit = (int)(Process.DisChargeProtect.VoltRiseLimit * 100),
                VoltUpperLimit = (int)(Process.DisChargeProtect.VoltUpperLimit * 100)
            };

            TCommonProtectMCU CommonProtectMCU = new()
            {
                CapacityUpperLimit = (int)(Process.CommonProtect.CapacityUpperLimit * 100),
                CellTempLowerLimit = (short)(Process.CommonProtect.CellTempLowerLimit * 100),
                CellTempUpperLimit = (short)(Process.CommonProtect.CellTempUpperLimit * 100),
                CellUnderVolt = (int)(Process.CommonProtect.CellUnderVolt * 100),
                CellVoltToolarge = (int)(Process.CommonProtect.CellVoltToolarge * 100),
                ChargeDisCellVoltLineDvalue = (int)(Process.CommonProtect.ChargeDisCellVoltLineDvalue * 100),
                ContactIR = (int)(Process.CommonProtect.ContactIR * 100),
                CurreDeviateLower = (int)(Process.CommonProtect.CurreDeviateLower * 100),
                CurreDeviateUpper = (int)(Process.CommonProtect.CurreDeviateUpper * 100),
                CurreFluctu = (int)(Process.CommonProtect.CurreFluctu * 100),
                CurreIntervalFluctu = (int)(Process.CommonProtect.CurreIntervalFluctu * 100),
                CurreIntervalFluctuTime = Process.CommonProtect.CurreIntervalFluctuTime * 100,
                CurreToolarge = (int)(Process.CommonProtect.CurreToolarge * 100),
                EmgStopVoltUpperLimit = (int)(Process.CommonProtect.EmgStopVoltUpperLimit * 100),
                InsteadVolt = (int)(Process.CommonProtect.InsteadVolt * 100),
                TempRiseTime = Process.CommonProtect.TempRiseTime,
                TempRiseValue = (Int16)(Process.CommonProtect.TempRiseValue * 100),
                IsValidFlag = BitToint(Process.CommonProtect.IsValidFlag),
                LineVoltToolarge = (int)(Process.CommonProtect.LineVoltToolarge * 100),
                PosTempUpperLimit = ((short)(Process.CommonProtect.PosTempUpperLimit * 100)),
                ReserveNull1 = new byte[2],
                ReserveNull2 = new byte[24],
                RESTCellLineVoltDvalue = (int)(Process.CommonProtect.RESTCellLineVoltDvalue * 100),
                RESTCurreUpperLimit = (int)(Process.CommonProtect.RESTCurreUpperLimit * 100),
                RESTVoltUpperLimit = (int)(Process.CommonProtect.RESTVoltUpperLimit * 100),
                TTime = Process.CommonProtect.TTime,
                TVoltLowerLimit = (int)(Process.CommonProtect.TVoltLowerLimit * 100),
                TVoltUpperLimit = (int)(Process.CommonProtect.TVoltUpperLimit * 100),
                VoltIntervalFluctu = (int)(Process.CommonProtect.VoltIntervalFluctu * 100),
                VoltIntervalFluctuTime = Process.CommonProtect.VoltIntervalFluctuTime,
                VoltSlump = (int)(Process.CommonProtect.VoltSlump * 100),
            };
            TProcessMCU ProcessMCU = new()
            {
                ChargeProtectMCU = ChargeProtectMCU,
                DisChargeProtectMCU = DisChargeProtectMCU,
                CommonProtectMCU = CommonProtectMCU,
                ProcessMode = Process.ProcessMode,
                CapEnCalculateMode = Process.CapEnCalculateMode,
                OperationMode = Process.OperationMode,
                StepCount = (byte)Process.StepCount,
            };
            bool[] PosSelected = new bool[600];
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                PosSelected[GlobalDefine.Mapping[ChnNo]] = Process.PosSelected[ChnNo];
            }
            ProcessMCU.PosSelected = BitTobytes(PosSelected);

            for (int i = 0; i < Process.ProcStepRec.Length; i++)
            {
                ProcessMCU.ProcStepRecMCU[i] = new TProcStepRecMCU()
                {
                    Current = (int)(Process.ProcStepRec[i].Current * 100),
                    EndCap = (int)(Process.ProcStepRec[i].EndCap * 100),
                    LimitTime1 = Process.ProcStepRec[i].LimitTime1,
                    LimitTime2 = (short)Process.ProcStepRec[i].LimitTime2,
                    LimitValue = (int)(Process.ProcStepRec[i].LimitValue * 100),
                    NextMode = Process.ProcStepRec[i].NextMode,
                    StepMode = Process.ProcStepRec[i].StepMode,
                    Voltage = (int)(Process.ProcStepRec[i].Voltage * 100),
                };
            }
            return ProcessMCU;
        }

        public static TChannelInfoMCU ConvertTChannelInfoMCU(TChannelInfo ChannelInfo)
        {
            TChannelInfoMCU ChannelInfoMCU = new();
            bool[] PosSelected = new bool[400];
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                PosSelected[GlobalDefine.Mapping[ChnNo]] = ChannelInfo.PosSelected[ChnNo];
            }
            ChannelInfoMCU.PosSelected = BitTobytes(PosSelected);

            ChannelInfoMCU.ReserveNull = new byte[10];
            return ChannelInfoMCU;
        }

        public static TContactTestProcessMCU ConvertTContactTestProcessMCU(TContactTestProcess ContactTestProcess)
        {
            TContactTestProcessMCU ContactTestProcessMCU = new()
            {
                ContactTestTime = ContactTestProcess.ContactTestTime,
                CurreDeviatePercent = (short)ContactTestProcess.CurreDeviatePercent,
                DetectVolt = (int)(ContactTestProcess.DetectVolt * 100),
                ProgramCurre = (int)(ContactTestProcess.ProgramCurre * 100),
                ProgramVolt = (int)(ContactTestProcess.ProgramVolt * 100),
                ReserveNull = new byte[2],
                ReserveNull2 = new byte[22],
                ReverbVolta = (int)(ContactTestProcess.ReverbVolta * 100),
                StepMode = 0x03,
                VoltChangeMax = (int)(ContactTestProcess.VoltChangeMax * 100),
                VoltChangeMin = (int)(ContactTestProcess.VoltChangeMin * 100),
                VoltLowerLimit = (int)(ContactTestProcess.VoltLowerLimit * 100),
                VoltUpperLimit = (int)(ContactTestProcess.VoltUpperLimit * 100)
            };
            return ContactTestProcessMCU;
        }

        public static TChannelProtectMCU ConvertTChannelProtectMCU(TChannelProtect ChannelProtect)
        {
            TChannelProtectMCU ChannelProtectMCU = new()
            {
                ReserveNull = new byte[4],
            };
            byte[] PosSelected = new byte[400];
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                PosSelected[GlobalDefine.Mapping[ChnNo]] = ChannelProtect.PosSelected[ChnNo];
            }
            ChannelProtectMCU.PosSelected = PosSelected;
            return ChannelProtectMCU;
        }

        public static TChannelControlMCU ConvertTChannelControlMCU(TChannelControl ChannelControl)
        {
            TChannelControlMCU ChannelControlMCU = new()
            {
                ControlCommand = ChannelControl.ControlCommand,
                OperationMode = ChannelControl.OperationMode,
                ReserveNull = new byte[3],
            };
            bool[] PosSelected = new bool[600];
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                PosSelected[GlobalDefine.Mapping[ChnNo]] = ChannelControl.PosSelected[ChnNo];
            }
            ChannelControlMCU.PosSelected = BitTobytes(PosSelected);
            return ChannelControlMCU;
        }

        public static TRealTimeData ConvertTRealTimeData(TRealTimeDataMCU TRealTimeDataMCU)
        {
            TChannelRealTimeData[] ChannelRealTimeData = new TChannelRealTimeData[GlobalDefine.CHANNELS];
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                TChannelRealTimeDataMCU ChannelRealTimeDataMCU = TRealTimeDataMCU.ChannelRealTimeDataMCU[GlobalDefine.Mapping[ChnNo]];
                ChannelRealTimeData[ChnNo] = new TChannelRealTimeData()
                {
                    ChnNo = ChnNo + 1,
                    Capacity = ChannelRealTimeDataMCU.Capacity / 100.0,
                    CellTemp = ChannelRealTimeDataMCU.CellTemp / 100.0,
                    ChannelTemp = ChannelRealTimeDataMCU.ChannelTemp / 100.0,
                    Curre = ChannelRealTimeDataMCU.Curre / 100.0,
                    Cycle1EndStep = ChannelRealTimeDataMCU.Cycle1EndStep,
                    Cycle1RemainCount = ChannelRealTimeDataMCU.Cycle1RemainCount,
                    Cycle1RunCount = ChannelRealTimeDataMCU.Cycle1RunCount,
                    Cycle1StartStep = ChannelRealTimeDataMCU.Cycle1StartStep,
                    Cycle2EndStep = ChannelRealTimeDataMCU.Cycle2EndStep,
                    Cycle2RemainCount = ChannelRealTimeDataMCU.Cycle2RemainCount,
                    Cycle2RunCount = ChannelRealTimeDataMCU.Cycle2RunCount,
                    Cycle2StartStep = ChannelRealTimeDataMCU.Cycle2StartStep,
                    Cycle3EndStep = ChannelRealTimeDataMCU.Cycle3EndStep,
                    Cycle3RemainCount = ChannelRealTimeDataMCU.Cycle3RemainCount,
                    Cycle3RunCount = ChannelRealTimeDataMCU.Cycle3RunCount,
                    Cycle3StartStep = ChannelRealTimeDataMCU.Cycle3StartStep,
                    Energy = ChannelRealTimeDataMCU.Energy / 100.0,
                    FanStatus = ChannelRealTimeDataMCU.FanStatus,
                    IR = ChannelRealTimeDataMCU.IR / 100.0,
                    LineVolt = ChannelRealTimeDataMCU.LineVolt / 100.0,
                    ProcessTime = ChannelRealTimeDataMCU.ProcessTime / 1000.0,
                    ProcessStatus = ChannelRealTimeDataMCU.ProcessStatus,
                    ChnState = ChannelRealTimeDataMCU.ChnState,
                    StepMode = ChannelRealTimeDataMCU.StepMode,
                    StepNo = ChannelRealTimeDataMCU.StepNo,
                    StepWorkTime = ChannelRealTimeDataMCU.StepWorkTime / 1000.0,
                    Volt = ChannelRealTimeDataMCU.Volt / 100.0
                };
            }

            TRealTimeData RealTimeData = new()
            {
                ChannelRealTimeData = ChannelRealTimeData,
                ContactTestFlag = TRealTimeDataMCU.ContactTestFlag,
                Cycle1EndStep = TRealTimeDataMCU.Cycle1EndStep,
                Cycle1RemainCount = TRealTimeDataMCU.Cycle1RemainCount,
                Cycle1RunCount = TRealTimeDataMCU.Cycle1RunCount,
                Cycle1StartStep = TRealTimeDataMCU.Cycle1StartStep,
                Cycle2EndStep = TRealTimeDataMCU.Cycle2EndStep,
                Cycle2RemainCount = TRealTimeDataMCU.Cycle2RemainCount,
                Cycle2RunCount = TRealTimeDataMCU.Cycle2RunCount,
                Cycle2StartStep = TRealTimeDataMCU.Cycle2StartStep,
                Cycle3EndStep = TRealTimeDataMCU.Cycle3EndStep,
                Cycle3RemainCount = TRealTimeDataMCU.Cycle3RemainCount,
                Cycle3RunCount = TRealTimeDataMCU.Cycle3RunCount,
                Cycle3StartStep = TRealTimeDataMCU.Cycle3StartStep,
                ResultFileCount = TRealTimeDataMCU.ResultFileCount,
                IdleTime = TRealTimeDataMCU.IdleTime / 1000.0,
                //ProcessAbsoluteTime = bytesToDateTime(TRealTimeDataMCU.ProcessAbsoluteTime),
                ProcessStatus = TRealTimeDataMCU.ProcessStatus,
                ProcessTime = TRealTimeDataMCU.ProcessTime / 1000.0,
                StepMode = TRealTimeDataMCU.StepMode,
                StepNo = TRealTimeDataMCU.StepNo,
                StepWorkTime = TRealTimeDataMCU.StepWorkTime / 1000.0,
                WaitNext = TRealTimeDataMCU.WaitNext == 1
            };
            bool[] boolPowerStatus = IntTobit(TRealTimeDataMCU.PowerStatus);
            RealTimeData.InverterState = boolPowerStatus[2];
            RealTimeData.Negative15VState = boolPowerStatus[1];
            RealTimeData.Positive15VState = boolPowerStatus[0];

            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                if (RealTimeData.ChannelRealTimeData[ChnNo].ProcessStatus == TProcessStatus.Running && RealTimeData.ChannelRealTimeData[ChnNo].StepMode != TStepMode.WAIT)
                {
                    RealTimeData.StepWorkTime = RealTimeData.ChannelRealTimeData[ChnNo].StepWorkTime;
                    break;
                }
            }

            return RealTimeData;
        }

        public static TResultData ConvertTResultData(TResultDataMCU ResultDataMCU, int DataID, DateTime STARTIME)
        {
            TResultData ResultData = new();
            for (int i = 0; i < ResultDataMCU.ChannelResultDataMCU.Length; i++)
            {
                TChannelResultDataMCU ChannelResultDataMCU = ResultDataMCU.ChannelResultDataMCU[i];
                if (ChannelResultDataMCU.ChnNo != 0)
                {
                    //int ChnNo = GlobalDefine.MappingMCU[ChannelResultDataMCU.ChnNo - 1];
                    int ChnNo = GlobalDefine.Mapping.ToList().IndexOf(ChannelResultDataMCU.ChnNo - 1);

                    ResultData.ChannelResultData[i] = new TChannelResultData()
                    {
                        DataID = DataID,
                        AvgCellTemp = ChannelResultDataMCU.AvgCellTemp / 100.0,
                        AvgEnvTemp = ChannelResultDataMCU.AvgEnvTemp / 100.0,
                        CCCVCapacity = (int)ChannelResultDataMCU.CCCVCapacity / 100.0,
                        CCTime = (int)ChannelResultDataMCU.CCTime / 1000.0,
                        ChnNo = ChnNo + 1,
                        Cycle1Count = ChannelResultDataMCU.Cycle1Count,
                        Cycle2Count = ChannelResultDataMCU.Cycle2Count,
                        Cycle3Count = ChannelResultDataMCU.Cycle3Count,
                        EndCapacity = (int)ChannelResultDataMCU.EndCapacity / 100.0,
                        EndCellTemp = ChannelResultDataMCU.EndCellTemp / 100.0,
                        EndCurre = ChannelResultDataMCU.EndCurre / 100.0,
                        EndCurreVolt = ChannelResultDataMCU.EndCurreVolt / 100.0,
                        EndEnengy = (int)ChannelResultDataMCU.EndEnengy / 100.0,
                        EndEnvTemp = ChannelResultDataMCU.EndEnvTemp / 100.0,
                        EndTime = (int)ChannelResultDataMCU.EndTime / 1000.0,
                        EndVolt = ChannelResultDataMCU.EndVolt / 100.0,
                        FiveMinCurre = ChannelResultDataMCU.FiveMinCurre / 100.0,
                        ProcessTime = (int)ChannelResultDataMCU.ProcessTime / 1000.0,
                        StartCellTemp = ChannelResultDataMCU.StartCellTemp / 100.0,
                        StartCurre = ChannelResultDataMCU.StartCurre / 100.0,
                        StartEnvTemp = ChannelResultDataMCU.StartEnvTemp / 100.0,
                        StartVolt = ChannelResultDataMCU.StartVolt / 100.0,
                        ChnState = ChannelResultDataMCU.ChnState,
                        StepMode = ChannelResultDataMCU.StepMode,
                        StepNo = ChannelResultDataMCU.StepNo,
                        StepWorkTime = BytesToDateTimeToInt(ChannelResultDataMCU.StepWorkTime, STARTIME) / 1000.0,
                        IR = 0//ChannelResultDataMCU.StepMode == TStepMode.REST ? 0 : Math.Abs(ChannelResultDataMCU.EndCurreVolt - ChannelResultDataMCU.EndVolt) / ChannelResultDataMCU.FiveMinCurre * 100000,
                    };

                    bool[] boolValidFlag = IntTobit(ChannelResultDataMCU.DataValidFlag);
                    ResultData.ChannelResultData[i].DataStartValidFlag = boolValidFlag[0];
                    ResultData.ChannelResultData[i].DataEndValidFlag = boolValidFlag[2];
                    ResultData.ChannelResultData[i].DataSuspendValidFlag = boolValidFlag[3];
                    ResultData.ChannelResultData[i].DataPowerValidFlag = boolValidFlag[4];
                    ResultData.ChannelResultData[i].DataCToVValidFlag = boolValidFlag[5];
                    ResultData.ChannelResultData[i].DataCapEnValidFlag = boolValidFlag[6];
                    ResultData.ChannelResultData[i].Data5MinCurreValidFlag = boolValidFlag[7];
                }
            }
            return ResultData;
        }

        public static TContactTestResultData ConvertTContactTestResultData(TContactTestResultDataMCU ContactTestResultDataMCU)
        {
            TContactTestResultData ContactTestResultData = new();
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                TChannelContactTestResultDataMCU ChannelContactTestResultDataMCU = ContactTestResultDataMCU.ChannelContactTestResultDataMCU[GlobalDefine.Mapping[ChnNo]];
                ContactTestResultData.ChannelContactTestResultData[ChnNo] = new TChannelContactTestResultData()
                {
                    ChnNo = ChnNo + 1,
                    ProcessTime = ContactTestResultDataMCU.ProcessTime,
                    ChnState = ChannelContactTestResultDataMCU.ChnState,
                    EndVolt = ChannelContactTestResultDataMCU.EndVolt / 100.0,
                    EndCurre = ChannelContactTestResultDataMCU.EndCurre / 100.0,
                    StartCurre = ChannelContactTestResultDataMCU.StartCurre / 100.0,
                    StartVolt = ChannelContactTestResultDataMCU.StartVolt / 100.0
                };
            }
            return ContactTestResultData;
        }

        public static TEnvData ConvertTEnvData(TEnvDataMCU EnvDataMCU)
        {
            TEnvData EnvData = new()
            {
                AirPressureState = (TAirPressureState)EnvDataMCU.AirPressureState,
                BatteryTempAlarmValue = EnvDataMCU.BatteryTempAlarmValue / 100.0,
                DeviceState = (TDeviceState)EnvDataMCU.DeviceState,
                EmgButtonState = (TEmgButtonState)EnvDataMCU.EmgButtonState,
                EtalonPowerState = (TEtalonPowerState)EnvDataMCU.EtalonPowerState,
                InverterPowerState = (TInverterPowerState)EnvDataMCU.InverterPowerState,
                McuWorkState = (TMcuWorkState)EnvDataMCU.McuWorkState,
                MechanicalTempAlarmValue = EnvDataMCU.MechanicalTempAlarmValue / 100.0,
                MechanicalWorkSate = (TMechanicalWorkSate)EnvDataMCU.MechanicalWorkSate,
                PowerFailFlag = (TPowerFailFlag)EnvDataMCU.PowerFailFlag,
                CylinderStatorState = (TCylinderStatorState)EnvDataMCU.CylinderStatorState,
                Softexpires = EnvDataMCU.Softexpires,
                SoftVersion = EnvDataMCU.SoftVersion,
                TrayState = (TTrayState)EnvDataMCU.TrayState,
                AdjustingCycleT = EnvDataMCU.AdjustingCycleT,
                BatteryAvgTempValue = EnvDataMCU.BatteryAvgTempValue / 100.0,
                CoefficientKd = EnvDataMCU.CoefficientKd / 100.0,
                CoefficientKi = EnvDataMCU.CoefficientKi / 100.0,
                CoefficientKp = EnvDataMCU.CoefficientKp / 100.0,
                FlowValveOpenValue = EnvDataMCU.FlowValveOpenValue / 100.0,
                FlowValveState = (TFlowValveState)EnvDataMCU.FlowValveState,
                TargetTempValue = EnvDataMCU.TargetTempValue / 100.0,
                ValveOpenValue = EnvDataMCU.ValveOpenValue / 100.0,
                RESETButton = (TRESETButtonStates)EnvDataMCU.InputSensorsMCU[9],
                AutoDoorState = (TDoorState)EnvDataMCU.InputSensorsMCU[15],
                WaterCooledValve = (TDoorState)EnvDataMCU.InputSensorsMCU[16],
                DoorCylinder = (TDoorState)EnvDataMCU.InputSensorsMCU[17],
                ForkState = (TForkState)EnvDataMCU.InputSensorsMCU[18],
                FireDoorL = (TDoorState)EnvDataMCU.InputSensorsMCU[19],
                FireDoorR = (TDoorState)EnvDataMCU.InputSensorsMCU[20],

                AirPressureStates = new TSensorStates[2]
                {
                    (TSensorStates)EnvDataMCU.InputSensorsMCU[12],
                    (TSensorStates)EnvDataMCU.InputSensorsMCU[13],
                },
                CylinderStatorStates = new TSensorStates[4]
                {
                    (TSensorStates)EnvDataMCU.InputSensorsMCU[4],
                    (TSensorStates)EnvDataMCU.InputSensorsMCU[5],
                    (TSensorStates)EnvDataMCU.InputSensorsMCU[6],
                    (TSensorStates)EnvDataMCU.InputSensorsMCU[7],
                },
                TrayStates = new TSensorStates[4]
                {
                    (TSensorStates)EnvDataMCU.InputSensorsMCU[0],
                    (TSensorStates)EnvDataMCU.InputSensorsMCU[1],
                    (TSensorStates)EnvDataMCU.InputSensorsMCU[2],
                    (TSensorStates)EnvDataMCU.InputSensorsMCU[3],
                }
            };

            /*
            //TrayState
            {
                if (EnvData.TrayStates[0] == TSensorStates.OK)
                {
                    if (EnvData.TrayStates[1] == TSensorStates.Null && EnvData.TrayStates[2] == TSensorStates.Null && EnvData.TrayStates[3] == TSensorStates.Null)
                    {
                        EnvData.TrayState = TTrayState.dsDock;
                    }
                    else
                    {
                        if (EnvData.ForkState == TForkState.fsUndock && EnvData.CylinderStatorState != TCylinderStatorState.dsRunning)
                            EnvData.TrayState = TTrayState.dsDockError;
                    }
                }
                else
                {
                    EnvData.TrayState = TTrayState.dsUndock;
                }
            }
            */

            for (int i = 0; i < EnvDataMCU.FanState.Length; i++)
            {
                EnvData.FanStates[i] = (TFanState)EnvDataMCU.FanState[i];
            }

            EnvData.MechanicalTempState = TTempState.asNormal;
            for (int i = 0; i < EnvDataMCU.MechanicalTempState.Length; i++)
            {
                EnvData.MechanicalTempStates[i] = (TTempState)EnvDataMCU.MechanicalTempState[i];
                if (EnvData.MechanicalTempStates[i] == TTempState.asInitError)
                    EnvData.MechanicalTempState = TTempState.asInitError;
                else if (EnvData.MechanicalTempStates[i] == TTempState.asAlarm)
                {
                    EnvData.MechanicalTempState = TTempState.asAlarm;
                    break;
                }
            }
            for (int i = 0; i < EnvData.MechanicalTempValue.Length; i++)
                EnvData.MechanicalTempValue[i] = EnvDataMCU.MechanicalTempValue[i] / 100.0;

            EnvData.SmogState = TSmogState.asNormal;
            for (int i = 0; i < EnvDataMCU.SmogState.Length; i++)
            {
                EnvData.SmogStates[i] = (TSmogState)EnvDataMCU.SmogState[i];
                if (EnvData.SmogStates[i] == TSmogState.asInitError)
                    EnvData.SmogState = TSmogState.asInitError;
                else if (EnvData.SmogStates[i] == TSmogState.asAlarm)
                {
                    EnvData.SmogState = TSmogState.asAlarm;
                    break;
                }
            }

            EnvData.SensorEMGAlarm = true;
            char[] SensorEMGStr = Convert.ToString(EnvDataMCU.SensorEMGAlarm, 2).PadLeft(32, '0').ToCharArray();
            for (int i = 0; i < 32; i++)
            {
                if (SensorEMGStr[31 - i] == '1')
                {
                    EnvData.SensorEMGAlarms.Add((TSensorsEMGFault)i);
                    EnvData.SensorEMGAlarm = false;
                }
            }

            EnvData.SeriousEMGState = true;
            char[] SeriousEMGStr = Convert.ToString(EnvDataMCU.SeriousEMGState, 2).PadLeft(32, '0').ToCharArray();
            for (int i = 0; i < 32; i++)
            {
                if (SeriousEMGStr[31 - i] == '1')
                {
                    EnvData.SeriousEMGStates.Add((TSeriousEMGFault)i);
                    EnvData.SeriousEMGState = false;
                }
            }

            char[] ShieldedSensorStr = Convert.ToString(EnvDataMCU.ShieldedSensor, 2).PadLeft(32, '0').ToCharArray();
            EnvData.ShieldedFireDoorSensor = ShieldedSensorStr[29] == '1';

            for (int i = 0; i < EnvData.InverterDataLorentz.Length; i++)
            {
                TInverterDataLorentzMCU InverterDataLorentzMCU = EnvDataMCU.InverterDataLorentzMCU[i];
                EnvData.InverterDataLorentz[i] = new TInverterDataLorentz()
                {
                    AC_Vab = InverterDataLorentzMCU.AC_Vab / 10.0,
                    AC_Vbc = InverterDataLorentzMCU.AC_Vbc / 10.0,
                    AC_Vca = InverterDataLorentzMCU.AC_Vca / 10.0,
                    AmpDC_V = InverterDataLorentzMCU.AmpDC_V / 10.0,
                    AmpTemp = InverterDataLorentzMCU.AmpTemp / 10.0,
                    Amp_C1 = InverterDataLorentzMCU.Amp_C1 / 10.0,
                    Amp_C2 = InverterDataLorentzMCU.Amp_C2 / 10.0,
                    ComState = (TComState)InverterDataLorentzMCU.ComState,
                    DataValidflag = InverterDataLorentzMCU.DataValidflag,
                    DateDVersion = InverterDataLorentzMCU.DateDVersion,
                    DateMVersion = InverterDataLorentzMCU.DateMVersion,
                    DateYVersion = InverterDataLorentzMCU.DateYVersion,
                    HardwareVersion = InverterDataLorentzMCU.HardwareVersion,
                    HardwareVersionID = (int)InverterDataLorentzMCU.HardwareVersionID,
                    InverterAlarm = new TInverterAlarm(InverterDataLorentzMCU.InverterAlarm),
                    InverterState = new TInverterStateLorentz(InverterDataLorentzMCU.InverterState),
                    PreAmpTemp = InverterDataLorentzMCU.PreAmpTemp / 10.0,
                    SoftwareVersion = InverterDataLorentzMCU.SoftwareVersion,
                    SoftwareVersionID = (int)InverterDataLorentzMCU.SoftwareVersionID,
                };
            }

            for (int i = 0; i < EnvData.CumulativeCANRxRrrorCount.Length; i++)
                EnvData.CumulativeCANRxRrrorCount[i] = EnvDataMCU.CumulativeCANRxRrrorCount[i];
            for (int i = 0; i < EnvData.CumulativeCANTxRrrorCount.Length; i++)
                EnvData.CumulativeCANTxRrrorCount[i] = EnvDataMCU.CumulativeCANTxRrrorCount[i];

            EnvData.DeviceOnOff = true;
            return EnvData;
        }
    }
}