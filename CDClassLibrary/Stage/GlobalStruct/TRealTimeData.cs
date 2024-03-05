using System.ComponentModel;
using System.Runtime.InteropServices;

namespace CDClassLibrary.Stage
{
    /// <summary>
    /// 实时数据（0xA103）
    /// </summary>
    public struct TRealTimeDataMCU
    {
        /// <summary>
        /// 流程绝对时间(生产模式)
        /// 流程工作绝对时间，绝对时间年-月-日-时-分-秒-毫秒
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] ProcessAbsoluteTime;
        /// <summary>
        /// 流程总时间(生产模式)
        /// 流程工作的总时间，相对时间，单位：毫秒，流程启动后从零开始计数，包括暂停、异常处理、转步时间，直到流程结束停止计时
        /// </summary>
        public Int32 ProcessTime;
        /// <summary>
        /// 步次工作时间(生产模式)
        /// 当前步次的实际工作时间，不包括转步时间，单位：毫秒
        /// </summary>
        public Int32 StepWorkTime;
        /// <summary>
        /// 流程总工作状态(生产模式)
        /// </summary>
        public TProcessStatus ProcessStatus;
        /// <summary>
        /// 步次序号
        /// </summary>
        public byte StepNo;
        /// <summary>
        /// 步次类型
        /// </summary>
        public TStepMode StepMode;
        /// <summary>
        /// 1 级循环起始步次序号(生产模式)
        /// 当前步次所在 1 级循环的起始步次序号，从 1 开始
        /// </summary>
        public byte Cycle1StartStep;
        /// <summary>
        /// 1 级循环结束步次序号(生产模式)
        /// 当前步次所在 1 级循环的结束步次序号，从 1 开始
        /// </summary>
        public byte Cycle1EndStep;
        /// <summary>
        /// 1 级循环完成次数(生产模式)
        /// 当前步次所在 1 级循环已完成的次数，从 1 开始
        /// </summary>
        public byte Cycle1RunCount;
        /// <summary>
        /// 1 级循环剩余次数(生产模式)
        /// 当前步次所在 1 级循环还剩余的次数，从 1 开始
        /// </summary>
        public byte Cycle1RemainCount;
        /// <summary>
        /// 2 级循环起始步次序号(生产模式)
        /// 当前步次所在 2 级循环的起始步次序号，从 1 开始
        /// </summary>
        public byte Cycle2StartStep;
        /// <summary>
        /// 2 级循环结束步次序号(生产模式)
        /// 当前步次所在 2 级循环的结束步次序号，从 1 开始
        /// </summary>
        public byte Cycle2EndStep;
        /// <summary>
        /// 2 级循环完成次数(生产模式)
        /// 当前步次所在 2 级循环已完成的次数，从 1 开始
        /// </summary>
        public byte Cycle2RunCount;
        /// <summary>
        /// 2 级循环剩余次数(生产模式)
        /// 当前步次所在 2 级循环还剩余的次数，从 1 开始
        /// </summary>
        public byte Cycle2RemainCount;
        /// <summary>
        /// 3 级循环起始步次序号(生产模式)
        /// 当前步次所在 3 级循环的起始步次序号，从 1 开始
        /// </summary>
        public byte Cycle3StartStep;
        /// <summary>
        /// 3 级循环结束步次序号(生产模式)
        /// 当前步次所在 3 级循环的结束步次序号，从 1 开始
        /// </summary>
        public byte Cycle3EndStep;
        /// <summary>
        /// 3 级循环完成次数(生产模式)
        /// 当前步次所在 3 级循环已完成的次数，从 1 开始
        /// </summary>
        public byte Cycle3RunCount;
        /// <summary>
        /// 3 级循环剩余次数(生产模式)
        /// 当前步次所在 3 级循环还剩余的次数，从 1 开始
        /// </summary>
        public byte Cycle3RemainCount;
        /// <summary>
        /// 接触测试状态
        /// </summary>
        public TContactTestFlag ContactTestFlag;
        /// <summary>
        /// 关键数据有效文件数量
        /// 0：表示没有关键数据文件
        /// </summary>
        public Int16 ResultFileCount;
        /// <summary>
        /// 转步等待标记（只在步次同步功能中使用）
        /// 0x55：当前步次结束，处于转步等待状态，允许转步；
        /// 其它：步次未结束，不允许转步；
        /// </summary>
        public byte WaitNext;
        /// <summary>
        /// 预留
        /// </summary> 
        public byte ReserveNull;
        /// <summary>
        /// 闲时总时间
        /// 从机构闭合开始计算的时间，相对时间，单位：毫秒
        /// </summary>
        public Int32 IdleTime;
        /// <summary>
        /// 电源模块状态
        /// Bit0: 正 15 伏状态，0 正常，1 无或异常
        /// Bit1: 负 15 伏状态，0 正常，1 无或异常
        /// Bit2: 逆变器状态，0 正常，1 无或异常
        /// </summary>
        public byte PowerStatus;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public byte[] ReserveNull2;
        /// <summary>
        /// 通道实时数据
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GlobalDefine.CHANNELS_MCU)]
        public TChannelRealTimeDataMCU[] ChannelRealTimeDataMCU;

        public TRealTimeDataMCU()
        {
            ProcessAbsoluteTime = new byte[12];
            for (int i = 0; i < 12; i++)
                ProcessAbsoluteTime[i] = 0;
            ProcessTime = 0;
            StepWorkTime = 0;
            ProcessStatus = TProcessStatus.Init;
            StepNo = 0;
            StepMode = TStepMode.SKIP;
            Cycle1StartStep = 0;
            Cycle1EndStep = 0;
            Cycle1RunCount = 0;
            Cycle1RemainCount = 0;
            Cycle2StartStep = 0;
            Cycle2EndStep = 0;
            Cycle2RunCount = 0;
            Cycle2RemainCount = 0;
            Cycle3StartStep = 0;
            Cycle3EndStep = 0;
            Cycle3RunCount = 0;
            Cycle3RemainCount = 0;
            ContactTestFlag = TContactTestFlag.Init;
            ResultFileCount = 0;
            WaitNext = 0;
            ReserveNull = 0;
            IdleTime = 0;
            PowerStatus = 0;
            ReserveNull2 = new byte[7];
            ChannelRealTimeDataMCU = new TChannelRealTimeDataMCU[GlobalDefine.CHANNELS_MCU];
            for (int i = 0; i < GlobalDefine.CHANNELS_MCU; i++)
                ChannelRealTimeDataMCU[i] = new TChannelRealTimeDataMCU();
        }
    }

    /// <summary>
    /// 通道实时数据
    /// </summary>
    public struct TChannelRealTimeDataMCU
    {
        /// <summary>
        /// 通道的流程总工作时间 
        /// 相对时间，单位：毫秒，流程启动后从零开始计数，包括暂停、异常处理、转步时间，直到流程结束停止计时  
        /// </summary>
        public Int32 ProcessTime;
        /// <summary>
        /// 步次工作时间
        /// 当前步次的实际工作时间，不包括转步时间，单位：毫秒
        /// </summary>
        public Int32 StepWorkTime;
        /// <summary>
        /// 通道工作状态
        /// </summary>
        public TProcessStatus ProcessStatus;
        /// <summary>
        /// 通道步次序号
        /// </summary>
        public byte StepNo;
        /// <summary>
        /// 通道步次类型
        /// </summary>
        public TStepMode StepMode;
        /// <summary>
        /// 1 级循环起始步次序号(生产模式)
        /// 当前步次所在 1 级循环的起始步次序号，从 1 开始
        /// </summary>
        public byte Cycle1StartStep;
        /// <summary>
        /// 1 级循环结束步次序号(生产模式)
        /// 当前步次所在 1 级循环的结束步次序号，从 1 开始
        /// </summary>
        public byte Cycle1EndStep;
        /// <summary>
        /// 1 级循环完成次数(生产模式)
        /// 当前步次所在 1 级循环已完成的次数，从 1 开始
        /// </summary>
        public byte Cycle1RunCount;
        /// <summary>
        /// 1 级循环剩余次数(生产模式)
        /// 当前步次所在 1 级循环还剩余的次数，从 1 开始
        /// </summary>
        public byte Cycle1RemainCount;
        /// <summary>
        /// 2 级循环起始步次序号(生产模式)
        /// 当前步次所在 2 级循环的起始步次序号，从 1 开始
        /// </summary>
        public byte Cycle2StartStep;
        /// <summary>
        /// 2 级循环结束步次序号(生产模式)
        /// 当前步次所在 2 级循环的结束步次序号，从 1 开始
        /// </summary>
        public byte Cycle2EndStep;
        /// <summary>
        /// 2 级循环完成次数(生产模式)
        /// 当前步次所在 2 级循环已完成的次数，从 1 开始
        /// </summary>
        public byte Cycle2RunCount;
        /// <summary>
        /// 2 级循环剩余次数(生产模式)
        /// 当前步次所在 2 级循环还剩余的次数，从 1 开始
        /// </summary>
        public byte Cycle2RemainCount;
        /// <summary>
        /// 3 级循环起始步次序号(生产模式)
        /// 当前步次所在 3 级循环的起始步次序号，从 1 开始
        /// </summary>
        public byte Cycle3StartStep;
        /// <summary>
        /// 3 级循环结束步次序号(生产模式)
        /// 当前步次所在 3 级循环的结束步次序号，从 1 开始
        /// </summary>
        public byte Cycle3EndStep;
        /// <summary>
        /// 3 级循环完成次数(生产模式)
        /// 当前步次所在 3 级循环已完成的次数，从 1 开始
        /// </summary>
        public byte Cycle3RunCount;
        /// <summary>
        /// 3 级循环剩余次数(生产模式)
        /// 当前步次所在 3 级循环还剩余的次数，从 1 开始
        /// </summary>
        public byte Cycle3RemainCount;
        /// <summary>
        /// 通道诊断值
        /// </summary>
        public byte ChnState;
        /// <summary>
        /// 通道电压
        /// 有符号, *100，单位 mV
        /// </summary>
        public Int32 Volt;
        /// <summary>
        /// 通道电流 
        /// 有符号，*100，单位 mA
        /// </summary>
        public Int32 Curre;
        /// <summary>
        /// 通道线电压
        /// 有符号, *100，单位 mV
        /// </summary>
        public Int32 LineVolt;
        /// <summary>
        /// 通道容量 
        /// 无符号，*100，单位 mAh
        /// </summary>
        public UInt32 Capacity;
        /// <summary>
        /// 通道能量/功率值 
        /// 能量：无符号，*100，单位 mWh
        /// 恒功率模式下为功率值：*100, 单位 mW
        /// </summary>
        public UInt32 Energy;
        /// <summary>
        /// 通道温度 
        /// 有符号，*100, 单位度
        /// </summary>
        public Int16 ChannelTemp;
        /// <summary>
        /// 电池温度 
        /// 有符号，*100, 单位度
        /// </summary>
        public Int16 CellTemp;
        /// <summary>
        /// 通道风机状态
        /// </summary>
        public TFanState FanStatus;
        /// <summary>
        /// 保留
        /// </summary>
        public byte null1;
        /// <summary>
        /// 接触阻抗 
        /// 无符号，*100，单位毫欧
        /// </summary>
        public UInt16 IR;

        public TChannelRealTimeDataMCU()
        {
            ProcessTime = 0;
            StepWorkTime = 0;
            ProcessStatus = 0;
            StepNo = 0;
            StepMode = TStepMode.SKIP;
            Cycle1StartStep = 0;
            Cycle1EndStep = 0;
            Cycle1RunCount = 0;
            Cycle1RemainCount = 0;
            Cycle2StartStep = 0;
            Cycle2EndStep = 0;
            Cycle2RunCount = 0;
            Cycle2RemainCount = 0;
            Cycle3StartStep = 0;
            Cycle3EndStep = 0;
            Cycle3RunCount = 0;
            Cycle3RemainCount = 0;
            ChnState = 0;
            Volt = 0;
            Curre = 0;
            LineVolt = 0;
            Capacity = 0;
            Energy = 0;
            ChannelTemp = 0;
            CellTemp = 0;
            FanStatus = 0;
            null1 = 0;
            IR = 0;
        }
    }

    /// <summary>
    /// 实时数据 
    /// </summary>
    [Serializable]
    public class TRealTimeData
    {
        /// <summary>
        /// 流程绝对时间(生产模式)
        /// 流程工作绝对时间，绝对时间年-月-日-时-分-秒-毫秒
        /// </summary>  
        //public DateTime ProcessAbsoluteTime = new DateTime();

        /// <summary>
        /// 流程总时间(生产模式)
        /// 流程工作的总时间，相对时间，流程启动后从零开始计数，包括暂停、异常处理、转步时间，直到流程结束停止计时
        /// </summary>
        public double ProcessTime = 0;
        /// <summary>
        /// 步次工作时间(生产模式)
        /// 当前步次的实际工作时间，不包括转步时间
        /// </summary>
        public double StepWorkTime = 0;
        /// <summary>
        /// 流程总工作状态(生产模式)
        /// </summary>
        public TProcessStatus ProcessStatus = TProcessStatus.Init;
        /// <summary>
        /// 步次序号
        /// </summary>
        public int StepNo = 0;
        /// <summary>
        /// 步次类型
        /// </summary>
        public TStepMode StepMode = TStepMode.SKIP;
        /// <summary>
        /// 1 级循环起始步次序号(生产模式)
        /// 当前步次所在 1 级循环的起始步次序号，从 1 开始
        /// </summary>
        public int Cycle1StartStep = 0;
        /// <summary>
        /// 1 级循环结束步次序号(生产模式)
        /// 当前步次所在 1 级循环的结束步次序号，从 1 开始
        /// </summary>
        public int Cycle1EndStep = 0;
        /// <summary>
        /// 1 级循环完成次数(生产模式)
        /// 当前步次所在 1 级循环已完成的次数，从 1 开始
        /// </summary>
        public int Cycle1RunCount = 0;
        /// <summary>
        /// 1 级循环剩余次数(生产模式)
        /// 当前步次所在 1 级循环还剩余的次数，从 1 开始
        /// </summary>
        public int Cycle1RemainCount = 0;
        /// <summary>
        /// 2 级循环起始步次序号(生产模式)
        /// 当前步次所在 2 级循环的起始步次序号，从 1 开始
        /// </summary>
        public int Cycle2StartStep = 0;
        /// <summary>
        /// 2 级循环结束步次序号(生产模式)
        /// 当前步次所在 2 级循环的结束步次序号，从 1 开始
        /// </summary>
        public int Cycle2EndStep = 0;
        /// <summary>
        /// 2 级循环完成次数(生产模式)
        /// 当前步次所在 2 级循环已完成的次数，从 1 开始
        /// </summary>
        public int Cycle2RunCount = 0;
        /// <summary>
        /// 2 级循环剩余次数(生产模式)
        /// 当前步次所在 2 级循环还剩余的次数，从 1 开始
        /// </summary>
        public int Cycle2RemainCount = 0;
        /// <summary>
        /// 3 级循环起始步次序号(生产模式)
        /// 当前步次所在 3 级循环的起始步次序号，从 1 开始
        /// </summary>
        public int Cycle3StartStep = 0;
        /// <summary>
        /// 3 级循环结束步次序号(生产模式)
        /// 当前步次所在 3 级循环的结束步次序号，从 1 开始
        /// </summary>
        public int Cycle3EndStep = 0;
        /// <summary>
        /// 3 级循环完成次数(生产模式)
        /// 当前步次所在 3 级循环已完成的次数，从 1 开始
        /// </summary>
        public int Cycle3RunCount = 0;
        /// <summary>
        /// 3 级循环剩余次数(生产模式)
        /// 当前步次所在 3 级循环还剩余的次数，从 1 开始
        /// </summary>
        public int Cycle3RemainCount = 0;
        /// <summary>
        /// 接触测试状态
        /// </summary>
        public TContactTestFlag ContactTestFlag = TContactTestFlag.Init;
        /// <summary>
        /// 关键数据有效文件数量
        /// 0：表示没有关键数据文件
        /// </summary>
        public int ResultFileCount = 0;
        /// <summary>
        /// 转步等待标记（只在步次同步功能中使用）
        /// true：当前步次结束，处于转步等待状态，允许转步；
        /// 其它：步次未结束，不允许转步；
        /// </summary>
        public bool WaitNext = false;
        /// <summary>
        /// 闭时总时间
        /// 从机构闭合开始计算的时间，相对时间
        /// </summary>
        public double IdleTime = 0;
        /// <summary>
        /// 正 15 伏状态，true 正常，1 无或异常
        /// </summary>
        public bool Positive15VState = false;
        /// <summary>
        /// 负 15 伏状态，true 正常，1 无或异常
        /// </summary>
        public bool Negative15VState = false;
        /// <summary>
        /// 逆变器状态，true 正常，false 无或异常
        /// </summary>
        public bool InverterState = false;

        /// <summary>
        /// 通道实时数据
        /// </summary> 
        public TChannelRealTimeData[] ChannelRealTimeData = new TChannelRealTimeData[GlobalDefine.CHANNELS];

        public TRealTimeData()
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                ChannelRealTimeData[ChnNo] = new TChannelRealTimeData();
        }
    }

    /// <summary>
    /// 通道实时数据
    /// </summary>
    [Serializable]
    public class TChannelRealTimeData
    {
        /// <summary>
        /// 通道号 
        /// 从 1 开始
        /// </summary>
        public int ChnNo = 0;
        /// <summary>
        /// 通道的流程总工作时间 
        /// 相对时间，单位：毫秒，流程启动后从零开始计数，包括暂停、异常处理、转步时间，直到流程结束停止计时  
        /// </summary>
        public double ProcessTime = 0;//
        /// <summary>
        /// 步次工作时间
        /// 当前步次的实际工作时间，不包括转步时间，单位：毫秒
        /// </summary>
        public double StepWorkTime = 0;//
        /// <summary>
        /// 通道工作状态
        /// </summary>
        public TProcessStatus ProcessStatus = TProcessStatus.Init;//
        /// <summary>
        /// 通道步次序号
        /// </summary>
        public int StepNo = 0;
        /// <summary>
        /// 通道步次类型
        /// </summary>
        public TStepMode StepMode = TStepMode.SKIP;
        /// <summary>
        /// 1 级循环起始步次序号(生产模式)
        /// 当前步次所在 1 级循环的起始步次序号，从 1 开始
        /// </summary>
        public int Cycle1StartStep = 0;
        /// <summary>
        /// 1 级循环结束步次序号(生产模式)
        /// 当前步次所在 1 级循环的结束步次序号，从 1 开始
        /// </summary>
        public int Cycle1EndStep = 0;
        /// <summary>
        /// 1 级循环完成次数(生产模式)
        /// 当前步次所在 1 级循环已完成的次数，从 1 开始
        /// </summary>
        public int Cycle1RunCount = 0;
        /// <summary>
        /// 1 级循环剩余次数(生产模式)
        /// 当前步次所在 1 级循环还剩余的次数，从 1 开始
        /// </summary>
        public int Cycle1RemainCount = 0;
        /// <summary>
        /// 2 级循环起始步次序号(生产模式)
        /// 当前步次所在 2 级循环的起始步次序号，从 1 开始
        /// </summary>
        public int Cycle2StartStep = 0;
        /// <summary>
        /// 2 级循环结束步次序号(生产模式)
        /// 当前步次所在 2 级循环的结束步次序号，从 1 开始
        /// </summary>
        public int Cycle2EndStep = 0;
        /// <summary>
        /// 2 级循环完成次数(生产模式)
        /// 当前步次所在 2 级循环已完成的次数，从 1 开始
        /// </summary>
        public int Cycle2RunCount = 0;
        /// <summary>
        /// 2 级循环剩余次数(生产模式)
        /// 当前步次所在 2 级循环还剩余的次数，从 1 开始
        /// </summary>
        public int Cycle2RemainCount = 0;
        /// <summary>
        /// 3 级循环起始步次序号(生产模式)
        /// 当前步次所在 3 级循环的起始步次序号，从 1 开始
        /// </summary>
        public int Cycle3StartStep = 0;
        /// <summary>
        /// 3 级循环结束步次序号(生产模式)
        /// 当前步次所在 3 级循环的结束步次序号，从 1 开始
        /// </summary>
        public int Cycle3EndStep = 0;
        /// <summary>
        /// 3 级循环完成次数(生产模式)
        /// 当前步次所在 3 级循环已完成的次数，从 1 开始
        /// </summary>
        public int Cycle3RunCount = 0;
        /// <summary>
        /// 3 级循环剩余次数(生产模式)
        /// 当前步次所在 3 级循环还剩余的次数，从 1 开始
        /// </summary>
        public int Cycle3RemainCount = 0;
        /// <summary>
        /// 通道诊断值
        /// </summary>
        public byte ChnState = 0;//
        /// <summary>
        /// 通道电压
        /// 有符号, *100，单位 mV
        /// </summary>
        public double Volt = 0;//
        /// <summary>
        /// 通道电流 
        /// 有符号，*100，单位 mA
        /// </summary>
        public double Curre = 0;//
        /// <summary>
        /// 通道线电压
        /// 有符号, *100，单位 mV
        /// </summary>
        public double LineVolt = 0;//
        /// <summary>
        /// 通道容量 
        /// 无符号，*100，单位 mAh
        /// </summary>
        public double Capacity = 0;//
        /// <summary>
        /// 通道能量/功率值 
        /// 能量：无符号，*100，单位 mWh
        /// 恒功率模式下为功率值：*100, 单位 mW
        /// </summary>
        public double Energy = 0;//
        /// <summary>
        /// 通道温度 
        /// 有符号，*100, 单位度
        /// </summary>
        public double ChannelTemp = 0;//
        /// <summary>
        /// 电池温度 
        /// 有符号，*100, 单位度
        /// </summary>
        public double CellTemp = 0;//
        /// <summary>
        /// 通道风机状态
        /// </summary>
        public TFanState FanStatus = TFanState.fsError;
        /// <summary>
        /// 接触阻抗 
        /// 无符号，*100，单位毫欧
        /// </summary>
        public double IR = 0;//
    }

    /// <summary>
    /// 流程总工作状态(生产模式)
    /// 0x00 初始状态（从未工作过的状态）
    /// 0x01 启动
    /// 0x02 暂停
    /// 0x03 停止
    /// </summary>
    public enum TProcessStatus : byte
    {
        /// <summary>
        /// 初始状态（从未工作过的状态）
        /// </summary>
        [Description("TProcessStatus_Init")]
        Init = 0x00,
        /// <summary>
        /// 启动
        /// </summary>
        [Description("TProcessStatus_Running")]
        Running = 0x01,
        /// <summary>
        /// 暂停
        /// </summary>
        [Description("TProcessStatus_Suspend")]
        Suspend = 0x02,
        /// <summary>
        /// 停止
        /// </summary>
        [Description("TProcessStatus_Stop")]
        Stop = 0x03,
    }

    /// <summary>
    /// 接触测试状态 
    /// </summary>
    public enum TContactTestFlag : byte
    {
        /// <summary>
        /// 初始状态或接触测试中
        /// </summary>
        [Description("TContactTestFlag_Init")]
        Init = 0,
        /// <summary>
        /// 接触测试启动失败：流程数据无效
        /// </summary>
        [Description("TContactTestFlag_Error1")]
        Error1 = 0x21,
        /// <summary>
        /// 接触测试启动失败：软件授权到期
        /// </summary>
        [Description("TContactTestFlag_Error2")]
        Error2 = 0x22,
        /// <summary>
        /// 接触测试启动失败：平台故障
        /// </summary>
        [Description("TContactTestFlag_Error3")]
        Error3 = 0x23,
        /// <summary>
        /// 接触测试完成
        /// </summary>
        [Description("TContactTestFlag_Complete")]
        Complete = 0x41
    }
}
