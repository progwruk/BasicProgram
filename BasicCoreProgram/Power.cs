using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Power
    {
        public void PowerTwo()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n && i < 32; i++)
            {
                double table = Math.Pow(2, i);
                Console.WriteLine(table);
            }
        }
    }
}
