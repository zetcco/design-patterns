using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class SonyBattery : Battery
    {
        public string getCharge()
        {
            return "20 (Sony)";
        }
    }
}
