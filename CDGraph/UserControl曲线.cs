using CDClassLibrary.Stage;
using CDGraph.Class;
using CDGraph.Language;
using ScottPlot;
using ScottPlot.Plottable;
using ScottPlot.Styles;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CDGraph
{
    public partial class UserControl曲线 : UserControl
    {
        public void Language()
        {
            //button_selectAll.Text = ResourceLang.UserControl曲线button_selectAllText;
            //comboBox_PlotStyle.Items[0] = ResourceLang.UserControl曲线comboBox_PlotStyleItems;
            //comboBox_PlotStyle.Items[1] = ResourceLang.UserControl曲线comboBox_PlotStyleItems1;
            //comboBox_PlotStyle.Items[10] = ResourceLang.UserControl曲线comboBox_PlotStyleItems10;
            //comboBox_PlotStyle.Items[11] = ResourceLang.UserControl曲线comboBox_PlotStyleItems11;
            //comboBox_PlotStyle.Items[12] = ResourceLang.UserControl曲线comboBox_PlotStyleItems12;
            //comboBox_PlotStyle.Items[13] = ResourceLang.UserControl曲线comboBox_PlotStyleItems13;
            //comboBox_PlotStyle.Items[14] = ResourceLang.UserControl曲线comboBox_PlotStyleItems14;
            //comboBox_PlotStyle.Items[2] = ResourceLang.UserControl曲线comboBox_PlotStyleItems2;
            //comboBox_PlotStyle.Items[3] = ResourceLang.UserControl曲线comboBox_PlotStyleItems3;
            //comboBox_PlotStyle.Items[4] = ResourceLang.UserControl曲线comboBox_PlotStyleItems4;
            //comboBox_PlotStyle.Items[5] = ResourceLang.UserControl曲线comboBox_PlotStyleItems5;
            //comboBox_PlotStyle.Items[6] = ResourceLang.UserControl曲线comboBox_PlotStyleItems6;
            //comboBox_PlotStyle.Items[7] = ResourceLang.UserControl曲线comboBox_PlotStyleItems7;
            //comboBox_PlotStyle.Items[8] = ResourceLang.UserControl曲线comboBox_PlotStyleItems8;
            //comboBox_PlotStyle.Items[9] = ResourceLang.UserControl曲线comboBox_PlotStyleItems9;
            //label1.Text = ResourceLang.UserControl曲线label1Text;
            //label10.Text = ResourceLang.UserControl曲线label10Text;
            //label2.Text = ResourceLang.UserControl曲线label2Text;
            //label3.Text = ResourceLang.UserControl曲线label3Text;
            //label_StepWorkTime.Text = ResourceLang.UserControl曲线label5Text;
            //label6.Text = ResourceLang.UserControl曲线label6Text;
            //label7.Text = ResourceLang.UserControl曲线label7Text;
            //保存图片ToolStripMenuItem.Text = ResourceLang.UserControl曲线保存图片ToolStripMenuItemText;
            //居中显示ToolStripMenuItem.Text = ResourceLang.UserControl曲线居中显示ToolStripMenuItemText;
            //缩放显示ToolStripMenuItem.Text = ResourceLang.UserControl曲线缩放显示ToolStripMenuItemText;
        }

        RealTimeDatajx cellData = new(Array.Empty<string>(), 0);
        byte[] ChnState = new byte[GlobalDefine.CHANNELS];
        bool[] ChaSelect = new bool[GlobalDefine.CHANNELS];
        List<(Label name, Label Value)> LabelSomeDateS = new();

        List<FormsPlot> FormsPlot = new();
        List<Plot> Plot = new();
        List<SignalPlotXYConst<double, double>[]> plotData = new();
        List<ScatterPlotList<double>> PlotCrosshair = new();
        List<Crosshair> Crosshair = new();
        List<CheckBox> ItemCheckBox = new();

        readonly IStyle[] PlotStyle = new IStyle[]
        {
            ScottPlot.Style.Black,ScottPlot.Style.Blue1,ScottPlot.Style.Blue2,ScottPlot.Style.Blue3,ScottPlot.Style.Burgundy,ScottPlot.Style.Control,ScottPlot.Style.Default,ScottPlot.Style.Gray1,
            ScottPlot.Style.Gray2,ScottPlot.Style.Hazel,ScottPlot.Style.Light1,ScottPlot.Style.Light2,ScottPlot.Style.Monospace,ScottPlot.Style.Pink,ScottPlot.Style.Seaborn
        };
        readonly Color[] colors = new Color[] {
          //1                           1                           1                           1                           1                           1                           1                           1
            Color.AliceBlue,            Color.AntiqueWhite,         Color.Aqua,                 Color.Aquamarine,           Color.Azure,                Color.Beige,                Color.Bisque,               Color.BlanchedAlmond,
            Color.Blue,                 Color.BlueViolet,           Color.Brown,                Color.BurlyWood,            Color.CadetBlue,            Color.Chartreuse,           Color.Chocolate,            Color.Coral,
            Color.CornflowerBlue,       Color.Cornsilk,             Color.Crimson,              Color.Cyan,                 Color.DarkBlue,             Color.DarkCyan,             Color.DarkGoldenrod,        Color.DarkGray,
            Color.DarkGreen,            Color.DarkKhaki,            Color.DarkMagenta,          Color.DarkOliveGreen,       Color.DarkOrange,           Color.DarkOrchid,           Color.DarkRed,              Color.DarkSalmon,
            Color.DarkSeaGreen,         Color.DarkSlateBlue,        Color.DarkSlateGray,        Color.DarkTurquoise,        Color.DarkViolet,           Color.DeepPink,             Color.DeepSkyBlue,          Color.DimGray,
            Color.DodgerBlue,           Color.Firebrick,            Color.FloralWhite,          Color.ForestGreen,          Color.Fuchsia,              Color.Gainsboro,            Color.GhostWhite,           Color.Gold,
            Color.Goldenrod,            Color.Gray,                 Color.Green,                Color.GreenYellow,          Color.Honeydew,             Color.HotPink,              Color.IndianRed,            Color.Indigo,
            Color.Ivory,                Color.Khaki,                Color.Lavender,             Color.LavenderBlush,        Color.LawnGreen,            Color.LemonChiffon,         Color.LightBlue,            Color.LightCoral,
            Color.LightCyan,            Color.LightGoldenrodYellow, Color.LightGreen,           Color.LightGray,            Color.LightPink,            Color.LightSalmon,          Color.LightSeaGreen,        Color.LightSkyBlue,
            Color.LightSlateGray,       Color.LightSteelBlue,       Color.LightYellow,          Color.Lime,                 Color.LimeGreen,            Color.Linen,                Color.Magenta,              Color.Maroon,
            Color.MediumAquamarine,     Color.MediumBlue,           Color.MediumOrchid,         Color.MediumPurple,         Color.MediumSeaGreen,       Color.MediumSlateBlue,      Color.MediumSpringGreen,    Color.MediumTurquoise,
            Color.MediumVioletRed,      Color.MidnightBlue,         Color.MintCream,            Color.MistyRose,            Color.Moccasin,             Color.NavajoWhite,          Color.Navy,                 Color.OldLace,
            Color.Olive,                Color.OliveDrab,            Color.Orange,               Color.OrangeRed,            Color.Orchid,               Color.PaleGoldenrod,        Color.PaleGreen,            Color.PaleTurquoise,
            Color.PaleVioletRed,        Color.PapayaWhip,           Color.PeachPuff,            Color.Peru,                 Color.Pink,                 Color.Plum,                 Color.PowderBlue,           Color.Purple,
            Color.Red,                  Color.RosyBrown,            Color.RoyalBlue,            Color.SaddleBrown,          Color.Salmon,               Color.SandyBrown,           Color.SeaGreen,             Color.SeaShell,
            Color.Sienna,               Color.Silver,               Color.SkyBlue,              Color.SlateBlue,            Color.SlateGray,            Color.Snow,                 Color.SpringGreen,          Color.SteelBlue,
            Color.Tan,                  Color.Teal,                 Color.Thistle,              Color.Tomato,               Color.Turquoise,            Color.Violet,               Color.Wheat,                Color.White,
            Color.WhiteSmoke,           Color.Yellow,               Color.YellowGreen,          Color.FromArgb(15,255,235), Color.FromArgb(147,20,232), Color.FromArgb(10,10,240),  Color.FromArgb(20,248,216), Color.FromArgb(20,255,225),
            Color.FromArgb(158,63,246), Color.FromArgb(185,62,62),  Color.FromArgb(242,204,155),Color.FromArgb(115,178,180),Color.FromArgb(10,242,199),  Color.FromArgb(230,125,50), Color.FromArgb(20,147,100), Color.FromArgb(120,169,2),
            Color.FromArgb(20,13,240),  Color.FromArgb(240,40,80),  Color.FromArgb(20,20,159),  Color.FromArgb(20,159,159), Color.FromArgb(204,154,31), Color.FromArgb(189,189,189),Color.FromArgb(20,120,20),  Color.FromArgb(209,203,127),
            Color.FromArgb(159,20,159), Color.FromArgb(105,127,67), Color.FromArgb(20,160,20),  Color.FromArgb(173,70,224), Color.FromArgb(159,20,20),  Color.FromArgb(253,170,142),Color.FromArgb(163,208,159),Color.FromArgb(92,81,159),
            Color.FromArgb(67,99,99),   Color.FromArgb(20,226,229), Color.FromArgb(168,20,231), Color.FromArgb(20,40,167),  Color.FromArgb(20,211,20),  Color.FromArgb(125,125,125),Color.FromArgb(50,164,20),  Color.FromArgb(198,54,54),
            Color.FromArgb(54,159,54),  Color.FromArgb(240,240,240),Color.FromArgb(20,235,20),  Color.FromArgb(238,185,52), Color.FromArgb(148,148,148),Color.FromArgb(20,148,20),  Color.FromArgb(193,20,67),  Color.FromArgb(20,125,200),
            Color.FromArgb(225,112,112),Color.FromArgb(95,20,150),  Color.FromArgb(5,250,160),  Color.FromArgb(250,250,15), Color.FromArgb(174,225,70),  Color.FromArgb(20,15,225),  Color.FromArgb(193,236,250),Color.FromArgb(5,148,148),
            Color.FromArgb(244,20,20),  Color.FromArgb(15,15,230),  Color.FromArgb(164,3,164),  Color.FromArgb(231,231,231),Color.FromArgb(20,202,213), Color.FromArgb(20,180,142), Color.FromArgb(52,198,190), Color.FromArgb(155,226,15),
            Color.FromArgb(139,156,173),Color.FromArgb(196,216,242),Color.FromArgb(20,20,244),  Color.FromArgb(70,225,70),  Color.FromArgb(15,5,250),   Color.FromArgb(148,20,20),  Color.FromArgb(122,225,190),Color.FromArgb(20,20,225),
            Color.FromArgb(206,105,231),Color.FromArgb(167,132,239),Color.FromArgb(80,199,133), Color.FromArgb(143,124,3),  Color.FromArgb(20,15,174),  Color.FromArgb(92,229,224), Color.FromArgb(219,41,153), Color.FromArgb(45,45,132),
            Color.FromArgb(20,248,245), Color.FromArgb(20,248,201), Color.FromArgb(20,242,193), Color.FromArgb(20,20,148),  Color.FromArgb(18,10,250),  Color.FromArgb(148,148,20), Color.FromArgb(127,162,55), Color.FromArgb(20,185,20),
            Color.FromArgb(20,89,20),   Color.FromArgb(238,132,234),Color.FromArgb(3,252,190),  Color.FromArgb(172,16,172), Color.FromArgb(195,3,3),    Color.FromArgb(239,132,167),Color.FromArgb(20,4,233),   Color.FromArgb(20,238,205),
            Color.FromArgb(225,153,83), Color.FromArgb(20,212,223), Color.FromArgb(241,180,241),Color.FromArgb(196,244,250),Color.FromArgb(148,20,148), Color.FromArgb(208,163,163),Color.FromArgb(85,125,245), Color.FromArgb(159,89,39),
            Color.FromArgb(15,148,134), Color.FromArgb(9,184,116),  Color.FromArgb(66,159,107), Color.FromArgb(180,102,65), Color.FromArgb(212,212,212),Color.FromArgb(155,226,255),Color.FromArgb(126,110,225),Color.FromArgb(132,148,164),
            Color.FromArgb(20,20,147),  Color.FromArgb(90,150,200), Color.FromArgb(230,200,160),Color.FromArgb(20,148,148), Color.FromArgb(236,211,236),Color.FromArgb(20,119,91),  Color.FromArgb(84,244,228), Color.FromArgb(3,150,3)
        };

        public UserControl曲线()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
            comboBox_PlotStyle.SelectedIndex = 0;

            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnCount = 0;

            NewFormsPlot("电压(mV)", 0);
            NewFormsPlot("电流(mA)", 1);
            NewFormsPlot("容量(mAh)", 2);
            NewFormsPlot("电池温度(℃)", 3);

            FormsPlotMax(0);

            PlotRender(RenderType.HighQualityDelayed, true);
            Language();
        }

        private void NewFormsPlot(string Title, int ID)
        {
            FormsPlot formsPlot = new()
            {
                Tag = ID,
                Name = Title,
                Dock = DockStyle.Left,
                Size = new Size(500, 260),
                Visible = ID < 4
            };

            formsPlot.Plot.Title(Title + "/时间(s)");
            formsPlot.Plot.YLabel(Title);
            formsPlot.Plot.XLabel("时间(s)");
            //formsPlot.Plot.YAxis.SetSizeLimit(min: 79, max: 79);
            formsPlot.RightClicked -= formsPlot.DefaultRightClickEvent;
            formsPlot.ContextMenuStrip = contextMenuStrip1;
            formsPlot.Plot.Style(PlotStyle[comboBox_PlotStyle.SelectedIndex]);

            formsPlot.DoubleClick += FormsPlot_DoubleClick;
            formsPlot.MouseEnter += FormsPlot_MouseEnter;
            formsPlot.MouseLeave += FormsPlot_MouseLeave;
            formsPlot.MouseMove += FormsPlot_MouseMove;

            Plot plot = formsPlot.Plot;
            Plot.Add(plot);
            Crosshair crosshair = formsPlot.Plot.AddCrosshair(0, 0);
            crosshair.IsVisible = false;
            Crosshair.Add(crosshair);

            CheckBox checkBox = new()
            {
                AutoSize = true,
                Text = Title,
                Tag = ID,
                Checked = ID < 4,
            };
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            ItemCheckBox.Add(checkBox);
            flowLayoutPanel1.Controls.Add(checkBox);

            tableLayoutPanel1.ColumnCount++;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanel1.Controls.Add(formsPlot, tableLayoutPanel1.ColumnCount - 1, 0);

            //LabelSomeDate
            Label label = new()
            {
                AutoSize = false,
                Text = Title + ":",
                Size = new Size(100, 20),
                Anchor = AnchorStyles.Left,
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
            };
            Label LabelSomeDate = new()
            {
                AutoSize = false,
                Text = "0",
                Size = new Size(100, 20),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top,
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
            };
            LabelSomeDateS.Add((label, LabelSomeDate));
            tableLayoutPanel2.ColumnCount++;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanel2.Controls.Add(label, tableLayoutPanel2.ColumnCount - 1, 0);
            tableLayoutPanel2.Controls.Add(LabelSomeDate, tableLayoutPanel2.ColumnCount - 1, 1);

            formsPlot.Configuration.Zoom = false;

            FormsPlot.Add(formsPlot);
        }

        private void SelectChange(bool[] ChaSelect)
        {
            this.ChaSelect = ChaSelect;
        }

        public void Datashow(RealTimeDatajx cellData, byte[] ChnState)
        {
            this.Enabled = false;
            panel_H.Enabled = false;

            tableLayoutPanel1.Enabled = false;

            this.cellData = cellData;
            this.ChnState = ChnState;

            for (int ChnNo = GlobalDefine.CHANNELS - 1; ChnNo >= 0; ChnNo--)
            {
                this.ChaSelect[ChnNo] = ChnState[ChnNo] != 0x60;
                No = ChnState[ChnNo] == 0x00 ? ChnNo : No;
            }

            new FrmSelectChn(SelectChange, ChaSelect, ChnState).ShowDialog();

            FormsPlot.Clear();
            Plot.Clear();
            PlotCrosshair.Clear();
            Crosshair.Clear();
            plotData.Clear();
            flowLayoutPanel1.Controls.Clear();
            ItemCheckBox.Clear();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnCount = 0;

            tableLayoutPanel_视图平铺.Controls.Clear();
            tableLayoutPanel_视图平铺.ColumnStyles.Clear();
            tableLayoutPanel_视图平铺.ColumnCount = 0;
            tableLayoutPanel_视图平铺.RowStyles.Clear();
            tableLayoutPanel_视图平铺.RowCount = 0;

            tableLayoutPanel_PlotFill.ColumnStyles[1].Width = 0F;

            foreach (var (name, Value) in LabelSomeDateS)
            {
                tableLayoutPanel2.ColumnCount--;
                tableLayoutPanel2.ColumnStyles.RemoveAt(tableLayoutPanel2.ColumnStyles.Count - 1);
                tableLayoutPanel2.Controls.Remove(name);
                tableLayoutPanel2.Controls.Remove(Value);
            }
            LabelSomeDateS.Clear();

            for (int i = 0; i < cellData.RealTimeDataitemName.Count; i++)
            {
                NewFormsPlot(cellData.RealTimeDataitemName[i], i);
            }
            NewFormsPlot("环境温度", FormsPlot.Count);

            Task task = new(new Action(() =>
            {
                for (int i = 0; i < cellData.RealTimeDataitemName.Count; i++)
                {
                    SignalPlotXYConst<double, double>[] signalPlotXYConsts = new SignalPlotXYConst<double, double>[GlobalDefine.CHANNELS];
                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    {
                        if (cellData.DataID.Length == 0)
                            return;
                        signalPlotXYConsts[ChnNo] = Plot[i].AddSignalXYConst(cellData.ProcessTime, cellData.RealTimeDataitem[i][ChnNo], color: colors[ChnNo]);
                        signalPlotXYConsts[ChnNo].LineWidth = 2;
                        signalPlotXYConsts[ChnNo].MarkerColor = colors[ChnNo];
                        signalPlotXYConsts[ChnNo].MarkerSize = 0;
                        signalPlotXYConsts[ChnNo].IsVisible = ChaSelect[ChnNo];
                    }
                    plotData.Add(signalPlotXYConsts);

                    ScatterPlotList<double> plotCrosshair = FormsPlot[i].Plot.AddScatterList(color: Color.Yellow, lineWidth: 4);
                    PlotCrosshair.Add(plotCrosshair);
                }
                {
                    SignalPlotXYConst<double, double>[] signalPlotXYConsts = new SignalPlotXYConst<double, double>[cellData.EnvDataTemp.Count];
                    for (int Index = 0; Index < cellData.EnvDataTemp.Count; Index++)
                    {
                        if (cellData.DataID.Length == 0)
                            return;
                        signalPlotXYConsts[Index] = Plot.Last().AddSignalXYConst(cellData.ProcessTime, cellData.EnvDataTemp[Index], color: colors[Index]);
                        signalPlotXYConsts[Index].LineWidth = 2;
                        signalPlotXYConsts[Index].MarkerColor = colors[Index];
                        signalPlotXYConsts[Index].MarkerSize = 0;
                        signalPlotXYConsts[Index].IsVisible = ChaSelect[Index];
                    }
                    plotData.Add(signalPlotXYConsts);

                    ScatterPlotList<double> plotCrosshair = FormsPlot.Last().Plot.AddScatterList(color: Color.Yellow, lineWidth: 4);
                    PlotCrosshair.Add(plotCrosshair);
                }
            }));
            task.Start();
            task.Wait();

            tableLayoutPanel_PlotFill.Controls.Clear();

            if (button1.Tag.ToString() == "视图平铺")
            {
                button1.Tag = "视图对比";
                PlotMaxMin();
            }
            else
            {
                FormsPlotMax(0);
            }

            Thread.Sleep(1000);
            for (int i = 0; i < FormsPlot.Count; i++)
            {
                FormsPlot[i].Plot.AxisAuto();
            }

            PlotRender(RenderType.HighQualityDelayed, true);


            panel_H.Enabled = true;
            tableLayoutPanel1.Enabled = true;

            this.Enabled = true;
        }

        private void Button_selectAll_Click(object sender, EventArgs e)
        {
            new FrmSelectChn(DrawChange, ChaSelect, ChnState).ShowDialog();
        }

        void DrawChange(bool[] ChaSelect)
        {
            this.ChaSelect = ChaSelect;

            DrawGraph();
            Thread.Sleep(500);

            PlotRender(RenderType.LowQualityThenHighQualityDelayed, true);
        }

        private void DrawGraph()
        {
            if (plotData == null)
                return;

            for (int i = 0; i < FormsPlot.Count; i++)
            {
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    plotData[i][ChnNo].IsVisible = ItemCheckBox[i].Checked && ChaSelect[ChnNo];
                }
            }

            //FormsPlot1.Plot.AxisAuto(); 
        }

        private void PlotRender(RenderType renderType, bool Refresh = false)
        {
            for (int i = 0; i < FormsPlot.Count; i++)
            {
                if (ItemCheckBox[i].Checked || Refresh)
                {
                    FormsPlot[i].RefreshRequest(renderType);
                }
            }
        }

        private void FormsPlot_DoubleClick(object sender, EventArgs e)
        {
            FormsPlot formsPlot = (FormsPlot)sender;
            (double mouseCoordX, double mouseCoordY) = formsPlot.GetMouseCoordinates();
            List<(int Pos, (double pointX, double pointY, int pointIndex) point)> PlotPoint = new();
            List<double> doubles = new();
            int ItemIndex = cellData.RealTimeDataitemName.IndexOf(formsPlot.Name.ToString()!);
            if (ItemIndex != -1 && ItemIndex != plotData.Count - 1)
            {
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    if (ChaSelect[ChnNo])
                    {
                        PlotPoint.Add((ChnNo, plotData[ItemIndex][ChnNo].GetPointNearestX(mouseCoordX)));
                        doubles.Add(Math.Abs(PlotPoint[^1].point.pointY - mouseCoordY));
                    }
                }
                if (doubles.Count > 0)
                {
                    int Min = doubles.IndexOf(doubles.Min());
                    No = PlotPoint[Min].Pos;
                    for (int i = 0; i < FormsPlot.Count - 1; i++)
                    {
                        PlotCrosshair[i].Clear();
                        for (int no = 0; no < cellData.DataID.Length; no++)
                        {
                            PlotCrosshair[i].Add(plotData[i][No].Xs[no], plotData[i][No].Ys[no]);
                        }
                    }
                    PlotRender(RenderType.HighQualityDelayed, true);
                }
            }
        }

        private void FormsPlot_MouseEnter(object sender, EventArgs e)
        {
            FormsPlot formsPlot = (FormsPlot)sender;
            tableLayoutPanel1.Tag = formsPlot.Tag;
            if ((int)panel_视图对比.Tag == (int)formsPlot.Tag)
            {
                对比视图ToolStripMenuItem.Text = "取消对比";
                对比视图ToolStripMenuItem.Enabled = true;
            }
            else if ((int)tableLayoutPanel_PlotFill.Tag == (int)formsPlot.Tag)
            {
                对比视图ToolStripMenuItem.Text = "对比视图";
                对比视图ToolStripMenuItem.Enabled = false;
            }
            else
            {
                对比视图ToolStripMenuItem.Text = "对比视图";
                对比视图ToolStripMenuItem.Enabled = true;
            }
            for (int i = 0; i < FormsPlot.Count; i++)
            {
                Crosshair[i].IsVisible = checkBox_Crosshair.Checked;
            }
        }

        private void FormsPlot_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < FormsPlot.Count; i++)
            {
                Crosshair[i].IsVisible = false;
            }
        }

        private void FormsPlot_MouseMove(object sender, MouseEventArgs e)
        {
            FormsPlot formsPlot = (FormsPlot)sender;
            (double mouseCoordX, _) = formsPlot.GetMouseCoordinates();
            PlotPointChanged(mouseCoordX);
        }

        private void PlotPointChanged(double mouseCoordX)
        {
            if (plotData.Count > 0)
            {
                int index = plotData[0][No].GetPointNearestX(mouseCoordX).index;
                label_Pos1.Text = (No + 1).ToString("000");
                label_ProcessTime.Text = TStructConvert.IntToTime((int)(cellData.ProcessTime[index] * 1000));
                label_StepWorkTime.Text = TStructConvert.IntToTime((int)(cellData.StepWorkTime[index] * 1000));
                label_Step.Text = $"{cellData.StepNo[index]}_{cellData.StepMode[index]}";
                label_ProcessStatus.Text = cellData.ProcessStatus[No][index];
                label_ChnState.Text = cellData.ChnState[No][index];

                for (int i = 0; i < FormsPlot.Count - 1; i++)
                    LabelSomeDateS[i].Value.Text = cellData.RealTimeDataitem[i][No][index].ToString();

                if (checkBox_Crosshair.Checked)
                {
                    for (int i = 0; i < FormsPlot.Count; i++)
                    {
                        if (ItemCheckBox[i].Checked)
                        {
                            CrosshairChanged(i, mouseCoordX, index);
                        }
                    }
                    PlotRender(RenderType.LowQualityThenHighQualityDelayed);
                }
            }
        }

        private void CrosshairChanged(int ItemIndex, double mouseCoordX, int index)
        {
            Crosshair[ItemIndex].X = mouseCoordX;
            if (ItemIndex < FormsPlot.Count - 1)
            {
                Crosshair[ItemIndex].Y = cellData.RealTimeDataitem[ItemIndex][No][index];
                string HFormatter(double HF) => cellData.RealTimeDataitem[ItemIndex][No][index].ToString();
                Crosshair[ItemIndex].HorizontalLine.PositionFormatter = HFormatter;
            }
            else
            {
                Crosshair[ItemIndex].Y = cellData.EnvDataTemp[Math.Min(No, cellData.EnvDataTemp.Count - 1)][index];
                string HFormatter(double HF) => cellData.EnvDataTemp[Math.Min(No, cellData.EnvDataTemp.Count - 1)][index].ToString();

                Crosshair[ItemIndex].HorizontalLine.PositionFormatter = HFormatter;
            }

            string VFormatter(double VF) => TStructConvert.IntToTime((int)(cellData.ProcessTime[index] * 1000));
            Crosshair[ItemIndex].VerticalLine.PositionFormatter = VFormatter;
        }

        private void ComboBox_PlotStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < FormsPlot.Count; i++)
            {
                FormsPlot[i].Plot.Style(PlotStyle[comboBox_PlotStyle.SelectedIndex]);
            }
            PlotRender(RenderType.HighQualityDelayed, true);
        }

        int No = 0;

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int Index = (int)checkBox.Tag;

            Crosshair[Index].IsVisible = checkBox.Checked;
            if (plotData.Count > 0)
            {
                if (Index < plotData.Count - 1)
                {
                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    {
                        plotData[Index][ChnNo].IsVisible = ChaSelect[ChnNo] && checkBox.Checked;
                    }
                }
                else
                {
                    for (int ChnNo = 0; ChnNo < plotData[Index].Length; ChnNo++)
                    {
                        plotData[Index][ChnNo].IsVisible = true;
                    }
                }
            }
            FormsPlot[Index].Visible = checkBox.Checked;
            if (button1.Tag.ToString() == "视图平铺")
            {
                button1.Tag = "视图对比";
                PlotMaxMin();
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Crosshair.Checked)
            {
                for (int i = 0; i < FormsPlot.Count; i++)
                {
                    Crosshair[i].IsVisible = false;
                }
                PlotRender(RenderType.HighQualityDelayed, true);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            PlotMaxMin();
            this.Enabled = true;
        }

        private void 居中显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FormsPlot.Count; i++)
            {
                if (ItemCheckBox[i].Checked)
                {
                    FormsPlot[i].Plot.AxisAuto();
                }
            }
            PlotRender(RenderType.LowQualityThenHighQualityDelayed, true);
        }

        private void 缩放显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Tag.ToString() == "视图平铺")
                PlotMaxMin();
            FormsPlotMax((int)tableLayoutPanel1.Tag);
        }

        private void 对比视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Tag.ToString() == "视图平铺")
                PlotMaxMin();
            if (对比视图ToolStripMenuItem.Text == "对比视图")
            {
                FormsPlotContrast((int)tableLayoutPanel1.Tag);
            }
            else
            {
                FormsPlot[(int)panel_视图对比.Tag].Dock = DockStyle.Left;
                FormsPlot[(int)panel_视图对比.Tag].Parent = tableLayoutPanel1;
                tableLayoutPanel1.Controls.Add(FormsPlot[(int)panel_视图对比.Tag], (int)panel_视图对比.Tag, 0);
                FormsPlot[(int)panel_视图对比.Tag].Configuration.Zoom = false;

                panel_视图对比.Tag = -1;
                tableLayoutPanel_PlotFill.ColumnStyles[1].Width = 0F;
            }
        }

        private void 保存图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                FileName = cellData.RealTimeDataitemName[(int)tableLayoutPanel1.Tag] + "-时间.png",

                Filter = "PNG Files (*.png)|*.png;*.png|JPG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|BMP Files (*.bmp)|*.bmp;*.bmp|All files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FormsPlot[(int)tableLayoutPanel_PlotFill.Tag].Plot.SaveFig(saveFileDialog.FileName);
            }
        }

        private void FormsPlotMax(int Index)
        {
            if (FormsPlot[Index].Parent == tableLayoutPanel1)
            {
                if ((int)tableLayoutPanel_PlotFill.Tag > -1)
                {
                    FormsPlot[(int)tableLayoutPanel_PlotFill.Tag].Dock = DockStyle.Left;
                    FormsPlot[(int)tableLayoutPanel_PlotFill.Tag].Parent = tableLayoutPanel1;
                    tableLayoutPanel1.Controls.Add(FormsPlot[(int)tableLayoutPanel_PlotFill.Tag], (int)tableLayoutPanel_PlotFill.Tag, 0);
                    FormsPlot[(int)tableLayoutPanel_PlotFill.Tag].Configuration.Zoom = false;
                }
                FormsPlot[Index].Configuration.Zoom = true;
                tableLayoutPanel_PlotFill.Controls.Add(FormsPlot[Index], 0, 0);
                tableLayoutPanel_PlotFill.Tag = Index;
                FormsPlot[Index].Dock = DockStyle.Fill;
            }
        }

        private void PlotMaxMin()
        {
            if (button1.Tag.ToString() == "视图对比")
            {
                panel_视图平铺.BringToFront();
                tableLayoutPanel_数据项.Parent = panel_视图平铺;

                #region 计算行列
                int count = 0;
                foreach (var item in ItemCheckBox)
                {
                    if (item.Checked)
                    {
                        count++;
                    }
                }

                double Sqrtcount = Math.Sqrt(count);
                int ColumnCount;
                int RowCount;

                if (Sqrtcount > (int)Sqrtcount)
                {
                    if (Sqrtcount > (int)Sqrtcount + 0.5)
                    {
                        RowCount = (int)Sqrtcount + 1;
                        ColumnCount = (int)Sqrtcount + 1;
                    }
                    else
                    {
                        RowCount = (int)Sqrtcount;
                        ColumnCount = (int)Sqrtcount + 1;
                    }
                }
                else
                {
                    RowCount = (int)Sqrtcount;
                    ColumnCount = (int)Sqrtcount;
                }
                #endregion

                tableLayoutPanel_视图平铺.ColumnStyles.Clear();
                tableLayoutPanel_视图平铺.ColumnCount = ColumnCount;
                for (int i = 0; i < ColumnCount; i++)
                    tableLayoutPanel_视图平铺.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

                tableLayoutPanel_视图平铺.RowStyles.Clear();
                tableLayoutPanel_视图平铺.RowCount = RowCount;
                for (int i = 0; i < RowCount; i++)
                    tableLayoutPanel_视图平铺.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

                int RealIndex = 0;
                for (int Index = 0; Index < ItemCheckBox.Count; Index++)
                {
                    if (ItemCheckBox[Index].Checked)
                    {
                        FormsPlot[Index].Dock = DockStyle.Fill;
                        FormsPlot[Index].Configuration.Zoom = true;
                        tableLayoutPanel_视图平铺.Controls.Add(FormsPlot[Index], RealIndex % ColumnCount, RealIndex / ColumnCount);
                        RealIndex++;
                    }
                }
                button1.Tag = "视图平铺";
            }
            else
            {
                panel_视图对比.BringToFront();
                tableLayoutPanel_数据项.Parent = panel1;
                for (int Index = 0; Index < ItemCheckBox.Count; Index++)
                {
                    FormsPlot[Index].Dock = DockStyle.Left;
                    tableLayoutPanel1.Controls.Add(FormsPlot[Index], Index, 0);
                    FormsPlot[Index].Configuration.Zoom = false;
                    if (Index == (int)tableLayoutPanel_PlotFill.Tag)
                    {
                        FormsPlotMax(Index);
                    }
                    if (Index == (int)panel_视图对比.Tag)
                    {
                        FormsPlotContrast(Index);
                    }
                }
                button1.Tag = "视图对比";
            }
        }

        private void FormsPlotContrast(int Index)
        {
            if (FormsPlot[Index].Parent == tableLayoutPanel1)
            {
                if ((int)panel_视图对比.Tag > -1)
                {
                    FormsPlot[(int)panel_视图对比.Tag].Dock = DockStyle.Left;
                    FormsPlot[(int)panel_视图对比.Tag].Parent = tableLayoutPanel1;
                    tableLayoutPanel1.Controls.Add(FormsPlot[(int)panel_视图对比.Tag], (int)panel_视图对比.Tag, 0);
                    FormsPlot[(int)panel_视图对比.Tag].Configuration.Zoom = false;
                }
                FormsPlot[Index].Configuration.Zoom = true;
                tableLayoutPanel_PlotFill.Controls.Add(FormsPlot[Index], 1, 0);
                panel_视图对比.Tag = Index;
                tableLayoutPanel_PlotFill.ColumnStyles[1].Width = 100F;
                FormsPlot[Index].Dock = DockStyle.Fill;
            }
        }
    }
}