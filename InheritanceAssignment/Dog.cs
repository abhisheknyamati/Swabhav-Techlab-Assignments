using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine("Woof!");
        }

        public void PrintDogInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Breed: {Breed}");
        }
    }
}
