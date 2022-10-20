using Decorator;

internal class Program
{
    private static void Main(string[] args)
    {
        IShape shape = new Circle();
        shape.draw();
        Console.WriteLine();

        shape = new RedDecorator(shape);
        shape.draw();
        Console.WriteLine();

        shape = new GreenDecorator(shape);
        shape.draw();
        Console.WriteLine();
    }
}