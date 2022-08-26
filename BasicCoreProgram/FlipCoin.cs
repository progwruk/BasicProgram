using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class FlipCoin
    {
        public void Coin()
        {
            int tailcount = 0, headcount = 0;
            Console.WriteLine("Enter number of times to flip coin");
            int flipcoin = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= flipcoin; i++)
            {
                Random random = new Random();
                double check = random.NextDouble();
                Console.WriteLine(check);
                if (check < 0.5)
                {
                    tailcount++;
                    Console.WriteLine("tail");
                }
                else
                {
                    Console.WriteLine("head");
                    headcount++;
                }
            }
            Console.WriteLine("number of head: " + headcount);
            Console.WriteLine("number of tail: " + tailcount);
            double headPercentage = (double)headcount / flipcoin * 100;
            double tailPercentage = (double)tailcount / flipcoin * 100;
            Console.WriteLine("Head percentage : " + headPercentage);
            Console.WriteLine("Tail percentage : " + tailPercentage);
        }
    }
}
