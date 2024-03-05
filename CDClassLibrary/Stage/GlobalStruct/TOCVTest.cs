namespace CDClassLibrary.Stage
{
    [Serializable]
    public class TOCVTestSet
    {
        public bool IsOCVTest = false;
        public int OCVMax = 4500;
        public int OCVMin = 200;
    }

    public class TOCVTestSetResultData
    {
        /// <summary>
        /// 通道测试数据
        /// </summary> 
        public TChannelOCVTestSetResultData[] ChannelOCVTestSetResultData = new TChannelOCVTestSetResultData[GlobalDefine.CHANNELS];
        public TOCVTestSetResultData()
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                ChannelOCVTestSetResultData[ChnNo] = new TChannelOCVTestSetResultData();
        }
    }

    public class TChannelOCVTestSetResultData
    {
        /// <summary>
        /// 通道号 
        /// 从 1 开始
        /// </summary>
        public int ChnNo = 0;
        /// <summary>
        /// 通道状态
        /// </summary>
        public byte ChnState = 0;
        /// <summary>
        /// 通道电压 
        /// 单位 mV，有符号
        /// </summary>
        public double Volt = 0;
    }
}
