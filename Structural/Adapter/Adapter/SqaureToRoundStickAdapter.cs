using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class SqaureToRoundStickAdapter : IRoundStick
    {
        private ISquareStick squareStick;
        public SqaureToRoundStickAdapter(ISquareStick squareStick)
        {
            this.squareStick = squareStick;
        }

        public void changeAdaptee(ISquareStick squareStick)
        {
            this.squareStick = squareStick;
        }

        public double getRadius()
        {
            return squareStick.getWidth() / Math.Sqrt(2.0);
        }
    }
}
