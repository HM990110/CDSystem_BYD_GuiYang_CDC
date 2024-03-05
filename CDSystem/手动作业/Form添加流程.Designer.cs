namespace CDSystem.手动作业
{
    partial class Form添加流程
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form添加流程));
            textBox_ProcessName = new TextBox();
            buttonSacve = new Button();
            label1 = new Label();
            comboBox_ProcessGroup = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox_ProcessName
            // 
            textBox_ProcessName.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ProcessName.Location = new Point(9, 29);
            textBox_ProcessName.Margin = new Padding(0);
            textBox_ProcessName.Name = "textBox_ProcessName";
            textBox_ProcessName.Size = new Size(212, 25);
            textBox_ProcessName.TabIndex = 0;
            textBox_ProcessName.TextChanged += textBox_ProcessName_TextChanged;
            textBox_ProcessName.KeyPress += TextBox_ProcessName_KeyPress;
            // 
            // buttonSacve
            // 
            buttonSacve.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSacve.Location = new Point(146, 132);
            buttonSacve.Margin = new Padding(0);
            buttonSacve.Name = "buttonSacve";
            buttonSacve.Size = new Size(75, 28);
            buttonSacve.TabIndex = 1;
            buttonSacve.Text = "确认";
            buttonSacve.UseVisualStyleBackColor = true;
            buttonSacve.Click += ButtonSacve_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 64);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "复制流程：";
            // 
            // comboBox_ProcessGroup
            // 
            comboBox_ProcessGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ProcessGroup.Font = new Font("微软雅黑", 10F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox_ProcessGroup.FormattingEnabled = true;
            comboBox_ProcessGroup.Location = new Point(9, 84);
            comboBox_ProcessGroup.Margin = new Padding(0);
            comboBox_ProcessGroup.Name = "comboBox_ProcessGroup";
            comboBox_ProcessGroup.Size = new Size(212, 27);
            comboBox_ProcessGroup.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(9, 9);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "流程ID：";
            // 
            // Form添加流程
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(230, 169);
            Controls.Add(label2);
            Controls.Add(comboBox_ProcessGroup);
            Controls.Add(label1);
            Controls.Add(buttonSacve);
            Controls.Add(textBox_ProcessName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form添加流程";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "添加流程";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_ProcessName;
        private Button buttonSacve;
        private Label label1;
        private ComboBox comboBox_ProcessGroup;
        private Label label2;
    }
}