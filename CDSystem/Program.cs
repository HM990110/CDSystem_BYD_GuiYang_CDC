using CDClassLibrary;
using CDClassLibrary.Stage;
using CDSystem.Language;
using CDSystem.Other;
using CDSystem.ϵͳ����;
using System.Globalization;

namespace CDSystem
{
    internal static class Program
    {
        public static MyClass�豸ѡ�� MyClass�豸ѡ�� = new();
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
                MyClass�豸ѡ�� = new MyClass�豸ѡ��(true);

                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new FormMain());
            }
            else
            {
                MessageBox.Show(null, ResourceLang.ProgramIsAlreadyRunn, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();//�˳�����   
            }
        }

        public static void Language()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(GlobalDefine.Lang.ToString());
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(GlobalDefine.Lang.ToString());
        }
    }
}