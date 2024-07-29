using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDLL.GlobalExceptionHandling
{
    public class MovieStoreEmptyEx : Exception
    {
        public MovieStoreEmptyEx(string errorMessage): base(errorMessage) { }
    }
}
