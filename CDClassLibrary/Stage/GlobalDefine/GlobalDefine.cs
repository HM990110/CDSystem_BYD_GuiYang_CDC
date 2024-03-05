using System.ComponentModel;

namespace CDClassLibrary.Stage
{
    public class GlobalDefine
    {
        public static Lang Lang = Lang.zh;

        public static int LNSTNO = 1;
        public static int DVSTNO = 1;

        /// <summary>
        /// 模式选择 true：生产模式；false：测试模式  
        /// </summary>
        public static bool OperationMode = true;
        /// <summary>
        /// 数据保存间隔时间 秒
        /// </summary>
        public static int UpdateInterval = 1;
        /// <summary>
        /// 数据保存间隔电压 mV
        /// </summary>
        public static int VoltInterval = 10;
        /// <summary>
        /// 数据保存间隔电流 mA
        /// </summary>
        public static int CurreInterval = 30;

        /// <summary>
        /// 无电池通道电压上限 mV
        /// </summary>
        public static int NOCellchannelVolt = 300;

        /// <summary>
        /// 列
        /// </summary>
        private static int nUM_STAGEPERDEVICE = 10;
        public static int NUM_STAGEPERDEVICE { get => nUM_STAGEPERDEVICE; private set => nUM_STAGEPERDEVICE = value; }
        /// <summary>
        /// 层
        /// </summary>  
        private static int nUM_DEVICEPERLINE = 6;
        public static int NUM_DEVICEPERLINE { get => nUM_DEVICEPERLINE; private set => nUM_DEVICEPERLINE = value; }

        /// <summary>
        /// 设备数量
        /// </summary>
        public static int NUM_ALLSTAGES { get; private set; }


        /// <summary>
        /// 硬件实际通道(单块板通道数量)
        /// </summary>
        public const int CHANNELColumn_MCU = 16;
        /// <summary>
        /// 硬件实际通道(板子数量)
        /// </summary> 
        public const int CHANNELRow_MCU = 16;
        /// <summary>
        /// 硬件实际通道数量
        /// </summary>
        public const int CHANNELS_MCU = CHANNELColumn_MCU * CHANNELRow_MCU;
        /// <summary>
        /// 用户通道列(单块板通道数量)
        /// </summary>
        public const int CHANNELColumn = 14;
        /// <summary>
        /// 用户通道行(板子数量)
        /// </summary>
        public const int CHANNELRow = 14;
        /// <summary>
        /// 用户通道数量
        /// </summary>
        public const int CHANNELS = CHANNELColumn * CHANNELRow;

        public static TParameterLimit ParameterLimit = new();
        public static TDeviceNGCount DeviceNGCount = new();

        /// <summary>
        /// 上位机转下位机映射 从0开始 数组索引是上位机的通道号
        /// </summary>
        public static int[] Mapping = new int[GlobalDefine.CHANNELS];
        /// <summary>
        /// 下位机IP1
        /// </summary>
        public static string[] IPs = new string[CHANNELS];

        //WMSIP MESIP
        public static string WMSIP = "";
        public static string MESIP = "";

        /// <summary>
        /// 设备类型
        /// </summary>
        public static TDeviceType[] DeviceTypes = new TDeviceType[CHANNELS];
        /// <summary>
        /// 启用标记
        /// </summary>
        public static bool[] VacancyFlags = new bool[CHANNELS];
        /// <summary>
        /// 手自动标记 true：自动；false：手动  
        /// </summary>
        public static bool[] ManualAutoFlags = new bool[CHANNELS];

        public static readonly string ErrorMesLogPath
            = @"D:\CDSystem\ErrorMesLog\";

        public static readonly string DataPath
            = @"D:\CDSystem\";
        public static readonly string ManualPath
            = @"\Manual\";
        public static readonly string AutoPath
            = @"\Auto\";

        public static readonly string PATH_MAIN
            = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string SystemPath
            = PATH_MAIN + @"System\";
        public static readonly string StagePath
            = PATH_MAIN + @"Stage\";
        public static readonly string CellTestRecordPath
            = SystemPath + @"CellTestRecord\";
        public static readonly string OperatingStatisticPath
            = SystemPath + @"OperatingStatistic\";
        public static readonly string PartStatisticPath
            = SystemPath + @"PartStatistic\";
        public static readonly string ProcessPath
            = SystemPath + @"Processes\";

        public static readonly string DeviceTypeFile
            = SystemPath + "DeviceType.dat";
        public static readonly string IPFile
            = SystemPath + "IP.dat";
        public static readonly string VacancyFlagFile
            = SystemPath + "VacancyFlag.dat";
        public static readonly string ManualAutoFlagFile
            = SystemPath + "ManualAutoFlag.dat";
        public static readonly string MappingFile
            = SystemPath + "Mapping.dat";
        public static readonly string MappingMCUFile
            = SystemPath + "MappingMCU.dat";
        public static readonly string ConfigFile
            = SystemPath + "Config.dat";
        public static readonly string ParameterLimitFile
            = SystemPath + "ParameterLimitFile.dat";
        public static readonly string NGCountFile
            = SystemPath + "NGCount.dat";
        public static readonly string ProcessFile
            = SystemPath + "Processes.dat";

        public static readonly string RunLogFile
            = "RunLog.db";
        public static readonly string AlarmLogFile
            = "AlarmLog.db";
        public static readonly string ErrorLogFile
            = "ErrorLog.db";
        public static readonly string MesLogFile
            = "MesLog.db";

        public static readonly string OperatingStatisticPathFile
            = OperatingStatisticPath + "OperatingStatistic.db";
        public static readonly string PartStatisticPathFile
            = PartStatisticPath + "PartStatistic.db";
        public static readonly string CellTestRecordFile
            = CellTestRecordPath + "CellTestRecord.db";


        /// <summary>
        /// 流程中
        /// </summary>
        public static TProcessFlag[] ProcessFlagInProc = new TProcessFlag[] {
            TProcessFlag.pfNoCellCheck,
            TProcessFlag.pfReady,
            TProcessFlag.pfWaitFixProc,
            TProcessFlag.pfWaitOCVTest,
            TProcessFlag.pfWaitContactTest,
            TProcessFlag.pfWaitProcStart,
            TProcessFlag.pfAutoInProc,
            TProcessFlag.pfManualInProc,
            TProcessFlag.pfWaitContinue,
        };

        public static void NumAllSTAGES(int DEVICEPERLINE, int STAGEPERDEVICE)
        {
            NUM_DEVICEPERLINE = DEVICEPERLINE;
            NUM_STAGEPERDEVICE = STAGEPERDEVICE;
            NUM_ALLSTAGES = NUM_DEVICEPERLINE * NUM_STAGEPERDEVICE;
        }
    }

    public enum TStageState : byte
    {
        /// <summary>
        /// 初始状态
        /// </summary>
        [Description("TStageState_ssInit")]
        ssInit = 0,
        /// <summary>
        /// 未启用
        /// </summary>
        [Description("TStageState_ssVacancy")]
        ssVacancy = 1,
        /// <summary>
        /// 无通信
        /// </summary>
        [Description("TStageState_ssOff")]
        ssOff = 2,
        /// <summary>
        /// 托盘进入
        /// </summary>
        [Description("TStageState_ssTrayIn")]
        ssTrayIn = 3,
        /// <summary>
        /// 流程准备
        /// </summary>
        [Description("TStageState_ssReady")]
        ssReady = 4,
        /// <summary>
        /// 流程等待
        /// </summary>
        [Description("TStageState_ssWait")]
        ssWait = 5,
        /// <summary>
        /// 流程中
        /// </summary>
        [Description("TStageState_ssRunning")]
        ssRunning = 6,
        /// <summary>
        /// 作业完成
        /// </summary>
        [Description("TStageState_ssProcessEnd")]
        ssProcessEnd = 7,
        /// <summary>
        /// 机构错误
        /// </summary>
        [Description("TStageState_ssEMG")]
        ssEMG = 8,
        /// <summary>
        /// 上位机报警
        /// </summary>
        [Description("TStageState_ssPCAlarm")]
        ssPCAlarm = 9,
        /// <summary>
        /// 超温报警
        /// </summary>
        [Description("TStageState_ssTemp")]
        ssTemp = 10,
        /// <summary>
        /// 烟雾报警
        /// </summary>
        [Description("TStageState_ssSmoke")]
        ssSmoke = 11,
        /// <summary>
        /// 超时
        /// </summary>
        [Description("TStageState_ssOverTime")]
        ssOverTime = 12,
        /// <summary>
        /// 充放电测试报警
        /// </summary>
        [Description("TStageState_ssChargeDis")]
        ssChargeDis = 13,
        /// <summary>
        /// 掉电标记
        /// </summary>
        [Description("TStageState_ssPowerDown")]
        ssPowerDown = 15,
        /// <summary>
        /// 等待出库
        /// </summary>
        [Description("TStageState_ssWaitOutbound")]
        ssWaitOutbound = 16,
        /// <summary>
        /// 托盘位置错误
        /// </summary>
        [Description("TStageState_ssTrayError")]
        ssTrayError = 17,
        /// <summary>
        /// 火警警告
        /// </summary>
        [Description("TStageState_ssFireAlarm")]
        ssFireAlarm = 18,
    }


    public enum TProcessFlag : byte
    {
        /// <summary>
        /// 初始状态
        /// </summary>
        [Description("TProcessFlag_ssInit")]
        pfInit,
        /// <summary>
        /// 无电池通道检测
        /// </summary>
        [Description("TProcessFlag_pfNoCellCheck")]
        pfNoCellCheck,
        /// <summary>
        /// 流程准备
        /// </summary>
        [Description("TProcessFlag_pfReady")]
        pfReady,
        /// <summary>
        /// 流程获取或发送
        /// </summary>
        [Description("TProcessFlag_pfWaitFixProc")]
        pfWaitFixProc,
        /// <summary>
        /// OCV测试
        /// </summary>
        [Description("TProcessFlag_pfWaitOCVTest")]
        pfWaitOCVTest,
        /// <summary>
        /// 接触测试
        /// </summary>
        [Description("TProcessFlag_pfWaitContactTest")]
        pfWaitContactTest,
        /// <summary>
        /// 接触测试
        /// </summary>
        [Description("TProcessFlag_pfInContactTest")]
        pfInContactTest,
        /// <summary>
        /// 流程启动
        /// </summary>
        [Description("TProcessFlag_pfWaitProcStart")]
        pfWaitProcStart,
        /// <summary>
        /// 流程自动运行中
        /// </summary>
        [Description("TProcessFlag_pfAutoInProc")]
        pfAutoInProc,
        /// <summary>
        /// 流程手动运行中
        /// </summary>
        [Description("TProcessFlag_pfManualInProc")]
        pfManualInProc,
        /// <summary>
        /// 流程自动停止
        /// </summary>
        [Description("TProcessFlag_pfAutoProcEnd")]
        pfAutoProcEnd,
        /// <summary>
        /// 流程手动停止
        /// </summary>
        [Description("TProcessFlag_pfManualProcEnd")]
        pfManualProcEnd,
        /// <summary>
        /// 流程恢复
        /// </summary>
        [Description("TProcessFlag_pfWaitContinue")]
        pfWaitContinue,
        /// <summary>
        /// 无电池通道检测错误
        /// </summary>
        [Description("TProcessFlag_pfNoCellCheckNG")]
        pfNoCellCheckNG,
        /// <summary>
        /// 流程等待时错误
        /// </summary>
        [Description("TProcessFlag_pfWaitNG")]
        pfWaitNG,
        /// <summary>
        /// 流程获取或发送失败
        /// </summary>
        [Description("TProcessFlag_pfWaitFixProcNG")]
        pfWaitFixProcNG,
        /// <summary>
        /// OCV测试失败
        /// </summary>
        [Description("TProcessFlag_pfWaitOCVTestNG")]
        pfWaitOCVTestNG,
        /// <summary>
        /// 接触测试错误
        /// </summary>
        [Description("TProcessFlag_pfWaitContactTestNG")]
        pfWaitContactTestNG,
        /// <summary>
        /// 流程启动失败
        /// </summary>
        [Description("TProcessFlag_pfWaitProcStartNG")]
        pfWaitProcStartNG,
        /// <summary>
        /// 流程运行中错误
        /// </summary>
        [Description("TProcessFlag_pfInProcNG")]
        pfInProcNG,
        /// <summary>
        /// 流程运行中错误
        /// </summary>
        [Description("TProcessFlag_pfOnMnStopNG")]
        pfOnMnStopNG,
        /// <summary>
        /// 流程结束错误
        /// </summary>
        [Description("TProcessFlag_pfEndNG")]
        pfEndNG,
        /// <summary>
        /// 流程恢复失败
        /// </summary>
        [Description("TProcessFlag_pfWaitContinueNG")]
        pfWaitContinueNG,
    }

    public enum Lang : int
    {
        zh = 0,
        en = 1,
    }

    //程序类型
    public enum TGramType
    {
        CDC1,
        CDC2,
        CDC3,
    }
}