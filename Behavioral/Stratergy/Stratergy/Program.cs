using Stratergy;

internal class Program
{
    private static void Main(string[] args)
    {
        RouteFinder routeFinder = new RouteFinder();
        routeFinder.setRouteStratergy(new WalkRouteStratergy());
        routeFinder.findRoute("Badulla", "Matara");

        routeFinder.setRouteStratergy(new BusRouteStratergy());
        routeFinder.findRoute("Badulla", "Matara");

        routeFinder.setRouteStratergy(new CarRouteStratergy());
        routeFinder.findRoute("Badulla", "Matara");
    }
}