using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog("Sammy", 3, "Golden Retriever");
            ((Dog)myDog).PrintDogInfo();
            ((Dog)myDog).Bark();
        }
    }
}
