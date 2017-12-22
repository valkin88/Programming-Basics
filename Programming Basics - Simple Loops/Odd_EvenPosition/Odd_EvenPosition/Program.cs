using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_EvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }

                }
                else
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
            }
            if (oddSum > 0 || oddSum < 0)
            {
                Console.WriteLine($"OddSum {oddSum}");
                Console.WriteLine($"OddMin {oddMin}");
                Console.WriteLine($"OddMax {oddMax}");
            }
            else
            {
                Console.WriteLine($"OddSum {oddSum}");
                Console.WriteLine($"OddMin No");
                Console.WriteLine($"OddMax No");
            }
            if (evenSum > 0 || evenSum < 0)
            {
                Console.WriteLine($"EvenSum {evenSum}");
                Console.WriteLine($"EvenMin {evenMin}");
                Console.WriteLine($"EvenMax {evenMax}");
            }
            else
            {
                Console.WriteLine($"EvenSum {evenSum}");
                Console.WriteLine($"EvenMin No");
                Console.WriteLine($"EvenMax No");
            }
        }
    }
}
