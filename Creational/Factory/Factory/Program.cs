using Factory;

internal class Program
{
    private static void Main(string[] args)
    {
        PowerbankFactory factory = new PowerbankFactory();

        Powerbank p1 = factory.getPowerbank("Samsung", "Huawei");
        p1.pressButton();

        Powerbank p2 = factory.getPowerbank("Oneplus", "Apple");
        p2.pressButton();

        Powerbank p3 = factory.getPowerbank("Samsung", "Apple");
        p3.pressButton();
    }
}