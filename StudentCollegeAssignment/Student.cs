using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeAssignment
{
    internal class Student : Person
    {
        private string branch;

        public Student(int id, string address, DateTime dob, string branch)
            : base(id, address, dob)
        {
            this.branch = branch;
            Print();
        }

        public void Print()
        {
            base.PrintDetails();
            Console.WriteLine("Branch : " + branch);
        }
    }
}
