using CDClassLibrary.Stage;

namespace CDGraph.Class
{
    public class ResultDatajx
    {
        public string[] Cell状态 = new string[GlobalDefine.CHANNELS];
        public string[] Cell起始时间 = new string[GlobalDefine.CHANNELS];
        public string[] Cell起始电压 = new string[GlobalDefine.CHANNELS];
        public string[] Cell起始电流 = new string[GlobalDefine.CHANNELS];
        public string[] Cell起始环境温度 = new string[GlobalDefine.CHANNELS];
        public string[] Cell起始电池温度 = new string[GlobalDefine.CHANNELS];
        public string[] Cell起始真空值 = new string[GlobalDefine.CHANNELS];
        public string[] Cell结束时间 = new string[GlobalDefine.CHANNELS];
        public string[] Cell结束电压 = new string[GlobalDefine.CHANNELS];
        public string[] Cell结束电流 = new string[GlobalDefine.CHANNELS];
        public string[] Cell结束环境温度 = new string[GlobalDefine.CHANNELS];
        public string[] Cell结束电池温度 = new string[GlobalDefine.CHANNELS];
        public string[] Cell结束真空值 = new string[GlobalDefine.CHANNELS];
        public string[] Cell结束容量 = new string[GlobalDefine.CHANNELS];
        public string[] Cell平均环境温度 = new string[GlobalDefine.CHANNELS];
        public string[] Cell平均电池温度 = new string[GlobalDefine.CHANNELS];

        public ResultDatajx()
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                Cell状态[ChnNo] = "0";
                Cell起始时间[ChnNo] = "0";
                Cell起始电压[ChnNo] = "0";
                Cell起始电流[ChnNo] = "0";
                Cell起始环境温度[ChnNo] = "0";
                Cell起始电池温度[ChnNo] = "0";
                Cell起始真空值[ChnNo] = "0";
                Cell结束时间[ChnNo] = "0";
                Cell结束电压[ChnNo] = "0";
                Cell结束电流[ChnNo] = "0";
                Cell结束环境温度[ChnNo] = "0";
                Cell结束电池温度[ChnNo] = "0";
                Cell结束真空值[ChnNo] = "0";
                Cell结束容量[ChnNo] = "0";
                Cell平均环境温度[ChnNo] = "0";
                Cell平均电池温度[ChnNo] = "0";
            }
        }
    }
}
