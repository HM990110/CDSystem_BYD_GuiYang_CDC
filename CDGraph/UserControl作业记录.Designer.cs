namespace CDGraph
{
    partial class UserControl作业记录
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Col托盘号 = new DataGridViewTextBoxColumn();
            Col批次编号 = new DataGridViewTextBoxColumn();
            Col电池型号 = new DataGridViewTextBoxColumn();
            Col设备编号 = new DataGridViewTextBoxColumn();
            Col开始时间 = new DataGridViewTextBoxColumn();
            Col结束时间 = new DataGridViewTextBoxColumn();
            Col自动流程 = new DataGridViewTextBoxColumn();
            Col自动停止 = new DataGridViewTextBoxColumn();
            Col电池数量 = new DataGridViewTextBoxColumn();
            ColNG数量 = new DataGridViewTextBoxColumn();
            Col数据包地址 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Col托盘号, Col批次编号, Col电池型号, Col设备编号, Col开始时间, Col结束时间, Col自动流程, Col自动停止, Col电池数量, ColNG数量, Col数据包地址 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1117, 754);
            dataGridView1.TabIndex = 5;
            // 
            // Col托盘号
            // 
            Col托盘号.HeaderText = "托盘号";
            Col托盘号.Name = "Col托盘号";
            Col托盘号.Width = 68;
            // 
            // Col批次编号
            // 
            Col批次编号.HeaderText = "批次编号";
            Col批次编号.Name = "Col批次编号";
            Col批次编号.Width = 80;
            // 
            // Col电池型号
            // 
            Col电池型号.HeaderText = "电池型号";
            Col电池型号.Name = "Col电池型号";
            Col电池型号.Width = 80;
            // 
            // Col设备编号
            // 
            Col设备编号.HeaderText = "设备编号";
            Col设备编号.Name = "Col设备编号";
            Col设备编号.Width = 80;
            // 
            // Col开始时间
            // 
            Col开始时间.HeaderText = "开始时间";
            Col开始时间.Name = "Col开始时间";
            Col开始时间.Width = 80;
            // 
            // Col结束时间
            // 
            Col结束时间.HeaderText = "结束时间";
            Col结束时间.Name = "Col结束时间";
            Col结束时间.Width = 80;
            // 
            // Col自动流程
            // 
            Col自动流程.HeaderText = "自动流程";
            Col自动流程.Name = "Col自动流程";
            Col自动流程.Width = 80;
            // 
            // Col自动停止
            // 
            Col自动停止.HeaderText = "自动停止";
            Col自动停止.Name = "Col自动停止";
            Col自动停止.Width = 80;
            // 
            // Col电池数量
            // 
            Col电池数量.HeaderText = "电池数量";
            Col电池数量.Name = "Col电池数量";
            Col电池数量.Width = 80;
            // 
            // ColNG数量
            // 
            ColNG数量.HeaderText = "NG数量";
            ColNG数量.Name = "ColNG数量";
            ColNG数量.Width = 75;
            // 
            // Col数据包地址
            // 
            Col数据包地址.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col数据包地址.HeaderText = "数据包地址";
            Col数据包地址.Name = "Col数据包地址";
            // 
            // UserControl作业记录
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "UserControl作业记录";
            Size = new Size(1117, 754);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Col托盘号;
        private DataGridViewTextBoxColumn Col批次编号;
        private DataGridViewTextBoxColumn Col电池型号;
        private DataGridViewTextBoxColumn Col设备编号;
        private DataGridViewTextBoxColumn Col开始时间;
        private DataGridViewTextBoxColumn Col结束时间;
        private DataGridViewTextBoxColumn Col自动流程;
        private DataGridViewTextBoxColumn Col自动停止;
        private DataGridViewTextBoxColumn Col电池数量;
        private DataGridViewTextBoxColumn ColNG数量;
        private DataGridViewTextBoxColumn Col数据包地址;
    }
}
