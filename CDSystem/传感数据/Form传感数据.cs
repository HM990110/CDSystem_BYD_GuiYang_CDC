using CDClassLibrary.Stage;
using CDClassLibrary;
using System.Drawing;
using CDSystem.Language;
using CDSystem.Other;

namespace CDSystem.传感数据
{
    public partial class Form传感数据 : Form
    {
        public void Language()
        {
            ButtonDebug.Text = ResourceLang.Form传感数据ButtonDebugText;
            groupBox1.Text = ResourceLang.Form传感数据groupBox1Text;
            groupBox2.Text = ResourceLang.Form传感数据groupBox2Text;
            groupBox3.Text = ResourceLang.Form传感数据groupBox3Text;
            groupBox4.Text = ResourceLang.Form传感数据groupBox4Text;
            groupBox5.Text = ResourceLang.Form传感数据groupBox5Text;
            labelMCU软件版本号Title.Text = ResourceLang.Form传感数据groupBoxMCU软件版本号Text;
            label电池平均温度值Title.Text = ResourceLang.Form传感数据groupBox电池平均温度值Text;
            label掉电标记Title.Text = ResourceLang.Form传感数据groupBox掉电标记Text;
            label复位按钮信号Title.Text = ResourceLang.Form传感数据groupBox复位按钮信号Text;
            label工装取电状态Title.Text = ResourceLang.Form传感数据groupBox工装取电状态Text;
            label货叉状态Title.Text = ResourceLang.Form传感数据groupBox货叉状态Text;
            label机构传感器报警Title.Text = ResourceLang.Form传感数据groupBox机构传感器报警Text;
            label机构严重故障状态Title.Text = ResourceLang.Form传感数据groupBox机构严重故障状态Text;
            label急停按钮检测Title.Text = ResourceLang.Form传感数据groupBox急停按钮检测Text;
            label流量阀开度状态Title.Text = ResourceLang.Form传感数据groupBox流量阀开度状态Text;
            label门气缸到位检测Title.Text = ResourceLang.Form传感数据groupBox门气缸到位检测Text;
            label逆变器电源状态Title.Text = ResourceLang.Form传感数据groupBox逆变器电源状态Text;
            label平台监控总状态Title.Text = ResourceLang.Form传感数据groupBox平台监控总状态Text;
            label气缸状态Title.Text = ResourceLang.Form传感数据groupBox气缸状态Text;
            label气压状态Title.Text = ResourceLang.Form传感数据groupBox气压状态Text;
            label上针床风机状态Title.Text = ResourceLang.Form传感数据groupBox上针床风机状态Text;
            label水冷风机状态Title.Text = ResourceLang.Form传感数据groupBox水冷风机状态Text;
            label通信状态Title.Text = ResourceLang.Form传感数据groupBox通信状态Text;
            label托盘状态Title.Text = ResourceLang.Form传感数据groupBox托盘状态Text;
            label维修门检测Title.Text = ResourceLang.Form传感数据groupBox维修门检测Text;
            label下位机工作模式Title.Text = ResourceLang.Form传感数据groupBox下位机工作模式Text;
            label下针床风机状态Title.Text = ResourceLang.Form传感数据groupBox下针床风机状态Text;
            label烟道风机状态Title.Text = ResourceLang.Form传感数据groupBox烟道风机状态Text;
            label烟雾状态Title.Text = ResourceLang.Form传感数据groupBox烟雾状态Text;
            label整体机械结构工作状态Title.Text = ResourceLang.Form传感数据groupBox整体机械结构工作状态Text;
            label自动门到位检测Title.Text = ResourceLang.Form传感数据groupBox自动门到位检测Text;

            UserControl设备选中.Language();
        }

        private Other.UserControl设备选中 UserControl设备选中;

        public Form传感数据()
        {
            InitializeComponent();

            UserControl设备选中 = new Other.UserControl设备选中();
            tableLayoutPanel2.Controls.Add(UserControl设备选中, 0, 0);
            UserControl设备选中.BackColor = Color.White;
            UserControl设备选中.Dock = DockStyle.Fill;
            UserControl设备选中.Location = new Point(4, 4);
            UserControl设备选中.Margin = new Padding(4);
            UserControl设备选中.Size = new Size(300, 32); 

            ViewShow机构温度();
            ViewShowCAN通讯错误();
            ViewShow通道温度();
            Power();
        }

        public void Power()
        {
            ButtonDebug.Enabled = Program.ClassUser.Power.传感器调试;
        }

        private void ButtonDebug_Click(object sender, System.EventArgs e)
        {
            new FormDebug().ShowDialog();
        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            DataShow();
        }

        public void RealTimeDataShow()
        {
            timer1.Enabled = true;
            DataShow();
        }

        public void RealTimeDataClose()
        {
            timer1.Enabled = false;
        }

        public void DataShow()
        {
            TEnvData EnvData = GlobalParams.GStages[GlobalParams.SelectStage].EnvData;

            #region
            DataChange通信状态(EnvData.DeviceOnOff);
            DataChange机构严重故障状态(EnvData.SeriousEMGState, EnvData.SeriousEMGStates, EnvData.DeviceOnOff);
            DataChange机构传感器报警(EnvData.SensorEMGAlarm, EnvData.SensorEMGAlarms, EnvData.DeviceOnOff);
            DataChange平台监控总状态(EnvData.DeviceState);
            DataChange整体机械结构工作状态(EnvData.MechanicalWorkSate);
            DataChange下位机工作模式(EnvData.McuWorkState);
            DataChange逆变器电源状态(EnvData.InverterPowerState);
            DataChange掉电标记(EnvData.PowerFailFlag);
            #endregion

            #region
            DataChange托盘状态(EnvData.TrayState, EnvData.TrayStates);
            DataChange气缸状态(EnvData.CylinderStatorState, EnvData.CylinderStatorStates);
            DataChange货叉状态(EnvData.ForkState);
            DataChange气压状态(EnvData.AirPressureState, EnvData.AirPressureStates);
            DataChange自动门到位检测(EnvData.AutoDoorState);
            DataChange维修门检测(EnvData.FireDoorL, EnvData.FireDoorR);
            DataChange门气缸到位检测(EnvData.DoorCylinder);
            DataChange急停按钮检测(EnvData.EmgButtonState);
            DataChange复位按钮信号(EnvData.RESETButton);
            DataChange电池平均温度(EnvData.BatteryAvgTempValue, EnvData.DeviceOnOff);
            DataChange烟雾状态(EnvData.SmogState, EnvData.SmogStates);
            DataChange上针床风机状态(EnvData.FanStates[0], EnvData.FanStates[1], EnvData.FanStates[2], EnvData.FanStates[3]);
            DataChange下针床风机状态(EnvData.FanStates[4], EnvData.FanStates[5], EnvData.FanStates[6], EnvData.FanStates[7]);
            DataChange水冷风机状态(EnvData.FanStates[8], EnvData.FanStates[9], EnvData.FanStates[10], EnvData.FanStates[11], EnvData.FanStates[12], EnvData.FanStates[13]);
            DataChange烟道风机状态(EnvData.FanStates[14]);
            //label_ShieldedFireDoorSensor.Text = EnvData.ShieldedFireDoorSensor.ToString();
            DataChange工装取电状态(EnvData.EtalonPowerState);
            DataChange流量阀开度状态(EnvData.FlowValveOpenValue);
            DataChange应用软件版本号(EnvData.SoftVersion);
            #endregion 

            DataChange机构温度(EnvData.MechanicalTempValue, EnvData.MechanicalTempStates);

            DataChange通道温度();

            DataChangeCAN通讯错误(EnvData.DeviceOnOff, EnvData.CumulativeCANTxRrrorCount, EnvData.CumulativeCANRxRrrorCount);
        }

        public void DataChange通信状态(bool DeviceOnOff)
        {
            Color color = DeviceOnOff ? Color.Yellow : Color.Red;
            string str = DeviceOnOff ? ResourceLang.ProgramConnect : ResourceLang.ProgramDisConnect;
            label通信状态.Text = str;
            panel通信状态.BackColor = color;
        }

        public void DataChange机构严重故障状态(bool SeriousEMGState, List<TSeriousEMGFault> SeriousEMGStates, bool DeviceOnOff)
        {
            Color color = DeviceOnOff ? (SeriousEMGState ? Color.Yellow : Color.Red) : Color.Cyan;
            string str = string.Empty;
            foreach (TSeriousEMGFault item in SeriousEMGStates)
            {
                str += GlobalFunction.GetValue(item) + "\r\n";
            }
            label机构严重故障状态.Text = str;
            panel机构严重故障状态.BackColor = color;
        }

        public void DataChange机构传感器报警(bool SensorEMGAlarm, List<TSensorsEMGFault> SensorEMGAlarms, bool DeviceOnOff)
        {
            Color color = DeviceOnOff ? (SensorEMGAlarm ? Color.Yellow : Color.Red) : Color.Cyan;
            string str = string.Empty;
            foreach (TSensorsEMGFault item in SensorEMGAlarms)
            {
                str += GlobalFunction.GetValue(item) + "\r\n";
            }
            label机构传感器报警.Text = str;
            panel机构传感器报警.BackColor = color;
        }

        public void DataChange平台监控总状态(TDeviceState DeviceState)
        {
            var color = DeviceState switch
            {
                TDeviceState.NO01 => Color.Cyan,
                TDeviceState.efNull => Color.Yellow,
                _ => Color.Red,
            };
            string str = GlobalFunction.GetValue(DeviceState);
            label平台监控总状态.Text = str;
            panel平台监控总状态.BackColor = color;
        }

        public void DataChange整体机械结构工作状态(TMechanicalWorkSate MechanicalWorkSate)
        {
            var color = MechanicalWorkSate switch
            {
                TMechanicalWorkSate.NO01 or TMechanicalWorkSate.Init => Color.Cyan,
                TMechanicalWorkSate.AtWork => Color.Blue,
                TMechanicalWorkSate.Completion => Color.Yellow,
                _ => Color.Red,
            };
            string str = GlobalFunction.GetValue(MechanicalWorkSate);
            label整体机械结构工作状态.Text = str;
            panel整体机械结构工作状态.BackColor = color;
        }

        public void DataChange下位机工作模式(TMcuWorkState McuWorkState)
        {
            var color = McuWorkState switch
            {
                TMcuWorkState.NO01 => Color.Cyan,
                TMcuWorkState.Manual1 or TMcuWorkState.Manual2 => Color.Red,
                TMcuWorkState.Auto1 or TMcuWorkState.Auto2 => Color.Yellow,
                _ => Color.Red,
            };
            string str = GlobalFunction.GetValue(McuWorkState);
            labe下位机工作模式.Text = str;
            panel下位机工作模式.BackColor = color;
        }

        public void DataChange逆变器电源状态(TInverterPowerState InverterPowerState)
        {
            var color = InverterPowerState switch
            {
                TInverterPowerState.NO01 or TInverterPowerState.asAlarm => Color.Cyan,
                TInverterPowerState.asNormal => Color.Yellow,
                _ => Color.Red,
            };
            string str = GlobalFunction.GetValue(InverterPowerState);

            label逆变器电源状态.Text = str;
            panel逆变器电源状态.BackColor = color;
        }

        public void DataChange掉电标记(TPowerFailFlag PowerFailFlag)
        {
            var color = PowerFailFlag switch
            {
                TPowerFailFlag.NO01 or TPowerFailFlag.pfInit => Color.Cyan,
                TPowerFailFlag.pfNormal => Color.Yellow,
                TPowerFailFlag.pfNormalStop => Color.Blue,
                _ => Color.Red,
            };
            string str = GlobalFunction.GetValue(PowerFailFlag);
            label掉电标记.Text = str;
            panel掉电标记.BackColor = color;
        }


        #region  传感器状态
        public void DataChange托盘状态(TTrayState TrayState, TSensorStates[] TrayStates)
        {
            Color color;
            string str = string.Empty;
            switch (TrayState)
            {
                case TTrayState.NO01:
                case TTrayState.dsUndock:
                    color = Color.Cyan;
                    str = GlobalFunction.GetValue(TrayState);
                    break;
                case TTrayState.dsDock:
                    color = Color.Yellow;
                    str = GlobalFunction.GetValue(TrayState);
                    break;
                case TTrayState.dsDockError:
                    color = Color.Red;
                    str += "传1:" + GlobalFunction.GetValue(TrayStates[0]) + "；";
                    str += "传2:" + GlobalFunction.GetValue(TrayStates[1]) + "；\r\n";
                    str += "传3:" + GlobalFunction.GetValue(TrayStates[2]) + "；";
                    str += "角1:" + GlobalFunction.GetValue(TrayStates[3]) + "；";
                    break;
                default:
                    color = Color.Red;
                    str = GlobalFunction.GetValue(TrayState);
                    break;
            }
            label托盘状态.Text = str;
            panel托盘状态.BackColor = color;
        }

        public void DataChange气缸状态(TCylinderStatorState CylinderStatorState, TSensorStates[] CylinderStatorStates)
        {
            Color color;
            string str = string.Empty;
            switch (CylinderStatorState)
            {
                case TCylinderStatorState.NO01:
                    color = Color.Cyan;
                    str = GlobalFunction.GetValue(CylinderStatorState);
                    break;
                case TCylinderStatorState.dsUndock:
                    color = Color.Blue;
                    str = GlobalFunction.GetValue(CylinderStatorState);
                    break;
                case TCylinderStatorState.dsDock:
                    color = Color.Yellow;
                    str = GlobalFunction.GetValue(CylinderStatorState);
                    break;
                case TCylinderStatorState.dsRunning:
                    color = Color.Red;
                    str += "零1:" + GlobalFunction.GetValue(CylinderStatorStates[0]) + "；";
                    str += "到1:" + GlobalFunction.GetValue(CylinderStatorStates[1]) + "；\r\n";
                    str += "零2:" + GlobalFunction.GetValue(CylinderStatorStates[2]) + "；";
                    str += "到2:" + GlobalFunction.GetValue(CylinderStatorStates[3]) + "；";
                    break;
                default:
                    color = Color.Red;
                    str = GlobalFunction.GetValue(CylinderStatorState);
                    break;
            }
            label气缸状态.Text = str;
            panel气缸状态.BackColor = color;
        }

        public void DataChange货叉状态(TForkState ForkState)
        {
            string str = GlobalFunction.GetValue(ForkState);
            var color = ForkState switch
            {
                TForkState.NO01 => Color.Cyan,
                TForkState.fsUndock => Color.Yellow,
                TForkState.fsDock => Color.Red,
                _ => Color.Red,
            };
            label货叉状态.Text = str;
            panel货叉状态.BackColor = color;
        }

        public void DataChange气压状态(TAirPressureState AirPressureState, TSensorStates[] AirPressureStates)
        {
            Color color;
            string str = string.Empty;
            switch (AirPressureState)
            {
                case TAirPressureState.NO01:
                    color = Color.Cyan;
                    str = GlobalFunction.GetValue(AirPressureState);
                    break;
                case TAirPressureState.asNormal:
                    color = Color.Yellow;
                    str = GlobalFunction.GetValue(AirPressureState);
                    break;
                case TAirPressureState.asError:
                    color = Color.Red;
                    str += "上:" + GlobalFunction.GetValue(AirPressureStates[0]) + "；";
                    str += "下:" + GlobalFunction.GetValue(AirPressureStates[1]) + "；";
                    break;
                default:
                    color = Color.Red;
                    str = GlobalFunction.GetValue(AirPressureState);
                    break;
            }
            label气压状态.Text = str;
            panel气压状态.BackColor = color;
        }

        public void DataChange自动门到位检测(TDoorState AutoDoorState)
        {
            Color color;
            color = AutoDoorState switch
            {
                TDoorState.NO01 => Color.Cyan,
                TDoorState.dsDock => Color.Yellow,
                TDoorState.dsNull => Color.Red,
                _ => Color.Red,
            };

            string str = GlobalFunction.GetValue(AutoDoorState);

            label自动门到位检测.Text = str;
            panel自动门到位检测.BackColor = color;
        }

        public void DataChange维修门检测(TDoorState FireDoorL, TDoorState FireDoorR)
        {
            Color color;
            string str = string.Empty;
            if (FireDoorL == FireDoorR)
            {
                str = GlobalFunction.GetValue(FireDoorL);
                color = FireDoorL switch
                {
                    TDoorState.NO01 => Color.Cyan,
                    TDoorState.dsDock => Color.Yellow,
                    TDoorState.dsNull => Color.Red,
                    _ => Color.Red,
                };
            }
            else
            {
                color = Color.Red;
                str += "左1:" + GlobalFunction.GetValue(FireDoorL) + "；";
                str += "右1:" + GlobalFunction.GetValue(FireDoorR) + "；";
            }
            label维修门检测.Text = str;
            panel维修门检测.BackColor = color;
        }

        public void DataChange门气缸到位检测(TDoorState DoorCylinder)
        {
            Color color;
            string str = GlobalFunction.GetValue(DoorCylinder);
            color = DoorCylinder switch
            {
                TDoorState.NO01 => Color.Cyan,
                TDoorState.dsDock => Color.Yellow,
                TDoorState.dsNull => Color.Red,
                _ => Color.Red,
            };
            label门气缸到位检测.Text = str;
            panel门气缸到位检测.BackColor = color;
        }

        public void DataChange急停按钮检测(TEmgButtonState EmgButtonState)
        {
            string str = GlobalFunction.GetValue(EmgButtonState);
            var color = EmgButtonState switch
            {
                TEmgButtonState.NO01 => Color.Cyan,
                TEmgButtonState.esNull => Color.Yellow,
                TEmgButtonState.esEMG => Color.Red,
                _ => Color.Red,
            };
            label急停按钮检测.Text = str;
            panel急停按钮检测.BackColor = color;
        }

        public void DataChange复位按钮信号(TRESETButtonStates RESETButton)
        {
            string str = GlobalFunction.GetValue(RESETButton);
            var color = RESETButton switch
            {
                TRESETButtonStates.NO01 => Color.Cyan,
                TRESETButtonStates.esNull => Color.Yellow,
                TRESETButtonStates.esRESET => Color.Red,
                _ => Color.Red,
            };
            label复位按钮信号.Text = str;
            panel复位按钮信号.BackColor = color;
        }

        public void DataChange烟雾状态(TSmogState SmogState, TSmogState[] SmogStates)
        {
            Color color;
            string str = string.Empty;
            switch (SmogState)
            {
                case TSmogState.NO01:
                    color = Color.Cyan;
                    str = GlobalFunction.GetValue(SmogState);
                    break;
                case TSmogState.asNormal:
                    color = Color.Yellow;
                    str = GlobalFunction.GetValue(SmogState);
                    break;
                case TSmogState.asAlarm:
                case TSmogState.asInitError:
                    color = Color.Red;
                    str += "烟雾1:" + GlobalFunction.GetValue(SmogStates[0]) + "；";
                    str += "烟雾1:" + GlobalFunction.GetValue(SmogStates[1]) + "；";
                    break;
                default:
                    color = Color.Red;
                    str = GlobalFunction.GetValue(SmogState);
                    break;
            }
            label烟雾状态.Text = str;
            panel烟雾状态.BackColor = color;
        }

        public void DataChange上针床风机状态(TFanState FanState0, TFanState FanState1, TFanState FanState2, TFanState FanState3)
        {
            TFanState fanState;
            string Str; Color color;
            if (FanState0 == TFanState.fsStop && FanState1 == TFanState.fsStop && FanState2 == TFanState.fsStop && FanState3 == TFanState.fsStop)
            {
                fanState = TFanState.fsStop;
                Str = GlobalFunction.GetValue(fanState);
                color = Color.Blue;
            }
            else if (FanState0 == TFanState.fsRun && FanState1 == TFanState.fsRun && FanState2 == TFanState.fsRun && FanState3 == TFanState.fsRun)
            {
                fanState = TFanState.fsRun;
                Str = GlobalFunction.GetValue(fanState);
                color = Color.Yellow;
            }
            else if (FanState0 == TFanState.NO01 && FanState1 == TFanState.NO01 && FanState2 == TFanState.NO01 && FanState3 == TFanState.NO01)
            {
                fanState = TFanState.NO01;
                Str = GlobalFunction.GetValue(fanState);
                color = Color.Cyan;
            }
            else
            {
                Str =
                    $"F1：{GlobalFunction.GetValue(FanState0)}；" +
                    $"F2：{GlobalFunction.GetValue(FanState1)}；\r\n" +
                    $"F3：{GlobalFunction.GetValue(FanState2)}；" +
                    $"F4：{GlobalFunction.GetValue(FanState3)}；";
                color = Color.Red;
            }
            label上针床风机状态.Text = Str;
            panel上针床风机状态.BackColor = color;
        }

        public void DataChange下针床风机状态(TFanState FanState4, TFanState FanState5, TFanState FanState6, TFanState FanState7)
        {
            TFanState fanState;
            string Str; Color color;
            if (FanState4 == TFanState.fsStop && FanState5 == TFanState.fsStop && FanState6 == TFanState.fsStop && FanState7 == TFanState.fsStop)
            {
                fanState = TFanState.fsStop;
                Str = GlobalFunction.GetValue(fanState);
                color = Color.Blue;
            }
            else if (FanState4 == TFanState.fsRun && FanState5 == TFanState.fsRun && FanState6 == TFanState.fsRun && FanState7 == TFanState.fsRun)
            {
                fanState = TFanState.fsRun;
                Str = GlobalFunction.GetValue(fanState);
                color = Color.Yellow;
            }
            else if (FanState4 == TFanState.NO01 && FanState5 == TFanState.NO01 && FanState6 == TFanState.NO01 && FanState7 == TFanState.NO01)
            {
                fanState = TFanState.NO01;
                Str = GlobalFunction.GetValue(fanState);
                color = Color.Cyan;
            }
            else
            {
                Str =
                    $"F1：{GlobalFunction.GetValue(FanState4)}；" +
                    $"F2：{GlobalFunction.GetValue(FanState5)}；\r\n" +
                    $"F3：{GlobalFunction.GetValue(FanState6)}；" +
                    $"F4：{GlobalFunction.GetValue(FanState7)}；";
                color = Color.Red;
            }
            label下针床风机状态.Text = Str;
            panel下针床风机状态.BackColor = color;
        }

        public void DataChange水冷风机状态(TFanState FanState8, TFanState FanState9, TFanState FanState10, TFanState FanState11, TFanState FanState12, TFanState FanState13)
        {
            TFanState fanState;
            string Str; Color color;
            if (FanState8 == TFanState.fsStop && FanState9 == TFanState.fsStop && FanState10 == TFanState.fsStop &&
                FanState11 == TFanState.fsStop && FanState12 == TFanState.fsStop && FanState13 == TFanState.fsStop)
            {
                fanState = TFanState.fsStop;
                Str = GlobalFunction.GetValue(fanState);
                color = Color.Blue;
            }
            else if (FanState8 == TFanState.fsRun && FanState9 == TFanState.fsRun && FanState10 == TFanState.fsRun &&
                FanState11 == TFanState.fsRun && FanState12 == TFanState.fsRun && FanState13 == TFanState.fsRun)
            {
                fanState = TFanState.fsRun;
                Str = GlobalFunction.GetValue(fanState);
                color = Color.Yellow;
            }
            else if (FanState8 == TFanState.NO01 && FanState9 == TFanState.NO01 && FanState10 == TFanState.NO01 &&
                FanState11 == TFanState.NO01 && FanState12 == TFanState.NO01 && FanState13 == TFanState.NO01)
            {
                fanState = TFanState.NO01;
                Str = GlobalFunction.GetValue(fanState);
                color = Color.Cyan;
            }
            else
            {
                Str =
                    $"F1：{GlobalFunction.GetValue(FanState8)}；" +
                    $"F2：{GlobalFunction.GetValue(FanState9)}；" +
                    $"F3：{GlobalFunction.GetValue(FanState10)}；" +
                    $"F4：{GlobalFunction.GetValue(FanState11)}；" +
                    $"F5：{GlobalFunction.GetValue(FanState12)}；" +
                    $"F6：{GlobalFunction.GetValue(FanState13)}；";
                color = Color.Red;
            }
            label水冷风机状态.Text = Str;
            panel水冷风机状态.BackColor = color;
        }

        public void DataChange烟道风机状态(TFanState FanState14)
        {
            string Str; Color color;
            switch (FanState14)
            {
                case TFanState.fsStop:
                    Str = GlobalFunction.GetValue(FanState14);
                    color = Color.Blue;
                    break;
                case TFanState.fsRun:
                    Str = GlobalFunction.GetValue(FanState14);
                    color = Color.Yellow;
                    break;
                case TFanState.NO01:
                    Str = GlobalFunction.GetValue(FanState14);
                    color = Color.Cyan;
                    break;
                default:
                    Str = GlobalFunction.GetValue(FanState14);
                    color = Color.Red;
                    break;
            }
            label烟道风机状态.Text = Str;
            panel烟道风机状态.BackColor = color;
        }

        public void DataChange电池平均温度(double BatteryAvgTempValue, bool DeviceOnOff)
        {
            double Temp = BatteryAvgTempValue;
            Color color = DeviceOnOff ? (Temp > 10 && Temp < 80 ? Color.Yellow : Color.Red) : Color.Cyan;
            label电池平均温度值.Text = Temp.ToString();
            panel电池平均温度值.BackColor = color;
        }

        public void DataChange应用软件版本号(byte SoftVersion)
        {
            labelMCU软件版本号.Text = SoftVersion.ToString();
            panelMCU软件版本号.BackColor = Color.Cyan;
        }

        public void DataChange工装取电状态(TEtalonPowerState EtalonPowerState)
        {
            string str = GlobalFunction.GetValue(EtalonPowerState);
            var color = EtalonPowerState switch
            {
                TEtalonPowerState.NO01 or TEtalonPowerState.WithOutput => Color.Cyan,
                TEtalonPowerState.NoOutput => Color.Yellow,
                _ => Color.Red,
            };
            label工装取电状态.Text = str;
            panel工装取电状态.BackColor = color;
        }

        public void DataChange流量阀开度状态(double FlowValveOpenValue)
        {
            Color color = FlowValveOpenValue > 0 ? Color.Yellow : Color.Cyan;
            string str = FlowValveOpenValue.ToString("F2");
            label流量阀开度状态.Text = str;
            panel流量阀开度状态.BackColor = color;
        }
        #endregion

        #region 机构温度 
        readonly (Panel Panel, Label Label)[] UC传感器_机构温度s = new (Panel Panel, Label Label)[8];

        private void ViewShow机构温度()
        {
            int ColumnCount = 8;
            int RowCount = 1;

            tableLayoutPanel_机构温度.ColumnStyles.Clear();
            tableLayoutPanel_机构温度.ColumnCount = ColumnCount + 1;
            for (int i = 0; i < ColumnCount; i++)
                tableLayoutPanel_机构温度.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_机构温度.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            tableLayoutPanel_机构温度.RowStyles.Clear();
            tableLayoutPanel_机构温度.RowCount = RowCount + 1;
            for (int i = 0; i < RowCount; i++)
                tableLayoutPanel_机构温度.RowStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_机构温度.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));

            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    int ID = i * ColumnCount + j;
                    UC传感器_机构温度s[ID].Panel = new Panel()
                    {
                        Dock = DockStyle.Fill,
                        BorderStyle = BorderStyle.FixedSingle,
                    };

                    UC传感器_机构温度s[ID].Label = new Label()
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };
                    UC传感器_机构温度s[ID].Panel.Controls.Add(UC传感器_机构温度s[ID].Label);

                    Label label = new()
                    {
                        AutoSize = true,
                        Dock = DockStyle.Top,
                        Text = (ID + 1).ToString(),
                    };
                    UC传感器_机构温度s[ID].Panel.Controls.Add(label);

                    tableLayoutPanel_机构温度.Controls.Add(UC传感器_机构温度s[ID].Panel, j, i);
                }
            }
        }

        public void DataChange机构温度(double[] MechanicalTempValue, TTempState[] MechanicalTempStates)
        {
            for (int i = 0; i < MechanicalTempStates.Length; i++)
            {
                var color = MechanicalTempStates[i] switch
                {
                    TTempState.NO01 or TTempState.asInitError => Color.Cyan,
                    TTempState.asNormal => Color.Yellow,
                    TTempState.asAlarm => Color.Red,
                    _ => Color.Red,
                };
                UC传感器_机构温度s[i].Label.Text = (MechanicalTempValue[i]).ToString("F2");
                UC传感器_机构温度s[i].Panel.BackColor = color;
            }
        }
        #endregion

        #region CAN通讯错误
        readonly (Panel Panel, Label Label)[] UC传感器_CAN通讯错误s = new (Panel Panel, Label Label)[GlobalDefine.CHANNELRow];

        private void ViewShowCAN通讯错误()
        {
            int ColumnCount = GlobalDefine.CHANNELRow / 2;
            int RowCount = 2;

            tableLayoutPanel_CAN通讯错误.ColumnStyles.Clear();
            tableLayoutPanel_CAN通讯错误.ColumnCount = ColumnCount + 1;
            for (int i = 0; i < ColumnCount; i++)
                tableLayoutPanel_CAN通讯错误.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_CAN通讯错误.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            tableLayoutPanel_CAN通讯错误.RowStyles.Clear();
            tableLayoutPanel_CAN通讯错误.RowCount = RowCount + 1;
            for (int i = 0; i < RowCount; i++)
                tableLayoutPanel_CAN通讯错误.RowStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_CAN通讯错误.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));

            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    int ID = i * ColumnCount + j;
                    UC传感器_CAN通讯错误s[ID].Panel = new Panel()
                    {
                        Dock = DockStyle.Fill,
                        BorderStyle = BorderStyle.FixedSingle,
                    };

                    UC传感器_CAN通讯错误s[ID].Label = new Label()
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };
                    UC传感器_CAN通讯错误s[ID].Panel.Controls.Add(UC传感器_CAN通讯错误s[ID].Label);

                    Label label = new()
                    {
                        AutoSize = true,
                        Dock = DockStyle.Top,
                        Text = (ID + 1).ToString(),
                    };
                    UC传感器_CAN通讯错误s[ID].Panel.Controls.Add(label);

                    tableLayoutPanel_CAN通讯错误.Controls.Add(UC传感器_CAN通讯错误s[ID].Panel, j, i);
                }
            }
        }

        public void DataChangeCAN通讯错误(bool DeviceOnOff, int[] CumulativeCANTxRrrorCount, int[] CumulativeCANRxRrrorCount)
        {
            for (int i = 0; i < 14; i++)
            {
                Color color = DeviceOnOff ? ((CumulativeCANTxRrrorCount[i] > 0 || CumulativeCANRxRrrorCount[i] > 0) ? Color.Red : Color.Yellow) : Color.Cyan;
                UC传感器_CAN通讯错误s[i].Label.Text = $"{CumulativeCANTxRrrorCount[i]};{CumulativeCANRxRrrorCount[i]}";
                UC传感器_CAN通讯错误s[i].Panel.BackColor = color;
            }
        }
        #endregion

        #region 通道温度
        readonly (Panel Panel, Label Label)[] UC传感器_通道温度s = new (Panel Panel, Label Label)[GlobalDefine.CHANNELS];

        private void ViewShow通道温度()
        {
            int ColumnCount = GlobalDefine.CHANNELColumn;
            int RowCount = GlobalDefine.CHANNELRow;

            tableLayoutPanel_通道温度.ColumnStyles.Clear();
            tableLayoutPanel_通道温度.ColumnCount = ColumnCount + 1;
            for (int i = 0; i < ColumnCount; i++)
                tableLayoutPanel_通道温度.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_通道温度.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            tableLayoutPanel_通道温度.RowStyles.Clear();
            tableLayoutPanel_通道温度.RowCount = RowCount + 1;
            for (int i = 0; i < RowCount; i++)
                tableLayoutPanel_通道温度.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_通道温度.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    int ID = i * ColumnCount + j;
                    UC传感器_通道温度s[ID].Panel = new Panel()
                    {
                        Dock = DockStyle.Fill,
                        BorderStyle = BorderStyle.FixedSingle,
                    };

                    UC传感器_通道温度s[ID].Label = new Label()
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };
                    UC传感器_通道温度s[ID].Panel.Controls.Add(UC传感器_通道温度s[ID].Label);

                    Label label = new()
                    {
                        AutoSize = true,
                        Dock = DockStyle.Top,
                        Text = (ID + 1).ToString(),
                    };
                    UC传感器_通道温度s[ID].Panel.Controls.Add(label);

                    tableLayoutPanel_通道温度.Controls.Add(UC传感器_通道温度s[ID].Panel, j, i);
                }
            }
        }

        public void DataChange通道温度()
        {
            TRealTimeData RealTimeData = GlobalParams.GStages[GlobalParams.SelectStage].RealTimeData;
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
            {
                UC传感器_通道温度s[ChnNo].Label.Text = (RealTimeData.ChannelRealTimeData[ChnNo].ChannelTemp).ToString("F2");
                UC传感器_通道温度s[ChnNo].Panel.BackColor = Color.Cyan;
            }
        }
        #endregion

        private void Label逆变器电源状态_Click(object sender, EventArgs e)
        {
            new Form逆变器信息().ShowDialog();
        }
    }
}
