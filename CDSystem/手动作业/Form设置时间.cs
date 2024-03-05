using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDSystem.手动作业
{
    public partial class Form设置时间 : Form
    {
        public void Language()
        {

        }

        public delegate void DelTest(string time);
        readonly DelTest _del;

        public Form设置时间(DelTest del, string time)
        {
            InitializeComponent();


            string[] strMes = time.Split(':');
            textBox_HH.Text = int.Parse(strMes[0]).ToString("00");
            textBox_mm.Text = int.Parse(strMes[1]).ToString("00");
            textBox_ss.Text = int.Parse(strMes[2]).ToString("00");
            _del = del;
        }

        private void buttonSacve_Click(object sender, EventArgs e)
        {
            _ = int.TryParse(textBox_HH.Text, out int timehh);
            _ = int.TryParse(textBox_mm.Text, out int timemm);
            _ = int.TryParse(textBox_ss.Text, out int timess);
            _del($"{timehh:00}:{timemm:00}:{timess:00}");
            this.Close();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b') // 判断按下的键是否为数字
            {
                e.Handled = true;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            _ = int.TryParse(textBox.Text, out int time);
            if (time > 59)
                textBox.Text = "00";
        }
    }
}
