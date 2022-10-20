using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class RoundHole
    {
        private int radius;

        public RoundHole(int radius)
        {
            this.radius = radius;
        }

        public void fits(IRoundStick stick)
        {
            if (stick.getRadius() <= this.radius)
                Console.WriteLine("Stick fits");
            else
                Console.WriteLine("Stick does not fit");
        }
    }
}
