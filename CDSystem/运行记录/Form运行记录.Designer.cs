namespace CDSystem.历史数据
{
    partial class Form运行记录
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            dataGridView_AlarmLog = new DataGridView();
            Col发生时间 = new DataGridViewTextBoxColumn();
            Col设备编号 = new DataGridViewTextBoxColumn();
            Col错误类型 = new DataGridViewTextBoxColumn();
            Col错误内容 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            comboBox_Device = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView_ErrorLog = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dataGridView_MesLog = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            dataGridView_RunLog = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AlarmLog).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ErrorLog).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MesLog).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_RunLog).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_AlarmLog
            // 
            dataGridView_AlarmLog.AllowUserToAddRows = false;
            dataGridView_AlarmLog.AllowUserToDeleteRows = false;
            dataGridView_AlarmLog.AllowUserToResizeColumns = false;
            dataGridView_AlarmLog.AllowUserToResizeRows = false;
            dataGridView_AlarmLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_AlarmLog.BackgroundColor = Color.White;
            dataGridView_AlarmLog.BorderStyle = BorderStyle.None;
            dataGridView_AlarmLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridView_AlarmLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_AlarmLog.ColumnHeadersHeight = 30;
            dataGridView_AlarmLog.Columns.AddRange(new DataGridViewColumn[] { Col发生时间, Col设备编号, Col错误类型, Col错误内容 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_AlarmLog.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_AlarmLog.Dock = DockStyle.Fill;
            dataGridView_AlarmLog.EnableHeadersVisualStyles = false;
            dataGridView_AlarmLog.Location = new Point(3, 3);
            dataGridView_AlarmLog.Name = "dataGridView_AlarmLog";
            dataGridView_AlarmLog.ReadOnly = true;
            dataGridView_AlarmLog.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_AlarmLog.RowTemplate.Height = 25;
            dataGridView_AlarmLog.Size = new Size(1896, 863);
            dataGridView_AlarmLog.TabIndex = 6;
            // 
            // Col发生时间
            // 
            Col发生时间.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col发生时间.HeaderText = "    发生时间    ";
            Col发生时间.Name = "Col发生时间";
            Col发生时间.ReadOnly = true;
            Col发生时间.Width = 112;
            // 
            // Col设备编号
            // 
            Col设备编号.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col设备编号.HeaderText = "    设备编号    ";
            Col设备编号.Name = "Col设备编号";
            Col设备编号.ReadOnly = true;
            Col设备编号.Width = 112;
            // 
            // Col错误类型
            // 
            Col错误类型.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col错误类型.HeaderText = "    错误类型    ";
            Col错误类型.Name = "Col错误类型";
            Col错误类型.ReadOnly = true;
            Col错误类型.Width = 112;
            // 
            // Col错误内容
            // 
            Col错误内容.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Col错误内容.DefaultCellStyle = dataGridViewCellStyle2;
            Col错误内容.HeaderText = "    错误内容    ";
            Col错误内容.Name = "Col错误内容";
            Col错误内容.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(473, 5);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 4;
            button1.Text = "搜索";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // comboBox_Device
            // 
            comboBox_Device.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Device.FormattingEnabled = true;
            comboBox_Device.Location = new Point(332, 6);
            comboBox_Device.Margin = new Padding(0, 6, 6, 6);
            comboBox_Device.Name = "comboBox_Device";
            comboBox_Device.Size = new Size(130, 25);
            comboBox_Device.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 11);
            label1.Margin = new Padding(11, 11, 0, 11);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 0;
            label1.Text = "设备选择（ID）：";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(79, 7);
            dateTimePicker1.Margin = new Padding(0, 7, 7, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 11);
            label2.Margin = new Padding(11, 11, 0, 11);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 9;
            label2.Text = "选择日期：";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(5, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1910, 899);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView_AlarmLog);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1902, 869);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "报警日志";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView_ErrorLog);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1902, 869);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "错误日志";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ErrorLog
            // 
            dataGridView_ErrorLog.AllowUserToAddRows = false;
            dataGridView_ErrorLog.AllowUserToDeleteRows = false;
            dataGridView_ErrorLog.AllowUserToResizeColumns = false;
            dataGridView_ErrorLog.AllowUserToResizeRows = false;
            dataGridView_ErrorLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_ErrorLog.BackgroundColor = Color.White;
            dataGridView_ErrorLog.BorderStyle = BorderStyle.None;
            dataGridView_ErrorLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridView_ErrorLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_ErrorLog.ColumnHeadersHeight = 30;
            dataGridView_ErrorLog.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView_ErrorLog.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView_ErrorLog.Dock = DockStyle.Fill;
            dataGridView_ErrorLog.EnableHeadersVisualStyles = false;
            dataGridView_ErrorLog.Location = new Point(3, 3);
            dataGridView_ErrorLog.Name = "dataGridView_ErrorLog";
            dataGridView_ErrorLog.ReadOnly = true;
            dataGridView_ErrorLog.RowTemplate.Height = 25;
            dataGridView_ErrorLog.Size = new Size(1896, 863);
            dataGridView_ErrorLog.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "    发生时间    ";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 112;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "    设备编号    ";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 112;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.HeaderText = "    错误类型    ";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 112;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTextBoxColumn4.HeaderText = "    错误内容    ";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView_MesLog);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1902, 869);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "MES日志";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_MesLog
            // 
            dataGridView_MesLog.AllowUserToAddRows = false;
            dataGridView_MesLog.AllowUserToDeleteRows = false;
            dataGridView_MesLog.AllowUserToResizeColumns = false;
            dataGridView_MesLog.AllowUserToResizeRows = false;
            dataGridView_MesLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_MesLog.BackgroundColor = Color.White;
            dataGridView_MesLog.BorderStyle = BorderStyle.None;
            dataGridView_MesLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
            dataGridView_MesLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView_MesLog.ColumnHeadersHeight = 30;
            dataGridView_MesLog.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView_MesLog.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView_MesLog.Dock = DockStyle.Fill;
            dataGridView_MesLog.EnableHeadersVisualStyles = false;
            dataGridView_MesLog.Location = new Point(3, 3);
            dataGridView_MesLog.Name = "dataGridView_MesLog";
            dataGridView_MesLog.ReadOnly = true;
            dataGridView_MesLog.RowTemplate.Height = 25;
            dataGridView_MesLog.Size = new Size(1896, 863);
            dataGridView_MesLog.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.HeaderText = "    发生时间    ";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 112;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.HeaderText = "    设备编号    ";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 112;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn7.HeaderText = "    错误类型    ";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 112;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTextBoxColumn8.HeaderText = "    错误内容    ";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView_RunLog);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1902, 869);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "运行日志";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView_RunLog
            // 
            dataGridView_RunLog.AllowUserToAddRows = false;
            dataGridView_RunLog.AllowUserToDeleteRows = false;
            dataGridView_RunLog.AllowUserToResizeColumns = false;
            dataGridView_RunLog.AllowUserToResizeRows = false;
            dataGridView_RunLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_RunLog.BackgroundColor = Color.White;
            dataGridView_RunLog.BorderStyle = BorderStyle.None;
            dataGridView_RunLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle10.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.WindowText;
            dataGridView_RunLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView_RunLog.ColumnHeadersHeight = 30;
            dataGridView_RunLog.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridView_RunLog.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridView_RunLog.Dock = DockStyle.Fill;
            dataGridView_RunLog.EnableHeadersVisualStyles = false;
            dataGridView_RunLog.Location = new Point(3, 3);
            dataGridView_RunLog.Name = "dataGridView_RunLog";
            dataGridView_RunLog.ReadOnly = true;
            dataGridView_RunLog.RowTemplate.Height = 25;
            dataGridView_RunLog.Size = new Size(1896, 863);
            dataGridView_RunLog.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn9.HeaderText = "    发生时间    ";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 112;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn10.HeaderText = "    设备编号    ";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 112;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn11.HeaderText = "    错误类型    ";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 112;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTextBoxColumn12.HeaderText = "    错误内容    ";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(dateTimePicker1);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(comboBox_Device);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(5, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1910, 40);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // Form运行记录
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 949);
            Controls.Add(tabControl1);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            Name = "Form运行记录";
            Padding = new Padding(5);
            Text = "Form运行记录";
            ((System.ComponentModel.ISupportInitialize)dataGridView_AlarmLog).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_ErrorLog).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_MesLog).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_RunLog).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_AlarmLog;
        private Label label1;
        private Button button1;
        public ComboBox comboBox_Device;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView_ErrorLog;
        private TabPage tabPage3;
        private DataGridView dataGridView_MesLog;
        private TabPage tabPage4;
        private DataGridView dataGridView_RunLog;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridViewTextBoxColumn Col发生时间;
        private DataGridViewTextBoxColumn Col设备编号;
        private DataGridViewTextBoxColumn Col错误类型;
        private DataGridViewTextBoxColumn Col错误内容;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}