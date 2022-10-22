using Factory;

internal class Program
{
    private static void Main(string[] args)
    {
        PowerBankFactory factory = new PowerBankFactory();

        PowerBank powerbank1 = factory.getPowerBank(new AppleDisplay(), new SamsungBattery());
        PowerBank powerbank2 = factory.getPowerBank(new HuaweiDisplay(), new SamsungBattery());
        PowerBank powerbank3 = factory.getPowerBank(new AppleDisplay(), new SonyBattery());

        powerbank1.getPercentage();
        powerbank2.getPercentage();
        powerbank3.getPercentage();
    }
}