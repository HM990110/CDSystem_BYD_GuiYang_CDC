namespace CDSystem.设备状态
{
    partial class Form设备信息
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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button6 = new Button();
            tableLayoutPanelDevice = new TableLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            流程信息ToolStripMenuItem = new ToolStripMenuItem();
            设备日志ToolStripMenuItem = new ToolStripMenuItem();
            传感数据ToolStripMenuItem = new ToolStripMenuItem();
            实时数据ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            初始操作ToolStripMenuItem = new ToolStripMenuItem();
            掉电操作ToolStripMenuItem = new ToolStripMenuItem();
            掉电清除ToolStripMenuItem = new ToolStripMenuItem();
            掉电恢复ToolStripMenuItem = new ToolStripMenuItem();
            自动手动切换ToolStripMenuItem = new ToolStripMenuItem();
            切置自动ToolStripMenuItem = new ToolStripMenuItem();
            预约手动ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            停止流程ToolStripMenuItem = new ToolStripMenuItem();
            重新作业ToolStripMenuItem = new ToolStripMenuItem();
            发送流程ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            强制出库ToolStripMenuItem = new ToolStripMenuItem();
            设备维护ToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            label15 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            labelWMS = new Label();
            groupBox无通信 = new GroupBox();
            label无通信 = new Label();
            groupBox1 = new GroupBox();
            label未启用 = new Label();
            groupBox2 = new GroupBox();
            label报警 = new Label();
            groupBox6 = new GroupBox();
            label作业完成 = new Label();
            groupBox3 = new GroupBox();
            label作业中 = new Label();
            groupBox5 = new GroupBox();
            label作业准备 = new Label();
            groupBox4 = new GroupBox();
            label闲置 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox无通信.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(400, 40);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 5);
            button1.Margin = new Padding(0, 5, 0, 5);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 2;
            button1.Tag = "设备状态";
            button1.Text = "设备状态";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Silver;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            button2.FlatAppearance.MouseDownBackColor = Color.Silver;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(100, 5);
            button2.Margin = new Padding(0, 5, 0, 5);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 3;
            button2.Tag = "流程状态";
            button2.Text = "流程状态";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.Silver;
            button4.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            button4.FlatAppearance.MouseDownBackColor = Color.Silver;
            button4.FlatAppearance.MouseOverBackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(200, 5);
            button4.Margin = new Padding(0, 5, 0, 5);
            button4.Name = "button4";
            button4.Size = new Size(100, 30);
            button4.TabIndex = 5;
            button4.Tag = "托盘信息";
            button4.Text = "托盘信息";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderColor = Color.Silver;
            button6.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            button6.FlatAppearance.MouseDownBackColor = Color.Silver;
            button6.FlatAppearance.MouseOverBackColor = Color.Silver;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(300, 5);
            button6.Margin = new Padding(0, 5, 0, 5);
            button6.Name = "button6";
            button6.Size = new Size(100, 30);
            button6.TabIndex = 7;
            button6.Tag = "MCU信息";
            button6.Text = "MCU信息";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Button_Click;
            // 
            // tableLayoutPanelDevice
            // 
            tableLayoutPanelDevice.ColumnCount = 1;
            tableLayoutPanelDevice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelDevice.Dock = DockStyle.Fill;
            tableLayoutPanelDevice.Location = new Point(5, 45);
            tableLayoutPanelDevice.Name = "tableLayoutPanelDevice";
            tableLayoutPanelDevice.RowCount = 1;
            tableLayoutPanelDevice.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelDevice.Size = new Size(1894, 660);
            tableLayoutPanelDevice.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 流程信息ToolStripMenuItem, 设备日志ToolStripMenuItem, 传感数据ToolStripMenuItem, 实时数据ToolStripMenuItem, toolStripSeparator1, 初始操作ToolStripMenuItem, 掉电操作ToolStripMenuItem, 自动手动切换ToolStripMenuItem, toolStripSeparator2, 停止流程ToolStripMenuItem, 重新作业ToolStripMenuItem, 发送流程ToolStripMenuItem, toolStripSeparator3, 强制出库ToolStripMenuItem, 设备维护ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(130, 286);
            contextMenuStrip1.LocationChanged += ContextMenuStrip1_LocationChanged;
            // 
            // 流程信息ToolStripMenuItem
            // 
            流程信息ToolStripMenuItem.Name = "流程信息ToolStripMenuItem";
            流程信息ToolStripMenuItem.Size = new Size(129, 22);
            流程信息ToolStripMenuItem.Text = "流程信息";
            流程信息ToolStripMenuItem.Click += 流程信息ToolStripMenuItem_Click;
            // 
            // 设备日志ToolStripMenuItem
            // 
            设备日志ToolStripMenuItem.Name = "设备日志ToolStripMenuItem";
            设备日志ToolStripMenuItem.Size = new Size(129, 22);
            设备日志ToolStripMenuItem.Text = "运行记录";
            设备日志ToolStripMenuItem.Click += 设备日志ToolStripMenuItem_Click;
            // 
            // 传感数据ToolStripMenuItem
            // 
            传感数据ToolStripMenuItem.Name = "传感数据ToolStripMenuItem";
            传感数据ToolStripMenuItem.Size = new Size(129, 22);
            传感数据ToolStripMenuItem.Text = "传感数据";
            传感数据ToolStripMenuItem.Click += 传感数据ToolStripMenuItem_Click;
            // 
            // 实时数据ToolStripMenuItem
            // 
            实时数据ToolStripMenuItem.Name = "实时数据ToolStripMenuItem";
            实时数据ToolStripMenuItem.Size = new Size(129, 22);
            实时数据ToolStripMenuItem.Text = "实时数据";
            实时数据ToolStripMenuItem.Click += 实时数据ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(126, 6);
            // 
            // 初始操作ToolStripMenuItem
            // 
            初始操作ToolStripMenuItem.Name = "初始操作ToolStripMenuItem";
            初始操作ToolStripMenuItem.Size = new Size(129, 22);
            初始操作ToolStripMenuItem.Text = "初始操作";
            初始操作ToolStripMenuItem.Click += 初始操作ToolStripMenuItem_Click;
            // 
            // 掉电操作ToolStripMenuItem
            // 
            掉电操作ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 掉电清除ToolStripMenuItem, 掉电恢复ToolStripMenuItem });
            掉电操作ToolStripMenuItem.Name = "掉电操作ToolStripMenuItem";
            掉电操作ToolStripMenuItem.Size = new Size(129, 22);
            掉电操作ToolStripMenuItem.Text = "掉电操作";
            // 
            // 掉电清除ToolStripMenuItem
            // 
            掉电清除ToolStripMenuItem.Name = "掉电清除ToolStripMenuItem";
            掉电清除ToolStripMenuItem.Size = new Size(124, 22);
            掉电清除ToolStripMenuItem.Text = "掉电清除";
            掉电清除ToolStripMenuItem.Click += 掉电清除ToolStripMenuItem_Click;
            // 
            // 掉电恢复ToolStripMenuItem
            // 
            掉电恢复ToolStripMenuItem.Name = "掉电恢复ToolStripMenuItem";
            掉电恢复ToolStripMenuItem.Size = new Size(124, 22);
            掉电恢复ToolStripMenuItem.Text = "掉电恢复";
            掉电恢复ToolStripMenuItem.Click += 掉电恢复ToolStripMenuItem_Click;
            // 
            // 自动手动切换ToolStripMenuItem
            // 
            自动手动切换ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 切置自动ToolStripMenuItem, 预约手动ToolStripMenuItem });
            自动手动切换ToolStripMenuItem.Name = "自动手动切换ToolStripMenuItem";
            自动手动切换ToolStripMenuItem.Size = new Size(129, 22);
            自动手动切换ToolStripMenuItem.Text = "自动/手动";
            // 
            // 切置自动ToolStripMenuItem
            // 
            切置自动ToolStripMenuItem.Name = "切置自动ToolStripMenuItem";
            切置自动ToolStripMenuItem.Size = new Size(124, 22);
            切置自动ToolStripMenuItem.Text = "切置自动";
            切置自动ToolStripMenuItem.Click += 切置自动ToolStripMenuItem_Click;
            // 
            // 预约手动ToolStripMenuItem
            // 
            预约手动ToolStripMenuItem.Name = "预约手动ToolStripMenuItem";
            预约手动ToolStripMenuItem.Size = new Size(124, 22);
            预约手动ToolStripMenuItem.Text = "预约手动";
            预约手动ToolStripMenuItem.Click += 预约手动ToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(126, 6);
            // 
            // 停止流程ToolStripMenuItem
            // 
            停止流程ToolStripMenuItem.Name = "停止流程ToolStripMenuItem";
            停止流程ToolStripMenuItem.Size = new Size(129, 22);
            停止流程ToolStripMenuItem.Text = "停止流程";
            停止流程ToolStripMenuItem.Click += 停止流程ToolStripMenuItem_Click;
            // 
            // 重新作业ToolStripMenuItem
            // 
            重新作业ToolStripMenuItem.Name = "重新作业ToolStripMenuItem";
            重新作业ToolStripMenuItem.Size = new Size(129, 22);
            重新作业ToolStripMenuItem.Text = "重新作业";
            重新作业ToolStripMenuItem.Click += 重新作业ToolStripMenuItem_Click;
            // 
            // 发送流程ToolStripMenuItem
            // 
            发送流程ToolStripMenuItem.Name = "发送流程ToolStripMenuItem";
            发送流程ToolStripMenuItem.Size = new Size(129, 22);
            发送流程ToolStripMenuItem.Text = "发送流程";
            发送流程ToolStripMenuItem.Click += 发送流程ToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(126, 6);
            // 
            // 强制出库ToolStripMenuItem
            // 
            强制出库ToolStripMenuItem.Name = "强制出库ToolStripMenuItem";
            强制出库ToolStripMenuItem.Size = new Size(129, 22);
            强制出库ToolStripMenuItem.Text = "强制出库";
            强制出库ToolStripMenuItem.Click += 强制出库ToolStripMenuItem_Click;
            // 
            // 设备维护ToolStripMenuItem
            // 
            设备维护ToolStripMenuItem.Name = "设备维护ToolStripMenuItem";
            设备维护ToolStripMenuItem.Size = new Size(129, 22);
            设备维护ToolStripMenuItem.Text = "设备维护";
            设备维护ToolStripMenuItem.Click += 设备维护ToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 16;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66698647F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666986F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66698647F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.664987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.664177F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label15, 10, 0);
            tableLayoutPanel1.Controls.Add(label8, 7, 0);
            tableLayoutPanel1.Controls.Add(label7, 6, 0);
            tableLayoutPanel1.Controls.Add(label6, 5, 0);
            tableLayoutPanel1.Controls.Add(label5, 4, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label10, 8, 0);
            tableLayoutPanel1.Controls.Add(label11, 9, 0);
            tableLayoutPanel1.Controls.Add(label9, 14, 0);
            tableLayoutPanel1.Controls.Add(label12, 13, 0);
            tableLayoutPanel1.Controls.Add(label13, 12, 0);
            tableLayoutPanel1.Controls.Add(label14, 11, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(5, 705);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1894, 50);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.BackColor = Color.Maroon;
            label15.ImeMode = ImeMode.NoControl;
            label15.Location = new Point(1263, 3);
            label15.Margin = new Padding(3);
            label15.Name = "label15";
            label15.Size = new Size(120, 44);
            label15.TabIndex = 13;
            label15.Text = "火警";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.BackColor = Color.Gold;
            label8.Location = new Point(885, 3);
            label8.Margin = new Padding(3);
            label8.Name = "label8";
            label8.Size = new Size(120, 44);
            label8.TabIndex = 7;
            label8.Text = "作业完成\r\n等待出库";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = Color.Yellow;
            label7.Location = new Point(759, 3);
            label7.Margin = new Padding(3);
            label7.Name = "label7";
            label7.Size = new Size(120, 44);
            label7.TabIndex = 6;
            label7.Text = "流程中";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = Color.GreenYellow;
            label6.Location = new Point(633, 3);
            label6.Margin = new Padding(3);
            label6.Name = "label6";
            label6.Size = new Size(120, 44);
            label6.TabIndex = 5;
            label6.Text = "流程等待";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Green;
            label5.Location = new Point(507, 3);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(120, 44);
            label5.TabIndex = 4;
            label5.Text = "流程准备";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Blue;
            label4.Location = new Point(381, 3);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(120, 44);
            label4.TabIndex = 3;
            label4.Text = "托盘进入";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Silver;
            label3.Location = new Point(255, 3);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(120, 44);
            label3.TabIndex = 2;
            label3.Text = "无通信";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Gray;
            label2.Location = new Point(129, 3);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(120, 44);
            label2.TabIndex = 1;
            label2.Text = "未启用";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Cyan;
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(120, 44);
            label1.TabIndex = 0;
            label1.Text = "初始状态";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.Red;
            label10.Location = new Point(1011, 3);
            label10.Margin = new Padding(3);
            label10.Name = "label10";
            label10.Size = new Size(120, 44);
            label10.TabIndex = 9;
            label10.Text = "机构错误\r\n真空测试报警";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.BackColor = Color.DarkRed;
            label11.Location = new Point(1137, 3);
            label11.Margin = new Padding(3);
            label11.Name = "label11";
            label11.Size = new Size(120, 44);
            label11.TabIndex = 10;
            label11.Text = "超温报警\r\n烟雾报警";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.BackColor = Color.OrangeRed;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(1767, 3);
            label9.Margin = new Padding(3);
            label9.Name = "label9";
            label9.Size = new Size(120, 44);
            label9.TabIndex = 12;
            label9.Text = "托盘位置错误";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.BackColor = Color.HotPink;
            label12.Location = new Point(1641, 3);
            label12.Margin = new Padding(3);
            label12.Name = "label12";
            label12.Size = new Size(120, 44);
            label12.TabIndex = 11;
            label12.Text = "掉电标记";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.BackColor = Color.DeepPink;
            label13.Location = new Point(1515, 3);
            label13.Margin = new Padding(3);
            label13.Name = "label13";
            label13.Size = new Size(120, 44);
            label13.TabIndex = 12;
            label13.Text = "充放电测试报警\r\n上位机报警";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.BackColor = Color.Purple;
            label14.Location = new Point(1389, 3);
            label14.Margin = new Padding(3);
            label14.Name = "label14";
            label14.Size = new Size(120, 44);
            label14.TabIndex = 13;
            label14.Text = "超时";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1894, 40);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(labelWMS);
            flowLayoutPanel2.Controls.Add(groupBox无通信);
            flowLayoutPanel2.Controls.Add(groupBox1);
            flowLayoutPanel2.Controls.Add(groupBox2);
            flowLayoutPanel2.Controls.Add(groupBox6);
            flowLayoutPanel2.Controls.Add(groupBox3);
            flowLayoutPanel2.Controls.Add(groupBox5);
            flowLayoutPanel2.Controls.Add(groupBox4);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(817, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1077, 40);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // labelWMS
            // 
            labelWMS.BackColor = Color.Yellow;
            labelWMS.BorderStyle = BorderStyle.FixedSingle;
            labelWMS.Location = new Point(3, 3);
            labelWMS.Margin = new Padding(3);
            labelWMS.Name = "labelWMS";
            labelWMS.Size = new Size(203, 34);
            labelWMS.TabIndex = 7;
            labelWMS.Text = "WMS连接成功";
            labelWMS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox无通信
            // 
            groupBox无通信.Controls.Add(label无通信);
            groupBox无通信.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox无通信.Location = new Point(211, 2);
            groupBox无通信.Margin = new Padding(2);
            groupBox无通信.Name = "groupBox无通信";
            groupBox无通信.Padding = new Padding(1, 0, 1, 2);
            groupBox无通信.Size = new Size(120, 36);
            groupBox无通信.TabIndex = 3;
            groupBox无通信.TabStop = false;
            groupBox无通信.Text = "无通信";
            // 
            // label无通信
            // 
            label无通信.Dock = DockStyle.Fill;
            label无通信.Location = new Point(1, 14);
            label无通信.Name = "label无通信";
            label无通信.Size = new Size(118, 20);
            label无通信.TabIndex = 1;
            label无通信.Text = "0";
            label无通信.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label未启用);
            groupBox1.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(335, 2);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 0, 1, 2);
            groupBox1.Size = new Size(120, 36);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "未启用";
            // 
            // label未启用
            // 
            label未启用.Dock = DockStyle.Fill;
            label未启用.Location = new Point(1, 14);
            label未启用.Name = "label未启用";
            label未启用.Size = new Size(118, 20);
            label未启用.TabIndex = 1;
            label未启用.Text = "0";
            label未启用.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label报警);
            groupBox2.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(459, 2);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(1, 0, 1, 2);
            groupBox2.Size = new Size(120, 36);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "报警";
            // 
            // label报警
            // 
            label报警.Dock = DockStyle.Fill;
            label报警.Location = new Point(1, 14);
            label报警.Name = "label报警";
            label报警.Size = new Size(118, 20);
            label报警.TabIndex = 1;
            label报警.Text = "0";
            label报警.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label作业完成);
            groupBox6.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(583, 2);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(1, 0, 1, 2);
            groupBox6.Size = new Size(120, 36);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "作业完成";
            // 
            // label作业完成
            // 
            label作业完成.Dock = DockStyle.Fill;
            label作业完成.Location = new Point(1, 14);
            label作业完成.Name = "label作业完成";
            label作业完成.Size = new Size(118, 20);
            label作业完成.TabIndex = 1;
            label作业完成.Text = "0";
            label作业完成.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label作业中);
            groupBox3.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(707, 2);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(1, 0, 1, 2);
            groupBox3.Size = new Size(120, 36);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "作业中";
            // 
            // label作业中
            // 
            label作业中.Dock = DockStyle.Fill;
            label作业中.Location = new Point(1, 14);
            label作业中.Name = "label作业中";
            label作业中.Size = new Size(118, 20);
            label作业中.TabIndex = 1;
            label作业中.Text = "0";
            label作业中.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label作业准备);
            groupBox5.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(831, 2);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(1, 0, 1, 2);
            groupBox5.Size = new Size(120, 36);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "作业准备";
            // 
            // label作业准备
            // 
            label作业准备.Dock = DockStyle.Fill;
            label作业准备.Location = new Point(1, 14);
            label作业准备.Name = "label作业准备";
            label作业准备.Size = new Size(118, 20);
            label作业准备.TabIndex = 1;
            label作业准备.Text = "0";
            label作业准备.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label闲置);
            groupBox4.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(955, 2);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(1, 0, 1, 2);
            groupBox4.Size = new Size(120, 36);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "闲置";
            // 
            // label闲置
            // 
            label闲置.Dock = DockStyle.Fill;
            label闲置.Location = new Point(1, 14);
            label闲置.Margin = new Padding(3);
            label闲置.Name = "label闲置";
            label闲置.Size = new Size(118, 20);
            label闲置.TabIndex = 0;
            label闲置.Text = "0";
            label闲置.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(5, 755);
            panel2.Name = "panel2";
            panel2.Size = new Size(1894, 150);
            panel2.TabIndex = 4;
            // 
            // Form设备信息
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1904, 910);
            Controls.Add(tableLayoutPanelDevice);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form设备信息";
            Padding = new Padding(5);
            flowLayoutPanel1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            groupBox无通信.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanelDevice;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 流程信息ToolStripMenuItem;
        private ToolStripMenuItem 设备日志ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 初始操作ToolStripMenuItem;
        private ToolStripMenuItem 掉电操作ToolStripMenuItem;
        private ToolStripMenuItem 自动手动切换ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 重新作业ToolStripMenuItem;
        private ToolStripMenuItem 停止流程ToolStripMenuItem;
        private ToolStripMenuItem 发送流程ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem 设备维护ToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button4;
        private ToolStripMenuItem 传感数据ToolStripMenuItem;
        private ToolStripMenuItem 实时数据ToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Panel panel1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label闲置;
        private Label label作业中;
        private Label label报警;
        private Label label未启用;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox5;
        private Label label作业准备;
        private GroupBox groupBox6;
        private Label label作业完成;
        private GroupBox groupBox无通信;
        private Label label无通信;
        private ToolStripMenuItem 掉电清除ToolStripMenuItem;
        private ToolStripMenuItem 掉电恢复ToolStripMenuItem;
        private ToolStripMenuItem 切置自动ToolStripMenuItem;
        private ToolStripMenuItem 预约手动ToolStripMenuItem;
        private Button button6;
        private Panel panel2;
        private Label label9;
        private Label label15;
        private Label labelWMS;
        private FlowLayoutPanel flowLayoutPanel2;
        private ToolStripMenuItem 强制出库ToolStripMenuItem;
    }
}