using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < Math.Round((n / 2.0), 1); i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - 2) / 2 - i), new string('*', i*2 + 2));
                }
                 else
                 {
                    Console.WriteLine("{0}{1}{0}", new string('-', n / 2 - i), new string('*', (i * 2) + 1));
                 }
            }
            for (int i = 1; i <= n / 2.0; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}
