using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy
{
    internal class CarRouteStratergy : IRouteStratergy
    {
        public void findRoute(string origin, string destination)
        {
            Console.WriteLine($"Found route from {origin} to {destination} by Car");
        }
    }
}
