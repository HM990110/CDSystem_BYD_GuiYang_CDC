using CDClassLibrary.Stage;
using System.Data;
using System.Data.SQLite;

namespace CDGraph.Class
{
    internal class DatabaseOperations
    {
        /// <summary>
        /// 测试数据读取
        /// </summary>
        /// <param name="dbfile"></param>
        /// <returns></returns>
        public static DataSet DataSelect(string dbfile)
        {
            DataSet ds = new();
            try
            {
                SQLiteConnection cn = new("data source=" + dbfile);
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
                    msda.Fill(ds);
                    ds.Tables[0].TableName = "RealTimeData";
                    ds.Tables[1].TableName = "ResultData";
                    ds.Tables[2].TableName = "ContactTestResultData";
                    ds.Tables[3].TableName = "OtherInfo";
                    cn.Close();//关闭数据库 
                }
            }
            catch
            {
                ds = null;
            }
            return ds;
        }

        /// <summary>
        /// 测试数据读取
        /// </summary>
        /// <param name="dbfile"></param>
        /// <returns></returns>
        public static DataTable? CellTestRecordSelect()
        {
            DataTable ds = null;
            try
            {
                SQLiteConnection cn = new("data source=" + "D:\\CDSystem\\CellTestRecord\\CellTestRecord.db");
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();//打开数据库连接
                    SQLiteCommand cmd = new()
                    {
                        Connection = cn,
                        CommandText = "select * from celltestrecord order by startime desc",
                    };
                    cmd.ExecuteNonQuery();
                    SQLiteDataAdapter msda = new(cmd);
                    msda.Fill(ds = new());
                    cn.Close();//关闭数据库 
                }
            }
            catch
            { }
            return ds;
        }
    }
}
