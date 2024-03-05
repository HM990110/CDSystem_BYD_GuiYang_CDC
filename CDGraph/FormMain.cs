using Aspose.Cells;
using CDClassLibrary.Stage;
using CDClassLibrary.Tools;
using CDGraph.Class;
using CDGraph.Language;
using Newtonsoft.Json;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CDGraph
{
    public partial class FormMain : Form
    {
        public void Language()
        {
            button_OpenFile.Text = ResourceLang.FormMainbutton_OpenFileText;
            button2.Text = ResourceLang.FormMainbutton2Text;
        }

        protected override CreateParams CreateParams { get { CreateParams cp = base.CreateParams; cp.ExStyle |= 0x02000000; return cp; } }

        TProcessGroup ProcessGroup = new();
        TTrayInfo TrayInfo = new();
        RealTimeDatajx RealTimeDatajx = new(Array.Empty<string>(), 0);
        List<ResultDatajx> ResultDatajx = new();

        public FormMain()
        {
            InitializeComponent();
            Language();
            TextBox.CheckForIllegalCrossThreadCalls = false;
            UserControl流程信息.Power(false);
        }

        string OpenFileDialogInitialDirectory = "D:\\CDSystem";
        private void Button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Title = "请选择文件",
                Filter = "充放电数据(*.db)|*.db|所有文件(*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                Multiselect = false,
                InitialDirectory = OpenFileDialogInitialDirectory
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialogInitialDirectory = openFileDialog.FileName.Replace(openFileDialog.SafeFileName, string.Empty);
                OpenFile(openFileDialog.FileName);
            }
        }

        string FileName = string.Empty;

        public void OpenFile(string FilePath)
        {
            try
            {
                FileName = FilePath.Split('\\').Last().Split('.')[0];
                this.Activate();
                ProcessBar1.BringToFront();
                ProcessBar1.Visible = true;
                ProcessBar1.Value = 0;

                ProcessGroup = new();
                TrayInfo = new();
                RealTimeDatajx = new(Array.Empty<string>(), 0);
                ResultDatajx = new List<ResultDatajx>();

                Task task = new(new Action(() =>
                {
                    textBox1.Text = FilePath;

                    DataSet data = DatabaseOperations.DataSelect(FilePath);

                    if (data != null && data.Tables != null)
                    {
                        DataTable OtherInfoData = data.Tables["OtherInfo"]!;

                        string[] RealTimeDataItem = Array.Empty<string>();
                        string[] EnvDataItem = Array.Empty<string>();
                        if (OtherInfoData != null && OtherInfoData.Rows.Count > 0)
                        {
                            TrayInfo = JsonConvert.DeserializeObject<TTrayInfo>(OtherInfoData.Rows[0]["TrayInfo"].ToString()!)!;
                            ProcessGroup = JsonConvert.DeserializeObject<TProcessGroup>(OtherInfoData.Rows[0]["ProcessGroup"].ToString()!)!;
                            RealTimeDataItem = OtherInfoData.Rows[0]["RealTimeDataItem"].ToString()!.Split(',');
                            EnvDataItem = OtherInfoData.Rows[0]["EnvDataItem"].ToString()!.Split(',');
                        }

                        DataTable RealTimeData = data.Tables["RealTimeData"]!;
                        DataTable ResultData = data.Tables["ResultData"]!;

                        if (RealTimeData != null && RealTimeData.Rows.Count > 0)
                            ProcessBar1.Maximum = RealTimeData.Rows.Count;
                        if (ResultData != null && ResultData.Rows.Count > 0)
                            ProcessBar1.Maximum += ResultData.Rows.Count;

                        if (RealTimeData != null && RealTimeData.Rows.Count > 0)
                        {
                            int DataLength = RealTimeData.Rows.Count;
                            RealTimeDatajx = new RealTimeDatajx(RealTimeDataItem, DataLength);
                            Task task = new(new Action(() =>
                            {
                                Task[] tasks = new Task[DataLength];
                                for (int No = 0; No < DataLength; No++)
                                {
                                    int no = No;
                                    tasks[no] = new Task(new Action(() =>
                                    {
                                        RealTimeDatajx.DataID[no] = (int)RealTimeData.Rows[no]["DataID"];
                                        RealTimeDatajx.StepNo[no] = (int)RealTimeData.Rows[no]["StepNo"];
                                        RealTimeDatajx.StepMode[no] = RealTimeData.Rows[no]["StepMode"].ToString()!;
                                        RealTimeDatajx.ProcessTime[no] = (double)RealTimeData.Rows[no]["ProcessTime"];
                                        RealTimeDatajx.StepWorkTime[no] = (double)RealTimeData.Rows[no]["StepWorkTime"];

                                        string[] DateItem = ZipUp.DecompressionObject<string>((byte[])RealTimeData.Rows[no]["RealTimeData"])!.Split(';');

                                        for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                                        {
                                            string[] strChannelRealTimeData = DateItem[ChnNo].Split(',');

                                            RealTimeDatajx.ProcessStatus[ChnNo][no] = GlobalFunction.GetValue(Enum.Parse<TProcessStatus>(strChannelRealTimeData[0]));
                                            RealTimeDatajx.ChnState[ChnNo][no] = byte.Parse(strChannelRealTimeData[1]).ToString("X2");

                                            for (int i = 0; i < RealTimeDatajx.RealTimeDataitem.Count; i++)
                                            {
                                                RealTimeDatajx.RealTimeDataitem[i][ChnNo][no] = double.Parse(strChannelRealTimeData[i + 2]);
                                            }
                                        }

                                        string[] EnvDataTemp = ZipUp.DecompressionObject<string>((byte[])RealTimeData.Rows[no]["EnvData"])!.Split(';')[0].Split(',');

                                        for (int Index = 0; Index < EnvDataTemp.Length - 1; Index++)
                                        {
                                            RealTimeDatajx.EnvDataTemp[Index][no] = double.Parse(EnvDataTemp[Index]);
                                        }
                                        RealTimeDatajx.EnvDataVacuum[no] = double.Parse(EnvDataTemp.Last());

                                        ProcessBar1.Value++;
                                    }));
                                    tasks[no].Start();
                                }
                                Task.WaitAll(tasks);
                            }));
                            task.Start();
                            task.Wait();
                        }
                        if (TrayInfo != null && ProcessGroup != null)
                        {
                            for (int i = 0; i < ProcessGroup.Process.StepCount; i++)
                            {
                                ResultDatajx.Add(new Class.ResultDatajx());
                            }

                            if (ResultData != null && ResultData.Rows.Count > 0)
                            {
                                foreach (DataRow row in ResultData.Rows)
                                {
                                    int StepNo = (int)row["StepNo"] - 1;
                                    int ChnNo = (int)row["ChnNo"] - 1;
                                    if (StepNo >= 0 && ChnNo >= 0)
                                    {
                                        ResultDatajx[StepNo].Cell状态[ChnNo] = (string)row["ChnState"];
                                        ResultDatajx[StepNo].Cell起始时间[ChnNo] = row["ProcessTime"].ToString()!;
                                        ResultDatajx[StepNo].Cell起始电压[ChnNo] = row["StartVolt"].ToString()!;
                                        ResultDatajx[StepNo].Cell起始电流[ChnNo] = row["StartCurre"].ToString()!;
                                        ResultDatajx[StepNo].Cell起始环境温度[ChnNo] = row["StartEnvTemp"].ToString()!;
                                        ResultDatajx[StepNo].Cell起始电池温度[ChnNo] = row["StartCellTemp"].ToString()!;
                                        //cellDatas[StepNo].Cell起始真空值[ChnNo] = double.Parse(row["StepNo"].ToString());
                                        ResultDatajx[StepNo].Cell结束时间[ChnNo] = row["EndTime"].ToString()!;
                                        ResultDatajx[StepNo].Cell结束电压[ChnNo] = row["EndVolt"].ToString()!;
                                        ResultDatajx[StepNo].Cell结束电流[ChnNo] = row["EndCurre"].ToString()!;
                                        ResultDatajx[StepNo].Cell结束环境温度[ChnNo] = row["EndEnvTemp"].ToString()!;
                                        ResultDatajx[StepNo].Cell结束电池温度[ChnNo] = row["EndCellTemp"].ToString()!;
                                        //cellDatas[StepNo].Cell结束真空值[ChnNo] = double.Parse(row["StepNo"].ToString());
                                        ResultDatajx[StepNo].Cell结束容量[ChnNo] = row["EndCapacity"].ToString()!;
                                        ResultDatajx[StepNo].Cell平均环境温度[ChnNo] = row["AvgEnvTemp"].ToString()!;
                                        ResultDatajx[StepNo].Cell平均电池温度[ChnNo] = row["AvgCellTemp"].ToString()!;
                                    }
                                    ProcessBar1.Value++;
                                }
                            }
                        }

                    }
                }));
                task.Start();
                task.Wait();

                Thread.Sleep(1000);

                ProcessBar1.Visible = false;
                this.Activate();
                UserControl曲线.Datashow(RealTimeDatajx, TrayInfo.ChnState);
                UserControl结果数据.DataShow(TrayInfo, ProcessGroup, ResultDatajx);
                UserControl流程信息.DataChange(ProcessGroup);
            }
            catch (Exception ex)
            {
                ProcessBar1.Visible = false;
                MessageBox.Show(ex.Message, "错误");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        string SaveFileDialogInitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private void Button2_Click(object sender, EventArgs e)
        {
            if (RealTimeDatajx.DataID.Length == 0)
                return;
            SaveFileDialog saveFileDialog = new()
            {
                FileName = FileName,  //设置默认文件名
                Filter = "xlsx文件(*.xlsx)|*.xlsx",  //设置文件类型
                DefaultExt = "xlsx", //设置默认格式（可以不设）
                AddExtension = true, //设置自动在文件名中添加扩展名
                RestoreDirectory = true,//保存对话框是否记忆上次打开的目录 
                InitialDirectory = SaveFileDialogInitialDirectory,
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveFileDialogInitialDirectory = saveFileDialog.FileName.Replace(saveFileDialog.FileName.Split('\\').Last(), string.Empty);
                    string save_filename = saveFileDialog.FileName.ToString(); //获得文件路径    

                    Workbook excelDoc = new();
                    excelDoc.Worksheets.Clear();
                    ProcessBar1.Value = 0;
                    ProcessBar1.Maximum = GlobalDefine.CHANNELS * RealTimeDatajx.DataID.Length + ResultDatajx.Count * GlobalDefine.CHANNELS;
                    ProcessBar1.Visible = true;
                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    {
                        string sheetName = "CH_" + (ChnNo + 1).ToString("000");
                        excelDoc.Worksheets.Add(sheetName);
                        Worksheet excelSheet = excelDoc.Worksheets[sheetName];
                        excelSheet.Cells[0, 0].Value = "序号";
                        excelSheet.Cells[0, 1].Value = "通道号";
                        excelSheet.Cells[0, 2].Value = "工作时间";
                        excelSheet.Cells[0, 3].Value = "步次时间";
                        excelSheet.Cells[0, 4].Value = "工作状态";
                        excelSheet.Cells[0, 5].Value = "步次序号";
                        excelSheet.Cells[0, 6].Value = "步次类型";
                        excelSheet.Cells[0, 7].Value = "诊断值";
                        for (int ItemIndex = 0; ItemIndex < RealTimeDatajx.RealTimeDataitemName.Count; ItemIndex++)
                        {
                            excelSheet.Cells[0, ItemIndex + 8].Value = RealTimeDatajx.RealTimeDataitemName[ItemIndex];
                        }

                        for (int j = 0; j < RealTimeDatajx.DataID.Length; j++)
                        {
                            int row = j + 1;
                            excelSheet.Cells[row, 0].Value = row;
                            excelSheet.Cells[row, 1].Value = ChnNo;
                            excelSheet.Cells[row, 2].Value = RealTimeDatajx.ProcessTime[j];
                            excelSheet.Cells[row, 3].Value = RealTimeDatajx.StepWorkTime[j];
                            excelSheet.Cells[row, 4].Value = RealTimeDatajx.ProcessStatus[ChnNo][j];
                            excelSheet.Cells[row, 5].Value = RealTimeDatajx.StepNo[j];
                            excelSheet.Cells[row, 6].Value = RealTimeDatajx.StepMode[j];
                            excelSheet.Cells[row, 7].Value = RealTimeDatajx.ChnState[ChnNo][j];
                            for (int ItemIndex = 0; ItemIndex < RealTimeDatajx.RealTimeDataitemName.Count; ItemIndex++)
                            {
                                excelSheet.Cells[row, ItemIndex + 8].Value = RealTimeDatajx.RealTimeDataitem[ItemIndex][ChnNo][j];
                            }
                            ProcessBar1.Value++;
                        }
                    }
                    {
                        string sheetName = "环境温度";
                        excelDoc.Worksheets.Add(sheetName);
                        Worksheet excelSheet = excelDoc.Worksheets[sheetName];
                        excelSheet.Cells[0, 0].Value = "序号";
                        for (int Index = 0; Index < RealTimeDatajx.EnvDataTemp.Count; Index++)
                            excelSheet.Cells[0, Index + 1].Value = "温度" + (Index + 1).ToString();
                        for (int Index = 0; Index < RealTimeDatajx.DataID.Length; Index++)
                        {
                            int row = Index + 1;
                            excelSheet.Cells[row, 0].Value = row;
                            for (int ItemIndex = 0; ItemIndex < RealTimeDatajx.EnvDataTemp.Count; ItemIndex++)
                            {
                                excelSheet.Cells[row, ItemIndex + 1].Value = RealTimeDatajx.EnvDataTemp[ItemIndex][Index];
                            }
                        }
                    }
                    {
                        string sheetName = "结果数据";
                        excelDoc.Worksheets.Add(sheetName);
                        Worksheet excelSheet = excelDoc.Worksheets[sheetName];
                        excelSheet.Cells[0, 0].Value = "通道号";
                        excelSheet.Cells[0, 1].Value = "电芯条码";
                        excelSheet.Cells[0, 2].Value = "状态";
                        excelSheet.Cells[0, 3].Value = "起始时间";
                        excelSheet.Cells[0, 4].Value = "起始电压(mV)";
                        excelSheet.Cells[0, 5].Value = "起始电流(mA)";
                        excelSheet.Cells[0, 6].Value = "起始环境温度(℃)";
                        excelSheet.Cells[0, 7].Value = "起始电池温度（℃）";
                        excelSheet.Cells[0, 8].Value = "结束时间";
                        excelSheet.Cells[0, 9].Value = "结束电压(mV)";
                        excelSheet.Cells[0, 10].Value = "结束电流(mA)";
                        excelSheet.Cells[0, 11].Value = "结束环境温度(℃)";
                        excelSheet.Cells[0, 12].Value = "结束电池温度(℃)";
                        excelSheet.Cells[0, 13].Value = "结束容量(mAh)";
                        for (int j = 0; j < ResultDatajx.Count; j++)
                        {
                            int row = j * GlobalDefine.CHANNELS + j + 1;
                            excelSheet.Cells[row, 0].Value = (j + 1).ToString() + "_" + ProcessGroup.Process.ProcStepRec[j].StepMode;
                            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                            {
                                row += 1;
                                excelSheet.Cells[row, 0].Value = "CH_" + (ChnNo + 1).ToString("000");
                                excelSheet.Cells[row, 1].Value = TrayInfo.CellNumber[ChnNo];
                                excelSheet.Cells[row, 2].Value = ResultDatajx[j].Cell状态[ChnNo];
                                excelSheet.Cells[row, 3].Value = ResultDatajx[j].Cell起始时间[ChnNo];
                                excelSheet.Cells[row, 4].Value = ResultDatajx[j].Cell起始电压[ChnNo];
                                excelSheet.Cells[row, 5].Value = ResultDatajx[j].Cell起始电流[ChnNo];
                                excelSheet.Cells[row, 6].Value = ResultDatajx[j].Cell起始环境温度[ChnNo];
                                excelSheet.Cells[row, 7].Value = ResultDatajx[j].Cell起始电池温度[ChnNo];
                                excelSheet.Cells[row, 8].Value = ResultDatajx[j].Cell结束时间[ChnNo];
                                excelSheet.Cells[row, 9].Value = ResultDatajx[j].Cell结束电压[ChnNo];
                                excelSheet.Cells[row, 10].Value = ResultDatajx[j].Cell结束电流[ChnNo];
                                excelSheet.Cells[row, 11].Value = ResultDatajx[j].Cell结束环境温度[ChnNo];
                                excelSheet.Cells[row, 12].Value = ResultDatajx[j].Cell结束电池温度[ChnNo];
                                excelSheet.Cells[row, 13].Value = ResultDatajx[j].Cell结束容量[ChnNo];
                                ProcessBar1.Value++;
                            }
                        }
                    }

                    {
                        string sheetName = "托盘信息";
                        excelDoc.Worksheets.Add(sheetName);
                        Worksheet excelSheet = excelDoc.Worksheets[sheetName];
                        int row = 0;
                        excelSheet.Cells[row, 0].Value = "任务ID";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.MissionID;
                        excelSheet.Cells[row, 0].Value = "电池型号";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.MDL_NAME;
                        excelSheet.Cells[row, 0].Value = "批次编号";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.BATCH_ID;
                        excelSheet.Cells[row, 0].Value = "托盘编号";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.TRAY_NO;
                        excelSheet.Cells[row, 0].Value = "流程编号";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.ProcessName;
                        excelSheet.Cells[row, 0].Value = "电池数量";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.CELL_COUNT;
                        excelSheet.Cells[row, 0].Value = "本工序NG数量";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.NG_COUNT;
                        excelSheet.Cells[row, 0].Value = "前工序NG数量";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.PF_COUNT;
                        excelSheet.Cells[row, 0].Value = "自动流程";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.AutoFlag;
                        excelSheet.Cells[row, 0].Value = "自动结束";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.AutoEnd;
                        excelSheet.Cells[row, 0].Value = "开始时间";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.STARTIME;
                        excelSheet.Cells[row, 0].Value = "结束时间";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.ENDTIME;
                        excelSheet.Cells[row, 0].Value = "设备编号";
                        excelSheet.Cells[row++, 1].Value = TrayInfo.FStageNo;
                        excelSheet.Cells[row++, 0].Value = "电池条码";
                        excelSheet.Cells[GlobalDefine.CHANNELRow + 2 + row, 0].Value = "电池状态";
                        for (int Row = 0; Row < GlobalDefine.CHANNELRow; Row++)
                        {
                            for (int Column = 0; Column < GlobalDefine.CHANNELColumn; Column++)
                            {
                                int Index = Row * GlobalDefine.CHANNELColumn + Column;
                                excelSheet.Cells[row + Row, Column].Value = TrayInfo.ChnState[Index].ToString("X2");
                                excelSheet.Cells[row + GlobalDefine.CHANNELRow + 3 + row, Column].Value = TrayInfo.CellNumber[Index];
                            }
                        }
                    }

                    excelDoc.Save(save_filename);
                    ProcessBar1.Visible = false;
                    MessageBox.Show("导出成功！", "成功");
                }
                catch (Exception ex)
                {
                    ProcessBar1.Visible = false;
                    MessageBox.Show("导出失败！" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserControl曲线.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            UserControl结果数据.BringToFront();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            UserControl流程信息.BringToFront();
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string sta = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                OpenFile(sta);
            }
        }

        private void FormMain_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            Console.WriteLine(1);
        }
    }
}