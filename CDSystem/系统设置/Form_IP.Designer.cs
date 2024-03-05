namespace CDSystem.系统设置
{
    partial class Form_IP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_IP));
            label4 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox_IP4 = new TextBox();
            textBox_IP3 = new TextBox();
            textBox_IP2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_IP1 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 4;
            label4.Text = "IP地址：";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(12, 29);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2);
            panel1.Size = new Size(200, 30);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.99999F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(textBox_IP4, 6, 0);
            tableLayoutPanel1.Controls.Add(textBox_IP3, 4, 0);
            tableLayoutPanel1.Controls.Add(textBox_IP2, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 5, 0);
            tableLayoutPanel1.Controls.Add(textBox_IP1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(194, 24);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_IP4
            // 
            textBox_IP4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_IP4.BorderStyle = BorderStyle.None;
            textBox_IP4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_IP4.Location = new Point(156, 4);
            textBox_IP4.Margin = new Padding(0);
            textBox_IP4.MaxLength = 3;
            textBox_IP4.Name = "textBox_IP4";
            textBox_IP4.Size = new Size(38, 16);
            textBox_IP4.TabIndex = 6;
            textBox_IP4.Tag = "4";
            textBox_IP4.TextAlign = HorizontalAlignment.Center;
            textBox_IP4.KeyPress += TextBox_IP_KeyPress;
            // 
            // textBox_IP3
            // 
            textBox_IP3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_IP3.BorderStyle = BorderStyle.None;
            textBox_IP3.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_IP3.Location = new Point(104, 4);
            textBox_IP3.Margin = new Padding(0);
            textBox_IP3.MaxLength = 3;
            textBox_IP3.Name = "textBox_IP3";
            textBox_IP3.Size = new Size(35, 16);
            textBox_IP3.TabIndex = 5;
            textBox_IP3.Tag = "3";
            textBox_IP3.TextAlign = HorizontalAlignment.Center;
            textBox_IP3.KeyPress += TextBox_IP_KeyPress;
            // 
            // textBox_IP2
            // 
            textBox_IP2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_IP2.BorderStyle = BorderStyle.None;
            textBox_IP2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_IP2.Location = new Point(52, 4);
            textBox_IP2.Margin = new Padding(0);
            textBox_IP2.MaxLength = 3;
            textBox_IP2.Name = "textBox_IP2";
            textBox_IP2.Size = new Size(35, 16);
            textBox_IP2.TabIndex = 4;
            textBox_IP2.Tag = "2";
            textBox_IP2.TextAlign = HorizontalAlignment.Center;
            textBox_IP2.KeyPress += TextBox_IP_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 3);
            label1.Name = "label1";
            label1.Size = new Size(11, 17);
            label1.TabIndex = 0;
            label1.Text = ".";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 3);
            label2.Name = "label2";
            label2.Size = new Size(11, 17);
            label2.TabIndex = 1;
            label2.Text = ".";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(142, 3);
            label3.Name = "label3";
            label3.Size = new Size(11, 17);
            label3.TabIndex = 2;
            label3.Text = ".";
            // 
            // textBox_IP1
            // 
            textBox_IP1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_IP1.BorderStyle = BorderStyle.None;
            textBox_IP1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_IP1.Location = new Point(0, 4);
            textBox_IP1.Margin = new Padding(0);
            textBox_IP1.MaxLength = 3;
            textBox_IP1.Name = "textBox_IP1";
            textBox_IP1.Size = new Size(35, 16);
            textBox_IP1.TabIndex = 3;
            textBox_IP1.Tag = "1";
            textBox_IP1.TextAlign = HorizontalAlignment.Center;
            textBox_IP1.KeyPress += TextBox_IP_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(137, 65);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 5;
            button1.Text = "保存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // Form_IP
            // 
            AcceptButton = button1;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(224, 103);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_IP";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "设备IP设置";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox_IP4;
        private TextBox textBox_IP3;
        private TextBox textBox_IP2;
        private TextBox textBox_IP1;
    }
}