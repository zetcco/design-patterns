using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Circle : IShape
    {
        public override void draw()
        {
            Console.Write("Drawing a Circle");
        }
    }
}
