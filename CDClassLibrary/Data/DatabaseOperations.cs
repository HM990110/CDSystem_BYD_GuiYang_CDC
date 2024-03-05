using CDClassLibrary.Log;
using CDClassLibrary.Stage;
using CDClassLibrary.Tools;
using Newtonsoft.Json;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace CDClassLibrary.Data
{
    public class DatabaseOperations
    {
        static readonly DateTime startTime = new(2000, 1, 1, 0, 0, 0);

        #region 测试数据
        /// <summary>
        /// 新建电芯测试记录数据库
        /// </summary>
        public static bool CellTestRecordDataCreateTable()
        {
            try
            {
                if (!Directory.Exists(GlobalDefine.CellTestRecordPath))
                    Directory.CreateDirectory(GlobalDefine.CellTestRecordPath);
                SQLiteConnection.CreateFile(GlobalDefine.CellTestRecordFile);
                SQLiteConnection cn = new("data source=" + GlobalDefine.CellTestRecordFile);
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText =
                        "CREATE TABLE CellTestRecord(" +
                        "MissionID varchar(8000)," +
                        "FStageNo varchar(8000)," +
                        "TRAY_NO varchar(8000)," +
                        "BATCH_ID varchar(8000)," +
                        "MDL_NAME varchar(8000)," +
                        "STARTIME varchar(8000)," +
                        "ENDTIME varchar(8000)," +
                        "AutoFlag varchar(10)," +
                        "AutoEnd varchar(10)," +
                        "CELL_COUNT int," +
                        "NG_COUNT int," +
                        "PF_COUNT int," +
                        "DataPath varchar(8000));"
                    };
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1010:" + ex.Message);
                GlobalFunction.ErrorLogAdd("", "新建测试数据数据库错误", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 新建测试数据数据库
        /// </summary>
        /// <param name="dbfile"></param>
        public static bool DataCreateTable(string dbfile)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(dbfile)))
                    Directory.CreateDirectory(Path.GetDirectoryName(dbfile)!);
                SQLiteConnection.CreateFile(dbfile);
                SQLiteConnection cn = new("data source=" + dbfile);
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText =
                        "CREATE TABLE RealTimeData(DataID int,ProcessTime float,StepWorkTime float,StepNo int,StepMode varchar(20),EnvData BLOB,RealTimeData BLOB);" +
                        "CREATE TABLE ResultData(DataID int,ChnNo int,ProcessTime float,StepWorkTime float,StepNo int,StepMode varchar(4),ChnState varchar(4),StartVolt float,StartCurre float,StartEnvTemp float,EndEnvTemp float,AvgEnvTemp float,AvgCellTemp float,EndCurreVolt float,EndTime float,EndVolt float,EndCurre float,CCTime float,EndCapacity float,EndEnengy float,FiveMinCurre float,StartCellTemp float,EndCellTemp float,CCCVCapacity float,IR float);" +
                        "CREATE TABLE ContactTestResultData(DataID int,ChnNo int,ProcessTime float,ChnState varchar(4),StartVolt float,StartCurre float,EndVolt float,EndCurre float);" +
                        "CREATE TABLE OtherInfo(TrayInfo varchar(8000),ProcessGroup varchar(8000),RealTimeDataItem varchar(8000),EnvDataItem varchar(8000));"
                    };
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1011:" + ex.Message);
                GlobalFunction.ErrorLogAdd("", "新建测试数据数据库错误", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 实时数据保存
        /// </summary>
        /// <param name="dbfile"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static bool RealTimeDataINSERT(string dbfile, string FStageNo, List<TRealTimeDataSave> Data)
        {
            if (Data.Count > 0)
            {
                SQLiteConnection cn = new("data source=" + dbfile);
                try
                {
                    if (cn.State != System.Data.ConnectionState.Open)
                    {
                        cn.Open();
                        SQLiteCommand cmd = new()
                        {
                            Connection = cn,
                            Transaction = cn.BeginTransaction()
                        };
                        string RealTimeDataAdd = "Insert into RealTimeData Values(@DataID,@ProcessTime,@StepWorkTime,@StepNo,@StepMode,@EnvData,@RealTimeData)";

                        for (int i = 0; i < Data.Count; i++)
                        {
                            //DataID int,ProcessTime int,StepNo int,StepMode varchar(20),EnvData BLOB
                            cmd.CommandText = RealTimeDataAdd;
                            cmd.Parameters.Add(new SQLiteParameter("@DataID", Data[i].DataID));
                            cmd.Parameters.Add(new SQLiteParameter("@ProcessTime", Data[i].ProcessTime));
                            cmd.Parameters.Add(new SQLiteParameter("@StepWorkTime", Data[i].StepWorkTime));
                            cmd.Parameters.Add(new SQLiteParameter("@StepNo", Data[i].StepNo));
                            cmd.Parameters.Add(new SQLiteParameter("@StepMode", Data[i].StepMode.ToString()));

                            //string EnvDataItem = "真空数显表值,机构温度值"; 
                            string EnvDataItem = string.Empty;
                            for (int iATemp = 0; iATemp < Data[i].EnvData.ATemp.Length; iATemp++)
                                EnvDataItem += $"{Data[i].EnvData.ATemp[iATemp]},";
                            EnvDataItem += $"{Data[i].EnvData.VacuumValue};";
                            cmd.Parameters.Add(new SQLiteParameter("@EnvData", ZipUp.CompressionObject(EnvDataItem)));

                            //DataID,ProcessTime,StepWorkTime,StepNo,StepMode,WorkState,ChnState,Volt,Curre,Capacity,CellTemp,LineVolt,Energy,ChannelTemp,IR
                            //ID,工作时间,步次时间,步次序号,步次类型,工作状态,电芯状态,电压,电流,容量,电池温度,线电压,能量,通道温度,阻抗 

                            //工作状态,电芯状态,电压,电流,容量,电池温度     不可删除，
                            //string RealTimeDataItem = "工作状态,电芯状态,电压,电流,容量,电池温度,线电压,能量,通道温度,接触阻抗";

                            string RealTimeData = string.Empty;
                            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                            {
                                RealTimeData +=
                                    $"{Data[i].ChannelRealTimeData[ChnNo].ProcessStatus}," +    //工作状态
                                    $"{Data[i].ChannelRealTimeData[ChnNo].ChnState}," +         //电芯状态
                                    $"{Data[i].ChannelRealTimeData[ChnNo].Volt}," +             //电压
                                    $"{Data[i].ChannelRealTimeData[ChnNo].Curre}," +            //电流
                                    $"{Data[i].ChannelRealTimeData[ChnNo].Capacity}," +         //容量
                                    $"{Data[i].ChannelRealTimeData[ChnNo].CellTemp}," +         //电池温度
                                    $"{Data[i].ChannelRealTimeData[ChnNo].LineVolt}," +         //线电压
                                    $"{Data[i].ChannelRealTimeData[ChnNo].Energy}," +           //能量
                                    $"{Data[i].ChannelRealTimeData[ChnNo].ChannelTemp}," +      //通道温度
                                    $"{Data[i].ChannelRealTimeData[ChnNo].IR};";                //接触阻抗
                            }
                            cmd.Parameters.Add(new SQLiteParameter("@RealTimeData", ZipUp.CompressionObject(RealTimeData)));

                            cmd.ExecuteNonQuery();
                        }
                        cmd.Transaction.Commit();
                    }
                    cn.Close();
                    //GlobalFunction.RunLogAdd(FStageNo, "实时数据保存成功"); 
                    return true;
                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine("1012:" + ex.Message);
                    GlobalFunction.ErrorLogAdd(FStageNo, "实时数据保存错误", ex.Message);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 测试结果数据保存
        /// </summary>
        /// <param name="dbfile"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static bool ResultDataINSERT(string dbfile, string FStageNo, List<TChannelResultData> Data, string TRAYNO)
        {
            try
            {
                SQLiteConnection cn = new("data source=" + dbfile);
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        Transaction = cn.BeginTransaction()
                    };
                    for (int i = 0; i < Data.Count; i++)
                    {
                        cmd.CommandText =
                            "Insert into ResultData Values(" +
                            "@DataID,@ChnNo,@ProcessTime,@StepWorkTime,@StepNo,@StepMode,@ChnState,@StartVolt,@StartCurre," +
                            "@StartEnvTemp,@EndEnvTemp,@AvgEnvTemp,@AvgCellTemp,@EndCurreVolt,@EndTime,@EndVolt,@EndCurre," +
                            "@CCTime,@EndCapacity,@EndEnengy,@FiveMinCurre,@StartCellTemp,@EndCellTemp,@CCCVCapacity,@IR)";
                        cmd.Parameters.Add(new SQLiteParameter("@DataID", Data[i].DataID));
                        cmd.Parameters.Add(new SQLiteParameter("@ChnNo", Data[i].ChnNo));
                        cmd.Parameters.Add(new SQLiteParameter("@ProcessTime", Data[i].ProcessTime));
                        cmd.Parameters.Add(new SQLiteParameter("@StepWorkTime", Data[i].StepWorkTime));
                        cmd.Parameters.Add(new SQLiteParameter("@StepNo", Data[i].StepNo));
                        cmd.Parameters.Add(new SQLiteParameter("@StepMode", Data[i].StepMode.ToString()));
                        cmd.Parameters.Add(new SQLiteParameter("@ChnState", Data[i].ChnState.ToString("X2")));
                        cmd.Parameters.Add(new SQLiteParameter("@StartVolt", Data[i].StartVolt));
                        cmd.Parameters.Add(new SQLiteParameter("@StartCurre", Data[i].StartCurre));
                        cmd.Parameters.Add(new SQLiteParameter("@StartEnvTemp", Data[i].StartEnvTemp));
                        cmd.Parameters.Add(new SQLiteParameter("@EndEnvTemp", Data[i].EndEnvTemp));
                        cmd.Parameters.Add(new SQLiteParameter("@AvgEnvTemp", Data[i].AvgEnvTemp));
                        cmd.Parameters.Add(new SQLiteParameter("@AvgCellTemp", Data[i].AvgCellTemp));
                        cmd.Parameters.Add(new SQLiteParameter("@EndCurreVolt", Data[i].EndCurreVolt));
                        cmd.Parameters.Add(new SQLiteParameter("@EndTime", Data[i].EndTime));
                        cmd.Parameters.Add(new SQLiteParameter("@EndVolt", Data[i].EndVolt));
                        cmd.Parameters.Add(new SQLiteParameter("@EndCurre", Data[i].EndCurre));
                        cmd.Parameters.Add(new SQLiteParameter("@CCTime", Data[i].CCTime));
                        cmd.Parameters.Add(new SQLiteParameter("@EndCapacity", Data[i].EndCapacity));
                        cmd.Parameters.Add(new SQLiteParameter("@EndEnengy", Data[i].EndEnengy));
                        cmd.Parameters.Add(new SQLiteParameter("@FiveMinCurre", Data[i].FiveMinCurre));
                        cmd.Parameters.Add(new SQLiteParameter("@StartCellTemp", Data[i].StartCellTemp));
                        cmd.Parameters.Add(new SQLiteParameter("@EndCellTemp", Data[i].EndCellTemp));
                        cmd.Parameters.Add(new SQLiteParameter("@CCCVCapacity", Data[i].CCCVCapacity));
                        cmd.Parameters.Add(new SQLiteParameter("@IR", Data[i].IR));
                        cmd.ExecuteNonQuery();
                    }
                    cmd.Transaction.Commit();
                }
                cn.Close();
                GlobalFunction.RunLogAdd(FStageNo, "测试结果数据保存成功", "<" + TRAYNO + ">测试结果数据保存成功");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1013:" + ex.Message);
                GlobalFunction.ErrorLogAdd("", "测试结果数据保存错误", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 接触测试结果数据保存
        /// </summary>
        /// <param name="dbfile"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static bool ContactTestResultDataINSERT(string dbfile, string FStageNo, List<TSaveContactTestResultData> Data, string TRAYNO)
        {
            try
            {
                SQLiteConnection cn = new("data source=" + dbfile);
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        Transaction = cn.BeginTransaction()
                    };
                    for (int i = 0; i < Data.Count; i++)
                    {
                        cmd.CommandText = "Insert into ContactTestResultData Values(" +
                            "@DataID,@ChnNo,@ProcessTime,@ChnState," +
                            "@StartVolt,@StartCurre,@EndVolt,@EndCurre)";
                        cmd.Parameters.Add(new SQLiteParameter("@DataID", Data[i].DataID));
                        cmd.Parameters.Add(new SQLiteParameter("@ChnNo", Data[i].ChnNo));
                        cmd.Parameters.Add(new SQLiteParameter("@ProcessTime", Data[i].ProcessTime));
                        cmd.Parameters.Add(new SQLiteParameter("@ChnState", Data[i].ChnState.ToString("X2")));
                        cmd.Parameters.Add(new SQLiteParameter("@StartVolt", Data[i].StartVolt));
                        cmd.Parameters.Add(new SQLiteParameter("@StartCurre", Data[i].StartCurre));
                        cmd.Parameters.Add(new SQLiteParameter("@EndVolt", Data[i].EndVolt));
                        cmd.Parameters.Add(new SQLiteParameter("@EndCurre", Data[i].EndCurre));
                        cmd.ExecuteNonQuery();
                    }
                    cmd.Transaction.Commit();
                }
                cn.Close();
                GlobalFunction.RunLogAdd(FStageNo, "接触测试结果数据保存成功", "<" + TRAYNO + ">接触测试结果数据保存成功");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1014:" + ex.Message);
                GlobalFunction.ErrorLogAdd("", "接触测试结果数据保存错误", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 托盘信息保存
        /// </summary>
        /// <param name="dbfile"></param>
        /// <param name="TrayInfo"></param>
        /// <param name="Process"></param>
        /// <param name="ContactTestProcess"></param>
        /// <param name="OCVTestSet"></param>
        /// <param name="VacuumTestSet"></param>
        /// <returns></returns>
        public static bool TrayInfoINSERT(string dbfile, string FStageNo, TTrayInfo TrayInfo, TProcessGroup ProcessGroup)
        {
            try
            {
                //托盘信息保存
                {
                    SQLiteConnection cn = new("data source=" + dbfile);
                    if (cn.State != System.Data.ConnectionState.Open)
                    {
                        string ChnState = "";
                        for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                            ChnState += TrayInfo.ChnState[ChnNo] + ",";

                        string RealTimeDataItem = "工作状态,电芯状态,电压,电流,容量,电池温度,线电压,能量,通道温度,接触阻抗";
                        string EnvDataItem = "真空数显表值,机构温度值";
                        cn.Open();
                        SQLiteCommand cmd = new()
                        {
                            Connection = cn,
                            CommandText = "Insert into OtherInfo Values(@TrayInfo,@ProcessGroup,@RealTimeDataItem,@EnvDataItem)"
                        };
                        cmd.Parameters.Add(new SQLiteParameter("@TrayInfo", JsonConvert.SerializeObject(TrayInfo)));
                        cmd.Parameters.Add(new SQLiteParameter("@ProcessGroup", JsonConvert.SerializeObject(ProcessGroup)));
                        cmd.Parameters.Add(new SQLiteParameter("@RealTimeDataItem", RealTimeDataItem));
                        cmd.Parameters.Add(new SQLiteParameter("@EnvDataItem", EnvDataItem));
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
                return /*CellTestRecordDataADD(dbfile, FStageNo, TrayInfo) &&*/ true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1015:" + ex.Message);
                GlobalFunction.ErrorLogAdd(FStageNo, "托盘信息保存错误", ex.Message);
                return false;
            }
        }

        public static bool TrayInfoUpdate(string dbfile, string FStageNo, TTrayInfo TrayInfo)
        {
            SQLiteConnection cn = new("data source=" + dbfile);
            try
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText = "Update OtherInfo set TrayInfo=@TrayInfo"
                    };
                    cmd.Parameters.Add(new SQLiteParameter("@TrayInfo", JsonConvert.SerializeObject(TrayInfo)));

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                if (File.Exists(dbfile))
                    File.Delete(dbfile);
                Console.WriteLine("1016:" + ex.Message);
                GlobalFunction.ErrorLogAdd(FStageNo, "电芯测试记录", ex.Message);
                return false;
            }
        }

        public static bool CellTestRecordDataADD(string dbfile, string FStageNo, TTrayInfo TrayInfo)
        {

            string PathFile = GlobalDefine.CellTestRecordFile;
            if (!File.Exists(PathFile))
            {
                if (!Directory.Exists(GlobalDefine.CellTestRecordPath))
                    Directory.CreateDirectory(GlobalDefine.CellTestRecordPath);
                DatabaseOperations.CellTestRecordDataCreateTable();
            }
            else
            {
                FileInfo fileinfo = new(PathFile);
                if (fileinfo.Length / 1024 / 1024 > 20)
                {
                    fileinfo.CopyTo(GlobalDefine.CellTestRecordPath + "CellTestRecord" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".dat");
                    fileinfo.Delete();
                    DatabaseOperations.CellTestRecordDataCreateTable();
                }
            }

            SQLiteConnection cn = new("data source=" + PathFile);
            try
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText = "Insert into CellTestRecord Values(@MissionID,@FStageNo,@TRAY_NO,@BATCH_ID,@MDL_NAME,@STARTIME,@ENDTIME,@AutoFlag,@AutoEnd,@CELL_COUNT,@NG_COUNT,@PF_COUNT,@DataPath)"
                    };
                    cmd.Parameters.Add(new SQLiteParameter("@MissionID", TrayInfo.MissionID));
                    cmd.Parameters.Add(new SQLiteParameter("@FStageNo", TrayInfo.FStageNo));
                    cmd.Parameters.Add(new SQLiteParameter("@TRAY_NO", TrayInfo.TRAY_NO));
                    cmd.Parameters.Add(new SQLiteParameter("@BATCH_ID", ""));
                    cmd.Parameters.Add(new SQLiteParameter("@MDL_NAME", TrayInfo.MDL_NAME));
                    cmd.Parameters.Add(new SQLiteParameter("@STARTIME", TrayInfo.STARTIME.ToString()));
                    cmd.Parameters.Add(new SQLiteParameter("@ENDTIME", TrayInfo.ENDTIME.ToString()));
                    cmd.Parameters.Add(new SQLiteParameter("@AutoFlag", TrayInfo.AutoFlag.ToString()));
                    cmd.Parameters.Add(new SQLiteParameter("@AutoEnd", TrayInfo.AutoEnd.ToString()));
                    cmd.Parameters.Add(new SQLiteParameter("@CELL_COUNT", TrayInfo.CELL_COUNT));
                    cmd.Parameters.Add(new SQLiteParameter("@NG_COUNT", TrayInfo.NG_COUNT));
                    cmd.Parameters.Add(new SQLiteParameter("@PF_COUNT", TrayInfo.PF_COUNT));
                    cmd.Parameters.Add(new SQLiteParameter("@DataPath", dbfile));

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                if (File.Exists(PathFile))
                    File.Delete(PathFile);
                Console.WriteLine("1016:" + ex.Message);
                GlobalFunction.ErrorLogAdd(FStageNo, "电芯测试记录", ex.Message);
                return false;
            }
        }

        public static bool CellTestRecordDataUpdate(string FStageNo, TTrayInfo TrayInfo)
        {
            string PathFile = GlobalDefine.CellTestRecordFile;
            if (!File.Exists(PathFile))
            {
                if (!Directory.Exists(GlobalDefine.CellTestRecordPath))
                    Directory.CreateDirectory(GlobalDefine.CellTestRecordPath);
                DatabaseOperations.CellTestRecordDataCreateTable();
            }
            else
            {
                FileInfo fileinfo = new(PathFile);
                if (fileinfo.Length / 1024 / 1024 > 20)
                {
                    fileinfo.CopyTo(GlobalDefine.CellTestRecordPath + "CellTestRecord" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".dat");
                    fileinfo.Delete();
                    DatabaseOperations.CellTestRecordDataCreateTable();
                }
            }
            SQLiteConnection cn = new("data source=" + PathFile);
            try
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText = "Update CellTestRecord set NG_COUNT = @NG_COUNT,AutoEnd = @AutoEnd,ENDTIME = @ENDTIME where MissionID = @MissionID;"
                    };
                    cmd.Parameters.Add(new SQLiteParameter("@MissionID", TrayInfo.MissionID));
                    cmd.Parameters.Add(new SQLiteParameter("@ENDTIME", TrayInfo.ENDTIME.ToString()));
                    cmd.Parameters.Add(new SQLiteParameter("@NG_COUNT", TrayInfo.NG_COUNT));
                    cmd.Parameters.Add(new SQLiteParameter("@AutoEnd", TrayInfo.AutoEnd.ToString()));

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                if (File.Exists(PathFile))
                    File.Delete(PathFile);
                Console.WriteLine("1016:" + ex.Message);
                GlobalFunction.ErrorLogAdd(FStageNo, "电芯测试记录", ex.Message);
                return false;
            }
        }


        /// <summary>
        /// 测试数据读取
        /// </summary>
        /// <param name="dbfile"></param>
        /// <returns></returns>
        public static DataSet? DataSelect(string dbfile)
        {
            try
            {
                SQLiteConnection cn = new("data source=" + dbfile);
                DataSet ds;
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();//打开数据库连接
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText =
                        "select * from RealTimeData Order by DataID;" +
                        "select * from ResultData Order by DataID;" +
                        "select * from ContactTestResultData Order by DataID;" +
                        "select * from OtherInfo;"
                    };
                    cmd.ExecuteNonQuery();
                    SQLiteDataAdapter msda = new(cmd);
                    msda.Fill(ds = new DataSet());
                    ds.Tables[0].TableName = "RealTimeData";
                    ds.Tables[1].TableName = "ResultData";
                    ds.Tables[2].TableName = "ContactTestResultData";
                    ds.Tables[3].TableName = "OtherInfo";
                    cn.Close();//关闭数据库 
                    return ds;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1017:" + ex.Message);
                GlobalFunction.ErrorLogAdd("", "测试数据读取失败", ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 实时数据读取
        /// </summary>
        /// <param name="dbfile"></param>
        /// <returns></returns>
        public static DataTable? RealTimeDataSelect(string dbfile, int DataID)
        {
            try
            {
                SQLiteConnection cn = new("data source=" + dbfile);
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();//打开数据库连接 
                    string sql = $"select * from RealTimeData Where DataID > {DataID} Order by DataID;";

                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText = sql
                    };
                    cmd.ExecuteNonQuery();
                    SQLiteDataAdapter msda = new(cmd);
                    DataTable ds = new();
                    msda.Fill(ds);
                    cn.Close();//关闭数据库 
                    return ds;
                }
                else return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1018:" + ex.Message);
                GlobalFunction.ErrorLogAdd("", "实时数据读取失败", ex.Message);
                return null;
            }
        }
        #endregion

        #region 错误日志
        /// <summary>
        /// 新建错误日志数据库
        /// </summary>
        /// <param name="dbfile"></param>
        public static bool ErrorMesLogCreateTable(string dbfile)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(dbfile)))
                    Directory.CreateDirectory(Path.GetDirectoryName(dbfile)!);
                SQLiteConnection.CreateFile(dbfile);
                SQLiteConnection cn = new("data source=" + dbfile);
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText =
                        "CREATE TABLE ErrorMesLog(ID int,Time DateTime,FStageNo varchar(8000),LType varchar(8000),lMessage varchar(8000));"
                    };
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1019:" + ex.Message);
                GlobalFunction.ErrorLogAdd("", "新建错误日志数据库错误", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 错误日志保存
        /// </summary>
        /// <param name="dbfile"></param>
        /// <param name="Data"></param>
        /// <returns></returns>

        public static bool LogINSERT(string PathFile, LogHelper Data)
        {
            if (!File.Exists(PathFile))
            {
                if (!Directory.Exists(Path.GetDirectoryName(PathFile)!))
                    Directory.CreateDirectory(Path.GetDirectoryName(PathFile)!);
                DatabaseOperations.ErrorMesLogCreateTable(PathFile);
            }
            else
            {
                FileInfo fileinfo = new(PathFile);
                if (fileinfo.Length / 1024 / 1024 > 20)
                {
                    fileinfo.CopyTo(GlobalDefine.ErrorMesLogPath + "ErrorLog" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".dat");
                    fileinfo.Delete();
                    DatabaseOperations.ErrorMesLogCreateTable(PathFile);
                }
            }
            SQLiteConnection cn = new("data source=" + PathFile);
            try
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText = "Insert into ErrorMesLog Values(" +
                        "@ID,@Time,@FStageNo,@LType,@lMessage)"
                    };
                    cmd.Parameters.Add(new SQLiteParameter("@ID", (int)(Data.Time - startTime).TotalSeconds));
                    cmd.Parameters.Add(new SQLiteParameter("@Time", Data.Time));
                    cmd.Parameters.Add(new SQLiteParameter("@FStageNo", Data.FStageNo));
                    cmd.Parameters.Add(new SQLiteParameter("@LType", Data.LType));
                    cmd.Parameters.Add(new SQLiteParameter("@lMessage", Data.LMessage));
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                if (File.Exists(PathFile))
                    File.Delete(PathFile);
                Console.WriteLine("1020:" + ex.Message);
                GlobalFunction.ErrorLogAdd("", "日志保存错误", PathFile + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 错误日志读取
        /// </summary>
        /// <param name="dbfile"></param>
        /// <returns></returns>
        public static DataTable? ErrorMesLogSelect(string File, string FStageNo = "")
        {
            try
            {
                SQLiteConnection cn = new("data source=" + File);
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    //Time '时间',FStageNo '设备编号',LType '日志类型',lMessage '日志内容'
                    string sql = "select * from ErrorMesLog";
                    if (FStageNo != "")
                        sql += $" where FStageNo='{FStageNo}' Order by ID Desc";
                    else
                        sql += $" Order by ID Desc";
                    sql += " limit 1000";

                    cn.Open();//打开数据库连接
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText = sql
                    };
                    cmd.ExecuteNonQuery();
                    SQLiteDataAdapter msda = new(cmd);
                    DataTable ds = new();
                    msda.Fill(ds);
                    cn.Close();//关闭数据库 
                    return ds;
                }
                else return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1021:" + ex.Message);
                //GlobalFunction.ErrorLogAdd("", "程序错误", "错误日志读取失败" + ex.Message);
                return null;
            }
        }

        #endregion 

        #region 运行统计 
        private static readonly object OperatingStatistic = new();
        /// <summary>
        /// 新建运行统计数据库
        /// </summary>
        /// <param name="dbfile"></param>
        public static bool OperatingStatisticCreateTable(string dbfile)
        {
            lock (OperatingStatistic)
            {
                try
                {
                    if (!Directory.Exists(Path.GetDirectoryName(dbfile)))
                        Directory.CreateDirectory(Path.GetDirectoryName(dbfile)!);
                    SQLiteConnection.CreateFile(dbfile);
                    SQLiteConnection cn = new("data source=" + dbfile);
                    if (cn.State != System.Data.ConnectionState.Open)
                    {
                        cn.Open();
                        SQLiteCommand cmd = new()
                        {
                            Connection = cn,
                            CommandText =
                            "CREATE TABLE OperatingStatistic(ID int,Time DateTime,FStageNo varchar(8000),LType varchar(8000));"
                        };
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("1023:" + ex.Message);
                    GlobalFunction.ErrorLogAdd("", "新建运行统计数据库错误", ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// 运行统计保存
        /// </summary>
        /// <param name="dbfile"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static bool OperatingStatisticINSERT(string FStageNo, string LType)
        {
            lock (OperatingStatistic)
            {
                string PathFile = GlobalDefine.OperatingStatisticPathFile;
                if (!File.Exists(PathFile))
                {
                    if (!Directory.Exists(GlobalDefine.OperatingStatisticPath))
                        Directory.CreateDirectory(GlobalDefine.OperatingStatisticPath);
                    OperatingStatisticCreateTable(PathFile);
                }
                else
                {
                    FileInfo fileinfo = new(PathFile);
                    if (fileinfo.Length / 1024 / 1024 > 20)
                    {
                        fileinfo.CopyTo(GlobalDefine.OperatingStatisticPath + "OperatingStatistic" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".dat");
                        fileinfo.Delete();
                        OperatingStatisticCreateTable(PathFile);
                    }
                }

                SQLiteConnection cn = new("data source=" + PathFile);
                try
                {
                    if (cn.State != System.Data.ConnectionState.Open)
                    {
                        DateTime date = DateTime.Now;
                        cn.Open();
                        SQLiteCommand cmd = new()
                        {
                            Connection = cn,
                            CommandText = "Insert into OperatingStatistic Values(" +
                            "@ID,@Time,@FStageNo,@LType)"
                        };
                        cmd.Parameters.Add(new SQLiteParameter("@ID", (int)(date - startTime).TotalSeconds));
                        cmd.Parameters.Add(new SQLiteParameter("@Time", date));
                        cmd.Parameters.Add(new SQLiteParameter("@FStageNo", FStageNo));
                        cmd.Parameters.Add(new SQLiteParameter("@LType", LType));
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    cn.Close();
                    if (File.Exists(PathFile))
                        File.Delete(PathFile);
                    Console.WriteLine("1024:" + ex.Message);
                    GlobalFunction.ErrorLogAdd("", "运行统计保存错误", ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// 运行统计读取
        /// </summary>
        /// <param name="dbfile"></param>
        /// <returns></returns>
        public static DataTable? OperatingStatisticSelect(string FStageNo)
        {
            try
            {
                SQLiteConnection cn = new("data source=" + GlobalDefine.OperatingStatisticPathFile);
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();//打开数据库连接
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText = $"select * from OperatingStatistic where FStageNo='{FStageNo}' Order by ID Desc limit 200"
                    };
                    cmd.ExecuteNonQuery();
                    SQLiteDataAdapter msda = new(cmd);
                    DataTable ds = new();
                    msda.Fill(ds);
                    cn.Close();//关闭数据库 
                    return ds;
                }
                else return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1025:" + ex.Message);
                GlobalFunction.ErrorLogAdd("", "运行统计读取失败", ex.Message);
                return null;
            }
        }
        #endregion

        #region 关键器件
        private static readonly object PartStatistic = new();
        /// <summary>
        /// 新建关键器件数据库
        /// </summary>
        /// <param name="dbfile"></param>
        public static bool PartStatisticCreateTable(string dbfile)
        {
            lock (PartStatistic)
            {
                try
                {
                    if (!Directory.Exists(Path.GetDirectoryName(dbfile)))
                        Directory.CreateDirectory(Path.GetDirectoryName(dbfile)!);
                    SQLiteConnection.CreateFile(dbfile);
                    SQLiteConnection cn = new("data source=" + dbfile);
                    if (cn.State != System.Data.ConnectionState.Open)
                    {
                        cn.Open();
                        SQLiteCommand cmd = new()
                        {
                            Connection = cn,
                            CommandText =
                            "CREATE TABLE PartStatistic(ID int,Time DateTime,FStageNo varchar(8000),LType varchar(8000));"
                        };
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("1026:" + ex.Message);
                    GlobalFunction.ErrorLogAdd("", "新建关键器件数据库错误", ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// 关键器件保存
        /// </summary>
        /// <param name="dbfile"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static bool PartStatisticINSERT(string FStageNo, string LType)
        {
            lock (PartStatistic)
            {
                string PathFile = GlobalDefine.PartStatisticPathFile;
                if (!File.Exists(PathFile))
                {
                    if (!Directory.Exists(GlobalDefine.PartStatisticPath))
                        Directory.CreateDirectory(GlobalDefine.PartStatisticPath);
                    DatabaseOperations.PartStatisticCreateTable(PathFile);
                }
                else
                {
                    FileInfo fileinfo = new(PathFile);
                    if (fileinfo.Length / 1024 / 1024 > 20)
                    {
                        fileinfo.CopyTo(GlobalDefine.PartStatisticPath + "PartStatistic" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".dat");
                        fileinfo.Delete();
                        DatabaseOperations.PartStatisticCreateTable(PathFile);
                    }
                }

                SQLiteConnection cn = new("data source=" + PathFile);
                try
                {
                    if (cn.State != System.Data.ConnectionState.Open)
                    {
                        DateTime date = DateTime.Now;
                        cn.Open();
                        SQLiteCommand cmd = new()
                        {
                            Connection = cn,
                            CommandText = "Insert into PartStatistic Values(" +
                            "@ID,@Time,@FStageNo,@LType)"
                        };
                        cmd.Parameters.Add(new SQLiteParameter("@ID", (int)(date - startTime).TotalSeconds));
                        cmd.Parameters.Add(new SQLiteParameter("@Time", date));
                        cmd.Parameters.Add(new SQLiteParameter("@FStageNo", FStageNo));
                        cmd.Parameters.Add(new SQLiteParameter("@LType", LType));
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    cn.Close();
                    if (File.Exists(PathFile))
                        File.Delete(PathFile);
                    Console.WriteLine("1027:" + ex.Message);
                    GlobalFunction.ErrorLogAdd("", "关键器件保存错误", ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// 关键器件读取
        /// </summary>
        /// <param name="dbfile"></param>
        /// <returns></returns>
        public static DataTable? PartStatisticSelect(string FStageNo)
        {
            string PathFile = GlobalDefine.PartStatisticPathFile;
            string path = GlobalDefine.PartStatisticPath;
            if (!File.Exists(PathFile))
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                DatabaseOperations.PartStatisticCreateTable(PathFile);
                return null;
            }
            else
            {
                FileInfo fileinfo = new(PathFile);
                if (fileinfo.Length / 1024 / 1024 > 20)
                {
                    fileinfo.CopyTo(path + "PartStatistic" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".dat");
                    fileinfo.Delete();
                    DatabaseOperations.PartStatisticCreateTable(PathFile);
                }
            }

            SQLiteConnection cn = new("data source=" + PathFile);
            try
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();//打开数据库连接
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText = $"select * from PartStatistic where FStageNo='{FStageNo}' Order by ID Desc limit 200"
                    };
                    cmd.ExecuteNonQuery();
                    SQLiteDataAdapter msda = new(cmd);
                    DataTable ds = new();
                    msda.Fill(ds);
                    cn.Close();//关闭数据库 
                    return ds;
                }
                else return null;
            }
            catch (Exception ex)
            {
                cn.Close();
                if (File.Exists(PathFile))
                    File.Delete(PathFile);
                Console.WriteLine("1028:" + ex.Message);
                GlobalFunction.ErrorLogAdd("", "关键器件读取失败", ex.Message);

                return null;
            }
        }
        #endregion
    }
}
