using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class TCPConnection
    {
        private IState _state;

        public TCPConnection()
        {
            // Initial state
            _state = new ListeningState();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }

}
