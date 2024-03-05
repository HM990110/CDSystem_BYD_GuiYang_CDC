namespace CDSystem.实时数据
{
    partial class Form_NG代码
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NG代码));
            dataGridView_NGCode = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_NGCode).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_NGCode
            // 
            dataGridView_NGCode.AllowUserToAddRows = false;
            dataGridView_NGCode.AllowUserToDeleteRows = false;
            dataGridView_NGCode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_NGCode.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_NGCode.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_NGCode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_NGCode.ColumnHeadersHeight = 30;
            dataGridView_NGCode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_NGCode.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_NGCode.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_NGCode.Dock = DockStyle.Fill;
            dataGridView_NGCode.Location = new Point(0, 0);
            dataGridView_NGCode.MultiSelect = false;
            dataGridView_NGCode.Name = "dataGridView_NGCode";
            dataGridView_NGCode.ReadOnly = true;
            dataGridView_NGCode.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_NGCode.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_NGCode.RowTemplate.Height = 30;
            dataGridView_NGCode.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_NGCode.Size = new Size(1200, 800);
            dataGridView_NGCode.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "保护码值";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 81;
            // 
            // Column2
            // 
            Column2.HeaderText = "分类";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 57;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "描述";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "判断阶段";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 81;
            // 
            // Column6
            // 
            Column6.HeaderText = "判断主体";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 81;
            // 
            // Form_NG代码
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1200, 800);
            Controls.Add(dataGridView_NGCode);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_NG代码";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NG代码";
            Load += Form_NG代码_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_NGCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_NGCode;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}