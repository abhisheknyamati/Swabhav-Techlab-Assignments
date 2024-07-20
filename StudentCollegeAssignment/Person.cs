using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeAssignment
{
    internal class Person
    {
        private int id;
        private string address;
        private DateTime dob;

        public Person(int id, string address, DateTime dob)
        {
            this.id = id;
            this.address = address;
            this.dob = dob;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Address : " + address);
            Console.WriteLine("DOB : " + dob.ToShortDateString());
        }
    }
}
