namespace CDSystem.系统设置
{
    partial class UC关键器件运行记录
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
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox逆变器 = new GroupBox();
            dataGridView_InverterPower = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            groupBox探针 = new GroupBox();
            TableLayoutPanel_ProbeCount = new TableLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label5 = new Label();
            numericUpDown_Probe = new NumericUpDown();
            radioButton_ContactLimit = new RadioButton();
            radioButton_RunLimit = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton_NGLimit = new RadioButton();
            tableLayoutPanel6 = new TableLayoutPanel();
            Button_SaveNGCount = new Button();
            numericUpDown_ContactLimit = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown_RunLimit = new NumericUpDown();
            numericUpDown_ChannelNGLimit = new NumericUpDown();
            panel1 = new Panel();
            Button_DeviceAll = new Button();
            Button_ChannelOne = new Button();
            Button_DeviceOne = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label6 = new Label();
            comboBox_Device = new ComboBox();
            button2 = new Button();
            tableLayoutPanel2.SuspendLayout();
            groupBox逆变器.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_InverterPower).BeginInit();
            groupBox探针.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Probe).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ContactLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_RunLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ChannelNGLimit).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox逆变器, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox探针, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 32);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1902, 877);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox逆变器
            // 
            groupBox逆变器.Controls.Add(dataGridView_InverterPower);
            groupBox逆变器.Dock = DockStyle.Fill;
            groupBox逆变器.Location = new Point(3, 3);
            groupBox逆变器.Name = "groupBox逆变器";
            groupBox逆变器.Size = new Size(294, 871);
            groupBox逆变器.TabIndex = 0;
            groupBox逆变器.TabStop = false;
            groupBox逆变器.Text = "逆变器";
            // 
            // dataGridView_InverterPower
            // 
            dataGridView_InverterPower.AllowUserToAddRows = false;
            dataGridView_InverterPower.AllowUserToDeleteRows = false;
            dataGridView_InverterPower.AllowUserToResizeColumns = false;
            dataGridView_InverterPower.AllowUserToResizeRows = false;
            dataGridView_InverterPower.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_InverterPower.BackgroundColor = Color.White;
            dataGridView_InverterPower.BorderStyle = BorderStyle.None;
            dataGridView_InverterPower.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridView_InverterPower.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_InverterPower.ColumnHeadersHeight = 30;
            dataGridView_InverterPower.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_InverterPower.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_InverterPower.Dock = DockStyle.Fill;
            dataGridView_InverterPower.EnableHeadersVisualStyles = false;
            dataGridView_InverterPower.Location = new Point(3, 19);
            dataGridView_InverterPower.Name = "dataGridView_InverterPower";
            dataGridView_InverterPower.RowHeadersVisible = false;
            dataGridView_InverterPower.RowTemplate.Height = 25;
            dataGridView_InverterPower.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_InverterPower.Size = new Size(288, 849);
            dataGridView_InverterPower.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "工作时间";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // groupBox探针
            // 
            groupBox探针.Controls.Add(TableLayoutPanel_ProbeCount);
            groupBox探针.Controls.Add(flowLayoutPanel5);
            groupBox探针.Controls.Add(tableLayoutPanel6);
            groupBox探针.Controls.Add(panel1);
            groupBox探针.Dock = DockStyle.Fill;
            groupBox探针.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox探针.Location = new Point(303, 3);
            groupBox探针.Name = "groupBox探针";
            groupBox探针.Size = new Size(1596, 871);
            groupBox探针.TabIndex = 2;
            groupBox探针.TabStop = false;
            groupBox探针.Text = "探针";
            // 
            // TableLayoutPanel_ProbeCount
            // 
            TableLayoutPanel_ProbeCount.ColumnCount = 1;
            TableLayoutPanel_ProbeCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_ProbeCount.Dock = DockStyle.Fill;
            TableLayoutPanel_ProbeCount.Location = new Point(3, 89);
            TableLayoutPanel_ProbeCount.Name = "TableLayoutPanel_ProbeCount";
            TableLayoutPanel_ProbeCount.RowCount = 1;
            TableLayoutPanel_ProbeCount.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_ProbeCount.Size = new Size(1590, 679);
            TableLayoutPanel_ProbeCount.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(label5);
            flowLayoutPanel5.Controls.Add(numericUpDown_Probe);
            flowLayoutPanel5.Controls.Add(radioButton_ContactLimit);
            flowLayoutPanel5.Controls.Add(radioButton_RunLimit);
            flowLayoutPanel5.Controls.Add(radioButton1);
            flowLayoutPanel5.Controls.Add(radioButton_NGLimit);
            flowLayoutPanel5.Dock = DockStyle.Top;
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(3, 54);
            flowLayoutPanel5.Margin = new Padding(0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(1590, 35);
            flowLayoutPanel5.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(9, 9);
            label5.Margin = new Padding(9, 9, 0, 9);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 12;
            label5.Text = "通道选择：";
            // 
            // numericUpDown_Probe
            // 
            numericUpDown_Probe.Anchor = AnchorStyles.Left;
            numericUpDown_Probe.Location = new Point(77, 6);
            numericUpDown_Probe.Margin = new Padding(0, 6, 6, 6);
            numericUpDown_Probe.Maximum = new decimal(new int[] { 196, 0, 0, 0 });
            numericUpDown_Probe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Probe.Name = "numericUpDown_Probe";
            numericUpDown_Probe.Size = new Size(80, 23);
            numericUpDown_Probe.TabIndex = 10;
            numericUpDown_Probe.TextAlign = HorizontalAlignment.Center;
            numericUpDown_Probe.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // radioButton_ContactLimit
            // 
            radioButton_ContactLimit.AutoSize = true;
            radioButton_ContactLimit.Location = new Point(170, 7);
            radioButton_ContactLimit.Margin = new Padding(7);
            radioButton_ContactLimit.Name = "radioButton_ContactLimit";
            radioButton_ContactLimit.Size = new Size(74, 21);
            radioButton_ContactLimit.TabIndex = 0;
            radioButton_ContactLimit.Text = "压合次数";
            radioButton_ContactLimit.UseVisualStyleBackColor = true;
            radioButton_ContactLimit.Click += RadioButton_ContactLimit_Click;
            // 
            // radioButton_RunLimit
            // 
            radioButton_RunLimit.AutoSize = true;
            radioButton_RunLimit.Location = new Point(258, 7);
            radioButton_RunLimit.Margin = new Padding(7);
            radioButton_RunLimit.Name = "radioButton_RunLimit";
            radioButton_RunLimit.Size = new Size(86, 21);
            radioButton_RunLimit.TabIndex = 1;
            radioButton_RunLimit.Text = "充放电次数";
            radioButton_RunLimit.UseVisualStyleBackColor = true;
            radioButton_RunLimit.Click += RadioButton_ContactLimit_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(358, 7);
            radioButton1.Margin = new Padding(7);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(98, 21);
            radioButton1.TabIndex = 3;
            radioButton1.Text = "维修累计次数";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += RadioButton_ContactLimit_Click;
            // 
            // radioButton_NGLimit
            // 
            radioButton_NGLimit.AutoSize = true;
            radioButton_NGLimit.Checked = true;
            radioButton_NGLimit.Location = new Point(470, 7);
            radioButton_NGLimit.Margin = new Padding(7);
            radioButton_NGLimit.Name = "radioButton_NGLimit";
            radioButton_NGLimit.Size = new Size(69, 21);
            radioButton_NGLimit.TabIndex = 2;
            radioButton_NGLimit.TabStop = true;
            radioButton_NGLimit.Text = "NG次数";
            radioButton_NGLimit.UseVisualStyleBackColor = true;
            radioButton_NGLimit.Click += RadioButton_ContactLimit_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 7;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(numericUpDown_ContactLimit, 1, 0);
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Controls.Add(label4, 2, 0);
            tableLayoutPanel6.Controls.Add(numericUpDown_RunLimit, 3, 0);
            tableLayoutPanel6.Controls.Add(label3, 4, 0);
            tableLayoutPanel6.Controls.Add(numericUpDown_ChannelNGLimit, 5, 0);
            tableLayoutPanel6.Controls.Add(Button_SaveNGCount, 6, 0);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel6.Location = new Point(3, 19);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(1590, 35);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // Button_SaveNGCount
            // 
            Button_SaveNGCount.Anchor = AnchorStyles.Left;
            Button_SaveNGCount.Location = new Point(621, 2);
            Button_SaveNGCount.Margin = new Padding(2);
            Button_SaveNGCount.Name = "Button_SaveNGCount";
            Button_SaveNGCount.Size = new Size(75, 30);
            Button_SaveNGCount.TabIndex = 2;
            Button_SaveNGCount.Text = "保存";
            Button_SaveNGCount.UseVisualStyleBackColor = true;
            Button_SaveNGCount.Click += Button_SaveNGCount_Click;
            // 
            // numericUpDown_ContactLimit
            // 
            numericUpDown_ContactLimit.Anchor = AnchorStyles.Left;
            numericUpDown_ContactLimit.Location = new Point(125, 6);
            numericUpDown_ContactLimit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_ContactLimit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_ContactLimit.Name = "numericUpDown_ContactLimit";
            numericUpDown_ContactLimit.Size = new Size(80, 23);
            numericUpDown_ContactLimit.TabIndex = 6;
            numericUpDown_ContactLimit.TextAlign = HorizontalAlignment.Center;
            numericUpDown_ContactLimit.Value = new decimal(new int[] { 4000, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 4;
            label2.Text = "探针压合次数上限：";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(431, 9);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 7;
            label3.Text = "单通道NG上限：";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(211, 9);
            label4.Name = "label4";
            label4.Size = new Size(128, 17);
            label4.TabIndex = 8;
            label4.Text = "探针充放电次数上限：";
            // 
            // numericUpDown_RunLimit
            // 
            numericUpDown_RunLimit.Anchor = AnchorStyles.Left;
            numericUpDown_RunLimit.Location = new Point(345, 6);
            numericUpDown_RunLimit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_RunLimit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_RunLimit.Name = "numericUpDown_RunLimit";
            numericUpDown_RunLimit.Size = new Size(80, 23);
            numericUpDown_RunLimit.TabIndex = 7;
            numericUpDown_RunLimit.TextAlign = HorizontalAlignment.Center;
            numericUpDown_RunLimit.Value = new decimal(new int[] { 3000, 0, 0, 0 });
            // 
            // numericUpDown_ChannelNGLimit
            // 
            numericUpDown_ChannelNGLimit.Anchor = AnchorStyles.Left;
            numericUpDown_ChannelNGLimit.Location = new Point(536, 6);
            numericUpDown_ChannelNGLimit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_ChannelNGLimit.Name = "numericUpDown_ChannelNGLimit";
            numericUpDown_ChannelNGLimit.Size = new Size(80, 23);
            numericUpDown_ChannelNGLimit.TabIndex = 9;
            numericUpDown_ChannelNGLimit.TextAlign = HorizontalAlignment.Center;
            numericUpDown_ChannelNGLimit.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // panel1
            // 
            panel1.Controls.Add(Button_DeviceAll);
            panel1.Controls.Add(Button_ChannelOne);
            panel1.Controls.Add(Button_DeviceOne);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 768);
            panel1.Name = "panel1";
            panel1.Size = new Size(1590, 100);
            panel1.TabIndex = 1;
            // 
            // Button_DeviceAll
            // 
            Button_DeviceAll.Location = new Point(12, 12);
            Button_DeviceAll.Margin = new Padding(12);
            Button_DeviceAll.Name = "Button_DeviceAll";
            Button_DeviceAll.Size = new Size(120, 30);
            Button_DeviceAll.TabIndex = 1;
            Button_DeviceAll.Text = "全部设备统计清空";
            Button_DeviceAll.UseVisualStyleBackColor = true;
            Button_DeviceAll.Click += Button_DeviceAll_Click;
            // 
            // Button_ChannelOne
            // 
            Button_ChannelOne.Location = new Point(300, 12);
            Button_ChannelOne.Margin = new Padding(12);
            Button_ChannelOne.Name = "Button_ChannelOne";
            Button_ChannelOne.Size = new Size(120, 30);
            Button_ChannelOne.TabIndex = 2;
            Button_ChannelOne.Text = "当前通道统计清空";
            Button_ChannelOne.UseVisualStyleBackColor = true;
            Button_ChannelOne.Click += Button_ChannelOne_Click;
            // 
            // Button_DeviceOne
            // 
            Button_DeviceOne.Location = new Point(156, 12);
            Button_DeviceOne.Margin = new Padding(12);
            Button_DeviceOne.Name = "Button_DeviceOne";
            Button_DeviceOne.Size = new Size(120, 30);
            Button_DeviceOne.TabIndex = 3;
            Button_DeviceOne.Text = "当前设备统计清空";
            Button_DeviceOne.UseVisualStyleBackColor = true;
            Button_DeviceOne.Click += Button_DeviceOne_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(comboBox_Device);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1902, 32);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 7);
            label6.Margin = new Padding(7);
            label6.Name = "label6";
            label6.Size = new Size(105, 17);
            label6.TabIndex = 3;
            label6.Text = "设备选择（ID）：";
            // 
            // comboBox_Device
            // 
            comboBox_Device.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Device.FormattingEnabled = true;
            comboBox_Device.Location = new Point(122, 3);
            comboBox_Device.Name = "comboBox_Device";
            comboBox_Device.Size = new Size(121, 25);
            comboBox_Device.TabIndex = 4;
            comboBox_Device.SelectedIndexChanged += ComboBox_Device_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(247, 1);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 5;
            button2.Text = "刷新";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // UC关键器件运行记录
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(flowLayoutPanel2);
            Name = "UC关键器件运行记录";
            Size = new Size(1902, 909);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox逆变器.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_InverterPower).EndInit();
            groupBox探针.ResumeLayout(false);
            groupBox探针.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Probe).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ContactLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_RunLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ChannelNGLimit).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox逆变器;
        private DataGridView dataGridView_InverterPower;
        private DataGridViewTextBoxColumn Column1;
        private GroupBox groupBox探针;
        private TableLayoutPanel TableLayoutPanel_ProbeCount;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label5;
        private NumericUpDown numericUpDown_Probe;
        private RadioButton radioButton_ContactLimit;
        private RadioButton radioButton_RunLimit;
        private RadioButton radioButton1;
        private RadioButton radioButton_NGLimit;
        private TableLayoutPanel tableLayoutPanel6;
        private Button Button_SaveNGCount;
        private NumericUpDown numericUpDown_ContactLimit;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown_RunLimit;
        private NumericUpDown numericUpDown_ChannelNGLimit;
        private Panel panel1;
        private Button Button_DeviceAll;
        private Button Button_ChannelOne;
        private Button Button_DeviceOne;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label6;
        private ComboBox comboBox_Device;
        private Button button2;
    }
}
