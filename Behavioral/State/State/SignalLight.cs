using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class SignalLight
    {
        private SignalState state = null;

        public SignalLight(SignalState state)
        {
            setStateAndContext(state);
        }

        public void setState(SignalState state)
        {
            setStateAndContext(state);
        }

        private void setStateAndContext(SignalState state)
        {
            this.state = state;
            this.state.setSignalLight(this);
        }

        public void change()
        {
            this.state.turnLight();
        }
    }
}
