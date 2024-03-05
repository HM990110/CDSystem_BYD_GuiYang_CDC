namespace CDSystem.传感数据
{
    partial class Form逆变器信息
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form逆变器信息));
            dataGridView_Step = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Step).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Step
            // 
            dataGridView_Step.AllowUserToAddRows = false;
            dataGridView_Step.AllowUserToDeleteRows = false;
            dataGridView_Step.AllowUserToResizeColumns = false;
            dataGridView_Step.AllowUserToResizeRows = false;
            dataGridView_Step.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Step.BackgroundColor = Color.White;
            dataGridView_Step.BorderStyle = BorderStyle.None;
            dataGridView_Step.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridView_Step.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Step.ColumnHeadersHeight = 30;
            dataGridView_Step.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_Step.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_Step.Dock = DockStyle.Fill;
            dataGridView_Step.EnableHeadersVisualStyles = false;
            dataGridView_Step.Location = new Point(0, 0);
            dataGridView_Step.Name = "dataGridView_Step";
            dataGridView_Step.ReadOnly = true;
            dataGridView_Step.RowHeadersWidth = 120;
            dataGridView_Step.RowTemplate.Height = 25;
            dataGridView_Step.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_Step.Size = new Size(580, 557);
            dataGridView_Step.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "逆变器1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "逆变器2";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "逆变器3";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            // 
            // Form逆变器信息
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 557);
            Controls.Add(dataGridView_Step);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form逆变器信息";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "逆变器信息";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Step).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Step;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}