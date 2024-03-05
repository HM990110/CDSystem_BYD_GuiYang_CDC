using CDClassLibrary;
using CDClassLibrary.Data;
using CDClassLibrary.Stage;
using CDSystem.Language;

namespace CDSystem.设备状态
{
    public partial class Form设备维护 : Form
    {
        public void Language()
        {
            this.Text = ResourceLang.Form设备信息设备维护ToolStripMenuItemText;
            button1.Text = ResourceLang.Form设备维护button1Text;
            label1.Text = ResourceLang.Form设备维护label1Text + GlobalParams.GStages[GlobalParams.SelectStage].FStageNo;
            label2.Text = ResourceLang.Form设备维护label2Text;

        }

        public Form设备维护()
        {
            InitializeComponent();
            Language();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Trim() != string.Empty)
            {
                GlobalParams.GStages[GlobalParams.SelectStage].VacancyFlag = false;
                GlobalFunction.RunLogAdd(GlobalParams.GStages[GlobalParams.SelectStage].FStageNo, "设备维护", richTextBox1.Text.Trim());
                GlobalDefine.VacancyFlags[GlobalParams.SelectStage] = false;
                GlobalFunction.SetVacancyFlag(); 
                this.Close();
            }
            else
            {
                MessageBox.Show("请填写维护内容！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
