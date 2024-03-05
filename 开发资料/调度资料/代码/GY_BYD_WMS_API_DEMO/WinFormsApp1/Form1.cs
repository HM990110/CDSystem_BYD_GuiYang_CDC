using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = JsonConvert.SerializeObject(new Zhuanhuan());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zhuanhuan? zhuanhuan = JsonConvert.DeserializeObject<Zhuanhuan>(richTextBox1.Text);
            zhuanhuan.int5 = 0;
        }
    }

    public class Zhuanhuan
    {
        public int int1 = 123;
        public int int2 = 123;
        public int int3 = 123;
        public int int4 = 123;
        public int int5 = 123;
        public string str1 = "123";
        public string str2 = "123";
        public string str3 = "123";
        public string str4 = "123";
        public string str5 = "123";
    }
}