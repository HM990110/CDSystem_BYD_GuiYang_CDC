using CDGraph.Language;

namespace CDGraph
{
    public partial class Form_NG代码 : Form
    {
        public void Language()
        {
            Column1.HeaderText = ResourceLang.Form_NG代码Column1HeaderText;
            Column2.HeaderText = ResourceLang.Form_NG代码Column2HeaderText;
            Column3.HeaderText = ResourceLang.Form_NG代码Column3HeaderText;
            Column5.HeaderText = ResourceLang.Form_NG代码Column5HeaderText;
            Column6.HeaderText = ResourceLang.Form_NG代码Column6HeaderText;
        }

        public Form_NG代码()
        {
            InitializeComponent();
            Language();
        }

        private void Form_NG代码_Load(object sender, EventArgs e)
        {
            dataGridView_NGCode.Rows.Add(new string[] { "00", "", "正常电芯", "", "" });
            dataGridView_NGCode.Rows.Add(new string[] { "60", "", "无电池通道", "", "" });
            dataGridView_NGCode.Rows.Add(new string[] { "61", "", "前工序NG电池", "", "" });
            dataGridView_NGCode.Rows.Add(new string[] { "62", "OCV测试", "电压<OCV下限", "OCV初始测试", "上位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "63", "OCV测试", "电压>OCV上限", "OCV初始测试", "上位机软件" });

            dataGridView_NGCode.Rows.Add(new string[] { "64", "流程中电压检测", "电压<当前步次电压下限", "流程中", "上位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "65", "流程中电压检测", "电压>当前步次电压上限", "流程中", "上位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "66", "流程中电流检测", "电流<当前步次电流下限", "流程中", "上位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "67", "流程中电流检测", "电流>当前步次电流上限", "流程中", "上位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "68", "流程中容量检测", "容量<当前步次容量下限", "流程中", "上位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "69", "流程中容量检测", "容量>当前步次容量上限", "流程中", "上位机软件" });

            dataGridView_NGCode.Rows.Add(new string[] { "10", "单片机节点", "单片机初始化异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "11", "单片机节点", "单片机ADC采样异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "12", "单片机节点", "单片机母线电压异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "13", "单片机节点", "单片机电源异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "14", "单片机节点", "单片机DAC异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "16", "单片机节点", "单片机CAN通讯异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "17", "单片机节点", "单片机外部触发异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "18", "单片机节点", "单片机电压采集异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "19", "单片机节点", "单片机电流采集异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "0B", "通用", "电池电压过压保护(串联单体电压上限保护)：流程中当电池电压大于设置的保护值时起保护", "流程中", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "0C", "通用", "电池电压欠压保护(串联单体电压下限保护)：流程中当电池电压小于设置的保护值时起保护", "流程中", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "1A", "单片机节点", "单片机线电压采集异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "1B", "单片机节点", "单片机电池温度采集异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "1C", "单片机节点", "单片机通道温度采集异常", "上电后", "单片机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "A0", "接触测试", "电池反接保护：接触测试开始前，当电池电压小于或等于设置的保护值时起保护", "接触测试", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "A1", "接触测试", "电压下限保护：接触测试开始前，当电池电压小于设置的保护值时起保护", "接触测试", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "A2", "接触测试", "电压上限保护：接触测试开始前，当电池电压大于设置的保护值时起保护", "接触测试", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "A4", "接触测试", "电流偏差保护：当电流与目标电流的偏差超过设定的百分比时起保护(正负偏差都会保护)", "接触测试", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "A6", "接触测试", "电压变化过小保护：接触测试过程中电压的变化值小于设定值则起保护(接触测试流程为CC)", "接触测试", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "A7", "接触测试", "电压变化过大保护：接触测试过程中电压的变化值大于设定值则起保护(接触测试流程为CC)", "接触测试", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "AA", "接触测试", "压差保护：接触测试过程中电压与线电压的压值差大于设定值则起保护(接触测试流程为CC)", "接触测试", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "C0", "通用", "电流线电压过压保护：流程中当线电压大于设定保护值时起保护", "流程中", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "C1", "通用", "充放电时，电流线电压与电池电压的差值(绝对值)大于设定保护值时起保护", "CC/CV/CCCV/DC/DV/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "C2", "通用", "休眠时，电流线电压与电池电压的差值(绝对值)大于设定保护值时起保护", "休眠", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "C3", "通用", "接触阻抗保护：如果(|线电压-电池电压| - 设定压差)/电流大于电阻阈值，且连续超过设定时间时起保护", "全程", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "C4", "充电", "电压突降保护：检测充电过程中是否有电压突降，根据相邻两次采样电压来判断是否有电压突降发生，如果(前一次电压 – 当前电压)> 设定幅度，则代表电压突降，这时起保护", "CC/CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "C5", "通用", "电池温度下限报警：如果电池温度低于设置的保护值时起保护", "流程中", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "C6", "通用", "电池温度上限报警：如果电池温度高于设置的保护值时起保护", "流程中", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "C7", "通用", "容量上限保护：流程中容量的上限，超过则起保护", "流程中", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "C8", "通用", "急停电压保护(上限)：当电池电压大于等于设定的保护值时起保护，并且所有通道停止充放电，状态为暂停", "流程中", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "C9", "通用", "T时刻电压上限保护：从流程开始时刻算起，到达设定的T时刻，如果此时电池电压大于设定保护值时起保护", "流程中", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "CA", "通用", "T时刻电压下限保护：从流程开始时刻算起，到达设定的T时刻，如果此时电池电压小于设定保护值时起保护", "流程中", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "CB", "通用", "通道板温度报警：如果通道板温度高于设置的保护值时起保护", "流程中", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "CC", "充电", "充电电压下限保护：充电时电池电压小于设定保护值时起保护", "CC/CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "CD", "通用", "恒流间隔波动保护：在恒流阶段检查，根据设定的间隔时间取电流值，如果相邻两次差值的绝对值大于设定波动值时则保护", "CC/CCCV/DC/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "CE", "充电", "充电恒压时电流突升保护：恒压时检测电流是否有突升，根据相邻两次采样电流来判断电流是否突升：如果(当前电流 –前一次电流)>设定幅度，则代表电流突升，此时起保护", "CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "CF", "通用", "休眠时电压异常波动保护：休眠步次中，等待一段延时后(待充放电结束电压稳定)，根据相邻两次采样电压来判断是否有电压波动，如果 |当前电压 –前一次电压| > 设定幅度则保护", "休眠", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "D0", "充电", "充电电压上限保护：充电时电池电压大于设定保护值时起保护", "CC/CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "D1", "充电", "充电检查保护：从当前步次开始时刻算起，到达设定的检查时刻，如果此时电池电压小于设定保护值时起保护，每个流程只在第一个充电步次中检查", "CC/CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "D2", "充电", "充电电压未上升保护：在恒流充电阶段判断：根据设定的间隔时间取电压值，如果本次取的电压值减去上一次取的电压值小于设定值时，则认为充电异常需要保护串联充电电压下降保护：在恒流充电阶段判断：根据设定的间隔时间取电压值，如果上一次取的电压值减去本次取的电压值大于", "CC/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "D3", "充电", "T1时刻电压上限保护：在恒流充电阶段判断：从当前步次开始时刻算起，到达设定的T1时刻，如果此时电池电压大于设定保护值时起保护，每个流程只在第一个充电步次中检查", "CC/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "D4", "充电", "T1时刻电压下限保护：在恒流充电阶段判断：从当前步次开始时刻算起，到达设定的T1时刻，如果此时电池电压小于设定保护值时起保护，每个流程只在第一个充电步次中检查", "CC/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "D5", "充电", "T2时刻电压上限保护：在恒流充电阶段判断：从当前步次开始时刻算起，到达设定的T2时刻，如果此时电池电压大于设定保护值时起保护，每个流程只在第一个充电步次中检查", "CC/CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "D6", "充电", "T2时刻电压下限保护：在恒流充电阶段判断：从当前步次开始时刻算起，到达设定的T2时刻，如果此时电池电压小于设定保护值时起保护，每个流程只在第一个充电步次中检查", "CC/CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "D7", "充电", "充电电压过上升保护：在恒流充电阶段判断：根据设定的间隔时间取电压值，如果本次取的电压值减去上一次取的电压值大于设定值时，则认为充电异常需要保", "CC/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "D8", "通用", "电池反接保护：当电池电压小于设定的保护值时起保护", "流程中", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "D9", "充电", "T5时刻电流上限保护：在恒流充电阶段判断：从当前步次开始时刻算起，到达设定的T5时刻，如果此时电流大于设定保护值时起保护，每个流程只在第一个充电", "CC/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "DA", "充电", "T5时刻电流下限保护：在恒流充电阶段判断：从当前步次开始时刻算起，到达设定的T5时刻，如果此时电流小于设定保护值时起保护，每个流程只在第一个充电", "CC/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "DB", "通用", "恒流波动保护(上限)：在恒流阶段判断，当电流大于(恒流值+波动值)时起保护", "CC/CCCV/DC/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "DC", "充电", "充电容量保护(上限)：充电时容量大于设定的保护值时起保护", "CC/CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "DD", "放电", "放电电压下限保护：放电时电池电压小于设定保护值时起保护", "DC/DV/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "DE", "放电", "放电限制时间保护：放电时间超过设定时间时起保护", "DC/DV/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "DF", "通用", "恒流波动保护(下限)：在恒流阶段判断，当电流小于(恒流值-波动值)时起保护", "CC/CCCV/DC/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "E0", "充电", "恒压时电流累计上升保护：恒压时检测电流是否有上升：根据相邻两次采样电流来判断，如果 (当前电流 –前一次电流)>设定幅度，则代表电流上升，记为1次，当前步次中，当电流上升次数累计达到设定次数时起保护", "CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "E1", "充电", "恒压时电流连续上升保护：恒压时检测电流是否有上升：根据相邻两次采样电流来判断，如果 (当前电流 –前一次电流)>设定幅度，则代表电流上升，记为1次，当前步次中，当电流连续上升次数达到设定次数时起保护", "CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "E2", "充电", "充电时电压累计下降保护：检测充电过程中是否有电压下降，根据相邻两次采样电压来判断，如果(前一次电压 – 当前电压)>设定幅度，则代表电压下降，记为1次，当前步次中，当电压下降次数累计达到设定次数时起保护", "CC/CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "E3", "充电", "充电时电压连续下降保护：检测充电过程中是否有电压下降，根据相邻两次采样电压来判断，如果(前一次电压 – 当前电压)>设定幅度，则代表电压下降，记为1次，当前步次中，当电压连续下降次数达到设定次数时起保护", "CC/CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "E4", "放电", "放电时电压累计上升保护：检测放电过程中是否有电压上升，根据相邻两次采样电压来判断，如果(当前电压 –前一次电压)>设定幅度，则代表电压上升，记为1次，当前步次中，当电压上升次数累计达到设定次数时起保护", "DC/DV/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "E5", "放电", "放电时电压连续上升保护：检测放电过程中是否有电压上升，根据相邻两次采样电压来判断，如果(当前电压 –前一次电压)>设定幅度，则代表电压上升，记为1次，当前步次中，当电压连续上升次数达到设定次数时起保护", "DC/DV/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "E6", "放电", "放电容量保护(上限)：放电时容量大于设定的保护值时起保护", "DC/DV/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "E7", "放电", "放电检查保护(上限)：从当前步次开始时刻算起，到达设定的检查时刻，如果此时电池电压大于设定保护值时起保护，", "DC/DV/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "E8", "放电", "放电检查保护(下限)：从当前步次开始时刻算起，到达设定的检查时刻，如果此时电池电压小于设定保护值时起保护，", "DC/DV/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "E9", "放电", "放电电压未下降保护：在恒流放电阶段判断：根据设定的间隔时间取电压值，如果上一次取的电压值减去本次取的电压值小于设定值时，则认为放电异常需要保", "DC/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "EA", "放电", "放电电压过下降保护：在恒流放电阶段判断：根据设定的间隔时间取电压值，如果上一次取的电压值减去本次取的电压值大于设定值时，则认为放电异常需要保护", "DC/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "EB", "放电", "放电电压上限保护：放电时电池电压大于设定保护值时起保护", "DC/DV/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "F1", "放电", "放电电流偏离保护：放电时电流与下发值偏差高于设定值，产生保护；", "", "" });
            dataGridView_NGCode.Rows.Add(new string[] { "F2", "充电", "充电电流下限保护：充电时如果电流小于设定保护值时起保护", "CV/CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "F4", "放电", "放电容量保护(下限)：在放电结束时判断，如果放电容量小于设定保护值时起保护", "DC/DV/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "F5", "通用", "休眠电压保护(上限)：休眠步次中，如果电池电压大于设定保护值时起保护", "休眠", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "F6", "通用", "休眠回路电流保护：在休眠步次中，如果电流大于设定保护值时起保护", "休眠", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "F7", "充电", "CC缺时保护：只在CCCV步次中检查，从当前步次起始时刻开始计时，如果恒流阶段的充电时间 (CC转CV时刻)小于设定时间则", "CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "F8", "充电", "CC超时保护：只在CCCV步次中检查，从当前步次起始时刻开始计时，如果到达设定时刻时步次仍处于恒流充电阶段则保护", "CCCV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "F9", "通用", "恒压偏差保护：恒压时，电压大于(恒压值+偏差)，或者小于(恒压值-偏差)时起保护", "CV/CCCV/DCDV", "下位机软件" });
            dataGridView_NGCode.Rows.Add(new string[] { "FF", "通用", "温升速率保护：电池温度上升速率大于设定的保护值时起保护", "流程中", "下位机软件" });
        }
    }
}