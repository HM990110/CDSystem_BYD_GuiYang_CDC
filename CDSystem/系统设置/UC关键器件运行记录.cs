using CDClassLibrary.Stage;
using CDClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDClassLibrary.Data;
using CDSystem.Language;

namespace CDSystem.系统设置
{
    public partial class UC关键器件运行记录 : UserControl
    {

        public void Language()
        {
            Button_ChannelOne.Text = ResourceLang.UC关键器件运行记录Button_ChannelOneText;
            Button_DeviceAll.Text = ResourceLang.UC关键器件运行记录Button_DeviceAllText;
            Button_DeviceOne.Text = ResourceLang.UC关键器件运行记录Button_DeviceOneText;
            Button_SaveNGCount.Text = ResourceLang.UC关键器件运行记录Button_SaveNGCountText;
            button2.Text = ResourceLang.UC关键器件运行记录button2Text;
            Column1.HeaderText = ResourceLang.UC关键器件运行记录Column1HeaderText;
            groupBox逆变器.Text = ResourceLang.UC关键器件运行记录groupBox逆变器Text;
            groupBox探针.Text = ResourceLang.UC关键器件运行记录groupBox探针Text;
            label2.Text = ResourceLang.UC关键器件运行记录label2Text;
            label3.Text = ResourceLang.UC关键器件运行记录label3Text;
            label4.Text = ResourceLang.UC关键器件运行记录label4Text;
            label5.Text = ResourceLang.UC关键器件运行记录label5Text;
            label6.Text = ResourceLang.UC关键器件运行记录label6Text;
            radioButton_ContactLimit.Text = ResourceLang.UC关键器件运行记录radioButton_ContactLimitText;
            radioButton_NGLimit.Text = ResourceLang.UC关键器件运行记录radioButton_NGLimitText;
            radioButton_RunLimit.Text = ResourceLang.UC关键器件运行记录radioButton_RunLimitText;
            radioButton1.Text = ResourceLang.UC关键器件运行记录radioButton1Text;
        }

        readonly Label[] Label_Probe = new Label[GlobalDefine.CHANNELS];

        public void Power()
        {
            panel1.Enabled = Program.ClassUser.Power.系统设置;
            tableLayoutPanel6.Enabled = Program.ClassUser.Power.系统设置;
        }

        public UC关键器件运行记录()
        {
            InitializeComponent();
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                comboBox_Device.Items.Add(GlobalParams.GStages[FStageID].FStageNo);
            }

            TableLayoutPanel_ProbeCount.RowStyles.Clear();
            TableLayoutPanel_ProbeCount.RowCount = GlobalDefine.CHANNELRow + 2;
            TableLayoutPanel_ProbeCount.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                TableLayoutPanel_ProbeCount.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                TableLayoutPanel_ProbeCount.Controls.Add(new Label()
                {
                    Text = $"{(i * GlobalDefine.CHANNELRow + 1):000}-{((i + 1) * GlobalDefine.CHANNELRow):000}",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(3),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.Black,
                    ForeColor = Color.White,
                }, 0, i + 1);
            }
            TableLayoutPanel_ProbeCount.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            TableLayoutPanel_ProbeCount.ColumnStyles.Clear();
            TableLayoutPanel_ProbeCount.ColumnCount = GlobalDefine.CHANNELColumn + 2;
            TableLayoutPanel_ProbeCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            for (int i = 0; i < GlobalDefine.CHANNELColumn; i++)
            {
                TableLayoutPanel_ProbeCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                TableLayoutPanel_ProbeCount.Controls.Add(new Label()
                {
                    Text = (i + 1).ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(3),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.Black,
                    ForeColor = Color.White,
                }, i + 1, 0);
            }
            TableLayoutPanel_ProbeCount.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            TableLayoutPanel_ProbeCount.Controls.Add(new Label()
            {
                Text = "缺角",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Margin = new Padding(3),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Black,
                ForeColor = Color.White,
            }, 0, 0);

            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                {
                    int x = j + i * GlobalDefine.CHANNELColumn;
                    Label_Probe[x] = new Label()
                    {
                        Text = "0",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        BackColor = Color.White,
                        ForeColor = Color.Black,
                        Margin = new Padding(3),
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = (x + 1),
                    };
                    Label_Probe[x].Click += Label_Probe_Click!;
                    TableLayoutPanel_ProbeCount.Controls.Add(Label_Probe[x], j + 1, i + 1);
                }
            }

            numericUpDown_Probe.Maximum = GlobalDefine.CHANNELS;
            numericUpDown_ChannelNGLimit.Value = GlobalDefine.DeviceNGCount.ChannelNGLimit;

            comboBox_Device.SelectedIndex = 0;
        }

        public void DataShow()
        {
            NeedleCount();
        }

        private void NeedleCount()
        {
            int Index = comboBox_Device.SelectedIndex;
            if (Index > -1)
            {
                Button_ChannelOne.Enabled = false;
                Button_DeviceOne.Enabled = false;
                Button_DeviceAll.Enabled = false;

                if (radioButton_ContactLimit.Checked)
                {
                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    {
                        Label_Probe[ChnNo].Text = GlobalDefine.DeviceNGCount.ContactCount[Index][ChnNo].ToString();
                        if (GlobalDefine.DeviceNGCount.ContactCount[Index][ChnNo] > GlobalDefine.DeviceNGCount.ContactLimit)
                            Label_Probe[ChnNo].BackColor = Color.Red;
                        else
                            Label_Probe[ChnNo].BackColor = Color.White;
                    }
                }
                else if (radioButton_RunLimit.Checked)
                {
                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    {
                        Label_Probe[ChnNo].Text = GlobalDefine.DeviceNGCount.RunCount[Index][ChnNo].ToString();
                        if (GlobalDefine.DeviceNGCount.RunCount[Index][ChnNo] > GlobalDefine.DeviceNGCount.RunLimit)
                            Label_Probe[ChnNo].BackColor = Color.Red;
                        else
                            Label_Probe[ChnNo].BackColor = Color.White;
                    }
                }
                else if (radioButton_NGLimit.Checked)
                {
                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    {
                        Label_Probe[ChnNo].Text = GlobalDefine.DeviceNGCount.NGCount[Index][ChnNo].ToString();
                        if (GlobalDefine.DeviceNGCount.NGCount[Index][ChnNo] > GlobalDefine.DeviceNGCount.ChannelNGLimit)
                            Label_Probe[ChnNo].BackColor = Color.Red;
                        else
                            Label_Probe[ChnNo].BackColor = Color.White;
                    }

                    Button_ChannelOne.Enabled = true;
                    Button_DeviceOne.Enabled = true;
                    Button_DeviceAll.Enabled = true;
                }
                else if (radioButton1.Checked)
                {
                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                    {
                        Label_Probe[ChnNo].Text = GlobalDefine.DeviceNGCount.UpKeepCount[Index][ChnNo].ToString();
                        Label_Probe[ChnNo].BackColor = Color.White;
                    }
                }

                dataGridView_InverterPower.Rows.Clear();
                DataTable? data = DatabaseOperations.PartStatisticSelect(GlobalParams.GStages[Index].FStageNo);
                if (data != null)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        if (row["LType"].ToString() == "逆变器")
                        {
                            int x = dataGridView_InverterPower.Rows.Add();
                            dataGridView_InverterPower.Rows[x].Cells[0].Value = row["Time"].ToString();
                        }
                    }
                }
            }
        }

        private void ComboBox_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            NeedleCount();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            NeedleCount();
        }

        private void RadioButton_ContactLimit_Click(object sender, EventArgs e)
        {
            NeedleCount();
        }

        private void Label_Probe_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            _ = int.TryParse(label.Tag.ToString(), out int Value);
            numericUpDown_Probe.Value = Value;
        }

        private void Button_DeviceAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否清除所有设备通道NG统计？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    Label_Probe[ChnNo].Text = "0";
                }
                for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                {
                    for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                        GlobalDefine.DeviceNGCount.NGCount[FStageID][ChnNo] = 0;
                }
                GlobalFunction.SetParameterLimit();
                NeedleCount();
            }
        }

        private void Button_DeviceOne_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否清除当前设备通道NG统计？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    GlobalDefine.DeviceNGCount.NGCount[comboBox_Device.SelectedIndex][ChnNo] = 0;
                }
                GlobalFunction.SetParameterLimit();
                NeedleCount();
            }
        }

        private void Button_ChannelOne_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否清除当前设备该通道NG统计？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GlobalDefine.DeviceNGCount.NGCount[comboBox_Device.SelectedIndex][(int)(numericUpDown_Probe.Value - 1)] = 0;
                GlobalDefine.DeviceNGCount.UpKeepCount[comboBox_Device.SelectedIndex][(int)(numericUpDown_Probe.Value - 1)]++;
                GlobalFunction.SetParameterLimit();
                NeedleCount();
            }
        }

        private void Button_SaveNGCount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否保存设备通道NG统计？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GlobalDefine.DeviceNGCount.ChannelNGLimit = (int)numericUpDown_ChannelNGLimit.Value;
                GlobalDefine.DeviceNGCount.ContactLimit = (int)numericUpDown_ContactLimit.Value;
                GlobalDefine.DeviceNGCount.RunLimit = (int)numericUpDown_RunLimit.Value;

                GlobalFunction.SetNGCount();
            }
        }

    }
}
