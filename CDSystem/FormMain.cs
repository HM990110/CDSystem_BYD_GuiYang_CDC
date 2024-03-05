using CDClassLibrary;
using CDSystem.传感数据;
using CDSystem.设备状态;
using CDSystem.系统设置;
using CDSystem.实时数据;
using CDSystem.手动作业;
using System.Reflection;
using CDSystem.历史数据;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CDSystem.Properties;
using CDSystem.Language;
using CDClassLibrary.Stage;

namespace CDSystem
{
    public partial class FormMain : Form
    {
        public void Language()
        {
            button主页.Text = ResourceLang.FormMainbutton主页Text;
            button传感数据.Text = ResourceLang.FormMainbutton传感数据Text;
            button历史数据.Text = ResourceLang.FormMainbutton历史数据Text;
            button实时数据.Text = ResourceLang.FormMainbutton实时数据Text;
            button手动作业.Text = ResourceLang.FormMainbutton手动作业Text;
            button系统设置.Text = ResourceLang.FormMainbutton系统设置Text;
            button运行记录.Text = ResourceLang.FormMainbutton运行记录Text;
            LabelItemTitle.Text = ResourceLang.FormMainLabelItemTitleText;
            登录ToolStripMenuItem.Text = ResourceLang.FormMain登录ToolStripMenuItemText;
            退出ToolStripMenuItem.Text = ResourceLang.FormMain退出ToolStripMenuItemText;
            label3.Text = ResourceLang.FormMainLanguageText;

            Form设备信息.Language();
            Form传感数据.Language();
            Form实时数据.Language();
            Form手动作业.Language();
            Form运行记录.Language();
            Form系统设置.Language();
        }

        protected override CreateParams CreateParams { get { CreateParams cp = base.CreateParams; cp.ExStyle |= 0x02000000; return cp; } }

        readonly Form设备信息 Form设备信息;
        readonly Form传感数据 Form传感数据;
        readonly Form实时数据 Form实时数据;
        readonly Form手动作业 Form手动作业;
        readonly Form运行记录 Form运行记录;
        readonly Form系统设置 Form系统设置;

        public FormMain()
        {
            InitializeComponent();

            this.Text +=
                $"  " +
                $"Version {Assembly.GetExecutingAssembly().GetName().Version} " +
                $"Build {System.IO.File.GetLastWriteTime(GetType().Assembly.Location)}";
            FormAdd(Form设备信息 = new Form设备信息(FormDelShow, DelSelect));
            FormAdd(Form传感数据 = new Form传感数据());
            FormAdd(Form实时数据 = new Form实时数据(FormDelShow));
            FormAdd(Form手动作业 = new Form手动作业());
            FormAdd(Form运行记录 = new Form运行记录());
            FormAdd(Form系统设置 = new Form系统设置());

            Form设备信息.BringToFront();
            GlobalParams.Run();
            Power();
            comboBox1.SelectedIndex = (int)GlobalDefine.Lang;
        }

        private void FormAdd(Form form)
        {
            //form.Hide();
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

        private void Button_BtnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            FormShow(button.Tag.ToString()!);
        }

        private void FormDelShow(string FormName)
        {
            if (FormName == "运行记录")
                Form运行记录.comboBox_Device.SelectedIndex = GlobalParams.SelectStage + 1;
            FormShow(FormName);
        }

        private void FormShow(string FormName)
        {
            if (this.Tag.ToString() != FormName)
            {
                switch (this.Tag.ToString())
                {
                    case "主页": button主页.BackgroundImage = Properties.Resources.菜单单元背景常态; Form设备信息.RealTimeDataClose(); break;
                    case "传感数据": button传感数据.BackgroundImage = Properties.Resources.菜单单元背景常态; Form传感数据.RealTimeDataClose(); break;
                    case "实时数据": button实时数据.BackgroundImage = Properties.Resources.菜单单元背景常态; Form实时数据.RealTimeDataClose(); break;
                    case "手动作业": button手动作业.BackgroundImage = Properties.Resources.菜单单元背景常态; break;
                    case "运行记录": button运行记录.BackgroundImage = Properties.Resources.菜单单元背景常态; break;
                    case "系统设置": button系统设置.BackgroundImage = Properties.Resources.菜单单元背景常态; break;
                }

                string FormNameText = "";
                switch (FormName)
                {
                    case "主页":
                        pictureBox2.Image = Properties.Resources.设备状态ancient_gate_fill;
                        button主页.BackgroundImage = Properties.Resources.菜单单元背景选中;
                        Form设备信息.BringToFront();
                        Form设备信息.RealTimeDataShow();
                        FormNameText = button主页.Text;
                        break;
                    case "传感数据":
                        pictureBox2.Image = Properties.Resources.传感数据dashboard_3_fill;
                        button传感数据.BackgroundImage = Properties.Resources.菜单单元背景选中;
                        Form传感数据.BringToFront();
                        Form传感数据.RealTimeDataShow();
                        FormNameText = button传感数据.Text;
                        break;
                    case "实时数据":
                        pictureBox2.Image = Properties.Resources.电池数据battery_charge_line;
                        button实时数据.BackgroundImage = Properties.Resources.菜单单元背景选中;
                        Form实时数据.BringToFront();
                        Form实时数据.RealTimeDataShow();
                        FormNameText = button实时数据.Text;
                        break;
                    case "手动作业":
                        pictureBox2.Image = Properties.Resources.手动作业flow_chart;
                        button手动作业.BackgroundImage = Properties.Resources.菜单单元背景选中;
                        Form手动作业.BringToFront();
                        FormNameText = button手动作业.Text;
                        break;
                    case "运行记录":
                        pictureBox2.Image = Properties.Resources.运行记录file_history_fill;
                        button运行记录.BackgroundImage = Properties.Resources.菜单单元背景选中;
                        Form运行记录.BringToFront();
                        Form运行记录.DataShow();
                        FormNameText = button运行记录.Text;
                        break;
                    case "系统设置":
                        pictureBox2.Image = Properties.Resources.系统设置_settings_line;
                        button系统设置.BackgroundImage = Properties.Resources.菜单单元背景选中;
                        Form系统设置.BringToFront();
                        Form系统设置.DataShow();
                        FormNameText = button系统设置.Text;
                        break;
                };

                LabelItemTitle.Text = FormNameText;
                this.Tag = FormName;
            }
        }

        private void DelSelect()
        {
            string FStageNo = GlobalParams.GStages[GlobalParams.SelectStage].FStageNo;
            Program.MyClass设备选中.SelectStageColumn = FStageNo.Substring(2, 3);
            Program.MyClass设备选中.SelectStageRow = FStageNo.Substring(5, 2);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(ResourceLang.ProgramExitSystem, ResourceLang.ProgramExit, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GlobalParams.GlobalParamsClose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Button历史数据_Click(object sender, EventArgs e)
        {
            Form_Graph_Show();
        }


        [DllImport("USER32.DLL")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public static void Form_Graph_Show()
        {
            Process[] procs = Process.GetProcessesByName("CDGraph");
            if (procs.Length > 0)
            {
                SetForegroundWindow(procs[0].MainWindowHandle);
                SetForegroundWindow(procs[0].MaxWorkingSet);
            }
            else
            {
                try { Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"CDGraph\CDGraph"); }
                catch (Exception ex)
                {
                    Console.WriteLine("1043:" + ex.Message);
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (this.Tag.ToString() != button.Tag.ToString())
                button.BackgroundImage = Properties.Resources.菜单单元背景移过;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (this.Tag.ToString() != button.Tag.ToString())
                button.BackgroundImage = Properties.Resources.菜单单元背景常态;
        }

        private void Button运行记录_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            FormShow(button.Tag.ToString()!);
            Form运行记录.comboBox_Device.SelectedIndex = 0;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            new FormLogin(PowerChange).ShowDialog();
        }
        private void PowerChange()
        {
            Form设备信息.Power();
            Form传感数据.Power();
            Form实时数据.Power();
            Form手动作业.Power();
            Form系统设置.Power();
            this.Power();
            pictureBox1.Image = Resources.menu_technicalSupport;
        }

        public void Power()
        {
            label1.Text = Program.ClassUser.Username;
            label2.Text = Program.ClassUser.Realname;
        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormLogin(PowerChange).ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ClassUser = new ClassUser();
            PowerChange();
            pictureBox1.Image = Resources.无人值守;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalDefine.Lang = (Lang)(comboBox1.SelectedIndex);

            GlobalFunction.Language();
            Program.Language();

            GlobalFunction.GetConfig();
            Language();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
