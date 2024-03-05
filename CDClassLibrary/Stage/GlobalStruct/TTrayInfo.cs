namespace CDClassLibrary.Stage
{
    [Serializable]
    public class TTrayInfo
    {
        public string MissionID = "";
        public string MDL_NAME = "";
        public string BATCH_ID = "";
        public string TRAY_NO = "";
        public string ProcessName = "";
        public int CELL_COUNT = GlobalDefine.CHANNELS;
        public int NG_COUNT = 0;
        public int PF_COUNT = 0;
        public bool AutoFlag = false;
        public bool AutoEnd = false;
        public DateTime STARTIME = DateTime.Now;
        public DateTime ENDTIME = DateTime.Now;
        public byte[] ChnState = new byte[GlobalDefine.CHANNELS];
        public string[] CellNumber = new string[GlobalDefine.CHANNELS];
        public string FStageNo = "";

        public TTrayInfo()
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                ChnState[ChnNo] = 0;
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                CellNumber[ChnNo] = "";
        }
    }
}
