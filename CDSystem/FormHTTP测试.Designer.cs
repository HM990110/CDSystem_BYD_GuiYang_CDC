namespace CDSystem
{
    partial class FormHTTP测试
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            richTextBox1 = new RichTextBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(571, 12);
            button1.Name = "button1";
            button1.Size = new Size(217, 56);
            button1.TabIndex = 0;
            button1.Text = "NotifyCellWorkState\r\n检测柜推送货位状态";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(571, 74);
            button2.Name = "button2";
            button2.Size = new Size(217, 56);
            button2.TabIndex = 1;
            button2.Text = "RequetWarehouseCellBingAsset\r\n检测柜获取托盘电池信息";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(571, 136);
            button3.Name = "button3";
            button3.Size = new Size(217, 56);
            button3.TabIndex = 2;
            button3.Text = "UploadWarehouseTestResult\r\n检测柜调⽤WMS接⼝上传结果";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(571, 198);
            button4.Name = "button4";
            button4.Size = new Size(217, 56);
            button4.TabIndex = 3;
            button4.Text = "NotifyWMSStandingFireAlarm\r\n调⽤⽕警报警接⼝";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(571, 260);
            button5.Name = "button5";
            button5.Size = new Size(217, 56);
            button5.TabIndex = 4;
            button5.Text = "NotifyCellFinishTest\r\n检测柜调⽤WMS获取货位任务是否完成";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(553, 426);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button6
            // 
            button6.Location = new Point(571, 322);
            button6.Name = "button6";
            button6.Size = new Size(217, 56);
            button6.TabIndex = 6;
            button6.Text = "RequestReleasePull\r\n检测柜通知脱开针床";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(616, 397);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(697, 397);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 8;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button8_Click;
            // 
            // FormHTTP测试
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(richTextBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormHTTP测试";
            Text = "FormHTTP测试";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private RichTextBox richTextBox1;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}