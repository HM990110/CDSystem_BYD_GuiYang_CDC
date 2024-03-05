namespace CDClassLibrary.Stage
{
    [Serializable]
    public class TParameterLimit
    {
        public TLimit[] Limits = new TLimit[GlobalDefine.NUM_ALLSTAGES];
        public TParameterLimit()
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                Limits[FStageID] = new TLimit();
            }
        }
    }

    [Serializable]
    public class TLimit
    {
        public int ATempLimit = 60;
        public int ACellTempLimit = 60;
        public int ASmogLimit = 60;

        public TWaterPID WaterPID = new();
        public int WaterTargetTempValue = 23;
    }
}
