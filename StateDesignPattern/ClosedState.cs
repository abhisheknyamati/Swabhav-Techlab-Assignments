using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class ClosedState : IState
    {
        public void Handle(TCPConnection connection)
        {
            Console.WriteLine("Handling connection in Closed state.");
            // This is the end state, so no transition here
        }
    }
}
