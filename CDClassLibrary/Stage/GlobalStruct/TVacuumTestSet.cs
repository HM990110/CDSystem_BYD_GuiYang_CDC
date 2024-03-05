namespace CDClassLibrary.Stage
{
    /// <summary>
    /// 水冷PID控制参数
    /// </summary>
    [Serializable]
    public class TWaterPID
    {
        /// <summary>
        /// Kp 比例系数，无符号，*100
        /// </summary>
        public double PIDKp;
        /// <summary>
        /// Ki 积分系数，无符号，*100
        /// </summary>
        public double PIDKi;
        /// <summary>
        /// Kd 微分系数，无符号，*100
        /// </summary>
        public double PIDKd;
        /// <summary>
        /// 调节周期 T，无符号，秒
        /// </summary>
        public int PIDT;

        public TWaterPID()
        {
            PIDKp = 6;
            PIDKi = 0.05;
            PIDKd = 0.1;
            PIDT = 2;
        }
    }
}
