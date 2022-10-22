namespace Factory
{
    internal class SamsungBattery : Battery
    {
        string Battery.getCharge()
        {
            return "10% (samsung)";
        }
    }
}