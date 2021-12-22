using System;
using System.Net;

namespace CustomNSLookup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPAddress[] ipAddresses = new IPAddress[args.Length];
            foreach (string url in args)
            {
                try
                {
                    IPHostEntry host = Dns.GetHostEntry(url);
                    IPAddress[] ipAddreses = host.AddressList;
                    Console.WriteLine("HOST: {0}", host.HostName);
                    Console.WriteLine("IP address:");
                    foreach (IPAddress ip in ipAddreses)
                    {
                        Console.WriteLine(ip);
                    }
                    
                }
                catch(System.Net.Sockets.SocketException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
