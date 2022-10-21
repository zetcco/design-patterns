using State;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Each State and the main Context should have references to each other, so here, main context sets the reference to it's state using the constructor
         * For the reference from state to the main context, after setting the state on the main context, that setted state is used to go to it's class and 
         * set the reference to the context using there */
        SignalLight signalLight = new SignalLight(new GreenSignalState());
        signalLight.change();
        signalLight.change();
        signalLight.change();
        signalLight.change();
        signalLight.change();
        signalLight.change();
    }
}