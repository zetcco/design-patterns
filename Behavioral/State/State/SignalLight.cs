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

        // This function is used to set the both references (from SignalState to SignalLight as well as from SignalLight to SignalState reference)
        private void setStateAndContext(SignalState state)
        {
            this.state = state;             // Sets the reference from here (SignalLight) to SignalState
            this.state.setSignalLight(this); // Through that passed state, we go to a function (called setSignalLight) on SignalState class and set the reference from SignalState to SignalLight
        }

        public void change()
        {
            this.state.turnLight();
        }
    }
}
