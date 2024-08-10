using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class ListeningState : IState
    {
        public void Handle(TCPConnection connection)
        {
            Console.WriteLine("Handling connection in Listening state.");
            // You might want to transition to another state here
        }
    }
}
