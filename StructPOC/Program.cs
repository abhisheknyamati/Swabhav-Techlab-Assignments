using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            College college;

            college._id = 1;
            college._name = "DMCE";
            college._university = "MU";

            college.Display();  

            College college1 = new College(2, "AC", "MU");
            college1.Display();
        }
    }
}
