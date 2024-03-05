using CDClassLibrary;
using CDClassLibrary.Stage;
using CDSystem.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDSystem.实时数据
{
    public partial class Form电芯条码 : Form
    {
        public void Language()
        {


        }

        readonly Label[] Label_Probe = new Label[GlobalDefine.CHANNELS];

        public Form电芯条码()
        {
            InitializeComponent();


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
                        Text = GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.CellNumber[x],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        ForeColor = Color.Black,
                        Margin = new Padding(3),
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = (x + 1),
                    };
                    if (GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.ChnState[i] == 0x60)
                        Label_Probe[x].BackColor = Color.White;
                    if (GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.ChnState[i] == 0x61)
                        Label_Probe[x].BackColor = Color.Gainsboro;
                    else
                        Label_Probe[x].BackColor = Color.Cyan;

                    TableLayoutPanel_ProbeCount.Controls.Add(Label_Probe[x], j + 1, i + 1);
                }
            }
        }
    }
}
