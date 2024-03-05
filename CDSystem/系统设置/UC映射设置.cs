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

namespace CDSystem.系统设置
{
    public partial class UC映射设置 : UserControl
    {
        public void Language()
        {
            Button_MappingAuto.Text = ResourceLang.UC映射设置Button_MappAutoText;
            Button_MappingSave.Text = ResourceLang.UC映射设置Button_MappSaveText;
            label1.Text = ResourceLang.UC映射设置label1Text;
        }

        public UC映射设置()
        {
            InitializeComponent();

            dataGridView_Mapping.Size = new Size(GlobalDefine.CHANNELColumn * 40 + 125, GlobalDefine.CHANNELRow * 40 + 45);
            for (int i = 0; i < GlobalDefine.CHANNELColumn; i++)
            {
                dataGridView_Mapping.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                dataGridView_Mapping.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView_Mapping.Columns[i].Width = 40;
            }
            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                int x = i * GlobalDefine.CHANNELColumn;
                dataGridView_Mapping.Rows.Add();
                dataGridView_Mapping.Rows[i].HeaderCell.Value = $"Ch{x + 1:000}-Ch{x + GlobalDefine.CHANNELColumn:000}";
            }
            DataShow();
        }

        public void DataShow()
        {
            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                {
                    int x = j + i * GlobalDefine.CHANNELColumn;
                    int intMapping = GlobalDefine.Mapping[x];
                    dataGridView_Mapping.Rows[i].Cells[j].Value = intMapping / GlobalDefine.CHANNELColumn_MCU * GlobalDefine.CHANNELColumn + intMapping % GlobalDefine.CHANNELColumn_MCU + 1;
                }
            }
            dataGridView_Mapping.ClearSelection();
        }

        public void Power()
        {
            this.Enabled = Program.ClassUser.Power.系统设置;
        }

        private void Button_MappingSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否保存设备通道映射设置？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<int> mapping = new();

                int[] Mapping = new int[GlobalDefine.CHANNELS]; 

                for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
                {
                    for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                    {
                        int Pos = j + i * GlobalDefine.CHANNELColumn;

                        _ = int.TryParse(dataGridView_Mapping.Rows[i].Cells[j].Value.ToString(), out int no);
                        no -= 1;

                        int repeat = mapping.IndexOf(no);
                        if (repeat > -1)
                        {
                            dataGridView_Mapping.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            dataGridView_Mapping.Rows[repeat / GlobalDefine.CHANNELColumn].Cells[repeat % GlobalDefine.CHANNELColumn].Style.BackColor = Color.Red;
                            return;
                        }
                        else
                        {
                            dataGridView_Mapping.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }
                        mapping.Add(no);

                        Mapping[Pos] = no / GlobalDefine.CHANNELColumn * GlobalDefine.CHANNELColumn_MCU + no % GlobalDefine.CHANNELColumn; 
                    }
                }

                GlobalDefine.Mapping = Mapping; 
                GlobalFunction.SetMapping();
                DataShow();
            }
        }

        private void Button_MappingAuto_Click(object sender, EventArgs e)
        {
            _ = int.TryParse(Button_MappingAuto.Tag.ToString(), out int Type);
            switch (Type)
            {
                case 0:
                    for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
                    {
                        for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                        {
                            int Pos = j + i * GlobalDefine.CHANNELColumn + 1;
                            dataGridView_Mapping.Rows[i].Cells[j].Value = Pos;
                        }
                    }
                    Button_MappingAuto.Tag = 1;
                    break;
                case 1:
                    for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
                    {
                        for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                        {
                            int Pos = j + i * GlobalDefine.CHANNELColumn + 1;
                            dataGridView_Mapping.Rows[j].Cells[GlobalDefine.CHANNELRow - i - 1].Value = Pos;
                        }
                    }
                    Button_MappingAuto.Tag = 2;
                    break;
                case 2:
                    for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
                    {
                        for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                        {
                            int Pos = j + i * GlobalDefine.CHANNELColumn + 1;
                            dataGridView_Mapping.Rows[GlobalDefine.CHANNELRow - i - 1].Cells[GlobalDefine.CHANNELColumn - j - 1].Value = Pos;
                        }
                    }
                    Button_MappingAuto.Tag = 3;
                    break;
                case 3:
                    for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
                    {
                        for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                        {
                            int Pos = j + i * GlobalDefine.CHANNELColumn + 1;
                            dataGridView_Mapping.Rows[GlobalDefine.CHANNELColumn - j - 1].Cells[i].Value = Pos;
                        }
                    }
                    Button_MappingAuto.Tag = 4;
                    break;
                case 4:
                    for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
                    {
                        for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                        {
                            int x = GlobalDefine.Mapping[j + i * GlobalDefine.CHANNELColumn];
                            int pos = x / GlobalDefine.CHANNELColumn_MCU * GlobalDefine.CHANNELColumn + x % GlobalDefine.CHANNELColumn_MCU;
                            dataGridView_Mapping.Rows[i].Cells[j].Value = pos + 1;
                        }
                    }
                    Button_MappingAuto.Tag = 0;
                    break;
            }
        }

        private void DataGridView_Mapping_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1 && dataGridView_Mapping.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                _ = int.TryParse(dataGridView_Mapping.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out int x);
                if (!(x > 0 && x <= GlobalDefine.CHANNELS))
                    dataGridView_Mapping.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = GlobalDefine.Mapping[e.RowIndex * GlobalDefine.CHANNELColumn + e.ColumnIndex];
            }
        }

    }
}
