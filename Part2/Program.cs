using System;
using System.Net;
using System.Net.Sockets;

Console.Write("Введите доменное имя: ");
string domain = Console.ReadLine();

try
{
    IPHostEntry entry = Dns.GetHostEntry(domain);

    Console.WriteLine($"Домен: {domain}");
    Console.WriteLine("IP-адреса:");
    foreach (IPAddress ip in entry.AddressList)
    {
        Console.WriteLine($"{ip} ({ip.AddressFamily})");
    }
}
catch (SocketException ex)
{
    Console.WriteLine($"Не удалось разрешить имя \"{domain}\": {ex.Message}");
}