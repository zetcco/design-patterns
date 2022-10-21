using State;

internal class Program
{
    private static void Main(string[] args)
    {

        // In this example, Context is the object that uses different States to act accordingly. In this, Context is a SignalLight box. Which switches it's colors

        /* Each State and the main Context should have references to each other, so here, main context sets the reference to it's state using the constructor
         * For the reference from state to the main context, after setting the state on the main context, through that setted state, we go to it's class (SignalState class) and 
         * set the reference to the context (SignalState -> SignalLight reference) using a function on there */
        SignalLight signalLight = new SignalLight(new GreenSignalState());
        signalLight.change();
        signalLight.change();
        signalLight.change();
        signalLight.change();
        signalLight.change();
        signalLight.change();
    }
}