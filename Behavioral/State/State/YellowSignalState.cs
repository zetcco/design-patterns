namespace State
{
    internal class YellowSignalState : SignalState
    {
        internal override void turnLight()
        {
            Console.WriteLine("Turned on Yellow Light");
            base.setSignalLightState(new RedSignalState());
        }
    }
}