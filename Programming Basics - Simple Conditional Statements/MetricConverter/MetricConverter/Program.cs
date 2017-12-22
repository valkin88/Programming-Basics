using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            double num = double.Parse(Console.ReadLine());
            Console.Write("Enter Metric1 (m, mm, cm, mi, in, km, ft, yd): ");
            string met1 = Console.ReadLine();
            Console.Write("Enter Metric2 (m, mm, cm, mi, in, km, ft, yd): ");
            string met2 = Console.ReadLine();
            double meter = 1;
            double milimeter = 1000;
            double centimeter = 100;
            double mile = 0.000621371192;
            double inch = 39.3700787;
            double kilometer = 0.001;
            double feet = 3.2808399;
            double yard = 1.0936133;
            if (met1 == "m")
            {
                num = num * meter;
            }
                else if (met1 == "mm")
                {
                    num = num / milimeter;
                }
                else if (met1 == "cm")
                {
                    num = num / centimeter;
                }
                else if (met1 == "mi")
                {
                    num = num / mile;
                }
                else if (met1 == "in")
                {
                    num = num / inch;
                }
                else if (met1 == "km")
                {
                    num = num / kilometer;
                }
                else if (met1 == "ft")
                {
                    num = num / feet;
                }
                else if (met1 == "yd")
                {
                num = num / yard;
                }
            if (met2 == "m")
            {
                num = num * meter;
            }
            else if (met2 == "mm")
            {
                num = num * milimeter;
            }
            else if (met2 == "cm")
            {
                num = num * centimeter;
            }
            else if (met2 == "mi")
            {
                num = num * mile;
            }
            else if (met2 == "in")
            {
                num = num * inch;
            }
            else if (met2 == "km")
            {
                num = num * kilometer;
            }
            else if (met2 == "ft")
            {
                num = num * feet;
            }
            else if (met2 == "yd")
            {
                num = num * yard;
            }
            Console.WriteLine(Math.Round(num, 8));
        }
    }
}
