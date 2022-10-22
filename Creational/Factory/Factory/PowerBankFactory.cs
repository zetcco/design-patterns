using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class PowerBankFactory
    {
        public PowerBank getPowerBank(Display display, Battery battery)
        {
            return new PowerBank(display, battery);
        }
    }
}
