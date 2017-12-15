using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOf10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}", new string('*', n));
            }
        }
    }
}
