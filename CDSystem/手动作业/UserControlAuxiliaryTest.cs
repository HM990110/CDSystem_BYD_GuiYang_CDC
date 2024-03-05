using System.ComponentModel;

namespace CDSystem.手动作业
{
    public partial class UserControlAuxiliaryTest : UserControl
    {
        public void Language()
        {

        }

        [Category("自定义")]
        public string TitleName
        {
            get => label2.Text;
            set
            {
                label2.Text = value;
            }
        }

        [Category("自定义")]
        public string Unit
        {
            get => label1.Text;
            set => label1.Text = value;
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
            set => numericUpDown1.Enabled = !value;
        }

        public UserControlAuxiliaryTest()
        {
            InitializeComponent();

        }
    }
}
