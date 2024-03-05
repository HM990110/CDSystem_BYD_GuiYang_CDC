using CDClassLibrary;
using CDClassLibrary.Data;
using CDClassLibrary.Stage;
using CDSystem.Language;
using System.Data;

namespace CDSystem.系统设置
{
    public partial class Form系统设置 : Form
    {
        public void Language()
        {
            tabPage1.Text = ResourceLang.Form系统设置tabPage1Text;
            tabPage2.Text = ResourceLang.Form系统设置tabPage2Text;
            tabPage3.Text = ResourceLang.Form系统设置tabPage3Text;
            tabPage5.Text = ResourceLang.Form系统设置tabPage5Text;

            UC参数设置.Language();
            UC映射设置.Language();
            UC关键器件运行记录.Language();
            UC用户管理.Language();
        }

        readonly UC参数设置 UC参数设置 = new();
        readonly UC映射设置 UC映射设置 = new();
        readonly UC关键器件运行记录 UC关键器件运行记录 = new();
        readonly UC用户管理 UC用户管理 = new();

        public Form系统设置()
        {
            InitializeComponent();
            UC参数设置.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(UC参数设置);
            UC映射设置.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(UC映射设置);
            UC关键器件运行记录.Dock = DockStyle.Fill;
            tabPage3.Controls.Add(UC关键器件运行记录);
            UC用户管理.Dock = DockStyle.Fill;
            tabPage5.Controls.Add(UC用户管理);
            Power();
        }
        public void DataShow()
        {
            UC参数设置.DataShow();
            UC映射设置.DataShow();
            UC关键器件运行记录.DataShow();
            UC用户管理.DataShow();
        }

        public void Power()
        {
            UC参数设置.Power();
            UC映射设置.Power();
            UC关键器件运行记录.Power();
            UC用户管理.Power();
        }
    }
}