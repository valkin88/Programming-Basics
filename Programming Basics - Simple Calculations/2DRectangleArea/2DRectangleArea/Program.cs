using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STrapec
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double sideA = Math.Abs(x1 - x2);
            double sideB = Math.Abs(y2 - y1);
            double s = sideA * sideB;
            double p = 2 * sideA + 2 * sideB;
            Console.WriteLine(s);
            Console.WriteLine(p);
        }
    }
}
