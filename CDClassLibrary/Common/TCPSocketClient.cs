using CDClassLibrary.Stage;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace CDClassLibrary.Common
{
    [Serializable]
    internal class TCPSocketClient
    {
        private readonly int Port;
        private readonly string IP;
        public Socket? clientSocket;
        readonly ManualResetEvent TimeoutObject = new(false);

        public TCPSocketClient(string IP, int Port)
        {
            this.IP = IP;
            this.Port = Port;
        }

        public bool Ping()
        {
            try
            {
                Ping ping = new();
                PingReply tmpReply = ping.Send(this.IP, Constants.TcpCmm.PING_TIMEOUT);
                return (tmpReply.Status == IPStatus.Success);
            }
            catch (Exception ex)
            {
                Console.WriteLine("1003:" + ex.Message);
                return false;
            }
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                if (ar.AsyncState != null)
                {
                    Socket client = (Socket)ar.AsyncState;
                    client?.EndConnect(ar);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("1004:" + ex.Message);
            }
            finally
            {
                TimeoutObject.Set();
            }
        }

        public bool Open()
        {
            try
            {
                //创建连接控件
                if (clientSocket == null)
                {
                    this.clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                    {
                        SendTimeout = Constants.TcpCmm.WRITE_TIMEOUT,
                        ReceiveTimeout = Constants.TcpCmm.READ_TIMEOUT
                    };
                }

                //判断是否需要重新连接
                if (!clientSocket.Connected)
                {
                    TimeoutObject.Reset();
                    clientSocket.BeginConnect(this.IP, this.Port, new AsyncCallback(ConnectCallback), clientSocket);

                    //等待连接超时
                    if (!TimeoutObject.WaitOne(Constants.TcpCmm.CONNECT_TIMEOUT, false))
                    {
                        clientSocket.Close();
                        return false;
                    }
                }

                //返回连接状态
                return (clientSocket.Connected);
            }
            catch (Exception ex)
            {
                clientSocket.Close();
                Console.WriteLine("1005:" + ex.Message);
                return false;
            }
        }

        public bool Send(byte[] sendBytes)
        {
            if (!clientSocket.Connected)
                return false;

            try
            {
                int tmpSend = clientSocket.Send(sendBytes);
                return (tmpSend == sendBytes.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine("1006:" + ex.Message);
                return false;
            }
        }

        //接收固定长度数据
        public bool Receive(ref byte[] recBytes, int offset = 0, int size = 0)
        {
            if (!clientSocket.Connected)
                return false;

            //如果接收长度为0，就取缓存长度
            int tmpSize = (size == 0) ? recBytes.Length : size;

            if (tmpSize > 0)
            {
                try
                {
                    //第一次接收的实际数据   
                    int tmpRec = clientSocket.Receive(recBytes, offset, tmpSize, 0);

                    //如果没有接收到需要的数据，循环接收直到超时  
                    while (tmpRec < tmpSize)
                    {
                        tmpRec += clientSocket.Receive(recBytes, offset + tmpRec, tmpSize - tmpRec, 0);
                    }
                    return (tmpRec == tmpSize);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("1007:" + ex.Message);
                    return false;
                }
            }
            else return false;
        }

        //接收非固定长度数据
        public bool ReceiveMCU(ref byte[] recBytes)
        {
            try
            {
                //先接收12字节包头取得长度
                if (!Receive(ref recBytes, 0, 12))
                    return false;

                //获取剩余字节数
                UInt32 RecByteCount = BitConverter.ToUInt32(recBytes, 8);

                if (RecByteCount > 0)
                {
                    //扩展数组大小
                    recBytes = (byte[])Redim(recBytes, Convert.ToInt32(12 + RecByteCount));

                    //接收剩余数据
                    return Receive(ref recBytes, 12, Convert.ToInt32(RecByteCount));
                }
                else return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1008:" + ex.Message);
                return false;
            }
        }

        private static Array Redim(Array origArray, int desiredSize)
        {
            //determine the type of element
            Type t = origArray.GetType().GetElementType()!;
            //create a number of elements with a new array of expectations
            //new array type must match the type of the original array
            Array newArray = Array.CreateInstance(t, desiredSize);
            //copy the original elements of the array to the new array
            Array.Copy(origArray, 0, newArray, 0, Math.Min(origArray.Length, desiredSize));
            //return new array
            return newArray;
        }

        public void Close()
        {
            if (clientSocket == null)
                return;
            try
            {
                if (clientSocket.Connected)
                    clientSocket.Disconnect(false);
                clientSocket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("1009:" + ex.Message);
            }
            finally { }
        }
    }
}
