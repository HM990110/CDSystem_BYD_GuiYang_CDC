using CDClassLibrary.Stage;
using CDClassLibrary;
using CDSystem.Language;
using CDSystem.手动作业;

namespace CDSystem.系统设置
{
    public partial class UC参数设置 : UserControl
    {
        public void Language()
        {
            buttonAutoFlag.Text = ResourceLang.UC参数设置buttonAutoFlagText;
            ButtonCDC2.Text = ResourceLang.UC参数设置ButtonCDC2Text;
            ButtonCDC3.Text = ResourceLang.UC参数设置ButtonCDC3Text;
            buttonIP.Text = ResourceLang.UC参数设置buttonIPText;
            buttonManualFlag.Text = ResourceLang.UC参数设置buttonManualFlagText;
            buttonVacancy.Text = ResourceLang.UC参数设置buttonVacancyText;
            buttonVacancyNo.Text = ResourceLang.UC参数设置buttonVacancyNoText;
        }

        public UC参数设置()
        {
            InitializeComponent();

            dataGridView_Device.Rows.Add(GlobalDefine.NUM_ALLSTAGES);
            Col机构温度报警值.HeaderCell.Style.BackColor = Color.DeepPink;
            Col电池温度报警值.HeaderCell.Style.BackColor = Color.DeepPink;
            Col水冷Kp比例系数.HeaderCell.Style.BackColor = Color.SkyBlue;
            Col水冷Ki积分系数.HeaderCell.Style.BackColor = Color.SkyBlue;
            Col水冷Kd微分系数.HeaderCell.Style.BackColor = Color.SkyBlue;
            Col水冷调节周期T.HeaderCell.Style.BackColor = Color.SkyBlue;
            Col水冷控制目标温度.HeaderCell.Style.BackColor = Color.SkyBlue;

            DataShow();
        }

        public void Power()
        {
            //this.Enabled = Program.ClassUser.Power.系统设置;
            flowLayoutPanel3.Enabled = Program.ClassUser.Power.系统设置;
            tableLayoutPanel1.Enabled = Program.ClassUser.Power.系统设置;
            dataGridView_Device.ReadOnly = !Program.ClassUser.Power.系统设置;
        }

        public void DataShow()
        {

            NumericUpDown_NOCellchannelVolt.Value = GlobalDefine.NOCellchannelVolt;

            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                dataGridView_Device.Rows[FStageID].Cells["Col设备ID"].Style.BackColor = GlobalDefine.DeviceTypes[FStageID] == TDeviceType.CDC2 ? Color.Orange : Color.LightSkyBlue;

                dataGridView_Device.Rows[FStageID].Cells["Col设备ID"].Value = GlobalParams.GStages[FStageID].FStageNo;
                dataGridView_Device.Rows[FStageID].Cells["ColIP地址"].Value = GlobalDefine.IPs[FStageID];
                dataGridView_Device.Rows[FStageID].Cells["Col设备启用"].Value = GlobalDefine.VacancyFlags[FStageID];
                dataGridView_Device.Rows[FStageID].Cells["Col自动模式"].Value = GlobalDefine.ManualAutoFlags[FStageID];
                dataGridView_Device.Rows[FStageID].Cells["Col设备类型"].Value = GlobalDefine.DeviceTypes[FStageID].ToString();

                dataGridView_Device.Rows[FStageID].Cells["Col机构温度报警值"].Value = GlobalDefine.ParameterLimit.Limits[FStageID].ATempLimit;
                dataGridView_Device.Rows[FStageID].Cells["Col电池温度报警值"].Value = GlobalDefine.ParameterLimit.Limits[FStageID].ACellTempLimit;

                dataGridView_Device.Rows[FStageID].Cells["Col水冷Kp比例系数"].Value = GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKp;
                dataGridView_Device.Rows[FStageID].Cells["Col水冷Ki积分系数"].Value = GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKi;
                dataGridView_Device.Rows[FStageID].Cells["Col水冷Kd微分系数"].Value = GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKd;
                dataGridView_Device.Rows[FStageID].Cells["Col水冷调节周期T"].Value = GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDT;
                dataGridView_Device.Rows[FStageID].Cells["Col水冷控制目标温度"].Value = GlobalDefine.ParameterLimit.Limits[FStageID].WaterTargetTempValue;
            }

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                _ = double.TryParse(dataGridView_Device.Rows[FStageID].Cells["Col水冷Kp比例系数"].Value.ToString(), out var PIDKp);
                GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKp = PIDKp;
                _ = double.TryParse(dataGridView_Device.Rows[FStageID].Cells["Col水冷Ki积分系数"].Value.ToString(), out var PIDKi);
                GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKi = PIDKi;
                _ = double.TryParse(dataGridView_Device.Rows[FStageID].Cells["Col水冷Kd微分系数"].Value.ToString(), out var PIDKd);
                GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKd = PIDKd;
                _ = int.TryParse(dataGridView_Device.Rows[FStageID].Cells["Col水冷调节周期T"].Value.ToString(), out var PIDT);
                GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDT = PIDT;

                _ = int.TryParse(dataGridView_Device.Rows[FStageID].Cells["Col水冷控制目标温度"].Value.ToString(), out var WaterTargetTempValue);
                GlobalDefine.ParameterLimit.Limits[FStageID].WaterTargetTempValue = WaterTargetTempValue;
            }

            Task.Run(() =>
            {
                for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                {
                    if (GlobalParams.GStages[FStageID].VacancyFlag && GlobalParams.CommMCU[FStageID].IsConnected())
                    {
                        GlobalParams.CommMCU[FStageID].WaterPIDControl(GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKp, GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKi, GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKd, GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDT);
                        GlobalParams.CommMCU[FStageID].WaterDoorTarget(GlobalDefine.ParameterLimit.Limits[FStageID].WaterTargetTempValue);
                    }
                }
            });
            GlobalFunction.SetParameterLimit();
            DataShow();
            MessageBox.Show("保存完成!", "完成");
        }

        private void ButtonIP_Click(object sender, EventArgs e)
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                if (!GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[FStageID].ProcessFlag))
                {
                    GlobalDefine.IPs[FStageID] = dataGridView_Device.Rows[FStageID].Cells["ColIP地址"].Value.ToString()!;
                    GlobalDefine.DeviceTypes[FStageID] = dataGridView_Device.Rows[FStageID].Cells["Col设备类型"].Value.ToString() == "CDC2" ? TDeviceType.CDC2 : TDeviceType.CDC3; ;
                    GlobalDefine.VacancyFlags[FStageID] = (bool)dataGridView_Device.Rows[FStageID].Cells["Col设备启用"].Value;
                    GlobalDefine.ManualAutoFlags[FStageID] = (bool)dataGridView_Device.Rows[FStageID].Cells["Col自动模式"].Value;
                    GlobalParams.GStages[FStageID].ThreadStageInfo(FStageID);
                }
            }
            GlobalFunction.SetIP();
            GlobalFunction.SetDeviceType();
            GlobalFunction.SetVacancyFlag();
            GlobalFunction.SetManualAutoFlag();
            DataShow();
            MessageBox.Show("保存成功!", "成功");
        }

        private void ButtonVacancyNo_Click(object sender, EventArgs e)
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                if (!GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[FStageID].ProcessFlag))
                {
                    dataGridView_Device.Rows[FStageID].Cells["Col设备启用"].Value = false;
                    GlobalDefine.VacancyFlags[FStageID] = false;
                    GlobalParams.GStages[FStageID].ThreadStageInfo(FStageID);
                }
            }
            GlobalFunction.SetVacancyFlag();
            DataShow();
            MessageBox.Show("保存成功!", "成功");
        }

        private void ButtonVacancy_Click(object sender, EventArgs e)
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                if (!GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[FStageID].ProcessFlag))
                {
                    dataGridView_Device.Rows[FStageID].Cells["Col设备启用"].Value = true;
                    GlobalDefine.VacancyFlags[FStageID] = true;
                    GlobalParams.GStages[FStageID].ThreadStageInfo(FStageID);
                }
            }
            GlobalFunction.SetVacancyFlag();
            DataShow();
            MessageBox.Show("保存成功!", "成功");
        }

        private void ButtonManualFlag_Click(object sender, EventArgs e)
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                if (!GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[FStageID].ProcessFlag))
                {
                    dataGridView_Device.Rows[FStageID].Cells["Col自动模式"].Value = false;
                    GlobalDefine.ManualAutoFlags[FStageID] = false;
                    GlobalParams.GStages[FStageID].ThreadStageInfo(FStageID);
                }
            }
            GlobalFunction.SetManualAutoFlag();
            DataShow();
            MessageBox.Show("保存成功!", "成功");
        }

        private void ButtonAutoFlag_Click(object sender, EventArgs e)
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                if (!GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[FStageID].ProcessFlag))
                {
                    dataGridView_Device.Rows[FStageID].Cells["Col自动模式"].Value = true;
                    GlobalDefine.ManualAutoFlags[FStageID] = true;
                    GlobalParams.GStages[FStageID].ThreadStageInfo(FStageID);
                }
            }
            GlobalFunction.SetManualAutoFlag();
            DataShow();
            MessageBox.Show("保存成功!", "成功");
        }

        private void ButtonCDC2_Click(object sender, EventArgs e)
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                if (!GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[FStageID].ProcessFlag))
                {
                    dataGridView_Device.Rows[FStageID].Cells["Col设备类型"].Value = TDeviceType.CDC2.ToString();
                    GlobalDefine.DeviceTypes[FStageID] = TDeviceType.CDC2;
                    GlobalParams.GStages[FStageID].ThreadStageInfo(FStageID);
                }
            }
            GlobalFunction.SetDeviceType();
            DataShow();
            MessageBox.Show("保存成功!", "成功");
        }

        private void ButtonCDC3_Click(object sender, EventArgs e)
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                if (!GlobalDefine.ProcessFlagInProc.Contains(GlobalParams.GStages[FStageID].ProcessFlag))
                {
                    dataGridView_Device.Rows[FStageID].Cells["Col设备类型"].Value = TDeviceType.CDC3.ToString();
                    GlobalDefine.DeviceTypes[FStageID] = TDeviceType.CDC3;
                    GlobalParams.GStages[FStageID].ThreadStageInfo(FStageID);
                }
            }
            GlobalFunction.SetDeviceType();
            DataShow();
            MessageBox.Show("保存成功!", "成功");
        }

        private void DataGridView_Device_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex; int ColumnIndex = e.ColumnIndex;
            if (RowIndex >= 0 && ColumnIndex >= 0)
            {
                if (dataGridView_Device.Columns[ColumnIndex].Name == "ColIP地址")
                    new Form_IP(SetIP, dataGridView_Device.Rows[RowIndex].Cells["ColIP地址"].Value.ToString()!, RowIndex).ShowDialog();
            }
        }

        private void SetIP(string IP, int Index)
        {
            dataGridView_Device.Rows[Index].Cells["ColIP地址"].Value = IP;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                _ = int.TryParse(dataGridView_Device.Rows[FStageID].Cells["Col机构温度报警值"].Value.ToString(), out var ATempLimit);
                GlobalDefine.ParameterLimit.Limits[FStageID].ATempLimit = ATempLimit;
                _ = int.TryParse(dataGridView_Device.Rows[FStageID].Cells["Col电池温度报警值"].Value.ToString(), out var ACellTempLimit);
                GlobalDefine.ParameterLimit.Limits[FStageID].ACellTempLimit = ACellTempLimit;
                //_ = int.TryParse(dataGridView_Device.Rows[Index].Cells["ColIP地址"].Value.ToString(), out var ASmogLimit);
                GlobalDefine.ParameterLimit.Limits[FStageID].ASmogLimit = 0;
            }

            Task.Run(() =>
            {
                for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                {
                    if (GlobalParams.GStages[FStageID].VacancyFlag && GlobalParams.CommMCU[FStageID].IsConnected())
                    {
                        GlobalParams.CommMCU[FStageID].SetTempSmogLimitAll(GlobalDefine.ParameterLimit.Limits[FStageID].ATempLimit, GlobalDefine.ParameterLimit.Limits[FStageID].ACellTempLimit, GlobalDefine.ParameterLimit.Limits[FStageID].ASmogLimit);
                    }
                }
            });
            GlobalFunction.SetParameterLimit();
            DataShow();
            MessageBox.Show("保存完成!", "完成");
        }

        private void Button_NOCellchannelVolt_Click(object sender, EventArgs e)
        {
            GlobalDefine.NOCellchannelVolt = (int)NumericUpDown_NOCellchannelVolt.Value;
            if (GlobalFunction.SetNOCellchannelVolt())
                MessageBox.Show("保存成功");
            else
                MessageBox.Show("保存成功");
        }
    }
}
