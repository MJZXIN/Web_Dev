using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace API
{
    public class sockets
    {
        static Socket soc = null;
        static bool isRunning = false;

        public static void connect() {
            soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("172.21.3.1"), 2000);
            try
            {
                soc.Connect(ipe);
                Console.WriteLine("连接成功");
            }
            catch (Exception)
            {
                Console.WriteLine("连接失败");
                return;
            }
            isRunning = true;
            Task Recv = Task.Run(() => { RecvData(); });
        }

        private static void RecvData()
        {
            
        }
    }
}
