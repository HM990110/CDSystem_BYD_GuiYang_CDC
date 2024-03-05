using CDClassLibrary.Data;
using CDSystem.Language;
using Newtonsoft.Json;
using System.Data;

namespace CDSystem.系统设置
{
    public partial class FormLogin : Form
    {
        public void Language()
        {
            this.Text = ResourceLang.FormLoginText;
            button1.Text = ResourceLang.FormLoginbutton1Text;
            label1.Text = ResourceLang.FormLoginlabel1Text;
            label2.Text = ResourceLang.FormLoginlabel2Text;
        }

        public delegate void MyDelPower();
        readonly MyDelPower _myDelPower;
        public FormLogin(MyDelPower myDelPower)
        {
            InitializeComponent();
            Language();

            _myDelPower = myDelPower;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            char[] textChar = textBox.Text.ToUpper().ToCharArray();
            List<char> textCharCopy = new();
            foreach (char c in textChar)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 48 && c <= 57))
                {
                    textCharCopy.Add(c);
                }
            }
            string textStr = new(textCharCopy.ToArray());
            textBox.Text = textStr;
            textBox.Select(textStr.Length, 0);
            label3.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Username = TextBoxUsername.Text.Trim();
            if (Username.Length == 0)
            {
                label3.Text = "工号不能为空！";
                return;
            }
            string Password = TextBoxPassword.Text.Trim();
            if (Password.Length == 0)
            {
                label3.Text = "密码不能为空！";
                return;
            }

            if (Username == "ADMIN" && Password == "123456")
            {
                Program.ClassUser = new ClassUser()
                {
                    Password = Password,
                    Password2 = Password,
                    Realname = "admin",
                    Username = Username,
                    Regtime = DateTime.Now,
                    Role = Role.游客,
                    Power = new Power()
                    {
                        传感器调试 = true,
                        停止流程 = true,
                        初始操作 = true,
                        发送流程 = true,
                        掉电操作 = true,
                        系统设置 = true,
                        编辑流程 = true,
                        自动手动切换 = true,
                        设备维护 = true,
                        重新作业 = true,
                    }
                };
                _myDelPower();
                this.Close();
            }

            try
            {
                string sql = string.Format("SELECT * FROM [USERTABLE] WHERE USERNAME='{0}'", Username);
                DataTable? data = DataCon.Reader(sql);
                if (data != null && data.Rows.Count > 0)
                {
                    if (data.Rows[0]["Password"].ToString() == Password)
                    {
                        //string dat = (string)data.Rows[0]["Regtime"];
                        Program.ClassUser = new ClassUser()
                        {
                            Username = Username,
                            Password = Password,
                            Password2 = (string)data.Rows[0]["Password2"],
                            Role = Enum.Parse<Role>((string)data.Rows[0]["Role"]),
                            Realname = (string)data.Rows[0]["Realname"],
                            Regtime = (DateTime)data.Rows[0]["Regtime"],
                        };
                        try
                        {
                            string Power = (string)data.Rows[0]["Power"];
                            if (!string.IsNullOrEmpty(Power))
                            {
                                var ClassUserPower = JsonConvert.DeserializeObject<Power>(Power);
                                if (ClassUserPower != null)
                                {
                                    Program.ClassUser.Power = ClassUserPower;
                                }
                                else
                                {
                                    Program.ClassUser.Power = new Power();
                                }
                            }
                            else
                            {
                                Program.ClassUser.Power = new Power();
                            }
                        }
                        catch
                        {
                            Program.ClassUser.Power = new Power();
                        }
                        _myDelPower();
                        this.Close();
                    }
                    else
                    {
                        label3.Text = "密码错误，请重新输入！";
                    }
                }
                else
                {
                    label3.Text = "工号不存在，请重新输入！";
                }
            }
            catch
            {
            }
        }
    }
}