using System.Runtime.InteropServices;

namespace CDClassLibrary.Stage
{
    /// <summary>
    /// 关键数据
    /// </summary>
    public struct TResultDataMCU
    {
        /// <summary>
        /// 单通道单步次关键数据
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]
        public TChannelResultDataMCU[] ChannelResultDataMCU;
        public TResultDataMCU()
        {
            ChannelResultDataMCU = new TChannelResultDataMCU[200];
            for (int i = 0; i < 200; i++)
                ChannelResultDataMCU[i] = new TChannelResultDataMCU();
        }
    }

    /// <summary>
    /// 单通道单步次关键数据
    /// </summary>
    public struct TChannelResultDataMCU
    {
        /// <summary>
        /// 通道号 
        /// 从 1 开始
        /// </summary>
        public UInt16 ChnNo;
        /// <summary>
        /// 1 级循环次数
        /// </summary>
        public byte Cycle1Count;
        /// <summary>
        /// 2 级循环次数
        /// </summary>
        public byte Cycle2Count;
        /// <summary>
        /// 3 级循环次数
        /// </summary>
        public byte Cycle3Count;
        /// <summary>
        /// 步次序号 
        /// 从 1 开始 
        /// </summary>
        public byte StepNo;
        /// <summary>
        /// 步次类型
        /// </summary>
        public TStepMode StepMode;
        /// <summary>
        /// 保留
        /// </summary>
        public byte ReserveNull;
        /// <summary>
        /// 流程总工作时间 
        /// 单位：毫秒
        /// </summary>
        public UInt32 ProcessTime;
        /// <summary>
        /// 步次绝对时间  
        /// 年-月-日-时-分-秒-毫秒
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] StepWorkTime;
        /// <summary>
        /// 关键数据有效标记
        /// 以 bit 为单位表示关键数据是否有效，
        /// 0 表示对应关键数据无效，1 表示对应
        /// 关键数据有效。
        /// Bit0：步次起始关键数据
        /// Bit1：预留（设定时刻 1 关键数据）
        /// Bit2：步次结束关键数据
        /// Bit3：暂停关键数据
        /// Bit4：掉电关键数据
        /// Bit5：恒流转恒压关键数据
        /// Bit6：容量能量关键数据
        /// Bit7：5 分钟电流关键数据
        /// 其他：保留
        /// </summary>
        public UInt16 DataValidFlag;
        /// <summary>
        /// 通道保护状态
        /// </summary>
        public byte ChnState;
        /// <summary>
        /// 保留
        /// </summary>
        public byte ReserveNull2;
        /// <summary>
        /// 步次起始电压 0 时刻，步次启动时候的电压, 单位 mV，*100，有符号
        /// </summary>
        public Int32 StartVolt;
        /// <summary>
        /// 步次起始电流 单位 mA，*100，有符号
        /// </summary>
        public Int32 StartCurre;
        /// <summary>
        /// 步次起始环境温度 有符号，*100, 单位度
        /// </summary>
        public Int16 StartEnvTemp;
        /// <summary>
        /// 步次结束环境温度 有符号，*100, 单位度
        /// </summary>
        public Int16 EndEnvTemp;
        /// <summary>
        /// 步次平均环境温度 有符号，*100, 单位度
        /// </summary>
        public Int16 AvgEnvTemp;
        /// <summary>
        /// 步次平均电池温度 有符号，*100, 单位度
        /// </summary>
        public Int16 AvgCellTemp;
        /// <summary>
        /// 步次结束时刻线电压 单位 mV，*100，有符号
        /// </summary>
        public Int32 EndCurreVolt;
        /// <summary>
        /// 步次结束时间 单位 ms，相对工作时间，相对于当前步次启动时间
        /// </summary>
        public UInt32 EndTime;
        /// <summary>
        /// 步次结束时刻电压 单位 mV，*100，有符号
        /// </summary>
        public Int32 EndVolt;
        /// <summary>
        /// 步次结束时刻电流 单位 mA，*100，有符号
        /// </summary>
        public Int32 EndCurre;
        /// <summary>
        /// 恒流转恒压时间 单位 ms，相对时间，只有对CCCV和DCCV有效，暂停时间不计入
        /// </summary>
        public UInt32 CCTime;
        /// <summary>
        /// 步次结束时刻容量 无符号, 单位 mAh，*100
        /// </summary>
        public UInt32 EndCapacity;
        /// <summary>
        /// 步次结束时刻能量/功率
        /// 能量：无符号, 单位 mWh，*100
        /// 恒功率模式下为功率值：*100, 单位mW
        /// </summary>
        public UInt32 EndEnengy;
        /// <summary>
        /// 5 分钟电流值  相对于当前步次启动时间，5分钟的电流值 单位 mA，*100，有符号
        /// </summary>
        public Int32 FiveMinCurre;
        /// <summary>
        /// 步次起始电池温度 有符号，*100, 单位度
        /// </summary>
        public Int16 StartCellTemp;
        /// <summary>
        /// 步次结束电池温度 有符号，*100,单位 度
        /// </summary>
        public Int16 EndCellTemp;
        /// <summary>
        /// CCCV步次中CC阶段的容量 无符号, 单位 mAh，*100
        /// </summary>
        public UInt32 CCCVCapacity;

        public TChannelResultDataMCU()
        {
            this.ChnNo = 0;
            this.Cycle1Count = 0;
            this.Cycle2Count = 0;
            this.Cycle3Count = 0;
            this.StepNo = 0;
            this.StepMode = TStepMode.SKIP;
            this.ReserveNull = 0;
            this.ProcessTime = 0;
            this.StepWorkTime = new byte[12];
            this.DataValidFlag = 0;
            this.ChnState = 0;
            this.ReserveNull2 = 0;
            this.StartVolt = 0;
            this.StartCurre = 0;
            this.StartEnvTemp = 0;
            this.EndEnvTemp = 0;
            this.AvgEnvTemp = 0;
            this.AvgCellTemp = 0;
            this.EndCurreVolt = 0;
            this.CCTime = 0;
            this.EndVolt = 0;
            this.EndCurre = 0;
            this.EndTime = 0;
            this.EndCapacity = 0;
            this.EndEnengy = 0;
            this.FiveMinCurre = 0;
            this.StartCellTemp = 0;
            this.EndCellTemp = 0;
            this.CCCVCapacity = 0;
        }
    }

    /// <summary>
    /// 关键数据
    /// </summary>
    [Serializable]
    public class TResultData
    {
        /// <summary>
        /// 单通道单步次关键数据
        /// </summary> 
        public TChannelResultData[] ChannelResultData = new TChannelResultData[200];
        public TResultData()
        {
            for (int i = 0; i < 200; i++)
                ChannelResultData[i] = new TChannelResultData();
        }
    }

    /// <summary>
    /// 单通道单步次关键数据
    /// </summary>
    [Serializable]
    public class TChannelResultData
    {
        public int DataID = 0;
        /// <summary>
        /// 通道号 
        /// 从 1 开始
        /// </summary>
        public int ChnNo = 0;
        /// <summary>
        /// 1 级循环次数
        /// </summary>
        public int Cycle1Count = 0;
        /// <summary>
        /// 2 级循环次数
        /// </summary>
        public int Cycle2Count = 0;
        /// <summary>
        /// 3 级循环次数
        /// </summary>
        public int Cycle3Count = 0;
        /// <summary>
        /// 步次序号 
        /// 从 1 开始 
        /// </summary>
        public int StepNo = 0;
        /// <summary>
        /// 步次类型
        /// </summary>
        public TStepMode StepMode = TStepMode.SKIP;
        /// <summary>
        /// 流程总工作时间 
        /// 单位：毫秒
        /// </summary>
        public double ProcessTime = 0;
        /// <summary>
        /// 步次绝对时间  
        /// 单位：毫秒
        /// </summary> 
        public double StepWorkTime = 0;

        /// <summary>
        /// 步次起始关键数据
        /// </summary>
        public bool DataStartValidFlag = false;
        /// <summary>
        /// 步次结束关键数据
        /// </summary>
        public bool DataEndValidFlag = false;
        /// <summary>
        /// 暂停关键数据
        /// </summary>
        public bool DataSuspendValidFlag = false;
        /// <summary>
        /// 掉电关键数据
        /// </summary>
        public bool DataPowerValidFlag = false;
        /// <summary>
        /// 恒流转恒压关键数据
        /// </summary>
        public bool DataCToVValidFlag = false;
        /// <summary>
        /// 容量能量关键数据
        /// </summary>
        public bool DataCapEnValidFlag = false;
        /// <summary>
        /// 5 分钟电流关键数据
        /// </summary>
        public bool Data5MinCurreValidFlag = false;

        /// <summary>
        /// 通道保护状态
        /// </summary>
        public byte ChnState = 0;
        /// <summary>
        /// 步次起始电压
        /// 0 时刻，步次启动时候的电压, 单位 mV，有符号
        /// </summary>
        public double StartVolt = 0;
        /// <summary>
        /// 步次起始电流
        /// 单位 mA，有符号
        /// </summary>
        public double StartCurre = 0;
        /// <summary>
        /// 步次起始环境温度
        /// 有符号， 单位度
        /// </summary>
        public double StartEnvTemp = 0;
        /// <summary>
        /// 步次结束环境温度
        /// 有符号，单位度
        /// </summary>
        public double EndEnvTemp = 0;
        /// <summary>
        /// 步次平均环境温度
        /// 有符号，单位度
        /// </summary>
        public double AvgEnvTemp = 0;
        /// <summary>
        /// 步次平均电池温度
        /// 有符号，单位度
        /// </summary>
        public double AvgCellTemp = 0;
        /// <summary>
        /// 步次结束时刻线电压
        /// 单位 mV，有符号
        /// </summary>
        public double EndCurreVolt = 0;
        /// <summary>
        /// 步次结束时间
        /// 单位 ms，相对工作时间，相对于当前步次启动时间
        /// </summary>
        public double EndTime = 0;
        /// <summary>
        /// 步次结束时刻电压
        /// 单位 mV，有符号
        /// </summary>
        public double EndVolt = 0;
        /// <summary>
        /// 步次结束时刻电流
        /// 单位 mA，有符号
        /// </summary>
        public double EndCurre = 0;
        /// <summary>
        /// 恒流转恒压时间
        /// 单位 ms，相对时间，只有对CCCV和DCCV有效，暂停时间不计入
        /// </summary>
        public double CCTime = 0;
        /// <summary>
        /// 步次结束时刻容量
        /// 无符号, 单位 mAh
        /// </summary>
        public double EndCapacity = 0;
        /// <summary>
        /// 步次结束时刻能量/功率
        /// 能量：无符号, 单位 mWh
        /// 恒功率模式下为功率值：单位mW
        /// </summary>
        public double EndEnengy = 0;
        /// <summary>
        /// 5 分钟电流值
        /// 相对于当前步次启动时间，5分钟的电流值 单位 mA，*100，有符号
        /// </summary>
        public double FiveMinCurre = 0;
        /// <summary>
        /// 步次起始电池温度
        /// 有符号，单位度
        /// </summary>
        public double StartCellTemp = 0;
        /// <summary>
        /// 步次结束电池温度 
        /// 有符号，单位 度
        /// </summary>
        public double EndCellTemp;
        /// <summary>
        /// CCCV步次中CC阶段的容量 
        /// 无符号, 单位 mAh
        /// </summary>
        public double CCCVCapacity = 0;

        /// <summary>
        /// 接触阻抗
        /// </summary>
        public double IR = 0;
    }
}
