using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class EstablishedState : IState
    {
        public void Handle(TCPConnection connection)
        {
            Console.WriteLine("Handling connection in Established state.");
            connection.SetState(new ClosedState()); // Transition to a new state
        }
    }
}
