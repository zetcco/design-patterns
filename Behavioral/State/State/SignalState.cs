namespace State
{
    internal abstract class SignalState
    {
        private SignalLight signalLight = null;

        public void setSignalLight(SignalLight signalLight)
        {
            this.signalLight = signalLight;
        }

        public void setSignalLightState(SignalState state)
        {
            this.signalLight.setState(state);
        }
        internal abstract void turnLight();
    }
}