using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace UdpLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var udpClient = new UdpClient(3231);
            IPEndPoint sender = null;
            var result = udpClient.Receive(ref sender);

            // для мультикаст сообщений
            // udpClient.JoinMulticastGroup(IPAddress.Parse("127.0.0.1"));
            udpClient.Close();

            var senderUdp = new UdpClient(3231);
            var text = "Hello";
            var bytes = System.Text.Encoding.UTF8.GetBytes(text);
            var sendedBytes = senderUdp.Send(bytes, bytes.Length);
            senderUdp.Close();

            Console.ReadKey();
        }

    }
}
