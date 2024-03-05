namespace CDSystem.设备状态
{
    partial class UserControlDevice
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
            TableLayoutPanelDevices = new TableLayoutPanel();
            PanelFStageID = new Panel();
            LabelDeviceOnOff = new Label();
            LabelFStageNo = new Label();
            labelStr1 = new Label();
            labelStr2 = new Label();
            labelStr3 = new Label();
            labelStr4 = new Label();
            TableLayoutPanelDevices.SuspendLayout();
            PanelFStageID.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelDevices
            // 
            TableLayoutPanelDevices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelDevices.Controls.Add(PanelFStageID, 0, 0);
            TableLayoutPanelDevices.Controls.Add(labelStr1, 0, 1);
            TableLayoutPanelDevices.Controls.Add(labelStr2, 0, 2);
            TableLayoutPanelDevices.Controls.Add(labelStr3, 0, 3);
            TableLayoutPanelDevices.Controls.Add(labelStr4, 0, 4);
            TableLayoutPanelDevices.Dock = DockStyle.Fill;
            TableLayoutPanelDevices.Location = new Point(2, 2);
            TableLayoutPanelDevices.Name = "TableLayoutPanelDevices";
            TableLayoutPanelDevices.RowCount = 1;
            TableLayoutPanelDevices.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TableLayoutPanelDevices.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanelDevices.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanelDevices.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanelDevices.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanelDevices.Size = new Size(144, 144);
            TableLayoutPanelDevices.TabIndex = 0;
            TableLayoutPanelDevices.Click += This_Click;
            TableLayoutPanelDevices.DoubleClick += This_DoubleClick;
            TableLayoutPanelDevices.MouseDown += This_MouseDown;
            // 
            // PanelFStageID
            // 
            PanelFStageID.BorderStyle = BorderStyle.FixedSingle;
            PanelFStageID.Controls.Add(LabelDeviceOnOff);
            PanelFStageID.Controls.Add(LabelFStageNo);
            PanelFStageID.Dock = DockStyle.Fill;
            PanelFStageID.Location = new Point(0, 0);
            PanelFStageID.Margin = new Padding(0);
            PanelFStageID.Name = "PanelFStageID";
            PanelFStageID.Size = new Size(144, 25);
            PanelFStageID.TabIndex = 0;
            PanelFStageID.MouseDown += This_MouseDown;
            // 
            // LabelDeviceOnOff
            // 
            LabelDeviceOnOff.BackColor = Color.Red;
            LabelDeviceOnOff.Dock = DockStyle.Right;
            LabelDeviceOnOff.Location = new Point(92, 0);
            LabelDeviceOnOff.Name = "LabelDeviceOnOff";
            LabelDeviceOnOff.Size = new Size(50, 23);
            LabelDeviceOnOff.TabIndex = 0;
            LabelDeviceOnOff.TextAlign = ContentAlignment.MiddleCenter;
            LabelDeviceOnOff.Click += This_Click;
            LabelDeviceOnOff.DoubleClick += This_DoubleClick;
            LabelDeviceOnOff.MouseDown += This_MouseDown;
            // 
            // LabelFStageNo
            // 
            LabelFStageNo.Dock = DockStyle.Fill;
            LabelFStageNo.Location = new Point(0, 0);
            LabelFStageNo.Name = "LabelFStageNo";
            LabelFStageNo.Size = new Size(142, 23);
            LabelFStageNo.TabIndex = 1;
            LabelFStageNo.TextAlign = ContentAlignment.MiddleLeft;
            LabelFStageNo.Click += This_Click;
            LabelFStageNo.DoubleClick += This_DoubleClick;
            LabelFStageNo.MouseDown += This_MouseDown;
            // 
            // labelStr1
            // 
            labelStr1.Dock = DockStyle.Fill;
            labelStr1.Location = new Point(3, 25);
            labelStr1.Name = "labelStr1";
            labelStr1.Size = new Size(138, 29);
            labelStr1.TabIndex = 1;
            labelStr1.TextAlign = ContentAlignment.MiddleCenter;
            labelStr1.Click += This_Click;
            labelStr1.DoubleClick += This_DoubleClick;
            labelStr1.MouseDown += This_MouseDown;
            // 
            // labelStr2
            // 
            labelStr2.Dock = DockStyle.Fill;
            labelStr2.Location = new Point(3, 54);
            labelStr2.Name = "labelStr2";
            labelStr2.Size = new Size(138, 29);
            labelStr2.TabIndex = 2;
            labelStr2.TextAlign = ContentAlignment.MiddleCenter;
            labelStr2.Click += This_Click;
            labelStr2.DoubleClick += This_DoubleClick;
            labelStr2.MouseDown += This_MouseDown;
            // 
            // labelStr3
            // 
            labelStr3.Dock = DockStyle.Fill;
            labelStr3.Location = new Point(3, 83);
            labelStr3.Name = "labelStr3";
            labelStr3.Size = new Size(138, 29);
            labelStr3.TabIndex = 3;
            labelStr3.TextAlign = ContentAlignment.MiddleCenter;
            labelStr3.Click += This_Click;
            labelStr3.DoubleClick += This_DoubleClick;
            labelStr3.MouseDown += This_MouseDown;
            // 
            // labelStr4
            // 
            labelStr4.Dock = DockStyle.Fill;
            labelStr4.Location = new Point(3, 112);
            labelStr4.Name = "labelStr4";
            labelStr4.Size = new Size(138, 32);
            labelStr4.TabIndex = 4;
            labelStr4.TextAlign = ContentAlignment.MiddleCenter;
            labelStr4.Click += This_Click;
            labelStr4.DoubleClick += This_DoubleClick;
            labelStr4.MouseDown += This_MouseDown;
            // 
            // UserControlDevice
            // 
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(TableLayoutPanelDevices);
            DoubleBuffered = true;
            Name = "UserControlDevice";
            Padding = new Padding(2);
            Size = new Size(148, 148);
            Click += This_Click;
            DoubleClick += This_DoubleClick;
            MouseDown += This_MouseDown;
            TableLayoutPanelDevices.ResumeLayout(false);
            PanelFStageID.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel TableLayoutPanelDevices;
        private Label labelStr2;
        private Label labelStr1;
        private Label LabelDeviceOnOff;
        private Label LabelFStageNo;
        private Panel PanelFStageID;
        private Label labelStr3;
        private Label labelStr4;
    }
}
