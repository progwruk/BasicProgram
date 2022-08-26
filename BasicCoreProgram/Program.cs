using System;
namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core program");
            while (true)
            {
                Console.WriteLine("Select program\n 1.flip coin\n 2.leap year\n 3.power\n 4.harmonic number\n 5.factors\n 6.quotientRemainder\n 7.swap numbers\n 8.evenOdd\n 9.alphabet");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Coin();
                        break;
                    case 2:
                        LeapYear leapyear = new LeapYear();
                        leapyear.Year();
                        break;
                    case 3:
                        Power power = new Power();
                        power.PowerTwo();
                        break;
                    case 4:
                         HarmonicNumber harmonicNumber = new HarmonicNumber();
                         harmonicNumber.Number();
                        break;
                    case 5:
                         Factors factors = new Factors();
                         factors.Fact();
                        break;
                    case 6:
                        QuotientRemainder quotientRemainder = new QuotientRemainder();
                        quotientRemainder.QuoRem();
                        break;
                    case 7:
                        SwapNumbers swapNumbers = new SwapNumbers();
                        swapNumbers.Swap();
                        break;
                    case 8:
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.Check();
                        break;
                    case 9:
                        VowelConsonant vowelConsonant = new VowelConsonant();
                        vowelConsonant.Alphabet();
                        break;
                    default:
                        Console.WriteLine("Select correct option");
                        break;
                }
            }
        }
    }
}
