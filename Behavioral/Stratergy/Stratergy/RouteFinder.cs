using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy
{
    internal class RouteFinder
    {
        private IRouteStratergy routeStratergy = null;

        public void setRouteStratergy(IRouteStratergy routeStratergy)
        {
            this.routeStratergy = routeStratergy;
        }

        public void findRoute(string origin, string destination)
        {
            this.routeStratergy.findRoute(origin, destination);
        }
    }
}
