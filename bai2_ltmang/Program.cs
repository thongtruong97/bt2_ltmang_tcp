using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace bai2_ltmang
{
    class Program
    {
        static void Main(string[] args)
        {

            IPEndPoint ipserver = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.SendTimeout = 1000;
            client.ReceiveTimeout = 1000;
            //TcpClient c = new TcpClient();
            //c.ReceiveTimeout = 0;
            try
            {
                client.Connect(ipserver);
                Console.WriteLine(ipserver.ToString() + " is opened.");
                client.Close();
            }
            catch
            {
                Console.WriteLine(ipserver.ToString() + " is closed.");
            }
        }
    }
}
