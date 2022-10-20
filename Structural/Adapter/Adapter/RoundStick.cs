using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class RoundStick : IRoundStick
    {
        private int radius;

        public RoundStick(int radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }
    }
}
