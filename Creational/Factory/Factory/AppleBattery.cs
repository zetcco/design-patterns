using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class AppleBattery : Battery
    {
        public int getPercentage()
        {
            return 21;
        }
    }
}
