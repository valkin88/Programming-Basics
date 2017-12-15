using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double result = 0.0;

            if (type == "premiere")
            {
                result = row * col * 12.00;
                Console.WriteLine($"{result:0.00}");
            }
            else if (type == "normal")
            {
                result = row * col * 7.5;
                Console.WriteLine($"{result:0.00}");
            }
            else if (type == "discount")
            {
                result = row * col * 5.00;
                Console.WriteLine($"{result:0.00}");
            }
        }
    }
}
