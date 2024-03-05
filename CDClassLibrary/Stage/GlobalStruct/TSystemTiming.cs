using System.Runtime.InteropServices;

namespace CDClassLibrary.Stage
{
    /// <summary>
    /// 系统校时（0xA101）
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct TSystemTimingMCU
    {
        /// <summary>
        /// 毫秒（0~1000）
        /// </summary>
        public UInt16 Millisecond;
        /// <summary>
        /// 秒（0~59）
        /// </summary>
        public byte Second;
        /// <summary>
        /// 分（0~59）
        /// </summary>
        public byte Minute;
        /// <summary>
        /// 时（0~23）
        /// </summary>
        public byte Hour;
        /// <summary>
        /// 日（1~31）
        /// </summary>
        public byte Day;
        /// <summary>
        /// 月（1~12）
        /// </summary>
        public byte Month;
        /// <summary>
        /// 星期（0~6）
        /// </summary>
        public byte DayOfWeek;
        /// <summary>
        /// 年（2000 年起）
        /// </summary>
        public UInt16 Year;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] ReserveNull;

        public TSystemTimingMCU()
        {
            DateTime time = DateTime.Now;
            Year = (byte)time.Year;
            Month = (byte)time.Month;
            Day = (byte)time.Day;
            Hour = (byte)time.Hour;
            Minute = (byte)time.Minute;
            Second = (byte)time.Second;
            Millisecond = (byte)time.Millisecond;
            DayOfWeek = (byte)time.DayOfWeek;
            ReserveNull = new byte[2];
        }
    }
}
