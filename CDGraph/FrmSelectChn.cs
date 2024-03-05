using CDClassLibrary.Stage;
using CDGraph.Language;

namespace CDGraph
{
    public partial class FrmSelectChn : Form
    {
        public void Language()
        {
            button1.Text = ResourceLang.FrmSelectChnbutton1Text;
        }

        bool[] ChaSelect = new bool[GlobalDefine.CHANNELS];
        byte[] ChnState = Array.Empty<byte>();

        public delegate void DelTest(bool[] ChaSelect);

        private DelTest _del;

        public FrmSelectChn()
        {
            InitializeComponent();
        }

        public FrmSelectChn(DelTest del, bool[] ChaSelect, byte[] ChnState)
        {
            InitializeComponent();
            this._del = del;
            this.ChaSelect = ChaSelect;
            this.ChnState = ChnState;
            int DgvWidth = dataGridView1.Width / GlobalDefine.CHANNELColumn;
            dataGridView1.ClearSelection();
            for (int i = 0; i < GlobalDefine.CHANNELColumn; i++)
            {
                dataGridView1.Columns.Add("", "");
                dataGridView1.Columns[i].Width = DgvWidth;
            }

            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                dataGridView1.Rows.Add("", "");
                dataGridView1.Rows[i].Height = DgvWidth;
            }
            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                {
                    int ChnNo = j + i * GlobalDefine.CHANNELColumn;
                    dataGridView1.Rows[i].Cells[j].Value = (ChnNo + 1).ToString();
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = ChaSelect[ChnNo] ? Color.Lime : CellColor(ChnState[ChnNo]);
                }
            }
            Language();
        }

        private static Color CellColor(byte bt)
        {
            var color = bt switch
            {
                0x00 => Color.Cyan,
                0x60 or 0x61 => Color.White,
                _ => Color.Red,
            };
            return color;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _del(ChaSelect);
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            dataGridView1.Rows[0].Cells[0].Selected = true;
            dataGridView1.ClearSelection();
        }

        private void DataGridView1_Leave(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void DataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewCell item in dataGridView1.SelectedCells)
            {
                int RowIndex = item.RowIndex;
                int ColumnIndex = item.ColumnIndex;
                int ChnNo = ColumnIndex + RowIndex * GlobalDefine.CHANNELColumn;
                CellSelect(ChnNo,   ChaSelect[ChnNo]);
            }
            dataGridView1.ClearSelection();
        }

        private void DataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
                {
                    for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                    {
                        int ChnNo = j + i * GlobalDefine.CHANNELColumn;
                        CellSelect(ChnNo, ChaSelect[ChnNo]);
                    }
                }
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                {
                    int ChnNo = j + i * GlobalDefine.CHANNELColumn;
                    if (ChnState[ChnNo] == 0x00)
                        CellSelect(ChnNo, !checkBoxOK电芯.Checked);
                }
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                {
                    int ChnNo = j + i * GlobalDefine.CHANNELColumn;
                    if (ChnState[ChnNo] is 0x00 or 0x60 or 0x61)
                        continue;
                    CellSelect(ChnNo, !checkBoxNG电芯.Checked);
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
            {
                for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                {
                    int ChnNo = j + i * GlobalDefine.CHANNELColumn;
                    if (ChnState[ChnNo] is 0x60 or 0x61)
                    {
                        CellSelect(ChnNo, !checkBox无电芯.Checked);
                    }
                }
            }
        }

        private void CellSelect(int ChnNo, bool boo)
        {
            dataGridView1.Rows[ChnNo / GlobalDefine.CHANNELColumn].Cells[ChnNo % GlobalDefine.CHANNELColumn].Style.BackColor = boo ? CellColor(ChnState[ChnNo]) : Color.Lime;
            ChaSelect[ChnNo] = !boo;
        }

        private void FrmSelectChn_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //e.Cancel = true;
        }
    }
}
