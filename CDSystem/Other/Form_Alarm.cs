
using CDClassLibrary;
using CDClassLibrary.Log;
using CDSystem.Language;

namespace CDSystem.Other
{
    public partial class Form_Alarm : Form
    {
        public void Language()
        {
            Col错误类型.HeaderText = ResourceLang.Form_AlarmCol错误类型HeaderText;
            Col错误内容.HeaderText = ResourceLang.Form_AlarmCol错误内容HeaderText;
            Col发生时间.HeaderText = ResourceLang.Form_AlarmCol发生时间HeaderText;
            Col设备编号.HeaderText = ResourceLang.Form_AlarmCol设备编号HeaderText;
        }

        public Form_Alarm()
        {
            InitializeComponent();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LogHelperADD(GlobalParams.RunLog, false);
            LogHelperADD(GlobalParams.ErrorLog);
            LogHelperADD(GlobalParams.AlarmLog);
            LogHelperADD(GlobalParams.MesLog, false);

            GlobalParams.RunLog.Clear();
            GlobalParams.ErrorLog.Clear();
            GlobalParams.AlarmLog.Clear();
            GlobalParams.MesLog.Clear();
        }

        void LogHelperADD(List<LogHelper> LogHelper, bool boov = true)
        {
            int Count = LogHelper.Count;
            if (Count > 0)
            {
                LogHelper[] Log = new LogHelper[Count];
                Array.Copy(LogHelper.ToArray(), Log, Count);

                this.Show();
                if (dataGridView_Log.Rows.Count + Count > 100)
                    dataGridView_Log.Rows.Clear();
                dataGridView_Log.ClearSelection();
                foreach (var item in Log)
                {
                    int index = dataGridView_Log.Rows.Add();
                    dataGridView_Log.Rows[index].HeaderCell.Value = (index + 1).ToString();
                    dataGridView_Log.Rows[index].Cells["Col发生时间"].Value = item.Time;
                    dataGridView_Log.Rows[index].Cells["Col设备编号"].Value = item.FStageNo;
                    dataGridView_Log.Rows[index].Cells["Col错误类型"].Value = item.LType;
                    dataGridView_Log.Rows[index].Cells["Col错误内容"].Value = item.LMessage;
                    dataGridView_Log.Rows[index].Selected = true;
                }
                if (this.dataGridView_Log.Rows.Count > 0)
                {
                    if (boov)
                        label1.Text = Log[Count - 1].LType;
                    dataGridView_Log.FirstDisplayedScrollingRowIndex = this.dataGridView_Log.Rows.Count - 1;
                }
            }
        }

        private void Form_Alarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}