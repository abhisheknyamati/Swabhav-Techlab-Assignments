using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDLL.GlobalExceptionHandling
{
    public class MaximumMovieCapacityEx : Exception
    {
        public MaximumMovieCapacityEx(string errorMessage):base(errorMessage) { }
    }
}
