using Proxy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Business
{
    internal class WebApi : IApiRequest
    {
        public bool IsConnected { get; set; }
        public Task<bool> Connect(IPAddress ip, int port)
        {
            return Task.Run(() => { 
                IsConnected = true;
                Console.WriteLine($"WebApi Connect ok.");
                return true; });
        }

        public Task<bool> DisConnect()
        {
            return Task.Run(() => { 
                IsConnected = false;
                Console.WriteLine($"WebApi DisConnect ok.");
                return true; });
        }

        public Task<bool> ping(IPAddress ip, int port)
        {
            return Task.Run(() => {
                Console.WriteLine($"WebApi ping ok.");
                return true; });
        }
    }
}
