namespace CDSystem.系统设置
{
    partial class UC映射设置
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView_Mapping = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            Button_MappingSave = new Button();
            Button_MappingAuto = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Mapping).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dataGridView_Mapping, 0, 0);
            tableLayoutPanel3.Controls.Add(panel2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1902, 909);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // dataGridView_Mapping
            // 
            dataGridView_Mapping.AllowUserToAddRows = false;
            dataGridView_Mapping.AllowUserToDeleteRows = false;
            dataGridView_Mapping.AllowUserToResizeColumns = false;
            dataGridView_Mapping.AllowUserToResizeRows = false;
            dataGridView_Mapping.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridView_Mapping.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Mapping.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_Mapping.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_Mapping.Location = new Point(3, 3);
            dataGridView_Mapping.MultiSelect = false;
            dataGridView_Mapping.Name = "dataGridView_Mapping";
            dataGridView_Mapping.RowHeadersWidth = 120;
            dataGridView_Mapping.RowTemplate.Height = 40;
            dataGridView_Mapping.ScrollBars = ScrollBars.None;
            dataGridView_Mapping.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_Mapping.Size = new Size(125, 85);
            dataGridView_Mapping.TabIndex = 7;
            dataGridView_Mapping.CellValueChanged += DataGridView_Mapping_CellValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Button_MappingSave);
            panel2.Controls.Add(Button_MappingAuto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(134, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1765, 903);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(164, 17);
            label1.TabIndex = 4;
            label1.Text = "不能在设备运行时修改映射。";
            // 
            // Button_MappingSave
            // 
            Button_MappingSave.Location = new Point(12, 32);
            Button_MappingSave.Margin = new Padding(12, 12, 12, 0);
            Button_MappingSave.Name = "Button_MappingSave";
            Button_MappingSave.Size = new Size(100, 30);
            Button_MappingSave.TabIndex = 3;
            Button_MappingSave.Text = "保存";
            Button_MappingSave.UseVisualStyleBackColor = true;
            Button_MappingSave.Click += Button_MappingSave_Click;
            // 
            // Button_MappingAuto
            // 
            Button_MappingAuto.Location = new Point(12, 74);
            Button_MappingAuto.Margin = new Padding(12, 12, 12, 0);
            Button_MappingAuto.Name = "Button_MappingAuto";
            Button_MappingAuto.Size = new Size(100, 30);
            Button_MappingAuto.TabIndex = 2;
            Button_MappingAuto.Tag = "0";
            Button_MappingAuto.Text = "自动";
            Button_MappingAuto.UseVisualStyleBackColor = true;
            Button_MappingAuto.Click += Button_MappingAuto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(93, 198, 215);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1902, 909);
            dataGridView1.TabIndex = 6;
            // 
            // UC映射设置
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel3);
            Controls.Add(dataGridView1);
            Name = "UC映射设置";
            Size = new Size(1902, 909);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Mapping).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView_Mapping;
        private Panel panel2;
        private Button Button_MappingSave;
        private Button Button_MappingAuto;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
