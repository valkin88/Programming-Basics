using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Sum = ");
            double sum = double.Parse(Console.ReadLine());
            Console.Write("Enter Currency1: ");
            string cur1 = Console.ReadLine();
            Console.Write("Enter Currency2: ");
            string cur2 = Console.ReadLine();
            double bgn = 1;
            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;
            double sum2;
            if (cur1 == "BGN")
            {
                   if (cur2 == "USD")
                   {
                    sum2 = sum / usd;
                    Console.WriteLine(Math.Round(sum2, 2));
                   }
                   else if (cur2 == "EUR")
                   {
                    sum2 = sum / eur;
                    Console.WriteLine(Math.Round(sum2, 2));
                   }
                   else if (cur2 == "GBP")
                   {
                    sum2 = sum / gbp;
                    Console.WriteLine(Math.Round(sum2, 2));
                   }
            }
            if (cur1 =="USD")
            {
                if (cur2 =="BGN")
                {
                    sum2 = sum * usd;
                    Console.WriteLine(Math.Round(sum2, 2));
                }
                else if (cur2 == "EUR")
                {
                    sum2 = sum * (usd / eur);
                    Console.WriteLine(Math.Round(sum2, 2));
                }
                else if (cur2 == "GBP")
                {
                    sum2 = sum * (usd / gbp);
                    Console.WriteLine(Math.Round(sum2, 2));
                }
            }
            if (cur1 == "EUR")
            {
                if (cur2 == "BGN")
                {
                    sum2 = sum * eur;
                    Console.WriteLine(Math.Round(sum2, 2));
                }
                else if (cur2 == "USD")
                {
                    sum2 = sum * (eur / usd);
                    Console.WriteLine(Math.Round(sum2, 2));
                }
                else if (cur2 == "GBP")
                {
                    sum2 = sum * (eur / gbp);
                    Console.WriteLine(Math.Round(sum2, 2));
                }
            }
            if (cur1 == "GBP")
            {
                if (cur2 == "BGN")
                {
                    sum2 = sum * bgn;
                    Console.WriteLine(Math.Round(sum2, 2));
                }
                else if (cur2 == "USD")
                {
                    sum2 = sum * (gbp / usd);
                    Console.WriteLine(Math.Round(sum2, 2));
                }
                else if (cur2 == "EUR")
                {
                    sum2 = sum * (gbp / eur);
                    Console.WriteLine(Math.Round(sum2, 2));
                }
            }
        }
    }
}
