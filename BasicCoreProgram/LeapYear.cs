using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("Enter four digit number year :");
            int year = int.Parse(Console.ReadLine());
            if (year % 100 == 0 && year % 400 == 0)
            {
                Console.WriteLine("It is a leap year", year);
                return;
            }
            if (year % 100 != 0 && year % 4 == 0)
                Console.WriteLine("It is a leap year", year);
            else
                Console.WriteLine("It is not a leap year", year);
        }

    }
}
