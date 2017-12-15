using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double years = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            if (gender == 'm' && years < 16)
            {
                Console.WriteLine("Master");
            }
            else if (gender == 'm' && years >= 16)
            {
                Console.WriteLine("Mr.");
            }
            if (gender == 'f' && years < 16)
            {
                Console.WriteLine("Miss");
            }
            else if (gender == 'f' && years >= 16)
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
