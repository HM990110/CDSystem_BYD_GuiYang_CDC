namespace CDSystem.系统设置
{
    partial class UC参数设置
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView_Device = new DataGridView();
            Col设备ID = new DataGridViewTextBoxColumn();
            ColIP地址 = new DataGridViewTextBoxColumn();
            Col设备类型 = new DataGridViewComboBoxColumn();
            Col设备启用 = new DataGridViewCheckBoxColumn();
            Col自动模式 = new DataGridViewCheckBoxColumn();
            Col机构温度报警值 = new DataGridViewTextBoxColumn();
            Col电池温度报警值 = new DataGridViewTextBoxColumn();
            Col水冷Kp比例系数 = new DataGridViewTextBoxColumn();
            Col水冷Ki积分系数 = new DataGridViewTextBoxColumn();
            Col水冷Kd微分系数 = new DataGridViewTextBoxColumn();
            Col水冷调节周期T = new DataGridViewTextBoxColumn();
            Col水冷控制目标温度 = new DataGridViewTextBoxColumn();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ButtonCDC2 = new Button();
            ButtonCDC3 = new Button();
            buttonVacancyNo = new Button();
            buttonVacancy = new Button();
            buttonManualFlag = new Button();
            buttonAutoFlag = new Button();
            buttonIP = new Button();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Label_NOCellchannelVolt = new Label();
            Button_NOCellchannelVolt = new Button();
            NumericUpDown_NOCellchannelVolt = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            button7 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Device).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown_NOCellchannelVolt).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Device
            // 
            dataGridView_Device.AllowUserToAddRows = false;
            dataGridView_Device.AllowUserToDeleteRows = false;
            dataGridView_Device.AllowUserToResizeColumns = false;
            dataGridView_Device.AllowUserToResizeRows = false;
            dataGridView_Device.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Device.BackgroundColor = Color.White;
            dataGridView_Device.BorderStyle = BorderStyle.Fixed3D;
            dataGridView_Device.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridView_Device.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Device.ColumnHeadersHeight = 30;
            dataGridView_Device.Columns.AddRange(new DataGridViewColumn[] { Col设备ID, ColIP地址, Col设备类型, Col设备启用, Col自动模式, Col机构温度报警值, Col电池温度报警值, Col水冷Kp比例系数, Col水冷Ki积分系数, Col水冷Kd微分系数, Col水冷调节周期T, Col水冷控制目标温度 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_Device.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_Device.Dock = DockStyle.Fill;
            dataGridView_Device.EnableHeadersVisualStyles = false;
            dataGridView_Device.Location = new Point(0, 0);
            dataGridView_Device.Name = "dataGridView_Device";
            dataGridView_Device.RowHeadersVisible = false;
            dataGridView_Device.RowTemplate.Height = 25;
            dataGridView_Device.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_Device.Size = new Size(1453, 638);
            dataGridView_Device.TabIndex = 8;
            dataGridView_Device.CellDoubleClick += DataGridView_Device_CellDoubleClick;
            // 
            // Col设备ID
            // 
            Col设备ID.HeaderText = "设备ID";
            Col设备ID.Name = "Col设备ID";
            Col设备ID.ReadOnly = true;
            // 
            // ColIP地址
            // 
            ColIP地址.HeaderText = "IP地址";
            ColIP地址.Name = "ColIP地址";
            ColIP地址.ReadOnly = true;
            // 
            // Col设备类型
            // 
            Col设备类型.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            Col设备类型.HeaderText = "设备类型";
            Col设备类型.Items.AddRange(new object[] { "CDC2", "CDC3" });
            Col设备类型.Name = "Col设备类型";
            Col设备类型.Resizable = DataGridViewTriState.True;
            Col设备类型.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Col设备启用
            // 
            Col设备启用.HeaderText = "设备启用";
            Col设备启用.Name = "Col设备启用";
            // 
            // Col自动模式
            // 
            Col自动模式.HeaderText = "自动模式";
            Col自动模式.Name = "Col自动模式";
            // 
            // Col机构温度报警值
            // 
            Col机构温度报警值.HeaderText = "机构温度报警值(℃)";
            Col机构温度报警值.Name = "Col机构温度报警值";
            // 
            // Col电池温度报警值
            // 
            Col电池温度报警值.HeaderText = "电池温度报警值(℃)";
            Col电池温度报警值.Name = "Col电池温度报警值";
            // 
            // Col水冷Kp比例系数
            // 
            Col水冷Kp比例系数.HeaderText = "水冷 Kp 比例系数";
            Col水冷Kp比例系数.Name = "Col水冷Kp比例系数";
            // 
            // Col水冷Ki积分系数
            // 
            Col水冷Ki积分系数.HeaderText = "水冷 Ki 积分系数";
            Col水冷Ki积分系数.Name = "Col水冷Ki积分系数";
            // 
            // Col水冷Kd微分系数
            // 
            Col水冷Kd微分系数.HeaderText = "水冷 Kd 微分系数";
            Col水冷Kd微分系数.Name = "Col水冷Kd微分系数";
            // 
            // Col水冷调节周期T
            // 
            Col水冷调节周期T.HeaderText = "水冷 调节周期 T(s)";
            Col水冷调节周期T.Name = "Col水冷调节周期T";
            // 
            // Col水冷控制目标温度
            // 
            Col水冷控制目标温度.HeaderText = "水冷控制目标温度(℃)";
            Col水冷控制目标温度.Name = "Col水冷控制目标温度";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ButtonCDC2);
            flowLayoutPanel3.Controls.Add(ButtonCDC3);
            flowLayoutPanel3.Controls.Add(buttonVacancyNo);
            flowLayoutPanel3.Controls.Add(buttonVacancy);
            flowLayoutPanel3.Controls.Add(buttonManualFlag);
            flowLayoutPanel3.Controls.Add(buttonAutoFlag);
            flowLayoutPanel3.Controls.Add(buttonIP);
            flowLayoutPanel3.Controls.Add(panel1);
            flowLayoutPanel3.Dock = DockStyle.Bottom;
            flowLayoutPanel3.Location = new Point(0, 691);
            flowLayoutPanel3.Margin = new Padding(12);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1453, 56);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // ButtonCDC2
            // 
            ButtonCDC2.BackColor = Color.FromArgb(93, 198, 215);
            ButtonCDC2.Location = new Point(12, 12);
            ButtonCDC2.Margin = new Padding(12);
            ButtonCDC2.Name = "ButtonCDC2";
            ButtonCDC2.Size = new Size(100, 30);
            ButtonCDC2.TabIndex = 2;
            ButtonCDC2.Text = "全部CDC2";
            ButtonCDC2.UseVisualStyleBackColor = false;
            ButtonCDC2.Click += ButtonCDC2_Click;
            // 
            // ButtonCDC3
            // 
            ButtonCDC3.BackColor = Color.FromArgb(93, 198, 215);
            ButtonCDC3.Location = new Point(136, 12);
            ButtonCDC3.Margin = new Padding(12);
            ButtonCDC3.Name = "ButtonCDC3";
            ButtonCDC3.Size = new Size(100, 30);
            ButtonCDC3.TabIndex = 3;
            ButtonCDC3.Text = "全部CDC3";
            ButtonCDC3.UseVisualStyleBackColor = false;
            ButtonCDC3.Click += ButtonCDC3_Click;
            // 
            // buttonVacancyNo
            // 
            buttonVacancyNo.BackColor = Color.PaleGoldenrod;
            buttonVacancyNo.Location = new Point(260, 12);
            buttonVacancyNo.Margin = new Padding(12);
            buttonVacancyNo.Name = "buttonVacancyNo";
            buttonVacancyNo.Size = new Size(100, 30);
            buttonVacancyNo.TabIndex = 0;
            buttonVacancyNo.Text = "全部不启用";
            buttonVacancyNo.UseVisualStyleBackColor = false;
            buttonVacancyNo.Click += ButtonVacancyNo_Click;
            // 
            // buttonVacancy
            // 
            buttonVacancy.BackColor = Color.PaleGoldenrod;
            buttonVacancy.Location = new Point(384, 12);
            buttonVacancy.Margin = new Padding(12);
            buttonVacancy.Name = "buttonVacancy";
            buttonVacancy.Size = new Size(100, 30);
            buttonVacancy.TabIndex = 1;
            buttonVacancy.Text = "全部启用";
            buttonVacancy.UseVisualStyleBackColor = false;
            buttonVacancy.Click += ButtonVacancy_Click;
            // 
            // buttonManualFlag
            // 
            buttonManualFlag.BackColor = Color.PowderBlue;
            buttonManualFlag.Location = new Point(508, 12);
            buttonManualFlag.Margin = new Padding(12);
            buttonManualFlag.Name = "buttonManualFlag";
            buttonManualFlag.Size = new Size(100, 30);
            buttonManualFlag.TabIndex = 0;
            buttonManualFlag.Text = "全部手动";
            buttonManualFlag.UseVisualStyleBackColor = false;
            buttonManualFlag.Click += ButtonManualFlag_Click;
            // 
            // buttonAutoFlag
            // 
            buttonAutoFlag.BackColor = Color.PowderBlue;
            buttonAutoFlag.Location = new Point(632, 12);
            buttonAutoFlag.Margin = new Padding(12);
            buttonAutoFlag.Name = "buttonAutoFlag";
            buttonAutoFlag.Size = new Size(100, 30);
            buttonAutoFlag.TabIndex = 1;
            buttonAutoFlag.Text = "全部自动";
            buttonAutoFlag.UseVisualStyleBackColor = false;
            buttonAutoFlag.Click += ButtonAutoFlag_Click;
            // 
            // buttonIP
            // 
            buttonIP.BackColor = Color.BurlyWood;
            buttonIP.Location = new Point(756, 12);
            buttonIP.Margin = new Padding(12);
            buttonIP.Name = "buttonIP";
            buttonIP.Size = new Size(100, 30);
            buttonIP.TabIndex = 0;
            buttonIP.Text = "全部保存";
            buttonIP.UseVisualStyleBackColor = false;
            buttonIP.Click += ButtonIP_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new Point(880, 12);
            panel1.Margin = new Padding(12);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 32);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(Label_NOCellchannelVolt, 0, 0);
            tableLayoutPanel2.Controls.Add(Button_NOCellchannelVolt, 2, 0);
            tableLayoutPanel2.Controls.Add(NumericUpDown_NOCellchannelVolt, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(323, 29);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // Label_NOCellchannelVolt
            // 
            Label_NOCellchannelVolt.Anchor = AnchorStyles.Left;
            Label_NOCellchannelVolt.AutoSize = true;
            Label_NOCellchannelVolt.Location = new Point(3, 6);
            Label_NOCellchannelVolt.Name = "Label_NOCellchannelVolt";
            Label_NOCellchannelVolt.Size = new Size(155, 17);
            Label_NOCellchannelVolt.TabIndex = 14;
            Label_NOCellchannelVolt.Text = "无电池通道电压上限(mV)：";
            // 
            // Button_NOCellchannelVolt
            // 
            Button_NOCellchannelVolt.Location = new Point(246, 3);
            Button_NOCellchannelVolt.Name = "Button_NOCellchannelVolt";
            Button_NOCellchannelVolt.Size = new Size(75, 23);
            Button_NOCellchannelVolt.TabIndex = 16;
            Button_NOCellchannelVolt.Text = "保存";
            Button_NOCellchannelVolt.UseVisualStyleBackColor = true;
            Button_NOCellchannelVolt.Click += Button_NOCellchannelVolt_Click;
            // 
            // NumericUpDown_NOCellchannelVolt
            // 
            NumericUpDown_NOCellchannelVolt.Location = new Point(164, 3);
            NumericUpDown_NOCellchannelVolt.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            NumericUpDown_NOCellchannelVolt.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            NumericUpDown_NOCellchannelVolt.Name = "NumericUpDown_NOCellchannelVolt";
            NumericUpDown_NOCellchannelVolt.Size = new Size(76, 23);
            NumericUpDown_NOCellchannelVolt.TabIndex = 17;
            NumericUpDown_NOCellchannelVolt.TextAlign = HorizontalAlignment.Center;
            NumericUpDown_NOCellchannelVolt.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 13;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(button7, 5, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button5, 4, 0);
            tableLayoutPanel1.Controls.Add(button1, 7, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 638);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1453, 53);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.BackColor = Color.DeepPink;
            tableLayoutPanel1.SetColumnSpan(button7, 2);
            button7.Location = new Point(610, 5);
            button7.Margin = new Padding(5);
            button7.Name = "button7";
            button7.Size = new Size(232, 43);
            button7.TabIndex = 8;
            button7.Text = "保存（温度上限）";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Button7_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(93, 198, 215);
            button2.Location = new Point(126, 5);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(111, 43);
            button2.TabIndex = 3;
            button2.Text = "保存（IP）";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(93, 198, 215);
            button3.Location = new Point(247, 5);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(111, 43);
            button3.TabIndex = 4;
            button3.Text = "保存（设备类型）";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(93, 198, 215);
            button4.Location = new Point(368, 5);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(111, 43);
            button4.TabIndex = 5;
            button4.Text = "保存（设备启用）";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(93, 198, 215);
            button5.Location = new Point(489, 5);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(111, 43);
            button5.TabIndex = 6;
            button5.Text = "保存（设备自动）";
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.SkyBlue;
            tableLayoutPanel1.SetColumnSpan(button1, 5);
            button1.Location = new Point(852, 5);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(595, 43);
            button1.TabIndex = 4;
            button1.Text = "保存（温度控制）";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button8_Click;
            // 
            // UC参数设置
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView_Device);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel3);
            Name = "UC参数设置";
            Size = new Size(1453, 747);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Device).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown_NOCellchannelVolt).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView_Device;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button ButtonCDC2;
        private Button ButtonCDC3;
        private Button buttonVacancyNo;
        private Button buttonVacancy;
        private Button buttonManualFlag;
        private Button buttonAutoFlag;
        private Button buttonIP;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private DataGridViewTextBoxColumn Col设备ID;
        private DataGridViewTextBoxColumn ColIP地址;
        private DataGridViewComboBoxColumn Col设备类型;
        private DataGridViewCheckBoxColumn Col设备启用;
        private DataGridViewCheckBoxColumn Col自动模式;
        private DataGridViewTextBoxColumn Col机构温度报警值;
        private DataGridViewTextBoxColumn Col电池温度报警值;
        private DataGridViewTextBoxColumn Col水冷Kp比例系数;
        private DataGridViewTextBoxColumn Col水冷Ki积分系数;
        private DataGridViewTextBoxColumn Col水冷Kd微分系数;
        private DataGridViewTextBoxColumn Col水冷调节周期T;
        private DataGridViewTextBoxColumn Col水冷控制目标温度;
        private Button button7;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Button_NOCellchannelVolt;
        private Panel panel1;
        private TextBox textBox1;
        private Label Label_NOCellchannelVolt;
        private NumericUpDown NumericUpDown_NOCellchannelVolt;
    }
}
