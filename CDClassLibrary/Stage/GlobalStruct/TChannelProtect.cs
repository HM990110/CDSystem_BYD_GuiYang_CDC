using System.Runtime.InteropServices;

namespace CDClassLibrary.Stage
{
    /// <summary>
    /// 上位机通道保护（0xB201）
    /// </summary>
    public struct TChannelProtectMCU
    {
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] ReserveNull;
        /// <summary>
        /// 通道保护值
        /// 每个通道占用一个字节
        /// 0：不保护
        /// 非 0： 保护值 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 400)]
        public byte[] PosSelected;

        public TChannelProtectMCU()
        {
            ReserveNull = new byte[4];
            PosSelected = new byte[400];
            for (int i = 0; i < PosSelected.Length; i++)
                PosSelected[i] = 0;
        }
    }

    /// <summary>
    /// 上位机通道保护
    /// </summary>
    [Serializable]
    public class TChannelProtect
    {
        /// <summary>
        /// 通道保护值
        /// 每个通道占用一个字节
        /// 0：不保护
        /// 非 0：保护值 
        /// </summary> 
        public byte[] PosSelected = new byte[GlobalDefine.CHANNELS];

        public TChannelProtect()
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                PosSelected[ChnNo] = 0;
        }
    }
}
