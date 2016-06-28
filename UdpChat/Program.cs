using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TcpChat
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Разработать чат, выполняющий обмен данными в текстовом виде между двумя приложениями.
            //В этом случае каждое приложение является и клиентом и сервером,
            //между которыми устанавливается соединение по протоколу TCP,
            //и выполняется передача текстовых сообщений.
            
            Console.Write("Server ip - ");
            var client_host = Console.ReadLine();
            Console.Write("Server port - ");
            var client_port = int.Parse(Console.ReadLine());
            Console.Write("Client port - ");
            var server_port = int.Parse(Console.ReadLine());
            Console.Write("Client nick - ");
            var name = Console.ReadLine();

            var updClient = new UdpBase(client_host, client_port, server_port, name);
        }
    }

    public class TcpBase
    {
        private readonly TcpListener _tcpReceiver;
        private readonly string _name;

        public TcpBase(string clientAddress, int clientPort, int serverPort, string name)
        {
            _tcpReceiver = new TcpListener(IPAddress.Any, clientPort);
            _tcpReceiver.Start();
            _tcpReceiver.BeginAcceptTcpClient(new AsyncCallback(AcceptClient), null);

            _name = name;
        }

        private void AcceptClient(IAsyncResult ar)
        {
            using (var client = _tcpReceiver.EndAcceptTcpClient(ar))
            using (var stream = client.GetStream())
            using (var br = new BinaryReader(stream))
            using (var bw = new BinaryWriter(stream))
            {
                var receive = new Thread(() =>
                {
                    while (true)
                        Console.WriteLine(br.ReadString());
                });
                var send = new Thread(() =>
                {
                    while (true)
                    {
                        var input = Console.ReadLine();

                        if (input == "exit") break;
                        bw.Write(input);
                    }
                });
                receive.Start();
                send.Start();
            }
        }
    }

    public class UdpBase
    {
        private UdpClient _udpReceiver;
        private UdpClient _udpSender;
        private IPEndPoint _endPoint;
        private string _name;

        public UdpBase(string clientAddress, int clientPort, int serverPort, string name)
        {
            _udpReceiver = new UdpClient(serverPort);
            _endPoint = new IPEndPoint(IPAddress.Any, 0);

            _udpSender = new UdpClient();
            _udpSender.Connect(clientAddress, clientPort);

            _name = name;

            Start();
        }

        private byte[] Receive()
        {
            try
            {
                return _udpReceiver.Receive(ref _endPoint);
            }
            catch
            {
                throw;
            }
        }

        private void Send(byte[] buffer)
        {
            try
            {
                _udpSender.Send(buffer, buffer.Length);
            }
            catch
            {
                throw;
            }
        }

        private void Start()
        {
            try
            {
                Console.WriteLine("\n-----------*******Общий чат*******-----------");
                Thread receive = new Thread(() =>
                {
                    while (true)
                    {
                        byte[] receiveBytes = Receive();
                        Console.WriteLine(Encoding.UTF8.GetString(receiveBytes));
                    }
                });
                Thread send = new Thread(() =>
                {
                    while (true)
                    {
                        Console.Write(_name + " says: ");
                        var input = Console.ReadLine();
                        if (input == "exit") break;

                        byte[] receiveBytes = Encoding.UTF8.GetBytes(_name + " says: " + input);
                        Send(receiveBytes);
                    }
                });
                receive.Start();
                send.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.ToString() + "\n  " + ex.Message);
            }
        }
    }
}
