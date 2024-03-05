
using CDClassLibrary;
using CDClassLibrary.Data;
using CDClassLibrary.Mes;
using System.Data;

namespace CDSystem
{
    public partial class FormHTTP测试 : Form
    {
        public FormHTTP测试()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            HttpWMS.NotifyCellFinishTest(1, 1);
            foreach (var item in GlobalParams.AlarmLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.AlarmLog.Clear();
            foreach (var item in GlobalParams.MesLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.MesLog.Clear();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            HttpWMS.NotifyWMSStandingFireAlarm(8, 1);
            foreach (var item in GlobalParams.AlarmLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.AlarmLog.Clear();
            foreach (var item in GlobalParams.MesLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.MesLog.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HttpWMS.UploadWarehouseTestResult(1, 1);
            foreach (var item in GlobalParams.AlarmLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.AlarmLog.Clear();
            foreach (var item in GlobalParams.MesLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.MesLog.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            HttpWMS.RequetWarehouseCellBingAsset(3, 1);
            foreach (var item in GlobalParams.AlarmLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.AlarmLog.Clear();
            foreach (var item in GlobalParams.MesLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.MesLog.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HttpWMS.NotifyCellWorkState(false, 3, 2);
            foreach (var item in GlobalParams.AlarmLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.AlarmLog.Clear();
            foreach (var item in GlobalParams.MesLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.MesLog.Clear();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            HttpWMS.RequestReleasePull(1, 1, "A001001");
            foreach (var item in GlobalParams.AlarmLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.AlarmLog.Clear();
            foreach (var item in GlobalParams.MesLog)
                richTextBox1.AppendText(item.LType + item.LMessage + "\r\n");
            GlobalParams.MesLog.Clear();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            bool boo = SqlServerData.DataWrite(  "D:\\123.db", CDClassLibrary.Stage.TDeviceType.CDC3);
            if (boo)
            {

            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [BYDDATA].[dbo].[CDC3_Table] where ID in(SELECT MAX(ID) FROM [BYDDATA].[dbo].[CDC3_Table] where SFC='FC468008WL9999191148')";
            DataTable data = DataCon.Reader(sql);
            if (data != null)
            {

                //byte[] byteDATA_RESULTs = (byte) data.Rows[0]["DATA_RESULT"]; 

                //string[] DATA_RESULTs = JsonConvert.DeserializeObject<string[]>(ZipUp.DecompressionObject<string>(byteDATA_RESULTs));

            }
        }
    }
}
