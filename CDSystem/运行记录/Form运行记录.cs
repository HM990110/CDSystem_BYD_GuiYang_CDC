using CDClassLibrary.Stage;
using CDClassLibrary;
using CDClassLibrary.Data;
using System.Data;
using CDSystem.Language;

namespace CDSystem.历史数据
{
    public partial class Form运行记录 : Form
    {
        public void Language()
        {
            button1.Text = ResourceLang.Form运行记录button1Text;
            Col错误类型.HeaderText = ResourceLang.Form运行记录Col错误类型HeaderText;
            Col错误内容.HeaderText = ResourceLang.Form运行记录Col错误内容HeaderText;
            Col发生时间.HeaderText = ResourceLang.Form运行记录Col发生时间HeaderText;
            Col设备编号.HeaderText = ResourceLang.Form运行记录Col设备编号HeaderText;
            dataGridViewTextBoxColumn1.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn1HeaderText;
            dataGridViewTextBoxColumn10.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn10HeaderText;
            dataGridViewTextBoxColumn11.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn11HeaderText;
            dataGridViewTextBoxColumn12.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn12HeaderText;
            dataGridViewTextBoxColumn2.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn2HeaderText;
            dataGridViewTextBoxColumn3.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn3HeaderText;
            dataGridViewTextBoxColumn4.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn4HeaderText;
            dataGridViewTextBoxColumn5.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn5HeaderText;
            dataGridViewTextBoxColumn6.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn6HeaderText;
            dataGridViewTextBoxColumn7.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn7HeaderText;
            dataGridViewTextBoxColumn8.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn8HeaderText;
            dataGridViewTextBoxColumn9.HeaderText = ResourceLang.Form运行记录dataGridViewTextBoxColumn9HeaderText;
            label1.Text = ResourceLang.Form运行记录label1Text;
            label2.Text = ResourceLang.Form运行记录label2Text;
            tabPage1.Text = ResourceLang.Form运行记录tabPage1Text;
            tabPage2.Text = ResourceLang.Form运行记录tabPage2Text;
            tabPage3.Text = ResourceLang.Form运行记录tabPage3Text;
            tabPage4.Text = ResourceLang.Form运行记录tabPage4Text;
        }

        public Form运行记录()
        {
            InitializeComponent();

            comboBox_Device.Items.Add("");
            for (int i = 0; i < GlobalDefine.NUM_STAGEPERDEVICE; i++)
            {
                for (int j = 0; j < GlobalDefine.NUM_DEVICEPERLINE; j++)
                {
                    int x = j + i * GlobalDefine.NUM_DEVICEPERLINE;
                    comboBox_Device.Items.Add(GlobalParams.GStages[x].FStageNo);
                }
            }
            comboBox_Device.SelectedIndex = 0;
        }

        public void DataShow()
        {
            DateTime dateTime = DateTime.Now;
            string LogPath = GlobalDefine.ErrorMesLogPath + $"{dateTime.Year}\\{dateTime.Month}\\{dateTime.Day}\\";
            DataShow(LogPath + GlobalDefine.RunLogFile, dataGridView_RunLog);
            DataShow(LogPath + GlobalDefine.AlarmLogFile, dataGridView_AlarmLog);
            DataShow(LogPath + GlobalDefine.ErrorLogFile, dataGridView_ErrorLog);
            DataShow(LogPath + GlobalDefine.MesLogFile, dataGridView_MesLog);
        }

        void DataShow(string Path, DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();

            DataTable? data = DatabaseOperations.ErrorMesLogSelect(Path, comboBox_Device.Text);
            if (data != null)
            {
                DataTable dgvDataTable = new DgvDataTable().Data;
                foreach (DataRow row in data.Rows)
                {
                    DataRow dr = dgvDataTable.NewRow();
                    dr["发生时间"] = row["Time"].ToString();
                    dr["设备编号"] = row["FStageNo"].ToString();
                    dr["错误类型"] = row["LType"].ToString();
                    dr["错误内容"] = row["lMessage"].ToString();

                    //Time '时间',FStageNo '设备编号',LType '日志类型',lMessage '日志内容' 
                    dgvDataTable.Rows.Add(dr);
                }
                dataGridView.DataSource = dgvDataTable;
                dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public class DgvDataTable
        {
            public DataTable Data;

            public DgvDataTable()
            {
                Data = new DataTable();
                Data.Columns.Add("发生时间");
                Data.Columns.Add("设备编号");
                Data.Columns.Add("错误类型");
                Data.Columns.Add("错误内容");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            string LogPath = GlobalDefine.ErrorMesLogPath + $"{dateTime.Year}\\{dateTime.Month}\\{dateTime.Day}\\";
            DataShow(LogPath + GlobalDefine.RunLogFile, dataGridView_RunLog);
            DataShow(LogPath + GlobalDefine.AlarmLogFile, dataGridView_AlarmLog);
            DataShow(LogPath + GlobalDefine.ErrorLogFile, dataGridView_ErrorLog);
            DataShow(LogPath + GlobalDefine.MesLogFile, dataGridView_MesLog);
        }

        private void Form运行记录_Activated(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string LogPath = GlobalDefine.ErrorMesLogPath + $"{dateTime.Year}\\{dateTime.Month}\\{dateTime.Day}\\";
            DataShow(LogPath + GlobalDefine.RunLogFile, dataGridView_RunLog);
            DataShow(LogPath + GlobalDefine.AlarmLogFile, dataGridView_AlarmLog);
            DataShow(LogPath + GlobalDefine.ErrorLogFile, dataGridView_ErrorLog);
            DataShow(LogPath + GlobalDefine.MesLogFile, dataGridView_MesLog);
        }

    }
}
