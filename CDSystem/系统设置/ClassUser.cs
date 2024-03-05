using CDClassLibrary.Stage;
using CDClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CDSystem.系统设置
{
    public class ClassUser : INotifyPropertyChanged
    {
        public ClassUser()
        {

        }

        private string _username = "";
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _password = string.Empty;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private string _password2 = string.Empty;
        public string Password2
        {
            get => _password2;
            set
            {
                _password2 = value;
                OnPropertyChanged(nameof(Password2));
            }
        }

        private string _realname = "";
        public string Realname
        {
            get => _realname;
            set
            {
                _realname = value;
                OnPropertyChanged(nameof(Realname));
            }
        }

        private DateTime _regtime = DateTime.Now;
        public DateTime Regtime
        {
            get => _regtime;
            set
            {
                _regtime = value;
                OnPropertyChanged(nameof(Regtime));
            }
        }

        private Role _role = 系统设置.Role.游客;
        public Role Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }

        private Power _power = new();
        public Power Power
        {
            get => _power;
            set
            {
                _power = value;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum Role { 游客, 管理员, 工程师, 操作员, }

    public class Power
    {
        public bool 初始操作 { get; set; } = false;
        public bool 掉电操作 { get; set; } = false;
        public bool 自动手动切换 { get; set; } = false;
        public bool 重新作业 { get; set; } = false;
        public bool 停止流程 { get; set; } = false;
        public bool 发送流程 { get; set; } = false;
        public bool 编辑流程 { get; set; } = false;
        public bool 设备维护 { get; set; } = false;
        public bool 传感器调试 { get; set; } = false;
        public bool 系统设置 { get; set; } = false;
    }
}
