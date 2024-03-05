namespace CDClassLibrary.Stage
{
    [Serializable]
    public class TProcessGroup
    {
        public string ProcessName = "";
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled = false;
        /// <summary>
        /// 是否复测流程
        /// </summary>
        public bool IsRetest = false;
        /// <summary>
        /// 单盘NG上限
        /// </summary>
        public int DeviceNGLimit = 20;


        /// <summary>
        /// 当前流程
        /// </summary>
        public TProcess Process = new();
        /// <summary>
        /// 接触测试流程
        /// </summary>
        public TContactTestProcess ContactTestProcess = new();
        /// <summary>
        /// OCV测试
        /// </summary>
        public TOCVTestSet OCVTestSet = new();
        /// <summary>
        /// 上位机步次保护
        /// </summary>
        public TPCProtect PCProtect = new();
    }
}
