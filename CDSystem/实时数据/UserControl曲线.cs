using CDClassLibrary;
using CDClassLibrary.Data;
using CDClassLibrary.Stage;
using CDClassLibrary.Tools;
using CDSystem.Language;
using ScottPlot;
using ScottPlot.Plottable;
using ScottPlot.Styles;
using System;
using System.Data;

namespace CDSystem.实时数据
{
    public partial class UserControl曲线 : UserControl
    {
        public void Language()
        {
            button1.Text = ResourceLang.UserControl曲线button1Text;
            checkBoxZoom.Text = ResourceLang.UserControl曲线checkBoxZoomText;
            label1.Text = ResourceLang.UserControl曲线label1Text;
            label12.Text = ResourceLang.UserControl曲线label12Text;
            label14.Text = ResourceLang.UserControl曲线label14Text;
            label16.Text = ResourceLang.UserControl曲线label16Text;
            label18.Text = ResourceLang.UserControl曲线label18Text;
            label20.Text = ResourceLang.UserControl曲线label20Text;
            label22.Text = ResourceLang.UserControl曲线label22Text;
            label24.Text = ResourceLang.UserControl曲线label24Text;
            label26.Text = ResourceLang.UserControl曲线label26Text;
            label28.Text = ResourceLang.UserControl曲线label28Text;
            label3.Text = ResourceLang.UserControl曲线label3Text;
            label30.Text = ResourceLang.UserControl曲线label30Text;
            label32.Text = ResourceLang.UserControl曲线label32Text;
            label34.Text = ResourceLang.UserControl曲线label34Text;
            label36.Text = ResourceLang.UserControl曲线label36Text;
            label9.Text = ResourceLang.UserControl曲线label9Text;

            FormsPlot1.Plot.Title(ResourceLang.UserControl曲线Voltage + "/" + ResourceLang.UserControl曲线Time);
            FormsPlot2.Plot.Title(ResourceLang.UserControl曲线Current + "/" + ResourceLang.UserControl曲线Time);
            FormsPlot3.Plot.Title(ResourceLang.UserControl曲线Capacity + "/" + ResourceLang.UserControl曲线Time);
            FormsPlot4.Plot.Title(ResourceLang.UserControl曲线BatteryTemp + "/" + ResourceLang.UserControl曲线Time);

            FormsPlot1.Plot.YAxis.Label(ResourceLang.UserControl曲线Voltage + "(mV)");
            FormsPlot2.Plot.YAxis.Label(ResourceLang.UserControl曲线Current + "(mA)");
            FormsPlot3.Plot.YAxis.Label(ResourceLang.UserControl曲线Capacity + "(mAh)");
            FormsPlot4.Plot.YAxis.Label(ResourceLang.UserControl曲线BatteryTemp + "(℃)");

            FormsPlot1.Plot.XAxis.Label(ResourceLang.UserControl曲线Time + "(s)");
            FormsPlot2.Plot.XAxis.Label(ResourceLang.UserControl曲线Time + "(s)");
            FormsPlot3.Plot.XAxis.Label(ResourceLang.UserControl曲线Time + "(s)");
            FormsPlot4.Plot.XAxis.Label(ResourceLang.UserControl曲线Time + "(s)");
        }

        CheckBox[] CheckBoxChnNo = new CheckBox[GlobalDefine.CHANNELColumn];

        PlotData plotData = new();
        List<TRealTimeDataSave> RealTimeDataS = new();

        Plot PlotVolt, PlotCurre, PlotCapacity, PlotCellTemp;
        Plot PlotCrosshairVolt, PlotCrosshairCurre, PlotCrosshairCapacity, PlotCrosshairCellTemp;
        Crosshair CrosshairVolt, CrosshairCurre, CrosshairCapacity, CrosshairCellTemp;
        ScatterPlotList<double> ScatterPlotListCrosshairVolt, ScatterPlotListCrosshairCurre, ScatterPlotListCrosshairCapacity, ScatterPlotListCrosshairCellTemp;

        readonly IStyle[] PlotStyle = new IStyle[]
        {
            ScottPlot.Style.Black,ScottPlot.Style.Blue1,ScottPlot.Style.Blue2,ScottPlot.Style.Blue3,ScottPlot.Style.Burgundy,ScottPlot.Style.Control,ScottPlot.Style.Default,ScottPlot.Style.Gray1,
            ScottPlot.Style.Gray2,ScottPlot.Style.Hazel,ScottPlot.Style.Light1,ScottPlot.Style.Light2,ScottPlot.Style.Monospace,ScottPlot.Style.Pink,ScottPlot.Style.Seaborn
        };

        public UserControl曲线()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;

            FormsPlot1.RightClicked -= FormsPlot1.DefaultRightClickEvent;
            FormsPlot2.RightClicked -= FormsPlot2.DefaultRightClickEvent;
            FormsPlot3.RightClicked -= FormsPlot3.DefaultRightClickEvent;
            FormsPlot4.RightClicked -= FormsPlot4.DefaultRightClickEvent;

            FormsPlot1.Plot.Style(ScottPlot.Style.Light2);
            FormsPlot2.Plot.Style(ScottPlot.Style.Light2);
            FormsPlot3.Plot.Style(ScottPlot.Style.Light2);
            FormsPlot4.Plot.Style(ScottPlot.Style.Light2);

            FormsPlot1.Plot.YAxis.SetSizeLimit(min: 79, max: 79);
            FormsPlot2.Plot.YAxis.SetSizeLimit(min: 79, max: 79);
            FormsPlot3.Plot.YAxis.SetSizeLimit(min: 79, max: 79);
            FormsPlot4.Plot.YAxis.SetSizeLimit(min: 79, max: 79);

            PlotVolt = FormsPlot1.Plot;
            PlotCurre = FormsPlot2.Plot;
            PlotCapacity = FormsPlot3.Plot;
            PlotCellTemp = FormsPlot4.Plot;

            PlotCrosshairVolt = FormsPlot1.Plot;
            PlotCrosshairCurre = FormsPlot2.Plot;
            PlotCrosshairCapacity = FormsPlot3.Plot;
            PlotCrosshairCellTemp = FormsPlot4.Plot;

            for (int i = 0; i < GlobalDefine.CHANNELColumn; i++)
            {
                comboBox1.Items.Add($"CH{i * GlobalDefine.CHANNELColumn + 1:000}-CH{(i + 1) * GlobalDefine.CHANNELColumn:000}");
                CheckBoxChnNo[i] = new CheckBox()
                {
                    AutoSize = true,
                    Text = $"CH{i + 1:000}",
                    Tag = i,
                    Checked = true,
                    Dock = DockStyle.Top
                };
                CheckBoxChnNo[i].CheckedChanged += CheckBoxChnNo_CheckedChanged;
                panel1.Controls.Add(CheckBoxChnNo[i]);
                CheckBoxChnNo[i].BringToFront();
            }

            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                plotData.Volt[ChnNo] = PlotVolt.AddScatterList();
                plotData.Volt[ChnNo].LineWidth = 2;
                plotData.Volt[ChnNo].MarkerSize = 0;

                plotData.Curre[ChnNo] = PlotCurre.AddScatterList();
                plotData.Curre[ChnNo].LineWidth = 2;
                plotData.Curre[ChnNo].MarkerSize = 0;

                plotData.Capacity[ChnNo] = PlotCapacity.AddScatterList();
                plotData.Capacity[ChnNo].LineWidth = 2;
                plotData.Capacity[ChnNo].MarkerSize = 0;

                plotData.CellTemp[ChnNo] = PlotCellTemp.AddScatterList();
                plotData.CellTemp[ChnNo].LineWidth = 2;
                plotData.CellTemp[ChnNo].MarkerSize = 0;
            }

            CrosshairVolt = PlotCrosshairVolt.AddCrosshair(0, 0);
            CrosshairCurre = PlotCrosshairCurre.AddCrosshair(0, 0);
            CrosshairCapacity = PlotCrosshairCapacity.AddCrosshair(0, 0);
            CrosshairCellTemp = PlotCrosshairCellTemp.AddCrosshair(0, 0);

            CrosshairVolt.IsVisible = false;
            CrosshairCurre.IsVisible = false;
            CrosshairCapacity.IsVisible = false;
            CrosshairCellTemp.IsVisible = false;

            ScatterPlotListCrosshairVolt = PlotCrosshairVolt.AddScatterList(color: Color.Yellow, lineWidth: 2);
            ScatterPlotListCrosshairCurre = PlotCrosshairCurre.AddScatterList(color: Color.Yellow, lineWidth: 2);
            ScatterPlotListCrosshairCapacity = PlotCrosshairCapacity.AddScatterList(color: Color.Yellow, lineWidth: 2);
            ScatterPlotListCrosshairCellTemp = PlotCrosshairCellTemp.AddScatterList(color: Color.Yellow, lineWidth: 2);

            comboBox1.SelectedIndex = 0;
            comboBox_PlotStyle.SelectedIndex = 0;
            PlotRender();
        }

        int DataID = -1;
        int SelectStage = 0;
        string DBPath = string.Empty;

        object objDataShow = new();
        public void DataShow()
        {
            lock (objDataShow)
            {
                try
                {
                    if (GlobalParams.GStages[SelectStage].ProcessFlag < TProcessFlag.pfReady || SelectStage != GlobalParams.SelectStage || DBPath != GlobalParams.GStages[SelectStage].DBPath)
                    {
                        SelectStage = GlobalParams.SelectStage;
                        DBPath = GlobalParams.GStages[SelectStage].DBPath;
                        DataID = -1;

                        if (RealTimeDataS.Count > 0)
                        {
                            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                            {
                                plotData.Volt[ChnNo].Clear();
                                plotData.Curre[ChnNo].Clear();
                                plotData.Capacity[ChnNo].Clear();
                                plotData.CellTemp[ChnNo].Clear();
                            }
                            ScatterPlotListCrosshairVolt.Clear();
                            ScatterPlotListCrosshairCurre.Clear();
                            ScatterPlotListCrosshairCapacity.Clear();
                            ScatterPlotListCrosshairCellTemp.Clear();

                            RealTimeDataS.Clear();
                            PlotRender();
                        }
                        return;
                    }
                    {
                        DataTable? dataTable = DatabaseOperations.RealTimeDataSelect(DBPath, DataID);
                        if (dataTable != null && dataTable.Rows.Count > 0)
                        {
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                DataID = (int)dataTable.Rows[i]["DataID"];
                                TRealTimeDataSave RealTimeData = new()
                                {
                                    DataID = (int)dataTable.Rows[i]["DataID"],
                                    ProcessTime = (double)dataTable.Rows[i]["ProcessTime"],
                                    StepWorkTime = (double)dataTable.Rows[i]["StepWorkTime"],
                                    StepNo = (int)dataTable.Rows[i]["StepNo"],
                                    StepMode = Enum.Parse<TStepMode>(dataTable.Rows[i]["StepMode"].ToString()!),
                                    ChannelRealTimeData = new TChannelRealTimeDataSave[GlobalDefine.CHANNELS]
                                };

                                string[] DateItem = ZipUp.DecompressionObject<string>((byte[])dataTable.Rows[i]["RealTimeData"])!.Split(';');
                                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                                {
                                    //string RealTimeDataItem = "工作状态,电芯状态,电压,电流,容量,电池温度,线电压,能量,通道温度,接触阻抗"; 
                                    string[] strChannelRealTimeData = DateItem[ChnNo].Split(',');
                                    RealTimeData.ChannelRealTimeData[ChnNo] = new TChannelRealTimeDataSave
                                    {
                                        ProcessStatus = Enum.Parse<TProcessStatus>(strChannelRealTimeData[0]),//工作状态
                                        ChnState = byte.Parse(strChannelRealTimeData[1]),//电芯状态
                                        Volt = double.Parse(strChannelRealTimeData[2]),//电压
                                        Curre = double.Parse(strChannelRealTimeData[3]),//电流
                                        Capacity = double.Parse(strChannelRealTimeData[4]),//容量
                                        CellTemp = double.Parse(strChannelRealTimeData[5]),//电池温度
                                        LineVolt = double.Parse(strChannelRealTimeData[6]),//线电压
                                        Energy = double.Parse(strChannelRealTimeData[7]),//能量
                                        ChannelTemp = double.Parse(strChannelRealTimeData[8]),//通道温度
                                        IR = double.Parse(strChannelRealTimeData[9])//接触阻抗
                                    };
                                }
                                RealTimeDataS.Add(RealTimeData);
                                DataChange(RealTimeData);
                            }
                            PlotRender();
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void PlotShow(int i)
        {
            try
            {
                bool IsVisible = CheckBoxChnNo[i % GlobalDefine.CHANNELColumn].Checked && i / GlobalDefine.CHANNELColumn == comboBox1.SelectedIndex;
                plotData.Volt[i].IsVisible = IsVisible;
                plotData.Curre[i].IsVisible = IsVisible;
                plotData.Capacity[i].IsVisible = IsVisible;
                plotData.CellTemp[i].IsVisible = IsVisible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataChange(TRealTimeDataSave RealTimeData)
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                plotData.Volt[ChnNo].Add(RealTimeData.ProcessTime, RealTimeData.ChannelRealTimeData[ChnNo].Volt);
                plotData.Curre[ChnNo].Add(RealTimeData.ProcessTime, RealTimeData.ChannelRealTimeData[ChnNo].Curre);
                plotData.Capacity[ChnNo].Add(RealTimeData.ProcessTime, RealTimeData.ChannelRealTimeData[ChnNo].Capacity);
                plotData.CellTemp[ChnNo].Add(RealTimeData.ProcessTime, RealTimeData.ChannelRealTimeData[ChnNo].CellTemp);
            }
            ScatterPlotListCrosshairVolt.Add(RealTimeData.ProcessTime, RealTimeData.ChannelRealTimeData[No].Volt);
            ScatterPlotListCrosshairCurre.Add(RealTimeData.ProcessTime, RealTimeData.ChannelRealTimeData[No].Curre);
            ScatterPlotListCrosshairCapacity.Add(RealTimeData.ProcessTime, RealTimeData.ChannelRealTimeData[No].Capacity);
            ScatterPlotListCrosshairCellTemp.Add(RealTimeData.ProcessTime, RealTimeData.ChannelRealTimeData[No].CellTemp);
        }

        private class PlotData
        {
            public ScatterPlotList<double>[] Volt = new ScatterPlotList<double>[GlobalDefine.CHANNELS];
            public ScatterPlotList<double>[] Curre = new ScatterPlotList<double>[GlobalDefine.CHANNELS];
            public ScatterPlotList<double>[] Capacity = new ScatterPlotList<double>[GlobalDefine.CHANNELS];
            public ScatterPlotList<double>[] CellTemp = new ScatterPlotList<double>[GlobalDefine.CHANNELS];
        }

        private void ComboBox_PlotStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormsPlot1.Plot.Style(PlotStyle[comboBox_PlotStyle.SelectedIndex]);
            FormsPlot2.Plot.Style(PlotStyle[comboBox_PlotStyle.SelectedIndex]);
            FormsPlot3.Plot.Style(PlotStyle[comboBox_PlotStyle.SelectedIndex]);
            FormsPlot4.Plot.Style(PlotStyle[comboBox_PlotStyle.SelectedIndex]);
            PlotRender();
        }

        private void PlotRender(RenderType renderType = RenderType.LowQualityThenHighQuality)
        {
            if (checkBoxZoom.Checked)
            {
                FormsPlot1.Plot.AxisAuto();
                FormsPlot2.Plot.AxisAuto();
                FormsPlot3.Plot.AxisAuto();
                FormsPlot4.Plot.AxisAuto();
            }

            FormsPlot1.RefreshRequest(renderType);
            FormsPlot2.RefreshRequest(renderType);
            FormsPlot3.RefreshRequest(renderType);
            FormsPlot4.RefreshRequest(renderType);
        }

        private void FormsPlot1_MouseEnter(object sender, EventArgs e)
        {
            CrosshairVolt.IsVisible = true;
            CrosshairCurre.IsVisible = true;
            CrosshairCapacity.IsVisible = true;
            CrosshairCellTemp.IsVisible = true;
        }

        private void FormsPlot1_MouseLeave(object sender, EventArgs e)
        {
            CrosshairVolt.IsVisible = false;
            CrosshairCurre.IsVisible = false;
            CrosshairCapacity.IsVisible = false;
            CrosshairCellTemp.IsVisible = false;
        }

        object objMouseMove = new();
        private void FormsPlot1_MouseMove(object sender, MouseEventArgs e)
        {
            lock (objMouseMove)
            {
                if (RealTimeDataS.Count > 0)
                {
                    FormsPlot formsPlot = (FormsPlot)sender;
                    (double mouseCoordX, double mouseCoordY) = formsPlot.GetMouseCoordinates();

                    int index = 0;
                    if (RealTimeDataS[0].ProcessTime >= mouseCoordX)
                        index = 0;
                    else if (mouseCoordX >= RealTimeDataS.Last().ProcessTime)
                        index = RealTimeDataS.Count - 1;
                    else
                    {
                        for (int i = 1; i < RealTimeDataS.Count; i++)
                        {
                            if (RealTimeDataS[i - 1].ProcessTime <= mouseCoordX && mouseCoordX <= RealTimeDataS[i].ProcessTime)
                            {
                                if (Math.Abs(RealTimeDataS[i - 1].ProcessTime - mouseCoordX) < Math.Abs(RealTimeDataS[i].ProcessTime - mouseCoordX))
                                    index = i - 1;
                                else
                                    index = i;
                                break;
                            }
                        }
                    }
                    Task.Run(() =>
                    {
                        label_ProcessTime.Text = TStructConvert.IntToTime((int)(RealTimeDataS[index].ProcessTime * 1000));
                        label_StepWorkTime.Text = TStructConvert.IntToTime((int)(RealTimeDataS[index].StepWorkTime * 1000));
                        label_Step.Text = $"{RealTimeDataS[index].StepNo}_{RealTimeDataS[index].StepMode}";
                        label_CellProcessStatus.Text = GlobalFunction.GetValue(RealTimeDataS[index].ChannelRealTimeData[No].ProcessStatus);
                        label_ChnState.Text = RealTimeDataS[index].ChannelRealTimeData[No].ChnState.ToString("X2");
                        label_Volt.Text = RealTimeDataS[index].ChannelRealTimeData[No].Volt.ToString("F2");
                        label_Curre.Text = RealTimeDataS[index].ChannelRealTimeData[No].Curre.ToString("F2");
                        label_LineVolt.Text = RealTimeDataS[index].ChannelRealTimeData[No].LineVolt.ToString("F2");
                        label_Capacity.Text = RealTimeDataS[index].ChannelRealTimeData[No].Capacity.ToString("F2");
                        label_ChannelTemp.Text = RealTimeDataS[index].ChannelRealTimeData[No].ChannelTemp.ToString("F2");
                        label_CellTemp.Text = RealTimeDataS[index].ChannelRealTimeData[No].CellTemp.ToString("F2");
                        label_Energy.Text = RealTimeDataS[index].ChannelRealTimeData[No].Energy.ToString("F2");
                        label_IR.Text = RealTimeDataS[index].ChannelRealTimeData[No].IR.ToString("F2");
                    });

                    PlotPointChanged(index);
                }
            }
        }

        private void PlotPointChanged(int index)
        {
            if (plotData != null && plotData.Curre != null && plotData.Curre[No] != null)
            {
                double X = RealTimeDataS[index].ProcessTime;
                string Xstr = TStructConvert.IntToTime((int)(RealTimeDataS[index].ProcessTime * 1000));
                CrosshairChanged(ref CrosshairVolt, ref PlotCrosshairVolt, RealTimeDataS[index].ChannelRealTimeData[No].Volt, X, Xstr);
                CrosshairChanged(ref CrosshairCurre, ref PlotCrosshairCurre, RealTimeDataS[index].ChannelRealTimeData[No].Curre, X, Xstr);
                CrosshairChanged(ref CrosshairCapacity, ref PlotCrosshairCapacity, RealTimeDataS[index].ChannelRealTimeData[No].Capacity, X, Xstr);
                CrosshairChanged(ref CrosshairCellTemp, ref PlotCrosshairCellTemp, RealTimeDataS[index].ChannelRealTimeData[No].CellTemp, X, Xstr);

                PlotRender(RenderType.HighQualityDelayed);
            }
        }

        private void CrosshairChanged(ref Crosshair crosshair, ref Plot plot, double Y, double X, string Xstr)
        {
            if (crosshair == null)
            {
                crosshair = plot.AddCrosshair(X, Y);
                crosshair.LineWidth = 3;
            }
            else
            {
                crosshair.X = X;
                crosshair.Y = Y;
            }
            string HFormatter(double HF) => $"{Y}";
            crosshair.HorizontalLine.PositionFormatter = HFormatter;
            string VFormatter(double VF) => $"{Xstr: 0))}";
            crosshair.VerticalLine.PositionFormatter = VFormatter;
        }

        private int No = 0;

        private void PlotSelect()
        {
            ScatterPlotListCrosshairVolt.Clear();
            for (int i = 0; i < RealTimeDataS.Count; i++)
            {
                ScatterPlotListCrosshairVolt.Add(RealTimeDataS[i].ProcessTime, RealTimeDataS[i].ChannelRealTimeData[No].Volt);
            }

            ScatterPlotListCrosshairCurre.Clear();
            for (int i = 0; i < RealTimeDataS.Count; i++)
            {
                ScatterPlotListCrosshairCurre.Add(RealTimeDataS[i].ProcessTime, RealTimeDataS[i].ChannelRealTimeData[No].Curre);
            }

            ScatterPlotListCrosshairCapacity.Clear();
            for (int i = 0; i < RealTimeDataS.Count; i++)
            {
                ScatterPlotListCrosshairCapacity.Add(RealTimeDataS[i].ProcessTime, RealTimeDataS[i].ChannelRealTimeData[No].Capacity);
            }

            ScatterPlotListCrosshairCellTemp.Clear();
            for (int i = 0; i < RealTimeDataS.Count; i++)
            {
                ScatterPlotListCrosshairCellTemp.Add(RealTimeDataS[i].ProcessTime, RealTimeDataS[i].ChannelRealTimeData[No].CellTemp);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalDefine.CHANNELColumn; i++)
            {
                int ChnNo = comboBox1.SelectedIndex * GlobalDefine.CHANNELColumn + i;
                CheckBoxChnNo[i].Text = $"CH{ChnNo + 1:000}";
                CheckBoxChnNo[i].Tag = ChnNo;
            }
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                PlotShow(ChnNo);
            }
            DataShow();
            PlotRender();
        }

        private void CheckBoxChnNo_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int ChnNo = (int)checkBox.Tag;
            PlotShow(ChnNo);
            PlotRender();
        }

        private void FormsPlot2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                FormsPlot1.Plot.AxisAuto();
                FormsPlot2.Plot.AxisAuto();
                FormsPlot3.Plot.AxisAuto();
                FormsPlot4.Plot.AxisAuto();
                PlotRender();
            }
        }

        private void FormsPlot1_DoubleClick(object sender, EventArgs e)
        {
            if (RealTimeDataS.Count == 0)
                return;

            FormsPlot formsPlot = (FormsPlot)sender;
            (double mouseCoordX, double mouseCoordY) = formsPlot.GetMouseCoordinates();
            int ID = 0;
            if (RealTimeDataS[0].ProcessTime >= mouseCoordX)
                ID = 0;
            else if (mouseCoordX >= RealTimeDataS.Last().ProcessTime)
                ID = RealTimeDataS.Count - 1;
            else
            {
                for (int i = 1; i < RealTimeDataS.Count; i++)
                {
                    if (RealTimeDataS[i - 1].ProcessTime <= mouseCoordX && mouseCoordX <= RealTimeDataS[i].ProcessTime)
                    {
                        if (Math.Abs(RealTimeDataS[i - 1].ProcessTime - mouseCoordX) < Math.Abs(RealTimeDataS[i].ProcessTime - mouseCoordX))
                            ID = i - 1;
                        else
                            ID = i;
                        break;
                    }
                }
            }
            List<double> doubles = new();
            List<int> ChnNos = new();
            switch (formsPlot.Tag.ToString())
            {
                case "Volt":
                    for (int index = 0; index < GlobalDefine.CHANNELColumn; index++)
                    {
                        if (CheckBoxChnNo[index].Checked)
                        {
                            doubles.Add(Math.Abs(RealTimeDataS[ID].ChannelRealTimeData[(int)CheckBoxChnNo[index].Tag].Volt - mouseCoordY));
                            ChnNos.Add((int)CheckBoxChnNo[index].Tag);
                        }
                    }
                    break;
                case "Curre":
                    for (int index = 0; index < GlobalDefine.CHANNELColumn; index++)
                    {
                        if (CheckBoxChnNo[index].Checked)
                        {
                            doubles.Add(Math.Abs(RealTimeDataS[ID].ChannelRealTimeData[(int)CheckBoxChnNo[index].Tag].Curre - mouseCoordY));
                            ChnNos.Add((int)CheckBoxChnNo[index].Tag);
                        }
                    }
                    break;
                case "Capacity":
                    for (int index = 0; index < GlobalDefine.CHANNELColumn; index++)
                    {
                        if (CheckBoxChnNo[index].Checked)
                        {
                            doubles.Add(Math.Abs(RealTimeDataS[ID].ChannelRealTimeData[(int)CheckBoxChnNo[index].Tag].Capacity - mouseCoordY));
                            ChnNos.Add((int)CheckBoxChnNo[index].Tag);
                        }
                    }
                    break;
                case "CellTemp":
                    for (int index = 0; index < GlobalDefine.CHANNELColumn; index++)
                    {
                        if (CheckBoxChnNo[index].Checked)
                        {
                            doubles.Add(Math.Abs(RealTimeDataS[ID].ChannelRealTimeData[(int)CheckBoxChnNo[index].Tag].CellTemp - mouseCoordY));
                            ChnNos.Add((int)CheckBoxChnNo[index].Tag);
                        }
                    }
                    break;
            }
            if (doubles.Count > 0)
            {
                int i = doubles.IndexOf(doubles.Min());
                LineSelect(ChnNos[i]);
            }
        }

        public void LineSelect(int ChnNo)
        {
            No = ChnNo;
            label_Pos.Text = (No + 1).ToString("000");
            PlotSelect();
            PlotRender(RenderType.HighQualityDelayed);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormsPlot1.Plot.AxisAuto();
            FormsPlot2.Plot.AxisAuto();
            FormsPlot3.Plot.AxisAuto();
            FormsPlot4.Plot.AxisAuto();
            PlotRender();
        }
    }
}
