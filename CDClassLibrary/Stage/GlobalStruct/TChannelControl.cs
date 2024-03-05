using System.Runtime.InteropServices;

namespace CDClassLibrary.Stage
{
    public struct TChannelControlMCU
    {
        /// <summary>
        /// 命令类型
        /// </summary>
        public TControlCommand ControlCommand;
        /// <summary>
        /// 模式选择
        /// </summary>
        public TOperationMode OperationMode;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] ReserveNull;
        /// <summary>
        /// 通道选择
        /// 每个通道用一个 bit，共 600 通道 
        /// 1：通道被选中 
        /// 0：通道不选中
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 75)]
        public byte[] PosSelected;

        public TChannelControlMCU()
        {
            ControlCommand = TControlCommand.Resume;
            OperationMode = TOperationMode.Production;
            ReserveNull = new byte[3];
            PosSelected = new byte[75];
            for (int i = 0; i < 75; i++)
            {
                PosSelected[i] = 0;
            }
        }
    }

    public class TChannelControl
    {
        /// <summary>
        /// 命令类型
        /// </summary>
        public TControlCommand ControlCommand = TControlCommand.Resume;
        /// <summary>
        /// 模式选择
        /// </summary>
        public TOperationMode OperationMode = TOperationMode.Production;
        /// <summary>
        /// 通道选择
        /// 每个通道用一个 bit，共 600 通道 
        /// true：通道被选中 
        /// false：通道不选中
        /// </summary> 
        public bool[] PosSelected = new bool[GlobalDefine.CHANNELS];

        public TChannelControl()
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                PosSelected[ChnNo] = false;
        }
    }

    /// <summary>
    /// 命令类型
    /// 0x01 启动using System.Runtime.InteropServices;

    namespace CDClassLibrary.Stage
    {
        public struct TChannelControlMCU
        {
            /// <summary>
            /// 命令类型
            /// </summary>
            public TControlCommand ControlCommand;
            /// <summary>
            /// 模式选择
            /// </summary>
            public TOperationMode OperationMode;
            /// <summary>
            /// 预留
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] ReserveNull;
            /// <summary>
            /// 通道选择
            /// 每个通道用一个 bit，共 600 通道 
            /// 1：通道被选中 
            /// 0：通道不选中
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 75)]
            public byte[] PosSelected;

            public TChannelControlMCU()
            {
                ControlCommand = TControlCommand.Resume;
                OperationMode = TOperationMode.Production;
                ReserveNull = new byte[3];
                PosSelected = new byte[75];
                for (int i = 0; i < 75; i++)
                {
                    PosSelected[i] = 0;
                }
            }
        }

        public class TChannelControl
        {
            /// <summary>
            /// 命令类型
            /// </summary>
            public TControlCommand ControlCommand = TControlCommand.Resume;
            /// <summary>
            /// 模式选择
            /// </summary>
            public TOperationMode OperationMode = TOperationMode.Production;
            /// <summary>
            /// 通道选择
            /// 每个通道用一个 bit，共 600 通道 
            /// true：通道被选中 
            /// false：通道不选中
            /// </summary> 
            public bool[] PosSelected = new bool[GlobalDefine.CHANNELS];

            public TChannelControl()
            {
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    PosSelected[ChnNo] = false;
            }
        }

        /// <summary>
        /// 命令类型
        /// 0x01 启动
        /// 0x02 暂停
        /// 0x03 停止
        /// 0x04 OCV 测试
        /// 0x05 接触测试启动
        /// </summary>
        public enum TControlCommand : byte
        {
            Resume = 0x01,
            Suspend = 0x02,
            Stop = 0x03,
            OCV = 0x04,
            Contact = 0x05,
        }
    }

    /// 0x02 暂停
    /// 0x03 停止
    /// 0x04 OCV 测试
    /// 0x05 接触测试启动
    /// </summary>
    public enum TControlCommand : byte
    {
        Resume = 0x01,
        Suspend = 0x02,
        Stop = 0x03,
        OCV = 0x04,
        Contact = 0x05,
    }
}
