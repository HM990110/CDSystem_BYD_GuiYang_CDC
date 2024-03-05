namespace CDSystem.实时数据
{
    partial class Form实时数据
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
            button工作时间 = new Button();
            button工作状态 = new Button();
            button电压电流 = new Button();
            button线电压阻抗 = new Button();
            button容量能量 = new Button();
            button温度 = new Button();
            tableLayoutPanel电池 = new TableLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            label_NG_COUNT = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label_MDL_NAME = new Label();
            label_TRAY_NO = new Label();
            label_ProcessTime = new Label();
            label_StepWorkTime = new Label();
            label_ProcessStatus = new Label();
            label_StepMode = new Label();
            label_CELL_COUNT = new Label();
            label4 = new Label();
            label10 = new Label();
            label_ProcessName = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonNG代码 = new Button();
            button流程信息 = new Button();
            button初始操作 = new Button();
            button掉电恢复 = new Button();
            button停止流程 = new Button();
            button重新作业 = new Button();
            button发送流程 = new Button();
            button数据截取 = new Button();
            button视图切换 = new Button();
            panel数据 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button其他 = new Button();
            button电芯条码 = new Button();
            timer3 = new System.Windows.Forms.Timer(components);
            AddNewDataTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel数据.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // button工作时间
            // 
            button工作时间.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button工作时间.BackColor = Color.White;
            button工作时间.FlatAppearance.BorderColor = Color.Silver;
            button工作时间.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            button工作时间.FlatAppearance.MouseDownBackColor = Color.Silver;
            button工作时间.FlatAppearance.MouseOverBackColor = Color.Silver;
            button工作时间.FlatStyle = FlatStyle.Flat;
            button工作时间.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button工作时间.Location = new Point(537, 0);
            button工作时间.Margin = new Padding(0);
            button工作时间.Name = "button工作时间";
            button工作时间.Size = new Size(179, 50);
            button工作时间.TabIndex = 6;
            button工作时间.Tag = "工作时间";
            button工作时间.Text = "流程时间\r\n步次时间";
            button工作时间.UseVisualStyleBackColor = false;
            button工作时间.Click += Button_Click;
            // 
            // button工作状态
            // 
            button工作状态.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button工作状态.FlatAppearance.BorderColor = Color.Silver;
            button工作状态.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            button工作状态.FlatAppearance.MouseDownBackColor = Color.Silver;
            button工作状态.FlatAppearance.MouseOverBackColor = Color.Silver;
            button工作状态.FlatStyle = FlatStyle.Flat;
            button工作状态.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button工作状态.Location = new Point(1074, 0);
            button工作状态.Margin = new Padding(0);
            button工作状态.Name = "button工作状态";
            button工作状态.Size = new Size(179, 50);
            button工作状态.TabIndex = 7;
            button工作状态.Tag = "工作状态";
            button工作状态.Text = "工作状态\r\nNG代码";
            button工作状态.UseVisualStyleBackColor = true;
            button工作状态.Click += Button_Click;
            // 
            // button电压电流
            // 
            button电压电流.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button电压电流.BackColor = Color.Silver;
            button电压电流.FlatAppearance.BorderColor = Color.Silver;
            button电压电流.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            button电压电流.FlatAppearance.MouseDownBackColor = Color.Silver;
            button电压电流.FlatAppearance.MouseOverBackColor = Color.Silver;
            button电压电流.FlatStyle = FlatStyle.Flat;
            button电压电流.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button电压电流.Location = new Point(0, 0);
            button电压电流.Margin = new Padding(0);
            button电压电流.Name = "button电压电流";
            button电压电流.Size = new Size(179, 50);
            button电压电流.TabIndex = 8;
            button电压电流.Tag = "电压电流";
            button电压电流.Text = "电压\r\n电流";
            button电压电流.UseVisualStyleBackColor = false;
            button电压电流.Click += Button_Click;
            // 
            // button线电压阻抗
            // 
            button线电压阻抗.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button线电压阻抗.FlatAppearance.BorderColor = Color.Silver;
            button线电压阻抗.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            button线电压阻抗.FlatAppearance.MouseDownBackColor = Color.Silver;
            button线电压阻抗.FlatAppearance.MouseOverBackColor = Color.Silver;
            button线电压阻抗.FlatStyle = FlatStyle.Flat;
            button线电压阻抗.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button线电压阻抗.Location = new Point(179, 0);
            button线电压阻抗.Margin = new Padding(0);
            button线电压阻抗.Name = "button线电压阻抗";
            button线电压阻抗.Size = new Size(179, 50);
            button线电压阻抗.TabIndex = 9;
            button线电压阻抗.Tag = "线电压阻抗";
            button线电压阻抗.Text = "线电压\r\n阻抗";
            button线电压阻抗.UseVisualStyleBackColor = true;
            button线电压阻抗.Click += Button_Click;
            // 
            // button容量能量
            // 
            button容量能量.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button容量能量.FlatAppearance.BorderColor = Color.Silver;
            button容量能量.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            button容量能量.FlatAppearance.MouseDownBackColor = Color.Silver;
            button容量能量.FlatAppearance.MouseOverBackColor = Color.Silver;
            button容量能量.FlatStyle = FlatStyle.Flat;
            button容量能量.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button容量能量.Location = new Point(358, 0);
            button容量能量.Margin = new Padding(0);
            button容量能量.Name = "button容量能量";
            button容量能量.Size = new Size(179, 50);
            button容量能量.TabIndex = 10;
            button容量能量.Tag = "容量能量";
            button容量能量.Text = "容量\r\n能量";
            button容量能量.UseVisualStyleBackColor = true;
            button容量能量.Click += Button_Click;
            // 
            // button温度
            // 
            button温度.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button温度.FlatAppearance.BorderColor = Color.Silver;
            button温度.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            button温度.FlatAppearance.MouseDownBackColor = Color.Silver;
            button温度.FlatAppearance.MouseOverBackColor = Color.Silver;
            button温度.FlatStyle = FlatStyle.Flat;
            button温度.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button温度.Location = new Point(716, 0);
            button温度.Margin = new Padding(0);
            button温度.Name = "button温度";
            button温度.Size = new Size(179, 50);
            button温度.TabIndex = 11;
            button温度.Tag = "温度";
            button温度.Text = "通道温度\r\n电池温度";
            button温度.UseVisualStyleBackColor = true;
            button温度.Click += Button_Click;
            // 
            // tableLayoutPanel电池
            // 
            tableLayoutPanel电池.ColumnCount = 1;
            tableLayoutPanel电池.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel电池.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel电池.Dock = DockStyle.Fill;
            tableLayoutPanel电池.Location = new Point(0, 50);
            tableLayoutPanel电池.Name = "tableLayoutPanel电池";
            tableLayoutPanel电池.RowCount = 1;
            tableLayoutPanel电池.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel电池.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel电池.Size = new Size(1435, 621);
            tableLayoutPanel电池.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1112471F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1112452F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1112452F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111326F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.110136F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1112471F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1112471F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1112471F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1112471F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label_NG_COUNT, 5, 1);
            tableLayoutPanel1.Controls.Add(label11, 5, 0);
            tableLayoutPanel1.Controls.Add(label8, 9, 0);
            tableLayoutPanel1.Controls.Add(label7, 8, 0);
            tableLayoutPanel1.Controls.Add(label6, 7, 0);
            tableLayoutPanel1.Controls.Add(label5, 6, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label_MDL_NAME, 1, 1);
            tableLayoutPanel1.Controls.Add(label_TRAY_NO, 2, 1);
            tableLayoutPanel1.Controls.Add(label_ProcessTime, 6, 1);
            tableLayoutPanel1.Controls.Add(label_StepWorkTime, 7, 1);
            tableLayoutPanel1.Controls.Add(label_ProcessStatus, 8, 1);
            tableLayoutPanel1.Controls.Add(label_StepMode, 9, 1);
            tableLayoutPanel1.Controls.Add(label_CELL_COUNT, 4, 1);
            tableLayoutPanel1.Controls.Add(label4, 4, 0);
            tableLayoutPanel1.Controls.Add(label10, 3, 0);
            tableLayoutPanel1.Controls.Add(label_ProcessName, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1435, 40);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label_NG_COUNT
            // 
            label_NG_COUNT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_NG_COUNT.BackColor = Color.Black;
            label_NG_COUNT.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_NG_COUNT.ForeColor = Color.White;
            label_NG_COUNT.Location = new Point(807, 20);
            label_NG_COUNT.Name = "label_NG_COUNT";
            label_NG_COUNT.Size = new Size(120, 20);
            label_NG_COUNT.TabIndex = 13;
            label_NG_COUNT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.BackColor = Color.Blue;
            label11.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(807, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 4;
            label11.Text = "NG数量";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.BackColor = Color.Green;
            label8.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1311, 0);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 7;
            label8.Text = "步次类型";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = Color.Green;
            label7.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1185, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 6;
            label7.Text = "总工作状态";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = Color.Green;
            label6.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1059, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 5;
            label6.Text = "步次时间";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Green;
            label5.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(933, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 4;
            label5.Text = "工作时间";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(429, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "托盘号";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(303, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "电芯型号";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_MDL_NAME
            // 
            label_MDL_NAME.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_MDL_NAME.BackColor = Color.Black;
            label_MDL_NAME.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_MDL_NAME.ForeColor = Color.White;
            label_MDL_NAME.Location = new Point(303, 20);
            label_MDL_NAME.Name = "label_MDL_NAME";
            label_MDL_NAME.Size = new Size(120, 20);
            label_MDL_NAME.TabIndex = 9;
            label_MDL_NAME.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_TRAY_NO
            // 
            label_TRAY_NO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_TRAY_NO.BackColor = Color.Black;
            label_TRAY_NO.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_TRAY_NO.ForeColor = Color.White;
            label_TRAY_NO.Location = new Point(429, 20);
            label_TRAY_NO.Name = "label_TRAY_NO";
            label_TRAY_NO.Size = new Size(120, 20);
            label_TRAY_NO.TabIndex = 11;
            label_TRAY_NO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_ProcessTime
            // 
            label_ProcessTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_ProcessTime.BackColor = Color.Black;
            label_ProcessTime.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_ProcessTime.ForeColor = Color.White;
            label_ProcessTime.Location = new Point(933, 20);
            label_ProcessTime.Name = "label_ProcessTime";
            label_ProcessTime.Size = new Size(120, 20);
            label_ProcessTime.TabIndex = 13;
            label_ProcessTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_StepWorkTime
            // 
            label_StepWorkTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_StepWorkTime.BackColor = Color.Black;
            label_StepWorkTime.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_StepWorkTime.ForeColor = Color.White;
            label_StepWorkTime.Location = new Point(1059, 20);
            label_StepWorkTime.Name = "label_StepWorkTime";
            label_StepWorkTime.Size = new Size(120, 20);
            label_StepWorkTime.TabIndex = 14;
            label_StepWorkTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_ProcessStatus
            // 
            label_ProcessStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_ProcessStatus.BackColor = Color.Black;
            label_ProcessStatus.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_ProcessStatus.ForeColor = Color.White;
            label_ProcessStatus.Location = new Point(1185, 20);
            label_ProcessStatus.Name = "label_ProcessStatus";
            label_ProcessStatus.Size = new Size(120, 20);
            label_ProcessStatus.TabIndex = 15;
            label_ProcessStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_StepMode
            // 
            label_StepMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_StepMode.BackColor = Color.Black;
            label_StepMode.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_StepMode.ForeColor = Color.White;
            label_StepMode.Location = new Point(1311, 20);
            label_StepMode.Name = "label_StepMode";
            label_StepMode.Size = new Size(120, 20);
            label_StepMode.TabIndex = 16;
            label_StepMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_CELL_COUNT
            // 
            label_CELL_COUNT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_CELL_COUNT.BackColor = Color.Black;
            label_CELL_COUNT.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_CELL_COUNT.ForeColor = Color.White;
            label_CELL_COUNT.Location = new Point(681, 20);
            label_CELL_COUNT.Name = "label_CELL_COUNT";
            label_CELL_COUNT.Size = new Size(120, 20);
            label_CELL_COUNT.TabIndex = 12;
            label_CELL_COUNT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(681, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 3;
            label4.Text = "电芯数量";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.Blue;
            label10.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(555, 0);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 19;
            label10.Text = "流程代码";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_ProcessName
            // 
            label_ProcessName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_ProcessName.BackColor = Color.Black;
            label_ProcessName.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_ProcessName.ForeColor = Color.White;
            label_ProcessName.Location = new Point(555, 20);
            label_ProcessName.Name = "label_ProcessName";
            label_ProcessName.Size = new Size(120, 20);
            label_ProcessName.TabIndex = 20;
            label_ProcessName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonNG代码);
            flowLayoutPanel2.Controls.Add(button流程信息);
            flowLayoutPanel2.Controls.Add(button初始操作);
            flowLayoutPanel2.Controls.Add(button掉电恢复);
            flowLayoutPanel2.Controls.Add(button停止流程);
            flowLayoutPanel2.Controls.Add(button重新作业);
            flowLayoutPanel2.Controls.Add(button发送流程);
            flowLayoutPanel2.Controls.Add(button数据截取);
            flowLayoutPanel2.Controls.Add(button视图切换);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(5, 45);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1435, 40);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // buttonNG代码
            // 
            buttonNG代码.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNG代码.Location = new Point(5, 5);
            buttonNG代码.Margin = new Padding(5);
            buttonNG代码.Name = "buttonNG代码";
            buttonNG代码.Size = new Size(150, 30);
            buttonNG代码.TabIndex = 7;
            buttonNG代码.Tag = "NG代码";
            buttonNG代码.Text = "NG代码";
            buttonNG代码.UseVisualStyleBackColor = true;
            buttonNG代码.Click += ButtonNG代码_Click;
            // 
            // button流程信息
            // 
            button流程信息.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button流程信息.Location = new Point(165, 5);
            button流程信息.Margin = new Padding(5);
            button流程信息.Name = "button流程信息";
            button流程信息.Size = new Size(150, 30);
            button流程信息.TabIndex = 12;
            button流程信息.Tag = "流程信息";
            button流程信息.Text = "流程信息";
            button流程信息.UseVisualStyleBackColor = true;
            button流程信息.Click += Button流程信息_Click;
            // 
            // button初始操作
            // 
            button初始操作.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button初始操作.Location = new Point(325, 5);
            button初始操作.Margin = new Padding(5);
            button初始操作.Name = "button初始操作";
            button初始操作.Size = new Size(150, 30);
            button初始操作.TabIndex = 8;
            button初始操作.Tag = "初始操作";
            button初始操作.Text = "初始操作";
            button初始操作.UseVisualStyleBackColor = true;
            button初始操作.Click += Button初始操作_Click;
            // 
            // button掉电恢复
            // 
            button掉电恢复.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button掉电恢复.Location = new Point(485, 5);
            button掉电恢复.Margin = new Padding(5);
            button掉电恢复.Name = "button掉电恢复";
            button掉电恢复.Size = new Size(150, 30);
            button掉电恢复.TabIndex = 9;
            button掉电恢复.Tag = "掉电恢复";
            button掉电恢复.Text = "掉电恢复";
            button掉电恢复.UseVisualStyleBackColor = true;
            button掉电恢复.Click += Button掉电恢复_Click;
            // 
            // button停止流程
            // 
            button停止流程.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button停止流程.Location = new Point(645, 5);
            button停止流程.Margin = new Padding(5);
            button停止流程.Name = "button停止流程";
            button停止流程.Size = new Size(150, 30);
            button停止流程.TabIndex = 10;
            button停止流程.Tag = "停止流程";
            button停止流程.Text = "停止流程";
            button停止流程.UseVisualStyleBackColor = true;
            button停止流程.Click += Button停止流程_Click;
            // 
            // button重新作业
            // 
            button重新作业.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button重新作业.Location = new Point(805, 5);
            button重新作业.Margin = new Padding(5);
            button重新作业.Name = "button重新作业";
            button重新作业.Size = new Size(150, 30);
            button重新作业.TabIndex = 13;
            button重新作业.Tag = "重新作业";
            button重新作业.Text = "重新作业";
            button重新作业.UseVisualStyleBackColor = true;
            button重新作业.Click += Button重新作业_Click;
            // 
            // button发送流程
            // 
            button发送流程.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button发送流程.Location = new Point(965, 5);
            button发送流程.Margin = new Padding(5);
            button发送流程.Name = "button发送流程";
            button发送流程.Size = new Size(150, 30);
            button发送流程.TabIndex = 11;
            button发送流程.Tag = "发送流程";
            button发送流程.Text = "发送流程";
            button发送流程.UseVisualStyleBackColor = true;
            button发送流程.Click += Button发送流程_Click;
            // 
            // button数据截取
            // 
            button数据截取.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button数据截取.Location = new Point(1125, 5);
            button数据截取.Margin = new Padding(5);
            button数据截取.Name = "button数据截取";
            button数据截取.Size = new Size(150, 30);
            button数据截取.TabIndex = 15;
            button数据截取.Tag = "数据截取";
            button数据截取.Text = "数据截取";
            button数据截取.UseVisualStyleBackColor = true;
            button数据截取.Click += Button数据截取_Click;
            // 
            // button视图切换
            // 
            button视图切换.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button视图切换.Location = new Point(1285, 5);
            button视图切换.Margin = new Padding(5);
            button视图切换.Name = "button视图切换";
            button视图切换.Size = new Size(150, 30);
            button视图切换.TabIndex = 14;
            button视图切换.Tag = "曲线展示";
            button视图切换.Text = "视图切换";
            button视图切换.UseVisualStyleBackColor = true;
            button视图切换.Click += Button曲线展示_Click;
            // 
            // panel数据
            // 
            panel数据.AutoSize = true;
            panel数据.Controls.Add(tableLayoutPanel电池);
            panel数据.Controls.Add(tableLayoutPanel3);
            panel数据.Dock = DockStyle.Fill;
            panel数据.Location = new Point(5, 85);
            panel数据.Name = "panel数据";
            panel数据.Size = new Size(1435, 671);
            panel数据.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 8;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.Controls.Add(button电压电流, 0, 0);
            tableLayoutPanel3.Controls.Add(button线电压阻抗, 1, 0);
            tableLayoutPanel3.Controls.Add(button容量能量, 2, 0);
            tableLayoutPanel3.Controls.Add(button工作时间, 3, 0);
            tableLayoutPanel3.Controls.Add(button温度, 4, 0);
            tableLayoutPanel3.Controls.Add(button其他, 5, 0);
            tableLayoutPanel3.Controls.Add(button工作状态, 6, 0);
            tableLayoutPanel3.Controls.Add(button电芯条码, 7, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1435, 50);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button其他
            // 
            button其他.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button其他.FlatAppearance.BorderColor = Color.Silver;
            button其他.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            button其他.FlatAppearance.MouseDownBackColor = Color.Silver;
            button其他.FlatAppearance.MouseOverBackColor = Color.Silver;
            button其他.FlatStyle = FlatStyle.Flat;
            button其他.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button其他.Location = new Point(895, 0);
            button其他.Margin = new Padding(0);
            button其他.Name = "button其他";
            button其他.Size = new Size(179, 50);
            button其他.TabIndex = 12;
            button其他.Tag = "其他";
            button其他.Text = "电压差\r\n步次";
            button其他.UseVisualStyleBackColor = true;
            button其他.Click += Button_Click;
            // 
            // button电芯条码
            // 
            button电芯条码.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button电芯条码.FlatAppearance.BorderColor = Color.Silver;
            button电芯条码.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            button电芯条码.FlatAppearance.MouseDownBackColor = Color.Silver;
            button电芯条码.FlatAppearance.MouseOverBackColor = Color.Silver;
            button电芯条码.FlatStyle = FlatStyle.Flat;
            button电芯条码.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button电芯条码.ImeMode = ImeMode.NoControl;
            button电芯条码.Location = new Point(1253, 0);
            button电芯条码.Margin = new Padding(0);
            button电芯条码.Name = "button电芯条码";
            button电芯条码.Size = new Size(182, 50);
            button电芯条码.TabIndex = 13;
            button电芯条码.Tag = "电芯条码";
            button电芯条码.Text = "电芯条码";
            button电芯条码.UseVisualStyleBackColor = true;
            button电芯条码.Click += Button电芯条码_Click;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += Timer3_Tick;
            // 
            // AddNewDataTimer
            // 
            AddNewDataTimer.Interval = 1000;
            AddNewDataTimer.Tick += AddNewDataTimer_Tick; 
            // 
            // Form实时数据
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1445, 761);
            Controls.Add(panel数据);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "Form实时数据";
            Padding = new Padding(5);
            Tag = "1936, 988";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel数据.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel电池;
        private System.Windows.Forms.Timer timer1;
        private Button button工作时间;
        private Button button工作状态;
        private Button button电压电流;
        private Button button线电压阻抗;
        private Button button容量能量;
        private Button button温度;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label_MDL_NAME;
        private Label label_TRAY_NO;
        private Label label_CELL_COUNT;
        private Label label_ProcessTime;
        private Label label_StepWorkTime;
        private Label label_ProcessStatus;
        private Label label_StepMode;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonNG代码;
        private Button button初始操作;
        private Button button停止流程;
        private Button button发送流程;
        private Button button流程信息;
        private Button button重新作业;
        private Button button视图切换;
        private Button button数据截取;
        public TableLayoutPanel tableLayoutPanel1; 
        private System.Windows.Forms.Timer timer3;
        private Button button掉电恢复;
        private Label label_ProcessName;
        private Label label10;
        private Panel panel数据;
        private Button button其他;
        private Button button电芯条码;
        private Label label_NG_COUNT;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Timer AddNewDataTimer;  
    }
}
