using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class PowerbankFactory
    {
        public Powerbank getPowerbank(String display, String battery)
        {
            Powerbank bank = new Powerbank();
            switch (display)
            {
                case "Samsung":
                    bank.setDisplay(new SamsungDisplay());
                    break;
                case "Oneplus":
                    bank.setDisplay(new OneplusDisplay());
                    break;
            }

            switch (battery)
            {
                case "Huawei":
                    bank.setBattery(new HuaweiBattery());
                    break;
                case "Apple":
                    bank.setBattery(new AppleBattery());
                    break;
            }

            return bank;
        }
    }
}
