namespace State
{
    internal class RedSignalState : SignalState
    {
        internal override void turnLight()
        {
            Console.WriteLine("Turned on Red Light");
            base.setSignalLightState(new GreenSignalState());
        }
    }
}