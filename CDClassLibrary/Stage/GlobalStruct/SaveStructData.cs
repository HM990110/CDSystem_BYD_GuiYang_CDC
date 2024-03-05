namespace CDClassLibrary.Stage
{
    public class SaveStructData
    {
        public static List<TSaveContactTestResultData> ContactTestResultData(TContactTestResultData ContactTestResultData, int DataID, DateTime STARTIME)
        {
            List<TSaveContactTestResultData> SaveDatas = new();
            foreach (TChannelContactTestResultData Data in ContactTestResultData.ChannelContactTestResultData)
            {
                TSaveContactTestResultData SaveData = new()
                {
                    DataID = DataID,
                    ChnNo = Data.ChnNo,
                    ChnState = Data.ChnState,
                    EndCurre = Data.EndCurre,
                    EndVolt = Data.EndVolt,
                    ProcessTime = BytesToDateTimeToInt(Data.ProcessTime, STARTIME),
                    StartCurre = Data.StartCurre,
                    StartVolt = Data.StartVolt,
                };
                SaveDatas.Add(SaveData);
            }
            return SaveDatas;
        }

        public static TRealTimeDataSave RealTimeDataSave(TRealTimeData RealTimeData, TSaveEnvData EnvData)
        {
            TRealTimeDataSave RealTimeDataSave = new()
            {
                DataID = (int)(RealTimeData.ProcessTime * 1000),
                ProcessTime = RealTimeData.ProcessTime,
                StepWorkTime = RealTimeData.StepWorkTime,
                StepMode = RealTimeData.StepMode,
                StepNo = RealTimeData.StepNo,
            };
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                RealTimeDataSave.ChannelRealTimeData[ChnNo] = new TChannelRealTimeDataSave()
                {
                    Volt = RealTimeData.ChannelRealTimeData[ChnNo].Volt,
                    Capacity = RealTimeData.ChannelRealTimeData[ChnNo].Capacity,
                    CellTemp = RealTimeData.ChannelRealTimeData[ChnNo].CellTemp,
                    ChannelTemp = RealTimeData.ChannelRealTimeData[ChnNo].ChannelTemp,
                    ChnNo = RealTimeData.ChannelRealTimeData[ChnNo].ChnNo,
                    ChnState = RealTimeData.ChannelRealTimeData[ChnNo].ChnState,
                    Curre = RealTimeData.ChannelRealTimeData[ChnNo].Curre,
                    Energy = RealTimeData.ChannelRealTimeData[ChnNo].Energy,
                    IR = RealTimeData.ChannelRealTimeData[ChnNo].IR,
                    LineVolt = RealTimeData.ChannelRealTimeData[ChnNo].LineVolt,
                    ProcessStatus = RealTimeData.ChannelRealTimeData[ChnNo].ProcessStatus,
                };
            }

            RealTimeDataSave.EnvData = EnvData;
            return RealTimeDataSave;
        }

        /// <summary>
        /// 将下位机绝对时间转相对时间为Int 毫秒
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="TdateTime"></param>
        /// <returns></returns>
        public static int BytesToDateTimeToInt(byte[] bytes, DateTime TdateTime)
        {
            string time = $"{bytes[9] * 256 + bytes[8]:0000}-{bytes[6]:00}-{bytes[5]:00} {bytes[4]:00}:{bytes[3]:00}:{bytes[2]:00}.{bytes[2] * 256 + bytes[1]:000}";
            DateTime dateTime = Convert.ToDateTime(time);
            return TimeSpanTime(dateTime, TdateTime);
        }

        /// <summary>
        /// date1-date2
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public static int TimeSpanTime(DateTime date1, DateTime date2)
        {
            TimeSpan time = date1 - date2;
            int N = time.Days * 24 * 3600 * 1000 + time.Hours * 3600 * 1000 + time.Minutes * 60 * 1000 + time.Seconds * 1000 + time.Milliseconds;
            return N;
        }
    }

    /// <summary>
    /// 接触测试关键数据
    /// </summary>
    [Serializable]
    public class TSaveContactTestResultData
    {
        public int DataID = 0;
        /// <summary>
        /// 通道号 
        /// 从 1 开始
        /// </summary>
        public int ChnNo = 0;
        /// <summary>
        /// 流程总工作时间 毫秒
        /// </summary>
        public double ProcessTime = 0;
        /// <summary>
        /// 通道状态
        /// </summary>
        public byte ChnState = 0;
        /// <summary>
        /// 通道起始电压 *100
        /// 单位 mV，有符号
        /// </summary>
        public double StartVolt = 0;
        /// <summary>
        /// 通道起始电流 *100
        /// 单位 mA，有符号
        /// </summary>
        public double StartCurre = 0;
        /// <summary>
        /// 通道结束电压 *100
        /// 单位 mV，有符号
        /// </summary>
        public double EndVolt = 0;
        /// <summary>
        /// 通道结束电流 *100
        /// 单位 mA，有符号
        /// </summary>
        public double EndCurre = 0;
    }

    /// <summary>
    /// 实时数据 
    /// </summary>
    [Serializable]
    public class TRealTimeDataSave
    {
        public int DataID = 0;
        /// <summary>
        /// 流程总时间(生产模式)
        /// 流程工作的总时间，相对时间，流程启动后从零开始计数，包括暂停、异常处理、转步时间，直到流程结束停止计时
        /// </summary>
        public double ProcessTime = 0;
        /// <summary>
        /// 步次工作时间
        /// 当前步次的实际工作时间，不包括转步时间，单位：毫秒
        /// </summary>
        public double StepWorkTime = 0;
        /// <summary>
        /// 步次序号
        /// </summary>
        public int StepNo = 0;
        /// <summary>
        /// 步次类型
        /// </summary>
        public TStepMode StepMode = TStepMode.SKIP;

        /// <summary>
        /// 通道实时数据
        /// </summary> 
        public TChannelRealTimeDataSave[] ChannelRealTimeData = new TChannelRealTimeDataSave[GlobalDefine.CHANNELS];

        public TSaveEnvData EnvData = new();

        public TRealTimeDataSave()
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                ChannelRealTimeData[ChnNo] = new TChannelRealTimeDataSave();
        }
    }

    /// <summary>
    /// 通道实时数据
    /// </summary>
    [Serializable]
    public class TChannelRealTimeDataSave
    {
        /// <summary>
        /// 通道号 
        /// 从 1 开始
        /// </summary>
        public int ChnNo = 0;
        /// <summary>
        /// 通道工作状态
        /// </summary>
        public TProcessStatus ProcessStatus = TProcessStatus.Init;
        /// <summary>
        /// 通道诊断值
        /// </summary>
        public byte ChnState = 0;
        /// <summary>
        /// 通道电压
        /// 有符号, *100，单位 mV
        /// </summary>
        public double Volt = 0;
        /// <summary>
        /// 通道电流 
        /// 有符号，*100，单位 mA
        /// </summary>
        public double Curre = 0;
        /// <summary>
        /// 通道线电压
        /// 有符号, *100，单位 mV
        /// </summary>
        public double LineVolt = 0;
        /// <summary>
        /// 通道容量 
        /// 无符号，*100，单位 mAh
        /// </summary>
        public double Capacity = 0;
        /// <summary>
        /// 通道能量/功率值 
        /// 能量：无符号，*100，单位 mWh
        /// 恒功率模式下为功率值：*100, 单位 mW
        /// </summary>
        public double Energy = 0;
        /// <summary>
        /// 通道温度 
        /// 有符号，*100, 单位度
        /// </summary>
        public double ChannelTemp = 0;
        /// <summary>
        /// 电池温度 
        /// 有符号，*100, 单位度
        /// </summary>
        public double CellTemp = 0;
        /// <summary>
        /// 接触阻抗 
        /// 无符号，*100，单位毫欧
        /// </summary>
        public double IR = 0;
    }

    /// <summary>
    /// 操控版状态
    /// </summary>
    [Serializable]
    public class TSaveEnvData
    {
        /// <summary>
        /// 真空数显表值 *100 单位KPa
        /// </summary>
        public double VacuumValue = 0;
        /// <summary>
        /// 机构温度值 *100
        /// </summary>
        public double[] ATemp = new double[8];

        public TSaveEnvData()
        {
            for (int i = 0; i < 8; i++)
                ATemp[i] = 0;
        }
    }
}
