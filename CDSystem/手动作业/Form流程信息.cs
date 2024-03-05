using CDClassLibrary.Stage;
using CDSystem.Language;

namespace CDSystem.手动作业
{
    public partial class Form流程信息 : Form
    {
        public void Language()
        {


        }

        public Form流程信息(TProcessGroup ProcessGroup)
        {
            InitializeComponent();

            userControl流程信息1.Power(false);

            userControl流程信息1.DataChange(ProcessGroup);
        }
    }
}
