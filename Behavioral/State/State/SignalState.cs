namespace State
{
    internal abstract class SignalState
    {
        private SignalLight signalLight = null;

        // This function is accessed through SignalLight class to set the reference from here (SignalState) to (SignalLight).
        public void setSignalLight(SignalLight signalLight)
        {
            this.signalLight = signalLight;
        }

        public void setSignalLightState(SignalState state)
        {
            this.signalLight.setState(state);
        }

        // This function is like the 'action' that each State performs
        internal abstract void turnLight();
    }
}