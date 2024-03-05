using System.ComponentModel;
using System.Runtime.InteropServices;

namespace CDClassLibrary.Stage
{
    /// <summary>
    /// 发送流程（0xA301）
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct TProcessMCU
    {
        //流程保护参数
        /// <summary>
        /// 充电保护
        /// </summary>
        public TChargeProtectMCU ChargeProtectMCU;
        /// <summary>
        /// 放电保护
        /// </summary>
        public TDisChargeProtectMCU DisChargeProtectMCU;
        /// <summary>
        /// 通用保护
        /// </summary>
        public TCommonProtectMCU CommonProtectMCU;


        /// <summary>
        /// 流程模式
        /// </summary>
        public TProcessMode ProcessMode;
        /// <summary>
        /// 容量/能量计算模式
        /// </summary>
        public TCapEnCalculateMode CapEnCalculateMode;
        /// <summary>
        /// 模式选择
        /// </summary>
        public TOperationMode OperationMode;
        /// <summary>
        /// 步次数量
        /// </summary>
        /// 
        public byte StepCount;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public byte[] ReserveNull;
        /// <summary>
        /// 通道选择
        /// 每个通道用一个 bit，共 600 通道
        /// 1：通道被选中
        /// 0：通道不选中
        /// </summary>



        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 75)]
        public byte[] PosSelected;
        /// <summary>
        /// 步次内容
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public TProcStepRecMCU[] ProcStepRecMCU;



        public TProcessMCU()
        {
            ChargeProtectMCU = new TChargeProtectMCU();
            DisChargeProtectMCU = new TDisChargeProtectMCU();
            CommonProtectMCU = new TCommonProtectMCU();
            ProcessMode = TProcessMode.Normal;
            CapEnCalculateMode = TCapEnCalculateMode.AddUp;
            OperationMode = TOperationMode.Production;
            StepCount = 0;
            ReserveNull = new byte[5];
            PosSelected = new byte[75];
            for (int i = 0; i < 75; i++)
                PosSelected[i] = 0;
            ProcStepRecMCU = new TProcStepRecMCU[100];
            for (int i = 0; i < 100; i++)
                ProcStepRecMCU[i] = new TProcStepRecMCU();
        }
    }

    /// <summary>
    /// 步次内容
    /// 单个流程内容
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct TProcStepRecMCU
    {
        /// <summary>
        /// 电压值/循环起始步次序号
        /// 有符号，*100, 单位 mV；（起始步次序号不乘 100）
        /// </summary>
        public Int32 Voltage;
        /// <summary>
        /// 电流值/循环次数
        /// 有符号，*100, 单位 mA，（循环次数不乘 100）
        /// </summary>
        public Int32 Current;
        /// <summary>
        /// 时间限制1
        /// 单位 s, 无符号，与时间限制 2 一起使用
        /// </summary>
        public Int32 LimitTime1;
        /// <summary>
        /// 限制值
        /// 充电时为电流截止值：有符号，*100, 单位 mA；
        /// 放电时为电压截止值：有符号，*100, 单位 mV；
        /// 恒功率时为设定功率值，有符号，*100, 单位 mW；
        /// </summary>
        public Int32 LimitValue;
        /// <summary>
        /// 容量截止值
        /// 本步次的容量截止值，无符号，*100，单位 mAh，为 0 时不起作用
        /// </summary>
        public Int32 EndCap;
        /// <summary>
        /// 步次类型
        /// </summary>
        public TStepMode StepMode;
        /// <summary>
        /// 下一步模式
        /// </summary>
        public TNextMode NextMode;
        /// <summary>
        /// 时间限制2
        /// 单位为毫秒，范围 0~1000，无符号，与时间限制 1 一起使用
        /// </summary>
        public Int16 LimitTime2;

        public TProcStepRecMCU()
        {
            Voltage = 0;
            Current = 0;
            LimitTime1 = 0;
            LimitValue = 0;
            EndCap = 0;
            StepMode = TStepMode.SKIP;
            NextMode = TNextMode.Next;
            LimitTime2 = 0;
        }
    }

    /// <summary>
    /// 充电保护
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct TChargeProtectMCU
    {
        /// <summary>
        /// 充电保护有效标记
        /// 每一位对应一项保护，1 表示保护项有效，0 表示保护项不起作用；
        /// bit0 保护项 1：充电上限电压
        /// bit1 保护项 2：充电上限容量
        /// bit3 保护项 3：充电检查（电压下限）
        /// bit4 保护项 4：充电电流下限
        /// bit5 保护项 5：T1 时刻检查
        /// bit8 保护项 6：T2 时刻检查
        /// bit11 保护项 7：CC 缺时检查
        /// bit12 保护项 8：CC 超时检查
        /// bit13 保护项 9：T5 时刻检查
        /// bit16 保护项 10：恒压时电压偏差范围 
        /// bit18 保护项 11：恒压电流上升累计次数
        /// bit19 保护项 12：恒压电流上升连续次数
        /// bit21 保护项 13：充电电压下降累计次数
        /// bit22 保护项 14：充电电压下降连续次数
        /// bit23 保护项 15：充电限制时间
        /// bit25 保护项 16：充电电压未上升保护
        /// bit26 保护项 17：恒压电流突升保护
        /// bit27 保护项 18：充电电压过上升保护
        /// bit28 保护项 19：充电下限电压保护
        /// </summary>
        public Int32 IsValidFlag;
        /// <summary>
        /// 充电上限电压
        /// 充电时电池电压大于设定保护值时起保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 VoltUpperLimit;
        /// <summary>
        /// 充电上限容量
        /// 充电时容量大于设定的保护值时起保护；（每个步次的容量从 0 开始计算，充电时表示储存了多少容量）；单位 mAh，*100，无符号
        /// </summary>
        public Int32 CapacityUpperLimit;
        /// <summary>
        /// 充电检查（检查时刻）
        /// 从当前步次开始时刻算起，到达设定的检查时刻，如果此时电池电压小于设定保护值时起保护，每个流程只在第一个充电步次中检查；为 0 时无效；单位 s，无符号
        /// </summary>
        public Int32 CheckTime;
        /// <summary>
        /// 充电检查（下限电压）
        /// 从当前步次开始时刻算起，到达设定的检查时刻，如果此时电池电压小于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mV, *100，有符号
        /// </summary>
        public Int32 CheckVoltUpperLimit;
        /// <summary>
        /// 充电电流下限
        /// 充电时如果电流小于设定保护值时起保护；单位 mA, *100，有符号
        /// </summary>
        public Int32 CurreLowerLimit;
        /// <summary>
        /// T1 时刻
        /// 单位 s，无符号
        /// </summary>
        public Int32 T1Time;
        /// <summary>
        /// T1 电压上限
        /// 从当前步次开始时刻算起，到达设定的 T1 时刻，如果此时电池电压大于设定保护值时起保护，每个流程只在第一个充电步次中检查;单位 mV, *100，有符号
        /// </summary>
        public Int32 T1VoltUpperLimit;
        /// <summary>
        /// T1 电压下限
        /// 从当前步次开始时刻算起，到达设定的 T1 时刻，如果此时电池电压小于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mV, *100，有符号
        /// </summary>
        public Int32 T1VoltLowerLimit;
        /// <summary>
        /// T2 时刻
        /// 单位 s，无符号
        /// </summary>
        public Int32 T2Time;
        /// <summary>
        /// T2 电压上限
        /// 从当前步次开始时刻算起，到达设定的 T2 时刻，如果此时电池电压大于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mV, *100，有符号
        /// </summary>
        public Int32 T2VoltUpperLimit;
        /// <summary>
        /// T2 电压下限
        /// 从当前步次开始时刻算起，到达设定的 T2 时刻，如果此时电池电压小于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mV, *100，有符号
        /// </summary>
        public Int32 T2VoltLowerLimit;
        /// <summary>
        /// CC 缺时检查
        /// 只在 CCCV 步次中检查，从当前步次起始时刻开始计时，如果恒流阶段的充电时间（CC 转 CV 时刻）小于设定时刻则保护；为 0 时无效；单位 s，无符号
        /// </summary>
        public Int32 CCLackTime;
        /// <summary>
        /// CC 超时检查
        /// 只在 CCCV 步次中检查，从当前步次起始时刻开始计时，如果到达设定时刻时步次仍处于恒流充电阶段则保护；为 0 时无效；单位 s，无符号
        /// </summary>
        public Int32 CCOverTime;
        /// <summary>
        /// T5 时刻
        /// 单位 s，无符号
        /// </summary>
        public Int32 T5Time;
        /// <summary>
        /// T5 电流上限
        /// 从当前步次开始时刻算起，到达设定的 T5 时刻，如果此时电流大于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mA, *100，有符号
        /// </summary>
        public Int32 T5CurreUpperLimit;
        /// <summary>
        /// T5 电流下限
        /// 从当前步次开始时刻算起，到达设定的 T5 时刻，如果此时电流小于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mA, *100，有符号
        /// </summary>
        public Int32 T5CurreLowerLimit;
        /// <summary>
        /// 充电恒压时，电压偏差范围
        /// 恒压时，电压大于（恒压值+偏差）或者小于(恒压值-偏差)时起保护；单位 mV，*100，有符号
        /// </summary>
        public Int32 ConstVoltDeviate;
        /// <summary>
        /// 恒压电流上升保护（上升幅度）
        /// 恒压时检测电流是否有上升，根据相邻两次采样电流来判断电流是否上升：如果（当前电流 – 前一次电流） > 设定幅度，则代表电流上升，记为1 次；单位 mA, *100，有符号
        /// </summary>
        public Int32 CurreRiseLimit;
        /// <summary>
        /// 恒压电流上升保护（累计次数）
        /// 当前步次中，当电流上升次数累计达到设定次数时起保护，只在恒压阶段判断；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public Int32 CurreRiseCumulateCount;
        /// <summary>
        /// 恒压电流上升保护（连续次数）
        /// 当前步次中，当电流上升连续达到设定次数时起保护，只在恒压阶段判断；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public Int32 CurreRiseContinueCount;
        /// <summary>
        /// 充电电压下降（下降幅度）
        /// 检测充电过程中是否有电压下降，根据相邻两次采样电压来判断是否有电压下降发生，如果（前一次电压 – 当前电压） > 设定幅度，则代表电压下降，记为 1 次；单位 mV, *100，有符号
        /// </summary>
        public Int32 VoltDropLimit;
        /// <summary>
        /// 充电电压下降（累计次数）
        /// 当前步次中，当电压下降次数累计达到设定次数时起保护；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public Int32 VoltDropCumulateCount;
        /// <summary>
        /// 充电电压下降（连续次数）
        /// 当前步次中，当电压下降连续次数达到设定次数时起保护；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public Int32 VoltDropContinueCount;
        /// <summary>
        /// 充电限制时间
        /// 充电的限制时间，超过设定值时起保护；单位 s，无符号
        /// </summary>
        public Int32 TimeLimit;
        /// <summary>
        /// 充电电压未上升保护（间隔时间）
        /// 在恒流充电阶段判断：根据设定的间隔时间取电压值，如果本次取的电压值减去上一次取的电压值小于设定值时，则认为充电异常需要保护；单位 s，无符号
        /// </summary>
        public Int32 NoVoltRiseTime;
        /// <summary>
        /// 充电电压未上升保护（电压幅值）
        /// 在恒流充电阶段判断：根据设定的间隔时间取电压值，如果本次取的电压值减去上一次取的电压值小于设定值时，则认为充电异常需要保护，单位 mV, *100，有符号
        /// </summary>
        public Int32 NoVoltRiseLimit;
        /// <summary>
        /// 恒压时电流突升
        /// 恒压时检测电流是否有突升，根据相邻两次采样电流来判断电流是否突升：如果（当前电流 – 前一次电流） > 设定幅度，则代表电流突升，此时起保护；单位 mA, *100，有符号
        /// </summary>
        public Int32 CurreSwell;
        /// <summary>
        /// 充电电压过上升保护（间隔时间）
        /// 在恒流充电阶段判断：根据设定的间隔时间取电压值，如果本次取的电压值减去上一次取的电压值大于设定值时，则认为充电异常需要保护；单位 s，无符号
        /// </summary>
        public Int32 SwellVoltRiseTime;
        /// <summary>
        /// 充电电压过上升保护（电压幅值）
        /// 在恒流充电阶段判断：根据设定的间隔时间取电压值，如果本次取的电压值减去上一次取的电压值大于设定值时，则认为充电异常需要保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 SwellVoltRiseLimit;
        /// <summary>
        /// 充电下限电压
        /// 充电时电池电压小于设定保护值时起保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 VoltLowerLimit;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] ReserveNull;

        public TChargeProtectMCU()
        {
            IsValidFlag = 0;
            VoltUpperLimit = 0;
            CapacityUpperLimit = 0;
            CheckTime = 0;
            CheckVoltUpperLimit = 0;
            CurreLowerLimit = 0;
            T1Time = 0;
            T1VoltUpperLimit = 0;
            T1VoltLowerLimit = 0;
            T2Time = 0;
            T2VoltUpperLimit = 0;
            T2VoltLowerLimit = 0;
            CCLackTime = 0;
            CCOverTime = 0;
            T5Time = 0;
            T5CurreLowerLimit = 0;
            T5CurreUpperLimit = 0;
            ConstVoltDeviate = 0;
            CurreRiseLimit = 0;
            CurreRiseContinueCount = 0;
            CurreRiseCumulateCount = 0;
            VoltDropLimit = 0;
            VoltDropCumulateCount = 0;
            VoltDropContinueCount = 0;
            TimeLimit = 0;
            NoVoltRiseTime = 0;
            NoVoltRiseLimit = 0;
            CurreSwell = 0;
            SwellVoltRiseTime = 0;
            SwellVoltRiseLimit = 0;
            VoltLowerLimit = 0;
            ReserveNull = new byte[8];
        }
    }

    /// <summary>
    /// 放电保护
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct TDisChargeProtectMCU
    {
        /// <summary>
        /// 放电保护有效标记
        /// 每一位对应一项保护，1 表示保护项有效，0 表示保护项不起作用；
        /// bit0 保护项 1：放电下限电压
        /// bit1 保护项 2：放电限制时间
        /// bit2 保护项 3：放电下限容量
        /// bit4 保护项 4：放电电压上升累计次数
        /// bit5 保护项 5：放电电压上升连续次数
        /// bit6 保护项 6：放电上限容量
        /// bit7 保护项 7：放电电流上偏差保护
        /// Bit9 保护项 8：放电检查（电压下限）
        /// bit10 保护项 9：放电检查（电压上限）
        /// bit12 保护项 10：放电电压未下降保护
        /// bit14 保护项 11：放电电压过下降保护
        /// bit15 保护项 12：放电上限电压保护
        /// bit30 保护项 s2：串联总电压偏差保护
        /// bit31 保护项 s1：串联总电压过压保护
        /// </summary>
        public Int32 IsValidFlag;
        /// <summary>
        /// 放电下限电压
        /// 放电时电压的下限值，放电时电池电压小于设定保护值时起保护；单位 mV, *100，有符号/// </summary>
        public Int32 VoltLowerLimit;
        /// <summary>
        /// 放电限制时间
        /// 放电的限制时间，超过设定值时起保护；单位 s，无符号
        /// </summary>
        public Int32 TimeLimit;
        /// <summary>
        /// 放电下限容量
        /// 在放电结束时判断，如果放电容量小于设定保护值时起保护；（每个步次的容量从 0 开始计算，放电时表示放掉了多少容量）；单位 mAh，*100，无符号
        /// </summary>
        public Int32 CapacityLowerLimit;
        /// <summary>
        /// 放电电压上升（上升幅度）
        /// 检测放电过程中是否有电压上升，根据相邻两次采样电压来判断是否有电压上升发生，如果（当前电压 – 前一次电压） > 设定幅度，则代表电压上升，记为 1 次；单位 mV, *100，有符号
        /// </summary>
        public Int32 VoltRiseLimit;
        /// <summary>
        /// 放电电压上升（累计次数）
        /// 当前步次中，当电压上升次数累计达到设定次数时起保护；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public Int32 VoltRiseCumulateCount;
        /// <summary>
        /// 放电电压上升（连续次数）
        /// 当前步次中，当电压上升连续次数达到设定次数时起保护；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public Int32 VoltRiseContinueCount;
        /// <summary>
        /// 放电上限容量
        /// 放电时容量大于设定的保护值时起保护；（每个步次的容量从 0 开始计算，充电时表示储存了多少容量）；单位 mAh，*100，无符号
        /// </summary>
        public Int32 CapacityUpperLimit;
        /// <summary>
        /// 放电电流上偏差保护
        /// 放电时如果（电流值-恒流值）大于设定保护值时起保护，单位 mA, *100，有符号
        /// </summary>
        public Int32 CurreDeviate;
        /// <summary>
        /// 放电检查（检查时刻）
        /// 从当前步次起始时刻开始计时，到达设定时刻后检查电压值，如果低于设定下限或超过设定上限则保护，单位 s，无符号
        /// </summary>
        public Int32 CheckTime;
        /// <summary>
        /// 放电检查（电压下限）
        /// 从当前步次起始时刻开始计时，到达设定时刻后检查电压值，如果低于设定下限或超过设定上限则保护，单位 mV, *100，有符号
        /// </summary>
        public Int32 CheckVoltLowerLimit;
        /// <summary>
        /// 放电检查（电压上限）
        /// 从当前步次起始时刻开始计时，到达设定时刻后检查电压值，如果低于设定下限或超过设定上限则保护，单位 mV, *100，有符号
        /// </summary>
        public Int32 CheckVoltUpperLimit;
        /// <summary>
        /// 放电电压未下降保护（间隔时间）
        /// 在恒流放电阶段判断：根据设定的间隔时间取电压值，如果上一次取的电压值减去本次取的电压值小于设定值时，则认为放电异常需要保护；单位 s，无符号
        /// </summary>
        public Int32 NoVoltDropTime;
        /// <summary>
        /// 放电电压未下降保护（电压幅值）
        /// 在恒流放电阶段判断：根据设定的间隔时间取电压值，如果上一次取的电压值减去本次取的电压值小于设定值时，则认为放电异常需要保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 NoVoltDropLimit;
        /// <summary>
        /// 放电电压过下降保护（间隔时间）
        /// 在恒流放电阶段判断：根据设定的间隔时间取电压值，如果上一次取的电压值减去本次取的电压值大于设定值时，则认为放电异常需要保护；单位 s，无符号
        /// </summary>
        public Int32 SwellVoltDropTime;
        /// <summary>
        /// 放电电压过下降保护（电压幅值）
        /// 在恒流放电阶段判断：根据设定的间隔时间取电压值，如果上一次取的电压值减去本次取的电压值大于设定值时，则认为放电异常需要保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 SwellVoltDropLimit;
        /// <summary>
        /// 放电上限电压
        /// 放电时电池电压大于设定保护值时起保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 VoltUpperLimit;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        public byte[] ReserveNull;
        /// <summary>
        /// 串联总电压偏差
        /// 单位 mV, *100，有符号
        /// </summary>
        public Int32 ConnectVoltDeviate;
        /// <summary>
        /// 串联总电压过压
        /// 单位 mV, *100，有符号
        /// </summary>
        public Int32 ConnectVoltToolarge;

        public TDisChargeProtectMCU()
        {
            IsValidFlag = 0;
            VoltLowerLimit = 0;
            TimeLimit = 0;
            CapacityLowerLimit = 0;
            VoltRiseLimit = 0;
            VoltRiseCumulateCount = 0;
            VoltRiseContinueCount = 0;
            CapacityUpperLimit = 0;
            CurreDeviate = 0;
            CheckTime = 0;
            CheckVoltLowerLimit = 0;
            CheckVoltUpperLimit = 0;
            NoVoltDropTime = 0;
            NoVoltDropLimit = 0;
            SwellVoltDropTime = 0;
            SwellVoltDropLimit = 0;
            VoltUpperLimit = 0;
            ReserveNull = new byte[56];
            ConnectVoltDeviate = 0;
            ConnectVoltToolarge = 0;
        }
    }

    /// <summary>
    /// 通用保护
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct TCommonProtectMCU
    {
        /// <summary>
        /// 通用保护有效标记
        /// 每一位对应一项保护，1 表示保护项有效，0 表示
        /// 保护项不起作用；
        /// bit0  保护项 1：恒流波动保护
        /// bit1  保护项 2：过流保护
        /// bit2  保护项 3：休眠回路电流保护
        /// bit3  保护项 4：电池电压过压保护
        /// bit4  保护项 5：电流线电压过压保护
        /// bit5  保护项 6：充放电时电压差值保护
        /// bit6  保护项 7：休眠时电压差值保护
        /// bit7  保护项 8：接触阻抗保护
        /// bit8  保护项 9：电压突降保护
        /// Bit9  保护项 10：电池温度下限报警保护
        /// Bit10 保护项 11：电池温度上限报警保护
        /// Bit11 保护项 12：容量上限保护
        /// Bit12 保护项 13：急停电压保护（上限）
        /// Bit13 保护项 14：T 时刻电压保护
        /// Bit14 保护项 15：通道板温度报警保护
        /// Bit16 保护项 17：休眠电压上限保护
        /// Bit18 保护项 18：恒流间隔波动
        /// Bit20 保护项 19：休眠步次电压异常波动
        /// Bit21 保护项 20：电池电压欠压保护
        /// Bit22 保护项 21：恒流上偏差保护
        /// Bit23 保护项 22：恒流下偏差保护
        /// Bit24 保护项 23：反接电压保护
        /// </summary>
        public Int32 IsValidFlag;
        /// <summary>
        /// 恒流波动保护
        /// 在恒流阶段，当电流大于（恒流值+波动值）时起保护（0xDB）；
        /// 在恒流阶段，当电流小于（恒流值-波动值）时起保护（0xDF）；
        /// 单位 mA, *100，有符号
        /// </summary>
        public Int32 CurreFluctu;
        /// <summary>
        /// 过流保护
        /// 流程中当电流大于设置的保护值时起保护；单位 mA, *100，有符号
        /// </summary>
        public Int32 CurreToolarge;
        /// <summary>
        /// 休眠回路电流保护
        /// 在休眠步次中，如果电流大于设定保护值时起保护；单位 mA, *100，有符号
        /// </summary>
        public Int32 RESTCurreUpperLimit;
        /// <summary>
        /// 电池电压过压保护
        /// 流程中当电池电压大于设置的保护值时起保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 CellVoltToolarge;
        /// <summary>
        /// 电流线电压过压保护
        /// 流程中当线电压大于设定保护值时起保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 LineVoltToolarge;
        /// <summary>
        /// 充放电时，电流线电压与电池电压差值保护
        /// 充放电时，电流线电压与电池电压的差值（绝对值）大于设定保护值时起保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 ChargeDisCellVoltLineDvalue;
        /// <summary>
        /// 休眠时，电流线电压与电池电压差值保护
        /// 休眠时，电流线电压与电池电压的差值（绝对值）大于设定保护值时起保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 RESTCellLineVoltDvalue;
        /// <summary>
        /// 接触阻抗保护
        /// 如果电流小于 3A（根据实际项目调整）时，接触阻抗为 0，否则接触阻抗=|线电压-电池电压|/电流，当接触阻抗大于设定保护值时起保护；单位毫欧姆，*100, 无符号
        /// </summary>
        public Int32 ContactIR;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] ReserveNull5;
        /// <summary>
        /// 电压突降保护
        /// 检测充电过程中是否有电压突降，根据相邻两次采样电压来判断是否有电压突降发生，如果（前一次电压 – 当前电压） > 设定幅度，则代表电压突降，这时起保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 VoltSlump;
        /// <summary>
        /// 电池温度下限报警
        /// 如果电池温度低于设置的保护值时起保护；单位度, *100，有符号
        /// </summary>
        public Int16 CellTempLowerLimit;
        /// <summary>
        /// 电池温度上限报警
        /// 如果电池温度高于设置的保护值时起保护；单位度, *100，有符号
        /// </summary>
        public Int16 CellTempUpperLimit;
        /// <summary>
        /// 容量上限保护
        /// 流程中容量的上限，超过则起保护；单位 mAh，*100，无符号
        /// </summary>
        public Int32 CapacityUpperLimit;
        /// <summary>
        /// 急停电压保护（上限）
        /// 全局电压上限保护，当电池电压大于等于设定的保护值时起保护，并且所有通道停止工作，状态为暂停；单位 mV, *100，有符号
        /// </summary>
        public Int32 EmgStopVoltUpperLimit;
        /// <summary>
        /// T 时刻
        /// 从流程开始时刻算起；单位 s，无符号
        /// </summary>
        public Int32 TTime;
        /// <summary>
        /// T 时刻电压上限
        /// 从流程开始时刻算起，到达设定的 T 时刻，如果此时电池电压大于设定保护值时起保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 TVoltUpperLimit;
        /// <summary>
        /// T 时刻电压下限
        /// 从流程开始时刻算起，到达设定的 T 时刻，如果此时电池电压小于设定保护值时起保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 TVoltLowerLimit;
        /// <summary>
        /// 通道板温度报警
        /// 如果通道板温度高于设置的保护值时起保护单位度, *100，有符号
        /// </summary>
        public Int16 PosTempUpperLimit;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] ReserveNull1;
        /// <summary>
        /// 休眠电压上限
        /// 休眠时，电压超过设定值则保护，单位 mV, *100，有符号
        /// </summary>
        public Int32 RESTVoltUpperLimit;
        /// <summary>
        /// 恒流间隔波动（间隔时间）
        /// 在恒流阶段检查，根据设定的间隔时间取电流值，如果相邻两次差值的绝对值大于设定波动值时则保护，为 0 时无效单位 s，无符号 
        /// </summary>
        public Int32 CurreIntervalFluctuTime;
        /// <summary>
        /// 恒流间隔波动（波动值）
        /// 在恒流阶段检查，根据设定的间隔时间取电流值，如果相邻两次差值的绝对值大于设定波动值时则保护，为 0 时无效单位 mA, *100，有符号
        /// </summary>
        public Int32 CurreIntervalFluctu;
        /// <summary>
        /// 休眠步次电压异常波动保护（延时时间）
        /// 休眠步次中，等待一段延时后（待充放电结束电压稳定），根据相邻两次采样电压来判断是否有电压上升发生，如果 |当前电压 – 前一次电压| >设定幅度则保护；单位 s，无符号
        /// </summary>
        public Int32 VoltIntervalFluctuTime;
        /// <summary>
        /// 休眠步次电压异常波动保护（检测幅值）
        /// 休眠步次中，等待一段延时后（待充放电结束电压稳定），根据相邻两次采样电压来判断是否有电压上升发生，如果 |当前电压 – 前一次电压| >设定幅度则保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 VoltIntervalFluctu;
        /// <summary>
        /// 电池电压欠压保护
        /// 流程中当电池电压小于设置的保护值时起保护；单位 mV, *100，有符号
        /// </summary>
        public Int32 CellUnderVolt;
        /// <summary>
        /// 恒流上偏差保护
        /// 在恒流阶段，当电流大于（恒流值+上偏差值）时起保护（0xDB）；
        /// </summary>
        public Int32 CurreDeviateUpper;
        /// <summary>
        /// 恒流下偏差保护
        /// 在恒流阶段，当电流小于（恒流值-下偏差值）时起保护（0xDF）；单位 mA, *100，有符号
        /// </summary>
        public Int32 CurreDeviateLower;
        /// <summary>
        /// 反接电压保护
        /// 反接电压最小值，低于则保护，单位 mV, *100，有符号
        /// </summary>
        public Int32 InsteadVolt;
        /// <summary>
        /// 温升速率 (间隔时间)
        /// 根据设定的间隔时间取电池温度，如果本次取的电池温度减去上一次取的电池温度大于设定值时，则认为电池温度上升速度异常需要保护:单位 s，无符号
        /// </summary>
        public Int32 TempRiseTime;
        /// <summary>
        /// 温升速率(电池温度幅值)
        /// 根据设定的间隔时间取电池温度，如果本次取的电池温度减去上一次取的电池温度大于设定值时，则认为电池温度上升速度异常需要保护:单位度.*100，有符号
        /// </summary>
        public Int16 TempRiseValue;
        /// <summary>
        /// 预留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
        public byte[] ReserveNull2;

        public TCommonProtectMCU()
        {
            IsValidFlag = 0;
            CurreFluctu = 0;
            CurreToolarge = 0;
            RESTCurreUpperLimit = 0;
            CellVoltToolarge = 0;
            LineVoltToolarge = 0;
            ChargeDisCellVoltLineDvalue = 0;
            RESTCellLineVoltDvalue = 0;
            ContactIR = 0;
            VoltSlump = 0;
            CellTempLowerLimit = 0;
            CellTempUpperLimit = 0;
            CapacityUpperLimit = 0;
            EmgStopVoltUpperLimit = 0;
            TTime = 0;
            TVoltUpperLimit = 0;
            TVoltLowerLimit = 0;
            PosTempUpperLimit = 0;
            ReserveNull1 = new byte[2];
            RESTVoltUpperLimit = 0;
            CurreIntervalFluctuTime = 0;
            CurreIntervalFluctu = 0;
            VoltIntervalFluctuTime = 0;
            VoltIntervalFluctu = 0;
            CellUnderVolt = 0;
            CurreDeviateUpper = 0;
            CurreDeviateLower = 0;
            InsteadVolt = 0;
            TempRiseTime = 0;
            TempRiseValue = 0;
            ReserveNull2 = new byte[18];
            ReserveNull5 = new byte[4];
        }
    }

    /// <summary>
    /// 流程参数
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public class TProcess
    {
        //流程保护参数
        /// <summary>
        /// 充电保护
        /// </summary>
        public TChargeProtect ChargeProtect = new();
        /// <summary>
        /// 放电保护
        /// </summary>
        public TDisChargeProtect DisChargeProtect = new();
        /// <summary>
        /// 通用保护
        /// </summary>
        public TCommonProtect CommonProtect = new();

        /// <summary>
        /// 流程模式
        /// </summary>
        public TProcessMode ProcessMode = TProcessMode.Normal;
        /// <summary>
        /// 容量/能量计算模式
        /// </summary>
        public TCapEnCalculateMode CapEnCalculateMode = TCapEnCalculateMode.AddUp;
        /// <summary>
        /// 模式选择
        /// </summary>
        public TOperationMode OperationMode = TOperationMode.Production;
        /// <summary>
        /// 步次数量
        /// </summary>
        public int StepCount = 0;
        /// <summary>
        /// 通道选择
        /// 每个通道用一个 bit，共 600 通道
        /// true：通道被选中
        /// false：通道不选中
        /// </summary>
        public bool[] PosSelected = new bool[GlobalDefine.CHANNELS];
        /// <summary>
        /// 步次内容 100步
        /// </summary> 
        public TProcStepRec[] ProcStepRec = new TProcStepRec[100];
        public TProcess()
        {
            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                PosSelected[ChnNo] = false;
            for (int i = 0; i < 100; i++)
                ProcStepRec[i] = new TProcStepRec();
        }
    }

    /// <summary>
    /// 步次内容
    /// </summary>
    [Serializable]
    public class TProcStepRec
    {
        /// <summary>
        /// 电压值/循环起始步次序号
        /// 有符号，单位 mV；
        /// </summary>
        public double Voltage = 0;
        /// <summary>
        /// 电流值/循环次数
        /// 有符号，单位 mA，
        /// </summary>
        public double Current = 0;
        /// <summary>
        /// 时间限制1
        /// 单位 s, 无符号，与时间限制 2 一起使用
        /// </summary>
        public int LimitTime1 = 0;
        /// <summary>
        /// 限制值
        /// 充电时为电流截止值：有符号，单位 mA；
        /// 放电时为电压截止值：有符号，单位 mV；
        /// 恒功率时为设定功率值，有符号，单位 mW；
        /// </summary>
        public double LimitValue = 0;
        /// <summary>
        /// 容量截止值
        /// 本步次的容量截止值，无符号，单位 mAh，为 0 时不起作用
        /// </summary>
        public double EndCap = 0;
        /// <summary>
        /// 步次类型
        /// </summary>
        public TStepMode StepMode = TStepMode.SKIP;
        /// <summary>
        /// 下一步模式
        /// </summary>
        public TNextMode NextMode = TNextMode.Next;
        /// <summary>
        /// 时间限制2
        /// 单位为毫秒，范围 0~1000，无符号，与时间限制 1 一起使用
        /// </summary>
        public int LimitTime2 = 0;
    }

    /// <summary>
    /// 充电保护
    /// </summary>
    [Serializable]
    public class TChargeProtect
    {
        /// <summary>
        /// 充电保护有效标记
        /// 每一位对应一项保护，true 表示保护项有效，false 表示保护项不起作用；
        /// bit0 保护项 1：充电上限电压
        /// bit1 保护项 2：充电上限容量
        /// bit3 保护项 3：充电检查（电压下限）
        /// bit4 保护项 4：充电电流下限
        /// bit5 保护项 5：T1 时刻检查
        /// bit8 保护项 6：T2 时刻检查
        /// bit11 保护项 7：CC 缺时检查
        /// bit12 保护项 8：CC 超时检查
        /// bit13 保护项 9：T5 时刻检查
        /// bit16 保护项 10：恒压时电压偏差范围 
        /// bit18 保护项 11：恒压电流上升累计次数
        /// bit19 保护项 12：恒压电流上升连续次数
        /// bit21 保护项 13：充电电压下降累计次数
        /// bit22 保护项 14：充电电压下降连续次数
        /// bit23 保护项 15：充电限制时间
        /// bit25 保护项 16：充电电压未上升保护
        /// bit26 保护项 17：恒压电流突升保护
        /// bit27 保护项 18：充电电压过上升保护
        /// bit28 保护项 19：充电下限电压保护
        /// </summary>
        public bool[] IsValidFlag = new bool[32];
        /// <summary>
        /// 充电上限电压
        /// 充电时电池电压大于设定保护值时起保护；单位 mV,有符号
        /// </summary>
        public double VoltUpperLimit = 3800;
        /// <summary>
        /// 充电上限容量
        /// 充电时容量大于设定的保护值时起保护；（每个步次的容量从 0 开始计算，充电时表示储存了多少容量）；单位 mAh，无符号
        /// </summary>
        public double CapacityUpperLimit = 20000;
        /// <summary>
        /// 充电检查（检查时刻）
        /// 从当前步次开始时刻算起，到达设定的检查时刻，如果此时电池电压小于设定保护值时起保护，每个流程只在第一个充电步次中检查；为 0 时无效；单位 s，无符号
        /// </summary>
        public int CheckTime = 5;
        /// <summary>
        /// 充电检查（下限电压）
        /// 从当前步次开始时刻算起，到达设定的检查时刻，如果此时电池电压小于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mV,有符号
        /// </summary>
        public double CheckVoltUpperLimit = 2000;
        /// <summary>
        /// 充电电流下限
        /// 充电时如果电流小于设定保护值时起保护；单位 mA,有符号
        /// </summary>
        public double CurreLowerLimit = 10;
        /// <summary>
        /// T1 时刻
        /// 单位 s，无符号
        /// </summary>
        public int T1Time = 2000;
        /// <summary>
        /// T1 电压上限
        /// 从当前步次开始时刻算起，到达设定的 T1 时刻，如果此时电池电压大于设定保护值时起保护，每个流程只在第一个充电步次中检查;单位 mV,有符号
        /// </summary>
        public double T1VoltUpperLimit = 4000;
        /// <summary>
        /// T1 电压下限
        /// 从当前步次开始时刻算起，到达设定的 T1 时刻，如果此时电池电压小于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mV,有符号
        /// </summary>
        public double T1VoltLowerLimit = 2500;
        /// <summary>
        /// T2 时刻
        /// 单位 s，无符号
        /// </summary>
        public double T2Time = 5;
        /// <summary>
        /// T2 电压上限
        /// 从当前步次开始时刻算起，到达设定的 T2 时刻，如果此时电池电压大于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mV,有符号
        /// </summary>
        public double T2VoltUpperLimit = 4000;
        /// <summary>
        /// T2 电压下限
        /// 从当前步次开始时刻算起，到达设定的 T2 时刻，如果此时电池电压小于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mV,有符号
        /// </summary>
        public double T2VoltLowerLimit = 2500;
        /// <summary>
        /// CC 缺时检查
        /// 只在 CCCV 步次中检查，从当前步次起始时刻开始计时，如果恒流阶段的充电时间（CC 转 CV 时刻）小于设定时刻则保护；为 0 时无效；单位 s，无符号
        /// </summary>
        public int CCLackTime = 60;
        /// <summary>
        /// CC 超时检查
        /// 只在 CCCV 步次中检查，从当前步次起始时刻开始计时，如果到达设定时刻时步次仍处于恒流充电阶段则保护；为 0 时无效；单位 s，无符号
        /// </summary>
        public int CCOverTime = 36000;
        /// <summary>
        /// T5 时刻
        /// 单位 s，无符号
        /// </summary>
        public int T5Time = 5;
        /// <summary>
        /// T5 电流上限
        /// 从当前步次开始时刻算起，到达设定的 T5 时刻，如果此时电流大于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mA,有符号
        /// </summary>
        public double T5CurreUpperLimit = 5000;
        /// <summary>
        /// T5 电流下限
        /// 从当前步次开始时刻算起，到达设定的 T5 时刻，如果此时电流小于设定保护值时起保护，每个流程只在第一个充电步次中检查；单位 mA,有符号
        /// </summary>
        public double T5CurreLowerLimit = 2000;
        /// <summary>
        /// 充电恒压时，电压偏差范围
        /// 恒压时，电压大于（恒压值+偏差）或者小于(恒压值-偏差)时起保护；单位 mV,有符号
        /// </summary>
        public double ConstVoltDeviate = 200;
        /// <summary>
        /// 恒压电流上升保护（上升幅度）
        /// 恒压时检测电流是否有上升，根据相邻两次采样电流来判断电流是否上升：如果（当前电流 – 前一次电流） > 设定幅度，则代表电流上升，记为1 次；单位 mA,有符号
        /// </summary>
        public double CurreRiseLimit = 200;
        /// <summary>
        /// 恒压电流上升保护（累计次数）
        /// 当前步次中，当电流上升次数累计达到设定次数时起保护，只在恒压阶段判断；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public int CurreRiseCumulateCount = 8;
        /// <summary>
        /// 恒压电流上升保护（连续次数）
        /// 当前步次中，当电流上升连续达到设定次数时起保护，只在恒压阶段判断；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public int CurreRiseContinueCount = 5;
        /// <summary>
        /// 充电电压下降（下降幅度）
        /// 检测充电过程中是否有电压下降，根据相邻两次采样电压来判断是否有电压下降发生，如果（前一次电压 – 当前电压） > 设定幅度，则代表电压下降，记为 1 次；单位 mV,有符号
        /// </summary>
        public double VoltDropLimit = 100;
        /// <summary>
        /// 充电电压下降（累计次数）
        /// 当前步次中，当电压下降次数累计达到设定次数时起保护；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public int VoltDropCumulateCount = 5;
        /// <summary>
        /// 充电电压下降（连续次数）
        /// 当前步次中，当电压下降连续次数达到设定次数时起保护；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public int VoltDropContinueCount = 3;
        /// <summary>
        /// 充电限制时间
        /// 充电的限制时间，超过设定值时起保护；单位 s，无符号
        /// </summary>
        public int TimeLimit = 36000;
        /// <summary>
        /// 充电电压未上升保护（间隔时间）
        /// 在恒流充电阶段判断：根据设定的间隔时间取电压值，如果本次取的电压值减去上一次取的电压值小于设定值时，则认为充电异常需要保护；单位 s，无符号
        /// </summary>
        public int NoVoltRiseTime = 10;
        /// <summary>
        /// 充电电压未上升保护（电压幅值）
        /// 在恒流充电阶段判断：根据设定的间隔时间取电压值，如果本次取的电压值减去上一次取的电压值小于设定值时，则认为充电异常需要保护，单位 mV,  有符号
        /// </summary>
        public double NoVoltRiseLimit = 1;
        /// <summary>
        /// 恒压时电流突升
        /// 恒压时检测电流是否有突升，根据相邻两次采样电流来判断电流是否突升：如果（当前电流 – 前一次电流） > 设定幅度，则代表电流突升，此时起保护；单位 mA,  有符号
        /// </summary>
        public double CurreSwell = 100;
        /// <summary>
        /// 充电电压过上升保护（间隔时间）
        /// 在恒流充电阶段判断：根据设定的间隔时间取电压值，如果本次取的电压值减去上一次取的电压值大于设定值时，则认为充电异常需要保护；单位 s，无符号
        /// </summary>
        public int SwellVoltRiseTime = 10;
        /// <summary>
        /// 充电电压过上升保护（电压幅值）
        /// 在恒流充电阶段判断：根据设定的间隔时间取电压值，如果本次取的电压值减去上一次取的电压值大于设定值时，则认为充电异常需要保护；单位 mV, 有符号
        /// </summary>
        public double SwellVoltRiseLimit = 300;
        /// <summary>
        /// 充电下限电压
        /// 充电时电池电压小于设定保护值时起保护；单位 mV,  有符号
        /// </summary>
        public double VoltLowerLimit = 100;

        public TChargeProtect()
        {
            for (int i = 0; i < 32; i++)
                IsValidFlag[i] = false;

            /// bit0 保护项 1：充电上限电压
            IsValidFlag[0] = true;
            /// bit1 保护项 2：充电上限容量
            IsValidFlag[1] = true;
            /// bit3 保护项 3：充电检查（电压下限）
            IsValidFlag[3] = true;
            /// bit4 保护项 4：充电电流下限
            IsValidFlag[4] = true;
            /// bit5 保护项 5：T1 时刻检查
            IsValidFlag[5] = false;
            /// bit8 保护项 6：T2 时刻检查
            IsValidFlag[8] = false;
            /// bit11 保护项 7：CC 缺时检查
            IsValidFlag[11] = false;
            /// bit12 保护项 8：CC 超时检查
            IsValidFlag[12] = false;
            /// bit13 保护项 9：T5 时刻检查
            IsValidFlag[13] = false;
            /// bit16 保护项 10：恒压时电压偏差范围 
            IsValidFlag[16] = true;
            /// bit18 保护项 11：恒压电流上升累计次数
            IsValidFlag[18] = true;
            /// bit19 保护项 12：恒压电流上升连续次数
            IsValidFlag[19] = true;
            /// bit21 保护项 13：充电电压下降累计次数
            IsValidFlag[21] = true;
            /// bit22 保护项 14：充电电压下降连续次数
            IsValidFlag[22] = true;
            /// bit23 保护项 15：充电限制时间
            IsValidFlag[23] = false;
            /// bit25 保护项 16：充电电压未上升保护
            IsValidFlag[25] = false;
            /// bit26 保护项 17：恒压电流突升保护
            IsValidFlag[26] = true;
            /// bit27 保护项 18：充电电压过上升保护
            IsValidFlag[27] = true;
            /// bit28 保护项 19：充电下限电压保护 
            IsValidFlag[28] = false;

        }
    }

    /// <summary>
    /// 放电保护
    /// </summary>
    [Serializable]
    public class TDisChargeProtect
    {
        /// <summary>
        /// 放电保护有效标记
        /// 每一位对应一项保护，1 表示保护项有效，0 表示保护项不起作用；
        /// bit0 保护项 1：放电下限电压
        /// bit1 保护项 2：放电限制时间
        /// bit2 保护项 3：放电下限容量
        /// bit4 保护项 4：放电电压上升累计次数
        /// bit5 保护项 5：放电电压上升连续次数
        /// bit6 保护项 6：放电上限容量
        /// bit7 保护项 7：放电电流上偏差保护
        /// Bit9 保护项 8：放电检查（电压下限）
        /// bit10 保护项 9：放电检查（电压上限）
        /// bit12 保护项 10：放电电压未下降保护
        /// bit14 保护项 11：放电电压过下降保护
        /// bit15 保护项 12：放电上限电压保护
        /// bit30 保护项 s2：串联总电压偏差保护
        /// bit31 保护项 s1：串联总电压过压保护
        /// </summary>
        public bool[] IsValidFlag = new bool[32];
        /// <summary>
        /// 放电下限电压
        /// 放电时电压的下限值，放电时电池电压小于设定保护值时起保护；单位 mV,有符号
        /// </summary>
        public double VoltLowerLimit = 1800;
        /// <summary>
        /// 放电限制时间
        /// 放电的限制时间，超过设定值时起保护；单位 s，无符号
        /// </summary>
        public int TimeLimit = 18000;
        /// <summary>
        /// 放电下限容量
        /// 在放电结束时判断，如果放电容量小于设定保护值时起保护；（每个步次的容量从 0 开始计算，放电时表示放掉了多少容量）；单位 mAh， 无符号
        /// </summary>
        public double CapacityLowerLimit = 10;
        /// <summary>
        /// 放电电压上升（上升幅度）
        /// 检测放电过程中是否有电压上升，根据相邻两次采样电压来判断是否有电压上升发生，如果（当前电压 – 前一次电压） > 设定幅度，则代表电压上升，记为 1 次；单位 mV, *100，有符号
        /// </summary>
        public double VoltRiseLimit = 100;
        /// <summary>
        /// 放电电压上升（累计次数）
        /// 当前步次中，当电压上升次数累计达到设定次数时起保护；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public int VoltRiseCumulateCount = 5;
        /// <summary>
        /// 放电电压上升（连续次数）
        /// 当前步次中，当电压上升连续次数达到设定次数时起保护；次数为 0 时此项保护不起作用；无符号
        /// </summary>
        public int VoltRiseContinueCount = 3;
        /// <summary>
        /// 放电上限容量
        /// 放电时容量大于设定的保护值时起保护；（每个步次的容量从 0 开始计算，充电时表示储存了多少容量）；单位 mAh， 无符号
        /// </summary>
        public double CapacityUpperLimit = 20000;
        /// <summary>
        /// 放电电流上偏差保护
        /// 放电时如果（电流值-恒流值）大于设定保护值时起保护，单位 mA,  有符号
        /// </summary>
        public double CurreDeviate = 100;
        /// <summary>
        /// 放电检查（检查时刻）
        /// 从当前步次起始时刻开始计时，到达设定时刻后检查电压值，如果低于设定下限或超过设定上限则保护，单位 s，无符号
        /// </summary>
        public int CheckTime = 180;
        /// <summary>
        /// 放电检查（电压下限）
        /// 从当前步次起始时刻开始计时，到达设定时刻后检查电压值，如果低于设定下限或超过设定上限则保护，单位 mV,  有符号
        /// </summary>
        public double CheckVoltLowerLimit = 2000;
        /// <summary>
        /// 放电检查（电压上限）
        /// 从当前步次起始时刻开始计时，到达设定时刻后检查电压值，如果低于设定下限或超过设定上限则保护，单位 mV,  有符号
        /// </summary>
        public double CheckVoltUpperLimit = 4200;
        /// <summary>
        /// 放电电压未下降保护（间隔时间）
        /// 在恒流放电阶段判断：根据设定的间隔时间取电压值，如果上一次取的电压值减去本次取的电压值小于设定值时，则认为放电异常需要保护；单位 s，无符号
        /// </summary>
        public int NoVoltDropTime = 60;
        /// <summary>
        /// 放电电压未下降保护（电压幅值）
        /// 在恒流放电阶段判断：根据设定的间隔时间取电压值，如果上一次取的电压值减去本次取的电压值小于设定值时，则认为放电异常需要保护；单位 mV,  有符号
        /// </summary>
        public double NoVoltDropLimit = 1;
        /// <summary>
        /// 放电电压过下降保护（间隔时间）
        /// 在恒流放电阶段判断：根据设定的间隔时间取电压值，如果上一次取的电压值减去本次取的电压值大于设定值时，则认为放电异常需要保护；单位 s，无符号
        /// </summary>
        public int SwellVoltDropTime = 10;
        /// <summary>
        /// 放电电压过下降保护（电压幅值）
        /// 在恒流放电阶段判断：根据设定的间隔时间取电压值，如果上一次取的电压值减去本次取的电压值大于设定值时，则认为放电异常需要保护；单位 mV,  有符号
        /// </summary>
        public double SwellVoltDropLimit = 200;
        /// <summary>
        /// 放电上限电压
        /// 放电时电池电压大于设定保护值时起保护；单位 mV, 有符号
        /// </summary>
        public double VoltUpperLimit = 0;
        /// <summary>
        /// 串联总电压偏差
        /// 单位 mV,  有符号
        /// </summary>
        public double ConnectVoltDeviate = 4500;
        /// <summary>
        /// 串联总电压过压
        /// 单位 mV,  有符号
        /// </summary>
        public double ConnectVoltToolarge = 0;

        public TDisChargeProtect()
        {
            for (int i = 0; i < 32; i++)
                IsValidFlag[i] = false;
            /// bit0 保护项 1：放电下限电压
            IsValidFlag[0] = true;
            /// bit1 保护项 2：放电限制时间
            IsValidFlag[1] = true;
            /// bit2 保护项 3：放电下限容量
            IsValidFlag[2] = false;
            /// bit4 保护项 4：放电电压上升累计次数
            IsValidFlag[4] = true;
            /// bit5 保护项 5：放电电压上升连续次数
            IsValidFlag[5] = true;
            /// bit6 保护项 6：放电上限容量
            IsValidFlag[6] = true;
            /// bit7 保护项 7：放电电流上偏差保护
            IsValidFlag[7] = true;
            /// Bit9 保护项 8：放电检查（电压下限）
            IsValidFlag[9] = false;
            /// bit10 保护项 9：放电检查（电压上限）
            IsValidFlag[10] = false;
            /// bit12 保护项 10：放电电压未下降保护
            IsValidFlag[12] = false;
            /// bit14 保护项 11：放电电压过下降保护
            IsValidFlag[14] = false;
            /// bit15 保护项 12：放电上限电压保护
            IsValidFlag[15] = false;
            /// bit30 保护项 s2：串联总电压偏差保护
            IsValidFlag[30] = false;
            /// bit31 保护项 s1：串联总电压过压保护
            IsValidFlag[31] = false;

        }
    }

    /// <summary>
    /// 通用保护
    /// </summary>
    [Serializable]
    public class TCommonProtect
    {
        /// <summary>
        /// 通用保护有效标记
        /// 每一位对应一项保护，1 表示保护项有效，0 表示
        /// 保护项不起作用；
        /// bit0  保护项 1：恒流波动保护
        /// bit1  保护项 2：过流保护
        /// bit2  保护项 3：休眠回路电流保护
        /// bit3  保护项 4：电池电压过压保护
        /// bit4  保护项 5：电流线电压过压保护
        /// bit5  保护项 6：充放电时电压差值保护
        /// bit6  保护项 7：休眠时电压差值保护
        /// bit7  保护项 8：接触阻抗保护
        /// bit8  保护项 9：电压突降保护
        /// Bit9  保护项 10：电池温度下限报警保护
        /// Bit10 保护项 11：电池温度上限报警保护
        /// Bit11 保护项 12：容量上限保护
        /// Bit12 保护项 13：急停电压保护（上限）
        /// Bit13 保护项 14：T 时刻电压保护
        /// Bit14 保护项 15：通道板温度报警保护
        /// Bit16 保护项 17：休眠电压上限保护
        /// Bit18 保护项 18：恒流间隔波动
        /// Bit20 保护项 19：休眠步次电压异常波动
        /// Bit21 保护项 20：电池电压欠压保护
        /// Bit22 保护项 21：恒流上偏差保护
        /// Bit23 保护项 22：恒流下偏差保护
        /// Bit24 保护项 23：反接电压保护
        /// Bit25 保护项 24：温升速率保护
        /// </summary>
        public bool[] IsValidFlag = new bool[32];
        /// <summary>
        /// 恒流波动保护
        /// 在恒流阶段，当电流大于（恒流值+波动值）时起保护（0xDB）；
        /// 在恒流阶段，当电流小于（恒流值-波动值）时起保护（0xDF）；
        /// 单位 mA, 有符号
        /// </summary>
        public double CurreFluctu = 500;
        /// <summary>
        /// 过流保护
        /// 流程中当电流大于设置的保护值时起保护；单位 mA,  有符号
        /// </summary>
        public double CurreToolarge = 30000;
        /// <summary>
        /// 休眠回路电流保护
        /// 在休眠步次中，如果电流大于设定保护值时起保护；单位 mA,  有符号
        /// </summary>
        public double RESTCurreUpperLimit = 6000;
        /// <summary>
        /// 电池电压过压保护
        /// 流程中当电池电压大于设置的保护值时起保护；单位 mV, 有符号
        /// </summary>
        public double CellVoltToolarge = 3900;
        /// <summary>
        /// 电流线电压过压保护
        /// 流程中当线电压大于设定保护值时起保护；单位 mV,  有符号
        /// </summary>
        public double LineVoltToolarge = 5000;
        /// <summary>
        /// 充放电时，电流线电压与池电压差值保护
        /// 充放电时，电流线电压与电池电压的差值（绝对值）大于设定保护值时起保护；单位 mV, 有符号
        /// </summary>
        public double ChargeDisCellVoltLineDvalue = 1000;
        /// <summary>
        /// 休眠时，电流线电压与电池电压差值保护
        /// 休眠时，电流线电压与电池电压的差值（绝对值）大于设定保护值时起保护；单位 mV,  有符号
        /// </summary>
        public double RESTCellLineVoltDvalue = 500;
        /// <summary>
        /// 接触阻抗保护
        /// 如果电流小于 3A（根据实际项目调整）时，接触阻抗为 0，否则接触阻抗=|线电压-电池电压|/电流，当接触阻抗大于设定保护值时起保护；单位毫欧姆，double 无符号
        /// </summary>
        public double ContactIR = 100;
        /// <summary>
        /// 电压突降保护
        /// 检测充电过程中是否有电压突降，根据相邻两次采样电压来判断是否有电压突降发生，如果（前一次电压 – 当前电压） > 设定幅度，则代表电压突降，这时起保护；单位 mV,  有符号
        /// </summary>
        public double VoltSlump = 500;
        /// <summary>
        /// 电池温度下限报警
        /// 如果电池温度低于设置的保护值时起保护；单位度, 有符号
        /// </summary>
        public double CellTempLowerLimit = 0;
        /// <summary>
        /// 电池温度上限报警
        /// 如果电池温度高于设置的保护值时起保护；单位度, 有符号
        /// </summary>
        public double CellTempUpperLimit = 70;
        /// <summary>
        /// 容量上限保护
        /// 流程中容量的上限，超过则起保护；单位 mAh， 无符号
        /// </summary>
        public double CapacityUpperLimit = 20000;
        /// <summary>
        /// 急停电压保护（上限）
        /// 全局电压上限保护，当电池电压大于等于设定的保护值时起保护，并且所有通道停止工作，状态为暂停；单位 mV, 有符号
        /// </summary>
        public double EmgStopVoltUpperLimit = 4000;
        /// <summary>
        /// T 时刻
        /// 从流程开始时刻算起；单位 s，无符号
        /// </summary>
        public int TTime = 20;
        /// <summary>
        /// T 时刻电压上限
        /// 从流程开始时刻算起，到达设定的 T 时刻，如果此时电池电压大于设定保护值时起保护；单位 mV, 有符号
        /// </summary>
        public double TVoltUpperLimit = 4500;
        /// <summary>
        /// T 时刻电压下限
        /// 从流程开始时刻算起，到达设定的 T 时刻，如果此时电池电压小于设定保护值时起保护；单位 mV, 有符号
        /// </summary>
        public double TVoltLowerLimit = 2000;
        /// <summary>
        /// 通道板温度报警
        /// 如果通道板温度高于设置的保护值时起保护单位度,  有符号
        /// </summary>
        public double PosTempUpperLimit = 80;
        /// <summary>
        /// 休眠电压上限
        /// 休眠时，电压超过设定值则保护，单位 mV, 有符号
        /// </summary>
        public double RESTVoltUpperLimit = 4800;
        /// <summary>
        /// 恒流间隔波动（间隔时间）
        /// 在恒流阶段检查，根据设定的间隔时间取电流值，如果相邻两次差值的绝对值大于设定波动值时则保护，为 0 时无效单位 s，无符号 
        /// </summary>
        public int CurreIntervalFluctuTime = 10;
        /// <summary>
        /// 恒流间隔波动（波动值）
        /// 在恒流阶段检查，根据设定的间隔时间取电流值，如果相邻两次差值的绝对值大于设定波动值时则保护，为 0 时无效单位 mA, 有符号
        /// </summary>
        public double CurreIntervalFluctu = 200;
        /// <summary>
        /// 休眠步次电压异常波动保护（延时时间）
        /// 休眠步次中，等待一段延时后（待充放电结束电压稳定），根据相邻两次采样电压来判断是否有电压上升发生，如果 |当前电压 – 前一次电压| >设定幅度则保护；单位 s，无符号
        /// </summary>
        public int VoltIntervalFluctuTime = 10;
        /// <summary>
        /// 休眠步次电压异常波动保护（检测幅值）
        /// 休眠步次中，等待一段延时后（待充放电结束电压稳定），根据相邻两次采样电压来判断是否有电压上升发生，如果 |当前电压 – 前一次电压| >设定幅度则保护；单位 mV,  ，有符号
        /// </summary>
        public double VoltIntervalFluctu = 100;
        /// <summary>
        /// 电池电压欠压保护
        /// 流程中当电池电压小于设置的保护值时起保护；单位 mV,  有符号
        /// </summary>
        public double CellUnderVolt = 2000;
        /// <summary>
        /// 恒流上偏差保护
        /// 在恒流阶段，当电流大于（恒流值+上偏差值）时起保护（0xDB）；
        /// </summary>
        public double CurreDeviateUpper = 500;
        /// <summary>
        /// 恒流下偏差保护
        /// 在恒流阶段，当电流小于（恒流值-下偏差值）时起保护（0xDF）；单位 mA, 有符号
        /// </summary>
        public double CurreDeviateLower = 500;
        /// <summary>
        /// 反接电压保护
        /// 反接电压最小值，低于则保护，单位 mV,  有符号
        /// </summary>
        public double InsteadVolt = 500;
        /// <summary>
        /// 温升速率 (间隔时间)
        /// 根据设定的间隔时间取电池温度，如果本次取的电池温度减去上一次取的电池温度大于设定值时，则认为电池温度上升速度异常需要保护:单位 s，无符号
        /// </summary>
        public int TempRiseTime = 5;
        /// <summary>
        /// 温升速率(电池温度幅值)
        /// 根据设定的间隔时间取电池温度，如果本次取的电池温度减去上一次取的电池温度大于设定值时，则认为电池温度上升速度异常需要保护:单位度.*100，有符号
        /// </summary>
        public double TempRiseValue = 5;


        public TCommonProtect()
        {
            for (int i = 0; i < 32; i++)
                IsValidFlag[i] = false;
            /// bit0  保护项 1：恒流波动保护
            IsValidFlag[0] = true;
            /// bit1  保护项 2：过流保护
            IsValidFlag[1] = true;
            /// bit2  保护项 3：休眠回路电流保护
            IsValidFlag[2] = false;
            /// bit3  保护项 4：电池电压过压保护
            IsValidFlag[3] = true;
            /// bit4  保护项 5：电流线电压过压保护
            IsValidFlag[4] = false;
            /// bit5  保护项 6：充放电时电压差值保护
            IsValidFlag[5] = true;
            /// bit6  保护项 7：休眠时电压差值保护
            IsValidFlag[6] = true;
            /// bit7  保护项 8：接触阻抗保护
            IsValidFlag[7] = false;
            /// bit8  保护项 9：电压突降保护
            IsValidFlag[8] = false;
            /// Bit9  保护项 10：电池温度下限报警保护
            IsValidFlag[9] = true;
            /// Bit10 保护项 11：电池温度上限报警保护
            IsValidFlag[10] = false;
            /// Bit11 保护项 12：容量上限保护
            IsValidFlag[11] = true;
            /// Bit12 保护项 13：急停电压保护（上限）
            IsValidFlag[12] = true;
            /// Bit13 保护项 14：T 时刻电压保护
            IsValidFlag[13] = false;
            /// Bit14 保护项 15：通道板温度报警保护
            IsValidFlag[14] = true;
            /// Bit16 保护项 17：休眠电压上限保护
            IsValidFlag[16] = false;
            /// Bit18 保护项 18：恒流间隔波动
            IsValidFlag[18] = false;
            /// Bit20 保护项 19：休眠步次电压异常波动
            IsValidFlag[20] = false;
            /// Bit21 保护项 20：电池电压欠压保护
            IsValidFlag[21] = false;
            /// Bit22 保护项 21：恒流上偏差保护
            IsValidFlag[22] = true;
            /// Bit23 保护项 22：恒流下偏差保护
            IsValidFlag[23] = true;
            /// Bit24 保护项 23：反接电压保护
            IsValidFlag[24] = false;
            /// Bit25 保护项 24：温升速率保护
            IsValidFlag[25] = true;
        }
    }

    /// <summary>
    /// 流程模式 
    /// </summary>
    public enum TProcessMode : byte
    {
        /// <summary>
        /// 正常流程
        /// </summary>
        [Description("TProcessMode_Normal")]
        Normal = 0x01,
        /// <summary>
        /// 校正流程
        /// </summary>
        [Description("TProcessMode_Calibration")]
        Calibration = 0x02,
        /// <summary>
        /// 计量流程
        /// </summary>
        [Description("TProcessMode_Measurement")]
        Measurement = 0x03,
    }

    /// <summary>
    /// 容量/能量计算模式 
    /// </summary>
    public enum TCapEnCalculateMode : byte
    {
        /// <summary>
        /// 每个步次从零开始计算
        /// </summary>
        [Description("TCapEnCalculateMode_StartAnew")]
        StartAnew,
        /// <summary>
        /// 步次类型相同时，累计计算
        /// </summary>
        [Description("TCapEnCalculateMode_AddUp")]
        AddUp
    }

    /// <summary>
    /// 模式选择 
    /// </summary>
    public enum TOperationMode : byte
    {
        /// <summary>
        /// 生产模式
        /// </summary>
        [Description("TOperationMode_Production")]
        Production = 0,
        /// <summary>
        /// 测试模式
        /// </summary>
        [Description("TOperationMode_Test")]
        Test = 1,
    } 

    /// <summary>
    /// 下一步模式 
    /// 该步次做完后，下位机工作方式 
    /// </summary>
    public enum TNextMode : byte
    {
        /// <summary>
        /// 继续下一步
        /// </summary>
        [Description("TNextMode_Next")]
        Next = 0x00,
        /// <summary>
        /// 暂停，等待上位机重新启动命令
        /// </summary>
        [Description("TNextMode_Suspend")]
        Suspend = 0x01,
    }


    /// <summary>
    /// 步次类型  
    /// </summary>
    public enum TStepMode : byte
    {
        /// <summary>
        /// 休眠
        /// </summary>
        [Description("TStepMode_REST")]
        REST = 0x00,
        /// <summary>
        /// 恒压充电
        /// </summary>
        [Description("TStepMode_CV")]
        CV = 0x01,
        /// <summary>
        /// 恒流放电
        /// </summary>
        [Description("TStepMode_DC")]
        DC = 0x02,
        /// <summary>
        /// 恒流充电
        /// </summary>
        [Description("TStepMode_CC")]
        CC = 0x03,
        /// <summary>
        /// 恒压放电
        /// </summary>
        [Description("TStepMode_DV")]
        DV = 0x04,
        /// <summary>
        /// 开路测试
        /// </summary>
        [Description("TStepMode_OCV")]
        OCV = 0x20,
        /// <summary>
        /// 恒功率充电
        /// </summary>
        [Description("TStepMode_CP")]
        CP = 0x31,
        /// <summary>
        /// 恒功率放电
        /// </summary>
        [Description("TStepMode_DP")]
        DP = 0x32,
        /// <summary>
        /// 跳过
        /// </summary>
        [Description("TStepMode_SKIP")]
        SKIP = 0x40,
        /// <summary>
        /// 恒流充到恒压充
        /// </summary>
        [Description("TStepMode_CCCV")]
        CCCV = 0x41,
        /// <summary>
        /// 恒流放到恒压放
        /// </summary>
        [Description("TStepMode_DCDV")]
        DCDV = 0x42,
        /// <summary>
        /// 循环步次
        /// </summary>
        [Description("TStepMode_CYCLE")]
        CYCLE = 0x80,

        /// <summary>
        /// 等待
        /// </summary>
        [Description("TStepMode_WAIT")]
        WAIT = 0xF8,
    }
}
