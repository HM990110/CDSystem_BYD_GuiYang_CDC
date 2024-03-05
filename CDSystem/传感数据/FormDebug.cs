using CDClassLibrary.Stage;
using CDClassLibrary;
using System.Windows.Forms;
using CDSystem.Language;
using System.Runtime.InteropServices;
using CDClassLibrary.Data;

namespace CDSystem.传感数据
{
    public partial class FormDebug : Form
    {
        public void Language()
        {
            button_ShieldedSensor.Text = ResourceLang.FormDebugbutton_ShieldedSensorText;
            button_报警参数.Text = ResourceLang.FormDebugbutton_报警参数Text;
            button_报警清除.Text = ResourceLang.FormDebugbutton_报警清除Text;
            button_打开风机总开.Text = ResourceLang.FormDebugbutton_打开风机总开Text;
            button_电磁锁打开.Text = ResourceLang.FormDebugbutton_电磁锁打开Text;
            button_电磁锁关闭.Text = ResourceLang.FormDebugbutton_电磁锁关闭Text;
            button_掉电恢复.Text = ResourceLang.FormDebugbutton_掉电恢复Text;
            button_掉电清除.Text = ResourceLang.FormDebugbutton_掉电清除Text;
            button_蜂鸣器打开A.Text = ResourceLang.FormDebugbutton_蜂鸣器打开AText;
            button_蜂鸣器打开M.Text = ResourceLang.FormDebugbutton_蜂鸣器打开MText;
            button_蜂鸣器关闭A.Text = ResourceLang.FormDebugbutton_蜂鸣器关闭AText;
            button_蜂鸣器关闭M.Text = ResourceLang.FormDebugbutton_蜂鸣器关闭MText;
            button_关闭风机总开.Text = ResourceLang.FormDebugbutton_关闭风机总开Text;
            button_进入手动模式.Text = ResourceLang.FormDebugbutton_进入手动模式Text;
            button_逆变器断电.Text = ResourceLang.FormDebugbutton_逆变器断电Text;
            button_逆变器上电.Text = ResourceLang.FormDebugbutton_逆变器上电Text;
            button_排烟风机停.Text = ResourceLang.FormDebugbutton_排烟风机停Text;
            button_排烟风机转.Text = ResourceLang.FormDebugbutton_排烟风机转Text;
            button_气缸闭合.Text = ResourceLang.FormDebugbutton_气缸闭合Text;
            button_气缸张开.Text = ResourceLang.FormDebugbutton_气缸张开Text;
            button_上位机报警.Text = ResourceLang.FormDebugbutton_上位机报警Text;
            button_上位机不报警.Text = ResourceLang.FormDebugbutton_上位机不报警Text;
            button_上针床风机停.Text = ResourceLang.FormDebugbutton_上针床风机停Text;
            button_上针床风机转.Text = ResourceLang.FormDebugbutton_上针床风机转Text;
            button_水冷电磁阀打开.Text = ResourceLang.FormDebugbutton_水冷电磁阀打开Text;
            button_水冷电磁阀关闭.Text = ResourceLang.FormDebugbutton_水冷电磁阀关闭Text;
            button_退出手动模式.Text = ResourceLang.FormDebugbutton_退出手动模式Text;
            button_系统启动.Text = ResourceLang.FormDebugbutton_系统启动Text;
            button_系统停止.Text = ResourceLang.FormDebugbutton_系统停止Text;
            button_下针床风机停.Text = ResourceLang.FormDebugbutton_下针床风机停Text;
            button_下针床风机转.Text = ResourceLang.FormDebugbutton_下针床风机转Text;
            button_校正工装断电.Text = ResourceLang.FormDebugbutton_校正工装断电Text;
            button_校正工装供电.Text = ResourceLang.FormDebugbutton_校正工装供电Text;
            button_异常断电.Text = ResourceLang.FormDebugbutton_异常断电Text;
            button_异常启动打开.Text = ResourceLang.FormDebugbutton_异常启动打开Text;
            button_异常启动关闭.Text = ResourceLang.FormDebugbutton_异常启动关闭Text;
            button_运行灯亮.Text = ResourceLang.FormDebugbutton_运行灯亮Text;
            button_运行灯灭.Text = ResourceLang.FormDebugbutton_运行灯灭Text;
            button_自动门落下.Text = ResourceLang.FormDebugbutton_自动门落下Text;
            button_自动门张开.Text = ResourceLang.FormDebugbutton_自动门张开Text;
            button1.Text = ResourceLang.FormDebugbutton1Text;
            button10.Text = ResourceLang.FormDebugbutton10Text;
            button11.Text = ResourceLang.FormDebugbutton11Text;
            button12.Text = ResourceLang.FormDebugbutton12Text;
            button13.Text = ResourceLang.FormDebugbutton13Text;
            button14.Text = ResourceLang.FormDebugbutton14Text;
            button15.Text = ResourceLang.FormDebugbutton15Text;
            button16.Text = ResourceLang.FormDebugbutton16Text;
            button17.Text = ResourceLang.FormDebugbutton17Text;
            button19.Text = ResourceLang.FormDebugbutton19Text;
            button2.Text = ResourceLang.FormDebugbutton2Text;
            button21.Text = ResourceLang.FormDebugbutton21Text;
            button3.Text = ResourceLang.FormDebugbutton3Text;
            button4.Text = ResourceLang.FormDebugbutton4Text;
            button5.Text = ResourceLang.FormDebugbutton5Text;
            button6.Text = ResourceLang.FormDebugbutton6Text;
            button7.Text = ResourceLang.FormDebugbutton7Text;
            button8.Text = ResourceLang.FormDebugbutton8Text;
            button9.Text = ResourceLang.FormDebugbutton9Text;
            checkBox_ShieldedFireDoorSensor.Text = ResourceLang.FormDebugcheckBox_ShieldedFireDoorSensorText;
            groupBox1.Text = ResourceLang.FormDebuggroupBox1Text;
            groupBox2.Text = ResourceLang.FormDebuggroupBox2Text;
            groupBox3.Text = ResourceLang.FormDebuggroupBox3Text;
            label1.Text = ResourceLang.FormDebuglabel1Text;
            label12.Text = ResourceLang.FormDebuglabel12Text;
            label2.Text = ResourceLang.FormDebuglabel2Text;
            label3.Text = ResourceLang.FormDebuglabel3Text;
            label4.Text = ResourceLang.FormDebuglabel4Text;
            label5.Text = ResourceLang.FormDebuglabel5Text;
            label6.Text = ResourceLang.FormDebuglabel6Text;
            label7.Text = ResourceLang.FormDebuglabel7Text;
            label8.Text = ResourceLang.FormDebuglabel8Text;
        }

        readonly int SelectStage;

        public FormDebug()
        {
            InitializeComponent();
            Language();
            SelectStage = GlobalParams.SelectStage;
            UserPowers();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TEnvDataMCU EnvDataMCU = GlobalParams.GStages[GlobalParams.SelectStage].EnvDataMCU;

            richTextBox1.Text = string.Empty;
            richTextBox1.AppendText("机构严重故障状态：" + EnvDataMCU.SeriousEMGState + "\r\n");
            richTextBox1.AppendText("机构传感器报警：" + EnvDataMCU.SensorEMGAlarm + "\r\n");
            richTextBox1.AppendText("平台状态：" + EnvDataMCU.DeviceState + "\r\n");
            richTextBox1.AppendText("机构工作状态：" + EnvDataMCU.MechanicalWorkSate + "\r\n");
            richTextBox1.AppendText("逆变器电源状态：" + EnvDataMCU.InverterPowerState + "\r\n");
            richTextBox1.AppendText("急停按钮检测：" + EnvDataMCU.EmgButtonState + "\r\n");
            richTextBox1.AppendText("托盘状态：" + EnvDataMCU.TrayState + "\r\n");
            richTextBox1.AppendText("气缸状态：" + EnvDataMCU.CylinderStatorState + "\r\n");
            richTextBox1.AppendText("气压状态：" + EnvDataMCU.AirPressureState + "\r\n");
            richTextBox1.AppendText("屏蔽传感器检测的状态回读：" + EnvDataMCU.ShieldedSensor + "\r\n");
            richTextBox1.AppendText("机构温度值：");
            foreach (var item in EnvDataMCU.MechanicalTempValue)
                richTextBox1.AppendText((int)item + ",");
            richTextBox1.AppendText("\r\n");
            richTextBox1.AppendText("下位机工作模式：" + EnvDataMCU.McuWorkState + "\r\n");
            richTextBox1.AppendText("应用软件版本号：" + EnvDataMCU.SoftVersion + "\r\n");
            richTextBox1.AppendText("掉电标记：" + EnvDataMCU.PowerFailFlag + "\r\n");
            richTextBox1.AppendText("授权到期标记：" + EnvDataMCU.Softexpires + "\r\n");
            richTextBox1.AppendText("烟雾浓度值：");
            foreach (var item in EnvDataMCU.SmogValue)
                richTextBox1.AppendText((int)item + ",");
            richTextBox1.AppendText("\r\n");
            richTextBox1.AppendText("比例阀开度值：" + EnvDataMCU.ValveOpenValue + "\r\n");
            richTextBox1.AppendText("电池平均温度值：" + EnvDataMCU.BatteryAvgTempValue + "\r\n");
            richTextBox1.AppendText("机构温度传感器状态：");
            foreach (var item in EnvDataMCU.MechanicalTempState)
                richTextBox1.AppendText((int)item + ",");
            richTextBox1.AppendText("\r\n");
            richTextBox1.AppendText("烟雾传感器状态：");
            foreach (var item in EnvDataMCU.SmogState)
                richTextBox1.AppendText((int)item + ",");
            richTextBox1.AppendText("\r\n");
            richTextBox1.AppendText("目标温度值：" + EnvDataMCU.TargetTempValue + "\r\n");
            richTextBox1.AppendText("流量阀开度值：" + EnvDataMCU.FlowValveOpenValue + "\r\n");
            richTextBox1.AppendText("工装取电状态：" + EnvDataMCU.EtalonPowerState + "\r\n");
            richTextBox1.AppendText("流量阀开度检测状态：" + EnvDataMCU.FlowValveState + "\r\n");
            richTextBox1.AppendText("Kp 比例系数：" + EnvDataMCU.CoefficientKp + "\r\n");
            richTextBox1.AppendText("Ki 积分系数：" + EnvDataMCU.CoefficientKi + "\r\n");
            richTextBox1.AppendText("Kd 微分系数：" + EnvDataMCU.CoefficientKd + "\r\n");
            richTextBox1.AppendText("调节周期 T：" + EnvDataMCU.AdjustingCycleT + "\r\n");
            richTextBox1.AppendText("机构温度报警值：" + EnvDataMCU.MechanicalTempAlarmValue + "\r\n");
            richTextBox1.AppendText("电池温度报警值：" + EnvDataMCU.BatteryTempAlarmValue + "\r\n");
            richTextBox1.AppendText("\r\n");
            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                    richTextBox1.AppendText("\r\n上针床风机：");
                else if (i == 4)
                    richTextBox1.AppendText("\r\n下针床风机：");
                else if (i == 8)
                    richTextBox1.AppendText("\r\n水冷风机：");
                else if (i == 14)
                    richTextBox1.AppendText("\r\n烟道风机：");
                else if (i == 15)
                    richTextBox1.AppendText("\r\n其他风机：");
                richTextBox1.AppendText((int)EnvDataMCU.FanState[i] + ",");
            }
            richTextBox1.AppendText("\r\n");
            richTextBox1.AppendText("CAN 通讯累计发送错误次数：");
            foreach (var item in EnvDataMCU.CumulativeCANTxRrrorCount)
                richTextBox1.AppendText((int)item + ",");
            richTextBox1.AppendText("\r\n");
            richTextBox1.AppendText("CAN 通讯累计接收错误次数：");
            foreach (var item in EnvDataMCU.CumulativeCANRxRrrorCount)
                richTextBox1.AppendText((int)item + ",");
            richTextBox1.AppendText("\r\n");

            richTextBox2.Text = string.Empty;
            richTextBox2.AppendText("托盘传感器 1：" + EnvDataMCU.InputSensorsMCU[0] + "\r\n");
            richTextBox2.AppendText("托盘传感器 2：" + EnvDataMCU.InputSensorsMCU[1] + "\r\n");
            richTextBox2.AppendText("托盘传感器 3：" + EnvDataMCU.InputSensorsMCU[2] + "\r\n");
            richTextBox2.AppendText("托盘缺角检测：" + EnvDataMCU.InputSensorsMCU[3] + "\r\n");
            richTextBox2.AppendText("气缸零位传感器 1：" + EnvDataMCU.InputSensorsMCU[4] + "\r\n");
            richTextBox2.AppendText("气缸到位传感器 1：" + EnvDataMCU.InputSensorsMCU[5] + "\r\n");
            richTextBox2.AppendText("气缸零位传感器 2：" + EnvDataMCU.InputSensorsMCU[6] + "\r\n");
            richTextBox2.AppendText("气缸到位传感器 2：" + EnvDataMCU.InputSensorsMCU[7] + "\r\n");
            richTextBox2.AppendText("急停检测：" + EnvDataMCU.InputSensorsMCU[8] + "\r\n");
            richTextBox2.AppendText("复位按钮信号：" + EnvDataMCU.InputSensorsMCU[9] + "\r\n");
            richTextBox2.AppendText("烟感信号 1：" + EnvDataMCU.InputSensorsMCU[10] + "\r\n");
            richTextBox2.AppendText("烟感信号 2：" + EnvDataMCU.InputSensorsMCU[11] + "\r\n");
            richTextBox2.AppendText("气压上限检测：" + EnvDataMCU.InputSensorsMCU[12] + "\r\n");
            richTextBox2.AppendText("气压下限检测：" + EnvDataMCU.InputSensorsMCU[13] + "\r\n");
            richTextBox2.AppendText("自动门下到位检测：" + EnvDataMCU.InputSensorsMCU[15] + "\r\n");
            richTextBox2.AppendText("水冷阀检测：" + EnvDataMCU.InputSensorsMCU[16] + "\r\n");
            richTextBox2.AppendText("门气缸到位检测：" + EnvDataMCU.InputSensorsMCU[17] + "\r\n");
        }

        private void Button_气缸闭合_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].CylinderStatorControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_气缸张开_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].CylinderStatorControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_逆变器上电_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].InverterPowerControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_逆变器断电_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].InverterPowerControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_蜂鸣器打开M_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].BuzzerControlM(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_蜂鸣器关闭M_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].BuzzerControlM(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_校正工装供电_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].EtalonPowerControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_校正工装断电_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].EtalonPowerControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_自动门落下_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].AutoDoorControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_自动门张开_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].AutoDoorControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_排烟风机转_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].SmokeExhaustFanControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_排烟风机停_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].SmokeExhaustFanControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_打开风机总开_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].AllFanControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_关闭风机总开_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].AllFanControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_运行灯亮_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].RunLightControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_运行灯灭_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].RunLightControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_电磁锁打开_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].ElectromagnetLockControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_电磁锁关闭_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].ElectromagnetLockControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_水冷电磁阀打开_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].WaterCooledControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_水冷电磁阀关闭_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].WaterCooledControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_异常启动打开_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].AbnormalStartControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_异常启动关闭_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].AbnormalStartControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_系统启动_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].SystemOnOff(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_系统停止_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].SystemOnOff(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_上位机报警_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].PCAlarm(0x01))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_上位机不报警_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].PCAlarm(0x00))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_报警清除_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].AlarmClear(0x01))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_掉电恢复_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].PowerFailControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_掉电清除_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].PowerFailControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_异常断电_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].AbnormalPowerOutage())
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_进入手动模式_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].ManualAutoControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_退出手动模式_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].ManualAutoControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_蜂鸣器打开A_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].BuzzerControlA(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_蜂鸣器关闭A_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].BuzzerControlA(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_报警参数_Click(object sender, EventArgs e)
        {
            _ = int.TryParse(TextBox_ATempLimit.Text, out int ATempLimit);
            _ = int.TryParse(TextBox_ACellTempLimit.Text, out int ACellTempLimit);
            _ = int.TryParse(TextBox_ASmogLimit.Text, out int ASmogLimit);

            if (!GlobalParams.CommMCU[SelectStage].SetTempSmogLimitAll(ATempLimit, ACellTempLimit, ASmogLimit))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GlobalParams.GStages[SelectStage].StateInit();
        }

        private void Button_水冷风机转_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _ = int.TryParse(button.Tag.ToString(), out int ID);
            if (!GlobalParams.CommMCU[SelectStage].WaterFanControl(0x55, ID))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_水冷风机停_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _ = int.TryParse(button.Tag.ToString(), out int ID);
            if (!GlobalParams.CommMCU[SelectStage].WaterFanControl(0xAA, ID))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_水冷风机总转_Click(object sender, EventArgs e)
        {
            bool result = true;
            for (int i = 0; i < 6; i++)
            {
                if (!GlobalParams.CommMCU[SelectStage].WaterFanControl(0x55, (i + 1)))
                {
                    result = false;
                    break;
                }
            }
            if (!result)
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_水冷风机总停_Click(object sender, EventArgs e)
        {
            bool result = true;
            for (int i = 0; i < 6; i++)
            {
                if (!GlobalParams.CommMCU[SelectStage].WaterFanControl(0xAA, (i + 1)))
                {
                    result = false;
                    break;
                }
            }
            if (!result)
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_上针床风机转_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].UPNeedleDedFanControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_上针床风机停_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].UPNeedleDedFanControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_下针床风机转_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].DownNeedleDedFanControl(0x55))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button_下针床风机停_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].DownNeedleDedFanControl(0xAA))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            _ = double.TryParse(TextBox_KpValue.Text, out double KpValue);
            _ = double.TryParse(TextBox_KiValue.Text, out double KiValue);
            _ = double.TryParse(TextBox_KdValue.Text, out double KdValue);
            _ = int.TryParse(TextBox_time.Text, out int time);

            if (!GlobalParams.CommMCU[SelectStage].WaterPIDControl(KpValue, KiValue, KdValue, time))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            GlobalParams.GStages[SelectStage].SaveRecResultData();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            _ = double.TryParse(uiTextBox1.Text, out double VacuumValue);
            if (!GlobalParams.CommMCU[SelectStage].WaterOpenControl(VacuumValue))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            _ = int.TryParse(TextBox_水冷系统控制温度.Text, out int ATemp);
            if (!GlobalParams.CommMCU[SelectStage].WaterDoorTarget(ATemp))
                MessageBox.Show("命令发送失败", "失败");
        }

        public static void UserPowers()
        {
            //groupBox1.Enabled = Program.UserClass.powers[7];
            //groupBox2.Enabled = Program.UserClass.powers[7];
        }

        private void Button_ShieldedSensor_Click(object sender, EventArgs e)
        {
            if (!GlobalParams.CommMCU[SelectStage].ShieldedSensor(checkBox_ShieldedFireDoorSensor.Checked))
                MessageBox.Show("命令发送失败", "失败");
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new()
                {
                    Title = "请选择文件",
                    Filter = "充放电流程(*.db)|*.db|所有文件(*.*)|*.*",
                    FilterIndex = 1,
                    RestoreDirectory = true,
                    Multiselect = false,
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string FilePath = openFileDialog.FileName.ToString();

                    if (SqlServerData.DataWrite(FilePath, FilePath.Contains("CDC3") ? TDeviceType.CDC3 : TDeviceType.CDC2))
                    {
                        MessageBox.Show("数据上传成功", "成功");
                    }
                    else
                    {
                        MessageBox.Show("数据上传失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }
    }
}
