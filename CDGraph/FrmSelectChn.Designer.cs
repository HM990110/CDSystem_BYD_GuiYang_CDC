namespace CDGraph
{
    partial class FrmSelectChn
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            checkBox无电芯 = new CheckBox();
            checkBoxNG电芯 = new CheckBox();
            checkBoxOK电芯 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 657);
            button1.Name = "button1";
            button1.Size = new Size(632, 40);
            button1.TabIndex = 100;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.GridColor = Color.FromArgb(104, 173, 255);
            dataGridView1.Location = new Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(632, 632);
            dataGridView1.TabIndex = 2;
            dataGridView1.TabStop = false;
            dataGridView1.Leave += DataGridView1_Leave;
            dataGridView1.MouseDown += DataGridView1_MouseDown;
            dataGridView1.MouseUp += DataGridView1_MouseUp;
            // 
            // checkBox无电芯
            // 
            checkBox无电芯.AutoSize = true;
            checkBox无电芯.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox无电芯.Location = new Point(154, 3);
            checkBox无电芯.Name = "checkBox无电芯";
            checkBox无电芯.Size = new Size(63, 21);
            checkBox无电芯.TabIndex = 0;
            checkBox无电芯.Text = "无电芯";
            checkBox无电芯.UseVisualStyleBackColor = true;
            checkBox无电芯.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // checkBoxNG电芯
            // 
            checkBoxNG电芯.AutoSize = true;
            checkBoxNG电芯.Checked = true;
            checkBoxNG电芯.CheckState = CheckState.Checked;
            checkBoxNG电芯.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxNG电芯.Location = new Point(78, 3);
            checkBoxNG电芯.Name = "checkBoxNG电芯";
            checkBoxNG电芯.Size = new Size(70, 21);
            checkBoxNG电芯.TabIndex = 2;
            checkBoxNG电芯.Text = "NG电芯";
            checkBoxNG电芯.UseVisualStyleBackColor = true;
            checkBoxNG电芯.CheckedChanged += CheckBox3_CheckedChanged;
            // 
            // checkBoxOK电芯
            // 
            checkBoxOK电芯.AutoSize = true;
            checkBoxOK电芯.Checked = true;
            checkBoxOK电芯.CheckState = CheckState.Checked;
            checkBoxOK电芯.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxOK电芯.Location = new Point(3, 3);
            checkBoxOK电芯.Name = "checkBoxOK电芯";
            checkBoxOK电芯.Size = new Size(69, 21);
            checkBoxOK电芯.TabIndex = 1;
            checkBoxOK电芯.Text = "OK电芯";
            checkBoxOK电芯.UseVisualStyleBackColor = true;
            checkBoxOK电芯.CheckedChanged += CheckBox2_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(checkBoxOK电芯);
            flowLayoutPanel1.Controls.Add(checkBoxNG电芯);
            flowLayoutPanel1.Controls.Add(checkBox无电芯);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(632, 25);
            flowLayoutPanel1.TabIndex = 101;
            // 
            // FrmSelectChn
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 697);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSelectChn";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "通道选择 ( 鼠标左键 -> 选择， 鼠标右键 -> 反向 )";
            FormClosing += FrmSelectChn_FormClosing;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBox无电芯;
        private CheckBox checkBoxNG电芯;
        private CheckBox checkBoxOK电芯;
    }
}