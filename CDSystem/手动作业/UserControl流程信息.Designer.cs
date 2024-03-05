namespace CDSystem.手动作业
{
    partial class UserControl流程信息
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel其他 = new TableLayoutPanel();
            tableLayoutPanel保护 = new TableLayoutPanel();
            groupBox通用保护 = new GroupBox();
            tableLayoutPanel通用保护 = new TableLayoutPanel();
            groupBox放电保护 = new GroupBox();
            tableLayoutPanel放电保护 = new TableLayoutPanel();
            groupBox充电保护 = new GroupBox();
            tableLayoutPanel充电保护 = new TableLayoutPanel();
            tableLayoutPanel辅助测试 = new TableLayoutPanel();
            panel接触测试 = new Panel();
            tableLayoutPanel接触测试 = new TableLayoutPanel();
            checkBox接触测试 = new CheckBox();
            panelOCV测试 = new Panel();
            tableLayoutPanelOCV测试 = new TableLayoutPanel();
            checkBoxOCV测试 = new CheckBox();
            dataGridView_Step = new DataGridView();
            Col步次ID = new DataGridViewTextBoxColumn();
            Col步次类型 = new DataGridViewComboBoxColumn();
            Col电流 = new DataGridViewTextBoxColumn();
            Col时长 = new DataGridViewTextBoxColumn();
            Col结束电压 = new DataGridViewTextBoxColumn();
            Col结束电流 = new DataGridViewTextBoxColumn();
            Col结束容量 = new DataGridViewTextBoxColumn();
            Col单步次保护 = new DataGridViewCheckBoxColumn();
            Col电压下限 = new DataGridViewTextBoxColumn();
            Col电压上限 = new DataGridViewTextBoxColumn();
            Col电流下限 = new DataGridViewTextBoxColumn();
            Col电流上限 = new DataGridViewTextBoxColumn();
            Col容量下限 = new DataGridViewTextBoxColumn();
            Col容量上限 = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            上移ToolStripMenuItem = new ToolStripMenuItem();
            下移ToolStripMenuItem = new ToolStripMenuItem();
            复制ToolStripMenuItem = new ToolStripMenuItem();
            粘贴ToolStripMenuItem = new ToolStripMenuItem();
            插入ToolStripMenuItem = new ToolStripMenuItem();
            删除ToolStripMenuItem = new ToolStripMenuItem();
            groupBox4 = new GroupBox();
            flowLayoutPanel1 = new Panel();
            panel2 = new Panel();
            numericUpDown_DeviceNGLimit = new NumericUpDown();
            label2 = new Label();
            panel1 = new Panel();
            radioButton_Retest = new RadioButton();
            radioButton_NoRetest = new RadioButton();
            checkBox_Enabled = new CheckBox();
            Button_Delete = new Button();
            Button_Insert = new Button();
            Button_Paste = new Button();
            Button_Copy = new Button();
            Button_MoveDown = new Button();
            Button_MoveUp = new Button();
            label1 = new Label();
            tableLayoutPanel其他.SuspendLayout();
            tableLayoutPanel保护.SuspendLayout();
            groupBox通用保护.SuspendLayout();
            groupBox放电保护.SuspendLayout();
            groupBox充电保护.SuspendLayout();
            tableLayoutPanel辅助测试.SuspendLayout();
            panel接触测试.SuspendLayout();
            panelOCV测试.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Step).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_DeviceNGLimit).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel其他
            // 
            tableLayoutPanel其他.AutoSize = true;
            tableLayoutPanel其他.ColumnCount = 6;
            tableLayoutPanel其他.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel其他.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel其他.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel其他.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel其他.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel其他.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel其他.Controls.Add(tableLayoutPanel保护, 0, 0);
            tableLayoutPanel其他.Controls.Add(tableLayoutPanel辅助测试, 5, 0);
            tableLayoutPanel其他.Dock = DockStyle.Bottom;
            tableLayoutPanel其他.Location = new Point(0, 916);
            tableLayoutPanel其他.Name = "tableLayoutPanel其他";
            tableLayoutPanel其他.RowCount = 1;
            tableLayoutPanel其他.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel其他.Size = new Size(1920, 84);
            tableLayoutPanel其他.TabIndex = 0;
            // 
            // tableLayoutPanel保护
            // 
            tableLayoutPanel保护.AutoSize = true;
            tableLayoutPanel保护.ColumnCount = 1;
            tableLayoutPanel其他.SetColumnSpan(tableLayoutPanel保护, 5);
            tableLayoutPanel保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel保护.Controls.Add(groupBox通用保护, 0, 2);
            tableLayoutPanel保护.Controls.Add(groupBox放电保护, 0, 1);
            tableLayoutPanel保护.Controls.Add(groupBox充电保护, 0, 0);
            tableLayoutPanel保护.Dock = DockStyle.Top;
            tableLayoutPanel保护.Location = new Point(0, 0);
            tableLayoutPanel保护.Margin = new Padding(0);
            tableLayoutPanel保护.Name = "tableLayoutPanel保护";
            tableLayoutPanel保护.RowCount = 3;
            tableLayoutPanel保护.RowStyles.Add(new RowStyle());
            tableLayoutPanel保护.RowStyles.Add(new RowStyle());
            tableLayoutPanel保护.RowStyles.Add(new RowStyle());
            tableLayoutPanel保护.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel保护.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel保护.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel保护.Size = new Size(1600, 84);
            tableLayoutPanel保护.TabIndex = 6;
            // 
            // groupBox通用保护
            // 
            groupBox通用保护.AutoSize = true;
            groupBox通用保护.Controls.Add(tableLayoutPanel通用保护);
            groupBox通用保护.Dock = DockStyle.Fill;
            groupBox通用保护.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox通用保护.Location = new Point(3, 59);
            groupBox通用保护.Name = "groupBox通用保护";
            groupBox通用保护.Size = new Size(1594, 22);
            groupBox通用保护.TabIndex = 3;
            groupBox通用保护.TabStop = false;
            groupBox通用保护.Text = "通用保护";
            // 
            // tableLayoutPanel通用保护
            // 
            tableLayoutPanel通用保护.AutoSize = true;
            tableLayoutPanel通用保护.ColumnCount = 6;
            tableLayoutPanel通用保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel通用保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel通用保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel通用保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel通用保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel通用保护.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel通用保护.Dock = DockStyle.Fill;
            tableLayoutPanel通用保护.Location = new Point(3, 19);
            tableLayoutPanel通用保护.Name = "tableLayoutPanel通用保护";
            tableLayoutPanel通用保护.RowCount = 1;
            tableLayoutPanel通用保护.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel通用保护.Size = new Size(1588, 0);
            tableLayoutPanel通用保护.TabIndex = 3;
            // 
            // groupBox放电保护
            // 
            groupBox放电保护.AutoSize = true;
            groupBox放电保护.Controls.Add(tableLayoutPanel放电保护);
            groupBox放电保护.Dock = DockStyle.Fill;
            groupBox放电保护.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox放电保护.Location = new Point(3, 31);
            groupBox放电保护.Name = "groupBox放电保护";
            groupBox放电保护.Size = new Size(1594, 22);
            groupBox放电保护.TabIndex = 2;
            groupBox放电保护.TabStop = false;
            groupBox放电保护.Text = "放电保护";
            // 
            // tableLayoutPanel放电保护
            // 
            tableLayoutPanel放电保护.AutoSize = true;
            tableLayoutPanel放电保护.ColumnCount = 6;
            tableLayoutPanel放电保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel放电保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel放电保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel放电保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel放电保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel放电保护.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel放电保护.Dock = DockStyle.Fill;
            tableLayoutPanel放电保护.Location = new Point(3, 19);
            tableLayoutPanel放电保护.Name = "tableLayoutPanel放电保护";
            tableLayoutPanel放电保护.RowCount = 1;
            tableLayoutPanel放电保护.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel放电保护.Size = new Size(1588, 0);
            tableLayoutPanel放电保护.TabIndex = 2;
            // 
            // groupBox充电保护
            // 
            groupBox充电保护.AutoSize = true;
            groupBox充电保护.Controls.Add(tableLayoutPanel充电保护);
            groupBox充电保护.Dock = DockStyle.Fill;
            groupBox充电保护.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox充电保护.Location = new Point(3, 3);
            groupBox充电保护.Name = "groupBox充电保护";
            groupBox充电保护.Size = new Size(1594, 22);
            groupBox充电保护.TabIndex = 1;
            groupBox充电保护.TabStop = false;
            groupBox充电保护.Text = "充电保护";
            // 
            // tableLayoutPanel充电保护
            // 
            tableLayoutPanel充电保护.AutoSize = true;
            tableLayoutPanel充电保护.ColumnCount = 6;
            tableLayoutPanel充电保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel充电保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel充电保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel充电保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel充电保护.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel充电保护.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel充电保护.Dock = DockStyle.Fill;
            tableLayoutPanel充电保护.Location = new Point(3, 19);
            tableLayoutPanel充电保护.Name = "tableLayoutPanel充电保护";
            tableLayoutPanel充电保护.RowCount = 1;
            tableLayoutPanel充电保护.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel充电保护.Size = new Size(1588, 0);
            tableLayoutPanel充电保护.TabIndex = 1;
            // 
            // tableLayoutPanel辅助测试
            // 
            tableLayoutPanel辅助测试.AutoSize = true;
            tableLayoutPanel辅助测试.ColumnCount = 1;
            tableLayoutPanel辅助测试.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel辅助测试.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel辅助测试.Controls.Add(panel接触测试, 0, 1);
            tableLayoutPanel辅助测试.Controls.Add(panelOCV测试, 0, 0);
            tableLayoutPanel辅助测试.Dock = DockStyle.Top;
            tableLayoutPanel辅助测试.Location = new Point(1600, 0);
            tableLayoutPanel辅助测试.Margin = new Padding(0);
            tableLayoutPanel辅助测试.Name = "tableLayoutPanel辅助测试";
            tableLayoutPanel辅助测试.RowCount = 4;
            tableLayoutPanel辅助测试.RowStyles.Add(new RowStyle());
            tableLayoutPanel辅助测试.RowStyles.Add(new RowStyle());
            tableLayoutPanel辅助测试.RowStyles.Add(new RowStyle());
            tableLayoutPanel辅助测试.RowStyles.Add(new RowStyle());
            tableLayoutPanel辅助测试.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel辅助测试.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel辅助测试.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel辅助测试.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel辅助测试.Size = new Size(320, 62);
            tableLayoutPanel辅助测试.TabIndex = 4;
            // 
            // panel接触测试
            // 
            panel接触测试.AutoSize = true;
            panel接触测试.BorderStyle = BorderStyle.Fixed3D;
            panel接触测试.Controls.Add(tableLayoutPanel接触测试);
            panel接触测试.Controls.Add(checkBox接触测试);
            panel接触测试.Dock = DockStyle.Fill;
            panel接触测试.Location = new Point(3, 34);
            panel接触测试.Name = "panel接触测试";
            panel接触测试.Size = new Size(314, 25);
            panel接触测试.TabIndex = 7;
            // 
            // tableLayoutPanel接触测试
            // 
            tableLayoutPanel接触测试.AutoSize = true;
            tableLayoutPanel接触测试.ColumnCount = 1;
            tableLayoutPanel接触测试.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel接触测试.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel接触测试.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel接触测试.Dock = DockStyle.Fill;
            tableLayoutPanel接触测试.Enabled = false;
            tableLayoutPanel接触测试.Location = new Point(0, 21);
            tableLayoutPanel接触测试.Name = "tableLayoutPanel接触测试";
            tableLayoutPanel接触测试.RowCount = 1;
            tableLayoutPanel接触测试.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel接触测试.Size = new Size(310, 0);
            tableLayoutPanel接触测试.TabIndex = 1;
            // 
            // checkBox接触测试
            // 
            checkBox接触测试.AutoSize = true;
            checkBox接触测试.Dock = DockStyle.Top;
            checkBox接触测试.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox接触测试.Location = new Point(0, 0);
            checkBox接触测试.Name = "checkBox接触测试";
            checkBox接触测试.Size = new Size(310, 21);
            checkBox接触测试.TabIndex = 0;
            checkBox接触测试.Text = "接触测试";
            checkBox接触测试.UseVisualStyleBackColor = true;
            checkBox接触测试.CheckedChanged += CheckBox接触测试_CheckedChanged;
            // 
            // panelOCV测试
            // 
            panelOCV测试.AutoSize = true;
            panelOCV测试.BorderStyle = BorderStyle.Fixed3D;
            panelOCV测试.Controls.Add(tableLayoutPanelOCV测试);
            panelOCV测试.Controls.Add(checkBoxOCV测试);
            panelOCV测试.Dock = DockStyle.Fill;
            panelOCV测试.Location = new Point(3, 3);
            panelOCV测试.Name = "panelOCV测试";
            panelOCV测试.Size = new Size(314, 25);
            panelOCV测试.TabIndex = 6;
            // 
            // tableLayoutPanelOCV测试
            // 
            tableLayoutPanelOCV测试.AutoSize = true;
            tableLayoutPanelOCV测试.ColumnCount = 1;
            tableLayoutPanelOCV测试.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelOCV测试.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelOCV测试.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelOCV测试.Dock = DockStyle.Fill;
            tableLayoutPanelOCV测试.Enabled = false;
            tableLayoutPanelOCV测试.Location = new Point(0, 21);
            tableLayoutPanelOCV测试.Name = "tableLayoutPanelOCV测试";
            tableLayoutPanelOCV测试.RowCount = 1;
            tableLayoutPanelOCV测试.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelOCV测试.Size = new Size(310, 0);
            tableLayoutPanelOCV测试.TabIndex = 1;
            // 
            // checkBoxOCV测试
            // 
            checkBoxOCV测试.AutoSize = true;
            checkBoxOCV测试.Dock = DockStyle.Top;
            checkBoxOCV测试.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxOCV测试.Location = new Point(0, 0);
            checkBoxOCV测试.Name = "checkBoxOCV测试";
            checkBoxOCV测试.Size = new Size(310, 21);
            checkBoxOCV测试.TabIndex = 0;
            checkBoxOCV测试.Text = "OCV测试";
            checkBoxOCV测试.UseVisualStyleBackColor = true;
            checkBoxOCV测试.CheckedChanged += CheckBoxOCV测试_CheckedChanged;
            // 
            // dataGridView_Step
            // 
            dataGridView_Step.AllowUserToAddRows = false;
            dataGridView_Step.AllowUserToDeleteRows = false;
            dataGridView_Step.AllowUserToResizeColumns = false;
            dataGridView_Step.AllowUserToResizeRows = false;
            dataGridView_Step.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Step.BackgroundColor = Color.White;
            dataGridView_Step.BorderStyle = BorderStyle.Fixed3D;
            dataGridView_Step.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridView_Step.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Step.ColumnHeadersHeight = 30;
            dataGridView_Step.Columns.AddRange(new DataGridViewColumn[] { Col步次ID, Col步次类型, Col电流, Col时长, Col结束电压, Col结束电流, Col结束容量, Col单步次保护, Col电压下限, Col电压上限, Col电流下限, Col电流上限, Col容量下限, Col容量上限 });
            dataGridView_Step.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_Step.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_Step.Dock = DockStyle.Fill;
            dataGridView_Step.EnableHeadersVisualStyles = false;
            dataGridView_Step.Location = new Point(3, 49);
            dataGridView_Step.Name = "dataGridView_Step";
            dataGridView_Step.RowTemplate.Height = 25;
            dataGridView_Step.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_Step.Size = new Size(1914, 864);
            dataGridView_Step.TabIndex = 4;
            dataGridView_Step.CellDoubleClick += DataGridView_Step_CellDoubleClick;
            dataGridView_Step.CellValueChanged += DataGridView_Step_CellValueChanged;
            // 
            // Col步次ID
            // 
            Col步次ID.HeaderText = "步次ID";
            Col步次ID.MinimumWidth = 100;
            Col步次ID.Name = "Col步次ID";
            Col步次ID.ReadOnly = true;
            Col步次ID.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Col步次类型
            // 
            Col步次类型.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            Col步次类型.HeaderText = "步次类型";
            Col步次类型.Items.AddRange(new object[] { "SKIP", "REST", "CC", "CCCV", "DC" });
            Col步次类型.MinimumWidth = 100;
            Col步次类型.Name = "Col步次类型";
            // 
            // Col电流
            // 
            Col电流.HeaderText = "电流(mA)";
            Col电流.MinimumWidth = 100;
            Col电流.Name = "Col电流";
            Col电流.Resizable = DataGridViewTriState.True;
            Col电流.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Col时长
            // 
            Col时长.HeaderText = "时长(min)";
            Col时长.MinimumWidth = 100;
            Col时长.Name = "Col时长";
            Col时长.ReadOnly = true;
            Col时长.Resizable = DataGridViewTriState.True;
            Col时长.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Col结束电压
            // 
            Col结束电压.HeaderText = "结束电压(mV)";
            Col结束电压.MinimumWidth = 100;
            Col结束电压.Name = "Col结束电压";
            Col结束电压.Resizable = DataGridViewTriState.True;
            Col结束电压.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Col结束电流
            // 
            Col结束电流.HeaderText = "结束电流(mA)";
            Col结束电流.MinimumWidth = 100;
            Col结束电流.Name = "Col结束电流";
            Col结束电流.Resizable = DataGridViewTriState.True;
            Col结束电流.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Col结束容量
            // 
            Col结束容量.HeaderText = "结束容量(mAh)";
            Col结束容量.MinimumWidth = 100;
            Col结束容量.Name = "Col结束容量";
            Col结束容量.Resizable = DataGridViewTriState.True;
            Col结束容量.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Col单步次保护
            // 
            Col单步次保护.HeaderText = "单步次保护";
            Col单步次保护.MinimumWidth = 100;
            Col单步次保护.Name = "Col单步次保护";
            Col单步次保护.Resizable = DataGridViewTriState.True;
            // 
            // Col电压下限
            // 
            Col电压下限.HeaderText = "电压下限(mV)";
            Col电压下限.MinimumWidth = 100;
            Col电压下限.Name = "Col电压下限";
            Col电压下限.Resizable = DataGridViewTriState.True;
            Col电压下限.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Col电压上限
            // 
            Col电压上限.HeaderText = "电压上限(mV)";
            Col电压上限.MinimumWidth = 100;
            Col电压上限.Name = "Col电压上限";
            Col电压上限.Resizable = DataGridViewTriState.True;
            Col电压上限.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Col电流下限
            // 
            Col电流下限.HeaderText = "电流下限(mA)";
            Col电流下限.MinimumWidth = 100;
            Col电流下限.Name = "Col电流下限";
            Col电流下限.Resizable = DataGridViewTriState.True;
            Col电流下限.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Col电流上限
            // 
            Col电流上限.HeaderText = "电流上限(mA)";
            Col电流上限.MinimumWidth = 100;
            Col电流上限.Name = "Col电流上限";
            Col电流上限.Resizable = DataGridViewTriState.True;
            Col电流上限.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Col容量下限
            // 
            Col容量下限.HeaderText = "容量下限(mAh)";
            Col容量下限.Name = "Col容量下限";
            // 
            // Col容量上限
            // 
            Col容量上限.HeaderText = "容量上限(mAh)";
            Col容量上限.Name = "Col容量上限";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 上移ToolStripMenuItem, 下移ToolStripMenuItem, 复制ToolStripMenuItem, 粘贴ToolStripMenuItem, 插入ToolStripMenuItem, 删除ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 136);
            // 
            // 上移ToolStripMenuItem
            // 
            上移ToolStripMenuItem.Name = "上移ToolStripMenuItem";
            上移ToolStripMenuItem.Size = new Size(100, 22);
            上移ToolStripMenuItem.Text = "上移";
            上移ToolStripMenuItem.Click += Button_MoveUp_Click;
            // 
            // 下移ToolStripMenuItem
            // 
            下移ToolStripMenuItem.Name = "下移ToolStripMenuItem";
            下移ToolStripMenuItem.Size = new Size(100, 22);
            下移ToolStripMenuItem.Text = "下移";
            下移ToolStripMenuItem.Click += Button_MoveDown_Click;
            // 
            // 复制ToolStripMenuItem
            // 
            复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            复制ToolStripMenuItem.Size = new Size(100, 22);
            复制ToolStripMenuItem.Text = "复制";
            复制ToolStripMenuItem.Click += Button_Copy_Click;
            // 
            // 粘贴ToolStripMenuItem
            // 
            粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            粘贴ToolStripMenuItem.Size = new Size(100, 22);
            粘贴ToolStripMenuItem.Text = "粘贴";
            粘贴ToolStripMenuItem.Click += Button_Paste_Click;
            // 
            // 插入ToolStripMenuItem
            // 
            插入ToolStripMenuItem.Name = "插入ToolStripMenuItem";
            插入ToolStripMenuItem.Size = new Size(100, 22);
            插入ToolStripMenuItem.Text = "插入";
            插入ToolStripMenuItem.Click += Button_Insert_Click;
            // 
            // 删除ToolStripMenuItem
            // 
            删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            删除ToolStripMenuItem.Size = new Size(100, 22);
            删除ToolStripMenuItem.Text = "删除";
            删除ToolStripMenuItem.Click += Button_Delete_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView_Step);
            groupBox4.Controls.Add(flowLayoutPanel1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1920, 916);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "充放电步次";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(checkBox_Enabled);
            flowLayoutPanel1.Controls.Add(Button_Delete);
            flowLayoutPanel1.Controls.Add(Button_Insert);
            flowLayoutPanel1.Controls.Add(Button_Paste);
            flowLayoutPanel1.Controls.Add(Button_Copy);
            flowLayoutPanel1.Controls.Add(Button_MoveDown);
            flowLayoutPanel1.Controls.Add(Button_MoveUp);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1914, 30);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(numericUpDown_DeviceNGLimit);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(1225, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2);
            panel2.Size = new Size(181, 30);
            panel2.TabIndex = 7;
            // 
            // numericUpDown_DeviceNGLimit
            // 
            numericUpDown_DeviceNGLimit.Dock = DockStyle.Left;
            numericUpDown_DeviceNGLimit.Location = new Point(95, 2);
            numericUpDown_DeviceNGLimit.Maximum = new decimal(new int[] { 196, 0, 0, 0 });
            numericUpDown_DeviceNGLimit.Name = "numericUpDown_DeviceNGLimit";
            numericUpDown_DeviceNGLimit.Size = new Size(80, 23);
            numericUpDown_DeviceNGLimit.TabIndex = 10;
            numericUpDown_DeviceNGLimit.TextAlign = HorizontalAlignment.Center;
            numericUpDown_DeviceNGLimit.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(2, 2);
            label2.Name = "label2";
            label2.Padding = new Padding(3);
            label2.Size = new Size(93, 23);
            label2.TabIndex = 9;
            label2.Text = "单盘NG上限：";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(radioButton_Retest);
            panel1.Controls.Add(radioButton_NoRetest);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(1053, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 30);
            panel1.TabIndex = 6;
            // 
            // radioButton_Retest
            // 
            radioButton_Retest.AutoSize = true;
            radioButton_Retest.Dock = DockStyle.Left;
            radioButton_Retest.Location = new Point(84, 0);
            radioButton_Retest.Name = "radioButton_Retest";
            radioButton_Retest.Padding = new Padding(5, 0, 5, 0);
            radioButton_Retest.Size = new Size(84, 26);
            radioButton_Retest.TabIndex = 1;
            radioButton_Retest.Text = "复测流程";
            radioButton_Retest.UseVisualStyleBackColor = true;
            // 
            // radioButton_NoRetest
            // 
            radioButton_NoRetest.AutoSize = true;
            radioButton_NoRetest.Checked = true;
            radioButton_NoRetest.Dock = DockStyle.Left;
            radioButton_NoRetest.Location = new Point(0, 0);
            radioButton_NoRetest.Name = "radioButton_NoRetest";
            radioButton_NoRetest.Padding = new Padding(5, 0, 5, 0);
            radioButton_NoRetest.Size = new Size(84, 26);
            radioButton_NoRetest.TabIndex = 0;
            radioButton_NoRetest.TabStop = true;
            radioButton_NoRetest.Text = "正常流程";
            radioButton_NoRetest.UseVisualStyleBackColor = true;
            // 
            // checkBox_Enabled
            // 
            checkBox_Enabled.AutoSize = true;
            checkBox_Enabled.Dock = DockStyle.Left;
            checkBox_Enabled.Location = new Point(968, 0);
            checkBox_Enabled.Margin = new Padding(5);
            checkBox_Enabled.Name = "checkBox_Enabled";
            checkBox_Enabled.Padding = new Padding(5, 0, 5, 0);
            checkBox_Enabled.Size = new Size(85, 30);
            checkBox_Enabled.TabIndex = 5;
            checkBox_Enabled.Text = "流程启用";
            checkBox_Enabled.UseVisualStyleBackColor = true;
            // 
            // Button_Delete
            // 
            Button_Delete.Dock = DockStyle.Left;
            Button_Delete.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Delete.Location = new Point(893, 0);
            Button_Delete.Name = "Button_Delete";
            Button_Delete.Size = new Size(75, 30);
            Button_Delete.TabIndex = 1;
            Button_Delete.Text = "删除";
            Button_Delete.UseVisualStyleBackColor = true;
            Button_Delete.Click += Button_Delete_Click;
            // 
            // Button_Insert
            // 
            Button_Insert.Dock = DockStyle.Left;
            Button_Insert.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Insert.Location = new Point(818, 0);
            Button_Insert.Name = "Button_Insert";
            Button_Insert.Size = new Size(75, 30);
            Button_Insert.TabIndex = 2;
            Button_Insert.Text = "插入";
            Button_Insert.UseVisualStyleBackColor = true;
            Button_Insert.Click += Button_Insert_Click;
            // 
            // Button_Paste
            // 
            Button_Paste.Dock = DockStyle.Left;
            Button_Paste.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Paste.Location = new Point(743, 0);
            Button_Paste.Name = "Button_Paste";
            Button_Paste.Size = new Size(75, 30);
            Button_Paste.TabIndex = 9;
            Button_Paste.Text = "粘贴";
            Button_Paste.UseVisualStyleBackColor = true;
            Button_Paste.Click += Button_Paste_Click;
            // 
            // Button_Copy
            // 
            Button_Copy.Dock = DockStyle.Left;
            Button_Copy.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Copy.Location = new Point(668, 0);
            Button_Copy.Name = "Button_Copy";
            Button_Copy.Size = new Size(75, 30);
            Button_Copy.TabIndex = 8;
            Button_Copy.Text = "复制";
            Button_Copy.UseVisualStyleBackColor = true;
            Button_Copy.Click += Button_Copy_Click;
            // 
            // Button_MoveDown
            // 
            Button_MoveDown.Dock = DockStyle.Left;
            Button_MoveDown.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_MoveDown.Location = new Point(593, 0);
            Button_MoveDown.Name = "Button_MoveDown";
            Button_MoveDown.Size = new Size(75, 30);
            Button_MoveDown.TabIndex = 4;
            Button_MoveDown.Text = "下移";
            Button_MoveDown.UseVisualStyleBackColor = true;
            Button_MoveDown.Click += Button_MoveDown_Click;
            // 
            // Button_MoveUp
            // 
            Button_MoveUp.Dock = DockStyle.Left;
            Button_MoveUp.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_MoveUp.Location = new Point(518, 0);
            Button_MoveUp.Name = "Button_MoveUp";
            Button_MoveUp.Size = new Size(75, 30);
            Button_MoveUp.TabIndex = 3;
            Button_MoveUp.Text = "上移";
            Button_MoveUp.UseVisualStyleBackColor = true;
            Button_MoveUp.Click += Button_MoveUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(518, 27);
            label1.TabIndex = 0;
            label1.Text = "SKIP：空  REST：休眠  CC：恒流充电  CV：恒压充电  CCCV：恒流恒压充电  DC：恒流放电";
            // 
            // UserControl流程信息
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(groupBox4);
            Controls.Add(tableLayoutPanel其他);
            DoubleBuffered = true;
            Name = "UserControl流程信息";
            Size = new Size(1920, 1000);
            tableLayoutPanel其他.ResumeLayout(false);
            tableLayoutPanel其他.PerformLayout();
            tableLayoutPanel保护.ResumeLayout(false);
            tableLayoutPanel保护.PerformLayout();
            groupBox通用保护.ResumeLayout(false);
            groupBox通用保护.PerformLayout();
            groupBox放电保护.ResumeLayout(false);
            groupBox放电保护.PerformLayout();
            groupBox充电保护.ResumeLayout(false);
            groupBox充电保护.PerformLayout();
            tableLayoutPanel辅助测试.ResumeLayout(false);
            tableLayoutPanel辅助测试.PerformLayout();
            panel接触测试.ResumeLayout(false);
            panel接触测试.PerformLayout();
            panelOCV测试.ResumeLayout(false);
            panelOCV测试.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Step).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_DeviceNGLimit).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel其他;
        private GroupBox groupBox通用保护;
        private TableLayoutPanel tableLayoutPanel通用保护;
        private GroupBox groupBox放电保护;
        private TableLayoutPanel tableLayoutPanel放电保护;
        private GroupBox groupBox充电保护;
        private TableLayoutPanel tableLayoutPanel充电保护;
        private DataGridView dataGridView_Step;
        private GroupBox groupBox4;
        private Panel flowLayoutPanel1;
        private Label label1;
        private Button Button_Delete;
        private Button Button_Insert;
        private Button Button_MoveUp;
        private Button Button_MoveDown;
        private TableLayoutPanel tableLayoutPanel保护;
        private TableLayoutPanel tableLayoutPanel辅助测试;
        private TableLayoutPanel tableLayoutPanel接触测试;
        private TableLayoutPanel tableLayoutPanelOCV测试;
        private Panel panel接触测试;
        private CheckBox checkBox接触测试;
        private Panel panelOCV测试;
        private CheckBox checkBoxOCV测试;
        private CheckBox checkBox_Enabled;
        private DataGridViewTextBoxColumn Col步次ID;
        private DataGridViewComboBoxColumn Col步次类型;
        private DataGridViewTextBoxColumn Col电流;
        private DataGridViewTextBoxColumn Col时长;
        private DataGridViewTextBoxColumn Col结束电压;
        private DataGridViewTextBoxColumn Col结束电流;
        private DataGridViewTextBoxColumn Col结束容量;
        private DataGridViewCheckBoxColumn Col单步次保护;
        private DataGridViewTextBoxColumn Col电压下限;
        private DataGridViewTextBoxColumn Col电压上限;
        private DataGridViewTextBoxColumn Col电流下限;
        private DataGridViewTextBoxColumn Col电流上限;
        private DataGridViewTextBoxColumn Col容量下限;
        private DataGridViewTextBoxColumn Col容量上限;
        private RadioButton radioButton_Retest;
        private RadioButton radioButton_NoRetest;
        private Panel panel1;
        private Panel panel2;
        private NumericUpDown numericUpDown_DeviceNGLimit;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 上移ToolStripMenuItem;
        private ToolStripMenuItem 下移ToolStripMenuItem;
        private ToolStripMenuItem 复制ToolStripMenuItem;
        private ToolStripMenuItem 粘贴ToolStripMenuItem;
        private ToolStripMenuItem 插入ToolStripMenuItem;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private Button Button_Paste;
        private Button Button_Copy;
    }
}
