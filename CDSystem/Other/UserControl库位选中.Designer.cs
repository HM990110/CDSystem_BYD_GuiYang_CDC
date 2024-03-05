namespace CDSystem.Other
{
    partial class UserControl设备选中
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ComboBoxRow = new ComboBox();
            ComboBoxColumn = new ComboBox();
            ComboBoxLine = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            myClass设备选中BindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myClass设备选中BindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333244F));
            tableLayoutPanel1.Controls.Add(ComboBoxRow, 5, 0);
            tableLayoutPanel1.Controls.Add(ComboBoxColumn, 3, 0);
            tableLayoutPanel1.Controls.Add(ComboBoxLine, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(434, 56);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ComboBoxRow
            // 
            ComboBoxRow.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxRow.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxRow.FlatStyle = FlatStyle.System;
            ComboBoxRow.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxRow.FormattingEnabled = true;
            ComboBoxRow.Location = new Point(317, 15);
            ComboBoxRow.Margin = new Padding(0);
            ComboBoxRow.Name = "ComboBoxRow";
            ComboBoxRow.Size = new Size(117, 25);
            ComboBoxRow.TabIndex = 5;
            // 
            // ComboBoxColumn
            // 
            ComboBoxColumn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxColumn.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxColumn.FlatStyle = FlatStyle.System;
            ComboBoxColumn.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxColumn.FormattingEnabled = true;
            ComboBoxColumn.Location = new Point(173, 15);
            ComboBoxColumn.Margin = new Padding(0);
            ComboBoxColumn.Name = "ComboBoxColumn";
            ComboBoxColumn.Size = new Size(115, 25);
            ComboBoxColumn.TabIndex = 4;
            // 
            // ComboBoxLine
            // 
            ComboBoxLine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxLine.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxLine.FlatStyle = FlatStyle.System;
            ComboBoxLine.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxLine.FormattingEnabled = true;
            ComboBoxLine.Location = new Point(29, 15);
            ComboBoxLine.Margin = new Padding(0);
            ComboBoxLine.Name = "ComboBoxLine";
            ComboBoxLine.Size = new Size(115, 25);
            ComboBoxLine.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Margin = new Padding(6, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 7;
            label1.Text = "排:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(150, 19);
            label2.Margin = new Padding(6, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 8;
            label2.Text = "列:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(294, 19);
            label3.Margin = new Padding(6, 0, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 17);
            label3.TabIndex = 9;
            label3.Text = "层:";
            // 
            // UserControl设备选中
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "UserControl设备选中";
            Size = new Size(434, 56);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myClass设备选中BindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox ComboBoxLine;
        private ComboBox ComboBoxRow;
        private ComboBox ComboBoxColumn;
        private BindingSource myClass设备选中BindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
