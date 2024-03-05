using CDClassLibrary.Common;
using CDClassLibrary.Language;
using CDClassLibrary.Log;
using CDClassLibrary.Mes;
using CDClassLibrary.Stage;
using System.Resources;

namespace CDClassLibrary
{
    public class GlobalParams
    {
        public static int SelectStage = 0;
        public static List<LogHelper> RunLog = new();
        public static List<LogHelper> AlarmLog = new();
        public static List<LogHelper> ErrorLog = new();
        public static List<LogHelper> MesLog = new();

        public static List<TProcessGroup> ProcessGroup = new();
        public static Task[] Tasks = Array.Empty<Task>();
        public static Task TaskWMS = new(() => { });
        public static ICommMCU[] CommMCU = Array.Empty<ICommMCU>();
        public static ThreadStage[] GStages = Array.Empty<ThreadStage>();

        public static ResourceManager Res = new("CDClassLibrary.Language.ResourceLang", typeof(ResourceLang).Assembly);

        public static void GlobalParamsCreate()
        {
            GlobalFunction.GetConfig();
            GlobalFunction.Language();

            Tasks = new Task[GlobalDefine.NUM_ALLSTAGES];
            CommMCU = new ICommMCU[GlobalDefine.NUM_ALLSTAGES];
            GStages = new ThreadStage[GlobalDefine.NUM_ALLSTAGES];

            GlobalFunction.GetParameterLimit();
            GlobalFunction.GetNGCount();
            GlobalFunction.GetIP();
            GlobalFunction.GetDeviceType();
            GlobalFunction.GetVacancyFlag();
            GlobalFunction.GetManualAutoFlag();
            GlobalFunction.GetMapping();
            GlobalFunction.GetProcessGroup();
            GlobalFunction.GetStage();
            OperationRecords.WriteOperatingStatistic("", "软件启动");
        }

        private static bool boolWMS = true;
        public static void Run()
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                Tasks[FStageID] = Task.Factory.StartNew(GStages[FStageID].Run, TaskCreationOptions.LongRunning);
            }

            TaskWMS = new Task(() =>
            {
                while (boolWMS)
                {
                    HttpWMS.NotifyCellWorkState();
                    Thread.Sleep(Constants.ThreadStage.THREADDELAY_WORK);
                }
            });
            TaskWMS.Start();
        }

        public static void GlobalParamsClose()
        {
            //保存设备线程现场数据
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                GStages[FStageID].StopStage();

            //等待线程结束
            Task.WaitAll(Tasks);

            boolWMS = false;
            TaskWMS.Wait();
            OperationRecords.WriteOperatingStatistic("", "软件退出");
            HttpWMS.NotifyCellWorkState(true);
        }
    }
}