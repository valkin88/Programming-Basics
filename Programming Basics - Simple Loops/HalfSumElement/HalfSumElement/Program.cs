using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int sum = 0;
            int leftSide = 0;
            int rightSide = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                if (num > maxNum)
                {
                    maxNum = num;
                }

            }
            leftSide = maxNum;
            rightSide = sum - maxNum;
            if (leftSide == rightSide)
            {
                Console.WriteLine($"Yes Sum {leftSide}");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(leftSide - rightSide)}");
            }         
        }
    }
}
