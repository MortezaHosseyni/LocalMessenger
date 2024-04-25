using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System;
using System.Net.NetworkInformation;

namespace LocalMessenger.Server
{
    public class Program
    {
        private static readonly Dictionary<Socket, string> _clientIPs = new Dictionary<Socket, string>();
        private const int _port = 8888;

        static string GetLocalIPv4(NetworkInterfaceType networkInterfaceType)
        {
            string ipAddress = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == networkInterfaceType && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipAddress = ip.Address.ToString();
                            break;
                        }
                    }
                    if (!string.IsNullOrEmpty(ipAddress))
                        break;
                }
            }
            return ipAddress;
        }

        static void Main(string[] args)
        {
            StartServer();
        }

        static void StartServer()
        {
            Logger _logger = new Logger("server_log.txt");

            string localIP = GetLocalIPv4(NetworkInterfaceType.Ethernet);

            Console.WriteLine($"Starting server on {localIP}:{_port}...");
            _logger.Log($"Starting server on {localIP}:{_port}...");

            TcpListener listener = new TcpListener(IPAddress.Parse(localIP), _port);
            listener.Start();

            while (true)
            {
                Console.WriteLine("Waiting for connections...");
                _logger.Log("Waiting for connections...");

                Socket client = listener.AcceptSocket();

                Console.WriteLine("Client connected: " + client.RemoteEndPoint);
                _logger.Log("Client connected: " + client.RemoteEndPoint);

                string clientIP = ((IPEndPoint)client.RemoteEndPoint).Address.ToString();
                _clientIPs.Add(client, clientIP);

                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
        }

        static void HandleClient(object clientObj)
        {
            Logger _logger = new Logger("server_log.txt");

            Socket client = (Socket)clientObj;
            NetworkStream stream = new NetworkStream(client);

            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                        break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine($"({client.RemoteEndPoint}) {message}");
                    _logger.Log($"({client.RemoteEndPoint}) {message}");

                    BroadcastMessage(message, client);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    _logger.Log("Error: " + ex.Message);
                    break;
                }
            }

            _clientIPs.Remove(client);
            Console.WriteLine("Client disconnected: " + client.RemoteEndPoint);
            _logger.Log("Client disconnected: " + client.RemoteEndPoint);
            client.Close();
        }

        static void BroadcastMessage(string message, Socket sender)
        {
            foreach (Socket client in _clientIPs.Keys)
            {
                if (client != sender)
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    client.Send(buffer);
                }
            }
        }
    }
}
