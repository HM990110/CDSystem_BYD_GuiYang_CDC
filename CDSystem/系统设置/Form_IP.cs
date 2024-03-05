using CDSystem.Language;

namespace CDSystem.系统设置
{
    public partial class Form_IP : Form
    {
        public void Language()
        {
            button1.Text = ResourceLang.Form_IPbutton1Text;
            label4.Text = ResourceLang.Form_IPlabel4Text;

        }

        public delegate void MyDel(string IP, int Index);
        readonly MyDel _del;

        int Index = 0;

        public Form_IP(MyDel del, string IP, int Index)
        {
            InitializeComponent();
            _del = del;
            this.Index = Index;
            string[] strings = IP.Split('.');
            textBox_IP1.Text = strings[0];
            textBox_IP2.Text = strings[1];
            textBox_IP3.Text = strings[2];
            textBox_IP4.Text = strings[3];
        }

        private void TextBox_IP_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.')
            {
                switch (textBox.Tag.ToString())
                {
                    case "1":
                        textBox_IP2.Focus();
                        textBox_IP2.SelectAll();
                        break;
                    case "2":
                        textBox_IP3.Focus();
                        textBox_IP3.SelectAll();
                        break;
                    case "3":
                        textBox_IP4.Focus();
                        textBox_IP4.SelectAll();
                        break;
                }
                e.Handled = true;
            }
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            else
            {
                if (char.IsNumber(e.KeyChar))
                {
                    string str = textBox.Text + e.KeyChar;
                    if (int.Parse(str) > 255)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _del($"{textBox_IP1.Text}.{textBox_IP2.Text}.{textBox_IP3.Text}.{textBox_IP4.Text}", Index);
            this.Close();
        }
    }
}

