using CDClassLibrary.Stage;
using CDClassLibrary;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CDSystem.Language;

namespace CDSystem.Other
{
    public partial class UserControl设备选中 : UserControl
    {
        public void Language()
        {
            label1.Text = ResourceLang.UserControl库位选中label1Text;
            label2.Text = ResourceLang.UserControl库位选中label2Text;
            label3.Text = ResourceLang.UserControl库位选中label3Text;
        }

        public UserControl设备选中()
        {
            InitializeComponent();

            BindingSource source = new()
            {
                DataSource = Program.MyClass设备选中
            };

            ComboBoxLine.Items.Add(GlobalDefine.LNSTNO.ToString("00"));
            for (int i = 0; i < GlobalDefine.NUM_STAGEPERDEVICE; i++)
                ComboBoxColumn.Items.Add((i + GlobalDefine.DVSTNO).ToString("000"));
            for (int i = 0; i < GlobalDefine.NUM_DEVICEPERLINE; i++)
                ComboBoxRow.Items.Add((i + 1).ToString("00"));

            ComboBoxLine.SelectedIndex = 0;

            this.ComboBoxColumn.DataBindings.Add("Text", source, "SelectStageColumn", true, DataSourceUpdateMode.OnPropertyChanged);
            this.ComboBoxRow.DataBindings.Add("Text", source, "SelectStageRow", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }

    public class MyClass设备选中 : INotifyPropertyChanged
    {
        public MyClass设备选中()
        {

        }

        public MyClass设备选中(bool b = true)
        {
            if (b)
            {
                string FStageNo = GlobalParams.GStages[GlobalParams.SelectStage].FStageNo;
                _selectStageColumn = FStageNo.Substring(2, 3);
                _selectStageRow = FStageNo.Substring(5, 2);
            }
        }

        private string _selectStageColumn = string.Empty;
        public string SelectStageColumn
        {
            get => _selectStageColumn;
            set
            {
                _selectStageColumn = value;
                GlobalParams.SelectStage = (int.Parse(value) - GlobalDefine.DVSTNO) * GlobalDefine.NUM_DEVICEPERLINE + (int.Parse(SelectStageRow) - 1);
                OnPropertyChanged(nameof(SelectStageColumn));
            }
        }

        private string _selectStageRow = string.Empty;

        public string SelectStageRow
        {
            get => _selectStageRow;
            set
            {
                _selectStageRow = value;
                GlobalParams.SelectStage = (int.Parse(SelectStageColumn) - GlobalDefine.DVSTNO) * GlobalDefine.NUM_DEVICEPERLINE + (int.Parse(value) - 1);
                OnPropertyChanged(nameof(SelectStageRow));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
