using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class SquareStick : ISquareStick
    {
        private int width;
        public SquareStick(int width)
        {
            this.width = width;
        }

        public int getWidth()
        {
            return width;
        }
    }
}
