using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacLib
{
    public class FacClass
    {
        public long FacFunc(long a)
        {

            long factorial = 1;
            for (; a > 0; factorial *= a--) ;
            return factorial;

        }
    }
}
