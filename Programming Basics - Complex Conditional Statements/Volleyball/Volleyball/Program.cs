using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double weekendInSofia = ((double)(48 - h)) * 3 / 4;
            double holidays = (double)p * 2 / 3;
            double totalDays = weekendInSofia + holidays + h;

            if (typeYear == "leap")
            {
                double bonusDays = totalDays * 0.15;
                double totalDaysInYear = bonusDays + totalDays;
                Console.WriteLine((int)totalDaysInYear);
            }
            else
            {
                Console.WriteLine((int)totalDays);
            }

        }
    }
}
