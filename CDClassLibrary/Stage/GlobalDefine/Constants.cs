namespace CDClassLibrary.Stage
{
    //系统常量定义类
    public static class Constants
    {
        //线程常数定义
        public static class ThreadStage
        {
            //判断设备未连接次数
            public const int COUNT_COMMERROR = 2;

            //设备运行时保存现场间隔
            public const int COUNT_SAVESTAGE = 180;

            //运行时设备线程等待时间
            public const int THREADDELAY_WORK = 800;

            //空置时设备线程等待时间
            public const int THREADDELAY_WAIT = 3000;

            //电池电压上限
            public const int UPLIMIT_CELL_VOLTAGE = 4500;

            //数据保存条数
            public const int DATA_COUNT_SAVE = 10;

            //数据保存时间间隔
            public const int TIME_INTERVAL_DATASAVE = 60;
        }

        //tcp通讯常数定义
        public static class CommMcu
        {
            //命令最多执行次数
            public const int COUNT_CMDAPPLY = 3;
        }

        //tcp通讯常数定义
        public static class TcpCmm
        {
            //PING超时
            public const int PING_TIMEOUT = 500;
            //连接超时
            public const int CONNECT_TIMEOUT = 1000;
            //写超时
            public const int WRITE_TIMEOUT = 500;
            //读取超时
            public const int READ_TIMEOUT = 1000;
        }
    }
}
