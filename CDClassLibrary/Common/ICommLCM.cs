using CDClassLibrary.Stage;
using CDClassLibrary.Stage.GlobalStruct;
using System.Runtime.InteropServices;

namespace CDClassLibrary.Common
{
    /// <summary>
    /// 操控板通信
    /// </summary>
    [Serializable]
    public class ICommMCU
    {
        private readonly string IP;
        private readonly TCPSocketClient CPSocketClient;
        private readonly object thisLock = new();
        private readonly string FStageNo;

        public ICommMCU(string FStageNo, string IP, int Port = 8000)
        {
            this.IP = IP;
            this.FStageNo = FStageNo;
            CPSocketClient = new TCPSocketClient(IP, Port);
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void CloseConn()
        {
            if (CPSocketClient.clientSocket == null)
                return;
            if (CPSocketClient.clientSocket.Connected)
                CPSocketClient.Close();
        }

        public bool IsConnected()
        {
            if (CPSocketClient.clientSocket == null)
                return CPSocketClient.Ping();
            else
                return CPSocketClient.clientSocket.Connected || CPSocketClient.Ping();
        }

        private bool SendCommandMCU(ushort Cmd, byte[] sendValues, ref byte[] recValues, int recLen, string LType, int ReceiveTime = 0)
        {
            string StrIP = $"TCP异常[{Cmd}][{IP}]：";
            string message = "";
            lock (thisLock)
            {
                MsgBody aa = new(Cmd, sendValues);
                byte[] sendBytes = aa.ToByteArray();
                byte[] recBytes = new byte[12];
                bool result = true;
                try
                {
                    for (int i = 0; i < Constants.CommMcu.COUNT_CMDAPPLY; i++)
                    {
                        //检查连接
                        if (CPSocketClient.clientSocket == null || !CPSocketClient.clientSocket.Connected)
                        {
                            if (!CPSocketClient.Ping())
                            {
                                message = StrIP + "Ping Failure";
                                CPSocketClient.Close();
                                result = false;
                                continue;
                            }
                            if (!CPSocketClient.Open())
                            {
                                message = StrIP + "Connect Failure";
                                CPSocketClient.Close();
                                result = false;
                                continue;
                            }
                        }
                        //发送数据
                        if (!CPSocketClient.Send(sendBytes))
                        {
                            message = StrIP + "Send Failure " + CPSocketClient.clientSocket.LocalEndPoint.ToString();
                            CPSocketClient.Close();
                            result = false;
                            continue;
                        }

                        Thread.Sleep(ReceiveTime);
                        //接收数据
                        if (!CPSocketClient.ReceiveMCU(ref recBytes))
                        {
                            message = StrIP + "Receive Failure " + CPSocketClient.clientSocket.LocalEndPoint.ToString();
                            CPSocketClient.Close();
                            result = false;
                            continue;
                        }
                        //正确收取数据后解析数据包
                        MsgBody RecMsg = new(recBytes);
                        UInt32 tmpDataSum = 0;
                        if (RecMsg.Cmd_Byte[1] == 0xC2)
                        {
                            //校验和
                            for (int j = 0; j < RecMsg.BodyDataBriny.Length - 4; j++)
                            {
                                tmpDataSum += RecMsg.BodyDataBriny[0 + j];
                            }
                            if ((tmpDataSum != RecMsg.CheckSum))
                            {
                                message = StrIP + "Recevie Data Check Failure";
                                CPSocketClient.Close();
                                result = false;
                                continue;
                            }
                            Array.Copy(RecMsg.BodyDataBriny, 0, recValues, 0, recLen);
                        }
                        else
                        {
                            if (RecMsg.Cmd_Byte[0] != 0x83)//非查询报文
                            {
                                //校验和
                                for (int j = 0; j < RecMsg.BodyDataBriny.Length - 4; j++)
                                {
                                    tmpDataSum += RecMsg.BodyDataBriny[0 + j];
                                }
                                if ((tmpDataSum != RecMsg.CheckSum))
                                {
                                    message = StrIP + "Recevie Data Check Failure";
                                    CPSocketClient.Close();
                                    result = false;
                                    continue;
                                }
                                if (RecMsg.BodyDataBriny.Length != recLen)
                                {
                                    message = StrIP + "Recevie Data Length Check Failure";
                                    CPSocketClient.Close();
                                    result = false;
                                    continue;
                                }
                            }

                            else//查询报文
                            {
                                //校验和
                                for (int j = 0; j < RecMsg.BodyDataBriny.Length - 4; j++)
                                {
                                    tmpDataSum += RecMsg.BodyDataBriny[0 + j];
                                }
                                if ((tmpDataSum != RecMsg.CheckSum))
                                {
                                    message = StrIP + "Recevie Data Check Failure";
                                    CPSocketClient.Close();
                                    result = false;
                                    continue;
                                }
                                Array.Copy(RecMsg.BodyDataBriny, 0, recValues, 0, RecMsg.BodyDataBriny.Length - 4);
                            }
                        }
                        break;
                    }
                }
                catch (Exception ex)
                {
                    message = StrIP + string.Format("TCP异常 {0:X} {1}", Cmd, IP + "-" + ex.Message);
                    CPSocketClient.Close();
                    result = false;

                    Console.WriteLine("1001:" + ex.Message);
                }
                if (!result && LType != "操控版状态收取" && LType != "实时数据收取")
                {
                    GlobalFunction.AlarmLogAdd(FStageNo, $"[{LType}]命令发送失败", message);
                }
                //else
                //{
                //    GlobalParams.UC_RunLog.WriteLog(new LogHelper(fStageNo, $"[{LType}]命令发送成功"));
                //}
                return result;
            }
        }

        /// <summary>
        /// 系统校时（0xA101）
        /// </summary>
        /// <returns></returns>
        public bool TimeSyn()
        {
            byte[] sendValue = GlobalFunction.StructToBytes(new TSystemTimingMCU());
            byte[] recValue = Array.Empty<byte>();

            return SendCommandMCU(0xA101, sendValue, ref recValue, 12, "系统校时");
        }

        /// <summary>
        /// 发送流程（0xA301）
        /// </summary>
        /// <param name="Process"></param>
        /// <returns></returns>
        public bool SchSend(TProcess Process)
        {

            byte[] sendValue = GlobalFunction.StructToBytes(TStructConvert.ConvertTProcessMCU(Process));

            byte[] recValue = Array.Empty<byte>();

            return SendCommandMCU(0xA301, sendValue, ref recValue, 12, "发送流程");
        }

        /// <summary>
        /// 接触测试流程（0xAA01）
        /// </summary>
        /// <param name="Process"></param>
        /// <returns></returns>
        public bool ContactTest(TContactTestProcess ContactTestProcess)
        {
            byte[] sendValue = GlobalFunction.StructToBytes(TStructConvert.ConvertTContactTestProcessMCU(ContactTestProcess));
            byte[] recValue = Array.Empty<byte>();

            return SendCommandMCU(0xAA01, sendValue, ref recValue, 12, "接触测试");
        }

        /// <summary>
        /// 上位机通道保护（0xB201）
        /// </summary>
        /// <param name="AChnStates"></param>
        /// <returns></returns>
        public bool SendChnState(TChannelProtect ChannelProtect)
        {
            byte[] sendValue = GlobalFunction.StructToBytes(TStructConvert.ConvertTChannelProtectMCU(ChannelProtect));
            byte[] recValue = Array.Empty<byte>();

            return SendCommandMCU(0xB201, sendValue, ref recValue, 12, "上位机通道保护");
        }

        /// <summary>
        ///通道控制（0xA102）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ChannelControl"></param>
        /// <returns></returns>
        public bool ChannelControl(TChannelControl ChannelControl)
        {
            byte[] sendValue = GlobalFunction.StructToBytes(TStructConvert.ConvertTChannelControlMCU(ChannelControl));
            byte[] recValue = Array.Empty<byte>();

            return SendCommandMCU(0xA102, sendValue, ref recValue, 12, "通道控制");
        }

        /// <summary>
        /// 实时数据（0xA103）
        /// </summary>
        /// <param name="StageRealData"></param>
        /// <returns></returns>
        public bool RecRealTimeData(ref TRealTimeDataMCU RealTimeDataMCU)
        {
            byte[] sendValue = new byte[4];
            byte[] recValue = new byte[Marshal.SizeOf(typeof(TRealTimeDataMCU))];

            if (SendCommandMCU(0xA103, sendValue, ref recValue, recValue.Length, "实时数据收取"))
            {
                var obj = GlobalFunction.BytesToStruct(recValue, typeof(TRealTimeDataMCU));
                if (obj != null)
                    RealTimeDataMCU = (TRealTimeDataMCU)obj;
                else
                    RealTimeDataMCU = new TRealTimeDataMCU();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 切换模式（0xA708）
        /// </summary>
        /// <param name="switchMode"></param>
        /// <returns></returns>
        public bool SwitchMode(TSwitchModeMCU switchMode)
        {
            byte[] sendValue = GlobalFunction.StructToBytes(switchMode);
            byte[] recValue = Array.Empty<byte>();

            return SendCommandMCU(0xA708, sendValue, ref recValue, 12, "切换模式");
        }

        /// <summary>
        /// 离线状态（0xA503）
        /// </summary>
        /// <returns></returns>
        public bool OfflineState(ref TOfflineStateMCU OfflineStateMCU)
        {
            byte[] sendValue = new byte[4];
            byte[] recValue = new byte[Marshal.SizeOf(typeof(TOfflineStateMCU))];

            if ((SendCommandMCU(0xA503, sendValue, ref recValue, recValue.Length, "离线状态收取")))
            {
                OfflineStateMCU = (TOfflineStateMCU)GlobalFunction.BytesToStruct(recValue, typeof(TOfflineStateMCU));
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 离线文件（0xB503）
        /// </summary>
        /// <returns></returns>
        public bool OfflineData(ref List<TRealTimeDataSave> RealTimeDataSaves, int FileNo)
        {
            byte[] sendValue = new byte[12];
            Array.Copy(BitConverter.GetBytes(FileNo), 0, sendValue, 0, 4);
            byte[] recValue = new byte[Marshal.SizeOf(typeof(TOfflineDataMCU))];

            if ((SendCommandMCU(0xB503, sendValue, ref recValue, recValue.Length, "离线文件收取", 3000)))
            {
                TOfflineDataMCU OfflineDataMCU = (TOfflineDataMCU)GlobalFunction.BytesToStruct(recValue, typeof(TOfflineDataMCU));
                if (OfflineDataMCU.RealTimeDataCount > 7)
                {
                    return false;
                }
                for (int i = 0; i < OfflineDataMCU.RealTimeDataCount; i++)
                {
                    TRealTimeData RealTimeData = TStructConvert.ConvertTRealTimeData(OfflineDataMCU.RealTimeDataMCUs[i]);

                    TSaveEnvData saveEnv = new();
                    for (int j = 0; j < 8; j++)
                        saveEnv.ATemp[j] = RealTimeData.ChannelRealTimeData[j].CellTemp;

                    TRealTimeDataSave realTimeDataSave = SaveStructData.RealTimeDataSave(RealTimeData, saveEnv);
                    RealTimeDataSaves.Add(realTimeDataSave);
                }
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 关键数据（0xA203）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="StageStepData"></param>
        /// <param name="AFileIndex"></param>
        /// <param name="Amode"></param>
        /// <returns></returns>
        public bool RecResultData(ref TResultDataMCU StageStepData, short AFileIndex, byte Amode = 1)
        {
            byte[] sendValue = new byte[4];
            sendValue[0] = Amode;
            Array.Copy(BitConverter.GetBytes(AFileIndex), 0, sendValue, 2, 2);
            byte[] recValue = new byte[Marshal.SizeOf(typeof(TResultDataMCU))];

            if ((SendCommandMCU(0xA203, sendValue, ref recValue, recValue.Length, "关键数据收取", 1000)))
            {
                StageStepData = (TResultDataMCU)GlobalFunction.BytesToStruct(recValue, typeof(TResultDataMCU));
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 接触测试关键数据（0xAA03）
        /// </summary>
        /// <param name="StageContactData"></param>
        /// <returns></returns>
        public bool RecContactData(ref TContactTestResultDataMCU StageContactData)
        {
            byte[] sendValue = Array.Empty<byte>();
            byte[] recValue = new byte[Marshal.SizeOf(typeof(TContactTestResultDataMCU))];

            if (SendCommandMCU(0xAA03, sendValue, ref recValue, recValue.Length, "接触测试关键数据收取"))
            {
                StageContactData = (TContactTestResultDataMCU)GlobalFunction.BytesToStruct(recValue, typeof(TContactTestResultDataMCU));
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 操控版状态
        /// 应用层数据（0xB103）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="envMcuData"></param>
        /// <returns></returns>
        public bool RecEnvData(ref TEnvDataMCU envMcuData)
        {
            int APos = 0;
            byte[] recValue = new byte[Marshal.SizeOf(typeof(TEnvDataMCU))];  //1024

            byte[] sendValue = new byte[sizeof(UInt32) + sizeof(UInt32)];
            Buffer.BlockCopy(BitConverter.GetBytes(APos), 0, sendValue, 0, 4);    //偏移地址
            Buffer.BlockCopy(BitConverter.GetBytes(recValue.Length - 8), 0, sendValue, 4, 4);    //收取字节长度

            if (SendCommandMCU(0xB103, sendValue, ref recValue, recValue.Length, "操控版状态收取", 100))
            {
                envMcuData = (TEnvDataMCU)GlobalFunction.BytesToStruct(recValue, typeof(TEnvDataMCU));
                return true;
            }
            else
                return false;
        }

        #region 操控版控制 

        /// <summary>
        /// 应用层数据（0xB101）
        /// </summary>
        /// <param name="AsendValue">数据</param>
        /// <param name="APos">偏移地址</param>
        /// <param name="CMDName">命令名称</param>
        /// <returns></returns>
        public bool ControlENV(byte[] AsendValue, UInt32 APos, string CMDName = "")
        {
            byte[] recValue = Array.Empty<byte>();
            int sendLength = AsendValue.Length;
            byte[] sendValue = new byte[sizeof(UInt32) + sizeof(UInt32) + sendLength];
            Buffer.BlockCopy(BitConverter.GetBytes(APos), 0, sendValue, 0, 4);    //偏移地址
            Buffer.BlockCopy(BitConverter.GetBytes(sendLength), 0, sendValue, 4, 4);    //下发字节长度
            Buffer.BlockCopy(AsendValue, 0, sendValue, 8, sendLength);    //下发实际内容

            return SendCommandMCU(0xB101, sendValue, ref recValue, 12, CMDName);
        }

        /// <summary>
        /// Pos 0 系统 启动/停止
        /// <para>0x55：按照限位方式 1 启动 </para>
        /// <para>[弃用]0x66：按照限位方式 2 启动</para>
        /// <para>[弃用]0xAA：系统停止，如果在正常充放电的过程中，下位机收到停止命令，会停止充放电工作，并张开气缸恢复到初始状态;</para>
        /// <para>[弃用]0xCC：上位机命令急停，急停在停止的基础上，关闭外部电源；</para>
        /// <para>其他：不响应</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns>
        public bool SystemOnOff(byte Command)
        {
            UInt32 Pos = 0;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];

            SendValue[0] = Command;

            return ControlENV(SendValue, Pos, "系统 启动/停止");
        }

        /// <summary>
        /// Pos 1 上位机报警
        /// <para>0x00：不报警</para>
        /// <para>0x01：报警</para>
        /// </summary>
        /// <param name="fStageNo">设备号</param>
        /// <param name="Command">命令</param>
        /// <returns></returns>
        public bool PCAlarm(byte Command)
        {
            UInt32 Pos = 1;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "上位机报警");
        }

        /// <summary>
        /// Pos 2 报警清除
        /// <para>0x01：清除所有的报警；烟雾等报警一旦触发需要人为解除 </para>
        /// </summary>
        /// <param name="fStageNo">设备号</param>
        /// <param name="Command">命令</param>
        /// <returns></returns>
        public bool AlarmClear(byte Command)
        {
            UInt32 Pos = 2;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "报警清除");
        }

        /// <summary>
        /// Pos 3 掉电清除/恢复
        /// <para>0x00：无效</para>
        /// <para>0x55：掉电恢复</para>
        /// <para>0xAA：掉电清除</para>
        /// </summary>
        /// <param name="fStageNo">设备号</param>
        /// <param name="Command">命令</param>
        /// <returns></returns>
        public bool PowerFailControl(byte Command)
        {
            UInt32 Pos = 3;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "掉电清除/恢复");
        }

        /// <summary>
        /// Pos 4 手动模式控制
        /// <para>0x55：进入手动测试模式</para>
        /// <para>0xAA：退出手动测试模式机构在初始状态下才能进入手动模式。进入手动模式后，可以对 DO、AO 进行上位机控制测试；退出测试模式必须将机构手动回归为进入状态，其他输出自动恢复为进入状态。</para>
        /// </summary>
        /// <param name="fStageNo">设备号</param>
        /// <param name="Command">命令</param>
        /// <returns></returns>
        public bool ManualAutoControl(byte Command)
        {
            UInt32 Pos = 4;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "手动模式控制");
        }

        /// <summary>
        /// Pos 5 异常断电（电源箱） 切断电源箱的电源
        /// </summary>
        public bool AbnormalPowerOutage()
        {
            UInt32 Pos = 5;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = 0x55;
            return ControlENV(SendValue, Pos, "异常断电（电源箱） 切断电源箱的电源");
        }

        /// <summary>
        /// Pos 9 蜂鸣器控制
        /// <para>0x55：蜂鸣器打开</para>
        /// <para>0xAA：蜂鸣器关闭</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns>
        public bool BuzzerControlA(byte Command)
        {
            UInt32 Pos = 9;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "蜂鸣器控制");
        }

        /// <summary>
        /// Pos 11 屏蔽传感器 
        /// </summary> 
        ///// <param name="ShieldedTraySensor">屏蔽缺角传感器检测</param>
        ///// <param name="ShieldedCylinderSensor"> 屏蔽抱紧气缸传感器</param>
        /// <param name="ShieldedFireDoorSensor"> 屏蔽维修门传感器</param>
        /// <returns></returns> 
        public bool ShieldedSensor(bool ShieldedFireDoorSensor)
        {
            UInt32 Pos = 11;
            bool[] bools = new bool[32];
            //bools[31] = ShieldedTraySensor;
            //bools[30] = ShieldedCylinderSensor;
            bools[29] = ShieldedFireDoorSensor;
            byte[] SendValue = TStructConvert.BitTobytes(bools);

            return ControlENV(SendValue, Pos, "消防控制");
        }

        /// <summary>
        /// Pos 86 流量阀控制温度目标值
        /// </summary>
        /// <param name="ATemp">流量阀控制温度目标值</param> 
        /// <returns></returns> 
        public bool WaterDoorTarget(int ATemp)
        {
            UInt32 Pos = 86;
            UInt32 SendLength = 2;
            byte[] SendValue = new byte[SendLength];
            Buffer.BlockCopy(BitConverter.GetBytes((short)(ATemp * 100)), 0, SendValue, 0, 2);
            return ControlENV(SendValue, Pos, "水冷系统控制温度目标值");
        }

        /// <summary>
        /// Pos 90 报警参数
        /// </summary>
        /// <param name="ATempLimit">机构温度报警值</param>
        /// <param name="ACellTempLimit">电池温度报警值</param>
        /// <param name="ASmogLimit">烟雾报警值</param>
        /// <returns></returns>
        public bool SetTempSmogLimitAll(int ATempLimit, int ACellTempLimit, int ASmogLimit)
        {
            UInt32 Pos = 90;
            UInt32 SendLength = 20;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = 0x55;
            Buffer.BlockCopy(BitConverter.GetBytes((short)(ATempLimit * 100)), 0, SendValue, 2, 2);
            Buffer.BlockCopy(BitConverter.GetBytes((short)(ACellTempLimit * 100)), 0, SendValue, 4, 2);
            Buffer.BlockCopy(BitConverter.GetBytes((short)(ASmogLimit * 100)), 0, SendValue, 6, 2);
            return ControlENV(SendValue, Pos, "报警参数");
        }

        /// <summary>
        /// Pos 110 机构温度补偿参数
        /// </summary>
        /// <param name="ATempFix">机构温度补偿值</param> 
        /// <returns></returns>
        public bool MechanicalTempFix(double[] ATempFix)
        {
            UInt32 Pos = 110;
            UInt32 SendLength = 20;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = 0x55;
            for (int i = 1; i <= ATempFix.Length; i++)
            {
                Buffer.BlockCopy(BitConverter.GetBytes((short)(ATempFix[i - 1] * 100)), 0, SendValue, 2 * i, 2);
            }
            return ControlENV(SendValue, Pos, "机构温度补偿参数");
        }

        /// <summary>
        /// Pos 300 压床弹开参数设置
        /// </summary>
        /// <param name="PValue">压床弹开负压值 P</param>
        /// <param name="time">压床弹开时间 T</param>  
        /// <returns></returns>
        public bool PressOpenControl(int PValue, int time)
        {
            UInt32 Pos = 300;
            UInt32 SendLength = 6;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = 0x55;
            Buffer.BlockCopy(BitConverter.GetBytes((short)(PValue * 100)), 0, SendValue, 2, 2);
            Buffer.BlockCopy(BitConverter.GetBytes((short)(time)), 0, SendValue, 4, 2);
            return ControlENV(SendValue, Pos, "压床弹开参数设置");
        }

        /// <summary>
        /// Pos 310 水冷 PID 控制参数
        /// </summary>
        /// <param name="KpValue">Kp 比例系数</param>
        /// <param name="KiValue">Ki 积分系数</param>
        /// <param name="KdValue">Kd 微分系数</param>
        /// <param name="time">调节周期 T</param>
        /// <returns></returns>
        public bool WaterPIDControl(double KpValue, double KiValue, double KdValue, int time)
        {
            UInt32 Pos = 310;
            UInt32 SendLength = 10;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = 0x55;
            Buffer.BlockCopy(BitConverter.GetBytes((short)(KpValue * 100)), 0, SendValue, 2, 2);
            Buffer.BlockCopy(BitConverter.GetBytes((short)(KiValue * 100)), 0, SendValue, 4, 2);
            Buffer.BlockCopy(BitConverter.GetBytes((short)(KdValue * 100)), 0, SendValue, 6, 2);
            Buffer.BlockCopy(BitConverter.GetBytes((short)(time)), 0, SendValue, 8, 2);
            return ControlENV(SendValue, Pos, "水冷 PID 控制参数");
        }

        #endregion

        #region 数字量输出测试区（手动模式）

        /// <summary>
        /// Pos 320 气缸控制
        /// <para>0x55：气缸闭合</para>
        /// <para>0xAA：气缸张开</para>
        /// </summary>
        /// <param name="Command">命令</param>
        /// <returns></returns>
        public bool CylinderStatorControl(byte Command)
        {
            UInt32 Pos = 320;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "气缸控制");
        }

        /// <summary>
        /// Pos 321 逆变器电源控制
        /// <para>0x55：逆变器上电</para>
        /// <para>0xAA：逆变器断电</para>
        /// </summary>
        /// <param name="Command">命令</param>
        /// <returns></returns>
        public bool InverterPowerControl(byte Command)
        {
            UInt32 Pos = 321;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "逆变器电源控制");
        }

        /// <summary>
        /// Pos 322 蜂鸣器控制
        /// <para>0x55：蜂鸣器打开</para>
        /// <para>0xAA：蜂鸣器关闭</para>
        /// </summary>
        /// <param name="Command">命令</param>
        /// <returns></returns>
        public bool BuzzerControlM(byte Command)
        {
            UInt32 Pos = 322;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "蜂鸣器控制");
        }

        /// <summary>
        /// Pos 326 校正工装控制 
        /// <para>0x55：校正工装供电 on</para>
        /// <para>0xAA：校正工装断电 off</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns> 
        public bool EtalonPowerControl(byte Command)
        {
            UInt32 Pos = 326;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "校正工装控制");
        }

        /// <summary>
        /// Pos 330 自动门控制 
        /// <para>0x55：自动门落下</para>
        /// <para>[弃用]0xAA：自动门张开</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns> 
        public bool AutoDoorControl(byte Command)
        {
            UInt32 Pos = 330;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "自动门控制");
        }

        /// <summary>
        /// Pos 331 上针床风机控制 
        /// <para>0x55：上针床风机转</para>
        /// <para>0xAA：上针床风机停</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns> 
        public bool UPNeedleDedFanControl(byte Command)
        {
            UInt32 Pos = 331;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "上针床风机控制");
        }

        /// <summary>
        /// Pos 333 排烟风机控制 
        /// <para>0x55：排烟风机转</para>
        /// <para>0xAA：排烟风机停</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns>  
        public bool SmokeExhaustFanControl(byte Command)
        {
            UInt32 Pos = 333;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "排烟风机控制");
        }

        /// <summary>
        /// Pos 334 风机总开控制 
        /// <para>0x55：打开风机总开</para>
        /// <para>0xAA：关闭风机总开</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns>  
        public bool AllFanControl(byte Command)
        {
            UInt32 Pos = 334;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "风机总开控制");
        }

        /// <summary>
        /// Pos 336 运行灯控制  
        /// <para>0x55：运行灯亮</para>
        /// <para>0xAA：运行灯灭</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns>  
        public bool RunLightControl(byte Command)
        {
            UInt32 Pos = 336;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "运行灯控制");
        }

        /// <summary>
        /// Pos 337 电磁锁控制  
        /// <para>0x55：电磁锁打开</para>
        /// <para>0xAA：电磁锁关闭</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns>  
        public bool ElectromagnetLockControl(byte Command)
        {
            UInt32 Pos = 337;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "电磁锁控制");
        }

        /// <summary>
        /// Pos 338 水冷电磁阀控制  
        /// <para>0x55：水冷电磁阀打开</para>
        /// <para>0xAA：水冷电磁阀关闭</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns>  
        public bool WaterCooledControl(byte Command)
        {
            UInt32 Pos = 338;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "电磁锁控制");
        }

        /// <summary>
        /// Pos 339 异常启动控制  
        /// <para>0x55：异常启动打开</para>
        /// <para>0xAA：异常启动关闭</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns>  
        public bool AbnormalStartControl(byte Command)
        {
            UInt32 Pos = 339;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "异常启动控制");
        }

        /// <summary>
        /// Pos 340 下针床风机控制 
        /// <para>0x55：下针床风机转</para>
        /// <para>0xAA：下针床风机停</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <returns></returns> 
        public bool DownNeedleDedFanControl(byte Command)
        {
            UInt32 Pos = 340;
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "下针床风机控制");
        }

        /// <summary>
        /// Pos 340 水冷风机控制 
        /// <para>0x55：水冷风机转</para>
        /// <para>0xAA：水冷风机停</para>
        /// </summary> 
        /// <param name="Command">命令</param>
        /// <param name="ID">风机ID</param>
        /// <returns></returns> 
        public bool WaterFanControl(byte Command, int ID)
        {
            UInt32 Pos = (uint)(ID + 340);
            UInt32 SendLength = 1;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = Command;
            return ControlENV(SendValue, Pos, "水冷风机控制");
        }

        /// <summary>
        /// Pos 354 流量阀开度 
        /// <para>流量阀开度：有符号，*100，单位 KPa，与流量阀设置有效一起下发，控制比例阀输出</para>
        /// </summary> 
        /// <param name="VacuumValue">流量阀开度</param>
        /// <returns></returns>   
        public bool WaterOpenControl(double VacuumValue)
        {
            UInt32 Pos = 354;
            UInt32 SendLength = 4;
            byte[] SendValue = new byte[SendLength];
            SendValue[0] = 0x55;
            Buffer.BlockCopy(BitConverter.GetBytes((short)(VacuumValue * 100)), 0, SendValue, 2, 2);
            return ControlENV(SendValue, Pos, "流量阀开度");
        }
        #endregion
    }
}
