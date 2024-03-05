using CDClassLibrary.Stage;

namespace CDGraph.Class
{
    public class RealTimeDatajx
    {
        public int[] DataID;
        public double[] ProcessTime;
        public double[] StepWorkTime;
        public int[] StepNo;
        public string[] StepMode;

        public string[][] ProcessStatus = new string[GlobalDefine.CHANNELS][];
        public string[][] ChnState = new string[GlobalDefine.CHANNELS][];

        public List<string> RealTimeDataitemName = new();
        public List<double[][]> RealTimeDataitem = new();

        public List<double[]> EnvDataTemp = new();
        public double[] EnvDataVacuum;

        public RealTimeDatajx(string[] RealTimeDataitemName, int DataLength)
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                ProcessStatus[ChnNo] = new string[DataLength];
                ChnState[ChnNo] = new string[DataLength];
            }
            DataID = new int[DataLength];
            ProcessTime = new double[DataLength];
            StepWorkTime = new double[DataLength];
            StepNo = new int[DataLength];
            StepMode = new string[DataLength];
            for (int i = 2; i < RealTimeDataitemName.Length; i++)
            {
                this.RealTimeDataitemName.Add(RealTimeDataitemName[i]);
                RealTimeDataitem.Add(new double[GlobalDefine.CHANNELS][]);
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    RealTimeDataitem[i - 2][ChnNo] = new double[DataLength];
                }
            }
            for (int Index = 0; Index < 8; Index++)
            {
                EnvDataTemp.Add(new double[DataLength]);
            }
            EnvDataVacuum = new double[DataLength];
        }

        /// <summary>
        /// 毫秒
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string IntToTime(int time)
        {
            time /= 1000;
            //int dateH = time / 3600;
            //int dateM = time % 3600 / 60;
            //int dateS = time % 60;
            string StrTime = $"{time / 3600:00}:{time % 3600 / 60:00}:{time % 60:00}";
            return StrTime;
        }
    }
}
