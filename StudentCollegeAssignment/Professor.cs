using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeAssignment
{
    internal class Professor : Person
    {
        public static double PA = 0.5;
        public static double TA = 0.3;

        private double basicSalary;
        private double salary;

        public Professor(int id, string address, DateTime dob, double basicSalary) 
            : base(id, address, dob)
        {
            this.basicSalary = basicSalary;
            CalculateSalary();
            Print();
        }

        public double CalculateSalary()
        {
            salary = basicSalary + (basicSalary * PA) + (basicSalary * TA);
            return salary;
        }

        public void Print()
        {
            base.PrintDetails();
            Console.WriteLine("Salary : " + salary);
        }
    }
}
