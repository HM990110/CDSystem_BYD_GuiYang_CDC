using CDGraph.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CDSystem.历史数据.Form运行记录;

namespace CDGraph
{
    public partial class UserControl作业记录 : UserControl
    {
        public UserControl作业记录()
        {
            InitializeComponent();
            Datashow();
        }

        public void Datashow()
        {
            DataTable data = DatabaseOperations.CellTestRecordSelect(); 
            if (data != null)
            {
                dataGridView1.Columns.Clear();
                DataTable dgvDataTable = new DgvDataTable().Data;
                foreach (DataRow row in data.Rows)
                {
                   // MissionID FStageNo    TRAY_NO BATCH_ID    MDL_NAME STARTIME    ENDTIME AutoFlag    AutoEnd CELL_COUNT  NG_COUNT PF_COUNT    DataPath 
                    
                    DataRow dr = dgvDataTable.NewRow();
                    dr["Col托盘号"] = row["TRAY_NO"].ToString();
                    dr["Col批次编号"] = row["BATCH_ID"].ToString();
                    dr["Col电池型号"] = row["MDL_NAME"].ToString();
                    dr["Col设备编号"] = row["FStageNo"].ToString();
                    dr["Col开始时间"] = row["STARTIME"].ToString();
                    dr["Col结束时间"] = row["ENDTIME"].ToString();
                    dr["Col自动流程"] = row["AutoFlag"].ToString();
                    dr["Col自动停止"] = row["AutoEnd"].ToString();
                    dr["Col电池数量"] = row["CELL_COUNT"].ToString();
                    dr["ColNG数量"] = row["NG_COUNT"].ToString();
                    dr["Col数据包地址"] = row["DataPath"].ToString();
                    dgvDataTable.Rows.Add(dr); 
                }
                dataGridView1.DataSource = dgvDataTable;
            }
        }

        public class DgvDataTable
        {
            public DataTable Data;

            public DgvDataTable()
            {
                Data = new DataTable();
                Data.Columns.Add("Col托盘号");
                Data.Columns.Add("Col批次编号");
                Data.Columns.Add("Col电池型号");
                Data.Columns.Add("Col设备编号");
                Data.Columns.Add("Col开始时间");
                Data.Columns.Add("Col结束时间");
                Data.Columns.Add("Col自动流程");
                Data.Columns.Add("Col自动停止");
                Data.Columns.Add("Col电池数量");
                Data.Columns.Add("ColNG数量");
                Data.Columns.Add("Col数据包地址");
            }
        }
    }
}
