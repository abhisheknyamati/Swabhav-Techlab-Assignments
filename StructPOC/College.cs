using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPOC
{
    public struct College
    {
        public int _id;
        public string _name;
        public string _university;


        public College(int id, string name, string university)
        {
            _id = id;
            _name = name;
            _university = university;
        }

        public void Display()
        {
            Console.WriteLine("Id : " + _id);
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("University : " + _university);
        }
    }
}
