namespace CDSystem.实时数据
{
    partial class Form电芯条码
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form电芯条码));
            TableLayoutPanel_ProbeCount = new TableLayoutPanel();
            SuspendLayout();
            // 
            // TableLayoutPanel_ProbeCount
            // 
            TableLayoutPanel_ProbeCount.ColumnCount = 1;
            TableLayoutPanel_ProbeCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_ProbeCount.Dock = DockStyle.Fill;
            TableLayoutPanel_ProbeCount.Location = new Point(0, 0);
            TableLayoutPanel_ProbeCount.Name = "TableLayoutPanel_ProbeCount";
            TableLayoutPanel_ProbeCount.RowCount = 1;
            TableLayoutPanel_ProbeCount.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_ProbeCount.Size = new Size(1584, 861);
            TableLayoutPanel_ProbeCount.TabIndex = 1;
            // 
            // Form电芯条码
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(TableLayoutPanel_ProbeCount);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form电芯条码";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "电芯条码";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel_ProbeCount;
    }
}