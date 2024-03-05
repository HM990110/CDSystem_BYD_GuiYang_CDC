namespace CDSystem.Other
{
    partial class Form_Alarm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Alarm));
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            dataGridView_Log = new DataGridView();
            Col发生时间 = new DataGridViewTextBoxColumn();
            Col设备编号 = new DataGridViewTextBoxColumn();
            Col错误类型 = new DataGridViewTextBoxColumn();
            Col错误内容 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Log).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(400, 147);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            // 
            // dataGridView_Log
            // 
            dataGridView_Log.AllowUserToAddRows = false;
            dataGridView_Log.AllowUserToDeleteRows = false;
            dataGridView_Log.AllowUserToResizeColumns = false;
            dataGridView_Log.AllowUserToResizeRows = false;
            dataGridView_Log.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Log.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Log.BackgroundColor = Color.White;
            dataGridView_Log.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridView_Log.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Log.ColumnHeadersHeight = 30;
            dataGridView_Log.Columns.AddRange(new DataGridViewColumn[] { Col发生时间, Col设备编号, Col错误类型, Col错误内容 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView_Log.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_Log.Dock = DockStyle.Fill;
            dataGridView_Log.EnableHeadersVisualStyles = false;
            dataGridView_Log.Location = new Point(400, 0);
            dataGridView_Log.Name = "dataGridView_Log";
            dataGridView_Log.ReadOnly = true;
            dataGridView_Log.RowHeadersWidth = 50;
            dataGridView_Log.RowTemplate.Height = 25;
            dataGridView_Log.Size = new Size(588, 147);
            dataGridView_Log.TabIndex = 5;
            // 
            // Col发生时间
            // 
            Col发生时间.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col发生时间.HeaderText = "    发生时间    ";
            Col发生时间.Name = "Col发生时间";
            Col发生时间.ReadOnly = true;
            Col发生时间.SortMode = DataGridViewColumnSortMode.NotSortable;
            Col发生时间.Width = 93;
            // 
            // Col设备编号
            // 
            Col设备编号.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col设备编号.HeaderText = "    设备编号    ";
            Col设备编号.Name = "Col设备编号";
            Col设备编号.ReadOnly = true;
            Col设备编号.SortMode = DataGridViewColumnSortMode.NotSortable;
            Col设备编号.Width = 93;
            // 
            // Col错误类型
            // 
            Col错误类型.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Col错误类型.DefaultCellStyle = dataGridViewCellStyle2;
            Col错误类型.HeaderText = "    错误类型    ";
            Col错误类型.Name = "Col错误类型";
            Col错误类型.ReadOnly = true;
            Col错误类型.SortMode = DataGridViewColumnSortMode.NotSortable;
            Col错误类型.Width = 93;
            // 
            // Col错误内容
            // 
            Col错误内容.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Col错误内容.DefaultCellStyle = dataGridViewCellStyle3;
            Col错误内容.HeaderText = "    错误内容    ";
            Col错误内容.Name = "Col错误内容";
            Col错误内容.ReadOnly = true;
            Col错误内容.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Form_Alarm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(988, 147);
            Controls.Add(dataGridView_Log);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Alarm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "报警信息";
            FormClosing += Form_Alarm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Log).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dataGridView_Log;
        private DataGridViewTextBoxColumn Col发生时间;
        private DataGridViewTextBoxColumn Col设备编号;
        private DataGridViewTextBoxColumn Col错误类型;
        private DataGridViewTextBoxColumn Col错误内容;
    }
}