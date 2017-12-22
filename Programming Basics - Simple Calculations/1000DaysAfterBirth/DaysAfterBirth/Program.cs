using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime date = System.DateTime.Parse(Console.ReadLine());
            DateTime result = date.AddDays(1000);
            Console.WriteLine("{0:dd-MM-yyyy}", result);
        }
    }
}
