using Proxy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Business
{
    internal class WebApiProxy : IApiRequest
    {
        private WebApi _api = new();

        public bool IsConnected => _api.IsConnected;

        public async Task<bool> Connect(IPAddress ip, int port)
        {
            var isOk = await ping(ip, port);
            if (!isOk)
                return false;

            Console.WriteLine($"WebApiProxy Connecting...");
            return await _api.Connect(ip, port);
        }

        public async Task<bool> DisConnect()
        {
            Console.WriteLine($"WebApiProxy DisConnecting...");
            return await _api.DisConnect();
        }

        public async Task<bool> ping(IPAddress ip, int port)
        {
            Console.WriteLine($"WebApiProxy ping...");
            return await _api.ping(ip, port);
        }
    }
}
