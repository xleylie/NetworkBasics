using System;
using System.Net;
using System.Net.Sockets;

try
{
    string hostName = Dns.GetHostName();
    IPAddress[] addresses = Dns.GetHostEntry(hostName).AddressList;

    Console.WriteLine($"Имя компьютера: {hostName}");

    Console.WriteLine();
    Console.WriteLine("Все IP-адреса:");
    foreach (IPAddress ip in addresses)
    {
        Console.WriteLine($"{ip} - {ip.AddressFamily}");
    }

    Console.WriteLine();
    Console.WriteLine("IPv4-адреса:");
    foreach (IPAddress ip in addresses)
    {
        if (ip.AddressFamily == AddressFamily.InterNetwork)
        {
            Console.WriteLine($"  {ip} - {ip.AddressFamily}");
        }
    }

    Console.WriteLine();
    Console.WriteLine("IPv6-адреса:");
    foreach (IPAddress ip in addresses)
    {
        if (ip.AddressFamily == AddressFamily.InterNetworkV6)
        {
            Console.WriteLine($"  {ip} - {ip.AddressFamily}");
        }
    }
}
catch (SocketException ex)
{
    Console.WriteLine($"Ошибка сети: {ex.Message}");
}