namespace CDSystem.系统设置
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            LabelError = new Label();
            button1 = new Button();
            label2 = new Label();
            TextBoxPassword = new TextBox();
            label1 = new Label();
            TextBoxUsername = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // LabelError
            // 
            LabelError.AutoSize = true;
            LabelError.Dock = DockStyle.Bottom;
            LabelError.ForeColor = Color.Red;
            LabelError.Location = new Point(0, 180);
            LabelError.Name = "LabelError";
            LabelError.Size = new Size(0, 17);
            LabelError.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(16, 145);
            button1.Margin = new Padding(3, 20, 3, 10);
            button1.Name = "button1";
            button1.Size = new Size(200, 30);
            button1.TabIndex = 19;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 18;
            label2.Text = "密码：";
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxPassword.Location = new Point(16, 102);
            TextBoxPassword.Margin = new Padding(0);
            TextBoxPassword.MaxLength = 20;
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.PasswordChar = '*';
            TextBoxPassword.Size = new Size(200, 24);
            TextBoxPassword.TabIndex = 17;
            TextBoxPassword.TextChanged += TextBox_TextChanged;
            TextBoxPassword.KeyPress += TextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 16;
            label1.Text = "工号：";
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxUsername.Location = new Point(16, 48);
            TextBoxUsername.Margin = new Padding(0);
            TextBoxUsername.MaxLength = 20;
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(200, 24);
            TextBoxUsername.TabIndex = 15;
            TextBoxUsername.TextChanged += TextBox_TextChanged;
            TextBoxUsername.KeyPress += TextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 20;
            // 
            // FormLogin
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 197);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(TextBoxPassword);
            Controls.Add(label1);
            Controls.Add(TextBoxUsername);
            Controls.Add(LabelError);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "员工登录";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelError;
        private Button button1;
        private Label label2;
        private TextBox TextBoxPassword;
        private Label label1;
        private TextBox TextBoxUsername;
        private Label label3;
    }
}