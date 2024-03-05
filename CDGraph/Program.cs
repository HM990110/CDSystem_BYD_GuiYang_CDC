using CDClassLibrary.Stage;
using CDClassLibrary.Tools;
using System.Resources;

namespace CDGraph
{
    internal static class Program
    {
        public static ResourceManager? Res;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GetConfig();

            GlobalFunction.Language();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new FormMain());
        }

        private static void GetConfig()
        {
            string ConfigFilePath = Application.StartupPath + "Config.dat";
            IniFileHM ConfigFile = new(ConfigFilePath);

            string[] keys = ConfigFile.INIGetAllItemKeys("Config");

            if (keys.Contains("Lang"))
                GlobalDefine.Lang = Enum.Parse<Lang>(ConfigFile.INIGetStringValue("Config", "Lang", Lang.zh.ToString()));
            else
                ConfigFile.INIWriteValue("Config", "Lang", Lang.zh.ToString());
        }
    }
}