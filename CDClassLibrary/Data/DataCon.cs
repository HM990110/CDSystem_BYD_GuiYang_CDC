using CDClassLibrary.Stage;
using CDClassLibrary.Tools;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace CDClassLibrary.Data
{
    public class DataCon
    {
        static readonly string ConStr = "Data Source = .; Database = BYDDATA; User Id = HKKJ; Password = 1234";

        /// <summary>
        /// 判定数据库是否连接成功
        /// </summary>
        /// <returns></returns>
        public static bool DataConState()
        {
            SqlConnection Conn = new(ConStr);
            bool boo = false;
            try
            {
                Conn.Open();
                if (Conn.State == ConnectionState.Open)
                    boo = true;
                Conn.Close();
            }
            catch { }
            return boo;
        }

        /// <summary>
        /// 查询数据，返回整个查询结果
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static DataTable? Reader(string strSql)
        {
            if (!DataConState())
                return null;
            SqlConnection Conn = new(ConStr);
            try
            {
                SqlCommand cmd = new()
                {
                    Connection = Conn,
                    CommandType = CommandType.Text,
                    CommandText = strSql
                };
                DataTable dt = new();
                SqlDataAdapter msda = new(cmd);
                msda.Fill(dt);
                Conn.Close();
                return dt;
            }
            catch
            {
                Conn.Close();
                return null;
            }
        }

        private static readonly object lockObjNonQuery = new();

        /// <summary>
        /// 数据库增、删、改
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static bool NonQuery(string strSql)
        {
            lock (lockObjNonQuery)
            {
                if (!DataConState())
                    return false;
                SqlConnection Conn = new(ConStr);
                try
                {
                    Conn.Open();
                    SqlCommand Cmd = new()
                    {
                        Connection = Conn,
                        CommandType = CommandType.Text,
                        CommandText = strSql
                    };
                    int iud = Cmd.ExecuteNonQuery();
                    Conn.Close();
                    if (iud > 0) return true;
                    else return false;
                }
                catch
                {
                    Conn.Close();
                    return false;
                }
            }
        }

        private static readonly object lockObjDataWrite = new();
        public static bool DataWrite(List<CellData> CellData, TDeviceType DeviceType)
        {
            lock (lockObjDataWrite)
            {
                try
                {
                    SqlConnection cn = new(ConStr);
                    if (cn.State != System.Data.ConnectionState.Open)
                    {
                        cn.Open();
                        SqlCommand cmd = new()
                        {
                            Connection = cn,
                            Transaction = cn.BeginTransaction()
                        };
                        for (int i = 0; i < CellData.Count; i++)
                        {
                            /*
                            "Insert into CDC2_Table Values(" +
                            "@OPERATION,@RESRCE,@USER_NO,@SHOP_ORDER,@ITEM_NO," +
                            "@MODEL_NO,@LOT_NO,@SFC,@TEST_DATE_TIME,@NG_CODE," +
                            "@EQUIPMENT_NO,@LNSTRUMENT_NO,@VERSION,@SHIFT,@IS_LLXJ," +
                            "@IS_BZHQ,@IS_TJ,@IS_CURRENT,@IS_TRANS,@RETURN_1D," +
                            "@TRAY_NO,@CELL_POS,@TIME_START,@TIME_END,@TIME_LONG," +
                            "@DATA_RESULT,@DATA_REALTIME,@VOLT_START,@VOLT_END,@TEMP_AVG)"
                            */
                            string strsql1 = string.Format("Insert into " + DeviceType + "_Table Values(" +
                            "'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}',{14}," +
                            "{15},{16},{17},{18},{19},'{20}',{21},'{22}','{23}',{24},'{25}','{26}',{27},{28},{29},{30})",
                            CellData[i].OPERATION, CellData[i].RESRCE, CellData[i].USER_NO, CellData[i].SHOP_ORDER, CellData[i].ITEM_NO,
                            CellData[i].MODEL_NO, CellData[i].LOT_NO, CellData[i].SFC, CellData[i].TEST_DATE_TIME, CellData[i].NG_CODE,
                            CellData[i].EQUIPMENT_NO, CellData[i].LNSTRUMENT_NO, CellData[i].VERSION, CellData[i].SHIFT, CellData[i].IS_LLXJ,
                            CellData[i].IS_BZHQ, CellData[i].IS_TJ, CellData[i].IS_CURRENT, CellData[i].IS_TRANS, CellData[i].RETURN_ID,
                            CellData[i].TRAY_NO, CellData[i].CELL_POS, CellData[i].TIME_START, CellData[i].TIME_END, CellData[i].TIME_LONG,
                            JsonConvert.SerializeObject(CellData[i].DATA_RESULTs),
                            JsonConvert.SerializeObject(CellData[i].DATA_REALTIMEs),
                            CellData[i].VOLT_START, CellData[i].VOLT_END, CellData[i].TEMP_AVG,
                            CellData[i].CAP_DC
                            );
                            cmd.CommandText = strsql1;

                            cmd.ExecuteNonQuery();

                            if (DeviceType == TDeviceType.CDC3)
                            {
                                //[DATA_INDEX],[MDL_NAME],[BATCH_ID],[TRAY_NO],[CELL_POS],[CELL_SN],[CAPACITY],[TIME_TEST],[TIME_UPDATE],[PC_UPLOAD],[REMARK]
                                string strsql2 = string.Format("Insert into CDC3_TEMP_TABLE Values(" +
                                "'{0}','{1}','{2}',{3},'{4}',{5},'{6}','{7}','{8}','{9}')",
                                 CellData[i].MODEL_NO, CellData[i].LOT_NO, CellData[i].TRAY_NO, CellData[i].CELL_POS, CellData[i].SFC, CellData[i].CAP_DC, CellData[i].TIME_END, CellData[i].TEST_DATE_TIME, "", "");
                                cmd.CommandText = strsql2;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        cmd.Transaction.Commit();
                    }
                    cn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("1045:" + ex.Message);
                    GlobalFunction.ErrorLogAdd("", "数据保存错误", ex.Message);
                    return false;
                }
            }
        }

    }

    public class SqlServerData
    {
        public static bool DataWrite(string DBPath, TDeviceType DeviceType)
        {
            DataSet? data = DatabaseOperations.DataSelect(DBPath);
            if (data != null)
            {
                DataTable? OtherInfoData = data.Tables["OtherInfo"];
                if (OtherInfoData != null)
                {
                    if (OtherInfoData.Rows.Count > 0)
                    {
                        TTrayInfo? TrayInfo = JsonConvert.DeserializeObject<TTrayInfo>(OtherInfoData.Rows[0]["TrayInfo"].ToString()!);
                        TProcessGroup? processGroup = JsonConvert.DeserializeObject<TProcessGroup>(OtherInfoData.Rows[0]["ProcessGroup"].ToString()!);
                        if (TrayInfo != null && processGroup != null)
                        {

                            CellData[] cellData = new CellData[GlobalDefine.CHANNELS];
                            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                            {
                                cellData[ChnNo] = new CellData();
                            }

                            DataTable? RealTimeData = data.Tables["RealTimeData"];
                            if (RealTimeData != null)
                            {
                                int DataLength = RealTimeData.Rows.Count;
                                if (RealTimeData.Rows.Count > 0)
                                {
                                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                                    {
                                        cellData[ChnNo].DATA_REALTIMEs = new string[DataLength];
                                        for (int j = 0; j < DataLength; j++)
                                        {
                                            cellData[ChnNo].DATA_REALTIMEs[j] = string.Empty;
                                        }
                                    }
                                    //Task task = new(new Action(() =>
                                    //{
                                    //    Task[] tasks = new Task[DataLength];
                                    for (int i = 0; i < DataLength; i++)
                                    {
                                        int k = i;
                                        //tasks[k] = new Task(new Action(() =>
                                        //{ 

                                        //DataID,ProcessTime,StepWorkTime,StepNo,StepMode,ProcessStatus,ChnState,Volt,Curre,Capacity,CellTemp,LineVolt,Energy,ChannelTemp,IR
                                        //ID,工作时间,步次时间,步次序号,步次类型,工作状态,电芯状态,电压,电流,容量,电池温度,线电压,能量,通道温度,阻抗 
                                        string strChannelRealTimeData =
                                            $"{(int)RealTimeData.Rows[k]["DataID"]}," +
                                            $"{(double)RealTimeData.Rows[k]["ProcessTime"]}," +
                                            $"{(double)RealTimeData.Rows[k]["StepWorkTime"]}," +
                                            $"{(int)RealTimeData.Rows[k]["StepNo"]}," +
                                            $"{(string)RealTimeData.Rows[k]["StepMode"]},";
                                        string[] DateItem = ZipUp.DecompressionObject<string>((byte[])RealTimeData.Rows[k]["RealTimeData"])!.Split(';');
                                        for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                                        {
                                            cellData[ChnNo].DATA_REALTIMEs[k] = strChannelRealTimeData + DateItem[ChnNo];
                                        }
                                        //}));
                                    }
                                    //    Task.WaitAll(tasks);
                                    //}));
                                    //task.Start();
                                    //task.Wait();

                                    string[] DateItem_START = ZipUp.DecompressionObject<string>((byte[])RealTimeData.Rows[0]["RealTimeData"])!.Split(';');
                                    string[] DateItem_END = ZipUp.DecompressionObject<string>((byte[])RealTimeData.Rows[DataLength - 1]["RealTimeData"])!.Split(';');

                                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                                    {
                                        cellData[ChnNo].VOLT_START = float.Parse(DateItem_START[ChnNo].Split(',')[2]);
                                        cellData[ChnNo].VOLT_END = float.Parse(DateItem_END[ChnNo].Split(',')[2]);
                                    }
                                }
                            }
                            else { return false; }

                            DataTable? ResultData = data.Tables["ResultData"];
                            if (ResultData != null)
                            {
                                int TEMPStep = 0;
                                if (DeviceType == TDeviceType.CDC2)
                                {
                                    for (int i = 0; i < processGroup.Process.StepCount; i++)
                                    {
                                        if (processGroup.Process.ProcStepRec[processGroup.Process.StepCount - 1 - i].StepMode != TStepMode.REST)
                                        {
                                            TEMPStep = processGroup.Process.StepCount - 1 - i;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < processGroup.Process.StepCount; i++)
                                    {
                                        if (processGroup.Process.ProcStepRec[processGroup.Process.StepCount - 1 - i].StepMode == TStepMode.DC)
                                        {
                                            TEMPStep = processGroup.Process.StepCount - 1 - i;
                                            break;
                                        }
                                    }
                                }

                                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                                {
                                    cellData[ChnNo].DATA_RESULTs = new string[processGroup.Process.StepCount];
                                    for (int j = 0; j < processGroup.Process.StepCount; j++)
                                    {
                                        cellData[ChnNo].DATA_RESULTs[j] = string.Empty;
                                    }
                                }

                                foreach (DataRow row in ResultData.Rows)
                                {
                                    int StepNo = (int)row["StepNo"] - 1;
                                    int ChnNo = (int)row["ChnNo"] - 1;

                                    if (StepNo >= 0 && ChnNo >= 0)
                                    {
                                        //ChnState,StepMode,ProcessTime,StartVolt,StartCurre,StartEnvTemp,StartCellTemp,EndTime,EndVolt,EndCurre,EndEnvTemp,EndCellTemp,EndCapacity,AvgEnvTemp,AvgCellTemp
                                        cellData[ChnNo].DATA_RESULTs[StepNo] =
                                            $"{(string)row["ChnState"]}," +
                                            $"{(string)row["StepMode"]}," +
                                            $"{(double)row["ProcessTime"]}," +
                                            $"{(double)row["StartVolt"]}," +
                                            $"{(double)row["StartCurre"]}," +
                                            $"{(double)row["StartEnvTemp"]}," +
                                            $"{(double)row["StartCellTemp"]}," +
                                            $"{(double)row["EndTime"]}," +
                                            $"{(double)row["EndVolt"]}," +
                                            $"{(double)row["EndCurre"]}," +
                                            $"{(double)row["EndEnvTemp"]}," +
                                            $"{(double)row["EndCellTemp"]}," +
                                            $"{(double)row["EndCapacity"]}," +
                                            $"{(double)row["AvgEnvTemp"]}," +
                                            $"{(double)row["AvgCellTemp"]}";
                                    }
                                    if (TEMPStep == StepNo)
                                    {
                                        cellData[ChnNo].TEMP_AVG = (float)(double)row["AvgCellTemp"];
                                        cellData[ChnNo].CAP_DC = (float)(double)row["EndCapacity"];
                                    }
                                }
                            }
                            else { return false; }

                            DateTime TEST_DATE_TIME = DateTime.Now;
                            string SHIFT =
                                (TEST_DATE_TIME > Convert.ToDateTime($"{TEST_DATE_TIME.Year}-{TEST_DATE_TIME.Month}-{TEST_DATE_TIME.Day} 08:00:00") &&
                                TEST_DATE_TIME < Convert.ToDateTime($"{TEST_DATE_TIME.Year}-{TEST_DATE_TIME.Month}-{TEST_DATE_TIME.Day} 20:00:00")) ?
                                "A" : "B";
                            int TIME_LONG = TStructConvert.TimeSpanTime(TrayInfo.STARTIME, TrayInfo.ENDTIME) / 100 / 60;

                            List<CellData> CellDatas = new();
                            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                            {
                                if (TrayInfo.ChnState[ChnNo] != 0x60 && TrayInfo.ChnState[ChnNo] != 0x61)
                                {
                                    cellData[ChnNo].OPERATION = DeviceType == TDeviceType.CDC2 ? "HC" : "FR";
                                    cellData[ChnNo].RESRCE = DeviceType == TDeviceType.CDC2 ? "G04_01_HC_01" : "G04_01_FR_01";
                                    cellData[ChnNo].USER_NO = string.Empty;
                                    cellData[ChnNo].SHOP_ORDER = string.Empty;
                                    cellData[ChnNo].ITEM_NO = string.Empty;
                                    cellData[ChnNo].MODEL_NO = TrayInfo.MDL_NAME;
                                    cellData[ChnNo].LOT_NO = TrayInfo.BATCH_ID;
                                    cellData[ChnNo].SFC = TrayInfo.CellNumber[ChnNo];
                                    cellData[ChnNo].TEST_DATE_TIME = TEST_DATE_TIME;
                                    cellData[ChnNo].NG_CODE = TrayInfo.ChnState[ChnNo].ToString("X2");
                                    cellData[ChnNo].EQUIPMENT_NO = TrayInfo.FStageNo;
                                    cellData[ChnNo].LNSTRUMENT_NO = string.Empty;
                                    cellData[ChnNo].VERSION = Assembly.GetExecutingAssembly().GetName().Version!.ToString();
                                    cellData[ChnNo].SHIFT = SHIFT;
                                    cellData[ChnNo].IS_LLXJ = 0;
                                    cellData[ChnNo].IS_BZHQ = 0;
                                    cellData[ChnNo].IS_TJ = 0;
                                    cellData[ChnNo].IS_CURRENT = 1;
                                    cellData[ChnNo].IS_TRANS = 0;
                                    cellData[ChnNo].RETURN_ID = 0;
                                    cellData[ChnNo].TRAY_NO = TrayInfo.TRAY_NO;
                                    cellData[ChnNo].CELL_POS = ChnNo + 1;
                                    cellData[ChnNo].TIME_START = TrayInfo.STARTIME;
                                    cellData[ChnNo].TIME_END = TrayInfo.ENDTIME;
                                    cellData[ChnNo].TIME_LONG = TIME_LONG;
                                    CellDatas.Add(cellData[ChnNo]);
                                }
                            }
                            if (!DataCon.DataWrite(CellDatas, DeviceType))
                                return false;
                            return true;
                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else { return false; }
            }
            else { return false; }
        }

    }

    public class CellData
    {
        /// <summary>
        /// 工序
        /// </summary>
        public string OPERATION = string.Empty;
        /// <summary>
        /// 岗位资源
        /// </summary>
        public string RESRCE = string.Empty;
        /// <summary>
        /// 作业员
        /// </summary>
        public string USER_NO = string.Empty;
        /// <summary>
        /// 工单
        /// </summary>
        public string SHOP_ORDER = string.Empty;
        /// <summary>
        /// SAP物料号
        /// </summary>
        public string ITEM_NO = string.Empty;
        /// <summary>
        /// 型号
        /// </summary>
        public string MODEL_NO = string.Empty;
        /// <summary>
        /// 批号
        /// </summary>
        public string LOT_NO = string.Empty;
        /// <summary>
        /// 条码
        /// </summary>
        public string SFC = string.Empty;
        /// <summary>
        /// 检测时间
        /// </summary>
        public DateTime TEST_DATE_TIME = DateTime.Now;
        /// <summary>
        /// 不良代码
        /// </summary>
        public string NG_CODE = string.Empty;
        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQUIPMENT_NO = string.Empty;
        /// <summary>
        /// 仪器编号
        /// </summary>
        public string LNSTRUMENT_NO = string.Empty;
        /// <summary>
        /// 软件版本号
        /// </summary>
        public string VERSION = string.Empty;
        /// <summary>
        /// 班次信息
        /// </summary>
        public string SHIFT = string.Empty;
        /// <summary>
        /// 是否启用来料校验
        /// </summary>
        public int IS_LLXJ;
        /// <summary>
        /// 是否从MES获取工艺标准
        /// </summary>
        public int IS_BZHQ;
        /// <summary>
        /// 是否调机模式
        /// </summary>
        public int IS_TJ;
        /// <summary>
        /// 最新数据标识
        /// </summary>
        public int IS_CURRENT;
        /// <summary>
        /// 数据传移标识
        /// </summary>
        public int IS_TRANS;
        /// <summary>
        /// 客户回传标识
        /// </summary>
        public int RETURN_ID;
        /// <summary>
        /// 托盘号
        /// </summary>
        public string TRAY_NO = string.Empty;
        /// <summary>
        /// 通道号
        /// </summary>
        public int CELL_POS;
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime TIME_START;
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime TIME_END;
        /// <summary>
        /// 相对时间
        /// </summary>
        public int TIME_LONG;
        /// <summary>
        /// 结果数据
        /// ChnState,StepMode,ProcessTime,StartVolt,StartCurre,StartEnvTemp,StartCellTemp,EndTime,EndVolt,EndCurre,EndEnvTemp,EndCellTemp,EndCapacity,AvgEnvTemp,AvgCellTemp
        /// </summary>
        public string[] DATA_RESULTs = Array.Empty<string>();
        /// <summary>
        /// 曲线数据
        /// DataID,ProcessTime,StepWorkTime,ChnState,Volt,Curre,Capacity,Energy,LineVolt,IR,ChannelTemp,CellTemp
        /// </summary>
        public string[] DATA_REALTIMEs = Array.Empty<string>();
        /// <summary>
        /// 初始电压
        /// </summary>
        public float VOLT_START;
        /// <summary>
        /// 终止电压
        /// </summary>
        public float VOLT_END;
        /// <summary>
        /// 平均温度
        /// </summary>
        public float TEMP_AVG;
        /// <summary>
        /// 放电容量
        /// </summary>
        public float CAP_DC;

        public CellData()
        {
        }
    }



}