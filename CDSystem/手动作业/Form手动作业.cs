using CDClassLibrary.Stage;
using CDClassLibrary;
using CDSystem.Language;
using System.Windows.Forms;
using CDSystem.Other;

namespace CDSystem.手动作业
{
    public partial class Form手动作业 : Form
    {
        private UserControl设备选中 UserControl设备选中;

        public void Language()
        {
            ButtonDelete.Text = ResourceLang.Form手动作业ButtonDeleteText;
            ButtonInsert.Text = ResourceLang.Form手动作业ButtonInsertText;
            ButtonSave.Text = ResourceLang.Form手动作业ButtonSaveText;
            buttonSend.Text = ResourceLang.Form手动作业buttonSendText;
            label1.Text = ResourceLang.Form手动作业label1Text;

            userControl流程信息1.Language();
            UserControl设备选中.Language();
        }

        readonly List<string> PName = new();

        public Form手动作业()
        {
            InitializeComponent();

            UserControl设备选中 = new UserControl设备选中();
            panel1.Controls.Add(UserControl设备选中);
            UserControl设备选中.BackColor = Color.White;
            UserControl设备选中.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserControl设备选中.Location = new Point(6, 6);
            UserControl设备选中.Margin = new Padding(6);
            UserControl设备选中.Size = new Size(300, 28);
            UserControl设备选中.BringToFront();
             
            List<TProcessGroup> ProcessGroups = GlobalParams.ProcessGroup;
            if (ProcessGroups != null && ProcessGroups.Count > 0)
            {
                for (int i = 0; i < ProcessGroups.Count; i++)
                {
                    comboBox_ProcessGroup.Items.Add(ProcessGroups[ProcessGroups.Count - 1 - i].ProcessName);
                    PName.Add(ProcessGroups[ProcessGroups.Count - 1 - i].ProcessName);
                }
                comboBox_ProcessGroup.SelectedIndex = 0;
            }
            userControl流程信息1.Power(true);
            Power();
        }

        public void Power()
        {
            ButtonRead.Enabled = Program.ClassUser.Power.编辑流程;
            ButtonInsert.Enabled = Program.ClassUser.Power.编辑流程;
            ButtonDelete.Enabled = Program.ClassUser.Power.编辑流程;
            ButtonSave.Enabled = Program.ClassUser.Power.编辑流程;
            ButtonSaveAs.Enabled = Program.ClassUser.Power.编辑流程;
            userControl流程信息1.Power(Program.ClassUser.Power.编辑流程);
            buttonSend.Enabled = Program.ClassUser.Power.发送流程;
            if (PName == null || PName.Count == 0)
                userControl流程信息1.Enabled = false;
        }

        private void Button_Insert_Click(object sender, EventArgs e)
        {
            new Form添加流程(NewTProcessGroup, PName).ShowDialog();
        }

        void NewTProcessGroup(string ProcessName, int PID)
        {
            TProcessGroup processGroup = new()
            {
                ProcessName = ProcessName
            };
            if (PID >= 0)
            {
                PID = GlobalParams.ProcessGroup.Count - PID;
                processGroup.Process = GlobalParams.ProcessGroup[PID].Process;
                processGroup.ContactTestProcess = GlobalParams.ProcessGroup[PID].ContactTestProcess;
                processGroup.OCVTestSet = GlobalParams.ProcessGroup[PID].OCVTestSet;
                processGroup.PCProtect = GlobalParams.ProcessGroup[PID].PCProtect;
            }

            GlobalParams.ProcessGroup.Add(processGroup);
            comboBox_ProcessGroup.Items.Insert(0, processGroup.ProcessName);
            PName.Insert(0, processGroup.ProcessName);
            GlobalFunction.SetProcesses(processGroup.ProcessName);
            comboBox_ProcessGroup.SelectedIndex = 0;
            userControl流程信息1.Enabled = true;
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            int Index = comboBox_ProcessGroup.SelectedIndex;
            if (Index >= 0)
            {
                if (MessageBox.Show($"确认删除流程工艺<{comboBox_ProcessGroup.SelectedItem}>吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Delete(GlobalDefine.ProcessPath + comboBox_ProcessGroup.SelectedItem + ".dat");
                    PName.RemoveAt(Index);
                    comboBox_ProcessGroup.Items.RemoveAt(Index);
                    GlobalParams.ProcessGroup.RemoveAt(GlobalParams.ProcessGroup.Count - 1 - Index);
                }
            }
            if (PName != null && PName.Count > 0)
            {
                comboBox_ProcessGroup.SelectedIndex = 0;
            }
            else
            {
                userControl流程信息1.Enabled = false;
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            int Index = comboBox_ProcessGroup.SelectedIndex;
            if (Index >= 0)
            {
                if (userControl流程信息1.DataSave(out TProcessGroup ProcessGroup))
                {
                    GlobalParams.ProcessGroup[comboBox_ProcessGroup.Items.Count - 1 - Index] = ProcessGroup;
                    GlobalFunction.SetProcesses(comboBox_ProcessGroup.SelectedItem.ToString()!);
                    MessageBox.Show("流程保存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ProcessGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = comboBox_ProcessGroup.SelectedIndex;
            if (Index >= 0)
            {
                userControl流程信息1.DataChange(GlobalParams.ProcessGroup[comboBox_ProcessGroup.Items.Count - 1 - Index]);
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
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
            if (comboBox_ProcessGroup.SelectedIndex >= 0)
                new Form_TrayInfo(TrayInfoMyDelForm).ShowDialog();
            else
                MessageBox.Show("请选择流程。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void TrayInfoMyDelForm(TTrayInfo TrayInfo)
        {
            if (userControl流程信息1.DataSave(out TProcessGroup ProcessGroup))
            {
                TProcessGroup processGroup = ProcessGroup;
                GlobalParams.ProcessGroup[comboBox_ProcessGroup.Items.Count - 1 - comboBox_ProcessGroup.SelectedIndex] = processGroup;
                GlobalFunction.SetProcesses(processGroup.ProcessName);
                string StrMes = string.Empty;
                if (GlobalParams.GStages[GlobalParams.SelectStage].GainProcess(processGroup, TrayInfo, ref StrMes))
                    MessageBox.Show("流程发送成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("流程发送失败！" + StrMes, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string OpenFileDialogInitialDirectory = "D:\\CDSystem";
        private void ButtonRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Title = "请选择文件",
                Filter = "充放电流程(*.dat)|*.dat|所有文件(*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                Multiselect = false,
                InitialDirectory = OpenFileDialogInitialDirectory
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialogInitialDirectory = openFileDialog.FileName.Replace(openFileDialog.SafeFileName, string.Empty);

                string FilePath = openFileDialog.FileName.ToString();
                string FileName = openFileDialog.SafeFileName.Split('.')[0];
                foreach (var item in PName)
                {
                    if (FileName == item)
                    {
                        MessageBox.Show("流程名已存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                if (GlobalFunction.GetProcessGroup(FilePath, FileName))
                {
                    comboBox_ProcessGroup.Items.Insert(0, GlobalParams.ProcessGroup.Last().ProcessName);
                    PName.Insert(0, GlobalParams.ProcessGroup.Last().ProcessName);
                    comboBox_ProcessGroup.SelectedIndex = 0;
                    userControl流程信息1.Enabled = true;

                    GlobalFunction.SetProcesses(GlobalParams.ProcessGroup.Last().ProcessName);
                }
                else
                {
                    MessageBox.Show("文件错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        string SaveFileDialogInitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private void ButtonSaveAs_Click(object sender, EventArgs e)
        {
            int Index = comboBox_ProcessGroup.SelectedIndex;
            if (Index >= 0)
            {
                if (userControl流程信息1.DataSave(out TProcessGroup ProcessGroup))
                {
                    SaveFileDialog saveFileDialog = new()
                    {
                        FileName = comboBox_ProcessGroup.SelectedItem.ToString(),  //设置默认文件名
                        Filter = "dat(*.dat)|*.dat",  //设置文件类型
                        DefaultExt = "dat", //设置默认格式（可以不设）
                        AddExtension = true, //设置自动在文件名中添加扩展名
                        RestoreDirectory = true,//保存对话框是否记忆上次打开的目录 
                        InitialDirectory = SaveFileDialogInitialDirectory,
                    };
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        SaveFileDialogInitialDirectory = saveFileDialog.FileName.Replace(saveFileDialog.FileName.Split('\\').Last(), string.Empty);
                        string save_filename = saveFileDialog.FileName!; //获得文件路径    
                        GlobalParams.ProcessGroup[comboBox_ProcessGroup.Items.Count - 1 - Index] = ProcessGroup;
                        GlobalFunction.SetProcesses(comboBox_ProcessGroup.SelectedItem.ToString()!);
                        File.Copy(GlobalDefine.ProcessPath + comboBox_ProcessGroup.SelectedItem.ToString()! + ".dat", save_filename);
                        MessageBox.Show("流程保存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
