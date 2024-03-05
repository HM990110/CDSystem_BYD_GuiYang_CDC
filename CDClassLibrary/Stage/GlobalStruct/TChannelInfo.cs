using System.Runtime.InteropServices;

namespace CDClassLibrary.Stage
{
    /// <summary>
    /// 通道配置信息（0x01A6）
    /// </summary>
    public struct TChannelInfoMCU
    {
        /// <summary>
        /// 通道配置信息
        /// 共设计 400 通道，按位表示是否需要启动
        /// 0~50 直接对应 0~400 通道，低位表示低通道
        /// 1：表示可以启动 
        /// 0：表示不启动
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
        public byte[] PosSelected;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public byte[] ReserveNull;

        public TChannelInfoMCU()
        {
            PosSelected = new byte[50];
            for (int i = 0; i < 50; i++)
                PosSelected[i] = 0;
            ReserveNull = new byte[10];
        }
    }

    /// <summary>
    /// 通道配置信息（0x01A6）
    /// </summary>
    public class TChannelInfo
    {
        /// <summary>
        /// 通道配置信息
        /// 共设计 400 通道，按位表示是否需要启动
        /// true：表示可以启动 
        /// false：表示不启动
        /// </summary> 
        public bool[] PosSelected = new bool[GlobalDefine.CHANNELS];

        public TChannelInfo()
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                PosSelected[ChnNo] = false;
        }
    }
}
