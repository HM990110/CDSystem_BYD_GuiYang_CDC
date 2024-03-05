namespace CDSystem.手动作业
{
    partial class Form_TrayInfo
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TrayInfo));
            dataGridView_CellSelect = new DataGridView();
            panel1 = new Panel();
            uiButton1 = new Button();
            label2 = new Label();
            textBox_TRAY_NO = new TextBox();
            textBox_MDL_NAME = new TextBox();
            label1 = new Label();
            Button_Save = new Button();
            dataGridView_CellNo = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CellSelect).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CellNo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_CellSelect
            // 
            dataGridView_CellSelect.AllowUserToAddRows = false;
            dataGridView_CellSelect.AllowUserToDeleteRows = false;
            dataGridView_CellSelect.AllowUserToResizeColumns = false;
            dataGridView_CellSelect.AllowUserToResizeRows = false;
            dataGridView_CellSelect.BackgroundColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_CellSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_CellSelect.ColumnHeadersHeight = 40;
            dataGridView_CellSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_CellSelect.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_CellSelect.Dock = DockStyle.Fill;
            dataGridView_CellSelect.Location = new Point(3, 3);
            dataGridView_CellSelect.Name = "dataGridView_CellSelect";
            dataGridView_CellSelect.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_CellSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_CellSelect.RowHeadersWidth = 120;
            dataGridView_CellSelect.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tableLayoutPanel1.SetRowSpan(dataGridView_CellSelect, 2);
            dataGridView_CellSelect.RowTemplate.Height = 40;
            dataGridView_CellSelect.ScrollBars = ScrollBars.None;
            dataGridView_CellSelect.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_CellSelect.Size = new Size(874, 751);
            dataGridView_CellSelect.TabIndex = 1;
            dataGridView_CellSelect.CellClick += DataGridView_CellSelect_CellClick;
            dataGridView_CellSelect.Paint += DataGridView_CellSelect_Paint;
            dataGridView_CellSelect.Leave += DataGridView_CellSelect_Leave;
            dataGridView_CellSelect.MouseUp += DataGridView_CellSelect_MouseUp;
            // 
            // panel1
            // 
            panel1.Controls.Add(uiButton1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_TRAY_NO);
            panel1.Controls.Add(textBox_MDL_NAME);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Button_Save);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(883, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 112);
            panel1.TabIndex = 2;
            // 
            // uiButton1
            // 
            uiButton1.Cursor = Cursors.Hand;
            uiButton1.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(210, 68);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(75, 30);
            uiButton1.TabIndex = 14;
            uiButton1.Text = "自动";
            uiButton1.Click += UiButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 55);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 13;
            label2.Text = "托盘号：";
            // 
            // textBox_TRAY_NO
            // 
            textBox_TRAY_NO.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_TRAY_NO.Location = new Point(15, 75);
            textBox_TRAY_NO.Name = "textBox_TRAY_NO";
            textBox_TRAY_NO.Size = new Size(176, 23);
            textBox_TRAY_NO.TabIndex = 11;
            // 
            // textBox_MDL_NAME
            // 
            textBox_MDL_NAME.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MDL_NAME.Location = new Point(15, 29);
            textBox_MDL_NAME.Name = "textBox_MDL_NAME";
            textBox_MDL_NAME.Size = new Size(176, 23);
            textBox_MDL_NAME.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 9;
            label1.Text = "电池型号：";
            // 
            // Button_Save
            // 
            Button_Save.Cursor = Cursors.Hand;
            Button_Save.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Save.Location = new Point(210, 22);
            Button_Save.MinimumSize = new Size(1, 1);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(75, 30);
            Button_Save.TabIndex = 8;
            Button_Save.Text = "发送";
            Button_Save.Click += Button_Save_Click;
            // 
            // dataGridView_CellNo
            // 
            dataGridView_CellNo.AllowUserToAddRows = false;
            dataGridView_CellNo.AllowUserToDeleteRows = false;
            dataGridView_CellNo.AllowUserToResizeColumns = false;
            dataGridView_CellNo.AllowUserToResizeRows = false;
            dataGridView_CellNo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_CellNo.BackgroundColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView_CellNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_CellNo.ColumnHeadersHeight = 40;
            dataGridView_CellNo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_CellNo.ColumnHeadersVisible = false;
            dataGridView_CellNo.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView_CellNo.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView_CellNo.Dock = DockStyle.Fill;
            dataGridView_CellNo.Location = new Point(883, 121);
            dataGridView_CellNo.MultiSelect = false;
            dataGridView_CellNo.Name = "dataGridView_CellNo";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView_CellNo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView_CellNo.RowHeadersWidth = 80;
            dataGridView_CellNo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView_CellNo.RowTemplate.Height = 25;
            dataGridView_CellNo.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_CellNo.Size = new Size(294, 633);
            dataGridView_CellNo.TabIndex = 3;
            dataGridView_CellNo.CellClick += DataGridView_CellNo_CellClick;
            dataGridView_CellNo.CellValueChanged += DataGridView_CellNo_CellValueChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.Controls.Add(dataGridView_CellSelect, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView_CellNo, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 118F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1180, 757);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // Form_TrayInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1180, 757);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_TrayInfo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "托盘信息";
            ((System.ComponentModel.ISupportInitialize)dataGridView_CellSelect).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CellNo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_CellSelect;
        private Panel panel1;
        private DataGridView dataGridView_CellNo;
        private DataGridViewTextBoxColumn Column1;
        private Button uiButton1;
        private Label label2;
        private TextBox textBox_TRAY_NO;
        private TextBox textBox_MDL_NAME;
        private Label label1;
        private Button Button_Save;
        private TableLayoutPanel tableLayoutPanel1;
    }
}