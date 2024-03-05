using CDClassLibrary.Stage;
using Newtonsoft.Json;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace CDClassLibrary.Mes
{
    public static class HttpWMS
    {
        public static bool DeviceOnOff = false;

        //readonly static string apiUrl = "http://172.17.20.243:8090/api/MERequest/"; 
        static string apiUrl = $"http://{GlobalDefine.WMSIP}:8090/api/MERequest/";

        readonly static object LockObj = new();
        readonly static string[] ListLog = new string[GlobalDefine.NUM_ALLSTAGES];

        public static bool Ping()
        {
            try
            {
                Ping ping = new();
                //PingReply tmpReply = ping.Send("172.17.20.243", Constants.TcpCmm.PING_TIMEOUT);
                PingReply tmpReply = ping.Send(GlobalDefine.WMSIP, Constants.TcpCmm.PING_TIMEOUT);
                return (tmpReply.Status == IPStatus.Success);
            }
            catch (Exception ex)
            {
                Console.WriteLine("1003:" + ex.Message);
                return false;
            }
        }

        public static string Post(string url, string content)
        {
            lock (LockObj)
            {
                string responseStr = string.Empty; if (Ping())
                {
                    try
                    {
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl + url);
                        request.Method = "POST";
                        request.ContentType = "application/json";
                        request.Accept = "text/plain";
                        request.Timeout = 2000;
                        request.AllowAutoRedirect = false;

                        StreamWriter requestStream = new(request.GetRequestStream());
                        requestStream.Write(content);
                        requestStream.Close();

                        WebResponse response = request.GetResponse();
                        if (response != null)
                        {
                            StreamReader reader = new(response.GetResponseStream(), Encoding.UTF8);
                            responseStr = reader.ReadToEnd();
                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        GlobalFunction.AlarmLogAdd("", "WMS通信失败", ex.Message);
                    }
                }
                return responseStr;
            }
        }

        #region 检测柜推送货位状态[NotifyCellWorkState] 相关

        struct NotifyCellWorkStateSend
        {
            public List<WorkState> WorkStates;
        }
        struct WorkState
        {
            /// <summary>
            /// 区域（单字母） N=化成区域 R=分容区域
            /// </summary>
            public string Zone;
            /// <summary>
            /// 排
            /// </summary>
            public int Row;
            /// <summary>
            /// 列
            /// </summary>
            public int Col;
            /// <summary>
            /// 层
            /// </summary>
            public int Layer;
            /// <summary>
            /// 深度 这边设备只有一个托盘 深度默认1
            /// </summary>
            public int Depth;
            /// <summary>
            /// 设备状态 1=空闲  2=⼯作中 3=异常 4=维修
            /// </summary>
            public int StatusCode;
            /// <summary>
            /// 设备异常信息
            /// </summary>
            public string Message;

        }

        /// <summary>
        /// 检测柜推送货位状态
        /// </summary>
        struct NotifyCellWorkStateResult
        {
            public int Result;
            public string Message;
        }

        private static int StatusCode(TStageState StageState, bool FRunFlag, bool VacancyFlag, bool ManualAutoFlag, bool close)
        {
            int StatusCode = 4;
            if (!close)
            {
                if (FRunFlag && VacancyFlag && ManualAutoFlag)
                {
                    StatusCode = StageState switch
                    {
                        TStageState.ssInit
                        => 1,
                        TStageState.ssTrayIn or
                        TStageState.ssReady or
                        TStageState.ssWait or
                        TStageState.ssRunning or
                        TStageState.ssProcessEnd or
                        TStageState.ssWaitOutbound
                        => 2,
                        TStageState.ssEMG or
                        TStageState.ssPCAlarm or
                        TStageState.ssTemp or
                        TStageState.ssSmoke or
                        TStageState.ssOverTime or
                        TStageState.ssChargeDis or
                        TStageState.ssPowerDown or
                        TStageState.ssOff
                        => 3,
                        TStageState.ssVacancy
                        => 4,
                        _ => 3,
                    };
                }
            }
            return StatusCode;
        }

        /// <summary>
        /// 检测柜推送货位状态
        /// </summary>
        /// <param name="Col"></param>
        /// <param name="Layer"></param>
        /// <returns></returns>
        public static bool NotifyCellWorkState(bool close = false, int Col = 0, int Layer = 0)
        {
            List<WorkState> WorkStates = new();
            if (Col != 0 && Layer != 0)
            {
                int FStageID = (Col - 1) * GlobalDefine.NUM_DEVICEPERLINE + (Layer - 1);
                WorkState workState = new()
                {
                    Zone = GlobalParams.GStages[FStageID].DeviceType == TDeviceType.CDC2 ? "N" : "R",
                    Row = GlobalDefine.LNSTNO,
                    Col = Col,
                    Layer = Layer,
                    Depth = 1,
                    Message = GlobalFunction.GetValue(GlobalParams.GStages[FStageID].StageState),
                    StatusCode = StatusCode(
                        GlobalParams.GStages[FStageID].StageState,
                        GlobalParams.GStages[FStageID].FRunFlag,
                        GlobalParams.GStages[FStageID].VacancyFlag,
                        GlobalParams.GStages[FStageID].ManualAutoFlag,
                        close),
                };
                WorkStates.Add(workState);
            }
            else
            {
                for (int i = 0; i < GlobalDefine.NUM_STAGEPERDEVICE; i++)
                {
                    for (int j = 0; j < GlobalDefine.NUM_DEVICEPERLINE; j++)
                    {
                        int FStageID = j + i * GlobalDefine.NUM_DEVICEPERLINE;
                        WorkState workState = new()
                        {
                            Zone = GlobalParams.GStages[FStageID].DeviceType == TDeviceType.CDC2 ? "N" : "R",
                            Row = GlobalDefine.LNSTNO,
                            Col = i + 1,
                            Layer = j + 1,
                            Depth = 1,
                            Message = GlobalFunction.GetValue(GlobalParams.GStages[FStageID].StageState),
                            StatusCode = StatusCode(
                                GlobalParams.GStages[FStageID].StageState,
                                GlobalParams.GStages[FStageID].FRunFlag,
                                GlobalParams.GStages[FStageID].VacancyFlag,
                                GlobalParams.GStages[FStageID].ManualAutoFlag,
                                close),
                        };

                        WorkStates.Add(workState);
                    }
                }
            }
            NotifyCellWorkStateSend Send = new() { WorkStates = WorkStates };

            StreamWriter streamWriter = new(GlobalDefine.SystemPath + "WorkStates.txt", false);
            streamWriter.Write(JsonConvert.SerializeObject(WorkStates));
            streamWriter.Flush();
            streamWriter.Close();

            try
            {
                string strResult = Post("NotifyCellWorkState", JsonConvert.SerializeObject(Send));
                if (strResult != string.Empty)
                {
                    NotifyCellWorkStateResult Result = JsonConvert.DeserializeObject<NotifyCellWorkStateResult>(strResult);
                    if (Result.Result == 0)
                    {
                        GlobalFunction.MesLogAdd("", "处理失败", "检测柜推送货位状态<NotifyCellWorkState>。" + Result.Message);
                        GlobalFunction.AlarmLogAdd("", "处理失败", "检测柜推送货位状态<NotifyCellWorkState>。" + Result.Message);
                        DeviceOnOff = false;
                        return false;
                    }
                    else
                    {
                        //GlobalFunction.MesLogAdd("", "推送货位状态成功", "检测柜推送货位状态<NotifyCellWorkState>。", false);
                        DeviceOnOff = true;
                        return true;
                    }
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine("1030:" + ex.Message);
                GlobalFunction.AlarmLogAdd("", "WMS通信失败", "检测柜推送货位状态<NotifyCellWorkState>。" + ex.Message);
                DeviceOnOff = false;
                return false;
            }
        }
        #endregion

        #region 检测柜获取托盘电池信息[RequetWarehouseCellBingAsset] 相关
        struct RequetWarehouseCellBingAssetSend
        {
            /// <summary>
            /// 区域（单字母） N=化成区域 R=分容区域
            /// </summary>
            public string Zone;
            /// <summary>
            /// 排
            /// </summary>
            public int Row;
            /// <summary>
            /// 列
            /// </summary>
            public int Col;
            /// <summary>
            /// 层
            /// </summary>
            public int Layer;
            /// <summary>
            /// 深度 这边设备只有一个托盘 深度默认1
            /// </summary>
            public int Depth;
        }

        struct RequetWarehouseCellBingAssetResult
        {
            /// <summary>
            /// 0 处理失败 1 处理成功
            /// </summary>
            public int Result;
            /// <summary>
            /// 对应的详细说明。如成功，不⽤提供说明；否则需提供错误信息。
            /// </summary>
            public string Message;
            public PalletContent PileContent;
        }
        struct PalletContent
        {
            /// <summary>
            /// 托盘条码
            /// </summary>
            public string PalletBarcode;
            /// <summary>
            /// 测试⼯艺号
            /// </summary>
            public string FileName;
            /// <summary>
            /// 电池类型(型号)
            /// </summary>
            public string BatteryType;
            /// <summary>
            /// 托盘⾥的电池集合
            /// </summary>
            public List<OneBattery> Batterys;
        }
        struct OneBattery
        {
            /// <summary>
            /// 电芯条码
            /// </summary>
            public string BatteryBarcode;
            /// <summary>
            /// 位置（1到38排序，实物和信息对应关系）
            /// </summary>
            public int PalletIndex;
            /// <summary>
            /// 1 真电芯 （默认）0 假电芯
            /// </summary>
            public int IsRealBattery;
            /// <summary>
            /// 前⼀检测⼯序测试结果 1=OK；0=NG（NG⼯位没有结果都是NG）；
            /// </summary>
            public int IsNg;
        }

        /// <summary>
        /// 检测柜获取托盘电池信息
        /// </summary>
        /// <param name="Col">列</param>
        /// <param name="Layer">层</param>
        public static bool RequetWarehouseCellBingAsset(int Col, int Layer)
        {
            int FStageID = (Col - 1) * GlobalDefine.NUM_DEVICEPERLINE + (Layer - 1);
            try
            {
                RequetWarehouseCellBingAssetSend Send = new()
                {
                    Zone = GlobalParams.GStages[FStageID].DeviceType == TDeviceType.CDC2 ? "N" : "R",
                    Row = GlobalDefine.LNSTNO,
                    Col = Col,
                    Layer = Layer,
                    Depth = 1,
                };

                string FStageNO = $"{GlobalDefine.LNSTNO:00}{Col:000}{Layer:00}";

                string strResult = Post("RequetWarehouseCellBingAsset", JsonConvert.SerializeObject(Send));
                if (strResult != string.Empty)
                {
                    RequetWarehouseCellBingAssetResult Result = JsonConvert.DeserializeObject<RequetWarehouseCellBingAssetResult>(strResult);
                    if (Result.Result == 0)
                    {
                        if (ListLog[FStageID] != (Col + Layer + DateTime.Now.ToString("HHmm") + "处理失败RequetWarehouseCellBingAsset"))
                        {
                            ListLog[FStageID] = (Col + Layer + DateTime.Now.ToString("HHmm") + "处理失败RequetWarehouseCellBingAsset");
                            GlobalFunction.MesLogAdd(FStageNO, "处理失败", "检测柜获取托盘电池信息<RequetWarehouseCellBingAsset>。" + Result.Message);
                            GlobalFunction.AlarmLogAdd(FStageNO, "处理失败", "检测柜获取托盘电池信息<RequetWarehouseCellBingAsset>。" + Result.Message);
                        }
                        return false;
                    }
                    else
                    {
                        string[] CellNumber = new string[GlobalDefine.CHANNELS]; 
                        byte[] ChnState = new byte[GlobalDefine.CHANNELS];
                        int CELL_COUNT = 0;
                        int PF_COUNT = 0;

                        bool boo = false;
                        for (int i = 0; i < GlobalParams.ProcessGroup.Count; i++)
                        {
                            if (GlobalParams.ProcessGroup[i].ProcessName == Result.PileContent.FileName)
                            {
                                TProcessGroup ProcessGroup = new()
                                {
                                    ProcessName = GlobalParams.ProcessGroup[i].ProcessName,
                                    IsRetest = GlobalParams.ProcessGroup[i].IsRetest,
                                    IsEnabled = GlobalParams.ProcessGroup[i].IsEnabled,
                                    ContactTestProcess = GlobalParams.ProcessGroup[i].ContactTestProcess,
                                    OCVTestSet = GlobalParams.ProcessGroup[i].OCVTestSet,
                                    PCProtect = GlobalParams.ProcessGroup[i].PCProtect,
                                    Process = GlobalParams.ProcessGroup[i].Process,
                                    DeviceNGLimit = GlobalParams.ProcessGroup[i].DeviceNGLimit,
                                };
                                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                                    ProcessGroup.Process.PosSelected[ChnNo] = ChnState[ChnNo] == 0;

                                GlobalParams.GStages[FStageID].ProcessGroup = ProcessGroup;
                                boo = true;
                                break;
                            }
                        }

                        for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                        {
                            ChnState[ChnNo] = 0x60;
                        }
                        foreach (var item in Result.PileContent.Batterys)
                        {
                            int Index = item.PalletIndex - 1;
                            CellNumber[Index] = item.BatteryBarcode; 
                            if (item.IsNg == 1 || GlobalParams.GStages[FStageID].ProcessGroup.IsRetest)
                            {
                                if (item.IsRealBattery == 1)
                                {
                                    ChnState[Index] = 0x00;
                                    CELL_COUNT++;
                                }
                                else
                                {
                                    ChnState[Index] = 0x61;
                                    PF_COUNT++;
                                }
                            }
                        }
                        TTrayInfo TrayInfo = new()
                        {  
                            TRAY_NO = Result.PileContent.PalletBarcode,
                            ProcessName = Result.PileContent.FileName,
                            AutoFlag = true,
                            FStageNo = FStageNO,
                            CellNumber = CellNumber,
                            ChnState = ChnState,
                            CELL_COUNT = CELL_COUNT,
                            PF_COUNT = PF_COUNT,
                        };

                        foreach (var item in Result.PileContent.Batterys)
                        {
                            if (item.BatteryBarcode.Replace(" ", "").Length >= 10)
                            {
                                string[] strBatteryBarcode = item.BatteryBarcode.Split(' ');
                                TrayInfo.MDL_NAME = strBatteryBarcode[0];
                                TrayInfo.BATCH_ID = strBatteryBarcode[1][..4];
                                break;
                            }
                        }

                        GlobalParams.GStages[FStageID].TrayInfo = TrayInfo;

                        if (boo)
                            GlobalFunction.MesLogAdd(FStageNO, "获取托盘电池信息成功", "检测柜获取托盘电池信息<RequetWarehouseCellBingAsset>。");
                        else
                        {
                            if (ListLog[FStageID] != (Col + Layer + DateTime.Now.ToString("HHmm") + "获取托盘电池信息失败RequetWarehouseCellBingAsset"))
                            {
                                ListLog[FStageID] = (Col + Layer + DateTime.Now.ToString("HHmm") + "获取托盘电池信息失败RequetWarehouseCellBingAsset");
                                GlobalFunction.MesLogAdd(FStageNO, "获取托盘电池信息失败", "系统中无该测试流程" + Result.PileContent.FileName + "检测柜获取托盘电池信息<RequetWarehouseCellBingAsset>。");
                                GlobalFunction.AlarmLogAdd(FStageNO, "获取托盘电池信息失败", "系统中无该测试流程" + Result.PileContent.FileName + "检测柜获取托盘电池信息<RequetWarehouseCellBingAsset>。");
                            }
                        }
                        return boo;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("1031:" + ex.Message);
                if (ListLog[FStageID] != (Col + Layer + DateTime.Now.ToString("HHmm") + "WMS通信失败RequetWarehouseCellBingAsset"))
                {
                    ListLog[FStageID] = (Col + Layer + DateTime.Now.ToString("HHmm") + "WMS通信失败RequetWarehouseCellBingAsset");
                    GlobalFunction.AlarmLogAdd("", "WMS通信失败", "检测柜获取托盘电池信息<RequetWarehouseCellBingAsset>。" + ex.Message);
                }
                return false;
            }
        }
        #endregion

        #region 检测柜调⽤WMS接⼝上传结果[UploadWarehouseTestResult] 相关
        struct UploadWarehouseTestResultSend
        {
            /// <summary>
            /// 区域（单字母） N=化成区域 R=分容区域 不可空
            /// </summary>
            public string Zone;
            /// <summary>
            /// 排 不可空
            /// </summary>
            public int Row;
            /// <summary>
            /// 列 不可空
            /// </summary>
            public int Col;
            /// <summary>
            /// 层 不可空
            /// </summary>
            public int Layer;
            /// <summary>
            /// 深度 这边设备只有一个托盘 深度默认1 不可空
            /// </summary>
            public int Depth;
            /// <summary>
            /// 托盘条码 不可空
            /// </summary>
            public string PalletBarcode;
            /// <summary>
            /// 电池测试结果列表 不可空
            /// </summary>
            public List<OneBatteryTestResult> BatteryTestResults;
            /// <summary>
            /// ⼯艺号 不可空
            /// </summary>
            public string FileName;
            /// <summary>
            /// 托盘OK、NG标识1=OK；0=NG 不可空
            /// </summary>
            public int BatteryTestFlag;
            /// <summary>
            /// 电池类型 不可空
            /// </summary>
            public string BatteryType;
        }
        struct OneBatteryTestResult
        {
            /// <summary>
            /// 电芯条码 不可空
            /// </summary>
            public string BatteryBarcode;
            /// <summary>
            /// 0 NG, 1 OK 不可空
            /// </summary>
            public int Result;
            /// <summary>
            /// NG代码 可空
            /// </summary>
            public string BatteryNGCode;
            /// <summary>
            /// 电池位置 不可空
            /// </summary>
            public int BatteryIndex;
        }

        struct UploadWarehouseTestResultResult
        {
            /// <summary>
            /// 0 处理失败 1 处理成功
            /// </summary>
            public int Result;
            /// <summary>
            /// 对应的详细说明。如成功，不⽤提供说明；否则需提供错误信息。
            /// </summary>
            public string Message;
        }

        /// <summary>
        /// 检测柜调⽤WMS接⼝上传结果
        /// </summary>
        /// <param name="Col">列</param>
        /// <param name="Layer">层</param>
        public static bool UploadWarehouseTestResult(int Col, int Layer)
        {
            int FStageID = (Col - 1) * GlobalDefine.NUM_DEVICEPERLINE + (Layer - 1);
            try
            {
                List<OneBatteryTestResult> BatteryTestResults = new();
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    if (GlobalParams.GStages[FStageID].TrayInfo.ChnState[ChnNo] != 0x60 &&
                        GlobalParams.GStages[FStageID].TrayInfo.CellNumber[ChnNo] != null)
                    {
                        BatteryTestResults.Add(new OneBatteryTestResult()
                        {
                            BatteryBarcode = GlobalParams.GStages[FStageID].TrayInfo.CellNumber[ChnNo],
                            BatteryIndex = ChnNo + 1,
                            Result = GlobalParams.GStages[FStageID].TrayInfo.ChnState[ChnNo] == 0x00 ? 1 : 0,
                            BatteryNGCode = GlobalParams.GStages[FStageID].TrayInfo.ChnState[ChnNo].ToString("X2"),
                        });
                    }
                }
                UploadWarehouseTestResultSend Send = new()
                {
                    Zone = GlobalParams.GStages[FStageID].DeviceType == TDeviceType.CDC2 ? "N" : "R",
                    Row = GlobalDefine.LNSTNO,
                    Col = Col,
                    Layer = Layer,
                    Depth = 1,
                    BatteryTestFlag = 1,
                    BatteryType = GlobalParams.GStages[FStageID].TrayInfo.MDL_NAME,
                    FileName = GlobalParams.GStages[FStageID].TrayInfo.ProcessName,
                    PalletBarcode = GlobalParams.GStages[FStageID].TrayInfo.TRAY_NO,
                    BatteryTestResults = BatteryTestResults,
                };

                string FStageNO = $"{GlobalDefine.LNSTNO:00}{Col:000}{Layer:00}";

                string strResult = Post("UploadWarehouseTestResult", JsonConvert.SerializeObject(Send));
                if (strResult != string.Empty)
                {
                    UploadWarehouseTestResultResult Result = JsonConvert.DeserializeObject<UploadWarehouseTestResultResult>(strResult);

                    if (Result.Result == 0)
                    {
                        if (ListLog[FStageID] != (Col + Layer + DateTime.Now.ToString("HHmm") + "处理失败UploadWarehouseTestResult"))
                        {
                            ListLog[FStageID] = (Col + Layer + DateTime.Now.ToString("HHmm") + "处理失败UploadWarehouseTestResult");
                            GlobalFunction.MesLogAdd(FStageNO, "处理失败", "检测柜调⽤WMS接⼝上传结果<UploadWarehouseTestResult>。" + Result.Message);
                            GlobalFunction.AlarmLogAdd(FStageNO, "处理失败", "检测柜调⽤WMS接⼝上传结果<UploadWarehouseTestResult>。" + Result.Message);
                        }
                        return false;
                    }
                    else
                    {
                        GlobalFunction.MesLogAdd(FStageNO, "上传结果成功", "检测柜调⽤WMS接⼝上传结果<UploadWarehouseTestResult>。");
                        return true;
                    }
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine("1032:" + ex.Message);
                if (ListLog[FStageID] != (Col + Layer + DateTime.Now.ToString("HHmm") + "WMS通信失败UploadWarehouseTestResult"))
                {
                    ListLog[FStageID] = (Col + Layer + DateTime.Now.ToString("HHmm") + "WMS通信失败UploadWarehouseTestResult");
                    GlobalFunction.AlarmLogAdd("", "WMS通信失败", "检测柜调⽤WMS接⼝上传结果<UploadWarehouseTestResult>。" + ex.Message);
                }
                return false;
            }
        }
        #endregion

        #region 调⽤⽕警报警接⼝[NotifyWMSStandingFireAlarm] 相关
        struct NotifyWMSStandingFireAlarmSend
        {
            /// <summary>
            /// 区域（单字母） N=化成区域 R=分容区域
            /// </summary>
            public string Zone;
            /// <summary>
            /// 排
            /// </summary>
            public int Row;
            /// <summary>
            /// 列
            /// </summary>
            public int Col;
            /// <summary>
            /// 层
            /// </summary>
            public int Layer;
            /// <summary>
            /// 深度 这边设备只有一个托盘 深度默认1
            /// </summary>
            public int Depth;
        }

        struct NotifyWMSStandingFireAlarmResult
        {
            /// <summary>
            /// 0 处理失败 1 处理成功
            /// </summary>
            public int Result;
            /// <summary>
            /// 对应的详细说明。如成功，不⽤提供说明；否则需提供错误信息。
            /// </summary>
            public string Message;
        }

        /// <summary>
        /// 调⽤⽕警报警接⼝
        /// </summary>
        /// <param name="Col">列</param>
        /// <param name="Layer">层</param>
        public static bool NotifyWMSStandingFireAlarm(int Col, int Layer)
        {
            int FStageID = (Col - 1) * GlobalDefine.NUM_DEVICEPERLINE + (Layer - 1);
            try
            {
                NotifyWMSStandingFireAlarmSend Send = new()
                {
                    Zone = GlobalParams.GStages[FStageID].DeviceType == TDeviceType.CDC2 ? "N" : "R",
                    Row = GlobalDefine.LNSTNO,
                    Col = Col,
                    Layer = Layer,
                    Depth = 1,
                };
                string FStageNO = $"{GlobalDefine.LNSTNO:00}{Col:000}{Layer:00}";

                string strResult = Post("NotifyWMSStandingFireAlarm", JsonConvert.SerializeObject(Send));
                if (strResult != string.Empty)
                {
                    NotifyWMSStandingFireAlarmResult Result = JsonConvert.DeserializeObject<NotifyWMSStandingFireAlarmResult>(strResult);

                    if (Result.Result == 0)
                    {
                        if (!ListLog[FStageID].Contains(Col + Layer + DateTime.Now.ToString("HHmm") + "处理失败NotifyWMSStandingFireAlarm"))
                        {
                            ListLog[FStageID] = (Col + Layer + DateTime.Now.ToString("HHmm") + "处理失败NotifyWMSStandingFireAlarm");
                            GlobalFunction.MesLogAdd(FStageNO, "处理失败", "调⽤⽕警报警接⼝<NotifyWMSStandingFireAlarm>。" + Result.Message);
                            GlobalFunction.AlarmLogAdd(FStageNO, "处理失败", "调⽤⽕警报警接⼝<NotifyWMSStandingFireAlarm>。" + Result.Message);
                        }
                        return false;
                    }
                    else
                    {
                        GlobalFunction.MesLogAdd("FStageNO", "火警处理完成", "调⽤⽕警报警接⼝<NotifyWMSStandingFireAlarm>。");
                        return true;
                    }
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine("1033:" + ex.Message);
                if (!ListLog[FStageID].Contains(Col + Layer + DateTime.Now.ToString("HHmm") + "WMS通信失败NotifyWMSStandingFireAlarm"))
                {
                    ListLog[FStageID] = (Col + Layer + DateTime.Now.ToString("HHmm") + "WMS通信失败NotifyWMSStandingFireAlarm");
                    GlobalFunction.AlarmLogAdd("", "WMS通信失败", "调⽤⽕警报警接⼝<NotifyWMSStandingFireAlarm>。" + ex.Message);
                }
                return false;
            }
        }
        #endregion

        #region  检测柜调⽤WMS获取货位任务是否完成[NotifyCellFinishTest] 相关
        struct NotifyCellFinishTestSend
        {
            /// <summary>
            /// 区域（单字母） N=化成区域 R=分容区域
            /// </summary>
            public string Zone;
            /// <summary>
            /// 排
            /// </summary>
            public int Row;
            /// <summary>
            /// 列
            /// </summary>
            public int Col;
            /// <summary>
            /// 层
            /// </summary>
            public int Layer;
            /// <summary>
            /// 深度 这边设备只有一个托盘 深度默认1
            /// </summary>
            public int Depth;
        }

        struct NotifyCellFinishTestResult
        {
            /// <summary>
            /// 0 处理失败 1 处理成功
            /// </summary>
            public int Result;
            /// <summary>
            /// 对应的详细说明。如成功，不⽤提供说明；否则需提供错误信息。
            /// </summary>
            public string Message;
            /// <summary>
            /// 0 放置未完成 1 托盘放置完成  不可空
            /// </summary>
            public int Code;
        }

        /// <summary>
        /// 检测柜调⽤WMS获取货位任务是否完成
        /// </summary>
        /// <param name="Col">列</param>
        /// <param name="Layer">层</param>
        public static bool NotifyCellFinishTest(int Col, int Layer)
        {
            int FStageID = (Col - 1) * GlobalDefine.NUM_DEVICEPERLINE + (Layer - 1);
            try
            {
                NotifyCellFinishTestSend Send = new()
                {
                    Zone = GlobalParams.GStages[FStageID].DeviceType == TDeviceType.CDC2 ? "N" : "R",
                    Row = GlobalDefine.LNSTNO,
                    Col = Col,
                    Layer = Layer,
                    Depth = 1,
                };
                string FStageNO = $"{GlobalDefine.LNSTNO:00}{Col:000}{Layer:00}";

                string strResult = Post("NotifyCellFinishTest", JsonConvert.SerializeObject(Send));
                if (strResult != string.Empty)
                {
                    NotifyCellFinishTestResult Result = JsonConvert.DeserializeObject<NotifyCellFinishTestResult>(strResult);

                    if (Result.Result == 0)
                    {
                        if (!ListLog[FStageID].Contains(Col + Layer + DateTime.Now.ToString("HHmm") + "处理失败NotifyCellFinishTest"))
                        {
                            ListLog[FStageID] = (Col + Layer + DateTime.Now.ToString("HHmm") + "处理失败NotifyCellFinishTest");
                            GlobalFunction.MesLogAdd(FStageNO, "处理失败", "检测柜调⽤WMS获取货位任务是否完成<NotifyCellFinishTest>。" + Result.Message);
                            GlobalFunction.AlarmLogAdd(FStageNO, "处理失败", "检测柜调⽤WMS获取货位任务是否完成<NotifyCellFinishTest>。" + Result.Message);
                        }
                        return false;
                    }
                    else
                    {
                        if (Result.Code == 1)
                        {
                            GlobalFunction.MesLogAdd(FStageNO, "托盘放置完成", "检测柜调⽤WMS获取货位任务是否完成<NotifyCellFinishTest>。");
                            return true;
                        }
                        else
                        {
                            GlobalFunction.MesLogAdd(FStageNO, "托盘放置未完成", "检测柜调⽤WMS获取货位任务是否完成<NotifyCellFinishTest>。");
                            return false;
                        }
                    }
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine("1034:" + ex.Message);
                if (!ListLog[FStageID].Contains(Col + Layer + DateTime.Now.ToString("HHmm") + "WMS通信失败NotifyCellFinishTest"))
                {
                    ListLog[FStageID] = (Col + Layer + DateTime.Now.ToString("HHmm") + "WMS通信失败NotifyCellFinishTest");
                    GlobalFunction.AlarmLogAdd("", "WMS通信失败", "检测柜调⽤WMS获取货位任务是否完成<NotifyCellFinishTest>。" + ex.Message);
                }
                return false;
            }
        }
        #endregion

        #region  检测柜通知脱开针床[RequestReleasePull] 相关
        struct RequestReleasePullSend
        {
            /// <summary>
            /// 区域（单字母） N=化成区域 R=分容区域
            /// </summary>
            public string Zone;
            /// <summary>
            /// 排
            /// </summary>
            public int Row;
            /// <summary>
            /// 列
            /// </summary>
            public int Col;
            /// <summary>
            /// 层
            /// </summary>
            public int Layer;
            /// <summary>
            /// 深度 这边设备只有一个托盘 深度默认1
            /// </summary>
            public int Depth;
            /// <summary>
            /// 托盘条码
            /// </summary>
            public string PalletBarcode;
        }

        struct RequestReleasePullResult
        {
            /// <summary>
            /// 0 处理失败 1 处理成功
            /// </summary>
            public int Result;
            /// <summary>
            /// 对应的详细说明。如成功，不⽤提供说明；否则需提供错误信息。
            /// </summary>
            public string Message;
            /// <summary>
            /// 0 不允许脱开针床 1 允许脱开针床  不可空
            /// </summary>
            public int Code;
        }

        /// <summary>
        /// 检测柜通知脱开针床
        /// </summary>
        /// <param name="Col">列</param>
        /// <param name="Layer">层</param>
        /// <param name="PalletBarcode">托盘条码</param>
        /// <returns></returns>
        public static bool RequestReleasePull(int Col, int Layer, string PalletBarcode)
        {
            int FStageID = (Col - 1) * GlobalDefine.NUM_DEVICEPERLINE + (Layer - 1);
            try
            {
                RequestReleasePullSend Send = new()
                {
                    Zone = GlobalParams.GStages[FStageID].DeviceType == TDeviceType.CDC2 ? "N" : "R",
                    Row = GlobalDefine.LNSTNO,
                    Col = Col,
                    Layer = Layer,
                    Depth = 1,
                    PalletBarcode = PalletBarcode
                };
                string FStageNO = $"{GlobalDefine.LNSTNO:00}{Col:000}{Layer:00}";

                string strResult = Post("RequestReleasePull", JsonConvert.SerializeObject(Send));
                if (strResult != string.Empty)
                {
                    RequestReleasePullResult Result = JsonConvert.DeserializeObject<RequestReleasePullResult>(strResult);

                    if (Result.Result == 0)
                    {
                        if (!ListLog[FStageID].Contains(Col + Layer + DateTime.Now.ToString("HHmm") + "处理失败RequestReleasePull"))
                        {
                            ListLog[FStageID] = (Col + Layer + DateTime.Now.ToString("HHmm") + "处理失败RequestReleasePull");
                            GlobalFunction.MesLogAdd(FStageNO, "处理失败", "检测柜通知脱开针床<RequestReleasePull>。" + Result.Message);
                            GlobalFunction.AlarmLogAdd(FStageNO, "处理失败", "检测柜通知脱开针床<RequestReleasePull>。" + Result.Message);
                        }
                        return false;
                    }
                    else
                    {
                        if (Result.Code == 1)
                        {
                            GlobalFunction.MesLogAdd(FStageNO, "允许脱开针床", "检测柜通知脱开针床<RequestReleasePull>。");
                            return true;
                        }
                        else
                        {
                            GlobalFunction.MesLogAdd(FStageNO, "不允许脱开针床", "检测柜通知脱开针床<RequestReleasePull>。");
                            return false;
                        }
                    }
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine("1035:" + ex.Message);
                if (!ListLog[FStageID].Contains(Col + Layer + DateTime.Now.ToString("HHmm") + "WMS通信失败RequestReleasePull"))
                {
                    ListLog[FStageID] = (Col + Layer + DateTime.Now.ToString("HHmm") + "WMS通信失败RequestReleasePull");
                    GlobalFunction.AlarmLogAdd("", "WMS通信失败", "检测柜通知脱开针床<RequestReleasePull>。" + ex.Message);
                }
                return false;
            }
        }

        #endregion
    }
}
