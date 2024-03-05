using System.Windows.Forms;

namespace CDSystem.手动作业
{
    partial class Form流程信息
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form流程信息));
            userControl流程信息1 = new UserControl流程信息();
            SuspendLayout();
            // 
            // userControl流程信息1
            // 
            userControl流程信息1.Dock = DockStyle.Fill;
            userControl流程信息1.Location = new Point(0, 0);
            userControl流程信息1.Name = "userControl流程信息1";
            userControl流程信息1.Size = new Size(1744, 911);
            userControl流程信息1.TabIndex = 0;
            // 
            // Form流程信息
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1744, 911);
            Controls.Add(userControl流程信息1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form流程信息";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "流程信息";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private UserControl流程信息 userControl流程信息1;
    }
}