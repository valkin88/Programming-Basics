using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int i = 0; i < Math.Round((n / 2.0), 1); i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 2) / 2 - i), new string('-', i * 2));
                }
            }

            else if (n % 2 != 0 && n > 1)
            {
                    Console.WriteLine("{0}*{0}", new string('-', n / 2));
                for (int i = 0; i < Math.Round((n / 2.0) - 1, 1); i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 2) / 2 - i), new string('-', (i * 2) + 1));
                }
            }
            if (n % 2 == 0)
            {
                for (int i = 0; i < Math.Round((n / 2.0) - 1, 1); i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', i + 1), new string('-', (n - 4) - i * 2));
                }
            }

            else if (n % 2 != 0 && n > 1)
            {

                for (int i = 0; i < Math.Round((n / 2.0) - 2, 1); i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', i + 1), new string('-', (n - 4) - i * 2));
                }
                Console.WriteLine("{0}*{0}", new string('-', n / 2));
            }
            else if (n == 1)
            {
                Console.WriteLine("*");
            }
        }
    }
}
