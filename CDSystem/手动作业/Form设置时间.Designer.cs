namespace CDSystem.手动作业
{
    partial class Form设置时间
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form设置时间));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox_HH = new TextBox();
            textBox_ss = new TextBox();
            textBox_mm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonSacve = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(28, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 30);
            panel1.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(textBox_HH, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox_ss, 4, 0);
            tableLayoutPanel1.Controls.Add(textBox_mm, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(133, 28);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // textBox_HH
            // 
            textBox_HH.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_HH.BorderStyle = BorderStyle.None;
            textBox_HH.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_HH.Location = new Point(0, 3);
            textBox_HH.Margin = new Padding(0);
            textBox_HH.MaxLength = 2;
            textBox_HH.Name = "textBox_HH";
            textBox_HH.Size = new Size(31, 21);
            textBox_HH.TabIndex = 7;
            textBox_HH.Text = "00";
            textBox_HH.TextAlign = HorizontalAlignment.Center;
            textBox_HH.TextChanged += textBox_TextChanged;
            textBox_HH.KeyPress += textBox_KeyPress;
            // 
            // textBox_ss
            // 
            textBox_ss.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_ss.BorderStyle = BorderStyle.None;
            textBox_ss.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ss.Location = new Point(102, 3);
            textBox_ss.Margin = new Padding(0);
            textBox_ss.MaxLength = 2;
            textBox_ss.Name = "textBox_ss";
            textBox_ss.Size = new Size(31, 21);
            textBox_ss.TabIndex = 9;
            textBox_ss.Text = "00";
            textBox_ss.TextAlign = HorizontalAlignment.Center;
            textBox_ss.TextChanged += textBox_TextChanged;
            textBox_ss.KeyPress += textBox_KeyPress;
            // 
            // textBox_mm
            // 
            textBox_mm.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_mm.BorderStyle = BorderStyle.None;
            textBox_mm.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_mm.Location = new Point(51, 3);
            textBox_mm.Margin = new Padding(0);
            textBox_mm.MaxLength = 2;
            textBox_mm.Name = "textBox_mm";
            textBox_mm.Size = new Size(31, 21);
            textBox_mm.TabIndex = 8;
            textBox_mm.Text = "00";
            textBox_mm.TextAlign = HorizontalAlignment.Center;
            textBox_mm.TextChanged += textBox_TextChanged;
            textBox_mm.KeyPress += textBox_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 3);
            label1.Name = "label1";
            label1.Size = new Size(14, 21);
            label1.TabIndex = 10;
            label1.Text = ":";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(85, 3);
            label2.Name = "label2";
            label2.Size = new Size(14, 21);
            label2.TabIndex = 11;
            label2.Text = ":";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSacve
            // 
            buttonSacve.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSacve.Location = new Point(178, 40);
            buttonSacve.Margin = new Padding(12);
            buttonSacve.Name = "buttonSacve";
            buttonSacve.Size = new Size(75, 30);
            buttonSacve.TabIndex = 13;
            buttonSacve.Text = "确认";
            buttonSacve.UseVisualStyleBackColor = true;
            buttonSacve.Click += buttonSacve_Click;
            // 
            // Form设置时间
            // 
            AcceptButton = buttonSacve;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 111);
            Controls.Add(panel1);
            Controls.Add(buttonSacve);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form设置时间";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "时间设置";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox_HH;
        private TextBox textBox_ss;
        private TextBox textBox_mm;
        private Label label1;
        private Label label2;
        private Button buttonSacve;
    }
}