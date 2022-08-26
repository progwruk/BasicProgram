using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LargestNumber
    {
        public void Number()
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("First number is largest", num1);
            }
            if (num2 > num1 && num2 > num3)
                Console.WriteLine("Second number is largest", num2);
            else
                Console.WriteLine("Third number is largest", num3);
        }
    }
}
