using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int addMinutes = 15;
            double hour1 = (minutes + addMinutes) / 60;
            double minutes1 = (minutes + addMinutes) % 60;
            double allHours = hour + hour1;
            double allMinutes = minutes1;
            if (allHours == 24)
            {
                allHours = 0;
            }
            Console.WriteLine($"{allHours}:{allMinutes:00}");
        }
    }
}
