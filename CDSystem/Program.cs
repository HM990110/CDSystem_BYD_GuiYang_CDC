using CDClassLibrary;
using CDClassLibrary.Stage;
using CDSystem.Language;
using CDSystem.Other;
using CDSystem.系统设置;
using System.Globalization;

namespace CDSystem
{
    internal static class Program
    {
        public static MyClass设备选中 MyClass设备选中 = new();
        public static ClassUser ClassUser = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Language();
            _ = new Mutex(true, Application.ProductName, out bool ret);
            if (ret)
            {
                GlobalParams.GlobalParamsCreate();
                MyClass设备选中 = new MyClass设备选中(true);

                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new FormMain());
            }
            else
            {
                MessageBox.Show(null, ResourceLang.ProgramIsAlreadyRunn, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();//退出程序   
            }
        }

        public static void Language()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(GlobalDefine.Lang.ToString());
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(GlobalDefine.Lang.ToString());
        }
    }
}