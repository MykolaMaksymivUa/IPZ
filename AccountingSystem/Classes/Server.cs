using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AccountingSystem.Server
{
    public class Server
    {
        readonly TcpListener _listener;

        // Запуск сервера
        public Server(int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
            _listener.Start(); 

            while (true)
            {
                TcpClient Client = _listener.AcceptTcpClient();
                Thread Thread = new Thread(new ParameterizedThreadStart(ClientThread));
                Thread.Start(Client);
            }
        }
        ~Server()
        {
            _listener?.Stop();
        }
        static void ClientThread(Object StateInfo)
        {
            new Client((TcpClient)StateInfo);
        }

        private void SendError(TcpClient Client, int Code)
        {

            string CodeStr = Code.ToString() + " " + ((HttpStatusCode)Code).ToString();
            string Html = "<html><body><h1>" + CodeStr + "</h1></body></html>";
            string Str = "HTTP/1.1 " + CodeStr + "\nContent-type: text/html\nContent-Length:" + Html.Length.ToString() + "\n\n" + Html;
            byte[] Buffer = Encoding.ASCII.GetBytes(Str);
            Client.GetStream().Write(Buffer, 0, Buffer.Length);
            Client.Close();
        }
    }
}
