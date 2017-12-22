using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0_100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] rounds = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (num < 0 && num >100)
            {
                Console.WriteLine("Invalid number!");
            }
            else if (num >= 0 && num <= 9)
            {
                Console.WriteLine("{0}", digits[num]);
            }
            else if (num > 9 && num <= 19)
            {
                Console.WriteLine("{0}", tens[num - 10]);
            }
            else if (num > 19 && num < 100)
            {
                if (num % 10 == 0)
                {
                    Console.WriteLine("{0}", rounds[num / 10 - 2]);
                }
                else if (num % 10 != 0)
                {
                    Console.WriteLine("{0} {1}", rounds[num / 10 - 2], digits[num % 10]);
                }
            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }
    }
}
