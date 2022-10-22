namespace Factory
{
    internal class PowerBank
    {
        private Display display;
        private Battery battery;

        internal PowerBank(Display display, Battery battery)
        {
            this.display = display;
            this.battery = battery;
        }

        public void getPercentage()
        {
            this.display.displayPercentage(battery.getCharge());
        }
    }
}