using CDClassLibrary.Stage;
using CDSystem.Language;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CDSystem.手动作业
{
    public partial class UserControl流程信息 : UserControl
    {
        public void Language()
        {
            Button_Delete.Text = ResourceLang.UserControl流程信息Button_DeleteText;
            Button_Insert.Text = ResourceLang.UserControl流程信息Button_InsertText;
            Button_MoveDown.Text = ResourceLang.UserControl流程信息Button_MoveDownText;
            Button_MoveUp.Text = ResourceLang.UserControl流程信息Button_MoveUpText;
            checkBox_Enabled.Text = ResourceLang.UserControl流程信息checkBox_EnabledText;
            checkBoxOCV测试.Text = ResourceLang.UserControl流程信息checkBoxOCV测试Text;
            checkBox接触测试.Text = ResourceLang.UserControl流程信息checkBox接触测试Text;
            Col步次ID.HeaderText = ResourceLang.UserControl流程信息Col步次IDHeaderText;
            Col步次类型.HeaderText = ResourceLang.UserControl流程信息Col步次类型HeaderText;
            Col单步次保护.HeaderText = ResourceLang.UserControl流程信息Col单步次保护HeaderText;
            Col电流.HeaderText = ResourceLang.UserControl流程信息Col电流HeaderText;
            Col电流上限.HeaderText = ResourceLang.UserControl流程信息Col电流上限HeaderText;
            Col电流下限.HeaderText = ResourceLang.UserControl流程信息Col电流下限HeaderText;
            Col结束电压.HeaderText = ResourceLang.UserControl流程信息Col电压HeaderText;
            Col电压上限.HeaderText = ResourceLang.UserControl流程信息Col电压上限HeaderText;
            Col电压下限.HeaderText = ResourceLang.UserControl流程信息Col电压下限HeaderText;
            Col结束电流.HeaderText = ResourceLang.UserControl流程信息Col结束电流HeaderText;
            Col结束容量.HeaderText = ResourceLang.UserControl流程信息Col结束容量HeaderText;
            Col时长.HeaderText = ResourceLang.UserControl流程信息Col时长HeaderText;
            groupBox4.Text = ResourceLang.UserControl流程信息groupBox4Text;
            groupBox充电保护.Text = ResourceLang.UserControl流程信息groupBox充电保护Text;
            groupBox放电保护.Text = ResourceLang.UserControl流程信息groupBox放电保护Text;
            groupBox通用保护.Text = ResourceLang.UserControl流程信息groupBox通用保护Text;
            label1.Text = ResourceLang.UserControl流程信息label1Text;

            TProcess Process = new();
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.VoltUpperLimit)).TitleName = ResourceLang.UserControlProtect充电保护VoltUpperLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.VoltLowerLimit)).TitleName = ResourceLang.UserControlProtect充电保护VoltLowerLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CapacityUpperLimit)).TitleName = ResourceLang.UserControlProtect充电保护CapacityUpperLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.TimeLimit)).TitleName = ResourceLang.UserControlProtect充电保护TimeLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CCLackTime)).TitleName = ResourceLang.UserControlProtect充电保护CCLackTimeTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CCOverTime)).TitleName = ResourceLang.UserControlProtect充电保护CCOverTimeTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CheckTime)).TitleName = ResourceLang.UserControlProtect充电保护CheckTimeTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CheckVoltUpperLimit)).TitleName = ResourceLang.UserControlProtect充电保护CheckVoltUpperLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CurreLowerLimit)).TitleName = ResourceLang.UserControlProtect充电保护CurreLowerLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T1Time)).TitleName = ResourceLang.UserControlProtect充电保护T1TimeTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T1VoltUpperLimit)).TitleName = ResourceLang.UserControlProtect充电保护T1VoltUpperLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T1VoltLowerLimit)).TitleName = ResourceLang.UserControlProtect充电保护T1VoltLowerLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T2Time)).TitleName = ResourceLang.UserControlProtect充电保护T2TimeTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T2VoltUpperLimit)).TitleName = ResourceLang.UserControlProtect充电保护T2VoltUpperLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T2VoltLowerLimit)).TitleName = ResourceLang.UserControlProtect充电保护T2VoltLowerLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T5Time)).TitleName = ResourceLang.UserControlProtect充电保护T5TimeTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T5CurreUpperLimit)).TitleName = ResourceLang.UserControlProtect充电保护T5CurreUpperLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T5CurreLowerLimit)).TitleName = ResourceLang.UserControlProtect充电保护T5CurreLowerLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.ConstVoltDeviate)).TitleName = ResourceLang.UserControlProtect充电保护ConstVoltDeviateTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CurreRiseLimit)).TitleName = ResourceLang.UserControlProtect充电保护CurreRiseLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CurreRiseCumulateCount)).TitleName = ResourceLang.UserControlProtect充电保护CurreRiseCumulateCountTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CurreRiseContinueCount)).TitleName = ResourceLang.UserControlProtect充电保护CurreRiseContinueCountTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.VoltDropLimit)).TitleName = ResourceLang.UserControlProtect充电保护VoltDropLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.VoltDropCumulateCount)).TitleName = ResourceLang.UserControlProtect充电保护VoltDropCumulateCountTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.VoltDropContinueCount)).TitleName = ResourceLang.UserControlProtect充电保护VoltDropContinueCountTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.NoVoltRiseTime)).TitleName = ResourceLang.UserControlProtect充电保护NoVoltRiseTimeTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.NoVoltRiseLimit)).TitleName = ResourceLang.UserControlProtect充电保护NoVoltRiseLimitTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CurreSwell)).TitleName = ResourceLang.UserControlProtect充电保护CurreSwellTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.SwellVoltRiseTime)).TitleName = ResourceLang.UserControlProtect充电保护SwellVoltRiseTimeTitleName;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.SwellVoltRiseLimit)).TitleName = ResourceLang.UserControlProtect充电保护SwellVoltRiseLimitTitleName;

            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.VoltLowerLimit)).TitleName = ResourceLang.UserControlProtect放电保护VoltLowerLimitTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.VoltUpperLimit)).TitleName = ResourceLang.UserControlProtect放电保护VoltUpperLimitTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.TimeLimit)).TitleName = ResourceLang.UserControlProtect放电保护TimeLimitTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CapacityLowerLimit)).TitleName = ResourceLang.UserControlProtect放电保护CapacityLowerLimitTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CapacityUpperLimit)).TitleName = ResourceLang.UserControlProtect放电保护CapacityUpperLimitTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.VoltRiseLimit)).TitleName = ResourceLang.UserControlProtect放电保护VoltRiseLimitTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.VoltRiseCumulateCount)).TitleName = ResourceLang.UserControlProtect放电保护VoltRiseCumulateCountTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.VoltRiseContinueCount)).TitleName = ResourceLang.UserControlProtect放电保护VoltRiseContinueCountTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CurreDeviate)).TitleName = ResourceLang.UserControlProtect放电保护CurreDeviateTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CheckTime)).TitleName = ResourceLang.UserControlProtect放电保护CheckTimeTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CheckVoltLowerLimit)).TitleName = ResourceLang.UserControlProtect放电保护CheckVoltLowerLimitTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CheckVoltUpperLimit)).TitleName = ResourceLang.UserControlProtect放电保护CheckVoltUpperLimitTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.NoVoltDropTime)).TitleName = ResourceLang.UserControlProtect放电保护NoVoltDropTimeTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.NoVoltDropLimit)).TitleName = ResourceLang.UserControlProtect放电保护NoVoltDropLimitTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.SwellVoltDropTime)).TitleName = ResourceLang.UserControlProtect放电保护SwellVoltDropTimeTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.SwellVoltDropLimit)).TitleName = ResourceLang.UserControlProtect放电保护SwellVoltDropLimitTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.ConnectVoltDeviate)).TitleName = ResourceLang.UserControlProtect放电保护ConnectVoltDeviateTitleName;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.ConnectVoltToolarge)).TitleName = ResourceLang.UserControlProtect放电保护ConnectVoltToolargeTitleName;

            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreToolarge)).TitleName = ResourceLang.UserControlProtect通用保护CurreToolargeTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CellVoltToolarge)).TitleName = ResourceLang.UserControlProtect通用保护CellVoltToolargeTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.LineVoltToolarge)).TitleName = ResourceLang.UserControlProtect通用保护LineVoltToolargeTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.RESTCurreUpperLimit)).TitleName = ResourceLang.UserControlProtect通用保护RESTCurreUpperLimitTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.ChargeDisCellVoltLineDvalue)).TitleName = ResourceLang.UserControlProtect通用保护ChargeDisCellVoltLineDvalueTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.RESTCellLineVoltDvalue)).TitleName = ResourceLang.UserControlProtect通用保护RESTCellLineVoltDvalueTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.RESTVoltUpperLimit)).TitleName = ResourceLang.UserControlProtect通用保护RESTVoltUpperLimitTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.VoltIntervalFluctuTime)).TitleName = ResourceLang.UserControlProtect通用保护VoltIntervalFluctuTimeTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.VoltIntervalFluctu)).TitleName = ResourceLang.UserControlProtect通用保护VoltIntervalFluctuTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.EmgStopVoltUpperLimit)).TitleName = ResourceLang.UserControlProtect通用保护EmgStopVoltUpperLimitTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CellUnderVolt)).TitleName = ResourceLang.UserControlProtect通用保护CellUnderVoltTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.InsteadVolt)).TitleName = ResourceLang.UserControlProtect通用保护InsteadVoltTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.VoltSlump)).TitleName = ResourceLang.UserControlProtect通用保护VoltSlumpTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CapacityUpperLimit)).TitleName = ResourceLang.UserControlProtect通用保护CapacityUpperLimitTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.ContactIR)).TitleName = ResourceLang.UserControlProtect通用保护ContactIRTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CellTempLowerLimit)).TitleName = ResourceLang.UserControlProtect通用保护CellTempLowerLimitTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CellTempUpperLimit)).TitleName = ResourceLang.UserControlProtect通用保护CellTempUpperLimitTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.PosTempUpperLimit)).TitleName = ResourceLang.UserControlProtect通用保护PosTempUpperLimitTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.TempRiseTime)).TitleName = ResourceLang.UserControlProtect通用保护TempRiseTimeTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.TempRiseValue)).TitleName = ResourceLang.UserControlProtect通用保护TempRiseValueTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.TTime)).TitleName = ResourceLang.UserControlProtect通用保护TTimeTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.TVoltUpperLimit)).TitleName = ResourceLang.UserControlProtect通用保护TVoltUpperLimitTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.TVoltLowerLimit)).TitleName = ResourceLang.UserControlProtect通用保护TVoltLowerLimitTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreFluctu)).TitleName = ResourceLang.UserControlProtect通用保护CurreFluctuTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreIntervalFluctuTime)).TitleName = ResourceLang.UserControlProtect通用保护CurreIntervalFluctuTimeTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreIntervalFluctu)).TitleName = ResourceLang.UserControlProtect通用保护CurreIntervalFluctuTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreDeviateUpper)).TitleName = ResourceLang.UserControlProtect通用保护CurreDeviateUpperTitleName;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreDeviateLower)).TitleName = ResourceLang.UserControlProtect通用保护CurreDeviateLowerTitleName;



            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.VoltUpperLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护VoltUpperLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.VoltLowerLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护VoltLowerLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CapacityUpperLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护CapacityUpperLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.TimeLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护TimeLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CCLackTime)).SetToolTip = ResourceLang.UserControlProtect充电保护CCLackTimeSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CCOverTime)).SetToolTip = ResourceLang.UserControlProtect充电保护CCOverTimeSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CheckTime)).SetToolTip = ResourceLang.UserControlProtect充电保护CheckTimeSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CheckVoltUpperLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护CheckVoltUpperLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CurreLowerLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护CurreLowerLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T1Time)).SetToolTip = ResourceLang.UserControlProtect充电保护T1TimeSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T1VoltUpperLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护T1VoltUpperLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T1VoltLowerLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护T1VoltLowerLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T2Time)).SetToolTip = ResourceLang.UserControlProtect充电保护T2TimeSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T2VoltUpperLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护T2VoltUpperLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T2VoltLowerLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护T2VoltLowerLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T5Time)).SetToolTip = ResourceLang.UserControlProtect充电保护T5TimeSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T5CurreUpperLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护T5CurreUpperLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.T5CurreLowerLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护T5CurreLowerLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.ConstVoltDeviate)).SetToolTip = ResourceLang.UserControlProtect充电保护ConstVoltDeviateSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CurreRiseLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护CurreRiseLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CurreRiseCumulateCount)).SetToolTip = ResourceLang.UserControlProtect充电保护CurreRiseCumulateCountSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CurreRiseContinueCount)).SetToolTip = ResourceLang.UserControlProtect充电保护CurreRiseContinueCountSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.VoltDropLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护VoltDropLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.VoltDropCumulateCount)).SetToolTip = ResourceLang.UserControlProtect充电保护VoltDropCumulateCountSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.VoltDropContinueCount)).SetToolTip = ResourceLang.UserControlProtect充电保护VoltDropContinueCountSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.NoVoltRiseTime)).SetToolTip = ResourceLang.UserControlProtect充电保护NoVoltRiseTimeSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.NoVoltRiseLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护NoVoltRiseLimitSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.CurreSwell)).SetToolTip = ResourceLang.UserControlProtect充电保护CurreSwellSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.SwellVoltRiseTime)).SetToolTip = ResourceLang.UserControlProtect充电保护SwellVoltRiseTimeSetToolTip;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(Process.ChargeProtect.SwellVoltRiseLimit)).SetToolTip = ResourceLang.UserControlProtect充电保护SwellVoltRiseLimitSetToolTip;

            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.VoltLowerLimit)).SetToolTip = ResourceLang.UserControlProtect放电保护VoltLowerLimitSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.VoltUpperLimit)).SetToolTip = ResourceLang.UserControlProtect放电保护VoltUpperLimitSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.TimeLimit)).SetToolTip = ResourceLang.UserControlProtect放电保护TimeLimitSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CapacityLowerLimit)).SetToolTip = ResourceLang.UserControlProtect放电保护CapacityLowerLimitSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CapacityUpperLimit)).SetToolTip = ResourceLang.UserControlProtect放电保护CapacityUpperLimitSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.VoltRiseLimit)).SetToolTip = ResourceLang.UserControlProtect放电保护VoltRiseLimitSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.VoltRiseCumulateCount)).SetToolTip = ResourceLang.UserControlProtect放电保护VoltRiseCumulateCountSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.VoltRiseContinueCount)).SetToolTip = ResourceLang.UserControlProtect放电保护VoltRiseContinueCountSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CurreDeviate)).SetToolTip = ResourceLang.UserControlProtect放电保护CurreDeviateSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CheckTime)).SetToolTip = ResourceLang.UserControlProtect放电保护CheckTimeSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CheckVoltLowerLimit)).SetToolTip = ResourceLang.UserControlProtect放电保护CheckVoltLowerLimitSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.CheckVoltUpperLimit)).SetToolTip = ResourceLang.UserControlProtect放电保护CheckVoltUpperLimitSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.NoVoltDropTime)).SetToolTip = ResourceLang.UserControlProtect放电保护NoVoltDropTimeSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.NoVoltDropLimit)).SetToolTip = ResourceLang.UserControlProtect放电保护NoVoltDropLimitSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.SwellVoltDropTime)).SetToolTip = ResourceLang.UserControlProtect放电保护SwellVoltDropTimeSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.SwellVoltDropLimit)).SetToolTip = ResourceLang.UserControlProtect放电保护SwellVoltDropLimitSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.ConnectVoltDeviate)).SetToolTip = ResourceLang.UserControlProtect放电保护ConnectVoltDeviateSetToolTip;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(Process.DisChargeProtect.ConnectVoltToolarge)).SetToolTip = ResourceLang.UserControlProtect放电保护ConnectVoltToolargeSetToolTip;

            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreToolarge)).SetToolTip = ResourceLang.UserControlProtect通用保护CurreToolargeSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CellVoltToolarge)).SetToolTip = ResourceLang.UserControlProtect通用保护CellVoltToolargeSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.LineVoltToolarge)).SetToolTip = ResourceLang.UserControlProtect通用保护LineVoltToolargeSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.RESTCurreUpperLimit)).SetToolTip = ResourceLang.UserControlProtect通用保护RESTCurreUpperLimitSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.ChargeDisCellVoltLineDvalue)).SetToolTip = ResourceLang.UserControlProtect通用保护ChargeDisCellVoltLineDvalueSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.RESTCellLineVoltDvalue)).SetToolTip = ResourceLang.UserControlProtect通用保护RESTCellLineVoltDvalueSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.RESTVoltUpperLimit)).SetToolTip = ResourceLang.UserControlProtect通用保护RESTVoltUpperLimitSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.VoltIntervalFluctuTime)).SetToolTip = ResourceLang.UserControlProtect通用保护VoltIntervalFluctuTimeSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.VoltIntervalFluctu)).SetToolTip = ResourceLang.UserControlProtect通用保护VoltIntervalFluctuSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.EmgStopVoltUpperLimit)).SetToolTip = ResourceLang.UserControlProtect通用保护EmgStopVoltUpperLimitSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CellUnderVolt)).SetToolTip = ResourceLang.UserControlProtect通用保护CellUnderVoltSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.InsteadVolt)).SetToolTip = ResourceLang.UserControlProtect通用保护InsteadVoltSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.VoltSlump)).SetToolTip = ResourceLang.UserControlProtect通用保护VoltSlumpSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CapacityUpperLimit)).SetToolTip = ResourceLang.UserControlProtect通用保护CapacityUpperLimitSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.ContactIR)).SetToolTip = ResourceLang.UserControlProtect通用保护ContactIRSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CellTempLowerLimit)).SetToolTip = ResourceLang.UserControlProtect通用保护CellTempLowerLimitSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CellTempUpperLimit)).SetToolTip = ResourceLang.UserControlProtect通用保护CellTempUpperLimitSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.PosTempUpperLimit)).SetToolTip = ResourceLang.UserControlProtect通用保护PosTempUpperLimitSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.TempRiseTime)).SetToolTip = ResourceLang.UserControlProtect通用保护TempRiseTimeSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.TempRiseValue)).SetToolTip = ResourceLang.UserControlProtect通用保护TempRiseValueSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.TTime)).SetToolTip = ResourceLang.UserControlProtect通用保护TTimeSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.TVoltUpperLimit)).SetToolTip = ResourceLang.UserControlProtect通用保护TVoltUpperLimitSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.TVoltLowerLimit)).SetToolTip = ResourceLang.UserControlProtect通用保护TVoltLowerLimitSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreFluctu)).SetToolTip = ResourceLang.UserControlProtect通用保护CurreFluctuSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreIntervalFluctuTime)).SetToolTip = ResourceLang.UserControlProtect通用保护CurreIntervalFluctuTimeSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreIntervalFluctu)).SetToolTip = ResourceLang.UserControlProtect通用保护CurreIntervalFluctuSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreDeviateUpper)).SetToolTip = ResourceLang.UserControlProtect通用保护CurreDeviateUpperSetToolTip;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(Process.CommonProtect.CurreDeviateLower)).SetToolTip = ResourceLang.UserControlProtect通用保护CurreDeviateLowerSetToolTip;


            TOCVTestSet OCVTestSet = new();
            UserControlAuxiliaryTestOCV测试.First((b) => b.AttributeName == nameof(OCVTestSet.OCVMin)).TitleName = ResourceLang.UserControlAuxiliaryTestOCV测试OCVMinTitleName;
            UserControlAuxiliaryTestOCV测试.First((b) => b.AttributeName == nameof(OCVTestSet.OCVMax)).TitleName = ResourceLang.UserControlAuxiliaryTestOCV测试OCVMaxTitleName;

            TContactTestProcess ContactTestProcess = new();
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ContactTestProcess.ProgramVolt)).TitleName = ResourceLang.UserControlAuxiliaryTest接触测试ProgramVoltTitleName;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ContactTestProcess.ProgramCurre)).TitleName = ResourceLang.UserControlAuxiliaryTest接触测试ProgramCurreTitleName;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ContactTestProcess.ContactTestTime)).TitleName = ResourceLang.UserControlAuxiliaryTest接触测试ContactTestTimeTitleName;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ContactTestProcess.DetectVolt)).TitleName = ResourceLang.UserControlAuxiliaryTest接触测试DetectVoltTitleName;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ContactTestProcess.ReverbVolta)).TitleName = ResourceLang.UserControlAuxiliaryTest接触测试ReverbVoltaTitleName;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ContactTestProcess.VoltUpperLimit)).TitleName = ResourceLang.UserControlAuxiliaryTest接触测试VoltUpperLimitTitleName;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ContactTestProcess.VoltLowerLimit)).TitleName = ResourceLang.UserControlAuxiliaryTest接触测试VoltLowerLimitTitleName;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ContactTestProcess.VoltChangeMax)).TitleName = ResourceLang.UserControlAuxiliaryTest接触测试VoltChangeMaxTitleName;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ContactTestProcess.VoltChangeMin)).TitleName = ResourceLang.UserControlAuxiliaryTest接触测试VoltChangeMinTitleName;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ContactTestProcess.CurreDeviatePercent)).TitleName = ResourceLang.UserControlAuxiliaryTest接触测试CurreDeviatePercentTitleName;
        }

        const int stepCount = 100;

        string ProcessName = "";

        private readonly List<UserControlProtect> UserControlProtect充电保护 = new();
        private readonly List<UserControlProtect> UserControlProtect放电保护 = new();
        private readonly List<UserControlProtect> UserControlProtect通用保护 = new();

        private readonly List<UserControlAuxiliaryTest> UserControlAuxiliaryTestOCV测试 = new();
        private readonly List<UserControlAuxiliaryTest> UserControlAuxiliaryTest接触测试 = new();

        public UserControl流程信息()
        {
            InitializeComponent();

            numericUpDown_DeviceNGLimit.Maximum = GlobalDefine.CHANNELS;

            StepViewShow();
            AuxiliaryViewShow();
            ProtectViewShow();
        }

        public void Power(bool IsUpdate)
        {
            Button_Delete.Visible = IsUpdate;
            Button_Insert.Visible = IsUpdate;
            Button_Copy.Visible = IsUpdate;
            Button_Paste.Visible = IsUpdate;
            Button_MoveDown.Visible = IsUpdate;
            Button_MoveUp.Visible = IsUpdate;
            contextMenuStrip1.Enabled = IsUpdate;
            checkBox_Enabled.Enabled = IsUpdate;
            radioButton_NoRetest.Enabled = IsUpdate;
            radioButton_Retest.Enabled = IsUpdate;
            numericUpDown_DeviceNGLimit.Enabled = IsUpdate;
            tableLayoutPanel其他.Enabled = IsUpdate;
            dataGridView_Step.ReadOnly = !IsUpdate;
            Col步次ID.ReadOnly = true;
            Col时长.ReadOnly = true;
        }

        private void StepViewShow()
        {
            dataGridView_Step.Rows.Add(stepCount);
            Col单步次保护.HeaderCell.Style.BackColor = Color.DeepPink;
            Col电压下限.HeaderCell.Style.BackColor = Color.DeepPink;
            Col电压上限.HeaderCell.Style.BackColor = Color.DeepPink;
            Col电流下限.HeaderCell.Style.BackColor = Color.DeepPink;
            Col电流上限.HeaderCell.Style.BackColor = Color.DeepPink;
            Col容量下限.HeaderCell.Style.BackColor = Color.DeepPink;
            Col容量上限.HeaderCell.Style.BackColor = Color.DeepPink;

            for (int i = 0; i < stepCount; i++)
            {
                dataGridView_Step.Rows[i].Cells["Col步次ID"].Value = (i + 1).ToString("000");
                dataGridView_Step.Rows[i].Cells["Col步次类型"].Value = "SKIP";
                dataGridView_Step.Rows[i].Cells["Col结束电压"].Value = 0;
                dataGridView_Step.Rows[i].Cells["Col电流"].Value = 0;
                dataGridView_Step.Rows[i].Cells["Col时长"].Value = "00:00:00";
                dataGridView_Step.Rows[i].Cells["Col结束电流"].Value = 0;
                dataGridView_Step.Rows[i].Cells["Col结束容量"].Value = 0;

                dataGridView_Step.Rows[i].Cells["Col单步次保护"].Value = false;
                dataGridView_Step.Rows[i].Cells["Col电压下限"].Value = 0;
                dataGridView_Step.Rows[i].Cells["Col电压上限"].Value = 0;
                dataGridView_Step.Rows[i].Cells["Col电流下限"].Value = 0;
                dataGridView_Step.Rows[i].Cells["Col电流上限"].Value = 0;
                dataGridView_Step.Rows[i].Cells["Col容量下限"].Value = 0;
                dataGridView_Step.Rows[i].Cells["Col容量上限"].Value = 0;
            }
        }

        private void ProtectViewShow()
        {
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "0", IsValid = true, TitleName = "<01>充电上限电压", Unit = "mV", Value = 3800, SetToolTip = "充电时电池电压>设定保护值时起保护；单位：mV", AttributeName = "VoltUpperLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "28", IsValid = false, TitleName = "<02>充电下限电压", Unit = "mV", Value = 100, SetToolTip = "从当前步次开始时刻算起，到达设定的T1时刻，如果【当前电池电压<设定保护值】时起保护，每个流程只在第一个充电步次中检查；单位：mV", AttributeName = "VoltLowerLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "1", IsValid = true, TitleName = "<03>充电上限容量", Unit = "mAh", Value = 20000, SetToolTip = "充电时容量>设定的保护值时起保护；（每个步次的容量从0开始计算，充电时表示储存了多少容量）；单位：mAh", AttributeName = "CapacityUpperLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "23", IsValid = false, TitleName = "<04>充电限制时间", Unit = "s", Value = 36000, SetToolTip = "充电的限制时间，超过设定值时起保护；单位：s", AttributeName = "TimeLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "11", IsValid = false, TitleName = "<05>CC缺时检查", Unit = "s", Value = 60, SetToolTip = "只在CCCV步次中检查，从当前步次起始时刻开始计时，如果【恒流阶段的充电时间（CC转CV时刻）<设定时刻】则保护；为0时无效；单位：s", AttributeName = "CCLackTime" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "12", IsValid = false, TitleName = "<06>CC超时检查", Unit = "s", Value = 36000, SetToolTip = "只在CCCV步次中检查，从当前步次起始时刻开始计时，如果到达设定时刻时步次仍处于恒流充电阶段则保护；为0时无效；单位：s", AttributeName = "CCOverTime" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "3", IsValid = true, TitleName = "<07>充电检查检查时刻", Unit = "s", Value = 5, SetToolTip = "从当前步次开始时刻算起，到达设定的检查时刻，如果【当前电池电压<设定保护值】时起保护，每个流程只在第一个充电步次中检查；为0时无效；单位：s", AttributeName = "CheckTime" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "3", IsValid = true, TitleName = "<08>充电检查下限电压", Unit = "mV", Value = 2000, SetToolTip = "从当前步次开始时刻算起，到达设定的检查时刻，如果【当前电池电压<设定保护值】时起保护，每个流程只在第一个充电步次中检查；单位：mV", AttributeName = "CheckVoltUpperLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "4", IsValid = true, TitleName = "<09>充电电流下限", Unit = "mA", Value = 10, SetToolTip = "充电时如果【电流<设定保护值】时起保护；单位：mA", AttributeName = "CurreLowerLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "5", IsValid = false, TitleName = "<10>T1时刻", Unit = "s", Value = 2000, SetToolTip = "单位：s", AttributeName = "T1Time" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "5", IsValid = false, TitleName = "<11>T1电压上限", Unit = "mV", Value = 4000, SetToolTip = "从当前步次开始时刻算起，到达设定的T1时刻，如果【当前电池电压>设定保护值】时起保护，每个流程只在第一个充电步次中检查；单位：mV", AttributeName = "T1VoltUpperLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "5", IsValid = false, TitleName = "<12>T1电压下限", Unit = "mV", Value = 2500, SetToolTip = "从当前步次开始时刻算起，到达设定的T1时刻，如果【当前电池电压<设定保护值】时起保护，每个流程只在第一个充电步次中检查；单位：mV", AttributeName = "T1VoltLowerLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "8", IsValid = false, TitleName = "<13>T2时刻", Unit = "s", Value = 5, SetToolTip = "单位：s", AttributeName = "T2Time" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "8", IsValid = false, TitleName = "<14>T2电压上限", Unit = "mV", Value = 4000, SetToolTip = "从当前步次开始时刻算起，到达设定的T2时刻，如果【当前电池电压>设定保护值】时起保护，每个流程只在第一个充电步次中检查；单位：mV", AttributeName = "T2VoltUpperLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "8", IsValid = false, TitleName = "<15>T2电压下限", Unit = "mV", Value = 2500, SetToolTip = "从当前步次开始时刻算起，到达设定的T2时刻，如果【当前电池电压<设定保护值】时起保护，每个流程只在第一个充电步次中检查；单位：mV", AttributeName = "T2VoltLowerLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "13", IsValid = false, TitleName = "<16>T5时刻", Unit = "s", Value = 5, SetToolTip = "单位：s", AttributeName = "T5Time" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "13", IsValid = false, TitleName = "<17>T5电流上限", Unit = "mA", Value = 5000, SetToolTip = "从当前步次开始时刻算起，到达设定的T5时刻，如果【当前电流>设定保护值】时起保护，每个流程只在第一个充电步次中检查；单位：mA", AttributeName = "T5CurreUpperLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "13", IsValid = false, TitleName = "<18>T5电流下限", Unit = "mA", Value = 2000, SetToolTip = "从当前步次开始时刻算起，到达设定的T5时刻，如果【当前电流<设定保护值】时起保护，每个流程只在第一个充电步次中检查；单位：mA", AttributeName = "T5CurreLowerLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "16", IsValid = true, TitleName = "<19>充电恒压时电压偏差范围", Unit = "mV", Value = 200, SetToolTip = "恒压时，【电压>（恒压值+偏差）或者<(恒压值-偏差)】时起保护；单位：mV", AttributeName = "ConstVoltDeviate" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "18、19", IsValid = true, TitleName = "<20>恒压电流上升上升幅度", Unit = "mA", Value = 200, SetToolTip = "当前步次中，当电流上升次数累计达到设定次数时起保护，只在恒压阶段判断；次数为0时此项保护不起作用", AttributeName = "CurreRiseLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "18、19", IsValid = true, TitleName = "<21>恒压电流上升累计次数", Unit = "次", Value = 8, SetToolTip = "当前步次中，当电流上升次数累计达到设定次数时起保护，只在恒压阶段判断；次数为0时此项保护不起作用", AttributeName = "CurreRiseCumulateCount" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "18、19", IsValid = true, TitleName = "<22>恒压电流上升连续次数", Unit = "次", Value = 5, SetToolTip = "当前步次中，当电流上升连续达到设定次数时起保护，只在恒压阶段判断；次数为0时此项保护不起作用", AttributeName = "CurreRiseContinueCount" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "21、22", IsValid = true, TitleName = "<23>充电电压下降幅度", Unit = "mV", Value = 100, SetToolTip = "检测充电过程中是否有电压下降，根据相邻两次采样电压来判断是否有电压下降发生，如果【（前次电压–当前电压）>设定幅度】，则代表电压下降，记为1次；单位：mV", AttributeName = "VoltDropLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "21、22", IsValid = true, TitleName = "<24>充电电压下降累计次数", Unit = "次", Value = 5, SetToolTip = "当前步次中，当电压下降次数累计达到设定次数时起保护；次数为0时此项保护不起作用", AttributeName = "VoltDropCumulateCount" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "21、22", IsValid = true, TitleName = "<25>充电电压下降连续次数", Unit = "次", Value = 3, SetToolTip = "当前步次中，当电压下降连续次数达到设定次数时起保护；次数为0时此项保护不起作用", AttributeName = "VoltDropContinueCount" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "25", IsValid = false, TitleName = "<26>充电电压未上升间隔时间", Unit = "s", Value = 10, SetToolTip = "在恒流充电阶段判断：根据设定的间隔时间取电压值，如果【（当前电压-前次电压）<设定值】时，则认为充电异常需要保护；单位：s", AttributeName = "NoVoltRiseTime" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "25", IsValid = false, TitleName = "<27>充电电压未上升电压幅值", Unit = "mV", Value = 1, SetToolTip = "在恒流充电阶段判断：根据设定的间隔时间取电压值，如果【（当前电压-前次电压）<设定值】时，则认为充电异常需要保护；单位：mV", AttributeName = "NoVoltRiseLimit" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "26", IsValid = true, TitleName = "<28>恒压时电流突升", Unit = "mA", Value = 100, SetToolTip = "恒压时检测电流是否有突升，根据相邻两次采样电流来判断电流是否突升：如果【（当前电流–前次电流）>设定幅度】，则代表电流突升，此时起保护；单位：mA", AttributeName = "CurreSwell" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "27", IsValid = true, TitleName = "<29>充电电压过上升间隔时间", Unit = "s", Value = 10, SetToolTip = "在恒流充电阶段判断：根据设定的间隔时间取电压值，如果【（当前电压-前次电压）>设定值】时，则认为充电异常需要保护；单位：s", AttributeName = "SwellVoltRiseTime" });
            UserControlProtect充电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "27", IsValid = true, TitleName = "<30>充电电压过上升电压幅值", Unit = "mV", Value = 300, SetToolTip = "在恒流充电阶段判断：根据设定的间隔时间取电压值，如果【（当前电压-前次电压）>设定值】时，则认为充电异常需要保护；单位：mV", AttributeName = "SwellVoltRiseLimit" });

            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "15", IsValid = false, TitleName = "<31>放电上限电压", Unit = "mV", Value = 4000, SetToolTip = "放电时【电池电压>设定保护值】时起保护；单位：mV", AttributeName = "VoltUpperLimit" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "0", IsValid = true, TitleName = "<32>放电下限电压", Unit = "mV", Value = 1800, SetToolTip = "放电时电压的下限值，放电时【电池电压<设定保护值】时起保护；单位：mV", AttributeName = "VoltLowerLimit" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "1", IsValid = true, TitleName = "<33>放电限制时间", Unit = "s", Value = 18000, SetToolTip = "放电的限制时间，超过设定值时起保护；单位：s", AttributeName = "TimeLimit" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "2", IsValid = false, TitleName = "<34>放电下限容量", Unit = "mAh", Value = 10, SetToolTip = "在放电结束时判断，如果【放电容量<设定保护值】时起保护；（每个步次的容量从0开始计算，放电时表示放掉了多少容量）；单位：mAh", AttributeName = "CapacityLowerLimit" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "6", IsValid = true, TitleName = "<35>放电上限容量", Unit = "mAh", Value = 20000, SetToolTip = "放电时【容量>设定的保护值】时起保护；（每个步次的容量从0开始计算，充电时表示储存了多少容量）；单位：mAh", AttributeName = "CapacityUpperLimit" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "4、5", IsValid = true, TitleName = "<36>放电电压上升上升幅度", Unit = "mV", Value = 100, SetToolTip = "检测放电过程中是否有电压上升，根据相邻两次采样电压来判断是否有电压上升发生，如果【（当前电压–前次电压）>设定幅度】，则代表电压上升，记为1次；单位：mV", AttributeName = "VoltRiseLimit" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "4、5", IsValid = true, TitleName = "<37>放电电压上升累计次数", Unit = "次", Value = 5, SetToolTip = "当前步次中，当电压上升次数累计达到设定次数时起保护；次数为0时此项保护不起作用", AttributeName = "VoltRiseCumulateCount" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "4、5", IsValid = true, TitleName = "<38>放电电压上升连续次数", Unit = "次", Value = 3, SetToolTip = "当前步次中，当电压上升连续次数达到设定次数时起保护；次数为0时此项保护不起作用", AttributeName = "VoltRiseContinueCount" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "7", IsValid = true, TitleName = "<39>放电电流上偏差", Unit = "mA", Value = 100, SetToolTip = "放电时如果【（电流值-恒流值）>设定保护值】时起保护；单位：mA", AttributeName = "CurreDeviate" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "9、10", IsValid = false, TitleName = "<40>放电检查检查时刻", Unit = "s", Value = 180, SetToolTip = "从当前步次起始时刻开始计时，到达设定时刻后检查电压值，如果低于设定下限或超过设定上限则保护；单位：s", AttributeName = "CheckTime" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "9、10", IsValid = false, TitleName = "<41>放电检查电压下限", Unit = "mV", Value = 2000, SetToolTip = "从当前步次起始时刻开始计时，到达设定时刻后检查电压值，如果低于设定下限或超过设定上限则保护；单位：mV", AttributeName = "CheckVoltLowerLimit" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "9、10", IsValid = false, TitleName = "<42>放电检查电压上限", Unit = "mV", Value = 4200, SetToolTip = "从当前步次起始时刻开始计时，到达设定时刻后检查电压值，如果低于设定下限或超过设定上限则保护；单位：mV", AttributeName = "CheckVoltUpperLimit" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "12", IsValid = false, TitleName = "<43>放电电压未下降间隔时间", Unit = "s", Value = 60, SetToolTip = "在恒流放电阶段判断：根据设定的间隔时间取电压值，如果【（前次电压-当前电压）<设定值】时，则认为放电异常需要保护；单位：s", AttributeName = "NoVoltDropTime" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "12", IsValid = false, TitleName = "<44>放电电压未下降电压幅值", Unit = "mV", Value = 1, SetToolTip = "在恒流放电阶段判断：根据设定的间隔时间取电压值，如果【（前次电压-当前电压）<设定值】时，则认为放电异常需要保护；单位：mV", AttributeName = "NoVoltDropLimit" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "14", IsValid = false, TitleName = "<45>放电电压过下降间隔时间", Unit = "s", Value = 10, SetToolTip = "在恒流放电阶段判断：根据设定的间隔时间取电压值，如果【（前次电压-当前电压）>设定值】时，则认为放电异常需要保护；单位：s", AttributeName = "SwellVoltDropTime" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "14", IsValid = false, TitleName = "<46>放电电压过下降电压幅值", Unit = "mV", Value = 200, SetToolTip = "在恒流放电阶段判断：根据设定的间隔时间取电压值，如果【（前次电压-当前电压）>设定值】时，则认为放电异常需要保护；单位：mV", AttributeName = "SwellVoltDropLimit" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "30", IsValid = false, TitleName = "<47>串联总电压偏差", Unit = "mV", Value = 4500, SetToolTip = "单位：mV", AttributeName = "ConnectVoltDeviate" });
            UserControlProtect放电保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "31", IsValid = false, TitleName = "<48>串联总电压过压", Unit = "mV", Value = 0, SetToolTip = "单位：mV", AttributeName = "ConnectVoltToolarge" });

            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "1", IsValid = true, TitleName = "<49>电池电流过流", Unit = "mA", Value = 30000, SetToolTip = "流程中当电流>设置的保护值时起保护；单位：mA", AttributeName = "CurreToolarge" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "3", IsValid = true, TitleName = "<50>电池电压过压", Unit = "mV", Value = 3900, SetToolTip = "流程中当电池电压>设置的保护值时起保护；单位：mV", AttributeName = "CellVoltToolarge" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "4", IsValid = false, TitleName = "<51>电流线电压过压", Unit = "mV", Value = 5000, SetToolTip = "流程中当线电压>设定保护值时起保护；单位：mV", AttributeName = "LineVoltToolarge" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "2", IsValid = false, TitleName = "<52>休眠回路电流", Unit = "mA", Value = 6000, SetToolTip = "在休眠步次中，如果电流>设定保护值时起保护；单位：mA", AttributeName = "RESTCurreUpperLimit" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "5", IsValid = true, TitleName = "<53>充放电时电压差值", Unit = "mV", Value = 1000, SetToolTip = "充放电时，【电流线电压与电池电压的差值（绝对值）>设定保护值时起保护】；单位：mV", AttributeName = "ChargeDisCellVoltLineDvalue" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "6", IsValid = true, TitleName = "<54>休眠电压差值", Unit = "mV", Value = 500, SetToolTip = "休眠时，【电流线电压与电池电压的差值（绝对值）>设定保护值时起保护】；单位：mV", AttributeName = "RESTCellLineVoltDvalue" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "16", IsValid = false, TitleName = "<55>休眠电压上限", Unit = "mV", Value = 4800, SetToolTip = "休眠时，电压超过设定值则保护；单位：mV", AttributeName = "RESTVoltUpperLimit" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "20", IsValid = false, TitleName = "<56>休眠步次电压异常波动延时时间", Unit = "s", Value = 10, SetToolTip = "休眠步次中，等待一段延时后（待充放电结束电压稳定），根据相邻两次采样电压来判断是否有电压上升发生，如果【（当前电压–前次电压）>设定幅度】则保护；单位：s", AttributeName = "VoltIntervalFluctuTime" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "20", IsValid = false, TitleName = "<57>休眠步次电压异常波动检测幅值", Unit = "mV", Value = 100, SetToolTip = "休眠步次中，等待一段延时后（待充放电结束电压稳定），根据相邻两次采样电压来判断是否有电压上升发生，如果【（当前电压–前次电压）>设定幅度】则保护；单位：mV", AttributeName = "VoltIntervalFluctu" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "12", IsValid = true, TitleName = "<58>急停电压上限", Unit = "mV", Value = 4000, SetToolTip = "全局电压上限保护，当电池电压>等于设定的保护值时起保护，并且所有通道停止工作，状态为暂停；单位：mV", AttributeName = "EmgStopVoltUpperLimit" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "21", IsValid = false, TitleName = "<59>电池电压欠压", Unit = "mV", Value = 2000, SetToolTip = "流程中当电池电压<设置的保护值时起保护；单位：mV", AttributeName = "CellUnderVolt" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "24", IsValid = false, TitleName = "<60>反接电压", Unit = "mV", Value = 500, SetToolTip = "反接电压最小值，低于则保护；单位：mV", AttributeName = "InsteadVolt" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "8", IsValid = false, TitleName = "<61>电压突降", Unit = "mV", Value = 500, SetToolTip = "检测充电过程中是否有电压突降，根据相邻两次采样电压来判断是否有电压突降发生，如果【（前次电压–当前电压）>设定幅度】，则代表电压突降，这时起保护；单位：mV", AttributeName = "VoltSlump" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "11", IsValid = true, TitleName = "<62>容量上限", Unit = "mAh", Value = 20000, SetToolTip = "流程中容量的上限，超过则起保护；单位：mAh", AttributeName = "CapacityUpperLimit" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "7", IsValid = false, TitleName = "<63>接触阻抗", Unit = "mΩ", Value = 100, SetToolTip = "如果【电流<3A】（根据实际项目调整）时，接触阻抗为0，否则【接触阻抗=（线电压-电池电压）/电流】，当接触阻抗>设定保护值时起保护；单位：mΩ", AttributeName = "ContactIR" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "9", IsValid = true, TitleName = "<64>电池温度下限", Unit = "℃", Value = 0, SetToolTip = "如果电池温度低于设置的保护值时起保护；单位：℃", AttributeName = "CellTempLowerLimit" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "10", IsValid = false, TitleName = "<65>电池温度上限", Unit = "℃", Value = 70, SetToolTip = "如果电池温度高于设置的保护值时起保护；单位：℃", AttributeName = "CellTempUpperLimit" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "14", IsValid = true, TitleName = "<66>通道板温度上限", Unit = "℃", Value = 80, SetToolTip = "如果通道板温度高于设置的保护值时起保护；单位：℃", AttributeName = "PosTempUpperLimit" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "25", IsValid = true, TitleName = "<67>温升速率间隔时间", Unit = "s", Value = 5, SetToolTip = "根据设定的间隔时间取电池温度，如果【（当前电池温度-前次电池温度）>设定值】时，则认为电池温度上升速度异常需要保护；单位：s", AttributeName = "TempRiseTime" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "25", IsValid = true, TitleName = "<68>温升速率电池温度幅值", Unit = "℃", Value = 5, SetToolTip = "根据设定的间隔时间取电池温度，如果【（当前电池温度-前次电池温度）>设定值】时，则认为电池温度上升速度异常需要保护；单位：℃", AttributeName = "TempRiseValue" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "13", IsValid = false, TitleName = "<69>T时刻", Unit = "s", Value = 20, SetToolTip = "从流程开始时刻算起；单位：s", AttributeName = "TTime" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "13", IsValid = false, TitleName = "<70>T时刻电压上限", Unit = "mV", Value = 4500, SetToolTip = "从流程开始时刻算起，到达设定的T时刻，如果【当前电池电压>设定保护值】时起保护；单位：mV", AttributeName = "TVoltUpperLimit" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "13", IsValid = false, TitleName = "<71>T时刻电压下限", Unit = "mV", Value = 2000, SetToolTip = "从流程开始时刻算起，到达设定的T时刻，如果【当前电池电压<设定保护值】时起保护；单位：mV", AttributeName = "TVoltLowerLimit" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "0", IsValid = true, TitleName = "<72>恒流波动", Unit = "mA", Value = 500, SetToolTip = "在恒流阶段，当【电流>（恒流值+波动值）】时起保护（0xDB）；在恒流阶段，当【电流<（恒流值-波动值）】时起保护（0xDF）；单位：mA", AttributeName = "CurreFluctu" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "18", IsValid = false, TitleName = "<73>恒流间隔波动间隔时间", Unit = "s", Value = 10, SetToolTip = "在恒流阶段检查，根据设定的间隔时间取电流值，如果【相邻两次差值的绝对值>设定波动值】时则保护，为0时无效；单位：s", AttributeName = "CurreIntervalFluctuTime" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "18", IsValid = false, TitleName = "<74>恒流间隔波动波动值", Unit = "mA", Value = 200, SetToolTip = "在恒流阶段检查，根据设定的间隔时间取电流值，如果【相邻两次差值的绝对值>设定波动值】时则保护，为0时无效；单位：mA", AttributeName = "CurreIntervalFluctu" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "22", IsValid = true, TitleName = "<75>恒流上偏差", Unit = "mA", Value = 500, SetToolTip = "在恒流阶段，当【电流>（恒流值+上偏差值）】时起保护（0xDB）；单位：mA", AttributeName = "CurreDeviateUpper" });
            UserControlProtect通用保护.Add(new UserControlProtect() { Dock = DockStyle.Fill, Group = "23", IsValid = true, TitleName = "<76>恒流下偏差", Unit = "mA", Value = 500, SetToolTip = "在恒流阶段，当【电流<（恒流值-下偏差值）】时起保护（0xDF）；单位：mA", AttributeName = "CurreDeviateLower" });

            TableLayoutPanelProtectAdd(UserControlProtect充电保护, tableLayoutPanel充电保护);
            TableLayoutPanelProtectAdd(UserControlProtect放电保护, tableLayoutPanel放电保护);
            TableLayoutPanelProtectAdd(UserControlProtect通用保护, tableLayoutPanel通用保护);
        }

        private static void TableLayoutPanelProtectAdd(List<UserControlProtect> UserControlProtect, TableLayoutPanel tableLayoutPanel)
        {
            int ColCount = 5;
            int ProtectCount = UserControlProtect.Count;
            int RowCount = ProtectCount % ColCount == 0 ? ProtectCount / ColCount : ProtectCount / ColCount + 1;

            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.RowCount = RowCount;
            for (int i = 0; i < RowCount; i++)
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            for (int i = 0; i < ProtectCount; i++)
                tableLayoutPanel.Controls.Add(UserControlProtect[i], i / RowCount, i % RowCount);
        }

        private void AuxiliaryViewShow()
        {
            UserControlAuxiliaryTestOCV测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "01、OCV测试电压下限", Unit = "mV", Value = 0, AttributeName = "OCVMin" });
            UserControlAuxiliaryTestOCV测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "02、OCV测试电压上限", Unit = "mV", Value = 0, AttributeName = "OCVMax" });

            UserControlAuxiliaryTest接触测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "01、程控电压", Unit = "mV", Value = 0, AttributeName = "ProgramVolt" });
            UserControlAuxiliaryTest接触测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "02、程控电流", Unit = "mA", Value = 0, AttributeName = "ProgramCurre" });
            UserControlAuxiliaryTest接触测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "03、接触测试时限", Unit = "s", Value = 0, AttributeName = "ContactTestTime" });
            UserControlAuxiliaryTest接触测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "04、检测电压", Unit = "mV", Value = 0, AttributeName = "DetectVolt" });
            UserControlAuxiliaryTest接触测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "05、反接电压", Unit = "mV", Value = 0, AttributeName = "ReverbVolta" });
            UserControlAuxiliaryTest接触测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "06、电压上限", Unit = "mV", Value = 0, AttributeName = "VoltUpperLimit" });
            UserControlAuxiliaryTest接触测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "07、电压下限", Unit = "mV", Value = 0, AttributeName = "VoltLowerLimit" });
            UserControlAuxiliaryTest接触测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "08、电压最大变化", Unit = "mV", Value = 0, AttributeName = "VoltChangeMax" });
            UserControlAuxiliaryTest接触测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "09、电压最小变化", Unit = "mV", Value = 0, AttributeName = "VoltChangeMin" });
            UserControlAuxiliaryTest接触测试.Add(new UserControlAuxiliaryTest() { Dock = DockStyle.Fill, Group = "0", TitleName = "10、电流偏差百分比", Unit = "%", Value = 0, AttributeName = "CurreDeviatePercent" });

            TableLayoutPanelAuxiliaryTestAdd(UserControlAuxiliaryTestOCV测试, tableLayoutPanelOCV测试);
            TableLayoutPanelAuxiliaryTestAdd(UserControlAuxiliaryTest接触测试, tableLayoutPanel接触测试);
        }

        private static void TableLayoutPanelAuxiliaryTestAdd(List<UserControlAuxiliaryTest> UserControlAuxiliaryTest, TableLayoutPanel tableLayoutPanel)
        {
            int ColCount = 1;
            int ProtectCount = UserControlAuxiliaryTest.Count;
            int RowCount = ProtectCount % ColCount == 0 ? ProtectCount / ColCount : ProtectCount / ColCount + 1;

            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.RowCount = RowCount;
            for (int i = 0; i < RowCount; i++)
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            for (int i = 0; i < ProtectCount; i++)
                tableLayoutPanel.Controls.Add(UserControlAuxiliaryTest[i], i / RowCount, i % RowCount);
        }

        public void DataChange(TProcessGroup ProcessGroup)
        {
            ProcessName = ProcessGroup.ProcessName;
            for (int i = 0; i < stepCount; i++)
            {
                dataGridView_Step.Rows[i].Cells["Col步次类型"].Value = ProcessGroup.Process.ProcStepRec[i].StepMode.ToString();
                dataGridView_Step.Rows[i].Cells["Col结束电压"].Value = ProcessGroup.Process.ProcStepRec[i].Voltage;
                dataGridView_Step.Rows[i].Cells["Col电流"].Value = ProcessGroup.Process.ProcStepRec[i].Current;
                int time = ProcessGroup.Process.ProcStepRec[i].LimitTime1;
                dataGridView_Step.Rows[i].Cells["Col时长"].Value = $"{time / 3600:00}:{time % 3600 / 60:00}:{time % 60:00}";

                dataGridView_Step.Rows[i].Cells["Col结束电流"].Value = ProcessGroup.Process.ProcStepRec[i].StepMode switch
                {
                    TStepMode.CV or TStepMode.CCCV => ProcessGroup.Process.ProcStepRec[i].LimitValue,
                    TStepMode.CC or TStepMode.DC or TStepMode.DV or TStepMode.DCDV => 0,
                    _ => (object)0,
                };
                dataGridView_Step.Rows[i].Cells["Col结束容量"].Value = ProcessGroup.Process.ProcStepRec[i].EndCap;

                dataGridView_Step.Rows[i].Cells["Col单步次保护"].Value = ProcessGroup.PCProtect.StepPCProtect[i].IsValidFlag;
                dataGridView_Step.Rows[i].Cells["Col电压下限"].Value = ProcessGroup.PCProtect.StepPCProtect[i].VoltageMin;
                dataGridView_Step.Rows[i].Cells["Col电压上限"].Value = ProcessGroup.PCProtect.StepPCProtect[i].VoltageMax;
                dataGridView_Step.Rows[i].Cells["Col电流下限"].Value = ProcessGroup.PCProtect.StepPCProtect[i].CurrentMin;
                dataGridView_Step.Rows[i].Cells["Col电流上限"].Value = ProcessGroup.PCProtect.StepPCProtect[i].CurrentMax;
                dataGridView_Step.Rows[i].Cells["Col容量下限"].Value = ProcessGroup.PCProtect.StepPCProtect[i].CapacityMin;
                dataGridView_Step.Rows[i].Cells["Col容量上限"].Value = ProcessGroup.PCProtect.StepPCProtect[i].CapacityMax;
            }

            #region 保护

            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.VoltUpperLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.VoltUpperLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.VoltLowerLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.VoltLowerLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CapacityUpperLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.CapacityUpperLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.TimeLimit)).Value = ProcessGroup.Process.ChargeProtect.TimeLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CCLackTime)).Value = ProcessGroup.Process.ChargeProtect.CCLackTime;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CCOverTime)).Value = ProcessGroup.Process.ChargeProtect.CCOverTime;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CheckTime)).Value = ProcessGroup.Process.ChargeProtect.CheckTime;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CheckVoltUpperLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.CheckVoltUpperLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CurreLowerLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.CurreLowerLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T1Time)).Value = ProcessGroup.Process.ChargeProtect.T1Time;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T1VoltUpperLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.T1VoltUpperLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T1VoltLowerLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.T1VoltLowerLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T2Time)).Value = (int)ProcessGroup.Process.ChargeProtect.T2Time;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T2VoltUpperLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.T2VoltUpperLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T2VoltLowerLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.T2VoltLowerLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T5Time)).Value = ProcessGroup.Process.ChargeProtect.T5Time;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T5CurreUpperLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.T5CurreUpperLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T5CurreLowerLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.T5CurreLowerLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.ConstVoltDeviate)).Value = (int)ProcessGroup.Process.ChargeProtect.ConstVoltDeviate;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CurreRiseLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.CurreRiseLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CurreRiseCumulateCount)).Value = ProcessGroup.Process.ChargeProtect.CurreRiseCumulateCount;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CurreRiseContinueCount)).Value = ProcessGroup.Process.ChargeProtect.CurreRiseContinueCount;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.VoltDropLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.VoltDropLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.VoltDropCumulateCount)).Value = ProcessGroup.Process.ChargeProtect.VoltDropCumulateCount;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.VoltDropContinueCount)).Value = ProcessGroup.Process.ChargeProtect.VoltDropContinueCount;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.NoVoltRiseTime)).Value = ProcessGroup.Process.ChargeProtect.NoVoltRiseTime;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.NoVoltRiseLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.NoVoltRiseLimit;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CurreSwell)).Value = (int)ProcessGroup.Process.ChargeProtect.CurreSwell;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.SwellVoltRiseTime)).Value = ProcessGroup.Process.ChargeProtect.SwellVoltRiseTime;
            UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.SwellVoltRiseLimit)).Value = (int)ProcessGroup.Process.ChargeProtect.SwellVoltRiseLimit;

            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.VoltLowerLimit)).Value = (int)ProcessGroup.Process.DisChargeProtect.VoltLowerLimit;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.VoltUpperLimit)).Value = (int)ProcessGroup.Process.DisChargeProtect.VoltUpperLimit;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.TimeLimit)).Value = ProcessGroup.Process.DisChargeProtect.TimeLimit;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CapacityLowerLimit)).Value = (int)ProcessGroup.Process.DisChargeProtect.CapacityLowerLimit;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CapacityUpperLimit)).Value = (int)ProcessGroup.Process.DisChargeProtect.CapacityUpperLimit;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.VoltRiseLimit)).Value = (int)ProcessGroup.Process.DisChargeProtect.VoltRiseLimit;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.VoltRiseCumulateCount)).Value = ProcessGroup.Process.DisChargeProtect.VoltRiseCumulateCount;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.VoltRiseContinueCount)).Value = ProcessGroup.Process.DisChargeProtect.VoltRiseContinueCount;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CurreDeviate)).Value = (int)ProcessGroup.Process.DisChargeProtect.CurreDeviate;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CheckTime)).Value = ProcessGroup.Process.DisChargeProtect.CheckTime;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CheckVoltLowerLimit)).Value = (int)ProcessGroup.Process.DisChargeProtect.CheckVoltLowerLimit;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CheckVoltUpperLimit)).Value = (int)ProcessGroup.Process.DisChargeProtect.CheckVoltUpperLimit;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.NoVoltDropTime)).Value = ProcessGroup.Process.DisChargeProtect.NoVoltDropTime;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.NoVoltDropLimit)).Value = (int)ProcessGroup.Process.DisChargeProtect.NoVoltDropLimit;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.SwellVoltDropTime)).Value = ProcessGroup.Process.DisChargeProtect.SwellVoltDropTime;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.SwellVoltDropLimit)).Value = (int)ProcessGroup.Process.DisChargeProtect.SwellVoltDropLimit;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.ConnectVoltDeviate)).Value = (int)ProcessGroup.Process.DisChargeProtect.ConnectVoltDeviate;
            UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.ConnectVoltToolarge)).Value = (int)ProcessGroup.Process.DisChargeProtect.ConnectVoltToolarge;

            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreToolarge)).Value = (int)ProcessGroup.Process.CommonProtect.CurreToolarge;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CellVoltToolarge)).Value = (int)ProcessGroup.Process.CommonProtect.CellVoltToolarge;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.LineVoltToolarge)).Value = (int)ProcessGroup.Process.CommonProtect.LineVoltToolarge;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.RESTCurreUpperLimit)).Value = (int)ProcessGroup.Process.CommonProtect.RESTCurreUpperLimit;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.ChargeDisCellVoltLineDvalue)).Value = (int)ProcessGroup.Process.CommonProtect.ChargeDisCellVoltLineDvalue;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.RESTCellLineVoltDvalue)).Value = (int)ProcessGroup.Process.CommonProtect.RESTCellLineVoltDvalue;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.RESTVoltUpperLimit)).Value = (int)ProcessGroup.Process.CommonProtect.RESTVoltUpperLimit;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.VoltIntervalFluctuTime)).Value = ProcessGroup.Process.CommonProtect.VoltIntervalFluctuTime;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.VoltIntervalFluctu)).Value = (int)ProcessGroup.Process.CommonProtect.VoltIntervalFluctu;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.EmgStopVoltUpperLimit)).Value = (int)ProcessGroup.Process.CommonProtect.EmgStopVoltUpperLimit;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CellUnderVolt)).Value = (int)ProcessGroup.Process.CommonProtect.CellUnderVolt;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.InsteadVolt)).Value = (int)ProcessGroup.Process.CommonProtect.InsteadVolt;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.VoltSlump)).Value = (int)ProcessGroup.Process.CommonProtect.VoltSlump;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CapacityUpperLimit)).Value = (int)ProcessGroup.Process.CommonProtect.CapacityUpperLimit;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.ContactIR)).Value = (int)ProcessGroup.Process.CommonProtect.ContactIR;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CellTempLowerLimit)).Value = (int)ProcessGroup.Process.CommonProtect.CellTempLowerLimit;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CellTempUpperLimit)).Value = (int)ProcessGroup.Process.CommonProtect.CellTempUpperLimit;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.PosTempUpperLimit)).Value = (int)ProcessGroup.Process.CommonProtect.PosTempUpperLimit;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.TempRiseTime)).Value = ProcessGroup.Process.CommonProtect.TempRiseTime;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.TempRiseValue)).Value = (int)ProcessGroup.Process.CommonProtect.TempRiseValue;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.TTime)).Value = ProcessGroup.Process.CommonProtect.TTime;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.TVoltUpperLimit)).Value = (int)ProcessGroup.Process.CommonProtect.TVoltUpperLimit;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.TVoltLowerLimit)).Value = (int)ProcessGroup.Process.CommonProtect.TVoltLowerLimit;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreFluctu)).Value = (int)ProcessGroup.Process.CommonProtect.CurreFluctu;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreIntervalFluctuTime)).Value = ProcessGroup.Process.CommonProtect.CurreIntervalFluctuTime;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreIntervalFluctu)).Value = (int)ProcessGroup.Process.CommonProtect.CurreIntervalFluctu;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreDeviateUpper)).Value = (int)ProcessGroup.Process.CommonProtect.CurreDeviateUpper;
            UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreDeviateLower)).Value = (int)ProcessGroup.Process.CommonProtect.CurreDeviateLower;

            foreach (var userControlProtect in UserControlProtect充电保护)
                userControlProtect.IsValid = ProcessGroup.Process.ChargeProtect.IsValidFlag[int.Parse(userControlProtect.Group.Split('、')[0])];
            foreach (var userControlProtect in UserControlProtect放电保护)
                userControlProtect.IsValid = ProcessGroup.Process.DisChargeProtect.IsValidFlag[int.Parse(userControlProtect.Group.Split('、')[0])];
            foreach (var userControlProtect in UserControlProtect通用保护)
                userControlProtect.IsValid = ProcessGroup.Process.CommonProtect.IsValidFlag[int.Parse(userControlProtect.Group.Split('、')[0])];

            #endregion

            #region 辅助测试

            checkBoxOCV测试.Checked = ProcessGroup.OCVTestSet.IsOCVTest;
            tableLayoutPanelOCV测试.Enabled = ProcessGroup.OCVTestSet.IsOCVTest;
            UserControlAuxiliaryTestOCV测试.First((b) => b.AttributeName == nameof(ProcessGroup.OCVTestSet.OCVMin)).Value = ProcessGroup.OCVTestSet.OCVMin;
            UserControlAuxiliaryTestOCV测试.First((b) => b.AttributeName == nameof(ProcessGroup.OCVTestSet.OCVMax)).Value = ProcessGroup.OCVTestSet.OCVMax;

            checkBox接触测试.Checked = ProcessGroup.ContactTestProcess.IsContactTest;
            tableLayoutPanel接触测试.Enabled = ProcessGroup.ContactTestProcess.IsContactTest;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.ProgramVolt)).Value = (int)ProcessGroup.ContactTestProcess.ProgramVolt;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.ProgramCurre)).Value = (int)ProcessGroup.ContactTestProcess.ProgramCurre;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.ContactTestTime)).Value = ProcessGroup.ContactTestProcess.ContactTestTime;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.DetectVolt)).Value = (int)ProcessGroup.ContactTestProcess.DetectVolt;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.ReverbVolta)).Value = (int)ProcessGroup.ContactTestProcess.ReverbVolta;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.VoltUpperLimit)).Value = (int)ProcessGroup.ContactTestProcess.VoltUpperLimit;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.VoltLowerLimit)).Value = (int)ProcessGroup.ContactTestProcess.VoltLowerLimit;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.VoltChangeMax)).Value = (int)ProcessGroup.ContactTestProcess.VoltChangeMax;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.VoltChangeMin)).Value = (int)ProcessGroup.ContactTestProcess.VoltChangeMin;
            UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.CurreDeviatePercent)).Value = ProcessGroup.ContactTestProcess.CurreDeviatePercent;

            #endregion

            checkBox_Enabled.Checked = ProcessGroup.IsEnabled;
            radioButton_NoRetest.Checked = !ProcessGroup.IsRetest;
            radioButton_Retest.Checked = ProcessGroup.IsRetest;
            numericUpDown_DeviceNGLimit.Value = ProcessGroup.DeviceNGLimit;
        }

        public bool DataSave(out TProcessGroup ProcessGroup)
        {
            ProcessGroup = new()
            {
                ProcessName = ProcessName
            };
            bool boo = true;
            string Errar = string.Empty;
            for (int i = 0; i < stepCount; i++)
            {
                TStepMode stepMode = (TStepMode)Enum.Parse(typeof(TStepMode), dataGridView_Step.Rows[i].Cells["Col步次类型"].Value.ToString()!);
                if (stepMode != TStepMode.SKIP)
                {
                    int index = ProcessGroup.Process.StepCount;
                    ProcessGroup.Process.StepCount++;

                    ProcessGroup.Process.ProcStepRec[index].StepMode = stepMode;
                    if (int.TryParse(dataGridView_Step.Rows[i].Cells["Col结束电压"].Value.ToString(), out int Voltage))
                    {
                        ProcessGroup.Process.ProcStepRec[index].Voltage = Voltage;
                    }
                    else
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col结束电压"].Style.BackColor = Color.Red;
                        Errar += $"{i + 1}行，电压 列\r\n";
                    }

                    if (int.TryParse(dataGridView_Step.Rows[i].Cells["Col电流"].Value.ToString(), out int Current))
                    {
                        ProcessGroup.Process.ProcStepRec[index].Current = Current;
                    }
                    else
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col电流"].Style.BackColor = Color.Red;
                        Errar += $"{i + 1}行，电流 列\r\n";
                    }

                    string[] str = dataGridView_Step.Rows[i].Cells["Col时长"].Value.ToString()!.Split(':');

                    ProcessGroup.Process.ProcStepRec[i].LimitTime1 = int.Parse(str[0]) * 3600 + int.Parse(str[1]) * 60 + int.Parse(str[2]);


                    _ = int.TryParse(dataGridView_Step.Rows[i].Cells["Col结束电流"].Value.ToString(), out int LimitValue);
                    switch (stepMode)
                    {
                        case TStepMode.CV:
                        case TStepMode.CCCV:
                            ProcessGroup.Process.ProcStepRec[index].LimitValue = LimitValue;
                            break;
                        case TStepMode.CC:
                        case TStepMode.DC:
                        case TStepMode.DV:
                        case TStepMode.DCDV:
                            ProcessGroup.Process.ProcStepRec[index].LimitValue = Voltage;
                            break;
                        case TStepMode.CP:
                        case TStepMode.DP:
                            ProcessGroup.Process.ProcStepRec[index].LimitValue = 0;
                            break;
                    }
                    if (int.TryParse(dataGridView_Step.Rows[i].Cells["Col结束容量"].Value.ToString(), out int EndCap))
                    {
                        ProcessGroup.Process.ProcStepRec[index].EndCap = EndCap;
                    }
                    else
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col结束容量"].Style.BackColor = Color.Red;
                    }

                    ProcessGroup.PCProtect.StepPCProtect[index].IsValidFlag = (bool)dataGridView_Step.Rows[i].Cells["Col单步次保护"].Value;
                    if (int.TryParse(dataGridView_Step.Rows[i].Cells["Col电压下限"].Value.ToString(), out int VoltageMin))
                    {
                        ProcessGroup.PCProtect.StepPCProtect[index].VoltageMin = VoltageMin;
                    }
                    else
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col电压下限"].Style.BackColor = Color.Red;
                        Errar += $"{i + 1}行，电压下限 列\r\n";
                    }

                    if (int.TryParse(dataGridView_Step.Rows[i].Cells["Col电压上限"].Value.ToString(), out int VoltageMax))
                    {
                        ProcessGroup.PCProtect.StepPCProtect[index].VoltageMax = VoltageMax;
                    }
                    else
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col电压上限"].Style.BackColor = Color.Red;
                        Errar += $"{i + 1}行，电压上限 列\r\n";
                    }
                    if (VoltageMin > VoltageMax)
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col电压下限"].Style.BackColor = Color.Red;
                        dataGridView_Step.Rows[i].Cells["Col电压上限"].Style.BackColor = Color.Red;
                        Errar += $"{i + 1}行，电压下限  大于  电压上限\r\n";
                    }
                    if (int.TryParse(dataGridView_Step.Rows[i].Cells["Col电流下限"].Value.ToString(), out int CurrentMin))
                    {
                        ProcessGroup.PCProtect.StepPCProtect[index].CurrentMin = CurrentMin;
                    }
                    else
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col电流下限"].Style.BackColor = Color.Red;
                        Errar += $"{i + 1}行，电流下限 列\r\n";
                    }
                    if (int.TryParse(dataGridView_Step.Rows[i].Cells["Col电流上限"].Value.ToString(), out int CurrentMax))
                    {
                        ProcessGroup.PCProtect.StepPCProtect[index].CurrentMax = CurrentMax;
                    }
                    else
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col电流上限"].Style.BackColor = Color.Red;
                        Errar += $"{i + 1}行，电流上限 列\r\n";
                    }
                    if (CurrentMin > CurrentMax)
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col电流下限"].Style.BackColor = Color.Red;
                        dataGridView_Step.Rows[i].Cells["Col电流上限"].Style.BackColor = Color.Red;
                        Errar += $"{i + 1}行，电流下限  大于  电流上限\r\n";
                    }
                    if (int.TryParse(dataGridView_Step.Rows[i].Cells["Col容量下限"].Value.ToString(), out int CapMin))
                    {
                        ProcessGroup.PCProtect.StepPCProtect[index].CapacityMin = CapMin;
                    }
                    else
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col容量下限"].Style.BackColor = Color.Red;
                        Errar += $"{i + 1}行，容量下限 列\r\n";
                    }
                    if (int.TryParse(dataGridView_Step.Rows[i].Cells["Col容量上限"].Value.ToString(), out int CapMax))
                    {
                        ProcessGroup.PCProtect.StepPCProtect[index].CapacityMax = CapMax;
                    }
                    else
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col容量上限"].Style.BackColor = Color.Red;
                        Errar += $"{i + 1}行，容量上限 列\r\n";
                    }
                    if (CapMin > CapMax)
                    {
                        boo = false;
                        dataGridView_Step.Rows[i].Cells["Col容量下限"].Style.BackColor = Color.Red;
                        dataGridView_Step.Rows[i].Cells["Col容量上限"].Style.BackColor = Color.Red;
                        Errar += $"{i + 1}行，容量下限  大于  容量上限\r\n";
                    }
                }
            }

            #region 保护

            ProcessGroup.Process.ChargeProtect.VoltUpperLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.VoltUpperLimit)).Value;
            ProcessGroup.Process.ChargeProtect.VoltLowerLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.VoltLowerLimit)).Value;
            ProcessGroup.Process.ChargeProtect.CapacityUpperLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CapacityUpperLimit)).Value;
            ProcessGroup.Process.ChargeProtect.TimeLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.TimeLimit)).Value;
            ProcessGroup.Process.ChargeProtect.CCLackTime = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CCLackTime)).Value;
            ProcessGroup.Process.ChargeProtect.CCOverTime = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CCOverTime)).Value;
            ProcessGroup.Process.ChargeProtect.CheckTime = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CheckTime)).Value;
            ProcessGroup.Process.ChargeProtect.CheckVoltUpperLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CheckVoltUpperLimit)).Value;
            ProcessGroup.Process.ChargeProtect.CurreLowerLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CurreLowerLimit)).Value;
            ProcessGroup.Process.ChargeProtect.T1Time = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T1Time)).Value;
            ProcessGroup.Process.ChargeProtect.T1VoltUpperLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T1VoltUpperLimit)).Value;
            ProcessGroup.Process.ChargeProtect.T1VoltLowerLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T1VoltLowerLimit)).Value;
            ProcessGroup.Process.ChargeProtect.T2Time = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T2Time)).Value;
            ProcessGroup.Process.ChargeProtect.T2VoltUpperLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T2VoltUpperLimit)).Value;
            ProcessGroup.Process.ChargeProtect.T2VoltLowerLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T2VoltLowerLimit)).Value;
            ProcessGroup.Process.ChargeProtect.T5Time = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T5Time)).Value;
            ProcessGroup.Process.ChargeProtect.T5CurreUpperLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T5CurreUpperLimit)).Value;
            ProcessGroup.Process.ChargeProtect.T5CurreLowerLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.T5CurreLowerLimit)).Value;
            ProcessGroup.Process.ChargeProtect.ConstVoltDeviate = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.ConstVoltDeviate)).Value;
            ProcessGroup.Process.ChargeProtect.CurreRiseLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CurreRiseLimit)).Value;
            ProcessGroup.Process.ChargeProtect.CurreRiseCumulateCount = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CurreRiseCumulateCount)).Value;
            ProcessGroup.Process.ChargeProtect.CurreRiseContinueCount = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CurreRiseContinueCount)).Value;
            ProcessGroup.Process.ChargeProtect.VoltDropLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.VoltDropLimit)).Value;
            ProcessGroup.Process.ChargeProtect.VoltDropCumulateCount = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.VoltDropCumulateCount)).Value;
            ProcessGroup.Process.ChargeProtect.VoltDropContinueCount = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.VoltDropContinueCount)).Value;
            ProcessGroup.Process.ChargeProtect.NoVoltRiseTime = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.NoVoltRiseTime)).Value;
            ProcessGroup.Process.ChargeProtect.NoVoltRiseLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.NoVoltRiseLimit)).Value;
            ProcessGroup.Process.ChargeProtect.CurreSwell = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.CurreSwell)).Value;
            ProcessGroup.Process.ChargeProtect.SwellVoltRiseTime = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.SwellVoltRiseTime)).Value;
            ProcessGroup.Process.ChargeProtect.SwellVoltRiseLimit = UserControlProtect充电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.ChargeProtect.SwellVoltRiseLimit)).Value;

            ProcessGroup.Process.DisChargeProtect.VoltLowerLimit = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.VoltLowerLimit)).Value;
            ProcessGroup.Process.DisChargeProtect.VoltUpperLimit = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.VoltUpperLimit)).Value;
            ProcessGroup.Process.DisChargeProtect.TimeLimit = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.TimeLimit)).Value;
            ProcessGroup.Process.DisChargeProtect.CapacityLowerLimit = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CapacityLowerLimit)).Value;
            ProcessGroup.Process.DisChargeProtect.CapacityUpperLimit = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CapacityUpperLimit)).Value;
            ProcessGroup.Process.DisChargeProtect.VoltRiseLimit = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.VoltRiseLimit)).Value;
            ProcessGroup.Process.DisChargeProtect.VoltRiseCumulateCount = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.VoltRiseCumulateCount)).Value;
            ProcessGroup.Process.DisChargeProtect.VoltRiseContinueCount = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.VoltRiseContinueCount)).Value;
            ProcessGroup.Process.DisChargeProtect.CurreDeviate = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CurreDeviate)).Value;
            ProcessGroup.Process.DisChargeProtect.CheckTime = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CheckTime)).Value;
            ProcessGroup.Process.DisChargeProtect.CheckVoltLowerLimit = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CheckVoltLowerLimit)).Value;
            ProcessGroup.Process.DisChargeProtect.CheckVoltUpperLimit = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.CheckVoltUpperLimit)).Value;
            ProcessGroup.Process.DisChargeProtect.NoVoltDropTime = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.NoVoltDropTime)).Value;
            ProcessGroup.Process.DisChargeProtect.NoVoltDropLimit = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.NoVoltDropLimit)).Value;
            ProcessGroup.Process.DisChargeProtect.SwellVoltDropTime = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.SwellVoltDropTime)).Value;
            ProcessGroup.Process.DisChargeProtect.SwellVoltDropLimit = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.SwellVoltDropLimit)).Value;
            ProcessGroup.Process.DisChargeProtect.ConnectVoltDeviate = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.ConnectVoltDeviate)).Value;
            ProcessGroup.Process.DisChargeProtect.ConnectVoltToolarge = UserControlProtect放电保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.DisChargeProtect.ConnectVoltToolarge)).Value;

            ProcessGroup.Process.CommonProtect.CurreToolarge = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreToolarge)).Value;
            ProcessGroup.Process.CommonProtect.CellVoltToolarge = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CellVoltToolarge)).Value;
            ProcessGroup.Process.CommonProtect.LineVoltToolarge = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.LineVoltToolarge)).Value;
            ProcessGroup.Process.CommonProtect.RESTCurreUpperLimit = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.RESTCurreUpperLimit)).Value;
            ProcessGroup.Process.CommonProtect.ChargeDisCellVoltLineDvalue = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.ChargeDisCellVoltLineDvalue)).Value;
            ProcessGroup.Process.CommonProtect.RESTCellLineVoltDvalue = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.RESTCellLineVoltDvalue)).Value;
            ProcessGroup.Process.CommonProtect.RESTVoltUpperLimit = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.RESTVoltUpperLimit)).Value;
            ProcessGroup.Process.CommonProtect.VoltIntervalFluctuTime = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.VoltIntervalFluctuTime)).Value;
            ProcessGroup.Process.CommonProtect.VoltIntervalFluctu = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.VoltIntervalFluctu)).Value;
            ProcessGroup.Process.CommonProtect.EmgStopVoltUpperLimit = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.EmgStopVoltUpperLimit)).Value;
            ProcessGroup.Process.CommonProtect.CellUnderVolt = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CellUnderVolt)).Value;
            ProcessGroup.Process.CommonProtect.InsteadVolt = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.InsteadVolt)).Value;
            ProcessGroup.Process.CommonProtect.VoltSlump = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.VoltSlump)).Value;
            ProcessGroup.Process.CommonProtect.CapacityUpperLimit = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CapacityUpperLimit)).Value;
            ProcessGroup.Process.CommonProtect.ContactIR = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.ContactIR)).Value;
            ProcessGroup.Process.CommonProtect.CellTempLowerLimit = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CellTempLowerLimit)).Value;
            ProcessGroup.Process.CommonProtect.CellTempUpperLimit = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CellTempUpperLimit)).Value;
            ProcessGroup.Process.CommonProtect.PosTempUpperLimit = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.PosTempUpperLimit)).Value;
            ProcessGroup.Process.CommonProtect.TempRiseTime = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.TempRiseTime)).Value;
            ProcessGroup.Process.CommonProtect.TempRiseValue = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.TempRiseValue)).Value;
            ProcessGroup.Process.CommonProtect.TTime = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.TTime)).Value;
            ProcessGroup.Process.CommonProtect.TVoltUpperLimit = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.TVoltUpperLimit)).Value;
            ProcessGroup.Process.CommonProtect.TVoltLowerLimit = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.TVoltLowerLimit)).Value;
            ProcessGroup.Process.CommonProtect.CurreFluctu = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreFluctu)).Value;
            ProcessGroup.Process.CommonProtect.CurreIntervalFluctuTime = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreIntervalFluctuTime)).Value;
            ProcessGroup.Process.CommonProtect.CurreIntervalFluctu = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreIntervalFluctu)).Value;
            ProcessGroup.Process.CommonProtect.CurreDeviateUpper = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreDeviateUpper)).Value;
            ProcessGroup.Process.CommonProtect.CurreDeviateLower = UserControlProtect通用保护.First((b) => b.AttributeName == nameof(ProcessGroup.Process.CommonProtect.CurreDeviateLower)).Value;

            foreach (var userControlProtect in UserControlProtect充电保护)
            {
                string[] index = userControlProtect.Group.Split('、');
                foreach (var item in index)
                {
                    ProcessGroup.Process.ChargeProtect.IsValidFlag[int.Parse(item)] = userControlProtect.IsValid;
                }
            }
            foreach (var userControlProtect in UserControlProtect放电保护)
            {
                string[] index = userControlProtect.Group.Split('、');
                foreach (var item in index)
                {
                    ProcessGroup.Process.DisChargeProtect.IsValidFlag[int.Parse(item)] = userControlProtect.IsValid;
                }
            }
            foreach (var userControlProtect in UserControlProtect通用保护)
            {
                string[] index = userControlProtect.Group.Split('、');
                foreach (var item in index)
                {
                    ProcessGroup.Process.CommonProtect.IsValidFlag[int.Parse(item)] = userControlProtect.IsValid;
                }
            }

            #endregion

            #region 辅助测试

            ProcessGroup.OCVTestSet.IsOCVTest = checkBoxOCV测试.Checked;
            ProcessGroup.OCVTestSet.OCVMin = UserControlAuxiliaryTestOCV测试.First((b) => b.AttributeName == nameof(ProcessGroup.OCVTestSet.OCVMin)).Value;
            ProcessGroup.OCVTestSet.OCVMax = UserControlAuxiliaryTestOCV测试.First((b) => b.AttributeName == nameof(ProcessGroup.OCVTestSet.OCVMax)).Value;

            ProcessGroup.ContactTestProcess.IsContactTest = checkBox接触测试.Checked;
            ProcessGroup.ContactTestProcess.ProgramVolt = UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.ProgramVolt)).Value;
            ProcessGroup.ContactTestProcess.ProgramCurre = UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.ProgramCurre)).Value;
            ProcessGroup.ContactTestProcess.ContactTestTime = UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.ContactTestTime)).Value;
            ProcessGroup.ContactTestProcess.DetectVolt = UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.DetectVolt)).Value;
            ProcessGroup.ContactTestProcess.ReverbVolta = UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.ReverbVolta)).Value;
            ProcessGroup.ContactTestProcess.VoltUpperLimit = UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.VoltUpperLimit)).Value;
            ProcessGroup.ContactTestProcess.VoltLowerLimit = UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.VoltLowerLimit)).Value;
            ProcessGroup.ContactTestProcess.VoltChangeMax = UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.VoltChangeMax)).Value;
            ProcessGroup.ContactTestProcess.VoltChangeMin = UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.VoltChangeMin)).Value;
            ProcessGroup.ContactTestProcess.CurreDeviatePercent = UserControlAuxiliaryTest接触测试.First((b) => b.AttributeName == nameof(ProcessGroup.ContactTestProcess.CurreDeviatePercent)).Value;

            #endregion

            ProcessGroup.IsEnabled = checkBox_Enabled.Checked;
            ProcessGroup.IsRetest = radioButton_Retest.Checked;
            ProcessGroup.DeviceNGLimit = (int)numericUpDown_DeviceNGLimit.Value;

            DataChange(ProcessGroup);
            if (!boo)
                MessageBox.Show("输入参数有错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return boo;
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView_Step.SelectedCells[0].RowIndex;
            if (RowIndex >= 0)
            {
                dataGridView_Step.Rows.RemoveAt(RowIndex);

                int x = dataGridView_Step.Rows.Add();
                dataGridView_Step.Rows[x].Cells["Col步次ID"].Value = (x + 1).ToString("000");
                dataGridView_Step.Rows[x].Cells["Col步次类型"].Value = "SKIP";
                dataGridView_Step.Rows[x].Cells["Col结束电压"].Value = 0;
                dataGridView_Step.Rows[x].Cells["Col电流"].Value = 0;
                dataGridView_Step.Rows[x].Cells["Col时长"].Value = "00:00:00";
                dataGridView_Step.Rows[x].Cells["Col结束电流"].Value = 0;
                dataGridView_Step.Rows[x].Cells["Col结束容量"].Value = 0;

                dataGridView_Step.Rows[x].Cells["Col单步次保护"].Value = false;
                dataGridView_Step.Rows[x].Cells["Col电压下限"].Value = 0;
                dataGridView_Step.Rows[x].Cells["Col电压上限"].Value = 0;
                dataGridView_Step.Rows[x].Cells["Col电流下限"].Value = 0;
                dataGridView_Step.Rows[x].Cells["Col电流上限"].Value = 0;
                dataGridView_Step.Rows[x].Cells["Col容量下限"].Value = 0;
                dataGridView_Step.Rows[x].Cells["Col容量上限"].Value = 0;

                for (int i = RowIndex; i < dataGridView_Step.Rows.Count; i++)
                {
                    dataGridView_Step.Rows[i].Cells[0].Value = (i + 1).ToString("000");
                }
            }
        }

        private void Button_Insert_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView_Step.SelectedCells[0].RowIndex;
            if (RowIndex >= 0)
            {
                dataGridView_Step.Rows.Insert(RowIndex);

                dataGridView_Step.Rows[RowIndex].Cells["Col步次ID"].Value = (RowIndex + 1).ToString("000");
                dataGridView_Step.Rows[RowIndex].Cells["Col步次类型"].Value = "SKIP";
                dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col电流"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col时长"].Value = "00:00:00";
                dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].Value = 0;

                dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].Value = false;
                dataGridView_Step.Rows[RowIndex].Cells["Col电压下限"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col电压上限"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col电流下限"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col电流上限"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col容量下限"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col容量上限"].Value = 0;

                dataGridView_Step.Rows.RemoveAt(dataGridView_Step.Rows.Count - 1);

                for (int i = RowIndex; i < dataGridView_Step.Rows.Count; i++)
                {
                    dataGridView_Step.Rows[i].Cells[0].Value = (i + 1).ToString("000");
                }
            }
        }

        List<Object> listrowCopy = new List<Object>();
        private void Button_Copy_Click(object sender, EventArgs e)
        {
            listrowCopy.Clear();
            int RowIndex = dataGridView_Step.SelectedCells[0].RowIndex;
            for (int i = 0; i < dataGridView_Step.Columns.Count; i++)
            {
                listrowCopy.Add(dataGridView_Step.Rows[RowIndex].Cells[i].Value);
            }
        }

        private void Button_Paste_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView_Step.SelectedCells[0].RowIndex;
            if (RowIndex >= 0)
            {
                dataGridView_Step.Rows.Insert(RowIndex);

                for (int i = 1; i < dataGridView_Step.Columns.Count; i++)
                {
                    dataGridView_Step.Rows[RowIndex].Cells[i].Value = listrowCopy[i];
                }
                dataGridView_Step.ClearSelection();
                dataGridView_Step.Rows.RemoveAt(dataGridView_Step.Rows.Count - 1);

                for (int i = RowIndex; i < dataGridView_Step.Rows.Count; i++)
                {
                    dataGridView_Step.Rows[i].Cells[0].Value = (i + 1).ToString("000");
                }
                dataGridView_Step.Rows[RowIndex].Cells[0].Selected = true;
            }
        }

        private void Button_MoveUp_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView_Step.SelectedCells[0].RowIndex;
            int ColumnIndex = dataGridView_Step.SelectedCells[0].ColumnIndex;
            if (RowIndex > 0)
            {
                List<Object> listrow1 = new List<Object>();
                List<Object> listrow2 = new List<Object>();
                for (int i = 0; i < dataGridView_Step.Columns.Count; i++)
                {
                    listrow1.Add(dataGridView_Step.Rows[RowIndex].Cells[i].Value);
                    listrow2.Add(dataGridView_Step.Rows[RowIndex - 1].Cells[i].Value);
                }
                for (int i = 1; i < dataGridView_Step.Columns.Count; i++)
                {
                    dataGridView_Step.Rows[RowIndex - 1].Cells[i].Value = listrow1[i];
                    dataGridView_Step.Rows[RowIndex].Cells[i].Value = listrow2[i];
                }
                dataGridView_Step.ClearSelection();
                dataGridView_Step.Rows[RowIndex - 1].Cells[ColumnIndex].Selected = true;
            }
        }

        private void Button_MoveDown_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView_Step.SelectedCells[0].RowIndex;
            int ColumnIndex = dataGridView_Step.SelectedCells[0].ColumnIndex;
            if (RowIndex < dataGridView_Step.Rows.Count - 1)
            {
                List<Object> listrow1 = new List<Object>();
                List<Object> listrow2 = new List<Object>();
                for (int i = 0; i < dataGridView_Step.Columns.Count; i++)
                {
                    listrow1.Add(dataGridView_Step.Rows[RowIndex].Cells[i].Value);
                    listrow2.Add(dataGridView_Step.Rows[RowIndex + 1].Cells[i].Value);
                }
                for (int i = 1; i < dataGridView_Step.Columns.Count; i++)
                {
                    dataGridView_Step.Rows[RowIndex + 1].Cells[i].Value = listrow1[i];
                    dataGridView_Step.Rows[RowIndex].Cells[i].Value = listrow2[i];
                }
                dataGridView_Step.ClearSelection();
                dataGridView_Step.Rows[RowIndex + 1].Cells[ColumnIndex].Selected = true;
            }
        }

        private void CheckBoxOCV测试_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanelOCV测试.Enabled = checkBoxOCV测试.Checked;
        }

        private void CheckBox接触测试_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanel接触测试.Enabled = checkBox接触测试.Checked;
        }

        private void DataGridView_Step_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex; int ColumnIndex = e.ColumnIndex;
            if (RowIndex >= 0 && ColumnIndex >= 0)
            {
                switch (dataGridView_Step.Columns[ColumnIndex].Name)
                {
                    case "Col步次类型":
                        StepModeChange((TStepMode)Enum.Parse(typeof(TStepMode), dataGridView_Step.Rows[RowIndex].Cells["Col步次类型"].Value.ToString()!), RowIndex);
                        break;
                    //case "Col单步次保护":
                    //    StepPCProtect((bool)dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].Value, RowIndex);
                    //    break;
                    //case "Col负压测试":
                    //    NegatPreTest((bool)dataGridView_Step.Rows[RowIndex].Cells["Col负压测试"].Value, RowIndex);
                    //    break;
                    case "Col时长":

                        break;
                    default:

                        break;
                }
            }
        }

        public void StepModeChange(TStepMode StepMode, int RowIndex)
        {
            switch (StepMode)
            {
                case TStepMode.SKIP:
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].ReadOnly = true;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].Style.BackColor = Color.Silver;
                    dataGridView_Step.Rows[RowIndex].Cells["Col电流"].ReadOnly = true;
                    dataGridView_Step.Rows[RowIndex].Cells["Col电流"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col电流"].Style.BackColor = Color.Silver;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col时长"].ReadOnly = true;
                    dataGridView_Step.Rows[RowIndex].Cells["Col时长"].Value = "00:00:00";
                    dataGridView_Step.Rows[RowIndex].Cells["Col时长"].Style.BackColor = Color.Silver;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].ReadOnly = true;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].Style.BackColor = Color.Silver;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].ReadOnly = true;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].Style.BackColor = Color.Silver;

                    dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].ReadOnly = true;
                    dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].Value = false;
                    dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].Style.BackColor = Color.Silver;
                    StepPCProtect(true, RowIndex, StepMode);

                    break;
                case TStepMode.REST:
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].ReadOnly = true;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].Style.BackColor = Color.Silver;
                    dataGridView_Step.Rows[RowIndex].Cells["Col电流"].ReadOnly = true;
                    dataGridView_Step.Rows[RowIndex].Cells["Col电流"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col电流"].Style.BackColor = Color.Silver;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col时长"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col时长"].Value = "00:00:00";
                    dataGridView_Step.Rows[RowIndex].Cells["Col时长"].Style.BackColor = Color.White;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].ReadOnly = true;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].Style.BackColor = Color.Silver;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].ReadOnly = true;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].Style.BackColor = Color.Silver;

                    dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].Value = false;
                    dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].Style.BackColor = Color.White;
                    StepPCProtect(false, RowIndex, StepMode);

                    break;
                case TStepMode.CC:
                case TStepMode.DC:
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].Style.BackColor = Color.White;
                    dataGridView_Step.Rows[RowIndex].Cells["Col电流"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col电流"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col电流"].Style.BackColor = Color.White;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col时长"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col时长"].Value = "00:00:00";
                    dataGridView_Step.Rows[RowIndex].Cells["Col时长"].Style.BackColor = Color.White;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].ReadOnly = true;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].Style.BackColor = Color.Silver;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].Style.BackColor = Color.White;

                    dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].Value = false;
                    dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].Style.BackColor = Color.White;
                    StepPCProtect(false, RowIndex, StepMode);

                    break;
                case TStepMode.CCCV:
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电压"].Style.BackColor = Color.White;
                    dataGridView_Step.Rows[RowIndex].Cells["Col电流"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col电流"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col电流"].Style.BackColor = Color.White;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col时长"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col时长"].Value = "00:00:00";
                    dataGridView_Step.Rows[RowIndex].Cells["Col时长"].Style.BackColor = Color.White;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束电流"].Style.BackColor = Color.White;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].Value = 0;
                    dataGridView_Step.Rows[RowIndex].Cells["Col结束容量"].Style.BackColor = Color.White;

                    dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].ReadOnly = false;
                    //dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].Value = false;
                    dataGridView_Step.Rows[RowIndex].Cells["Col单步次保护"].Style.BackColor = Color.White;
                    StepPCProtect(false, RowIndex, StepMode);

                    break;
            }
        }

        public void StepPCProtect(bool ReadOnly, int RowIndex, TStepMode StepMode)
        {
            dataGridView_Step.Rows[RowIndex].Cells["Col电压下限"].ReadOnly = ReadOnly;
            dataGridView_Step.Rows[RowIndex].Cells["Col电压下限"].Style.BackColor = ReadOnly ? Color.Silver : Color.White;
            dataGridView_Step.Rows[RowIndex].Cells["Col电压上限"].ReadOnly = ReadOnly;
            dataGridView_Step.Rows[RowIndex].Cells["Col电压上限"].Style.BackColor = ReadOnly ? Color.Silver : Color.White;
            if (ReadOnly)
            {
                dataGridView_Step.Rows[RowIndex].Cells["Col电压下限"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col电压上限"].Value = 0;
            }

            if (!ReadOnly)
                ReadOnly = StepMode == TStepMode.REST;
            dataGridView_Step.Rows[RowIndex].Cells["Col电流下限"].ReadOnly = ReadOnly;
            dataGridView_Step.Rows[RowIndex].Cells["Col电流下限"].Style.BackColor = ReadOnly ? Color.Silver : Color.White;
            dataGridView_Step.Rows[RowIndex].Cells["Col电流上限"].ReadOnly = ReadOnly;
            dataGridView_Step.Rows[RowIndex].Cells["Col电流上限"].Style.BackColor = ReadOnly ? Color.Silver : Color.White;
            dataGridView_Step.Rows[RowIndex].Cells["Col容量下限"].ReadOnly = ReadOnly;
            dataGridView_Step.Rows[RowIndex].Cells["Col容量下限"].Style.BackColor = ReadOnly ? Color.Silver : Color.White;
            dataGridView_Step.Rows[RowIndex].Cells["Col容量上限"].ReadOnly = ReadOnly;
            dataGridView_Step.Rows[RowIndex].Cells["Col容量上限"].Style.BackColor = ReadOnly ? Color.Silver : Color.White;

            if (ReadOnly)
            {
                dataGridView_Step.Rows[RowIndex].Cells["Col电流下限"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col电流上限"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col容量下限"].Value = 0;
                dataGridView_Step.Rows[RowIndex].Cells["Col容量上限"].Value = 0;
            }
        }

        private void DataGridView_Step_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex; int ColumnIndex = e.ColumnIndex;
            if (RowIndex >= 0 && ColumnIndex >= 0)
            {
                if (dataGridView_Step.Columns[ColumnIndex].Name == "Col时长" &&
                    dataGridView_Step.Rows[RowIndex].Cells["Col步次类型"].Value.ToString() != "SKIP")
                    new Form设置时间(TimeChange, dataGridView_Step.Rows[RowIndex].Cells["Col时长"].Value.ToString()!).ShowDialog();
            }
        }
        private void TimeChange(string time)
        {
            dataGridView_Step.SelectedCells[0].Value = time;
        }


    }
}
