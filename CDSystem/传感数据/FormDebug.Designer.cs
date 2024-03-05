using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CDSystem.传感数据
{
    partial class FormDebug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebug));
            richTextBox1 = new RichTextBox();
            button_气缸闭合 = new Button();
            button_气缸张开 = new Button();
            button_逆变器上电 = new Button();
            button_逆变器断电 = new Button();
            button_蜂鸣器打开M = new Button();
            button_蜂鸣器关闭M = new Button();
            button_校正工装供电 = new Button();
            button_校正工装断电 = new Button();
            button_自动门落下 = new Button();
            button_自动门张开 = new Button();
            button_上针床风机转 = new Button();
            button_上针床风机停 = new Button();
            button_下针床风机转 = new Button();
            button_下针床风机停 = new Button();
            button_排烟风机转 = new Button();
            button_排烟风机停 = new Button();
            button_打开风机总开 = new Button();
            button_关闭风机总开 = new Button();
            button_运行灯亮 = new Button();
            button_运行灯灭 = new Button();
            button_电磁锁打开 = new Button();
            button_电磁锁关闭 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            button14 = new Button();
            button15 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button_异常启动关闭 = new Button();
            button_异常启动打开 = new Button();
            button_水冷电磁阀关闭 = new Button();
            button_水冷电磁阀打开 = new Button();
            button19 = new Button();
            label8 = new Label();
            uiTextBox1 = new TextBox();
            button_上位机不报警 = new Button();
            button_上位机报警 = new Button();
            button_系统停止 = new Button();
            button_系统启动 = new Button();
            groupBox2 = new GroupBox();
            groupBox7 = new GroupBox();
            groupBox6 = new GroupBox();
            button21 = new Button();
            TextBox_水冷系统控制温度 = new TextBox();
            label12 = new Label();
            groupBox5 = new GroupBox();
            button16 = new Button();
            TextBox_time = new TextBox();
            label7 = new Label();
            TextBox_KdValue = new TextBox();
            label6 = new Label();
            TextBox_KiValue = new TextBox();
            label5 = new Label();
            TextBox_KpValue = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            button_报警参数 = new Button();
            TextBox_ASmogLimit = new TextBox();
            label3 = new Label();
            TextBox_ACellTempLimit = new TextBox();
            label2 = new Label();
            TextBox_ATempLimit = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            checkBox_ShieldedFireDoorSensor = new CheckBox();
            button_ShieldedSensor = new Button();
            button17 = new Button();
            button1 = new Button();
            button_进入手动模式 = new Button();
            button_退出手动模式 = new Button();
            button_蜂鸣器打开A = new Button();
            button_蜂鸣器关闭A = new Button();
            button_报警清除 = new Button();
            button_异常断电 = new Button();
            button_掉电恢复 = new Button();
            button_掉电清除 = new Button();
            richTextBox2 = new RichTextBox();
            button18 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(286, 733);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button_气缸闭合
            // 
            button_气缸闭合.Location = new Point(6, 20);
            button_气缸闭合.Name = "button_气缸闭合";
            button_气缸闭合.Size = new Size(130, 30);
            button_气缸闭合.TabIndex = 1;
            button_气缸闭合.Text = "气缸闭合";
            button_气缸闭合.UseVisualStyleBackColor = true;
            button_气缸闭合.Click += Button_气缸闭合_Click;
            // 
            // button_气缸张开
            // 
            button_气缸张开.Location = new Point(142, 20);
            button_气缸张开.Name = "button_气缸张开";
            button_气缸张开.Size = new Size(130, 30);
            button_气缸张开.TabIndex = 2;
            button_气缸张开.Text = "气缸张开";
            button_气缸张开.UseVisualStyleBackColor = true;
            button_气缸张开.Click += Button_气缸张开_Click;
            // 
            // button_逆变器上电
            // 
            button_逆变器上电.Location = new Point(278, 20);
            button_逆变器上电.Name = "button_逆变器上电";
            button_逆变器上电.Size = new Size(130, 30);
            button_逆变器上电.TabIndex = 3;
            button_逆变器上电.Text = "逆变器上电";
            button_逆变器上电.UseVisualStyleBackColor = true;
            button_逆变器上电.Click += Button_逆变器上电_Click;
            // 
            // button_逆变器断电
            // 
            button_逆变器断电.Location = new Point(414, 20);
            button_逆变器断电.Name = "button_逆变器断电";
            button_逆变器断电.Size = new Size(130, 30);
            button_逆变器断电.TabIndex = 4;
            button_逆变器断电.Text = "逆变器断电";
            button_逆变器断电.UseVisualStyleBackColor = true;
            button_逆变器断电.Click += Button_逆变器断电_Click;
            // 
            // button_蜂鸣器打开M
            // 
            button_蜂鸣器打开M.Location = new Point(550, 20);
            button_蜂鸣器打开M.Name = "button_蜂鸣器打开M";
            button_蜂鸣器打开M.Size = new Size(130, 30);
            button_蜂鸣器打开M.TabIndex = 5;
            button_蜂鸣器打开M.Text = "蜂鸣器打开M";
            button_蜂鸣器打开M.UseVisualStyleBackColor = true;
            button_蜂鸣器打开M.Click += Button_蜂鸣器打开M_Click;
            // 
            // button_蜂鸣器关闭M
            // 
            button_蜂鸣器关闭M.Location = new Point(686, 20);
            button_蜂鸣器关闭M.Name = "button_蜂鸣器关闭M";
            button_蜂鸣器关闭M.Size = new Size(130, 30);
            button_蜂鸣器关闭M.TabIndex = 6;
            button_蜂鸣器关闭M.Text = "蜂鸣器关闭M";
            button_蜂鸣器关闭M.UseVisualStyleBackColor = true;
            button_蜂鸣器关闭M.Click += Button_蜂鸣器关闭M_Click;
            // 
            // button_校正工装供电
            // 
            button_校正工装供电.Location = new Point(6, 56);
            button_校正工装供电.Name = "button_校正工装供电";
            button_校正工装供电.Size = new Size(130, 30);
            button_校正工装供电.TabIndex = 13;
            button_校正工装供电.Text = "校正工装供电";
            button_校正工装供电.UseVisualStyleBackColor = true;
            button_校正工装供电.Click += Button_校正工装供电_Click;
            // 
            // button_校正工装断电
            // 
            button_校正工装断电.Location = new Point(142, 56);
            button_校正工装断电.Name = "button_校正工装断电";
            button_校正工装断电.Size = new Size(130, 30);
            button_校正工装断电.TabIndex = 14;
            button_校正工装断电.Text = "校正工装断电";
            button_校正工装断电.UseVisualStyleBackColor = true;
            button_校正工装断电.Click += Button_校正工装断电_Click;
            // 
            // button_自动门落下
            // 
            button_自动门落下.Location = new Point(278, 56);
            button_自动门落下.Name = "button_自动门落下";
            button_自动门落下.Size = new Size(130, 30);
            button_自动门落下.TabIndex = 21;
            button_自动门落下.Text = "自动门落下";
            button_自动门落下.UseVisualStyleBackColor = true;
            button_自动门落下.Click += Button_自动门落下_Click;
            // 
            // button_自动门张开
            // 
            button_自动门张开.Location = new Point(414, 56);
            button_自动门张开.Name = "button_自动门张开";
            button_自动门张开.Size = new Size(130, 30);
            button_自动门张开.TabIndex = 22;
            button_自动门张开.Text = "自动门张开";
            button_自动门张开.UseVisualStyleBackColor = true;
            button_自动门张开.Click += Button_自动门张开_Click;
            // 
            // button_上针床风机转
            // 
            button_上针床风机转.Location = new Point(550, 56);
            button_上针床风机转.Name = "button_上针床风机转";
            button_上针床风机转.Size = new Size(130, 30);
            button_上针床风机转.TabIndex = 23;
            button_上针床风机转.Text = "上针床风机转";
            button_上针床风机转.UseVisualStyleBackColor = true;
            button_上针床风机转.Click += Button_上针床风机转_Click;
            // 
            // button_上针床风机停
            // 
            button_上针床风机停.Location = new Point(686, 56);
            button_上针床风机停.Name = "button_上针床风机停";
            button_上针床风机停.Size = new Size(130, 30);
            button_上针床风机停.TabIndex = 24;
            button_上针床风机停.Text = "上针床风机停";
            button_上针床风机停.UseVisualStyleBackColor = true;
            button_上针床风机停.Click += Button_上针床风机停_Click;
            // 
            // button_下针床风机转
            // 
            button_下针床风机转.Location = new Point(6, 92);
            button_下针床风机转.Name = "button_下针床风机转";
            button_下针床风机转.Size = new Size(130, 30);
            button_下针床风机转.TabIndex = 25;
            button_下针床风机转.Text = "下针床风机转";
            button_下针床风机转.UseVisualStyleBackColor = true;
            button_下针床风机转.Click += Button_下针床风机转_Click;
            // 
            // button_下针床风机停
            // 
            button_下针床风机停.Location = new Point(142, 92);
            button_下针床风机停.Name = "button_下针床风机停";
            button_下针床风机停.Size = new Size(130, 30);
            button_下针床风机停.TabIndex = 26;
            button_下针床风机停.Text = "下针床风机停";
            button_下针床风机停.UseVisualStyleBackColor = true;
            button_下针床风机停.Click += Button_下针床风机停_Click;
            // 
            // button_排烟风机转
            // 
            button_排烟风机转.Location = new Point(278, 92);
            button_排烟风机转.Name = "button_排烟风机转";
            button_排烟风机转.Size = new Size(130, 30);
            button_排烟风机转.TabIndex = 27;
            button_排烟风机转.Text = "排烟风机转";
            button_排烟风机转.UseVisualStyleBackColor = true;
            button_排烟风机转.Click += Button_排烟风机转_Click;
            // 
            // button_排烟风机停
            // 
            button_排烟风机停.Location = new Point(414, 92);
            button_排烟风机停.Name = "button_排烟风机停";
            button_排烟风机停.Size = new Size(130, 30);
            button_排烟风机停.TabIndex = 28;
            button_排烟风机停.Text = "排烟风机停";
            button_排烟风机停.UseVisualStyleBackColor = true;
            button_排烟风机停.Click += Button_排烟风机停_Click;
            // 
            // button_打开风机总开
            // 
            button_打开风机总开.Location = new Point(550, 92);
            button_打开风机总开.Name = "button_打开风机总开";
            button_打开风机总开.Size = new Size(130, 30);
            button_打开风机总开.TabIndex = 29;
            button_打开风机总开.Text = "打开风机总开";
            button_打开风机总开.UseVisualStyleBackColor = true;
            button_打开风机总开.Click += Button_打开风机总开_Click;
            // 
            // button_关闭风机总开
            // 
            button_关闭风机总开.Location = new Point(686, 92);
            button_关闭风机总开.Name = "button_关闭风机总开";
            button_关闭风机总开.Size = new Size(130, 30);
            button_关闭风机总开.TabIndex = 30;
            button_关闭风机总开.Text = "关闭风机总开";
            button_关闭风机总开.UseVisualStyleBackColor = true;
            button_关闭风机总开.Click += Button_关闭风机总开_Click;
            // 
            // button_运行灯亮
            // 
            button_运行灯亮.Location = new Point(6, 128);
            button_运行灯亮.Name = "button_运行灯亮";
            button_运行灯亮.Size = new Size(130, 30);
            button_运行灯亮.TabIndex = 33;
            button_运行灯亮.Text = "运行灯亮";
            button_运行灯亮.UseVisualStyleBackColor = true;
            button_运行灯亮.Click += Button_运行灯亮_Click;
            // 
            // button_运行灯灭
            // 
            button_运行灯灭.Location = new Point(142, 128);
            button_运行灯灭.Name = "button_运行灯灭";
            button_运行灯灭.Size = new Size(130, 30);
            button_运行灯灭.TabIndex = 34;
            button_运行灯灭.Text = "运行灯灭";
            button_运行灯灭.UseVisualStyleBackColor = true;
            button_运行灯灭.Click += Button_运行灯灭_Click;
            // 
            // button_电磁锁打开
            // 
            button_电磁锁打开.Location = new Point(278, 128);
            button_电磁锁打开.Name = "button_电磁锁打开";
            button_电磁锁打开.Size = new Size(130, 30);
            button_电磁锁打开.TabIndex = 35;
            button_电磁锁打开.Text = "电磁锁打开";
            button_电磁锁打开.UseVisualStyleBackColor = true;
            button_电磁锁打开.Click += Button_电磁锁打开_Click;
            // 
            // button_电磁锁关闭
            // 
            button_电磁锁关闭.Location = new Point(414, 128);
            button_电磁锁关闭.Name = "button_电磁锁关闭";
            button_电磁锁关闭.Size = new Size(130, 30);
            button_电磁锁关闭.TabIndex = 36;
            button_电磁锁关闭.Text = "电磁锁关闭";
            button_电磁锁关闭.UseVisualStyleBackColor = true;
            button_电磁锁关闭.Click += Button_电磁锁关闭_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button14);
            groupBox1.Controls.Add(button15);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button11);
            groupBox1.Controls.Add(button12);
            groupBox1.Controls.Add(button13);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button_异常启动关闭);
            groupBox1.Controls.Add(button_异常启动打开);
            groupBox1.Controls.Add(button_水冷电磁阀关闭);
            groupBox1.Controls.Add(button_水冷电磁阀打开);
            groupBox1.Controls.Add(button_气缸闭合);
            groupBox1.Controls.Add(button_运行灯亮);
            groupBox1.Controls.Add(button_逆变器断电);
            groupBox1.Controls.Add(button_运行灯灭);
            groupBox1.Controls.Add(button_逆变器上电);
            groupBox1.Controls.Add(button_电磁锁打开);
            groupBox1.Controls.Add(button_气缸张开);
            groupBox1.Controls.Add(button_电磁锁关闭);
            groupBox1.Controls.Add(button_打开风机总开);
            groupBox1.Controls.Add(button_关闭风机总开);
            groupBox1.Controls.Add(button_蜂鸣器关闭M);
            groupBox1.Controls.Add(button_蜂鸣器打开M);
            groupBox1.Controls.Add(button_下针床风机转);
            groupBox1.Controls.Add(button_下针床风机停);
            groupBox1.Controls.Add(button_排烟风机转);
            groupBox1.Controls.Add(button_排烟风机停);
            groupBox1.Controls.Add(button_自动门落下);
            groupBox1.Controls.Add(button_自动门张开);
            groupBox1.Controls.Add(button_校正工装断电);
            groupBox1.Controls.Add(button_上针床风机转);
            groupBox1.Controls.Add(button_校正工装供电);
            groupBox1.Controls.Add(button_上针床风机停);
            groupBox1.Location = new Point(602, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 331);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "数字量输出测试区（手动模式）";
            // 
            // button14
            // 
            button14.Location = new Point(686, 128);
            button14.Name = "button14";
            button14.Size = new Size(130, 30);
            button14.TabIndex = 54;
            button14.Text = "水冷风机 总 停";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Button_水冷风机总停_Click;
            // 
            // button15
            // 
            button15.Location = new Point(550, 128);
            button15.Name = "button15";
            button15.Size = new Size(130, 30);
            button15.TabIndex = 53;
            button15.Text = "水冷风机 总 转";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Button_水冷风机总转_Click;
            // 
            // button10
            // 
            button10.Location = new Point(686, 200);
            button10.Name = "button10";
            button10.Size = new Size(130, 30);
            button10.TabIndex = 52;
            button10.Tag = "6";
            button10.Text = "水冷风机 6 停\r\n";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Button_水冷风机停_Click;
            // 
            // button11
            // 
            button11.Location = new Point(550, 200);
            button11.Name = "button11";
            button11.Size = new Size(130, 30);
            button11.TabIndex = 51;
            button11.Tag = "6";
            button11.Text = "水冷风机 6 转";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Button_水冷风机转_Click;
            // 
            // button12
            // 
            button12.Location = new Point(414, 200);
            button12.Name = "button12";
            button12.Size = new Size(130, 30);
            button12.TabIndex = 50;
            button12.Tag = "5";
            button12.Text = "水冷风机 5 停\r\n";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Button_水冷风机停_Click;
            // 
            // button13
            // 
            button13.Location = new Point(278, 200);
            button13.Name = "button13";
            button13.Size = new Size(130, 30);
            button13.TabIndex = 49;
            button13.Tag = "5";
            button13.Text = "水冷风机 5 转";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Button_水冷风机转_Click;
            // 
            // button6
            // 
            button6.Location = new Point(142, 200);
            button6.Name = "button6";
            button6.Size = new Size(130, 30);
            button6.TabIndex = 48;
            button6.Tag = "4";
            button6.Text = "水冷风机 4 停\r\n";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_水冷风机停_Click;
            // 
            // button7
            // 
            button7.Location = new Point(6, 200);
            button7.Name = "button7";
            button7.Size = new Size(130, 30);
            button7.TabIndex = 47;
            button7.Tag = "4";
            button7.Text = "水冷风机 4 转";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button_水冷风机转_Click;
            // 
            // button8
            // 
            button8.Location = new Point(686, 164);
            button8.Name = "button8";
            button8.Size = new Size(130, 30);
            button8.TabIndex = 46;
            button8.Tag = "3";
            button8.Text = "水冷风机 3 停\r\n";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_水冷风机停_Click;
            // 
            // button9
            // 
            button9.Location = new Point(550, 164);
            button9.Name = "button9";
            button9.Size = new Size(130, 30);
            button9.TabIndex = 45;
            button9.Tag = "3";
            button9.Text = "水冷风机 3 转";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_水冷风机转_Click;
            // 
            // button2
            // 
            button2.Location = new Point(414, 164);
            button2.Name = "button2";
            button2.Size = new Size(130, 30);
            button2.TabIndex = 44;
            button2.Tag = "2";
            button2.Text = "水冷风机 2 停\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_水冷风机停_Click;
            // 
            // button3
            // 
            button3.Location = new Point(278, 164);
            button3.Name = "button3";
            button3.Size = new Size(130, 30);
            button3.TabIndex = 43;
            button3.Tag = "2";
            button3.Text = "水冷风机 2 转";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_水冷风机转_Click;
            // 
            // button4
            // 
            button4.Location = new Point(142, 164);
            button4.Name = "button4";
            button4.Size = new Size(130, 30);
            button4.TabIndex = 42;
            button4.Tag = "1";
            button4.Text = "水冷风机 1 停\r\n";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_水冷风机停_Click;
            // 
            // button5
            // 
            button5.Location = new Point(6, 164);
            button5.Name = "button5";
            button5.Size = new Size(130, 30);
            button5.TabIndex = 41;
            button5.Tag = "1";
            button5.Text = "水冷风机 1 转\r\n";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_水冷风机转_Click;
            // 
            // button_异常启动关闭
            // 
            button_异常启动关闭.Location = new Point(417, 236);
            button_异常启动关闭.Name = "button_异常启动关闭";
            button_异常启动关闭.Size = new Size(130, 30);
            button_异常启动关闭.TabIndex = 40;
            button_异常启动关闭.Text = "异常启动关闭";
            button_异常启动关闭.UseVisualStyleBackColor = true;
            button_异常启动关闭.Click += Button_异常启动关闭_Click;
            // 
            // button_异常启动打开
            // 
            button_异常启动打开.Location = new Point(281, 236);
            button_异常启动打开.Name = "button_异常启动打开";
            button_异常启动打开.Size = new Size(130, 30);
            button_异常启动打开.TabIndex = 39;
            button_异常启动打开.Text = "异常启动打开";
            button_异常启动打开.UseVisualStyleBackColor = true;
            button_异常启动打开.Click += Button_异常启动打开_Click;
            // 
            // button_水冷电磁阀关闭
            // 
            button_水冷电磁阀关闭.Location = new Point(145, 236);
            button_水冷电磁阀关闭.Name = "button_水冷电磁阀关闭";
            button_水冷电磁阀关闭.Size = new Size(130, 30);
            button_水冷电磁阀关闭.TabIndex = 38;
            button_水冷电磁阀关闭.Text = "水冷电磁阀关闭";
            button_水冷电磁阀关闭.UseVisualStyleBackColor = true;
            button_水冷电磁阀关闭.Click += Button_水冷电磁阀关闭_Click;
            // 
            // button_水冷电磁阀打开
            // 
            button_水冷电磁阀打开.Location = new Point(9, 236);
            button_水冷电磁阀打开.Name = "button_水冷电磁阀打开";
            button_水冷电磁阀打开.Size = new Size(130, 30);
            button_水冷电磁阀打开.TabIndex = 37;
            button_水冷电磁阀打开.Text = "水冷电磁阀打开";
            button_水冷电磁阀打开.UseVisualStyleBackColor = true;
            button_水冷电磁阀打开.Click += Button_水冷电磁阀打开_Click;
            // 
            // button19
            // 
            button19.Dock = DockStyle.Top;
            button19.Location = new Point(3, 57);
            button19.Name = "button19";
            button19.Size = new Size(191, 30);
            button19.TabIndex = 83;
            button19.Text = "水冷系统流量阀开度";
            button19.UseVisualStyleBackColor = true;
            button19.Click += Button19_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(3, 19);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(149, 16);
            label8.TabIndex = 81;
            label8.Text = "水冷系统流量阀开度（%）：";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Cursor = Cursors.IBeam;
            uiTextBox1.Dock = DockStyle.Top;
            uiTextBox1.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(3, 35);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Size = new Size(191, 22);
            uiTextBox1.TabIndex = 78;
            uiTextBox1.Text = "60";
            // 
            // button_上位机不报警
            // 
            button_上位机不报警.Location = new Point(414, 20);
            button_上位机不报警.Name = "button_上位机不报警";
            button_上位机不报警.Size = new Size(130, 30);
            button_上位机不报警.TabIndex = 44;
            button_上位机不报警.Text = "上位机不报警";
            button_上位机不报警.UseVisualStyleBackColor = true;
            button_上位机不报警.Click += Button_上位机不报警_Click;
            // 
            // button_上位机报警
            // 
            button_上位机报警.Location = new Point(278, 20);
            button_上位机报警.Name = "button_上位机报警";
            button_上位机报警.Size = new Size(130, 30);
            button_上位机报警.TabIndex = 43;
            button_上位机报警.Text = "上位机报警";
            button_上位机报警.UseVisualStyleBackColor = true;
            button_上位机报警.Click += Button_上位机报警_Click;
            // 
            // button_系统停止
            // 
            button_系统停止.Location = new Point(142, 20);
            button_系统停止.Name = "button_系统停止";
            button_系统停止.Size = new Size(130, 30);
            button_系统停止.TabIndex = 42;
            button_系统停止.Text = "系统停止";
            button_系统停止.UseVisualStyleBackColor = true;
            button_系统停止.Click += Button_系统停止_Click;
            // 
            // button_系统启动
            // 
            button_系统启动.Location = new Point(6, 20);
            button_系统启动.Name = "button_系统启动";
            button_系统启动.Size = new Size(130, 30);
            button_系统启动.TabIndex = 41;
            button_系统启动.Text = "系统启动";
            button_系统启动.UseVisualStyleBackColor = true;
            button_系统启动.Click += Button_系统启动_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button18);
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(button17);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button_进入手动模式);
            groupBox2.Controls.Add(button_退出手动模式);
            groupBox2.Controls.Add(button_蜂鸣器打开A);
            groupBox2.Controls.Add(button_蜂鸣器关闭A);
            groupBox2.Controls.Add(button_报警清除);
            groupBox2.Controls.Add(button_异常断电);
            groupBox2.Controls.Add(button_掉电恢复);
            groupBox2.Controls.Add(button_掉电清除);
            groupBox2.Controls.Add(button_系统启动);
            groupBox2.Controls.Add(button_上位机不报警);
            groupBox2.Controls.Add(button_系统停止);
            groupBox2.Controls.Add(button_上位机报警);
            groupBox2.Location = new Point(602, 349);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(826, 396);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "其他";
            // 
            // groupBox7
            // 
            groupBox7.AutoSize = true;
            groupBox7.Controls.Add(button19);
            groupBox7.Controls.Add(uiTextBox1);
            groupBox7.Controls.Add(label8);
            groupBox7.Location = new Point(414, 187);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(197, 90);
            groupBox7.TabIndex = 96;
            groupBox7.TabStop = false;
            groupBox7.Text = "水冷系统流量阀开度";
            // 
            // groupBox6
            // 
            groupBox6.AutoSize = true;
            groupBox6.Controls.Add(button21);
            groupBox6.Controls.Add(TextBox_水冷系统控制温度);
            groupBox6.Controls.Add(label12);
            groupBox6.Location = new Point(414, 92);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(197, 90);
            groupBox6.TabIndex = 95;
            groupBox6.TabStop = false;
            groupBox6.Text = "水冷系统控制温度";
            // 
            // button21
            // 
            button21.Dock = DockStyle.Top;
            button21.Location = new Point(3, 57);
            button21.Name = "button21";
            button21.Size = new Size(191, 30);
            button21.TabIndex = 85;
            button21.Text = "水冷系统控制温度";
            button21.UseVisualStyleBackColor = true;
            button21.Click += Button21_Click;
            // 
            // TextBox_水冷系统控制温度
            // 
            TextBox_水冷系统控制温度.Cursor = Cursors.IBeam;
            TextBox_水冷系统控制温度.Dock = DockStyle.Top;
            TextBox_水冷系统控制温度.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_水冷系统控制温度.Location = new Point(3, 35);
            TextBox_水冷系统控制温度.Margin = new Padding(4, 5, 4, 5);
            TextBox_水冷系统控制温度.MinimumSize = new Size(1, 16);
            TextBox_水冷系统控制温度.Name = "TextBox_水冷系统控制温度";
            TextBox_水冷系统控制温度.Size = new Size(191, 22);
            TextBox_水冷系统控制温度.TabIndex = 83;
            TextBox_水冷系统控制温度.Text = "25";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Top;
            label12.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ImeMode = ImeMode.NoControl;
            label12.Location = new Point(3, 19);
            label12.Margin = new Padding(0);
            label12.Name = "label12";
            label12.Size = new Size(172, 16);
            label12.TabIndex = 84;
            label12.Text = "水冷系统控制温度目标值（℃）：";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.Controls.Add(button16);
            groupBox5.Controls.Add(TextBox_time);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(TextBox_KdValue);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(TextBox_KiValue);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(TextBox_KpValue);
            groupBox5.Controls.Add(label4);
            groupBox5.Location = new Point(209, 92);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(197, 204);
            groupBox5.TabIndex = 94;
            groupBox5.TabStop = false;
            groupBox5.Text = "水冷 PID 控制参数";
            // 
            // button16
            // 
            button16.Dock = DockStyle.Top;
            button16.Location = new Point(3, 171);
            button16.Name = "button16";
            button16.Size = new Size(191, 30);
            button16.TabIndex = 68;
            button16.Text = "水冷 PID 控制参数";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Button16_Click;
            // 
            // TextBox_time
            // 
            TextBox_time.Cursor = Cursors.IBeam;
            TextBox_time.Dock = DockStyle.Top;
            TextBox_time.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_time.Location = new Point(3, 149);
            TextBox_time.Margin = new Padding(4, 5, 4, 5);
            TextBox_time.MinimumSize = new Size(1, 16);
            TextBox_time.Name = "TextBox_time";
            TextBox_time.Size = new Size(191, 22);
            TextBox_time.TabIndex = 72;
            TextBox_time.Text = "2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(3, 133);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(98, 16);
            label7.TabIndex = 76;
            label7.Text = "调节周期 T（s）：";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Click += Label7_Click;
            // 
            // TextBox_KdValue
            // 
            TextBox_KdValue.Cursor = Cursors.IBeam;
            TextBox_KdValue.Dock = DockStyle.Top;
            TextBox_KdValue.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_KdValue.Location = new Point(3, 111);
            TextBox_KdValue.Margin = new Padding(4, 5, 4, 5);
            TextBox_KdValue.MinimumSize = new Size(1, 16);
            TextBox_KdValue.Name = "TextBox_KdValue";
            TextBox_KdValue.Size = new Size(191, 22);
            TextBox_KdValue.TabIndex = 69;
            TextBox_KdValue.Text = "0.10";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(3, 95);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(79, 16);
            label6.TabIndex = 75;
            label6.Text = "Kd 微分系数：";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBox_KiValue
            // 
            TextBox_KiValue.Cursor = Cursors.IBeam;
            TextBox_KiValue.Dock = DockStyle.Top;
            TextBox_KiValue.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_KiValue.Location = new Point(3, 73);
            TextBox_KiValue.Margin = new Padding(4, 5, 4, 5);
            TextBox_KiValue.MinimumSize = new Size(1, 16);
            TextBox_KiValue.Name = "TextBox_KiValue";
            TextBox_KiValue.Size = new Size(191, 22);
            TextBox_KiValue.TabIndex = 70;
            TextBox_KiValue.Text = "0.05";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(3, 57);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 74;
            label5.Text = "Ki 积分系数：";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBox_KpValue
            // 
            TextBox_KpValue.Cursor = Cursors.IBeam;
            TextBox_KpValue.Dock = DockStyle.Top;
            TextBox_KpValue.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_KpValue.Location = new Point(3, 35);
            TextBox_KpValue.Margin = new Padding(4, 5, 4, 5);
            TextBox_KpValue.MinimumSize = new Size(1, 16);
            TextBox_KpValue.Name = "TextBox_KpValue";
            TextBox_KpValue.Size = new Size(191, 22);
            TextBox_KpValue.TabIndex = 71;
            TextBox_KpValue.Text = "6.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(3, 19);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(79, 16);
            label4.TabIndex = 73;
            label4.Text = "Kp 比例系数：";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            groupBox4.AutoSize = true;
            groupBox4.Controls.Add(button_报警参数);
            groupBox4.Controls.Add(TextBox_ASmogLimit);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(TextBox_ACellTempLimit);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(TextBox_ATempLimit);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(6, 92);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(197, 166);
            groupBox4.TabIndex = 93;
            groupBox4.TabStop = false;
            groupBox4.Text = "报警参数";
            // 
            // button_报警参数
            // 
            button_报警参数.Dock = DockStyle.Top;
            button_报警参数.Location = new Point(3, 133);
            button_报警参数.Name = "button_报警参数";
            button_报警参数.Size = new Size(191, 30);
            button_报警参数.TabIndex = 54;
            button_报警参数.Text = "报警参数";
            button_报警参数.UseVisualStyleBackColor = true;
            button_报警参数.Click += Button_报警参数_Click;
            // 
            // TextBox_ASmogLimit
            // 
            TextBox_ASmogLimit.Cursor = Cursors.IBeam;
            TextBox_ASmogLimit.Dock = DockStyle.Top;
            TextBox_ASmogLimit.Enabled = false;
            TextBox_ASmogLimit.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_ASmogLimit.Location = new Point(3, 111);
            TextBox_ASmogLimit.Margin = new Padding(4, 5, 4, 5);
            TextBox_ASmogLimit.MinimumSize = new Size(1, 16);
            TextBox_ASmogLimit.Name = "TextBox_ASmogLimit";
            TextBox_ASmogLimit.Size = new Size(191, 22);
            TextBox_ASmogLimit.TabIndex = 3;
            TextBox_ASmogLimit.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Enabled = false;
            label3.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(3, 95);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(91, 16);
            label3.TabIndex = 66;
            label3.Text = "烟雾报警值(PM):";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBox_ACellTempLimit
            // 
            TextBox_ACellTempLimit.Cursor = Cursors.IBeam;
            TextBox_ACellTempLimit.Dock = DockStyle.Top;
            TextBox_ACellTempLimit.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_ACellTempLimit.Location = new Point(3, 73);
            TextBox_ACellTempLimit.Margin = new Padding(4, 5, 4, 5);
            TextBox_ACellTempLimit.MinimumSize = new Size(1, 16);
            TextBox_ACellTempLimit.Name = "TextBox_ACellTempLimit";
            TextBox_ACellTempLimit.Size = new Size(191, 22);
            TextBox_ACellTempLimit.TabIndex = 3;
            TextBox_ACellTempLimit.Text = "70";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(3, 57);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(106, 16);
            label2.TabIndex = 65;
            label2.Text = "电池温度报警值(℃):";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBox_ATempLimit
            // 
            TextBox_ATempLimit.Cursor = Cursors.IBeam;
            TextBox_ATempLimit.Dock = DockStyle.Top;
            TextBox_ATempLimit.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_ATempLimit.Location = new Point(3, 35);
            TextBox_ATempLimit.Margin = new Padding(4, 5, 4, 5);
            TextBox_ATempLimit.MinimumSize = new Size(1, 16);
            TextBox_ATempLimit.Name = "TextBox_ATempLimit";
            TextBox_ATempLimit.Size = new Size(191, 22);
            TextBox_ATempLimit.TabIndex = 57;
            TextBox_ATempLimit.Text = "60";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(3, 19);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(106, 16);
            label1.TabIndex = 64;
            label1.Text = "机构温度报警值(℃):";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox_ShieldedFireDoorSensor);
            groupBox3.Controls.Add(button_ShieldedSensor);
            groupBox3.Location = new Point(686, 92);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(130, 87);
            groupBox3.TabIndex = 92;
            groupBox3.TabStop = false;
            groupBox3.Text = "屏蔽传感器检测";
            // 
            // checkBox_ShieldedFireDoorSensor
            // 
            checkBox_ShieldedFireDoorSensor.AutoSize = true;
            checkBox_ShieldedFireDoorSensor.Location = new Point(6, 22);
            checkBox_ShieldedFireDoorSensor.Name = "checkBox_ShieldedFireDoorSensor";
            checkBox_ShieldedFireDoorSensor.Size = new Size(63, 21);
            checkBox_ShieldedFireDoorSensor.TabIndex = 91;
            checkBox_ShieldedFireDoorSensor.Text = "安全门";
            checkBox_ShieldedFireDoorSensor.UseVisualStyleBackColor = true;
            // 
            // button_ShieldedSensor
            // 
            button_ShieldedSensor.Location = new Point(6, 49);
            button_ShieldedSensor.Name = "button_ShieldedSensor";
            button_ShieldedSensor.Size = new Size(118, 30);
            button_ShieldedSensor.TabIndex = 90;
            button_ShieldedSensor.Text = "屏蔽传感器检测";
            button_ShieldedSensor.UseVisualStyleBackColor = true;
            button_ShieldedSensor.Click += Button_ShieldedSensor_Click;
            // 
            // button17
            // 
            button17.Location = new Point(686, 251);
            button17.Name = "button17";
            button17.Size = new Size(130, 30);
            button17.TabIndex = 77;
            button17.Text = "结果数据";
            button17.UseVisualStyleBackColor = true;
            button17.Click += Button17_Click;
            // 
            // button1
            // 
            button1.Location = new Point(686, 180);
            button1.Name = "button1";
            button1.Size = new Size(130, 67);
            button1.TabIndex = 67;
            button1.Text = "初始化";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button_进入手动模式
            // 
            button_进入手动模式.Location = new Point(278, 56);
            button_进入手动模式.Name = "button_进入手动模式";
            button_进入手动模式.Size = new Size(130, 30);
            button_进入手动模式.TabIndex = 52;
            button_进入手动模式.Text = "进入手动模式";
            button_进入手动模式.UseVisualStyleBackColor = true;
            button_进入手动模式.Click += Button_进入手动模式_Click;
            // 
            // button_退出手动模式
            // 
            button_退出手动模式.Location = new Point(414, 56);
            button_退出手动模式.Name = "button_退出手动模式";
            button_退出手动模式.Size = new Size(130, 30);
            button_退出手动模式.TabIndex = 51;
            button_退出手动模式.Text = "退出手动模式";
            button_退出手动模式.UseVisualStyleBackColor = true;
            button_退出手动模式.Click += Button_退出手动模式_Click;
            // 
            // button_蜂鸣器打开A
            // 
            button_蜂鸣器打开A.Enabled = false;
            button_蜂鸣器打开A.Location = new Point(550, 56);
            button_蜂鸣器打开A.Name = "button_蜂鸣器打开A";
            button_蜂鸣器打开A.Size = new Size(130, 30);
            button_蜂鸣器打开A.TabIndex = 50;
            button_蜂鸣器打开A.Text = "蜂鸣器打开A";
            button_蜂鸣器打开A.UseVisualStyleBackColor = true;
            button_蜂鸣器打开A.Click += Button_蜂鸣器打开A_Click;
            // 
            // button_蜂鸣器关闭A
            // 
            button_蜂鸣器关闭A.Enabled = false;
            button_蜂鸣器关闭A.Location = new Point(686, 56);
            button_蜂鸣器关闭A.Name = "button_蜂鸣器关闭A";
            button_蜂鸣器关闭A.Size = new Size(130, 30);
            button_蜂鸣器关闭A.TabIndex = 49;
            button_蜂鸣器关闭A.Text = "蜂鸣器关闭A";
            button_蜂鸣器关闭A.UseVisualStyleBackColor = true;
            button_蜂鸣器关闭A.Click += Button_蜂鸣器关闭A_Click;
            // 
            // button_报警清除
            // 
            button_报警清除.Location = new Point(550, 20);
            button_报警清除.Name = "button_报警清除";
            button_报警清除.Size = new Size(130, 30);
            button_报警清除.TabIndex = 45;
            button_报警清除.Text = "报警清除";
            button_报警清除.UseVisualStyleBackColor = true;
            button_报警清除.Click += Button_报警清除_Click;
            // 
            // button_异常断电
            // 
            button_异常断电.Location = new Point(142, 56);
            button_异常断电.Name = "button_异常断电";
            button_异常断电.Size = new Size(130, 30);
            button_异常断电.TabIndex = 48;
            button_异常断电.Text = "异常断电";
            button_异常断电.UseVisualStyleBackColor = true;
            button_异常断电.Click += Button_异常断电_Click;
            // 
            // button_掉电恢复
            // 
            button_掉电恢复.Location = new Point(686, 20);
            button_掉电恢复.Name = "button_掉电恢复";
            button_掉电恢复.Size = new Size(130, 30);
            button_掉电恢复.TabIndex = 46;
            button_掉电恢复.Text = "掉电恢复";
            button_掉电恢复.UseVisualStyleBackColor = true;
            button_掉电恢复.Click += Button_掉电恢复_Click;
            // 
            // button_掉电清除
            // 
            button_掉电清除.Location = new Point(6, 56);
            button_掉电清除.Name = "button_掉电清除";
            button_掉电清除.Size = new Size(130, 30);
            button_掉电清除.TabIndex = 47;
            button_掉电清除.Text = "掉电清除";
            button_掉电清除.UseVisualStyleBackColor = true;
            button_掉电清除.Click += Button_掉电清除_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(304, 12);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(286, 733);
            richTextBox2.TabIndex = 46;
            richTextBox2.Text = "";
            // 
            // button18
            // 
            button18.Location = new Point(686, 287);
            button18.Name = "button18";
            button18.Size = new Size(130, 30);
            button18.TabIndex = 97;
            button18.Text = "数据上传";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // FormDebug
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1440, 757);
            Controls.Add(richTextBox2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDebug";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Debug";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_气缸闭合;
        private Button button_气缸张开;
        private Button button_逆变器上电;
        private Button button_逆变器断电;
        private Button button_蜂鸣器打开M;
        private Button button_蜂鸣器关闭M;
        private Button button_校正工装供电;
        private Button button_校正工装断电;
        private Button button_自动门落下;
        private Button button_自动门张开;
        private Button button_上针床风机转;
        private Button button_上针床风机停;
        private Button button_下针床风机转;
        private Button button_下针床风机停;
        private Button button_排烟风机转;
        private Button button_排烟风机停;
        private Button button_打开风机总开;
        private Button button_关闭风机总开;
        private Button button_运行灯亮;
        private Button button_运行灯灭;
        private Button button_电磁锁打开;
        private Button button_电磁锁关闭;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private Button button_异常启动关闭;
        private Button button_异常启动打开;
        private Button button_水冷电磁阀关闭;
        private Button button_水冷电磁阀打开;
        private Button button_上位机不报警;
        private Button button_上位机报警;
        private Button button_系统停止;
        private Button button_系统启动;
        private GroupBox groupBox2;
        private Button button_报警清除;
        private Button button_异常断电;
        private Button button_掉电恢复;
        private Button button_掉电清除;
        private Button button_报警参数;
        private Button button_进入手动模式;
        private Button button_退出手动模式;
        private Button button_蜂鸣器打开A;
        private Button button_蜂鸣器关闭A;
        private TextBox TextBox_ASmogLimit;
        private TextBox TextBox_ACellTempLimit;
        private TextBox TextBox_ATempLimit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button14;
        private Button button15;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox TextBox_time;
        private TextBox TextBox_KdValue;
        private TextBox TextBox_KiValue;
        private TextBox TextBox_KpValue;
        private Button button16;
        private Button button17;
        private Button button19;
        private Label label8;
        private TextBox uiTextBox1;
        private Button button21;
        private Label label12;
        private TextBox TextBox_水冷系统控制温度;
        private Button button_ShieldedSensor;
        private GroupBox groupBox3;
        private CheckBox checkBox_ShieldedFireDoorSensor;
        private RichTextBox richTextBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Button button18;
    }
}