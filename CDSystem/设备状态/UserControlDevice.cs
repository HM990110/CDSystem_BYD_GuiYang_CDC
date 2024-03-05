using CDClassLibrary.Stage;
using CDClassLibrary;
using System.ComponentModel;
using CDSystem.Language;
using System.Data.SqlTypes;

namespace CDSystem.设备状态
{
    [DefaultEvent("BtnClick")]
    public partial class UserControlDevice : UserControl
    {
        public int FStageID = 0;
        public string FStageNo = string.Empty;

        public UserControlDevice()
        {
            InitializeComponent();
        }

        public UserControlDevice(int FStageID)
        {
            InitializeComponent();
            this.FStageID = FStageID;
            this.FStageNo = GlobalParams.GStages[FStageID].FStageNo;
            LabelFStageNo.Text = this.FStageNo;
            this.BackColor = GlobalDefine.DeviceTypes[FStageID] == TDeviceType.CDC2 ? Color.Orange : Color.LightSkyBlue;
        }

        public void IsSelected(bool Selected = false)
        {
            if (Selected)
            {
                GlobalParams.SelectStage = FStageID;
                PanelFStageID.BackColor = Color.Orange;
            }
            else
            {
                PanelFStageID.BackColor = Color.Empty;
            }
        }

        readonly Color[] Colors = new Color[]
        {
            Color.Cyan,       Color.Gray,       Color.Silver,       Color.Blue,
            Color.Green,      Color.GreenYellow,Color.Yellow,       Color.Gold,
            Color.Red,        Color.Red,        Color.DarkRed,      Color.DarkRed,
            Color.Purple,     Color.DeepPink,   Color.Red,          Color.HotPink,
            Color.Gold,       Color.OrangeRed,  Color.Maroon
        };

        private SelectType selectType = SelectType.设备状态;
        public SelectType SelectType
        {
            get => selectType;
            set
            {
                selectType = value;
                /*
                switch (value)
                {
                    case SelectType.设备状态:
                        label1.Text = "设备状态:";
                        label2.Text = "工作模式:";
                        break;
                    case SelectType.机构温度:
                        label1.Text = "环境温度:";
                        label2.Text = "电池均温:";
                        break;
                    case SelectType.流程状态:
                        label1.Text = "流程标记";
                        label2.Text = "步次序号";
                        break;
                    case SelectType.工作时间:
                        label1.Text = "流程时间";
                        label2.Text = "步次时间:";
                        break;
                    case SelectType.托盘信息1:
                        label1.Text = "批次编号:";
                        label2.Text = "托盘编号:";
                        break;
                    case SelectType.托盘信息2:
                        label1.Text = "开始时间:";
                        label2.Text = "流程名称:";
                        break;
                    case SelectType.基隆信息1:
                        label1.Text = "设备IP:";
                        label2.Text = "工作模式:";
                        break;
                    case SelectType.基隆信息2:
                        label1.Text = "机械状态:";
                        label2.Text = "掉电标记:";
                        break;
                    case SelectType.基隆信息3:
                        label1.Text = "机构诊断:";
                        label2.Text = "软件版本:";
                        break;
                }
                */
            }
        }

        public void DataChange()
        {
            LabelDeviceOnOff.BackColor = GlobalParams.GStages[FStageID].EnvData.DeviceOnOff ? Color.Lime : Color.Red;
            LabelDeviceOnOff.Text = GlobalParams.GStages[FStageID].EnvData.DeviceOnOff ? (GlobalDefine.DeviceTypes[FStageID] == TDeviceType.CDC2 ? "CDC2" : "CDC3") : ResourceLang.ProgramDisConnect;

            this.Enabled = GlobalParams.GStages[FStageID].VacancyFlag;
            TableLayoutPanelDevices.BackColor = Colors[(int)GlobalParams.GStages[FStageID].StageState];
            if (GlobalParams.GStages[FStageID].VacancyFlag)
            {
                switch (SelectType)
                {
                    case SelectType.设备状态:
                        labelStr1.Text = GlobalFunction.GetValue(GlobalParams.GStages[FStageID].StageState);
                        labelStr2.Text = GlobalParams.GStages[FStageID].ManualAutoFlag ? ResourceLang.ProgramAuto : ResourceLang.ProgramManual;
                        labelStr3.Text = GlobalParams.GStages[FStageID].EnvData.MechanicalTempValue.Max() + "℃";
                        labelStr4.Text = GlobalParams.GStages[FStageID].EnvData.BatteryAvgTempValue + "℃";
                        break;
                    case SelectType.流程状态:
                        labelStr1.Text = GlobalFunction.GetValue(GlobalParams.GStages[FStageID].ProcessFlag);
                        labelStr2.Text = GlobalParams.GStages[FStageID].RealTimeData.StepNo + "-" + GlobalParams.GStages[FStageID].RealTimeData.StepMode.ToString();
                        labelStr3.Text = TStructConvert.IntToTime((int)(GlobalParams.GStages[FStageID].RealTimeData.ProcessTime * 1000));
                        labelStr4.Text = TStructConvert.IntToTime((int)(GlobalParams.GStages[FStageID].RealTimeData.StepWorkTime * 1000));
                        break;
                    case SelectType.托盘信息:
                        labelStr1.Text = GlobalParams.GStages[FStageID].TrayInfo.MDL_NAME;
                        labelStr2.Text = GlobalParams.GStages[FStageID].TrayInfo.TRAY_NO;
                        labelStr3.Text = GlobalParams.GStages[FStageID].TrayInfo.STARTIME.ToString("HH:mm:ss");
                        labelStr4.Text = GlobalParams.GStages[FStageID].ProcessGroup.ProcessName;
                        break;
                    case SelectType.MCU信息:
                        labelStr1.Text = GlobalParams.GStages[FStageID].IP;
                        labelStr2.Text = GlobalParams.GStages[FStageID].EnvData.SoftVersion.ToString();
                        labelStr3.Text = GlobalFunction.GetValue(GlobalParams.GStages[FStageID].EnvData.MechanicalWorkSate);
                        labelStr4.Text = GlobalFunction.GetValue(GlobalParams.GStages[FStageID].EnvData.PowerFailFlag);
                        break;
                        //labelStr1.Text = GlobalFunction.GetValue(GlobalParams.GStages[FStageID].EnvData.McuWorkState);
                        //labelStr2.Text = GlobalParams.GStages[FStageID].EnvData.MucLog + GlobalParams.GStages[FStageID].EnvData.MucLogGrade;
                        //break;
                }
            }
        }

        private void This_Click(object sender, EventArgs e)
        {
            if (this.UCClick != null)
            {
                UCClick(this, e);
                IsSelected(true);
            }
        }

        private void This_DoubleClick(object sender, EventArgs e)
        {
            if (this.UCDoubleClick != null)
                UCDoubleClick(this, e);
        }

        private void This_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.UCMouseDown != null)
            {
                UCMouseDown(this, e);
                IsSelected(true);
            }
        }

        /// <summary>
        /// 控件点击事件
        /// </summary>
        [Description("按钮点击事件"), Category("自定义")]
        public event EventHandler? UCClick;

        /// <summary>
        /// 控件双击事件
        /// </summary>
        [Description("按钮点击事件"), Category("自定义")]
        public event EventHandler? UCDoubleClick;

        /// <summary>
        /// 控件鼠标点击事件
        /// </summary>
        [Description("按钮点击事件"), Category("自定义")]
        public event MouseEventHandler? UCMouseDown;
    }

    public enum SelectType
    {
        设备状态,
        流程状态,
        托盘信息,
        MCU信息,
    }
}
