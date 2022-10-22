using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class AppleDisplay : Display
    {
        public void displayPercentage(string percentage)
        {
            Console.WriteLine("Apple display percentage: " + percentage);
        }
    }
}
