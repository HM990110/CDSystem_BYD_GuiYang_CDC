using CDClassLibrary.Stage;
using CDClassLibrary;
using CDSystem.手动作业;
using System.Text;
using CDSystem.Language;
using CDSystem.Other;

namespace CDSystem.实时数据
{
    public partial class Form实时数据 : Form
    {
        public void Language()
        {
            label3.Text = ResourceLang.Form实时数据label3Text;
            label4.Text = ResourceLang.Form实时数据label4Text;
            label5.Text = ResourceLang.Form实时数据label5Text;
            label6.Text = ResourceLang.Form实时数据label6Text;
            label7.Text = ResourceLang.Form实时数据label7Text;
            label8.Text = ResourceLang.Form实时数据label8Text;
            buttonNG代码.Text = ResourceLang.Form实时数据buttonNG代码Text;
            button初始操作.Text = ResourceLang.Form实时数据button初始操作Text;
            button电压电流.Text = ResourceLang.Form实时数据button电压电流Text;
            button掉电恢复.Text = ResourceLang.Form实时数据button掉电恢复Text;
            button发送流程.Text = ResourceLang.Form实时数据button发送流程Text;
            button工作时间.Text = ResourceLang.Form实时数据button工作时间Text;
            button工作状态.Text = ResourceLang.Form实时数据button工作状态Text;
            button流程信息.Text = ResourceLang.Form实时数据button流程信息Text;
            button电芯条码.Text = ResourceLang.Form实时数据button电芯条码Text;
            button其他.Text = ResourceLang.Form实时数据button其他Text;
            button视图切换.Text = ResourceLang.Form实时数据button视图切换Text;
            button容量能量.Text = ResourceLang.Form实时数据button容量能量Text;
            button数据截取.Text = ResourceLang.Form实时数据button数据截取Text;
            button停止流程.Text = ResourceLang.Form实时数据button停止流程Text;
            button温度.Text = ResourceLang.Form实时数据button温度Text;
            button线电压阻抗.Text = ResourceLang.Form实时数据button线电压阻抗Text;
            button重新作业.Text = ResourceLang.Form实时数据button重新作业Text;
            label1.Text = ResourceLang.Form实时数据label1Text;
            label11.Text = ResourceLang.Form实时数据labelNGCountText;
            label10.Text = ResourceLang.Form实时数据label10Text;

            ShowselectType();
            UserControl曲线.Language();
            UserControl设备选中.Language();
        }

        public (TableLayoutPanel tableLayoutPanel, Label labelChnNo, Label labelStr1Unit, Label labelStr1, Label labelStr2Unit, Label labelStr2)[] UserControl电池S =
            new (TableLayoutPanel tableLayoutPanel, Label labelChnNo, Label labelStr1Unit, Label labelStr1, Label labelStr2Unit, Label labelStr2)[GlobalDefine.CHANNELS];

        public delegate void MyDelFormShow(string FormName);
        readonly MyDelFormShow _delFormShow;

        private UserControl设备选中 UserControl设备选中;
        private UserControl曲线 UserControl曲线;

        public Form实时数据(MyDelFormShow delFormShow)
        {
            InitializeComponent();

            ViewShow();
            _delFormShow = delFormShow;
            Power();
        }

        public void Power()
        {
            button初始操作.Enabled = Program.ClassUser.Power.初始操作;
            button掉电恢复.Enabled = Program.ClassUser.Power.掉电操作;
            button重新作业.Enabled = Program.ClassUser.Power.重新作业;
            button停止流程.Enabled = Program.ClassUser.Power.停止流程;
            button发送流程.Enabled = Program.ClassUser.Power.发送流程;
        }

        private void ViewShow()
        {
            int ColumnCount = GlobalDefine.CHANNELColumn;
            int RowCount = GlobalDefine.CHANNELRow;

            tableLayoutPanel电池.ColumnStyles.Clear();
            tableLayoutPanel电池.ColumnCount = ColumnCount + 1;
            for (int i = 0; i < ColumnCount; i++)
                tableLayoutPanel电池.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel电池.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            tableLayoutPanel电池.RowStyles.Clear();
            tableLayoutPanel电池.RowCount = RowCount + 1;
            for (int i = 0; i < RowCount; i++)
                tableLayoutPanel电池.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel电池.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    int ChnNo = i * ColumnCount + j;

                    UserControl电池S[ChnNo].labelChnNo = new Label()
                    {
                        AutoSize = true,
                        Dock = DockStyle.Fill,
                        Font = new Font("微软雅黑", 9F, FontStyle.Bold),
                        Text = $"{ChnNo + 1:000}  [{(i + 1).ToString("00") + "-" + (j + 1).ToString("00")}]",
                        Tag = ChnNo,
                        BackColor = Color.White,
                        Margin = new Padding(0),
                    };
                    UserControl电池S[ChnNo].labelChnNo.DoubleClick += UserControl电池S_DoubleClick;
                    UserControl电池S[ChnNo].labelStr2 = new Label()
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleRight,
                        Dock = DockStyle.Fill,
                        Tag = ChnNo,
                        BackColor = Color.White,
                        Margin = new Padding(0),
                    };
                    UserControl电池S[ChnNo].labelStr2.DoubleClick += UserControl电池S_DoubleClick;
                    UserControl电池S[ChnNo].labelStr2Unit = new Label()
                    {
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Dock = DockStyle.Fill,
                        Tag = ChnNo,
                        BackColor = Color.White,
                        Margin = new Padding(0),
                        Text = "电压",
                    };
                    UserControl电池S[ChnNo].labelStr2Unit.DoubleClick += UserControl电池S_DoubleClick;
                    UserControl电池S[ChnNo].labelStr1 = new Label()
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleRight,
                        Dock = DockStyle.Fill,
                        Tag = ChnNo,
                        BackColor = Color.White,
                        Margin = new Padding(0),
                    };
                    UserControl电池S[ChnNo].labelStr1.DoubleClick += UserControl电池S_DoubleClick;
                    UserControl电池S[ChnNo].labelStr1Unit = new Label()
                    {
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Dock = DockStyle.Fill,
                        Tag = ChnNo,
                        BackColor = Color.White,
                        Margin = new Padding(0),
                        Text = "电流"
                    };
                    UserControl电池S[ChnNo].labelStr1Unit.DoubleClick += UserControl电池S_DoubleClick;
                    TableLayoutPanel tableLayoutPanel = new()
                    {
                        RowCount = 3,
                        ColumnCount = 2,
                        Dock = DockStyle.Fill,
                        Tag = ChnNo,
                        BackColor = Color.Black,
                        Padding = new Padding(1)
                    };
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

                    tableLayoutPanel.Controls.Add(UserControl电池S[ChnNo].labelStr2, 1, 2);
                    tableLayoutPanel.Controls.Add(UserControl电池S[ChnNo].labelStr2Unit, 0, 2);
                    tableLayoutPanel.Controls.Add(UserControl电池S[ChnNo].labelStr1, 1, 1);
                    tableLayoutPanel.Controls.Add(UserControl电池S[ChnNo].labelStr1Unit, 0, 1);
                    tableLayoutPanel.Controls.Add(UserControl电池S[ChnNo].labelChnNo, 0, 0);
                    tableLayoutPanel.SetColumnSpan(UserControl电池S[ChnNo].labelChnNo, 2);
                    tableLayoutPanel.DoubleClick += UserControl电池S_DoubleClick;

                    UserControl电池S[ChnNo].tableLayoutPanel = tableLayoutPanel;
                    tableLayoutPanel电池.Controls.Add(tableLayoutPanel, j, i);
                }
            }

            ButtonOld = button电压电流;

            UserControl设备选中 = new UserControl设备选中();
            tableLayoutPanel1.Controls.Add(UserControl设备选中, 0, 0);
            UserControl设备选中.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserControl设备选中.BackColor = Color.White;
            UserControl设备选中.Location = new Point(4, 4);
            UserControl设备选中.Margin = new Padding(4);
            tableLayoutPanel1.SetRowSpan(UserControl设备选中, 2);
            UserControl设备选中.Size = new Size(292, 32);

            UserControl曲线 = new UserControl曲线();
            UserControl曲线.Dock = DockStyle.Fill;
            Controls.Add(UserControl曲线);

        }

        enum SelectType
        {
            工作时间,
            工作状态,
            电压电流,
            线电压阻抗,
            容量能量,
            温度,
            其他,
        }
        SelectType selectType = SelectType.电压电流;

        public void RealTimeDataShow()
        {
            timer1.Enabled = true && button视图切换.Tag.ToString() == "曲线展示";
            timer3.Enabled = true;
            AddNewDataTimer.Enabled = true && button视图切换.Tag.ToString() != "曲线展示";
            DataChange1();
            DataChange3();
            UserControl曲线.DataShow();
        }

        public void RealTimeDataClose()
        {
            timer1.Enabled = false;
            timer3.Enabled = false;
            AddNewDataTimer.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DataChange1();
        }
        private void DataChange1()
        {
            TRealTimeData RealTimeData = GlobalParams.GStages[GlobalParams.SelectStage].RealTimeData;
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                string ShowStr1 = string.Empty;
                string ShowStr2 = string.Empty;

                switch (selectType)
                {
                    case SelectType.工作时间:
                        ShowStr1 = TStructConvert.IntToTime((int)(RealTimeData.ChannelRealTimeData[ChnNo].ProcessTime * 1000));
                        ShowStr2 = TStructConvert.IntToTime((int)(RealTimeData.ChannelRealTimeData[ChnNo].StepWorkTime * 1000));
                        break;
                    case SelectType.工作状态:
                        ShowStr1 = GlobalFunction.GetValue(RealTimeData.ChannelRealTimeData[ChnNo].ProcessStatus);
                        ShowStr2 = RealTimeData.ChannelRealTimeData[ChnNo].ChnState.ToString("X2");
                        break;
                    case SelectType.电压电流:
                        ShowStr1 = RealTimeData.ChannelRealTimeData[ChnNo].Volt.ToString("F2");
                        ShowStr2 = RealTimeData.ChannelRealTimeData[ChnNo].Curre.ToString("F2");
                        break;
                    case SelectType.线电压阻抗:
                        ShowStr1 = RealTimeData.ChannelRealTimeData[ChnNo].LineVolt.ToString("F2");
                        ShowStr2 = RealTimeData.ChannelRealTimeData[ChnNo].IR.ToString("F2");
                        break;
                    case SelectType.容量能量:
                        ShowStr1 = RealTimeData.ChannelRealTimeData[ChnNo].Capacity.ToString("F2");
                        ShowStr2 = RealTimeData.ChannelRealTimeData[ChnNo].Energy.ToString("F2");
                        break;
                    case SelectType.温度:
                        ShowStr1 = RealTimeData.ChannelRealTimeData[ChnNo].ChannelTemp.ToString("F2");
                        ShowStr2 = RealTimeData.ChannelRealTimeData[ChnNo].CellTemp.ToString("F2");
                        break;
                    case SelectType.其他:
                        ShowStr1 = (RealTimeData.ChannelRealTimeData[ChnNo].Volt - RealTimeData.ChannelRealTimeData[ChnNo].LineVolt).ToString("F2");
                        ShowStr2 = RealTimeData.ChannelRealTimeData[ChnNo].StepNo + "_" + RealTimeData.ChannelRealTimeData[ChnNo].StepMode;
                        break;
                }

                UserControl电池S[ChnNo].labelStr1.Text = ShowStr1;
                UserControl电池S[ChnNo].labelStr2.Text = ShowStr2;
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            label_MDL_NAME.Text = GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.MDL_NAME;
            label_TRAY_NO.Text = GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.TRAY_NO;
            label_CELL_COUNT.Text = GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.CELL_COUNT.ToString();
            label_NG_COUNT.Text = GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.NG_COUNT.ToString();
            label_ProcessName.Text = GlobalParams.GStages[GlobalParams.SelectStage].ProcessGroup.ProcessName.ToString();

            label_ProcessTime.Text = TStructConvert.IntToTime((int)(GlobalParams.GStages[GlobalParams.SelectStage].RealTimeData.ProcessTime * 1000));
            label_StepWorkTime.Text = TStructConvert.IntToTime((int)(GlobalParams.GStages[GlobalParams.SelectStage].RealTimeData.StepWorkTime * 1000));
            label_ProcessStatus.Text = GlobalFunction.GetValue(GlobalParams.GStages[GlobalParams.SelectStage].RealTimeData.ProcessStatus);
            label_StepMode.Text = GlobalParams.GStages[GlobalParams.SelectStage].RealTimeData.StepNo + "_" + GlobalParams.GStages[GlobalParams.SelectStage].RealTimeData.StepMode.ToString();

            //Button掉电恢复.Enabled = Program.UserClass.powers[7] && GlobalParams.GStages[GlobalParams.SelectStage].EnvData.PowerFailFlag == TPowerFailFlag.pfOccurred;
            //Button_SendProcess.Enabled = Program.UserClass.powers[7] && GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag == TProcessFlag.pfInit;
            //Button停止流程.Enabled = Program.UserClass.powers[7] && GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag);
            //Button重新作业.Enabled = Program.UserClass.powers[7] && !GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag);

            DataChange3();
        }
        private void DataChange3()
        {
            TRealTimeData RealTimeData = GlobalParams.GStages[GlobalParams.SelectStage].RealTimeData;
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                Color color;
                if (GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.ChnState[ChnNo] == 0x60)
                {

                    color = Color.White;
                }
                else if (GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.ChnState[ChnNo] == 0x61)
                {
                    color = Color.Gainsboro;
                }
                else
                {
                    if (RealTimeData.ProcessStatus != TProcessStatus.Init)
                    {
                        switch (RealTimeData.ChannelRealTimeData[ChnNo].ChnState)
                        {
                            case 0x00:
                                if (RealTimeData.ChannelRealTimeData[ChnNo].ProcessStatus != TProcessStatus.Stop)
                                {
                                    color = RealTimeData.ChannelRealTimeData[ChnNo].StepMode switch
                                    {
                                        TStepMode.REST => Color.Yellow,
                                        TStepMode.CC => Color.Orange,
                                        TStepMode.CV => Color.Gold,
                                        TStepMode.CCCV => Color.DarkOrange,
                                        TStepMode.DC => Color.LightSkyBlue,
                                        TStepMode.DV => Color.Maroon,
                                        TStepMode.DCDV => Color.Blue,
                                        _ => Color.Cyan,
                                    };
                                }
                                else
                                    color = Color.Cyan;
                                break;
                            case 0x60:
                                color = Color.White;
                                break;
                            case 0x61:
                                color = Color.WhiteSmoke;
                                break;
                            default:
                                color = Color.Red;
                                break;
                        }
                    }
                    else
                    {
                        color = Color.Cyan;
                    }
                }
                UserControl电池S[ChnNo].labelChnNo.BackColor = color;
                UserControl电池S[ChnNo].labelStr1Unit.BackColor = color;
                UserControl电池S[ChnNo].labelStr1.BackColor = color;
                UserControl电池S[ChnNo].labelStr2Unit.BackColor = color;
                UserControl电池S[ChnNo].labelStr2.BackColor = color;
            }
        }

        Button ButtonOld = new();
        private void Button_Click(object sender, EventArgs e)
        {
            ButtonOld.BackColor = Color.White;
            Button button = (Button)sender;
            button.BackColor = Color.Silver;
            ButtonOld = button;
            string strType = button.Tag.ToString()!;
            selectType = (SelectType)Enum.Parse(typeof(SelectType), strType);
            ShowselectType();

            DataChange1();
            DataChange3();
        }

        private void ShowselectType()
        {
            string ShowStr1Unit = string.Empty;
            string ShowStr2Unit = string.Empty;
            switch (selectType)
            {
                case SelectType.工作时间:
                    ShowStr1Unit = "P:";
                    ShowStr2Unit = "S:";
                    break;
                case SelectType.工作状态:
                    ShowStr1Unit = "W:";
                    ShowStr2Unit = "N:";
                    break;
                case SelectType.电压电流:
                    ShowStr1Unit = "V:";
                    ShowStr2Unit = "C:";
                    break;
                case SelectType.线电压阻抗:
                    ShowStr1Unit = "L:";
                    ShowStr2Unit = "I:";
                    break;
                case SelectType.容量能量:
                    ShowStr1Unit = "C:";
                    ShowStr2Unit = "E:";
                    break;
                case SelectType.温度:
                    ShowStr1Unit = "C:";
                    ShowStr2Unit = "B:";
                    break;
                case SelectType.其他:
                    ShowStr1Unit = "V:";
                    ShowStr2Unit = "S:";
                    break;
            }
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                UserControl电池S[ChnNo].labelStr1Unit.Text = ShowStr1Unit;
                UserControl电池S[ChnNo].labelStr2Unit.Text = ShowStr2Unit;
            }
        }

        private void ButtonNG代码_Click(object sender, EventArgs e)
        {
            new Form_NG代码().ShowDialog();
        }

        private void Button流程信息_Click(object sender, EventArgs e)
        {
            new Form流程信息(GlobalParams.GStages[GlobalParams.SelectStage].ProcessGroup).ShowDialog();
        }

        private void Button初始操作_Click(object sender, EventArgs e)
        {
            string ProcessFlagStr = "";
            if (GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag))
                ProcessFlagStr = "设备作业中，";
            if (MessageBox.Show(ProcessFlagStr + "是否要初始化设备状态", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                GlobalParams.GStages[GlobalParams.SelectStage].StateInit();
        }

        private void Button掉电恢复_Click(object sender, EventArgs e)
        {
            if (GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssPowerDown)
                if (MessageBox.Show("是否要执行掉电恢复命令", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    GlobalParams.GStages[GlobalParams.SelectStage].Continue();
        }

        private void Button重新作业_Click(object sender, EventArgs e)
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

        private void Button停止流程_Click(object sender, EventArgs e)
        {
            if (GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag) ||
                GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssReady ||
                GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssWait ||
                GlobalParams.GStages[GlobalParams.SelectStage].StageState == TStageState.ssRunning)
                if (MessageBox.Show("是否要停止流程", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    GlobalParams.GStages[GlobalParams.SelectStage].StopJob();
        }

        private void Button发送流程_Click(object sender, EventArgs e)
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

        private void Button曲线展示_Click(object sender, EventArgs e)
        {
            if (button视图切换.Tag.ToString() == "曲线展示")
            {
                UserControl曲线.BringToFront();
                UserControl曲线.DataShow();
                timer1.Enabled = false;
                AddNewDataTimer.Enabled = true;
                button视图切换.Tag = "数据展示";
            }
            else
            {
                panel数据.BringToFront();
                timer1.Enabled = true;
                AddNewDataTimer.Enabled = false;
                button视图切换.Tag = "曲线展示";
            }
        }

        private void UserControl电池S_DoubleClick(object sender, EventArgs e)
        {
            if (button视图切换.Tag.ToString() == "曲线展示")
            {
                Control control = (Control)sender;
                UserControl曲线.BringToFront();
                UserControl曲线.DataShow();
                timer1.Enabled = false;
                AddNewDataTimer.Enabled = true;
                button视图切换.Tag = "数据展示";
                UserControl曲线.LineSelect((int)control.Tag);
            }
        }

        private void Button数据截取_Click(object sender, EventArgs e)
        {
            TRealTimeData RealTimeData = GlobalParams.GStages[GlobalParams.SelectStage].RealTimeData;
            SaveFileDialog dialog = new()
            {
                Filter = "CSV文件(*.csv)|*.csv"
            };
            ; //设置文件类型
            dialog.FileName = DateTime.Now.ToString("yyyyMMddhhmmss");  //设置默认文件名
            dialog.DefaultExt = "csv"; //设置默认格式（可以不设）
            dialog.AddExtension = true; //设置自动在文件名中添加扩展名
            dialog.RestoreDirectory = true;//保存对话框是否记忆上次打开的目录 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string save_filename = dialog.FileName.ToString(); //获得文件路径   
                StreamWriter streamWriter = new(save_filename, false);
                string strTitle =
                    "通道号,流程总工作时间,步次工作时间,通道工作状态,通道步次序号," +
                    "通道步次类型,通道诊断值,通道电压,通道电流,通道线电压,通道容量," +
                    "通道能量/功率值,通道温度,电池温度,接触阻抗";
                streamWriter.WriteLine(strTitle);

                StringBuilder stringBuilder = new();
                foreach (var item in RealTimeData.ChannelRealTimeData)
                {
                    string str =
                        item.ChnNo + "," +
                        TStructConvert.IntToTime((int)(item.ProcessTime * 1000)) + "," +
                        TStructConvert.IntToTime((int)(item.StepWorkTime * 1000)) + "," +
                        GlobalFunction.GetValue(item.ProcessStatus) + "," +
                        item.StepNo + "," +
                        GlobalFunction.GetValue(item.StepMode) + "," +
                        item.ChnState.ToString("X2") + "," +
                        item.Volt.ToString("F2") + "," +
                        item.Curre.ToString("F2") + "," +
                        item.LineVolt.ToString("F2") + "," +
                        item.Capacity.ToString("F2") + "," +
                        item.Energy.ToString("F2") + "," +
                        item.ChannelTemp.ToString("F2") + "," +
                        item.CellTemp.ToString("F2") + "," +
                        item.IR.ToString("F2") + ",";
                    stringBuilder.AppendLine(str);
                }
                streamWriter.Write(stringBuilder.ToString());
                streamWriter.Flush();
                streamWriter.Close();

                File.Open(save_filename, FileMode.Open);
            }
        }

        private void Button电芯条码_Click(object sender, EventArgs e)
        {
            new Form电芯条码().ShowDialog();
        }

        private void AddNewDataTimer_Tick(object sender, EventArgs e)
        {
            UserControl曲线.DataShow();
        }
    }
}

