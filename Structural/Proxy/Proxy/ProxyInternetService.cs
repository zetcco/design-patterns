using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ProxyInternetService : IInternetService
    {
        IInternetService service;
        List<String> blacklist = new List<string>() { "www.whatsapp.com" };
        public ProxyInternetService(IInternetService service)
        {
            this.service = service;
        }
        public void connect(String url)
        {
            if (blacklist.Contains(url))
            {
                Console.WriteLine("Cannot access url");
                return;
            }
            service.connect(url);
        }
    }
}
