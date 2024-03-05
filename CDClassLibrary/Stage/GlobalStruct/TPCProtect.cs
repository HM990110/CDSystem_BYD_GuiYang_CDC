namespace CDClassLibrary.Stage
{
    [Serializable]
    public class TPCProtect
    {
        public TStepPCProtect[] StepPCProtect = new TStepPCProtect[100];
        public TPCProtect()
        {
            for (int i = 0; i < 100; i++)
                StepPCProtect[i] = new TStepPCProtect();
        }
        /*
         * 过压
         * 欠压 
         * 
         * 过流
         * 欠流
         * 
         * 超温
         * 低温
         * 
        */
    }

    [Serializable]
    public class TStepPCProtect
    {
        public bool IsValidFlag = false;

        /// <summary>
        /// 过压
        /// </summary>
        public int VoltageMax = 0;
        /// <summary>
        /// 欠压
        /// </summary>
        public int VoltageMin = 0;
        /// <summary>
        /// 过流
        /// </summary>
        public int CurrentMax = 0;
        /// <summary>
        /// 欠流
        /// </summary>
        public int CurrentMin = 0;

        /// <summary>
        /// 过容
        /// </summary>
        public int CapacityMax = 0;
        /// <summary>
        /// 欠容
        /// </summary>
        public int CapacityMin = 0;
    }
}
