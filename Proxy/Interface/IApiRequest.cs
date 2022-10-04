using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Interface
{
    internal interface IApiRequest
    {
        public Task<bool> ping(IPAddress ip, int port);
        public Task<bool> Connect(IPAddress ip, int port);
        public Task<bool> DisConnect();
    }
}
