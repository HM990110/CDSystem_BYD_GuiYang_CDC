using System.Runtime.InteropServices;

namespace CDClassLibrary.Stage.GlobalStruct
{
    /// <summary>
    /// 离线状态
    /// </summary>
    public struct TOfflineStateMCU
    {
        /// <summary>
        /// 离线数据有效标志
        /// </summary>
        public byte Flag;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] ReserveNull;
        /// <summary>
        /// 离线数据数量
        /// 离线文件个数，为 0 表示没有文件。
        /// </summary>
        public Int32 OfflineFileCount;


        public TOfflineStateMCU()
        {
            Flag = 0;
            ReserveNull = new byte[3];
            OfflineFileCount = 0;
        }
    }

    public struct TOfflineDataMCU
    {
        /// <summary>
        /// 文件序号 从 0 开始
        /// </summary>
        public Int32 FileNo;
        /// <summary>
        /// 文件保存实时数据数量
        /// 保存了几条实时数据，为 0 表示没有实时数据
        /// </summary>
        public Int16 RealTimeDataCount;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] ReserveNull;
        /// <summary>
        /// 文件保存时间
        /// 毫秒2-秒-分-时-日-月-星期-年-预留2
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] FileTime;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 108)]
        public byte[] ReserveNull2;
        /// <summary>
        /// 实时数据
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public TRealTimeDataMCU[] RealTimeDataMCUs;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11356)]
        public byte[] ReserveNull3;

        public TOfflineDataMCU()
        {
            FileNo = 0;
            RealTimeDataCount = 0;
            ReserveNull = new byte[2];
            FileTime = new byte[12];
            ReserveNull2 = new byte[108];
            RealTimeDataMCUs = new TRealTimeDataMCU[7];
            for (int i = 0; i < 7; i++)
                RealTimeDataMCUs[i] = new TRealTimeDataMCU();
            ReserveNull3 = new byte[11356];
        }
    }

    public struct TSwitchModeMCU
    {
        /// <summary>
        /// 0：退出，1：进入
        /// </summary>
        public byte InOut;
        /// <summary>
        /// 0：正常，1：校正，2：配置，3：更新，4：传输文件
        /// </summary>
        public byte WorkModeMCU;
        /// <summary>
        /// 0x55：正极，0xAA：负极
        /// </summary>
        public byte PolaritySet;

        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public byte[] ReserveNull;

        public TSwitchModeMCU()
        {
            InOut = 0;
            WorkModeMCU = 0;
            PolaritySet = 0x55;
            ReserveNull = new byte[9];
        }
    }
}
