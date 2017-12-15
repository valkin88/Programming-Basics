using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double comission = -1.0;
            double total = 0.0;

            if (sales >= 0 && sales <= 500)
            {
                if (town == "sofia")
                {
                    comission = 0.05;
                }
                else if (town == "varna")
                {
                    comission = 0.045;
                }
                else if (town == "plovdiv")
                {
                    comission = 0.055;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                if (town == "sofia")
                {
                    comission = 0.07;
                }
                else if (town == "varna")
                {
                    comission = 0.075;
                }
                else if (town == "plovdiv")
                {
                    comission = 0.08;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                if (town == "sofia")
                {
                    comission = 0.08;
                }
                else if (town == "varna")
                {
                    comission = 0.1;
                }
                else if (town == "plovdiv")
                {
                    comission = 0.12;
                }
            }
            else if (sales > 10000)
            {
                if (town == "sofia")
                {
                    comission = 0.12;
                }
                else if (town == "varna")
                {
                    comission = 0.13;
                }
                else if (town == "plovdiv")
                {
                    comission = 0.145;
                }
            }
            if (comission > 0)
            {
                total = sales * comission;
                Console.WriteLine($"{total:0.00}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
