namespace CDSystem
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTitle = new Panel();
            LabelItemTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button主页 = new Button();
            button传感数据 = new Button();
            button实时数据 = new Button();
            button手动作业 = new Button();
            button运行记录 = new Button();
            button历史数据 = new Button();
            button系统设置 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            登录ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panelTitle.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(72, 76, 127);
            panelTitle.Controls.Add(LabelItemTitle);
            panelTitle.Controls.Add(flowLayoutPanel1);
            panelTitle.Controls.Add(pictureBox2);
            panelTitle.Controls.Add(tableLayoutPanel1);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1904, 60);
            panelTitle.TabIndex = 3;
            // 
            // LabelItemTitle
            // 
            LabelItemTitle.AutoSize = true;
            LabelItemTitle.BackColor = Color.FromArgb(72, 76, 127);
            LabelItemTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelItemTitle.ForeColor = Color.White;
            LabelItemTitle.Location = new Point(60, 15);
            LabelItemTitle.Margin = new Padding(0);
            LabelItemTitle.Name = "LabelItemTitle";
            LabelItemTitle.Size = new Size(96, 28);
            LabelItemTitle.TabIndex = 6;
            LabelItemTitle.Text = "库位信息";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(button主页);
            flowLayoutPanel1.Controls.Add(button传感数据);
            flowLayoutPanel1.Controls.Add(button实时数据);
            flowLayoutPanel1.Controls.Add(button手动作业);
            flowLayoutPanel1.Controls.Add(button运行记录);
            flowLayoutPanel1.Controls.Add(button历史数据);
            flowLayoutPanel1.Controls.Add(button系统设置);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(730, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1041, 60);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // button主页
            // 
            button主页.BackColor = Color.FromArgb(72, 76, 127);
            button主页.BackgroundImage = Properties.Resources.菜单单元背景选中;
            button主页.BackgroundImageLayout = ImageLayout.Stretch;
            button主页.FlatAppearance.BorderColor = Color.FromArgb(72, 76, 127);
            button主页.FlatAppearance.BorderSize = 0;
            button主页.FlatAppearance.CheckedBackColor = Color.White;
            button主页.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 127);
            button主页.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 76, 127);
            button主页.FlatStyle = FlatStyle.Flat;
            button主页.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button主页.Location = new Point(0, 20);
            button主页.Margin = new Padding(0, 20, 0, 0);
            button主页.Name = "button主页";
            button主页.Size = new Size(130, 40);
            button主页.TabIndex = 13;
            button主页.Tag = "主页";
            button主页.Text = "主页";
            button主页.UseVisualStyleBackColor = false;
            button主页.Click += Button_BtnClick;
            button主页.MouseEnter += Button_MouseEnter;
            button主页.MouseLeave += Button_MouseLeave;
            // 
            // button传感数据
            // 
            button传感数据.BackColor = Color.FromArgb(72, 76, 127);
            button传感数据.BackgroundImage = Properties.Resources.菜单单元背景常态;
            button传感数据.BackgroundImageLayout = ImageLayout.Stretch;
            button传感数据.FlatAppearance.BorderColor = Color.FromArgb(72, 76, 127);
            button传感数据.FlatAppearance.BorderSize = 0;
            button传感数据.FlatAppearance.CheckedBackColor = Color.White;
            button传感数据.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 127);
            button传感数据.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 76, 127);
            button传感数据.FlatStyle = FlatStyle.Flat;
            button传感数据.Location = new Point(130, 20);
            button传感数据.Margin = new Padding(0, 20, 0, 0);
            button传感数据.Name = "button传感数据";
            button传感数据.Size = new Size(130, 40);
            button传感数据.TabIndex = 19;
            button传感数据.Tag = "传感数据";
            button传感数据.Text = "传感数据";
            button传感数据.UseVisualStyleBackColor = false;
            button传感数据.Click += Button_BtnClick;
            button传感数据.MouseEnter += Button_MouseEnter;
            button传感数据.MouseLeave += Button_MouseLeave;
            // 
            // button实时数据
            // 
            button实时数据.BackColor = Color.FromArgb(72, 76, 127);
            button实时数据.BackgroundImage = Properties.Resources.菜单单元背景常态;
            button实时数据.BackgroundImageLayout = ImageLayout.Stretch;
            button实时数据.FlatAppearance.BorderColor = Color.FromArgb(72, 76, 127);
            button实时数据.FlatAppearance.BorderSize = 0;
            button实时数据.FlatAppearance.CheckedBackColor = Color.White;
            button实时数据.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 127);
            button实时数据.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 76, 127);
            button实时数据.FlatStyle = FlatStyle.Flat;
            button实时数据.Location = new Point(260, 20);
            button实时数据.Margin = new Padding(0, 20, 0, 0);
            button实时数据.Name = "button实时数据";
            button实时数据.Size = new Size(130, 40);
            button实时数据.TabIndex = 14;
            button实时数据.Tag = "实时数据";
            button实时数据.Text = "实时数据";
            button实时数据.UseVisualStyleBackColor = false;
            button实时数据.Click += Button_BtnClick;
            button实时数据.MouseEnter += Button_MouseEnter;
            button实时数据.MouseLeave += Button_MouseLeave;
            // 
            // button手动作业
            // 
            button手动作业.BackColor = Color.FromArgb(72, 76, 127);
            button手动作业.BackgroundImage = Properties.Resources.菜单单元背景常态;
            button手动作业.BackgroundImageLayout = ImageLayout.Stretch;
            button手动作业.FlatAppearance.BorderColor = Color.FromArgb(72, 76, 127);
            button手动作业.FlatAppearance.BorderSize = 0;
            button手动作业.FlatAppearance.CheckedBackColor = Color.White;
            button手动作业.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 127);
            button手动作业.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 76, 127);
            button手动作业.FlatStyle = FlatStyle.Flat;
            button手动作业.Location = new Point(390, 20);
            button手动作业.Margin = new Padding(0, 20, 0, 0);
            button手动作业.Name = "button手动作业";
            button手动作业.Size = new Size(130, 40);
            button手动作业.TabIndex = 16;
            button手动作业.Tag = "手动作业";
            button手动作业.Text = "手动作业";
            button手动作业.UseVisualStyleBackColor = false;
            button手动作业.Click += Button_BtnClick;
            button手动作业.MouseEnter += Button_MouseEnter;
            button手动作业.MouseLeave += Button_MouseLeave;
            // 
            // button运行记录
            // 
            button运行记录.BackColor = Color.FromArgb(72, 76, 127);
            button运行记录.BackgroundImage = Properties.Resources.菜单单元背景常态;
            button运行记录.BackgroundImageLayout = ImageLayout.Stretch;
            button运行记录.FlatAppearance.BorderColor = Color.FromArgb(72, 76, 127);
            button运行记录.FlatAppearance.BorderSize = 0;
            button运行记录.FlatAppearance.CheckedBackColor = Color.White;
            button运行记录.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 127);
            button运行记录.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 76, 127);
            button运行记录.FlatStyle = FlatStyle.Flat;
            button运行记录.Location = new Point(520, 20);
            button运行记录.Margin = new Padding(0, 20, 0, 0);
            button运行记录.Name = "button运行记录";
            button运行记录.Size = new Size(130, 40);
            button运行记录.TabIndex = 17;
            button运行记录.Tag = "运行记录";
            button运行记录.Text = "运行记录";
            button运行记录.UseVisualStyleBackColor = false;
            button运行记录.Click += Button运行记录_Click;
            button运行记录.MouseEnter += Button_MouseEnter;
            button运行记录.MouseLeave += Button_MouseLeave;
            // 
            // button历史数据
            // 
            button历史数据.BackColor = Color.FromArgb(72, 76, 127);
            button历史数据.BackgroundImage = Properties.Resources.菜单单元背景常态;
            button历史数据.BackgroundImageLayout = ImageLayout.Stretch;
            button历史数据.FlatAppearance.BorderColor = Color.FromArgb(72, 76, 127);
            button历史数据.FlatAppearance.BorderSize = 0;
            button历史数据.FlatAppearance.CheckedBackColor = Color.White;
            button历史数据.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 127);
            button历史数据.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 76, 127);
            button历史数据.FlatStyle = FlatStyle.Flat;
            button历史数据.Location = new Point(650, 20);
            button历史数据.Margin = new Padding(0, 20, 0, 0);
            button历史数据.Name = "button历史数据";
            button历史数据.Size = new Size(130, 40);
            button历史数据.TabIndex = 15;
            button历史数据.Tag = "历史数据";
            button历史数据.Text = "历史数据";
            button历史数据.UseVisualStyleBackColor = false;
            button历史数据.Click += Button历史数据_Click;
            button历史数据.MouseEnter += Button_MouseEnter;
            button历史数据.MouseLeave += Button_MouseLeave;
            // 
            // button系统设置
            // 
            button系统设置.BackColor = Color.FromArgb(72, 76, 127);
            button系统设置.BackgroundImage = Properties.Resources.菜单单元背景常态;
            button系统设置.BackgroundImageLayout = ImageLayout.Stretch;
            button系统设置.FlatAppearance.BorderColor = Color.FromArgb(72, 76, 127);
            button系统设置.FlatAppearance.BorderSize = 0;
            button系统设置.FlatAppearance.CheckedBackColor = Color.White;
            button系统设置.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 127);
            button系统设置.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 76, 127);
            button系统设置.FlatStyle = FlatStyle.Flat;
            button系统设置.Location = new Point(780, 20);
            button系统设置.Margin = new Padding(0, 20, 0, 0);
            button系统设置.Name = "button系统设置";
            button系统设置.Size = new Size(130, 40);
            button系统设置.TabIndex = 18;
            button系统设置.Tag = "系统设置";
            button系统设置.Text = "系统设置";
            button系统设置.UseVisualStyleBackColor = false;
            button系统设置.Click += Button_BtnClick;
            button系统设置.MouseEnter += Button_MouseEnter;
            button系统设置.MouseLeave += Button_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(913, 35);
            label3.Margin = new Padding(3, 35, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 21;
            label3.Text = "语言切换:";
            label3.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "zh", "en" });
            comboBox1.Location = new Point(978, 30);
            comboBox1.Margin = new Padding(3, 30, 3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(60, 25);
            comboBox1.TabIndex = 20;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(72, 76, 127);
            pictureBox2.Image = Properties.Resources.设备状态ancient_gate_fill;
            pictureBox2.Location = new Point(5, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(5);
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ContextMenuStrip = contextMenuStrip1;
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(1771, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(133, 60);
            tableLayoutPanel1.TabIndex = 20;
            tableLayoutPanel1.Click += Login_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 登录ToolStripMenuItem, 退出ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 48);
            // 
            // 登录ToolStripMenuItem
            // 
            登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            登录ToolStripMenuItem.Size = new Size(100, 22);
            登录ToolStripMenuItem.Text = "登录";
            登录ToolStripMenuItem.Click += 登录ToolStripMenuItem_Click;
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(100, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.无人值守;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel1.SetRowSpan(pictureBox1, 2);
            pictureBox1.Size = new Size(54, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Login_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ContextMenuStrip = contextMenuStrip1;
            label1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(63, 5);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += Login_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ContextMenuStrip = contextMenuStrip1;
            label2.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(63, 40);
            label2.Name = "label2";
            label2.Size = new Size(38, 16);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += Login_Click;
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1904, 900);
            Controls.Add(panelTitle);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "主页";
            Text = "CDSystem";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelTitle;
        private Button button主页;
        private Button button实时数据;
        private Button button历史数据;
        private Button button手动作业;
        private Button button运行记录;
        private Button button系统设置;
        private Label LabelItemTitle;
        private Button button传感数据;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 登录ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ComboBox comboBox1;
        private Label label3;
    }
}

