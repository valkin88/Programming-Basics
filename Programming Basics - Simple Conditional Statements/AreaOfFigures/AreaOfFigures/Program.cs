using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string form = Console.ReadLine();
            if (form == "square")
            {
                Console.Write("A = ");
                double a = double.Parse(Console.ReadLine());
                double s = a * a;
                Console.WriteLine(Math.Round(s, 3));
            }
            else if (form == "rectangle")
            {
                Console.Write("A = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("B = ");
                double b = double.Parse(Console.ReadLine());
                double s = a * b;
                Console.WriteLine(Math.Round(s, 3));
            }
            else if (form == "circle")
            {
                Console.Write("R = ");
                double r = double.Parse(Console.ReadLine());
                double s = Math.PI * r * r;
                Console.WriteLine(Math.Round(s, 3));
            }
            else if (form == "triangle")
            {
                Console.Write("A = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("H = ");
                double h = double.Parse(Console.ReadLine());
                double s = (a * h) / 2;
                Console.WriteLine(Math.Round(s, 3));
            }
        }
    }
}
