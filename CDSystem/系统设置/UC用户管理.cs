using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDSystem.系统设置
{
    public partial class UC用户管理 : UserControl
    {
        public void Language()
        {

        }

        public UC用户管理()
        {
            InitializeComponent();
        }

        public void DataShow()
        {

        }

        public void Power()
        {
            this.Enabled = Program.ClassUser.Power.系统设置;
        }
    }
}
