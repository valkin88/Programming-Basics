using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int MaxDifference = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                if (i < 1)
                {
                    sum1 = num1 + num2;
                }
                if (i == 1)
                {
                    sum2 = num1 + num2;
                    MaxDifference = Math.Abs(sum2 - sum1);
                    sum3 = num1 + num2;
                }
                if (i > 1)
                {
                    sum2 = num1 + num2;
                    if (Math.Abs(sum2 - sum3) > MaxDifference)
                    {
                        MaxDifference = Math.Abs(sum2 - sum3);
                    }
                    sum3 = num1 + num2;
                }
            }
            if (sum1 == sum2 && sum2 == sum3)
            {
                Console.WriteLine($"Yes, value {sum1}");
            }
            else if (n == 1)
            {
                Console.WriteLine($"Yes, value {sum1}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff {MaxDifference}");
            }
        }
    }
}
