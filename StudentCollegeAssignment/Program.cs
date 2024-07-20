using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student(2, "thane", new DateTime(2022, 3, 5), "computer");
            Console.WriteLine();
            Person professor = new Professor(1, "airoli", new DateTime(2011, 9, 3), 30000);

        }
    }
}
