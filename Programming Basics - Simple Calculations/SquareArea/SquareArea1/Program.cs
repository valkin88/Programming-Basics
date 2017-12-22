using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            int s = a * a;
            Console.WriteLine("S = " + s);
        }
    }
}
