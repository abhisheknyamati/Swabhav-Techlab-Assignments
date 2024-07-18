using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BMI_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "John", 30, 5.8, 40);
            Person person1 = new Person(2, "Max", 22, 5.7, 68);
            Person person2 = new Person(3, "Sam", 21, 6.2, 100);

            Person[] persons = new Person[] { person, person1, person2 };

            foreach (var item in persons)
            {
                Console.WriteLine(item.PrintDetails() + "\n");
            }

            Person HighestBMI = Person.CalculateHighestBMI(persons);

            Console.WriteLine("Person with highest BMI value is : \n" + HighestBMI.PrintDetails()); 
        }
    }
}
