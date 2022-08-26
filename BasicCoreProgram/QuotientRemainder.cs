using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class QuotientRemainder
    {
        int dividend = 19, divisor = 5;
        public void QuoRem()
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("quotient = " + quotient);
            Console.WriteLine("remainder = " + remainder);
        }
    }
}
