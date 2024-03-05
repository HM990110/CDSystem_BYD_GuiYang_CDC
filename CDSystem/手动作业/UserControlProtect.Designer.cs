namespace CDSystem.手动作业
{
    partial class UserControlProtect
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
            checkBox1 = new CheckBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(0, 0);
            checkBox1.Margin = new Padding(0);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(2, 0, 0, 0);
            checkBox1.Size = new Size(316, 20);
            checkBox1.TabIndex = 0;
            toolTip1.SetToolTip(checkBox1, "属性");
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "属性";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(386, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(label1, "属性");
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Right;
            numericUpDown1.Location = new Point(316, 0);
            numericUpDown1.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 99999, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Right;
            // 
            // UserControlProtect
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.SkyBlue;
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(1);
            Name = "UserControlProtect";
            Size = new Size(421, 20);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private ToolTip toolTip1;
        private Label label1;
        private NumericUpDown numericUpDown1;
    }
}
