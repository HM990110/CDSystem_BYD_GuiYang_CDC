using System.ComponentModel;

namespace CDSystem.手动作业
{
    public partial class UserControlProtect : UserControl
    {
        public void Language()
        {

        }

        [Category("自定义")]
        public string TitleName
        {
            get => checkBox1.Text;
            set
            {
                checkBox1.Text = value;
                toolTip1.ToolTipTitle = value;
            }
        }

        [Category("自定义")]
        public string Unit
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        [Category("自定义")]
        public string SetToolTip
        {
            get => string.Empty;
            set
            {
                toolTip1.SetToolTip(this.checkBox1, value);
                toolTip1.SetToolTip(this.label1, value);
            }
        }

        [Category("自定义")]
        public int Value
        {
            get => (int)numericUpDown1.Value;
            set => numericUpDown1.Value = value;
        }

        private string type = string.Empty;
        [Category("自定义")]
        public string Type
        {
            get => type;
            set => type = value;
        }

        private string group = string.Empty;
        [Category("自定义")]
        public string Group
        {
            get => group;
            set => group = value;
        }

        [Category("自定义")]
        public bool IsValid
        {
            get => checkBox1.Checked;
            set => checkBox1.Checked = value;
        }

        private string attributeName = string.Empty;
        [Category("自定义")]
        public string AttributeName
        {
            get => attributeName;
            set => attributeName = value;
        }

        [Category("自定义")]
        public bool ReadOnly
        {
            get => !numericUpDown1.Enabled;
            set { numericUpDown1.Enabled = !value; checkBox1.Enabled = !value; }
        }

        public UserControlProtect()
        {
            InitializeComponent();

        }
    }
}
