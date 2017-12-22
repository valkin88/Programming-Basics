using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int runner1 = int.Parse(Console.ReadLine());
            int runner2 = int.Parse(Console.ReadLine());
            int runner3 = int.Parse(Console.ReadLine());
            int minutes = (runner1 + runner2 + runner3) / 60;
            int seconds = (runner1 + runner2 + runner3) % 60;
            Console.WriteLine($"{minutes}:{seconds:00}");
        }
    }
}
