using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int x2 = h * 3;
            int x3 = h;
            int x4 = h * 2;
            int y1 = 0;
            int y2 = h;
            int y3 = h;
            int y4 = h * 4;

            if (((x > x1 && x < x2) && (y > y1 && y < y2)) || ((x > x3 && x < x4) && (y > y3 && y < y4)))
            {
                Console.WriteLine("inside");
            }
            else if ((x > x3 && x < x4) && (y == y3))
            {
                Console.WriteLine("inside");
            }
            else if ((((x >= x1 && x <= x2) && (y == y1 || y == y2)) || ((y >= y1 && y <= y2) && (x == x1 || x == x2))) || (((x >= x3 && x <= x4) && (y == y3 || y == y4)) || ((y >= y3 && y <= y4) && (x == x3 || x == x4))))
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
