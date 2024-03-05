using CDClassLibrary;
using CDClassLibrary.Stage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDSystem.传感数据
{
    public partial class Form逆变器信息 : Form
    {
        public void Language()
        {

        }

        public Form逆变器信息()
        {
            InitializeComponent();


            dataGridView_Step.Columns.Clear();
            dataGridView_Step.Columns.Add("逆变器1", "逆变器1");
            dataGridView_Step.Columns.Add("逆变器2", "逆变器2");
            dataGridView_Step.Columns.Add("逆变器3", "逆变器3");


            int
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "前级 AC 电压 ab";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "前级 AC 电压 bc";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "前级 AC 电压 ca ";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "软件版本号";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "硬件版本号";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "日期";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "前级温度";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级输出电流1";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级输出电流 2";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级 DC 电压输出";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级环境温度";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "前级输出欠压";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "前级输出过压";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "前级过温故障";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "前级风扇异常";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级故障";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级输出欠压";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级输出过压";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级过温故障";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级风扇异常";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "前级状态";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "前级开关机状态";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "前级工作状态";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级状态";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级开关机状态";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "后级工作状态";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "通信状态";
            x = dataGridView_Step.Rows.Add(); dataGridView_Step.Rows[x].HeaderCell.Value = "数据有效标记";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TInverterDataLorentz[] InverterDataLorentz = GlobalParams.GStages[GlobalParams.SelectStage].EnvData.InverterDataLorentz;
            int ColIndex = 0;
            foreach (var item in InverterDataLorentz)
            {
                int RowsIndex = 0;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.AC_Vab;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.AC_Vbc;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.AC_Vca;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.SoftwareVersion + "_" + item.SoftwareVersionID;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.HardwareVersion + "_" + item.HardwareVersionID;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.DateYVersion + "-" + item.DateMVersion + "-" + item.DateDVersion;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.PreAmpTemp;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.Amp_C1;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.Amp_C2;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.AmpDC_V;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.AmpTemp;

                dataGridView_Step.Rows[RowsIndex].Cells[ColIndex].Value = item.InverterAlarm.前级输出欠压 ? "0" : "1";
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Style.BackColor = item.InverterAlarm.前级输出欠压 ? Color.Red : Color.Empty;
                dataGridView_Step.Rows[RowsIndex].Cells[ColIndex].Value = item.InverterAlarm.前级输出过压 ? "0" : "1";
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Style.BackColor = item.InverterAlarm.前级输出过压 ? Color.Red : Color.Empty;
                dataGridView_Step.Rows[RowsIndex].Cells[ColIndex].Value = item.InverterAlarm.前级过温故障 ? "0" : "1";
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Style.BackColor = item.InverterAlarm.前级过温故障 ? Color.Red : Color.Empty;
                dataGridView_Step.Rows[RowsIndex].Cells[ColIndex].Value = item.InverterAlarm.前级风扇异常 ? "0" : "1";
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Style.BackColor = item.InverterAlarm.前级风扇异常 ? Color.Red : Color.Empty;
                dataGridView_Step.Rows[RowsIndex].Cells[ColIndex].Value = item.InverterAlarm.后级故障 ? "0" : "1";
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Style.BackColor = item.InverterAlarm.后级故障 ? Color.Red : Color.Empty;
                dataGridView_Step.Rows[RowsIndex].Cells[ColIndex].Value = item.InverterAlarm.后级输出欠压 ? "0" : "1";
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Style.BackColor = item.InverterAlarm.后级输出欠压 ? Color.Red : Color.Empty;
                dataGridView_Step.Rows[RowsIndex].Cells[ColIndex].Value = item.InverterAlarm.后级输出过压 ? "0" : "1";
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Style.BackColor = item.InverterAlarm.后级输出过压 ? Color.Red : Color.Empty;
                dataGridView_Step.Rows[RowsIndex].Cells[ColIndex].Value = item.InverterAlarm.后级过温故障 ? "0" : "1";
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Style.BackColor = item.InverterAlarm.后级过温故障 ? Color.Red : Color.Empty;
                dataGridView_Step.Rows[RowsIndex].Cells[ColIndex].Value = item.InverterAlarm.后级风扇异常 ? "0" : "1";
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Style.BackColor = item.InverterAlarm.后级风扇异常 ? Color.Red : Color.Empty;
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = GlobalFunction.GetValue(item.InverterState.FrontState);
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = GlobalFunction.GetValue(item.InverterState.FrontSwitchOnOffState);
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = GlobalFunction.GetValue(item.InverterState.FrontWorkState);
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = GlobalFunction.GetValue(item.InverterState.AfterState);
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = GlobalFunction.GetValue(item.InverterState.AfterSwitchOnOffState);
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = GlobalFunction.GetValue(item.InverterState.AfterWorkState);
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = GlobalFunction.GetValue(item.ComState);
                dataGridView_Step.Rows[RowsIndex++].Cells[ColIndex].Value = item.DataValidflag;
                ColIndex++;
            }
        }
    }
}
