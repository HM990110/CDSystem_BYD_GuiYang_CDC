using CDSystem.手动作业;
using System.Windows.Forms;

namespace CDGraph
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            button_OpenFile = new Button();
            ProcessBar1 = new ProgressBar();
            UserControl曲线 = new UserControl曲线();
            UserControl结果数据 = new UserControl结果数据();
            UserControl流程信息 = new UserControl流程信息();
            panel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_OpenFile
            // 
            button_OpenFile.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_OpenFile.Location = new Point(620, 4);
            button_OpenFile.Margin = new Padding(4);
            button_OpenFile.Name = "button_OpenFile";
            button_OpenFile.Size = new Size(89, 30);
            button_OpenFile.TabIndex = 38;
            button_OpenFile.Text = "打开文件";
            button_OpenFile.UseVisualStyleBackColor = true;
            button_OpenFile.Click += Button_OpenFile_Click;
            // 
            // ProcessBar1
            // 
            ProcessBar1.Anchor = AnchorStyles.None;
            ProcessBar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProcessBar1.Location = new Point(652, 490);
            ProcessBar1.Margin = new Padding(4);
            ProcessBar1.MinimumSize = new Size(82, 4);
            ProcessBar1.Name = "ProcessBar1";
            ProcessBar1.Size = new Size(600, 60);
            ProcessBar1.TabIndex = 42;
            ProcessBar1.Text = "uiProcessBar1";
            ProcessBar1.Visible = false;
            // 
            // UserControl曲线
            // 
            UserControl曲线.BackColor = Color.White;
            UserControl曲线.Dock = DockStyle.Fill;
            UserControl曲线.Location = new Point(0, 39);
            UserControl曲线.Margin = new Padding(4);
            UserControl曲线.Name = "UserControl曲线";
            UserControl曲线.Size = new Size(1904, 1002);
            UserControl曲线.TabIndex = 0;
            // 
            // UserControl结果数据
            // 
            UserControl结果数据.BackColor = Color.White;
            UserControl结果数据.Dock = DockStyle.Fill;
            UserControl结果数据.Location = new Point(0, 39);
            UserControl结果数据.Name = "UserControl结果数据";
            UserControl结果数据.Size = new Size(1904, 1002);
            UserControl结果数据.TabIndex = 0;
            // 
            // UserControl流程信息
            // 
            UserControl流程信息.Dock = DockStyle.Fill;
            UserControl流程信息.Location = new Point(0, 39);
            UserControl流程信息.Name = "UserControl流程信息";
            UserControl流程信息.Size = new Size(1904, 1002);
            UserControl流程信息.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.AutoSize = true;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button_OpenFile);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 39);
            panel1.TabIndex = 45;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(8, 8);
            textBox1.Margin = new Padding(8);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(600, 23);
            textBox1.TabIndex = 85;
            // 
            // button2
            // 
            button2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(717, 4);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(89, 30);
            button2.TabIndex = 86;
            button2.Text = "导出Excel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(910, 4);
            button1.Margin = new Padding(100, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(89, 30);
            button1.TabIndex = 89;
            button1.Text = "曲线图";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(1007, 4);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(89, 30);
            button4.TabIndex = 88;
            button4.Text = "结果数据";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(1104, 4);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(89, 30);
            button5.TabIndex = 87;
            button5.Text = "流程信息";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // FormMain
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1904, 1041);
            Controls.Add(ProcessBar1);
            Controls.Add(UserControl曲线);
            Controls.Add(UserControl结果数据);
            Controls.Add(UserControl流程信息);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "充放电曲线";
            Load += FormMain_Load;
            DragDrop += FormMain_DragDrop;
            DragOver += FormMain_DragOver;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_OpenFile;
        private ProgressBar ProcessBar1;
        private FlowLayoutPanel panel1;
        private UserControl结果数据 UserControl结果数据;
        private UserControl流程信息 UserControl流程信息;
        private TextBox textBox1;
        private Button button2;
        private UserControl曲线 UserControl曲线;
        private Button button1;
        private Button button4;
        private Button button5;
    }
}

