using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {

                if (i % 2 != 0)
                {
                    int num = int.Parse(Console.ReadLine());
                    rightSum += num;
                }
                else
                {
                    int num = int.Parse(Console.ReadLine());
                    leftSum += num;
                }

            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes Sum {leftSum}");
            }
            else
            {
                Console.WriteLine($"No diff {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
