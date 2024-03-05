using CDGraph.Class;
using CDGraph.Language;
using CDClassLibrary.Stage;

namespace CDGraph
{
    public partial class UserControl结果数据 : UserControl
    {
        public void Language()
        {
            label1.Text = ResourceLang.UserControl结果数据label1Text;
            label2.Text = ResourceLang.UserControl结果数据label2Text;
            label3.Text = ResourceLang.UserControl结果数据label3Text;
            label4.Text = ResourceLang.UserControl结果数据label4Text; 
            label6.Text = ResourceLang.UserControl结果数据label6Text;
            label7.Text = ResourceLang.UserControl结果数据label7Text;
            uiButton1.Text = ResourceLang.UserControl结果数据uiButton1Text;
            uiButton10.Text = ResourceLang.UserControl结果数据uiButton10Text;
            uiButton11.Text = ResourceLang.UserControl结果数据uiButton11Text;
            uiButton12.Text = ResourceLang.UserControl结果数据uiButton12Text;
            uiButton13.Text = ResourceLang.UserControl结果数据uiButton13Text;
            uiButton14.Text = ResourceLang.UserControl结果数据uiButton14Text;
            uiButton15.Text = ResourceLang.UserControl结果数据uiButton15Text;
            uiButton16.Text = ResourceLang.UserControl结果数据uiButton16Text;
            uiButton17.Text = ResourceLang.UserControl结果数据uiButton17Text;
            uiButton19.Text = ResourceLang.UserControl结果数据uiButton19Text;
            uiButton2.Text = ResourceLang.UserControl结果数据uiButton2Text;
            uiButton3.Text = ResourceLang.UserControl结果数据uiButton3Text;
            uiButton4.Text = ResourceLang.UserControl结果数据uiButton4Text;
            uiButton5.Text = ResourceLang.UserControl结果数据uiButton5Text;
            uiButton6.Text = ResourceLang.UserControl结果数据uiButton6Text;
            uiButton7.Text = ResourceLang.UserControl结果数据uiButton7Text;
            uiButton8.Text = ResourceLang.UserControl结果数据uiButton8Text;
            uiButton9.Text = ResourceLang.UserControl结果数据uiButton9Text;

        }
        List<ResultDatajx> ResultDatajx = new();
        TProcessGroup ProcessGroup = new();
        TTrayInfo TrayInfo = new();

        readonly Label[] Label_Cells = new Label[GlobalDefine.CHANNELS];

        readonly string[] strEmpty = new string[GlobalDefine.CHANNELS];

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public UserControl结果数据()
        {
            InitializeComponent();
            CreateStageView();

            Language();
        }

        private void CreateStageView()
        {
            this.Size = new Size(1600, 900);

            TableLayoutPanelCells.RowStyles.Clear();
            TableLayoutPanelCells.RowCount = GlobalDefine.CHANNELRow + 2;
            TableLayoutPanelCells.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                TableLayoutPanelCells.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                TableLayoutPanelCells.Controls.Add(new Label()
                {
                    Text = $"{(i * GlobalDefine.CHANNELRow + 1):000}-{((i + 1) * GlobalDefine.CHANNELRow):000}",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(3),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.Black,
                    ForeColor = Color.White,
                }, 0, i + 1);
            }
            TableLayoutPanelCells.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            TableLayoutPanelCells.ColumnStyles.Clear();
            TableLayoutPanelCells.ColumnCount = GlobalDefine.CHANNELColumn + 2;
            TableLayoutPanelCells.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            for (int i = 0; i < GlobalDefine.CHANNELColumn; i++)
            {
                TableLayoutPanelCells.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                TableLayoutPanelCells.Controls.Add(new Label()
                {
                    Text = (i + 1).ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(3),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.Black,
                    ForeColor = Color.White,
                }, i + 1, 0);
            }
            TableLayoutPanelCells.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            TableLayoutPanelCells.Controls.Add(new Label()
            {
                Text = "缺角",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Margin = new Padding(3),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Black,
                ForeColor = Color.White,
            }, 0, 0);

            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                {
                    int x = j + i * GlobalDefine.CHANNELColumn;
                    Label_Cells[x] = new Label()
                    {
                        Text = "0",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        BackColor = Color.White,
                        ForeColor = Color.Black,
                        Margin = new Padding(3),
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = (x + 1),
                    };
                    TableLayoutPanelCells.Controls.Add(Label_Cells[x], j + 1, i + 1);
                }
            }

            for (int i = 0; i < strEmpty.Length; i++)
                strEmpty[i] = string.Empty;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Step = ComboBox_Step.SelectedIndex;
            CellStage = button.Tag.ToString()!;
            if (Step > -1)
            {
                ShowCellStage();
            }
            else
            {
                DataShow(strEmpty);
            }
        }

        int Step; string CellStage = "电芯状态";

        private void ShowCellStage()
        {
            switch (CellStage)
            {
                case "起始时间":
                    DataShow(ResultDatajx[Step].Cell起始时间);
                    break;
                case "起始电压":
                    DataShow(ResultDatajx[Step].Cell起始电压);
                    break;
                case "起始电流":
                    DataShow(ResultDatajx[Step].Cell起始电流);
                    break;
                case "起始环境温度":
                    DataShow(ResultDatajx[Step].Cell起始环境温度);
                    break;
                case "起始电池温度":
                    DataShow(ResultDatajx[Step].Cell起始电池温度);
                    break;
                case "起始真空值":
                    DataShow(ResultDatajx[Step].Cell起始真空值);
                    break;
                case "结束时间":
                    DataShow(ResultDatajx[Step].Cell结束时间);
                    break;
                case "结束电压":
                    DataShow(ResultDatajx[Step].Cell结束电压);
                    break;
                case "结束电流":
                    DataShow(ResultDatajx[Step].Cell结束电流);
                    break;
                case "结束环境温度":
                    DataShow(ResultDatajx[Step].Cell结束环境温度);
                    break;
                case "结束电池温度":
                    DataShow(ResultDatajx[Step].Cell结束电池温度);
                    break;
                case "结束真空值":
                    DataShow(ResultDatajx[Step].Cell结束真空值);
                    break;
                case "结束容量":
                    DataShow(ResultDatajx[Step].Cell结束容量);
                    break;
                case "平均环境温度":
                    DataShow(ResultDatajx[Step].Cell平均环境温度);
                    break;
                case "平均电池温度":
                    DataShow(ResultDatajx[Step].Cell平均电池温度);
                    break;
                case "电芯状态":
                    //dataShow<byte>(TrayInfo.ChnState);
                    DataShow(ResultDatajx[Step].Cell状态);
                    break;
                default:
                    DataShow(strEmpty);
                    break;
            }

        }

        void DataShow(string[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Label_Cells[i].Text = t[i];
            }
        }

        public void LangSwitch()
        {

        }

        public void DataShow(TTrayInfo trayInfo, TProcessGroup processGroup, List<ResultDatajx> resultDatajx)
        {
            this.TrayInfo = trayInfo;
            this.ProcessGroup = processGroup;
            this.ResultDatajx = resultDatajx;

            ComboBox_Step.Items.Clear();

            if (TrayInfo != null)
            {
                label_MDL_NAME.Text = TrayInfo.MDL_NAME; 
                label_STARTIME.Text = TrayInfo.STARTIME.ToString();
                label_ENDTIME.Text = TrayInfo.ENDTIME.ToString();
                label_EQUIP_ID.Text = TrayInfo.FStageNo;

                label_ProcessName.Text = TrayInfo.ProcessName;

                for (int i = 0; i < ProcessGroup.Process.StepCount; i++)
                {
                    ComboBox_Step.Items.Add((i + 1) + "_" + ProcessGroup.Process.ProcStepRec[i].StepMode.ToString());
                }
                if (ResultDatajx != null && ResultDatajx.Count > 0)
                {
                    ComboBox_Step.SelectedIndex = 0;
                }

                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    Label_Cells[ChnNo].BackColor = TrayInfo.ChnState[ChnNo] switch
                    {
                        0x60 => Color.White,
                        0x61 => Color.Gainsboro,
                        0x00 => Color.Lime,
                        _ => Color.Red,
                    };
                }
            }
        }

        private void ComboBox_Step_SelectedIndexChanged(object sender, EventArgs e)
        {
            Step = ComboBox_Step.SelectedIndex;
            ShowCellStage();
        }

        private void UiButton19_Click(object sender, EventArgs e)
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                Label_Cells[ChnNo].Text = TrayInfo.ChnState[ChnNo].ToString("X2");
        }

        private void UiButton17_Click(object sender, EventArgs e)
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                Label_Cells[ChnNo].Text = TrayInfo.CellNumber[ChnNo];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Form_NG代码().ShowDialog();
        }
    }
}