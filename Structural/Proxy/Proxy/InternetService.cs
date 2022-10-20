using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class InternetService : IInternetService
    {
        public void connect(string url)
        {
            Console.WriteLine("Accessed: " + url);
        }
    }
}
