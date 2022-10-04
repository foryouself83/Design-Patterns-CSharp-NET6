
using Proxy.Business;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        var proxy = new WebApiProxy();

        Task.Factory.StartNew(async () =>
        {
            await proxy.Connect(IPAddress.Parse("127.0.0.1"), 50001);
            Console.WriteLine($"WebApiProxy Connected: {proxy.IsConnected}");
            await proxy.DisConnect();
            Console.WriteLine($"WebApiProxy Connected: {proxy.IsConnected}");
        });        

        Console.ReadKey();
    }
}