using CDSystem.Language;

namespace CDSystem.手动作业
{
    public partial class Form添加流程 : Form
    {
        public void Language()
        {
            buttonSacve.Text = ResourceLang.Form添加流程buttonSacveText;
            label1.Text = ResourceLang.Form添加流程label1Text;
        }

        public delegate void DelTest(string name, int PID);
        readonly DelTest _del;
        readonly List<string> PName = new();

        public Form添加流程(DelTest del, List<string> PName)
        {
            InitializeComponent();


            _del = del;
            this.PName = PName;
            textBox_ProcessName.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            comboBox_ProcessGroup.Items.Add("");
            foreach (string name in PName)
            {
                comboBox_ProcessGroup.Items.Add(name);
            }
        }

        private void ButtonSacve_Click(object sender, EventArgs e)
        {
            string str = textBox_ProcessName.Text;
            foreach (var item in PName)
            {
                if (str == item)
                {
                    MessageBox.Show("流程名已存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            _del(textBox_ProcessName.Text, comboBox_ProcessGroup.SelectedIndex);
            this.Close();
        }

        private void TextBox_ProcessName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void textBox_ProcessName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            char[] textChar = textBox.Text.ToUpper().ToCharArray();
            List<char> textCharCopy = new();
            foreach (char c in textChar)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 48 && c <= 57) || c == '-')
                {
                    textCharCopy.Add(c);
                }
            }
            string textStr = new(textCharCopy.ToArray());
            textBox.Text = textStr;
            textBox.Select(textStr.Length, 0);
        }
    }
}