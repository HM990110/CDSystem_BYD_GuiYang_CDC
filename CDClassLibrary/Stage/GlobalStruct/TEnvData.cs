using System.ComponentModel;
using System.Runtime.InteropServices;

namespace CDClassLibrary.Stage
{
    /// <summary>
    /// 应用层上传数据（0xB103）
    /// 操控版状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct TEnvDataMCU
    {
        readonly int Pos;
        readonly int dataLength;

        /// <summary>
        /// Pos：0   机构严重故障状态
        /// </summary>
        public Int32 SeriousEMGState;//bit byte
        /// <summary>
        /// Pos：4   机构传感器报警
        /// </summary>
        public Int32 SensorEMGAlarm;
        /// <summary>
        /// Pos：8   平台状态      
        /// </summary>
        public byte DeviceState;
        /// <summary>
        /// Pos：9   机构工作状态
        /// </summary>
        public byte MechanicalWorkSate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public byte[] NullBytes1;                      //预留 
        /// <summary>
        /// Pos：20   逆变器电源状态
        /// </summary>
        public byte InverterPowerState;
        /// <summary>
        /// Pos：21   急停按钮检测
        /// </summary>
        public byte EmgButtonState;
        /// <summary>
        /// Pos：22   托盘状态
        /// </summary>
        public byte TrayState;
        /// <summary>
        /// Pos：23   气缸状态
        /// </summary>
        public byte CylinderStatorState;
        /// <summary>
        /// Pos：24   气压状态
        /// </summary>
        public byte AirPressureState;
        /// <summary>
        /// Pos：25   布幕状态
        /// </summary>
        [Obsolete] public byte CurtainState;
        /// <summary>
        /// Pos：26   屏蔽传感器检测的状态回读
        /// </summary>
        public Int32 ShieldedSensor;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] NullBytes2;                      //预留 
        /// <summary>
        /// Pos：50   4 个机构温度值，有符号，*100，单位度
        /// </summary> 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public Int16[] MechanicalTempValue;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] NullBytes3;                      //预留  
        /// <summary>
        /// Pos：70   下位机工作模式
        /// </summary>
        public byte McuWorkState;
        /// <summary>
        /// Pos：71   应用软件版本号
        /// </summary>
        public byte SoftVersion;
        /// <summary>
        /// Pos：72   掉电标记
        /// </summary>
        public byte PowerFailFlag;
        /// <summary>
        /// Pos：73   授权到期标记
        /// </summary>
        public byte Softexpires;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] NullBytes4;                      //预留  
        /// <summary>
        /// Pos：80   电池温度值
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 75)]
        [Obsolete] public Int16[] CellTempValue;
        /// <summary>
        /// Pos：230   烟雾浓度值
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public Int16[] SmogValue;
        /// <summary>
        /// Pos: 234    负压目标值 P 
        /// </summary>
        public Int16 NegatPreTargetValueP;
        /// <summary>
        /// Pos: 236    比例阀开度值
        /// </summary>
        public Int16 ValveOpenValue;
        /// <summary>
        /// Pos: 238    电池平均温度值
        /// </summary>
        public Int16 BatteryAvgTempValue;
        /// <summary>
        /// Pos：240   机构温度传感器状态 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] MechanicalTempState;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] NullBytes6;                      //预留
        /// <summary>
        /// Pos：250   电池温度传感器状态
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 75)]
        [Obsolete] public byte[] CellTempState;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public byte[] NullBytes7;                      //预留
        /// <summary>
        /// Pos：330   烟雾传感器状态
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] SmogState;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] NullBytes8;                      //预留
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] NullBytes9;                      //预留
        /// <summary>
        /// Pos：336   目标温度值   有符号，*100，范围-12800~+12800，单位度
        /// </summary>
        public Int16 TargetTempValue;
        /// <summary>
        /// Pos：338   流量阀开度值
        /// </summary>
        public Int16 FlowValveOpenValue;
        /// <summary>
        /// Pos：340   真空数显表值*100 单位KPa
        /// </summary>
        public Int16 VacuumValue;
        /// <summary>
        /// Pos：342   真空数显表状态
        /// </summary>
        public Int16 VacuumState;
        /// <summary>
        /// Pos：344   测堵工作状态
        /// </summary>
        public byte PluggingState;
        /// <summary>
        /// Pos：345   保压工作状态
        /// </summary>
        public byte MaintPreState;
        /// <summary>
        /// Pos：346   三色灯状态
        /// </summary>
        [Obsolete] public byte LightState;
        /// <summary>
        /// Pos：347   工装取电状态
        /// </summary>
        public byte EtalonPowerState;
        /// <summary>
        /// Pos：348   保压漏率值*100 单位KPa/min
        /// </summary>
        public UInt16 PressureValue;
        /// <summary>
        /// Pos：350   负压工作状态
        /// </summary>
        public byte NegatPreState;
        /// <summary>
        /// Pos：351   流量阀开度检测状态
        /// </summary>
        public byte FlowValveState;
        /// <summary>
        /// Pos：352   Kp 比例系数
        /// </summary>
        public Int16 CoefficientKp;
        /// <summary>
        /// Pos：354   Ki 积分系数
        /// </summary>
        public Int16 CoefficientKi;
        /// <summary>
        /// Pos：356   Kd 微分系数
        /// </summary>
        public Int16 CoefficientKd;
        /// <summary>
        /// Pos：358   调节周期 T
        /// </summary>
        public Int16 AdjustingCycleT;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public byte[] NullBytes10;                      //预留 
        /// <summary>
        /// <para> Pos：370   输入传感器状态 </para>
        /// <para> 0:托盘传感器 1: 0 无效，1 有效 1 </para>
        /// <para> 1:托盘传感器 2: 0 无效，1 有效 1 </para>
        /// <para> 2:托盘传感器 3: 0 无效，1 有效 1 </para>
        /// <para> 3:托盘缺角检测: 0 无效，1 有效 1 </para>
        /// <para> 4:气缸零位传感器 1: 0 无效，1 有效 1 </para>
        /// <para> 5:气缸到位传感器 1: 0 无效，1 有效 1 </para>
        /// <para> 6:气缸零位传感器 2: 0 无效，1 有效 1 </para>
        /// <para> 7:气缸到位传感器 2: 0 无效，1 有效 1 </para>
        /// <para> 8:急停检测: 0 无效，1 有效 1 </para>
        /// <para> 9:复位按钮信号: 0 无效，1 有效 1 </para>
        /// <para> 10:烟感信号 1: 0 无效，1 有效 1 </para>
        /// <para> 11:烟感信号 2: 0 无效，1 有效 1 </para>
        /// <para> 12:气压上限检测: 0 无效，1 有效 1 </para>
        /// <para> 13:气压下限检测: 0 无效，1 有效 1 </para>
        /// <para> [Obsolete]14:自动门上到位检测: 0 无效，1 有效 1 </para>
        /// <para> 15:自动门下到位检测: 0 无效，1 有效 1 </para>
        /// <para> 16:水冷阀检测：0 无效，1 有效 1 </para>
        /// <para> 17:门气缸到位检测：0 无效，1 有效 1 </para>
        /// <para> [Obsolete]18:货叉传感器检测: 0 无效，1 有效 1 </para>
        /// <para> [Obsolete]19:自动旋钮状态: 0 无效，1 有效 1 </para>
        /// <para> [Obsolete]20:启动按钮状态: 0 无效，1 有效 1 </para>
        /// <para> [Obsolete]21:气缸上升按钮: 0 无效，1 有效 1 </para>
        /// <para> [Obsolete]22:气缸下降按钮: 0 无效，1 有效 1 </para>
        /// <para> [Obsolete]23:驱动箱上电信号: 0 断电，1 上电 1 </para>
        /// <para> [Obsolete]24:左幕布伸出位: 0 无效，1 有效 1 </para>
        /// <para> [Obsolete]25:右幕布伸出位: 0 无效，1 有效 1 </para>
        /// <para> [Obsolete]26:左幕布收回位: 0 无效，1 有效 1 </para>
        /// <para> [Obsolete]27:右幕布收回位: 0 无效，1 有效 1 </para>
        /// 保留 2 </para>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public byte[] InputSensorsMCU;
        /// <summary>
        /// Pos：400   机构温度报警值
        /// </summary>  
        public Int16 MechanicalTempAlarmValue;
        /// <summary>
        /// Pos：402   电池温度报警值
        /// </summary>  
        public Int16 BatteryTempAlarmValue;
        /// <summary>
        /// Pos：404   烟雾报警值
        /// </summary>  
        public Int16 SmogAlarmValue;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] NullBytes11;                      //预留 
        /// <summary>
        /// Pos：410   机构温度补偿值 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public Int16[] MechanicalTempFixValue;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] NullBytes12;                      //预留 
        /// <summary>
        /// Pos：430   电池温度补偿值 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 75)]
        [Obsolete] public Int16[] CellTempFixValue;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public byte[] NullBytes13;                      //预留 
        /// <summary>
        /// Pos：590   真空数显表补偿值
        /// </summary>
        public Int16 VacuumFixValue;
        /// <summary>
        /// Pos：592   风机状态
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
        public byte[] FanState;
        /// <summary>
        /// Pos：672   洛伦兹逆变器信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public TInverterDataLorentzMCU[] InverterDataLorentzMCU;
        /// <summary>
        /// Pos：870   CAN 通讯累计发送错误次数
        /// 预留 16 个单片机，按实际使用单片机数量显示。无符号整型，单位次数
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Int32[] CumulativeCANTxRrrorCount;
        /// <summary>
        /// Pos：934   CAN 通讯累计接收错误次数
        /// 预留 16 个单片机，按实际使用单片机数量显示。无符号整型，单位次数
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Int32[] CumulativeCANRxRrrorCount;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
        public byte[] NullBytes14;                      //预留

        public TEnvDataMCU()
        {
            Pos = 0;
            dataLength = 0;
            SeriousEMGState = 0;
            SensorEMGAlarm = 0;
            DeviceState = 0;
            MechanicalWorkSate = 0;
            InverterPowerState = 0;
            EmgButtonState = 0;
            TrayState = 0;
            CylinderStatorState = 0;
            AirPressureState = 0;
            CurtainState = 0;
            MechanicalTempValue = new Int16[8];
            for (int i = 0; i < 8; i++)
                MechanicalTempValue[i] = 0;
            McuWorkState = 0;
            SoftVersion = 0;
            PowerFailFlag = 0;
            Softexpires = 0;
            CellTempValue = new Int16[75];
            for (int i = 0; i < 75; i++)
                CellTempValue[i] = 0;
            SmogValue = new Int16[2];
            for (int i = 0; i < 2; i++)
                SmogValue[i] = 0;
            NegatPreTargetValueP = 0;
            ValveOpenValue = 0;
            BatteryAvgTempValue = 0;
            MechanicalTempState = new byte[8];
            for (int i = 0; i < 8; i++)
                MechanicalTempState[i] = 0;
            CellTempState = new byte[75];
            for (int i = 0; i < 75; i++)
                CellTempState[i] = 0;
            SmogState = new byte[2];
            for (int i = 0; i < 2; i++)
                SmogState[i] = 0;
            TargetTempValue = 0;
            FlowValveOpenValue = 0;
            VacuumValue = 0;
            VacuumState = 0;
            PluggingState = 0;
            MaintPreState = 0;
            LightState = 0;
            EtalonPowerState = 0;
            PressureValue = 0;
            NegatPreState = 0;
            FlowValveState = 0;
            CoefficientKp = 0;
            CoefficientKi = 0;
            CoefficientKd = 0;
            AdjustingCycleT = 0;
            ShieldedSensor = 0;

            InputSensorsMCU = new byte[30];
            for (int i = 0; i < 30; i++)
                InputSensorsMCU[i] = 0;
            MechanicalTempAlarmValue = 0;
            BatteryTempAlarmValue = 0;
            SmogAlarmValue = 0;
            MechanicalTempFixValue = new Int16[6];
            for (int i = 0; i < 6; i++)
                MechanicalTempFixValue[i] = 0;
            CellTempFixValue = new Int16[75];
            for (int i = 0; i < 75; i++)
                CellTempFixValue[i] = 0;
            VacuumFixValue = 0;
            FanState = new byte[80];
            for (int i = 0; i < 80; i++)
                FanState[i] = 0;
            InverterDataLorentzMCU = new TInverterDataLorentzMCU[3];
            for (int i = 0; i < 3; i++)
                InverterDataLorentzMCU[i] = new TInverterDataLorentzMCU();
            CumulativeCANTxRrrorCount = new Int32[16];
            for (int i = 0; i < 16; i++)
                CumulativeCANTxRrrorCount[i] = 0;
            CumulativeCANRxRrrorCount = new Int32[16];
            for (int i = 0; i < 16; i++)
                CumulativeCANRxRrrorCount[i] = 0;

            NullBytes1 = new byte[10];
            NullBytes2 = new byte[24];
            NullBytes3 = new byte[4];
            NullBytes4 = new byte[6];
            NullBytes6 = new byte[2];
            NullBytes7 = new byte[5];
            NullBytes8 = new byte[2];
            NullBytes9 = new byte[2];
            NullBytes10 = new byte[10];
            NullBytes11 = new byte[4];
            NullBytes12 = new byte[8];
            NullBytes13 = new byte[10];
            NullBytes14 = new byte[26];
        }
    }

    /// <summary>
    /// 洛伦兹逆变器信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct TInverterDataLorentzMCU
    {
        /// <summary>
        /// 前级 AC 电压*10 ab
        /// </summary>
        public Int16 AC_Vab;
        /// <summary>
        /// 前级 AC 电压*10 bc
        /// </summary>
        public Int16 AC_Vbc;
        /// <summary>
        /// 前级 AC 电压*10 ca
        /// </summary>
        public Int16 AC_Vca;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] NullBytes1;                   //预留
        /// <summary>
        /// 软件版本号
        /// </summary>
        public UInt16 SoftwareVersion;
        /// <summary>
        /// 软件版本号ID
        /// </summary>
        public UInt32 SoftwareVersionID;
        /// <summary>
        /// 硬件版本号
        /// </summary>
        public UInt16 HardwareVersion;
        /// <summary>
        /// 硬件版本号ID
        /// </summary>
        public UInt32 HardwareVersionID;
        /// <summary>
        /// 日期年
        /// </summary>
        public UInt16 DateYVersion;
        /// <summary>
        /// 日期月
        /// </summary>
        public byte DateMVersion;
        /// <summary>
        /// 日期日
        /// </summary>
        public byte DateDVersion;
        /// <summary>
        /// 前级温度 *10
        /// </summary>
        public Int16 PreAmpTemp;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] NullBytes2;                   //预留
        /// <summary>
        /// 后级输出电流 1 *10
        /// </summary>
        public Int16 Amp_C1;
        /// <summary>
        /// //后级输出电流 2 *10
        /// </summary>
        public Int16 Amp_C2;
        /// <summary>
        /// 后级 DC 电压输 出 *10,单位 mV
        /// </summary>
        public UInt16 AmpDC_V;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] NullBytes3;                   //预留
        /// <summary>
        /// 后级环境温度 *10
        /// </summary>
        public Int16 AmpTemp;
        /// <summary>
        /// 设备告警
        /// </summary>
        public UInt32 InverterAlarm;
        /// <summary>
        /// 状态
        /// </summary>
        public Int16 InverterState;
        /// <summary>
        /// 通信状态
        /// </summary>
        public byte ComState;
        /// <summary>
        /// 数据有效标记
        /// </summary>
        public Int16 DataValidflag;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] NullBytes4;                      //预留
        public TInverterDataLorentzMCU()
        {
            AC_Vab = 0;
            AC_Vbc = 0;
            AC_Vca = 0;
            SoftwareVersion = 0;
            SoftwareVersionID = 0;
            HardwareVersion = 0;
            HardwareVersionID = 0;
            DateYVersion = 0;
            DateMVersion = 0;
            DateDVersion = 0;
            PreAmpTemp = 0;
            Amp_C1 = 0;
            Amp_C2 = 0;
            AmpDC_V = 0;
            AmpTemp = 0;
            InverterAlarm = 0;
            InverterState = 0;
            ComState = 0;
            DataValidflag = 0;
            NullBytes1 = new byte[12];                   //预留
            NullBytes2 = new byte[8];                   //预留
            NullBytes3 = new byte[4];                   //预留
            NullBytes4 = new byte[1];
        }
    }

    /// <summary>
    /// 图为逆变器信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct TInverterDataTwowinMCU
    {
        /// <summary>
        /// DC 电压*10
        /// </summary>
        public Int16 DC_V;
        /// <summary>
        /// DC 电流*10
        /// </summary>
        public Int16 DC_I;
        /// <summary>
        /// AC 电压*10 a
        /// </summary>
        public UInt16 AC_Va;
        /// <summary>
        /// AC 电压*10 b
        /// </summary>
        public UInt16 AC_Vb;
        /// <summary>
        /// AC 电压*10 c
        /// </summary>
        public UInt16 AC_Vc;
        /// <summary>
        /// AC 频率*10
        /// </summary>
        public UInt16 AC_Rate;
        /// <summary>
        /// 状态 1
        /// </summary>
        public byte InverterState;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] NullBytes; //预留
        /// <summary>
        /// 通信状态
        /// </summary>
        public TComState ComState;
        /// <summary>
        /// 环境温度*10
        /// </summary>
        public Int16 EnvTemp;
        /// <summary>
        /// 散热器温度*10
        /// </summary>
        public Int16 CoolTemp;
        /// <summary>
        /// 程序 V 版本号
        /// </summary>
        public Int16 ProgramV;
        /// <summary>
        /// 程序 A 版本号
        /// </summary>
        public Int16 ProgramA;
        /// <summary>
        /// 三相并机交流有效值和*100 a
        /// </summary>
        public Int16 TriPhaseValue_a;
        /// <summary>
        /// 三相并机交流有效值和*100 b
        /// </summary>
        public Int16 TriPhaseValue_b;
        /// <summary>
        /// 三相并机交流有效值和*100 c
        /// </summary>
        public Int16 TriPhaseValue_c;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] NullBytes2; //预留

        public TInverterDataTwowinMCU()
        {
            DC_V = 0;
            DC_I = 0;
            AC_Va = 0;
            AC_Vb = 0;
            AC_Vc = 0;
            AC_Rate = 0;
            InverterState = 0;
            ComState = 0;
            EnvTemp = 0;
            CoolTemp = 0;
            ProgramV = 0;
            ProgramA = 0;
            TriPhaseValue_a = 0;
            TriPhaseValue_b = 0;
            TriPhaseValue_c = 0;
            NullBytes = new byte[1]; //预留
            NullBytes2 = new byte[1]; //预留
        }
    }

    /// <summary>
    /// 操控版状态
    /// </summary>
    [Serializable]
    public class TEnvData
    {
        public bool DeviceOnOff = false;

        /// <summary> 
        /// 应用软件版本号
        /// </summary>
        public byte SoftVersion = 0;
        /// <summary> 
        /// 授权到期标记
        /// </summary>
        public byte Softexpires = 0;

        /// <summary>
        /// 机构严重故障状态
        /// </summary>
        public bool SeriousEMGState = true;
        public List<TSeriousEMGFault> SeriousEMGStates = new();
        /// <summary>
        /// 机构传感器报警
        /// </summary>
        public bool SensorEMGAlarm = true;
        public List<TSensorsEMGFault> SensorEMGAlarms = new();

        /// <summary>
        /// 平台监控总状态      
        /// </summary>
        public TDeviceState DeviceState = TDeviceState.NO01;
        /// <summary>
        /// 整体机械结构工作状态
        /// </summary>
        public TMechanicalWorkSate MechanicalWorkSate = TMechanicalWorkSate.NO01;
        /// <summary>
        /// 下位机工作模式
        /// </summary>
        public TMcuWorkState McuWorkState = TMcuWorkState.NO01;
        /// <summary>
        /// 逆变器电源状态
        /// </summary>
        public TInverterPowerState InverterPowerState = TInverterPowerState.NO01;
        /// <summary>
        /// 掉电标记
        /// </summary>
        public TPowerFailFlag PowerFailFlag = TPowerFailFlag.NO01;

        /// <summary>
        /// 急停按钮检测
        /// </summary>
        public TEmgButtonState EmgButtonState = TEmgButtonState.NO01;
        /// <summary> 
        /// 复位按钮信号
        /// </summary>
        public TRESETButtonStates RESETButton = TRESETButtonStates.NO01;

        /// <summary>
        /// 托盘状态
        /// </summary>
        public TTrayState TrayState = TTrayState.NO01;
        /// <summary>
        /// 0.托盘传感器 1: 0 无效，1 有效
        /// 1.托盘传感器 2: 0 无效，1 有效
        /// 2.托盘传感器 3: 0 无效，1 有效
        /// 3.托盘缺角检测: 0 无效，1 有效
        /// </summary>
        public TSensorStates[] TrayStates = new TSensorStates[4];
        /// <summary>
        /// 气缸状态
        /// </summary>
        public TCylinderStatorState CylinderStatorState = TCylinderStatorState.NO01;
        /// <summary>
        /// 0.气缸零位传感器 1: 0 无效，1 有效
        /// 1.气缸到位传感器 1: 0 无效，1 有效
        /// 2.气缸零位传感器 2: 0 无效，1 有效
        /// 3.气缸到位传感器 2: 0 无效，1 有效
        /// </summary>
        public TSensorStates[] CylinderStatorStates = new TSensorStates[4];

        /// <summary>
        /// 气压状态
        /// </summary>
        public TAirPressureState AirPressureState = TAirPressureState.NO01;
        /// <summary>
        /// 0.气压上限检测 1: 0 无效，1 有效
        /// 1.气压下限检测 1: 0 无效，1 有效 
        /// </summary>
        public TSensorStates[] AirPressureStates = new TSensorStates[2];

        /// <summary>
        /// 自动门下到位检测
        /// </summary>
        public TDoorState AutoDoorState = TDoorState.NO01;
        /// <summary>
        /// 水冷阀检测
        /// </summary>
        public TDoorState WaterCooledValve = TDoorState.NO01;
        /// <summary>
        /// 门气缸到位检测
        /// </summary>
        public TDoorState DoorCylinder = TDoorState.NO01;
        /// <summary>
        /// 左维修门检测
        /// </summary>
        public TDoorState FireDoorL = TDoorState.NO01;
        /// <summary>
        /// 右维修门检测
        /// </summary>
        public TDoorState FireDoorR = TDoorState.NO01;

        /// <summary>
        /// 货叉传感器
        /// </summary>
        public TForkState ForkState = TForkState.NO01;

        /// <summary>
        /// 风机状态
        /// 1-4 上针床风机
        /// 5-8 下针床风机
        /// 9-14 水冷风机
        /// 15 烟道风机
        /// </summary>
        public TFanState[] FanStates = new TFanState[80];

        /// <summary>
        /// 机构温度传感器状态 
        /// </summary> 
        public TTempState MechanicalTempState = TTempState.NO01;
        /// <summary>
        /// 机构温度传感器状态 
        /// </summary> 
        public TTempState[] MechanicalTempStates = new TTempState[8];
        /// <summary>
        /// 机构温度值 *100
        /// </summary>  
        public double[] MechanicalTempValue = new double[8];
        /// <summary>
        /// 机构温度报警值 *100
        /// </summary>  
        public double MechanicalTempAlarmValue = 0;

        /// <summary>
        /// 烟雾传感器状态
        /// </summary> 
        public TSmogState SmogState = TSmogState.NO01;
        /// <summary>
        /// 烟雾传感器状态
        /// </summary> 
        public TSmogState[] SmogStates = new TSmogState[2];

        /// <summary>
        /// 电池平均温度值 *100
        /// </summary>
        public double BatteryAvgTempValue = 0;
        /// <summary>
        /// 目标温度值 *100
        /// </summary>
        public double TargetTempValue = 0;
        /// <summary> 
        /// 电池温度报警值 *100
        /// </summary>  
        public double BatteryTempAlarmValue = 0;

        /// <summary>
        /// Kp 比例系数 *100
        /// </summary>
        public double CoefficientKp = 0;
        /// <summary>
        /// Ki 积分系数 *100
        /// </summary>
        public double CoefficientKi = 0;
        /// <summary>
        /// Kd 微分系数 *100
        /// </summary>
        public double CoefficientKd = 0;
        /// <summary>
        /// 调节周期 T
        /// </summary>
        public int AdjustingCycleT = 0;

        /// <summary>
        /// 工装取电状态
        /// </summary>
        public TEtalonPowerState EtalonPowerState = TEtalonPowerState.NO01;

        /// <summary>
        /// 洛伦兹逆变器信息
        /// </summary> 
        public TInverterDataLorentz[] InverterDataLorentz = new TInverterDataLorentz[3];

        /// <summary>
        /// 比例阀开度值 *100
        /// </summary>
        public double ValveOpenValue = 0;
        /// <summary>
        /// 流量阀开度值 *100
        /// </summary>
        public double FlowValveOpenValue = 0;
        /// <summary>
        /// 流量阀开度检测状态
        /// </summary>
        public TFlowValveState FlowValveState = TFlowValveState.NO01;

        //屏蔽传感器检测的状态回读
        /*
        //上位机可以通过这个状态知道下位机处于哪种屏蔽状态
        /// <summary>
        /// Bit0：1 屏蔽缺角传感器检测,0 不屏蔽
        /// </summary>
        [Obsolete] public bool ShieldedTraySensor;

        /// <summary>
        /// Bit1：1 屏蔽抱紧气缸传感器,0 不屏蔽
        /// </summary>
        [Obsolete] public bool ShieldedCylinderSensor;
        */

        /// <summary>
        /// Bit2：1 屏蔽维修门传感器,0 不屏蔽 
        /// </summary>
        public bool ShieldedFireDoorSensor;

        /// <summary>
        /// CAN 通讯累计发送错误次数
        /// </summary> 
        public int[] CumulativeCANTxRrrorCount = new int[14];
        /// <summary>
        /// CAN 通讯累计接收错误次数 
        /// </summary> 
        public int[] CumulativeCANRxRrrorCount = new int[14];

        public TEnvData()
        {
            for (int i = 0; i < TrayStates.Length; i++)
                TrayStates[i] = TSensorStates.Null;
            for (int i = 0; i < CylinderStatorStates.Length; i++)
                CylinderStatorStates[i] = TSensorStates.Null;
            for (int i = 0; i < AirPressureStates.Length; i++)
                AirPressureStates[i] = TSensorStates.Null;
            for (int i = 0; i < FanStates.Length; i++)
                FanStates[i] = TFanState.NO01;
            for (int i = 0; i < MechanicalTempStates.Length; i++)
                MechanicalTempStates[i] = TTempState.NO01;
            for (int i = 0; i < MechanicalTempValue.Length; i++)
                MechanicalTempValue[i] = 0;
            for (int i = 0; i < SmogStates.Length; i++)
                SmogStates[i] = TSmogState.NO01;
            for (int i = 0; i < InverterDataLorentz.Length; i++)
                InverterDataLorentz[i] = new TInverterDataLorentz();
            for (int i = 0; i < CumulativeCANTxRrrorCount.Length; i++)
                CumulativeCANTxRrrorCount[i] = 0;
            for (int i = 0; i < CumulativeCANRxRrrorCount.Length; i++)
                CumulativeCANRxRrrorCount[i] = 0;
        }
    }

    /// <summary>
    /// 洛伦兹逆变器信息
    /// </summary> 
    [Serializable]
    public class TInverterDataLorentz
    {
        /// <summary>
        /// 前级 AC 电压 ab *10
        /// </summary>
        public double AC_Vab = 0;
        /// <summary>
        /// 前级 AC 电压 bc *10
        /// </summary>
        public double AC_Vbc = 0;
        /// <summary>
        /// 前级 AC 电压 ca *10
        /// </summary>
        public double AC_Vca = 0;
        /// <summary>
        /// 软件版本号
        /// </summary>
        public int SoftwareVersion = 0;
        /// <summary>
        /// 软件版本号ID
        /// </summary>
        public int SoftwareVersionID = 0;
        /// <summary>
        /// 硬件版本号
        /// </summary>
        public int HardwareVersion = 0;
        /// <summary>
        /// 硬件版本号ID
        /// </summary>
        public int HardwareVersionID = 0;
        /// <summary>
        /// 日期年
        /// </summary>
        public int DateYVersion = 0;
        /// <summary>
        /// 日期月
        /// </summary>
        public byte DateMVersion = 0;
        /// <summary>
        /// 日期日
        /// </summary>
        public byte DateDVersion = 0;
        /// <summary>
        /// 前级温度  *10
        /// </summary>
        public double PreAmpTemp = 0;
        /// <summary>
        /// 后级输出电流 1 *10
        /// </summary>
        public double Amp_C1 = 0;
        /// <summary>
        /// 后级输出电流 2 *10
        /// </summary>
        public double Amp_C2 = 0;
        /// <summary>
        /// 后级 DC 电压输出,单位 mA *10
        /// </summary>
        public double AmpDC_V = 0;
        /// <summary>
        /// 后级环境温度 *10
        /// </summary>
        public double AmpTemp = 0;
        /// <summary>
        /// 设备告警
        /// </summary>
        public TInverterAlarm InverterAlarm = new(0);
        /// <summary>
        /// 状态
        /// </summary>
        public TInverterStateLorentz InverterState = new(0);
        /// <summary>
        /// 通信状态
        /// </summary>
        public TComState ComState = TComState.Null;
        /// <summary>
        /// 数据有效标记
        /// </summary>
        public int DataValidflag = 0;
    }

    /// <summary>
    /// 设备告警
    /// </summary>
    [Serializable]
    public class TInverterAlarm
    {
        public bool 前级输出欠压;    //bit2:
        public bool 前级输出过压;    //bit3:
        public bool 前级过温故障;    //bit10:
        public bool 前级风扇异常;    //bit11:
        public bool 后级故障;        //bit15:
        public bool 后级输出欠压;    //bit18:
        public bool 后级输出过压;    //bit19:
        public bool 后级过温故障;    //bit23:
        public bool 后级风扇异常;    //bit24:

        public TInverterAlarm(UInt32 Value)
        {
            bool[] boolTInverterAlarm = TStructConvert.IntTobit((int)Value);

            前级输出欠压 = boolTInverterAlarm[2];//bit2:
            前级输出过压 = boolTInverterAlarm[3];// bit3:
            前级过温故障 = boolTInverterAlarm[10];// bit10:
            前级风扇异常 = boolTInverterAlarm[11];//bit11:
            后级故障 = boolTInverterAlarm[15];//bit15:
            后级输出欠压 = boolTInverterAlarm[18];//bit18:
            后级输出过压 = boolTInverterAlarm[19];//bit19:
            后级过温故障 = boolTInverterAlarm[23];//bit23:
            后级风扇异常 = boolTInverterAlarm[24];//Bit24: 
        }
    }
    /// <summary>
    /// 状态
    /// </summary>
    [Serializable]
    public class TInverterStateLorentz
    {
        /// <summary>
        /// 前级状态 bit0~2
        /// </summary>
        public State FrontState;
        /// <summary>
        /// 前级开关机状态 bit3
        /// </summary>
        public SwitchOnOffState FrontSwitchOnOffState;
        /// <summary>
        /// 前级工作状态 bit5~7
        /// </summary>
        public WorkState FrontWorkState;
        /// <summary>
        /// 后级状态 bit8~10
        /// </summary>
        public State AfterState;
        /// <summary>
        /// 后级开关机状态 bit11
        /// </summary>
        public SwitchOnOffState AfterSwitchOnOffState;
        /// <summary>
        /// 后级工作状态 bit13~15
        /// </summary>
        public WorkState AfterWorkState;

        public TInverterStateLorentz(Int16 Value)
        {
            string str2 = Convert.ToString(Value, 2).PadLeft(32, '0');
            string str = "";
            for (int i = 0; i < 32; i++)
            {
                str += str2[31 - i];
            }

            switch (str[..3])
            {
                case "000": FrontState = State.待机; break;
                case "001": FrontState = State.故障; break;
                case "010": FrontState = State.运行; break;
            }
            FrontSwitchOnOffState = str[3] == '0' ? SwitchOnOffState.关机 : SwitchOnOffState.开机;
            switch (str.Substring(5, 3))
            {
                case "000": FrontWorkState = WorkState.初始; break;
                case "001": FrontWorkState = WorkState.预充; break;
                case "010": FrontWorkState = WorkState.等待; break;
                case "011": FrontWorkState = WorkState.故障; break;
                case "100": FrontWorkState = WorkState.软起状态; break;
                case "101": FrontWorkState = WorkState.正常状态; break;
            }

            switch (str.Substring(8, 3))
            {
                case "000": AfterState = State.待机; break;
                case "001": AfterState = State.故障; break;
                case "010": AfterState = State.运行; break;
            }
            AfterSwitchOnOffState = str[11] == '0' ? SwitchOnOffState.关机 : SwitchOnOffState.开机;
            switch (str.Substring(13, 3))
            {
                case "000": AfterWorkState = WorkState.初始; break;
                case "001": AfterWorkState = WorkState.预充; break;
                case "010": AfterWorkState = WorkState.等待; break;
                case "011": AfterWorkState = WorkState.故障; break;
                case "100": AfterWorkState = WorkState.软起状态; break;
                case "101": AfterWorkState = WorkState.正常状态; break;
            }
        }

        public enum State { 待机 = 0, 故障 = 1, 运行 = 2 }

        public enum SwitchOnOffState { 关机 = 0, 开机 = 1 }

        public enum WorkState { 初始 = 0, 预充 = 1, 等待 = 2, 故障 = 3, 软起状态 = 4, 正常状态 = 5 }
    }

    /// <summary>
    /// 图为逆变器信息
    /// </summary> 
    [Serializable]
    public class TInverterDataTwowin
    {
        /// <summary>
        /// DC 电压
        /// </summary>
        public double DC_V = 0;
        /// <summary>
        /// DC 电流
        /// </summary>
        public double DC_I = 0;
        /// <summary>
        /// AC 电压 a
        /// </summary>
        public double AC_Va = 0;
        /// <summary>
        /// AC 电压 b
        /// </summary>
        public double AC_Vb = 0;
        /// <summary>
        /// AC 电压 c
        /// </summary>
        public double AC_Vc = 0;
        /// <summary>
        /// AC 频率
        /// </summary>
        public double AC_Rate = 0;
        /// <summary>
        /// 状态 1
        /// </summary>
        public TInverterStateTwowin InverterState = 0;
        /// <summary>
        /// 通信状态
        /// </summary>
        public TComState ComState = TComState.Null;
        /// <summary>
        /// 环境温度
        /// </summary>
        public double EnvTemp = 0;
        /// <summary>
        /// 散热器温度
        /// </summary>
        public double CoolTemp = 0;
        /// <summary>
        /// 程序 V 版本号
        /// </summary>
        public Int16 ProgramV = 0;
        /// <summary>
        /// 程序 A 版本号
        /// </summary>
        public Int16 ProgramA = 0;
        /// <summary>
        /// 三相并机交流有效值和 a
        /// </summary>
        public double TriPhaseValue_a = 0;
        /// <summary>
        /// 三相并机交流有效值和 b
        /// </summary>
        public double TriPhaseValue_b = 0;
        /// <summary>
        /// 三相并机交流有效值和 c
        /// </summary>
        public double TriPhaseValue_c = 0;
    }

    /// <summary>
    /// 每个 bit 表示一种故障，0 无故障，1 有
    /// 故障；
    /// Bit0：机构部温度报警
    /// Bit1：电池温度报警
    /// Bit2：烟雾报警
    /// Bit3：CO 报警
    /// Bit4：气压报警
    /// Bit5：机构风机报警
    /// Bit6：按钮急停报警
    /// Bit7：PC 命令急停
    /// Bit8：PC 报警
    /// Bit9：逆变器报警
    /// Bit10：保压报警
    /// Bit11：负压报警
    /// Bit12：测堵报警
    /// Bit13：电源部断电报警
    /// Bit14：消防报警（PLC 给机笼）
    /// </summary>
    public enum TSeriousEMGFault : byte
    {
        /// <summary>
        /// 机构部温度报警
        /// </summary>
        [Description("TSeriousEMGFault_efTemp")]
        efTemp = 0,
        /// <summary>
        /// 电池温度报警
        /// </summary>
        [Description("TSeriousEMGFault_efBoardTemp")]
        efBoardTemp = 1,
        /// <summary>
        /// 烟雾报警
        /// </summary>
        [Description("TSeriousEMGFault_efSmog")]
        efSmog = 2,
        /// <summary>
        /// CO报警
        /// </summary>
        [Description("TSeriousEMGFault_efCO")]
        [Obsolete] efCO = 3,
        /// <summary>
        /// 气压报警
        /// </summary>
        [Description("TSeriousEMGFault_efAir")]
        efAir = 4,
        /// <summary>
        /// 机构风机报警
        /// </summary>
        [Description("TSeriousEMGFault_efFan")]
        efFan = 5,
        /// <summary>
        /// 按钮急停报警
        /// </summary>
        [Description("TSeriousEMGFault_efManual")]
        efManual = 6,
        /// <summary>
        /// PC命令急停
        /// </summary>
        [Description("TSeriousEMGFault_efManualPC")]
        efManualPC = 7,
        /// <summary>
        /// PC报警
        /// </summary>
        [Description("TSeriousEMGFault_efFromPC")]
        efFromPC = 8,
        /// <summary>
        /// 逆变器报警
        /// </summary>
        [Description("TSeriousEMGFault_efInverter")]
        efInverter = 9,
        /// <summary>
        /// 保压报警
        /// </summary>
        [Description("TSeriousEMGFault_efMaintPreState")]
        efMaintPreState = 10,
        /// <summary>
        /// 负压报警
        /// </summary>
        [Description("TSeriousEMGFault_efNegatPreState")]
        efNegatPreState = 11,
        /// <summary>
        /// 测堵报警
        /// </summary>
        [Description("TSeriousEMGFault_efPluggingState")]
        efPluggingState = 12,
        /// <summary>
        /// 电源部断电报警
        /// </summary>
        [Description("TSeriousEMGFault_efPowerSupply")]
        [Obsolete] efPowerSupply = 13,
        /// <summary>
        /// 消防报警（PLC 给机笼）
        /// </summary>
        [Description("TSeriousEMGFault_efFireControl")]
        [Obsolete] efFireControl = 14,
    };

    /// <summary>
    /// 机构传感器报警
    /// 每个 bit 表示一种传感器，0 无报警，1 有报警；
    /// Bit0：托盘传感器 1 报警；
    /// Bit1：托盘传感器 2 报警；
    /// Bit2：气缸零位报警；
    /// Bit3：气缸到位报警；
    /// Bit4：布幕伸出报警
    /// Bit5：布幕收回报警
    /// Bit6：托盘缺角传感器报警；
    /// Bit7：货叉传感器报警；
    /// Bit8：自动门传感器报警；
    /// Bit9：顶部风机报警；
    /// Bit10：中框风机报警；
    /// Bit11：维修侧风机报警；
    /// </summary>
    public enum TSensorsEMGFault : byte
    {
        /// <summary>
        /// 托盘传感器 1 报警
        /// </summary>
        [Description("TSensorsEMGFault_efTray1Error")]
        efTray1Error = 0,
        /// <summary>
        /// 托盘传感器 2 报警
        /// </summary>
        [Description("TSensorsEMGFault_efTray2Error")]
        efTray2Error = 1,
        /// <summary>
        /// 气缸零位报警
        /// </summary>
        [Description("TSensorsEMGFault_efProbeUpError")]
        efProbeUpError = 2,
        /// <summary>
        /// 气缸到位报警
        /// </summary>
        [Description("TSensorsEMGFault_efProbeDownError")]
        efProbeDownError = 3,
        /// <summary>
        /// 布幕伸出报警
        /// </summary>
        [Description("TSensorsEMGFault_efExtendError")]
        [Obsolete] efExtendError = 4,
        /// <summary>
        /// 布幕收回报警
        /// </summary>
        [Description("TSensorsEMGFault_efWithdrawalError")]
        [Obsolete] efWithdrawalError = 5,
        /// <summary>
        /// 托盘缺角传感器报警
        /// </summary>
        [Description("TSensorsEMGFault_efTrayAngleError")]
        efTrayAngleError = 6,
        /// <summary>
        /// 货叉传感器报警
        /// </summary>
        [Description("TSensorsEMGFault_sfFock")]
        sfFock = 7,
        /// <summary>
        /// 自动门传感器报警
        /// </summary>
        [Description("TSensorsEMGFault_efAutoDoorError")]
        efAutoDoorError = 8,
        /// <summary>
        /// 顶部风机报警
        /// </summary>
        [Description("TSensorsEMGFault_efTopFanError")]
        efTopFanError = 9,
        /// <summary>
        /// 中框风机报警
        /// </summary>
        [Description("TSensorsEMGFault_efCentreFanError")]
        efCentreFanError = 10,
        /// <summary>
        /// 维修侧风机报警
        /// </summary>
        [Description("TSensorsEMGFault_efSideFanError")]
        efSideFanError = 11,
        /// <summary>
        /// 排烟风机报警
        /// </summary>
        [Description("TSensorsEMGFault_efSmokeExhaustFanError")]
        efSmokeExhaustFanError = 12,
        /// <summary>
        /// 流量阀开度报警
        /// </summary>
        [Description("TSensorsEMGFault_efFlowValveError")]
        efFlowValveError = 13,
        /// <summary>
        /// 水冷风机报警
        /// </summary>
        [Description("TSensorsEMGFault_efWaterFanError")]
        efWaterFanError = 14,
        /// <summary>
        /// 安全门报警
        /// </summary>
        [Description("TSensorsEMGFault_efFireDoorError")]
        efFireDoorError = 15,
    };

    /// <summary>
    /// 平台监控总状态      
    /// 0x55.平台健康
    /// 0x66.通道有保护
    /// 0x77.一般故障流程可以工作
    /// 0x88.故障流程不能工作
    /// 0xAA.平台有故障,具体故障码通过平台报警读取命令获取
    /// </summary>
    public enum TDeviceState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 平台健康
        /// </summary>
        [Description("TDeviceState_efNull")]
        efNull = 0x55,
        /// <summary>
        /// 通道有保护
        /// </summary>
        [Description("TDeviceState_protecte")]
        [Obsolete] protecte = 0x66,
        /// <summary>
        /// 一般故障流程可以工作
        /// </summary>
        [Description("TDeviceState_ProCanWorkError")]
        [Obsolete] ProCanWorkError = 0x77,
        /// <summary>
        /// 故障流程不能工作
        /// </summary>
        [Description("TDeviceState_ProCannotWorkError")]
        [Obsolete] ProCannotWorkError = 0x88,
        /// <summary>
        /// 平台有故障,具体故障码通过平台报警读取命令获取
        /// </summary>
        [Description("TDeviceState_ErrorOther")]
        ErrorOther = 0xAA,
    };

    /// <summary>
    /// 整体机械结构工作状态
    /// 0x00：初始化状态(只在第一次上电后)
    /// 0x01：机构在执行流程动作中（收到上位机下发的启动或停止命令）
    /// 0x10：机构动作正常完成
    /// 0x11：机构动作执行超时（异常）
    /// </summary>
    public enum TMechanicalWorkSate : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 初始化状态(只在第一次上电后)
        /// </summary>
        [Description("TMechanicalWorkSate_Init")]
        Init = 0x00,
        /// <summary>
        /// 机构在执行流程动作中（收到上位机下发的启动或停止命令）
        /// </summary>
        [Description("TMechanicalWorkSate_AtWork")]
        AtWork = 0x01,
        /// <summary>
        /// 机构动作正常完成
        /// </summary>
        [Description("TMechanicalWorkSate_Completion")]
        Completion = 0x10,
        /// <summary>
        /// 机构动作执行超时（异常）
        /// </summary>
        [Description("TMechanicalWorkSate_Timeout")]
        Timeout = 0x11
    };

    /// <summary>
    /// 逆变器电源状态
    /// 0.电源关闭
    /// 1.电源开启
    /// 2.电源错误
    /// </summary>
    public enum TInverterPowerState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 电源关闭
        /// </summary>
        [Description("TInverterPowerState_asAlarm")]
        asAlarm = 0,
        /// <summary>
        /// 电源开启
        /// </summary>
        [Description("TInverterPowerState_asNormal")]
        asNormal = 1,
        /// <summary>
        /// 电源错误
        /// </summary>
        [Description("TInverterPowerState_asInitError")]
        asInitError = 2,
    }

    /// <summary>
    /// 复位按钮信号
    /// 0.弹出
    /// 1.按下
    /// </summary>
    public enum TRESETButtonStates : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 弹出
        /// </summary>
        [Description("TRESETButtonStates_esNull")]
        esNull = 0,
        /// <summary>
        /// 按下
        /// </summary>
        [Description("TRESETButtonStates_esRESET")]
        esRESET = 1,
    }

    /// <summary>
    /// 急停按钮检测
    /// 0.没有急停
    /// 1.有急停按下
    /// </summary>
    public enum TEmgButtonState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 没有急停
        /// </summary>
        [Description("TEmgButtonState_esNull")]
        esNull = 0,
        /// <summary>
        /// 有急停按下
        /// </summary>
        [Description("TEmgButtonState_esEMG")]
        esEMG = 1,
    }

    /// <summary>
    /// 托盘状态
    /// 0.没有托盘
    /// 1.托盘到位
    /// 2.托盘不到位 
    /// </summary>
    public enum TTrayState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 没有托盘
        /// </summary>
        [Description("TTrayState_dsUndock")]
        dsUndock = 0,
        /// <summary>
        /// 托盘到位
        /// </summary>
        [Description("TTrayState_dsDock")]
        dsDock = 1,
        /// <summary>
        /// 托盘不到位
        /// </summary>
        [Description("TTrayState_dsDockError")]
        dsDockError = 2,
    }

    /// <summary>
    /// 气缸状态
    /// 0.气缸张开
    /// 1.气缸闭合
    /// 2.气缸运动中 
    /// </summary>
    public enum TCylinderStatorState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 气缸张开
        /// </summary>
        [Description("TCylinderStatorState_dsUndock")]
        dsUndock = 0,
        /// <summary>
        /// 气缸闭合
        /// </summary>
        [Description("TCylinderStatorState_dsDock")]
        dsDock = 1,
        /// <summary>
        /// 气缸运动中
        /// </summary>
        [Description("TCylinderStatorState_dsRunning")]
        dsRunning = 2,
    }

    /// <summary>
    /// 风机状态
    /// 0.关闭
    /// 1.打开
    /// 2.故障
    /// </summary>
    public enum TFanState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 关闭
        /// </summary>
        [Description("TFanState_fsStop")]
        fsStop = 0,
        /// <summary>
        /// 打开
        /// </summary>
        [Description("TFanState_fsRun")]
        fsRun = 1,
        /// <summary>
        /// 故障
        /// </summary>
        [Description("TFanState_fsError")]
        fsError = 2,
    }

    /// <summary>
    /// 气压状态
    /// 0.正常 
    /// 1.异常
    /// </summary>
    public enum TAirPressureState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 正常
        /// </summary>
        [Description("TAirPressureState_asNormal")]
        asNormal = 0,
        /// <summary>
        /// 异常
        /// </summary>
        [Description("TAirPressureState_asError")]
        asError = 1,
    }

    /// <summary>
    /// 布幕状态
    /// 0：布幕收回
    /// 1：布幕伸出
    /// 2：异常
    /// </summary>
    public enum TCurtainState : byte
    {
        /// <summary>
        /// 布幕收回
        /// </summary>
        [Description("TCurtainState_csWithdrawal")]
        csWithdrawal = 0,
        /// <summary>
        /// 布幕伸出
        /// </summary>
        [Description("TCurtainState_csExtend")]
        csExtend = 1,
        /// <summary>
        /// 异常
        /// </summary>
        [Description("TCurtainState_csError")]
        csError = 2
    }

    /// <summary>
    /// 门状态
    /// 0.无效
    /// 1.到位 
    /// </summary>
    public enum TDoorState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 无效
        /// </summary>
        [Description("TDoorState_dsNull")]
        dsNull = 0,
        /// <summary>
        /// 到位
        /// </summary>
        [Description("TDoorState_dsDock")]
        dsDock = 1,
    }

    /// <summary>
    /// 复位按钮状态
    /// 0.旋出
    /// 1.按下
    /// </summary>
    public enum TResKeyStates : byte
    {
        /// <summary>
        /// 旋出
        /// </summary>
        [Description("TResKeyStates_Up")]
        Up = 0,
        /// <summary>
        /// 按下
        /// </summary>
        [Description("TResKeyStates_Down")]
        Down = 1,
    }

    /// <summary>
    /// 货叉状态
    /// 0.没挡
    /// 1.挡住
    /// </summary>
    public enum TForkState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 没挡
        /// </summary>
        [Description("TForkState_fsUndock")]
        fsUndock = 0,
        /// <summary>
        /// 挡住
        /// </summary>
        [Description("TForkState_fsDock")]
        fsDock = 1,
    }

    /// <summary>
    /// 0.无效
    /// 1.安全
    /// </summary>
    public enum TSecureState : byte
    {
        /// <summary>
        /// 无效
        /// </summary>
        [Description("TSecureState_ssNo")]
        ssNo = 0,
        /// <summary>
        /// 安全
        /// </summary>
        [Description("TSecureState_ssSecure")]
        ssSecure = 1,
    }

    /// <summary>
    /// 掉电标记
    /// 0.初始化状态
    /// 1.异常掉电需要上位机下发掉电清除或恢复
    /// 2.掉电恢复或清除执行中
    /// 3.正常工作状态
    /// 4.正常掉电
    /// 5.恢复失败
    /// </summary>
    public enum TPowerFailFlag : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 初始化状态
        /// </summary>
        [Description("TPowerFailFlag_pfInit")]
        pfInit = 0,
        /// <summary>
        /// 异常掉电需要上位机下发掉电清除或恢复
        /// </summary>
        [Description("TPowerFailFlag_pfOccurred")]
        pfOccurred = 1,
        /// <summary>
        /// 掉电恢复或清除执行中
        /// </summary>
        [Description("TPowerFailFlag_pfResuming")]
        pfResuming = 2,
        /// <summary>
        /// 正常工作状态
        /// </summary>
        [Description("TPowerFailFlag_pfNormal")]
        pfNormal = 3,
        /// <summary>
        /// 正常掉电
        /// </summary>
        [Description("TPowerFailFlag_pfNormalStop")]
        pfNormalStop = 4,
        /// <summary>
        /// 掉电恢复失败
        /// </summary>
        [Description("TPowerFailFlag_pfResumeError")]
        pfResumeError = 5,
    }

    /// <summary>
    /// 下位机工作模式
    /// 0x51.下位机处于手动测试模式，不可退出（与进入的转态不一致）
    /// 0x52.下位机处于手动测试模式，可退出测试模式
    /// 0xA1.下位机处于正常工作模式，流程工作中不可进入测试模式
    /// 0xAA.下位机处于正常工作模式，空闲状态，可进入测试模式
    /// </summary>
    public enum TMcuWorkState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 下位机处于手动测试模式，不可退出（与进入的转态不一致）
        /// </summary>
        [Description("TMcuWorkState_Manual1")]
        Manual1 = 0x51,
        /// <summary>
        /// 下位机处于手动测试模式，可退出测试模式
        /// </summary>
        [Description("TMcuWorkState_Manual2")]
        Manual2 = 0x52,
        /// <summary>
        /// 下位机处于正常工作模式，流程工作中不可进入测试模式
        /// </summary>
        [Description("TMcuWorkState_Auto1")]
        Auto1 = 0xA1,
        /// <summary>
        /// 下位机处于正常工作模式，空闲状态，可进入测试模式
        /// </summary>
        [Description("TMcuWorkState_Auto2")]
        Auto2 = 0xAA,
    }

    /// <summary>
    /// 工装取电状态 
    /// 0：无输出
    /// 1：有输出
    /// </summary>
    public enum TEtalonPowerState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 无输出
        /// </summary>
        [Description("TEtalonPowerState_WithOutput")]
        WithOutput = 0,
        /// <summary>
        /// 有输出
        /// </summary>
        [Description("TEtalonPowerState_NoOutput")]
        NoOutput = 1
    }

    /// <summary>
    /// 流量阀开度检测状态
    /// 0：初始化
    /// 1：开始检测
    /// 2：检测中
    /// 3：检测完成
    /// 4：检测故障（报警）
    /// </summary>
    public enum TFlowValveState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 初始化
        /// </summary>
        [Description("TFlowValveState_Init")]
        Init = 0,
        /// <summary>
        /// 开始检测
        /// </summary>
        [Description("TFlowValveState_Start")]
        Start = 1,
        /// <summary>
        /// 检测中
        /// </summary>
        [Description("TFlowValveState_Test")]
        Test = 2,
        /// <summary>
        /// 检测完成
        /// </summary>
        [Description("TFlowValveState_Completed")]
        Completed = 3,
        /// <summary>
        /// 检测故障（报警）
        /// </summary>
        [Description("TFlowValveState_Error")]
        Error = 4
    }

    /// <summary>
    /// 机构温度传感器状态
    /// 0.正常
    /// 1.温度超标报警
    /// 2.传感器异常或没有连接
    /// </summary>
    public enum TTempState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 正常
        /// </summary>
        [Description("TTempState_asNormal")]
        asNormal = 0,
        /// <summary>
        /// 温度超标报警
        /// </summary>
        [Description("TTempState_asAlarm")]
        asAlarm = 1,
        /// <summary>
        /// 传感器异常或没有连接
        /// </summary>
        [Description("TTempState_asInitError")]
        asInitError = 2,
    }

    /// <summary>
    /// 烟雾传感器状态
    /// 0.正常
    /// 1.烟雾超标报警
    /// 2.传感器异常或没有连接
    /// </summary>
    public enum TSmogState : byte
    {
        NO01 = 0xFF,

        /// <summary>
        /// 正常
        /// </summary>
        [Description("TSmogState_asNormal")]
        asNormal = 0,
        /// <summary>
        /// 烟雾超标报警
        /// </summary>
        [Description("TSmogState_asAlarm")]
        asAlarm = 1,
        /// <summary>
        /// 传感器异常或没有连接
        /// </summary>
        [Description("TSmogState_asInitError")]
        asInitError = 2,
    }

    /// <summary>
    /// 传感器状态
    /// 0.无效
    /// 1.有效
    /// </summary>
    public enum TSensorStates : byte
    {
        /// <summary>
        /// 无效
        /// </summary>
        [Description("TSensorStates_Null")]
        Null = 0,
        /// <summary>
        /// 有效
        /// </summary>
        [Description("TSensorStates_OK")]
        OK = 1,
    }

    /// <summary>
    /// 通信状态
    /// 0.电源故障通讯不上
    /// 1.初始化不对
    /// 2.正常
    /// </summary>
    public enum TComState : byte
    {
        /// <summary>
        /// 电源故障通讯不上
        /// </summary>
        [Description("TComState_Null")]
        Null = 0,
        /// <summary>
        /// 初始化不对
        /// </summary>
        [Description("TComState_Error")]
        Error = 1,
        /// <summary>
        /// 正常
        /// </summary>
        [Description("TComState_OK")]
        OK = 2
    }

    /// <summary>
    /// 通信状态
    /// 1：电源故障通讯不上，
    /// 2：初始化不对
    /// 0：正常
    /// </summary>
    public enum TInverterStateTwowin : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("TInverterStateTwowin_asNormal")]
        asNormal = 0,
        /// <summary>
        /// 电源故障通讯不上
        /// </summary>
        [Description("TInverterStateTwowin_asAlarm")]
        asAlarm = 1,
        /// <summary>
        /// 初始化不对
        /// </summary>
        [Description("TInverterStateTwowin_asInitError")]
        asInitError = 2,
    }
}