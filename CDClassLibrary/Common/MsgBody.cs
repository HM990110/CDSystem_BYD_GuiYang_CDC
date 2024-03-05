using System.Text;

namespace CDClassLibrary.Common
{
    class MsgBody
    {
        public MsgBody(UInt16 Cmd, byte[] b, string str = "")
        {
            this.BodyDataStr = str;
            this.BodyDataBriny = b;
            this.Start_Byte = new byte[4] { 0xAA, 0x55, 0x00, 0xFF };
            this.Cmd_Byte = new byte[4];
            this.CheckSum_Byte = new byte[4];
            this.Cmd = Cmd;
        }

        public MsgBody(byte[] b)
        {
            this.Source = b;
            SetValues();
        }

        public byte Start = 0xAA;
        public byte[] Start_Byte = Array.Empty<byte>();

        /// <summary>
        /// 命令字 用来标记消息类型
        /// </summary>
        public UInt16 Cmd;
        //public byte SubCmd;
        public byte[] Cmd_Byte = Array.Empty<byte>();

        /// <summary>
        /// 包长
        /// </summary>
        public UInt32 DataLength;
        public byte[] DataLength_Byte = Array.Empty<byte>();

        /// <summary>
        /// 发生的文本内容
        /// </summary>
        public string BodyDataStr = string.Empty;
        public byte[] BodyDataStr_Byte = Array.Empty<byte>();

        /// <summary>
        /// 发生的二进制字节内容
        /// </summary>
        public byte[] BodyDataBriny = Array.Empty<byte>();

        /// <summary>
        /// 包尾校验和 BodyDataBriny求和
        /// </summary>
        public UInt32 CheckSum;
        public byte[] CheckSum_Byte = Array.Empty<byte>();

        /// <summary>
        /// 需要解析原字节数组
        /// </summary>
        private readonly byte[] Source = Array.Empty<byte>();

        /// <summary>
        /// 数据组合为byte数组
        /// </summary>
        /// <returns></returns>
        public byte[] ToByteArray()
        {
            //转byte数组
            BodyDataStr_Byte = Encoding.UTF8.GetBytes(BodyDataStr);
            Array.Copy(BitConverter.GetBytes(Cmd), 0, Cmd_Byte, 0, 2);

            DataLength = Convert.ToUInt32(BodyDataStr_Byte.Length + BodyDataBriny.Length + 4);    //桢体 + 校验和
            DataLength_Byte = BitConverter.GetBytes(DataLength);                                  //桢体有效字节数组

            UInt32 tmpDataSum = 0;
            for (int j = 0; j < BodyDataBriny.Length; j++)
            {
                tmpDataSum += BodyDataBriny[0 + j];
            }
            CheckSum = tmpDataSum;
            CheckSum_Byte = BitConverter.GetBytes(tmpDataSum);

            //移入result
            byte[] result = new byte[Start_Byte.Length + Cmd_Byte.Length + DataLength_Byte.Length + DataLength];       //桢体+帧头长度+桢体数据长度
            Array.Copy(Start_Byte, 0, result, 0, Start_Byte.Length);                          //帧同步码
            Array.Copy(Cmd_Byte, 0, result, Start_Byte.Length, Cmd_Byte.Length);              //桢命令
            Array.Copy(DataLength_Byte, 0, result, Start_Byte.Length + Cmd_Byte.Length, DataLength_Byte.Length);   //后续长度

            //Array.Copy(BodyDataStr_Byte, 0, result, 12, BodyDataStr_Byte.Length);
            Array.Copy(BodyDataBriny, 0, result, Start_Byte.Length + Cmd_Byte.Length + DataLength_Byte.Length, BodyDataBriny.Length);   //有效桢体
            Array.Copy(CheckSum_Byte, 0, result, Start_Byte.Length + Cmd_Byte.Length + DataLength_Byte.Length + DataLength - 4, CheckSum_Byte.Length);                 //结束校验和

            return result;
        }

        /// <summary>
        /// 数据解析
        /// </summary>
        public void SetValues()
        {
            try
            {
                Start_Byte = SubByte(Source, 0, 4);

                Cmd_Byte = SubByte(Source, 4, 2);
                Cmd = BitConverter.ToUInt16(Cmd_Byte, 0);

                DataLength_Byte = SubByte(Source, 8, 4);
                DataLength = BitConverter.ToUInt32(DataLength_Byte, 0);

                BodyDataBriny = SubByte(Source, 12, Convert.ToInt32(DataLength));

                CheckSum_Byte = SubByte(BodyDataBriny, BodyDataBriny.Length - 4, 4);
                CheckSum = BitConverter.ToUInt32(CheckSum_Byte, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "解包错误");
                Console.WriteLine("1002:" + ex.Message);
            }
        }

        /// <summary>
        /// 截取字节数组
        /// </summary>
        /// <param name="srcBytes">要截取的字节数组</param>
        /// <param name="startIndex">开始截取位置的索引</param>
        /// <param name="length">要截取的字节长度</param>
        /// <returns>截取后的字节数组</returns>
        public static byte[] SubByte(byte[] srcBytes, int startIndex, int length)
        {
            MemoryStream bufferStream = new();
            byte[] returnByte = Array.Empty<byte>();
            if (srcBytes == null) { return returnByte; }
            if (startIndex < 0) { startIndex = 0; }
            if (startIndex < srcBytes.Length)
            {
                if (length < 1 || length > srcBytes.Length - startIndex) { length = srcBytes.Length - startIndex; }
                bufferStream.Write(srcBytes, startIndex, length);
                returnByte = bufferStream.ToArray();
                bufferStream.SetLength(0);
                bufferStream.Position = 0;
            }
            bufferStream.Close();
            bufferStream.Dispose();
            return returnByte;
        }
    }
}
