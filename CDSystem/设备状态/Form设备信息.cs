using CDClassLibrary.Stage;
using CDClassLibrary;
using CDSystem.手动作业;
using System.Data.SqlTypes;
using CDSystem.Other;
using CDSystem.Language;
using CDClassLibrary.Mes;

namespace CDSystem.设备状态
{
    public partial class Form设备信息 : Form
    {
        public void Language()
        {
            button1.Text = ResourceLang.Form设备信息button1Text;
            button2.Text = ResourceLang.Form设备信息button2Text;
            button4.Text = ResourceLang.Form设备信息button4Text;
            button6.Text = ResourceLang.Form设备信息button6Text;
            groupBox1.Text = ResourceLang.Form设备信息groupBox1Text;
            groupBox2.Text = ResourceLang.Form设备信息groupBox2Text;
            groupBox3.Text = ResourceLang.Form设备信息groupBox3Text;
            groupBox4.Text = ResourceLang.Form设备信息groupBox4Text;
            groupBox5.Text = ResourceLang.Form设备信息groupBox5Text;
            groupBox6.Text = ResourceLang.Form设备信息groupBox6Text;
            groupBox无通信.Text = ResourceLang.Form设备信息groupBox无通信Text;
            label1.Text = ResourceLang.Form设备信息label1Text;
            label10.Text = ResourceLang.Form设备信息label10Text;
            label11.Text = ResourceLang.Form设备信息label11Text;
            label12.Text = ResourceLang.Form设备信息label12Text;
            label13.Text = ResourceLang.Form设备信息label13Text;
            label14.Text = ResourceLang.Form设备信息label14Text;
            label2.Text = ResourceLang.Form设备信息label2Text;
            label3.Text = ResourceLang.Form设备信息label3Text;
            label4.Text = ResourceLang.Form设备信息label4Text;
            label5.Text = ResourceLang.Form设备信息label5Text;
            label6.Text = ResourceLang.Form设备信息label6Text;
            label7.Text = ResourceLang.Form设备信息label7Text;
            label8.Text = ResourceLang.Form设备信息label8Text;
            label9.Text = ResourceLang.Form设备信息label9Text;
            label15.Text = ResourceLang.Form设备信息labe火警Text;
            初始操作ToolStripMenuItem.Text = ResourceLang.Form设备信息初始操作ToolStripMenuItemText;
            传感数据ToolStripMenuItem.Text = ResourceLang.Form设备信息传感数据ToolStripMenuItemText;
            掉电操作ToolStripMenuItem.Text = ResourceLang.Form设备信息掉电操作ToolStripMenuItemText;
            掉电恢复ToolStripMenuItem.Text = ResourceLang.Form设备信息掉电恢复ToolStripMenuItemText;
            掉电清除ToolStripMenuItem.Text = ResourceLang.Form设备信息掉电清除ToolStripMenuItemText;
            发送流程ToolStripMenuItem.Text = ResourceLang.Form设备信息发送流程ToolStripMenuItemText;
            设备日志ToolStripMenuItem.Text = ResourceLang.Form设备信息设备日志ToolStripMenuItemText;
            流程信息ToolStripMenuItem.Text = ResourceLang.Form设备信息流程信息ToolStripMenuItemText;
            切置自动ToolStripMenuItem.Text = ResourceLang.Form设备信息切置自动ToolStripMenuItemText;
            设备维护ToolStripMenuItem.Text = ResourceLang.Form设备信息设备维护ToolStripMenuItemText;
            实时数据ToolStripMenuItem.Text = ResourceLang.Form设备信息实时数据ToolStripMenuItemText;
            停止流程ToolStripMenuItem.Text = ResourceLang.Form设备信息停止流程ToolStripMenuItemText;
            预约手动ToolStripMenuItem.Text = ResourceLang.Form设备信息预约手动ToolStripMenuItemText;
            重新作业ToolStripMenuItem.Text = ResourceLang.Form设备信息重新作业ToolStripMenuItemText;
            自动手动切换ToolStripMenuItem.Text = ResourceLang.Form设备信息自动手动切换ToolStripMenuItemText;

            Form_Alarm.Language();
        }

        private readonly UserControlDevice[] UserControlDevices = new UserControlDevice[GlobalDefine.NUM_ALLSTAGES];
        private readonly Form_Alarm Form_Alarm = new();

        public delegate void MyDelSelected();
        readonly MyDelSelected _delSelected;
        public delegate void MyDelFormShow(string FormName);
        readonly MyDelFormShow _delFormShow;

        public Form设备信息(MyDelFormShow delFormShow, MyDelSelected delSelected)
        {
            InitializeComponent();


            _delSelected = delSelected;
            _delFormShow = delFormShow;
            ViewShow();
            Power();

            Form_Alarm.TopLevel = false;
            Form_Alarm.Dock = DockStyle.Fill;
            Form_Alarm.FormBorderStyle = FormBorderStyle.None;
            Form_Alarm.Show();
            this.panel2.Controls.Add(Form_Alarm);
        }

        public void Power()
        {
            初始操作ToolStripMenuItem.Enabled = Program.ClassUser.Power.初始操作;
            掉电操作ToolStripMenuItem.Enabled = Program.ClassUser.Power.掉电操作;
            自动手动切换ToolStripMenuItem.Enabled = Program.ClassUser.Power.自动手动切换;
            重新作业ToolStripMenuItem.Enabled = Program.ClassUser.Power.重新作业;
            停止流程ToolStripMenuItem.Enabled = Program.ClassUser.Power.停止流程;
            发送流程ToolStripMenuItem.Enabled = Program.ClassUser.Power.发送流程;
            强制出库ToolStripMenuItem.Enabled = Program.ClassUser.Power.设备维护;
            设备维护ToolStripMenuItem.Enabled = Program.ClassUser.Power.设备维护;
        }

        public void ViewShow()
        {
            int ColumnCount = GlobalDefine.NUM_STAGEPERDEVICE;
            int RowCount = GlobalDefine.NUM_DEVICEPERLINE;

            tableLayoutPanelDevice.ColumnStyles.Clear();
            tableLayoutPanelDevice.ColumnCount = ColumnCount + 1;
            for (int i = 0; i < ColumnCount; i++)
                tableLayoutPanelDevice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelDevice.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            tableLayoutPanelDevice.RowStyles.Clear();
            tableLayoutPanelDevice.RowCount = RowCount + 1;
            for (int i = 0; i < RowCount; i++)
                tableLayoutPanelDevice.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelDevice.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            for (int j = 0; j < ColumnCount; j++)
            {
                for (int i = 0; i < RowCount; i++)
                {
                    int ID = j * RowCount + i;
                    UserControlDevices[ID] = new UserControlDevice(ID)
                    {
                        Dock = DockStyle.Fill,
                        ContextMenuStrip = contextMenuStrip1
                    };
                    tableLayoutPanelDevice.Controls.Add(UserControlDevices[ID], j, RowCount - i - 1);
                    UserControlDevices[ID].UCMouseDown += UserControlDevice1_UCClick!;
                    UserControlDevices[ID].UCClick += UserControlDevice1_UCClick!;
                    UserControlDevices[ID].UCDoubleClick += UserControlDevice1_UCDoubleClick!;
                }
            }
            UserControlDevices[0].IsSelected(true);
            ButtonOld = button1;
        }

        Button ButtonOld = new();
        private void Button_Click(object sender, EventArgs e)
        {
            ButtonOld.BackColor = Color.White;
            Button button = (Button)sender;
            button.BackColor = Color.Silver;
            ButtonOld = button;
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                UserControlDevices[FStageID].SelectType = (SelectType)Enum.Parse(typeof(SelectType), button.Tag.ToString()!);
                UserControlDevices[FStageID].DataChange();
            }
        }

        private void UserControlDevice1_UCClick(object sender, EventArgs e)
        {
            for (int i = 0; i < UserControlDevices.Length; i++)
                UserControlDevices[i].IsSelected(false);
            _delSelected();
        }

        private void UserControlDevice1_UCDoubleClick(object sender, EventArgs e)
        {
            _delFormShow("实时数据");
        }

        private void 流程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form流程信息(GlobalParams.GStages[GlobalParams.SelectStage].ProcessGroup).ShowDialog();
        }

        private void 设备日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _delFormShow("运行记录");
        }

        private void 传感数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _delFormShow("传感数据");
        }

        private void 实时数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _delFormShow("实时数据");
        }

        private void 初始操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ProcessFlagStr = "";
            if (GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag))
                ProcessFlagStr = "设备作业中，";
            if (MessageBox.Show(ProcessFlagStr + "是否要初始化设备状态", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                GlobalParams.GStages[GlobalParams.SelectStage].StateInit();
        }

        private void 掉电恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssPowerDown)
                if (MessageBox.Show("是否要执行掉电恢复命令", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    GlobalParams.GStages[GlobalParams.SelectStage].Continue();
        }

        private void 切置自动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag))
            {
                if (MessageBox.Show($"是否要{切置自动ToolStripMenuItem.Text}状态？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GlobalParams.GStages[GlobalParams.SelectStage].ManualAutoFlag)
                    {
                        GlobalParams.GStages[GlobalParams.SelectStage].ManualAutoFlag = false;
                        GlobalDefine.ManualAutoFlags[GlobalParams.SelectStage] = false;
                        切置自动ToolStripMenuItem.Text = "切置自动";
                    }
                    else
                    {
                        GlobalParams.GStages[GlobalParams.SelectStage].ManualAutoFlag = true;
                        GlobalDefine.ManualAutoFlags[GlobalParams.SelectStage] = true;
                        切置自动ToolStripMenuItem.Text = "切置手动";
                    }
                    GlobalFunction.SetManualAutoFlag();
                }
            }
            else
            {
                MessageBox.Show("设备作业中不能进行此操作！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 重新作业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.GStages[GlobalParams.SelectStage].ManualAutoFlag && GlobalParams.GStages[GlobalParams.SelectStage].ProcessGroup.ProcessName == string.Empty)
                return;
            if (!GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag))
            {
                if (MessageBox.Show("是否要重新作业", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Msg = "";
                    if (!GlobalParams.GStages[GlobalParams.SelectStage].ReAssignment(ref Msg))
                        MessageBox.Show("重新作业失败：" + Msg, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("设备作业中不能进行此操作！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 停止流程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag) ||
                GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssReady ||
                GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssWait ||
                GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssRunning)
                if (MessageBox.Show("是否要停止流程", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    GlobalParams.GStages[GlobalParams.SelectStage].StopJob();
        }

        private void 发送流程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag))
            {
                MessageBox.Show("设备作业中不能进行此操作！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (GlobalParams.GStages[GlobalParams.SelectStage].ManualAutoFlag)
            {
                MessageBox.Show("设备自动模式中不能进行此操作！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _delFormShow("手动作业");
        }

        private void 设备维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag))
            {
                new Form设备维护().ShowDialog();
            }
            else
            {
                MessageBox.Show("设备作业中不能进行此操作！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DataShow();
        }

        private void DataShow()
        {
            int numbers闲置 = 0, numbers作业准备 = 0, numbers作业中 = 0, numbers作业完成 = 0, numbers报警 = 0, numbers未启用 = 0, numbers无通信 = 0;
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                switch (GlobalParams.GStages[FStageID].StageState)
                {
                    case TStageState.ssInit:
                        numbers闲置++;
                        break;
                    case TStageState.ssTrayIn:
                    case TStageState.ssReady:
                        numbers作业准备++;
                        break;
                    case TStageState.ssWait:
                    case TStageState.ssRunning:
                        numbers作业中++;
                        break;
                    case TStageState.ssProcessEnd:
                        numbers作业完成++;
                        break;
                    case TStageState.ssEMG:
                    case TStageState.ssPCAlarm:
                    case TStageState.ssTemp:
                    case TStageState.ssSmoke:
                    case TStageState.ssOverTime:
                    case TStageState.ssChargeDis:
                    case TStageState.ssPowerDown:
                        numbers报警++;
                        break;
                    case TStageState.ssVacancy:
                        numbers未启用++;
                        break;
                    case TStageState.ssOff:
                        numbers无通信++;
                        break;
                }

                UserControlDevices[FStageID].DataChange();
            }


            label闲置.Text = numbers闲置.ToString();
            label作业准备.Text = numbers作业准备.ToString();
            label作业中.Text = numbers作业中.ToString();
            label作业完成.Text = numbers作业完成.ToString();
            label报警.Text = numbers报警.ToString();
            label未启用.Text = numbers未启用.ToString();
            label无通信.Text = numbers无通信.ToString();



            labelWMS.Text = HttpWMS.DeviceOnOff ? ResourceLang.Form设备信息WMSConnectionSuccessful : ResourceLang.Form设备信息WMSConnectionFailed;
            labelWMS.BackColor = HttpWMS.DeviceOnOff ? Color.Yellow : Color.Red;
        }

        public void RealTimeDataShow()
        {
            timer1.Enabled = true;
            DataShow();
        }

        public void RealTimeDataClose()
        {
            timer1.Enabled = false;
        }

        private void 掉电清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssPowerDown)
                if (MessageBox.Show("是否要执行掉电清除命令", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    GlobalParams.CommMCU[GlobalParams.SelectStage].PowerFailControl(0xAA);
        }

        private void 预约手动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalParams.GStages[GlobalParams.SelectStage].ManualReservationFlag = !GlobalParams.GStages[GlobalParams.SelectStage].ManualReservationFlag;
        }

        private void ContextMenuStrip1_LocationChanged(object sender, EventArgs e)
        {
            切置自动ToolStripMenuItem.Text = GlobalParams.GStages[GlobalParams.SelectStage].ManualAutoFlag ? "切置手动" : "切置自动";
            预约手动ToolStripMenuItem.Text = GlobalParams.GStages[GlobalParams.SelectStage].ManualReservationFlag ? "取消预约手动" : "预约手动";
        }

        private void 强制出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("是否要强制出库", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag) ||
                    GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssReady ||
                    GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssWait ||
                    GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssRunning)
                    GlobalParams.GStages[GlobalParams.SelectStage].StopJob();

                //GlobalParams.GStages[SelectStage].InspectionEnd();
                GlobalParams.GStages[GlobalParams.SelectStage].CheckTrayOut(true);

                GlobalFunction.RunLogAdd(GlobalParams.GStages[GlobalParams.SelectStage].FStageNo, "强制出库", "用户：" + Program.ClassUser.Username + ",托盘<" + GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.TRAY_NO + ">强制出库");
            }
        }
    }
}
