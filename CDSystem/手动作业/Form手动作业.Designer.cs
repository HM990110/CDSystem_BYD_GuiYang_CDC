namespace CDSystem.手动作业
{
    partial class Form手动作业
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
            userControl流程信息1 = new UserControl流程信息();
            panel1 = new FlowLayoutPanel();
            label1 = new Label();
            comboBox_ProcessGroup = new ComboBox();
            ButtonRead = new Button();
            ButtonInsert = new Button();
            ButtonDelete = new Button();
            ButtonSave = new Button();
            ButtonSaveAs = new Button();
            buttonSend = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userControl流程信息1
            // 
            userControl流程信息1.Dock = DockStyle.Fill;
            userControl流程信息1.Location = new Point(5, 45);
            userControl流程信息1.Name = "userControl流程信息1";
            userControl流程信息1.Size = new Size(1910, 899);
            userControl流程信息1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox_ProcessGroup);
            panel1.Controls.Add(ButtonRead);
            panel1.Controls.Add(ButtonInsert);
            panel1.Controls.Add(ButtonDelete);
            panel1.Controls.Add(ButtonSave);
            panel1.Controls.Add(ButtonSaveAs);
            panel1.Controls.Add(buttonSend);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1910, 40);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(11, 11);
            label1.Margin = new Padding(11, 11, 0, 11);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 1;
            label1.Text = "选择流程：";
            // 
            // comboBox_ProcessGroup
            // 
            comboBox_ProcessGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ProcessGroup.Font = new Font("微软雅黑", 10F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox_ProcessGroup.FormattingEnabled = true;
            comboBox_ProcessGroup.Location = new Point(79, 6);
            comboBox_ProcessGroup.Margin = new Padding(0, 6, 6, 6);
            comboBox_ProcessGroup.Name = "comboBox_ProcessGroup";
            comboBox_ProcessGroup.Size = new Size(252, 27);
            comboBox_ProcessGroup.TabIndex = 0;
            comboBox_ProcessGroup.SelectedIndexChanged += ProcessGroup_SelectedIndexChanged;
            // 
            // ButtonRead
            // 
            ButtonRead.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRead.Location = new Point(342, 5);
            ButtonRead.Margin = new Padding(5);
            ButtonRead.Name = "ButtonRead";
            ButtonRead.Size = new Size(75, 30);
            ButtonRead.TabIndex = 9;
            ButtonRead.Text = "读取";
            ButtonRead.UseVisualStyleBackColor = true;
            ButtonRead.Click += ButtonRead_Click;
            // 
            // ButtonInsert
            // 
            ButtonInsert.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonInsert.Location = new Point(427, 5);
            ButtonInsert.Margin = new Padding(5);
            ButtonInsert.Name = "ButtonInsert";
            ButtonInsert.Size = new Size(75, 30);
            ButtonInsert.TabIndex = 5;
            ButtonInsert.Text = "添加";
            ButtonInsert.UseVisualStyleBackColor = true;
            ButtonInsert.Click += Button_Insert_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDelete.Location = new Point(512, 5);
            ButtonDelete.Margin = new Padding(5);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 30);
            ButtonDelete.TabIndex = 4;
            ButtonDelete.Text = "删除";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += Button_Delete_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSave.Location = new Point(597, 5);
            ButtonSave.Margin = new Padding(5);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 30);
            ButtonSave.TabIndex = 6;
            ButtonSave.Text = "保存";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += Button_Save_Click;
            // 
            // ButtonSaveAs
            // 
            ButtonSaveAs.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSaveAs.Location = new Point(682, 5);
            ButtonSaveAs.Margin = new Padding(5);
            ButtonSaveAs.Name = "ButtonSaveAs";
            ButtonSaveAs.Size = new Size(75, 30);
            ButtonSaveAs.TabIndex = 10;
            ButtonSaveAs.Text = "另存为";
            ButtonSaveAs.UseVisualStyleBackColor = true;
            ButtonSaveAs.Click += ButtonSaveAs_Click;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSend.Location = new Point(812, 5);
            buttonSend.Margin = new Padding(50, 5, 0, 5);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 30);
            buttonSend.TabIndex = 8;
            buttonSend.Text = "发送";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += ButtonSend_Click;
            // 
            // Form手动作业
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1920, 949);
            Controls.Add(userControl流程信息1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form手动作业";
            Padding = new Padding(5);
            Text = "Form手动作业";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UserControl流程信息 userControl流程信息1;
        private FlowLayoutPanel panel1;
        private Button ButtonDelete;
        private Button ButtonInsert;
        private Button ButtonSave;
        private Button buttonSend;
        private Label label1;
        private ComboBox comboBox_ProcessGroup;
        private Button ButtonRead;
        private Button ButtonSaveAs;
    }
}