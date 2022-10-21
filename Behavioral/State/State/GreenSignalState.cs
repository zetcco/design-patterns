using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class GreenSignalState : SignalState
    {
        internal override void turnLight()
        {
            Console.WriteLine("Turned on Green Light");
            base.setSignalLightState(new YellowSignalState());
        }
    }
}
