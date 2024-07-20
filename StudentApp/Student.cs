using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Student
    {   public static double CGPA_PERCENTAGE_CONSTANT_VALUE = 9.5;
        private int rollNumber;
        private string name;
        private double cgpa;
        private double percentage;

        public Student(int rollNumber, string name, double cgpa)
        {
            RollNumber = rollNumber;
            Name = name;
            CGPA = cgpa;
        }

        public int RollNumber
        {
            get { return rollNumber; }
            set { rollNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { 
                if (value.Length >= 5) { 
                    name = value; } 
                else { throw new ArgumentException("Minimum 5 characters are required in name!"); }
            }
        }

        public double CGPA
        {
            get { return cgpa; }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    cgpa = value;
                }
                else { throw new ArgumentException("CGPA must be between 1 and 10!"); }
            }
        }

        public double Percentage(double cgpa)
        {
            percentage = cgpa * CGPA_PERCENTAGE_CONSTANT_VALUE;
            return percentage;
        }

        public void PrintDetails(Student student)
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Roll Number : " + RollNumber);
            Console.WriteLine("CGPA : " + CGPA);
            Console.WriteLine("Percentage : " + percentage);
        }

    }
}
