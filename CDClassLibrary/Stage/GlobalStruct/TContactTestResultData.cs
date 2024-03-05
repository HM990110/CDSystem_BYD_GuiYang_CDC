using System.Runtime.InteropServices;

namespace CDClassLibrary.Stage
{
    /// <summary>
    /// 接触测试关键数据（0xAA03）
    /// </summary>
    public struct TContactTestResultDataMCU
    {
        /// <summary>
        /// 接触测试启动绝对时间
        /// 流程工作绝对时间，绝对时间 年-月-日-时-分-秒-毫秒
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] ProcessTime;
        /// <summary>
        /// 通道测试数据
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GlobalDefine.CHANNELS_MCU)]
        public TChannelContactTestResultDataMCU[] ChannelContactTestResultDataMCU;
        public TContactTestResultDataMCU()
        {
            ProcessTime = new byte[12];
            for (int i = 0; i < 12; i++)
                ProcessTime[i] = 0;
            ChannelContactTestResultDataMCU = new TChannelContactTestResultDataMCU[GlobalDefine.CHANNELS_MCU];
            for (int i = 0; i < GlobalDefine.CHANNELS_MCU; i++)
                ChannelContactTestResultDataMCU[i] = new TChannelContactTestResultDataMCU();
        }
    }

    /// <summary>
    /// 通道测试数据
    /// </summary>
    public struct TChannelContactTestResultDataMCU
    {
        /// <summary>
        /// 通道状态
        /// </summary>
        public byte ChnState;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] ReserveNull;
        /// <summary>
        /// 通道起始电压 
        /// 单位 mV，*100，有符号
        /// </summary>
        public Int32 StartVolt;
        /// <summary>
        /// 通道起始电流 
        /// 单位 mA，*100，有符号
        /// </summary>
        public Int32 StartCurre;
        /// <summary>
        /// 通道结束电压 
        /// 单位 mV，*100，有符号
        /// </summary>
        public Int32 EndVolt;
        /// <summary>
        /// 通道结束电流 
        /// 单位 mA，*100，有符号
        /// </summary>
        public Int32 EndCurre;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] ReserveNull2;

        public TChannelContactTestResultDataMCU()
        {
            ChnState = 0;
            ReserveNull = new byte[3];
            StartVolt = 0;
            StartCurre = 0;
            EndVolt = 0;
            EndCurre = 0;
            ReserveNull2 = new byte[12];
        }
    }

    /// <summary>
    /// 接触测试关键数据
    /// </summary>
    [Serializable]
    public class TContactTestResultData
    {
        /// <summary>
        /// 通道测试数据
        /// </summary> 
        public TChannelContactTestResultData[] ChannelContactTestResultData = new TChannelContactTestResultData[GlobalDefine.CHANNELS];
        public TContactTestResultData()
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                ChannelContactTestResultData[ChnNo] = new TChannelContactTestResultData();
        }
    }

    /// <summary>
    /// 通道测试数据
    /// </summary>
    [Serializable]
    public class TChannelContactTestResultData
    {
        /// <summary>
        /// 通道号 
        /// 从 1 开始
        /// </summary>
        public int ChnNo = 0;
        /// <summary>
        /// 接触测试启动绝对时间
        /// 流程工作绝对时间，绝对时间 年-月-日-时-分-秒-毫秒
        /// </summary> 
        public byte[] ProcessTime = new byte[12];
        /// <summary>
        /// 通道状态
        /// </summary>
        public byte ChnState = 0;
        /// <summary>
        /// 通道起始电压 
        /// 单位 mV，有符号
        /// </summary>
        public double StartVolt = 0;
        /// <summary>
        /// 通道起始电流 
        /// 单位 mA，有符号
        /// </summary>
        public double StartCurre = 0;
        /// <summary>
        /// 通道结束电压 
        /// 单位 mV，有符号
        /// </summary>
        public double EndVolt = 0;
        /// <summary>
        /// 通道结束电流 
        /// 单位 mA，有符号
        /// </summary>
        public double EndCurre = 0;
    }
}
