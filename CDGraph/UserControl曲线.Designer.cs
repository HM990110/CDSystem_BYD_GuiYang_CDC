using System.Windows.Forms;

namespace CDGraph
{
    partial class UserControl曲线
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            居中显示ToolStripMenuItem = new ToolStripMenuItem();
            缩放显示ToolStripMenuItem = new ToolStripMenuItem();
            对比视图ToolStripMenuItem = new ToolStripMenuItem();
            保存图片ToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label_Pos1 = new Label();
            label2 = new Label();
            label_ProcessTime = new Label();
            label6 = new Label();
            label_Step = new Label();
            panel_H = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label10 = new Label();
            label7 = new Label();
            label_ChnState = new Label();
            label_ProcessStatus = new Label();
            label_StepWorkTime = new Label();
            label3 = new Label();
            button1 = new Button();
            button_selectAll = new Button();
            checkBox_Crosshair = new CheckBox();
            panel2 = new Panel();
            comboBox_PlotStyle = new ComboBox();
            label4 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel_数据项 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel_PlotFill = new TableLayoutPanel();
            panel_视图平铺 = new Panel();
            tableLayoutPanel_视图平铺 = new TableLayoutPanel();
            panel_视图对比 = new Panel();
            contextMenuStrip1.SuspendLayout();
            panel_H.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel_数据项.SuspendLayout();
            panel_视图平铺.SuspendLayout();
            panel_视图对比.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 居中显示ToolStripMenuItem, 缩放显示ToolStripMenuItem, 对比视图ToolStripMenuItem, 保存图片ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(125, 92);
            // 
            // 居中显示ToolStripMenuItem
            // 
            居中显示ToolStripMenuItem.Name = "居中显示ToolStripMenuItem";
            居中显示ToolStripMenuItem.Size = new Size(124, 22);
            居中显示ToolStripMenuItem.Text = "居中显示";
            居中显示ToolStripMenuItem.Click += 居中显示ToolStripMenuItem_Click;
            // 
            // 缩放显示ToolStripMenuItem
            // 
            缩放显示ToolStripMenuItem.Name = "缩放显示ToolStripMenuItem";
            缩放显示ToolStripMenuItem.Size = new Size(124, 22);
            缩放显示ToolStripMenuItem.Text = "缩放显示";
            缩放显示ToolStripMenuItem.Click += 缩放显示ToolStripMenuItem_Click;
            // 
            // 对比视图ToolStripMenuItem
            // 
            对比视图ToolStripMenuItem.Name = "对比视图ToolStripMenuItem";
            对比视图ToolStripMenuItem.Size = new Size(124, 22);
            对比视图ToolStripMenuItem.Text = "对比视图";
            对比视图ToolStripMenuItem.Click += 对比视图ToolStripMenuItem_Click;
            // 
            // 保存图片ToolStripMenuItem
            // 
            保存图片ToolStripMenuItem.Name = "保存图片ToolStripMenuItem";
            保存图片ToolStripMenuItem.Size = new Size(124, 22);
            保存图片ToolStripMenuItem.Text = "保存图片";
            保存图片ToolStripMenuItem.Click += 保存图片ToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(2, 224);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Tag = -1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "通道：";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_Pos1
            // 
            label_Pos1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Pos1.BorderStyle = BorderStyle.FixedSingle;
            label_Pos1.Location = new Point(0, 20);
            label_Pos1.Margin = new Padding(0);
            label_Pos1.Name = "label_Pos1";
            label_Pos1.Size = new Size(100, 25);
            label_Pos1.TabIndex = 1;
            label_Pos1.Text = "001";
            label_Pos1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(100, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 6;
            label2.Text = "工作时间：";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_ProcessTime
            // 
            label_ProcessTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_ProcessTime.BorderStyle = BorderStyle.FixedSingle;
            label_ProcessTime.Location = new Point(100, 20);
            label_ProcessTime.Margin = new Padding(0);
            label_ProcessTime.Name = "label_ProcessTime";
            label_ProcessTime.Size = new Size(100, 25);
            label_ProcessTime.TabIndex = 7;
            label_ProcessTime.Text = "00:00:00";
            label_ProcessTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(300, 0);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 8;
            label6.Text = "流程步次：";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_Step
            // 
            label_Step.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Step.BorderStyle = BorderStyle.FixedSingle;
            label_Step.Location = new Point(300, 20);
            label_Step.Margin = new Padding(0);
            label_Step.Name = "label_Step";
            label_Step.Size = new Size(100, 25);
            label_Step.TabIndex = 9;
            label_Step.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_H
            // 
            panel_H.BackColor = Color.Transparent;
            panel_H.Controls.Add(tableLayoutPanel2);
            panel_H.Controls.Add(button1);
            panel_H.Controls.Add(button_selectAll);
            panel_H.Controls.Add(checkBox_Crosshair);
            panel_H.Controls.Add(panel2);
            panel_H.Dock = DockStyle.Top;
            panel_H.Location = new Point(0, 0);
            panel_H.Margin = new Padding(4);
            panel_H.Name = "panel_H";
            panel_H.Size = new Size(1904, 45);
            panel_H.TabIndex = 33;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label10, 5, 0);
            tableLayoutPanel2.Controls.Add(label7, 4, 0);
            tableLayoutPanel2.Controls.Add(label6, 3, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label_ProcessTime, 1, 1);
            tableLayoutPanel2.Controls.Add(label_ChnState, 5, 1);
            tableLayoutPanel2.Controls.Add(label_ProcessStatus, 4, 1);
            tableLayoutPanel2.Controls.Add(label_Step, 3, 1);
            tableLayoutPanel2.Controls.Add(label_StepWorkTime, 2, 1);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(label_Pos1, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(371, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(600, 45);
            tableLayoutPanel2.TabIndex = 43;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Location = new Point(500, 0);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 44;
            label10.Text = "电芯状态：";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(400, 0);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 44;
            label7.Text = "工作状态：";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_ChnState
            // 
            label_ChnState.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_ChnState.BorderStyle = BorderStyle.FixedSingle;
            label_ChnState.Location = new Point(500, 20);
            label_ChnState.Margin = new Padding(0);
            label_ChnState.Name = "label_ChnState";
            label_ChnState.Size = new Size(100, 25);
            label_ChnState.TabIndex = 45;
            label_ChnState.Text = "00";
            label_ChnState.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_ProcessStatus
            // 
            label_ProcessStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_ProcessStatus.BorderStyle = BorderStyle.FixedSingle;
            label_ProcessStatus.Location = new Point(400, 20);
            label_ProcessStatus.Margin = new Padding(0);
            label_ProcessStatus.Name = "label_ProcessStatus";
            label_ProcessStatus.Size = new Size(100, 25);
            label_ProcessStatus.TabIndex = 44;
            label_ProcessStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_StepWorkTime
            // 
            label_StepWorkTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_StepWorkTime.BorderStyle = BorderStyle.FixedSingle;
            label_StepWorkTime.Location = new Point(200, 20);
            label_StepWorkTime.Margin = new Padding(0);
            label_StepWorkTime.Name = "label_StepWorkTime";
            label_StepWorkTime.Size = new Size(100, 25);
            label_StepWorkTime.TabIndex = 47;
            label_StepWorkTime.Text = "00:00:00";
            label_StepWorkTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(200, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 46;
            label3.Text = "流程步次：";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Font = new Font("微软雅黑", 9F);
            button1.Location = new Point(282, 0);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(89, 45);
            button1.TabIndex = 85;
            button1.Tag = "视图对比";
            button1.Text = "视图切换";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button_selectAll
            // 
            button_selectAll.Dock = DockStyle.Left;
            button_selectAll.Font = new Font("微软雅黑", 9F);
            button_selectAll.Location = new Point(193, 0);
            button_selectAll.Margin = new Padding(4);
            button_selectAll.Name = "button_selectAll";
            button_selectAll.Size = new Size(89, 45);
            button_selectAll.TabIndex = 40;
            button_selectAll.Text = "通道选择";
            button_selectAll.UseVisualStyleBackColor = true;
            button_selectAll.Click += Button_selectAll_Click;
            // 
            // checkBox_Crosshair
            // 
            checkBox_Crosshair.AutoSize = true;
            checkBox_Crosshair.Dock = DockStyle.Left;
            checkBox_Crosshair.Font = new Font("微软雅黑", 9F);
            checkBox_Crosshair.Location = new Point(118, 0);
            checkBox_Crosshair.Margin = new Padding(0);
            checkBox_Crosshair.Name = "checkBox_Crosshair";
            checkBox_Crosshair.Size = new Size(75, 45);
            checkBox_Crosshair.TabIndex = 83;
            checkBox_Crosshair.Text = "十字光标";
            checkBox_Crosshair.UseVisualStyleBackColor = true;
            checkBox_Crosshair.CheckedChanged += CheckBox2_CheckedChanged;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(comboBox_PlotStyle);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(118, 45);
            panel2.TabIndex = 84;
            // 
            // comboBox_PlotStyle
            // 
            comboBox_PlotStyle.Dock = DockStyle.Left;
            comboBox_PlotStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_PlotStyle.FormattingEnabled = true;
            comboBox_PlotStyle.Items.AddRange(new object[] { "黑色", "蓝色1", "蓝色2", "蓝色3", "酒红色", "控制", "默认", "灰色1", "灰色2", "浅褐色", "浅色1", "浅色2", "等宽字体", "粉色", "海鸥色" });
            comboBox_PlotStyle.Location = new Point(0, 17);
            comboBox_PlotStyle.Margin = new Padding(0);
            comboBox_PlotStyle.Name = "comboBox_PlotStyle";
            comboBox_PlotStyle.Size = new Size(114, 25);
            comboBox_PlotStyle.TabIndex = 35;
            comboBox_PlotStyle.SelectedValueChanged += ComboBox_PlotStyle_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0, 2, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 1;
            label4.Text = "图表样式：";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Location = new Point(1, 1);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Padding = new Padding(3);
            label8.Size = new Size(62, 24);
            label8.TabIndex = 1;
            label8.Text = "数据项：";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tableLayoutPanel_数据项);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 746);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 250);
            panel1.TabIndex = 45;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(1904, 224);
            panel3.TabIndex = 34;
            // 
            // tableLayoutPanel_数据项
            // 
            tableLayoutPanel_数据项.AutoSize = true;
            tableLayoutPanel_数据项.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel_数据项.ColumnCount = 2;
            tableLayoutPanel_数据项.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel_数据项.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_数据项.Controls.Add(label8, 0, 0);
            tableLayoutPanel_数据项.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel_数据项.Dock = DockStyle.Top;
            tableLayoutPanel_数据项.ForeColor = Color.White;
            tableLayoutPanel_数据项.Location = new Point(0, 0);
            tableLayoutPanel_数据项.Name = "tableLayoutPanel_数据项";
            tableLayoutPanel_数据项.RowCount = 1;
            tableLayoutPanel_数据项.RowStyles.Add(new RowStyle());
            tableLayoutPanel_数据项.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_数据项.Size = new Size(1904, 26);
            tableLayoutPanel_数据项.TabIndex = 33;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(64, 1);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(2);
            flowLayoutPanel1.Size = new Size(1839, 24);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // tableLayoutPanel_PlotFill
            // 
            tableLayoutPanel_PlotFill.BackColor = Color.Black;
            tableLayoutPanel_PlotFill.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel_PlotFill.ColumnCount = 2;
            tableLayoutPanel_PlotFill.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_PlotFill.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
            tableLayoutPanel_PlotFill.Dock = DockStyle.Fill;
            tableLayoutPanel_PlotFill.Location = new Point(0, 0);
            tableLayoutPanel_PlotFill.Name = "tableLayoutPanel_PlotFill";
            tableLayoutPanel_PlotFill.RowCount = 1;
            tableLayoutPanel_PlotFill.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_PlotFill.Size = new Size(1904, 746);
            tableLayoutPanel_PlotFill.TabIndex = 46;
            tableLayoutPanel_PlotFill.Tag = -1;
            // 
            // panel_视图平铺
            // 
            panel_视图平铺.BackColor = Color.Black;
            panel_视图平铺.Controls.Add(tableLayoutPanel_视图平铺);
            panel_视图平铺.Dock = DockStyle.Fill;
            panel_视图平铺.Location = new Point(0, 45);
            panel_视图平铺.Name = "panel_视图平铺";
            panel_视图平铺.Size = new Size(1904, 996);
            panel_视图平铺.TabIndex = 47;
            // 
            // tableLayoutPanel_视图平铺
            // 
            tableLayoutPanel_视图平铺.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel_视图平铺.ColumnCount = 1;
            tableLayoutPanel_视图平铺.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_视图平铺.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_视图平铺.Dock = DockStyle.Fill;
            tableLayoutPanel_视图平铺.Location = new Point(0, 0);
            tableLayoutPanel_视图平铺.Name = "tableLayoutPanel_视图平铺";
            tableLayoutPanel_视图平铺.RowCount = 1;
            tableLayoutPanel_视图平铺.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_视图平铺.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_视图平铺.Size = new Size(1904, 996);
            tableLayoutPanel_视图平铺.TabIndex = 0;
            // 
            // panel_视图对比
            // 
            panel_视图对比.BackColor = Color.Black;
            panel_视图对比.Controls.Add(tableLayoutPanel_PlotFill);
            panel_视图对比.Controls.Add(panel1);
            panel_视图对比.Dock = DockStyle.Fill;
            panel_视图对比.Location = new Point(0, 45);
            panel_视图对比.Name = "panel_视图对比";
            panel_视图对比.Size = new Size(1904, 996);
            panel_视图对比.TabIndex = 48;
            panel_视图对比.Tag = -1;
            // 
            // UserControl曲线
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel_视图对比);
            Controls.Add(panel_视图平铺);
            Controls.Add(panel_H);
            Margin = new Padding(4);
            Name = "UserControl曲线";
            Size = new Size(1904, 1041);
            contextMenuStrip1.ResumeLayout(false);
            panel_H.ResumeLayout(false);
            panel_H.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel_数据项.ResumeLayout(false);
            tableLayoutPanel_数据项.PerformLayout();
            panel_视图平铺.ResumeLayout(false);
            panel_视图对比.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_H;
        private Button button_selectAll;
        private ComboBox comboBox_PlotStyle;
        private Label label1;
        private Label label_Pos1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 居中显示ToolStripMenuItem;
        private ToolStripMenuItem 缩放显示ToolStripMenuItem;
        private ToolStripMenuItem 保存图片ToolStripMenuItem;
        private Label label2;
        private Label label_ProcessTime;
        private Label label6;
        private Label label_Step;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox checkBox_Crosshair;
        private Label label_ProcessStatus;
        private Label label7;
        private Label label_ChnState;
        private Label label10;
        private Panel panel1;
        private Label label8;
        private Panel panel2;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel_数据项;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel_PlotFill;
        private Panel panel_视图平铺;
        private TableLayoutPanel tableLayoutPanel_视图平铺;
        private Panel panel_视图对比;
        private ToolStripMenuItem 对比视图ToolStripMenuItem;
        private Button button1;
        private Label label_StepWorkTime;
        private Label label3;
    }
}

