namespace Factory
{
    internal class HuaweiDisplay : Display
    {
        void Display.displayPercentage(string percentage)
        {
            Console.WriteLine("Huawei display percentage: " + percentage);
        }
    }
}