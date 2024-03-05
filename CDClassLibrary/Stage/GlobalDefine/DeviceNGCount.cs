namespace CDClassLibrary.Stage
{
    [Serializable]
    public class TDeviceNGCount
    {
        public int ChannelNGLimit = 10;
        public int ContactLimit = 4000;
        public int RunLimit = 3000;

        public int[][] NGCount = new int[GlobalDefine.NUM_ALLSTAGES][];
        public int[][] UpKeepCount = new int[GlobalDefine.NUM_ALLSTAGES][];
        public int[][] ContactCount = new int[GlobalDefine.NUM_ALLSTAGES][];
        public int[][] RunCount = new int[GlobalDefine.NUM_ALLSTAGES][];

        public TDeviceNGCount()
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                NGCount[FStageID] = new int[GlobalDefine.CHANNELS];
                UpKeepCount[FStageID] = new int[GlobalDefine.CHANNELS];
                ContactCount[FStageID] = new int[GlobalDefine.CHANNELS];
                RunCount[FStageID] = new int[GlobalDefine.CHANNELS];
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    NGCount[FStageID][ChnNo] = 0;
                    UpKeepCount[FStageID][ChnNo] = 0;
                    ContactCount[FStageID][ChnNo] = 0;
                    RunCount[FStageID][ChnNo] = 0;
                }
            }
        }
    }
}
