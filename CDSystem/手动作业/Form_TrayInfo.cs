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
using static CDSystem.手动作业.Form_TrayInfo;
using CDSystem.Language;

namespace CDSystem.手动作业
{
    public partial class Form_TrayInfo : Form
    {
        public void Language()
        {
            Button_Save.Text = ResourceLang.Form_TrayInfoButton_SaveText;
            label1.Text = ResourceLang.Form_TrayInfolabel1Text;
            label2.Text = ResourceLang.Form_TrayInfolabel2Text;
            uiButton1.Text = ResourceLang.Form_TrayInfouiButton1Text;
        }

        public delegate void MyDelForm(TTrayInfo TrayInfo);
        readonly MyDelForm _myDelForm;

        public Form_TrayInfo(MyDelForm myDelForm)
        {
            InitializeComponent();


            _myDelForm = myDelForm;
            for (int i = 0; i < GlobalDefine.CHANNELColumn; i++)
            {
                dataGridView_CellSelect.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                dataGridView_CellSelect.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                dataGridView_CellSelect.Rows.Add();
                dataGridView_CellSelect.Rows[i].HeaderCell.Value = $"Ch{i * GlobalDefine.CHANNELColumn + 1:000}~Ch{(i + 1) * GlobalDefine.CHANNELColumn:000}";
            }
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                dataGridView_CellNo.Rows.Add();
                dataGridView_CellNo.Rows[ChnNo].HeaderCell.Value = $"Ch{ChnNo + 1:000}";
                dataGridView_CellSelect.Rows[ChnNo / GlobalDefine.CHANNELColumn].Cells[ChnNo % GlobalDefine.CHANNELColumn].Value = (ChnNo + 1).ToString("000");
            }
            DataShow();
        }

        public void LangSwitch()
        {
            ComponentResourceManager resources = new(this.GetType());

            resources.ApplyResources(this.Button_Save, "Button_Save");
            resources.ApplyResources(this.label1, "label1");
            resources.ApplyResources(this.label2, "label2");
            resources.ApplyResources(this.uiButton1, "uiButton1");
        }

        private void UiButton1_Click(object sender, EventArgs e)
        {
            DataShow();
        }

        public void DataShow()
        {
            textBox_MDL_NAME.Text = GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.MDL_NAME;
            textBox_TRAY_NO.Text = GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.TRAY_NO;
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                dataGridView_CellNo.Rows[ChnNo].Cells[0].Value = GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.CellNumber[ChnNo].ToString();
                Color color;
                if (GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.ChnState[ChnNo] == 0x60 || GlobalParams.GStages[GlobalParams.SelectStage].TrayInfo.ChnState[ChnNo] == 0x61)
                    color = Color.White;
                else
                    color = Color.Lime;
                dataGridView_CellSelect.Rows[ChnNo / GlobalDefine.CHANNELColumn].Cells[ChnNo % GlobalDefine.CHANNELColumn].Style.BackColor = color;
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[GlobalParams.SelectStage].ProcessFlag))
            {
                MessageBox.Show("流程已开始。不能修改托盘信息", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                TTrayInfo TrayInfo = new();
                TrayInfo.FStageNo = GlobalParams.GStages[GlobalParams.SelectStage].FStageNo;
                for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                {
                    if (dataGridView_CellNo.Rows[ChnNo].Cells[0].Value != null)
                    {
                        var str = dataGridView_CellNo.Rows[ChnNo].Cells[0].Value.ToString();
                        if (str != null)
                        {
                            TrayInfo.CellNumber[ChnNo] = str;
                            if (dataGridView_CellSelect.Rows[ChnNo / GlobalDefine.CHANNELColumn].Cells[ChnNo % GlobalDefine.CHANNELColumn].Style.BackColor == Color.White)
                            {
                                TrayInfo.ChnState[ChnNo] = 0x60;
                                TrayInfo.CELL_COUNT--;
                            }
                            else
                                TrayInfo.ChnState[ChnNo] = 0x00;
                        }
                    }
                }
                //MessageBox.Show("托盘信息保存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _myDelForm(TrayInfo);
                this.Close();
            }
        }

        private void DataGridView_CellSelect_Paint(object sender, PaintEventArgs e)
        {
            int width = (dataGridView_CellSelect.Width - 125) / GlobalDefine.CHANNELColumn;
            int height = (dataGridView_CellSelect.Height - 45) / GlobalDefine.CHANNELRow;

            for (int i = 0; i < GlobalDefine.CHANNELColumn; i++)
                dataGridView_CellSelect.Columns[i].Width = width;
            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
                dataGridView_CellSelect.Rows[i].Height = height;
        }

        private void DataGridView_CellSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;//行索引
            int ColumnIndexy = e.ColumnIndex;//列索引


            if (RowIndex >= 0 && ColumnIndexy >= 0)
            {
                int Indexy = RowIndex * GlobalDefine.CHANNELColumn + ColumnIndexy;
                dataGridView_CellNo.ClearSelection();//清除所有选中的单元格
                dataGridView_CellNo.Rows[Indexy].Cells[0].Selected = true;//当前单元格是否选中
                dataGridView_CellNo.FirstDisplayedScrollingRowIndex = Indexy;//选中换行
            }
        }

        private void DataGridView_CellNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;//获取当前单元格的行索引 
            if (RowIndex >= 0)
            {
                dataGridView_CellSelect.ClearSelection();
                dataGridView_CellSelect.Rows[RowIndex / GlobalDefine.CHANNELColumn].Cells[RowIndex % GlobalDefine.CHANNELColumn].Selected = true;
            }
        }

        private void DataGridView_CellSelect_Leave(object sender, EventArgs e)
        {
            dataGridView_CellSelect.ClearSelection();
        }

        private void DataGridView_CellNo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (RowIndex >= 0)
            {
                if (dataGridView_CellNo.Rows[RowIndex].Cells[0].Value == null || dataGridView_CellNo.Rows[RowIndex].Cells[0].Value.ToString() == "")
                {
                    dataGridView_CellNo.Rows[RowIndex].Cells[0].Style.BackColor = Color.White;
                    dataGridView_CellSelect.Rows[RowIndex / GlobalDefine.CHANNELColumn].Cells[RowIndex % GlobalDefine.CHANNELColumn].Style.BackColor = Color.White;
                }
                else
                {
                    dataGridView_CellNo.Rows[RowIndex].Cells[0].Style.BackColor = Color.Lime;
                    dataGridView_CellSelect.Rows[RowIndex / GlobalDefine.CHANNELColumn].Cells[RowIndex % GlobalDefine.CHANNELColumn].Style.BackColor = Color.Lime;
                }
            }
        }

        private void DataGridView_CellSelect_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewCell item in dataGridView_CellSelect.SelectedCells)
            {
                if (item.Style.BackColor == Color.White)
                {
                    item.Style.BackColor = Color.Lime;
                    int RowIndex = item.RowIndex * GlobalDefine.CHANNELColumn + item.ColumnIndex;
                    dataGridView_CellNo.Rows[RowIndex].Cells[0].Style.BackColor = Color.Lime;
                    dataGridView_CellNo.Rows[RowIndex].Cells[0].Value = $"{textBox_TRAY_NO.Text}-{RowIndex + 1:000}";
                }
                else
                {
                    item.Style.BackColor = Color.White;
                    int RowIndex = item.RowIndex * GlobalDefine.CHANNELColumn + item.ColumnIndex;
                    dataGridView_CellNo.Rows[RowIndex].Cells[0].Style.BackColor = Color.White;
                    dataGridView_CellNo.Rows[RowIndex].Cells[0].Value = string.Empty;
                }
            }
            dataGridView_CellSelect.ClearSelection();
        }
    }
}
