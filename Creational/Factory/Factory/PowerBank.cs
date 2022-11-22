using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Powerbank
    {
        private Battery battery;
        private Display display;
        public Powerbank(Battery battery, Display display)
        {
            this.display = display;
            this.battery = battery;
        }

        public Powerbank()
        {
        }

        public void pressButton()
        {
            int percentage = this.battery.getPercentage();
            this.display.displayPercentage(percentage);
        }

        public void setBattery(Battery battery)
        {
            this.battery = battery;
        }

        public void setDisplay(Display display)
        {
            this.display = display;
        }
    }
}
