using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = { 
                new Student(1, "Abhishek", 5.5),
                new Student(2, "Nyamati", 7.6), 
                new Student(3, "Rohan", 8.8)
            };

            foreach (Student student in students)
            {
                student.Percentage(student.CGPA);
                student.PrintDetails(student);
                Console.WriteLine();
            }

        }
    }
}
