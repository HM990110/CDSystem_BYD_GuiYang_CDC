using System.Runtime.InteropServices;

namespace CDClassLibrary.Stage
{
    /// <summary>
    /// 接触测试流程（0xAA01）
    /// </summary>
    public struct TContactTestProcessMCU
    {
        /// <summary>
        /// 接触测试类型
        /// 0x00：休眠（REST，不用）
        /// 0x02：恒流放电（DC，不用）
        /// 0x03：恒流充电（CC）
        /// 0x20: 开路测试（OCV，不用）
        /// 0x40: 跳过（SKIP，不用）
        /// </summary>
        public Int16 StepMode;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] ReserveNull;
        /// <summary>
        /// 程控电压
        /// 单位 mV，*100，有符号
        /// </summary>
        public Int32 ProgramVolt;
        /// <summary>
        /// 程控电流
        /// 单位 mA，*100，有符号
        /// </summary>
        public Int32 ProgramCurre;
        /// <summary>
        /// 接触测试时限
        /// 单位 s，时间范围 0~99，超出该值最大 99
        /// </summary>
        public Int32 ContactTestTime;
        /// <summary>
        /// 检测电压
        /// 单位 mV，*100，有符号
        /// </summary>
        public Int32 DetectVolt;
        /// <summary>
        /// 反接电压
        /// 单位 mV，*100，有符号
        /// </summary>
        public Int32 ReverbVolta;
        /// <summary>
        /// 电压上限
        /// 单位 mV，*100，有符号
        /// </summary>
        public Int32 VoltUpperLimit;
        /// <summary>
        /// 电压下限
        /// 单位 mV，*100，有符号
        /// </summary>
        public Int32 VoltLowerLimit;
        /// <summary>
        /// 电压最大变化
        /// 接触测试起始到结束电压变化的最大值，单位 mV，*100，有符号
        /// </summary>
        public Int32 VoltChangeMax;
        /// <summary>
        /// 电压最小变化
        /// 接触测试起始到结束电压变化的最小值，单位 mV，*100，有符号
        /// </summary>
        public Int32 VoltChangeMin;
        /// <summary>
        /// 电流偏差百分比%
        /// 接触测试过程中，采样值与设定值之间差值百分比，有正负偏差，两位数百分比
        /// </summary>
        public Int16 CurreDeviatePercent;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        public byte[] ReserveNull2;

        public TContactTestProcessMCU()
        {
            StepMode = 0x03;
            ReserveNull = new byte[2];
            ProgramVolt = 0;
            ProgramCurre = 0;
            ContactTestTime = 0;
            DetectVolt = 0;
            ReverbVolta = 0;
            VoltUpperLimit = 0;
            VoltLowerLimit = 0;
            VoltChangeMax = 0;
            VoltChangeMin = 0;
            CurreDeviatePercent = 0;
            ReserveNull2 = new byte[22];
        }
    }

    /// <summary>
    /// 接触测试流程
    /// </summary>
    [Serializable]
    public class TContactTestProcess
    {
        public bool IsContactTest = false;
        /// <summary>
        /// 程控电压
        /// 单位 mV，有符号
        /// </summary>
        public double ProgramVolt = 0;
        /// <summary>
        /// 程控电流
        /// 单位 mA，有符号
        /// </summary>
        public double ProgramCurre = 0;
        /// <summary>
        /// 接触测试时限
        /// 单位 s，时间范围 0~99，超出该值最大 99
        /// </summary>
        public int ContactTestTime = 0;
        /// <summary>
        /// 检测电压
        /// 单位 mV，有符号
        /// </summary>
        public double DetectVolt = 0;
        /// <summary>
        /// 反接电压
        /// 单位 mV，有符号
        /// </summary>
        public double ReverbVolta = 0;
        /// <summary>
        /// 电压上限
        /// 单位 mV，有符号
        /// </summary>
        public double VoltUpperLimit = 0;
        /// <summary>
        /// 电压下限
        /// 单位 mV，有符号
        /// </summary>
        public double VoltLowerLimit = 0;
        /// <summary>
        /// 电压最大变化
        /// 接触测试起始到结束电压变化的最大值，单位 mV，有符号
        /// </summary>
        public double VoltChangeMax = 0;
        /// <summary>
        /// 电压最小变化
        /// 接触测试起始到结束电压变化的最小值，单位 mV，有符号
        /// </summary>
        public double VoltChangeMin = 0;
        /// <summary>
        /// 电流偏差百分比%
        /// 接触测试过程中，采样值与设定值之间差值百分比，有正负偏差，两位数百分比
        /// </summary>
        public int CurreDeviatePercent = 0;
    }
}
