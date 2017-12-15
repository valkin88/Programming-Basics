using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = -1.0;
            double total = 0.0;

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    price = 0.50;
                    total = quantity * price;
                    Console.WriteLine(total);
                }
                else if (product == "water")
                {
                    price = 0.80;
                    total = quantity * price;
                    Console.WriteLine(total);
                }
                else if (product == "beer")
                {
                    price = 1.20;
                    total = quantity * price;
                    Console.WriteLine(total);
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                    total = quantity * price;
                    Console.WriteLine(total);
                }
                else if (product == "peanuts")
                {
                    price = 1.60;
                    total = quantity * price;
                    Console.WriteLine(total);
                }
            }
            if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                        price = 0.40;
                        total = quantity * price;
                        Console.WriteLine(total);
                }
                else if (product == "water")
                {
                        price = 0.70;
                        total = quantity * price;
                        Console.WriteLine(total);
                }
                else if (product == "beer")
                {
                        price = 1.15;
                        total = quantity * price;
                        Console.WriteLine(total);
                }
                else if (product == "sweets")
                {
                        price = 1.30;
                        total = quantity * price;
                        Console.WriteLine(total);
                }
                else if (product == "peanuts")
                {
                        price = 1.50;
                        total = quantity * price;
                        Console.WriteLine(total);
                }
            }
            if (town == "varna")
            {
                if (product == "coffee")
                {
                            price = 0.45;
                            total = quantity * price;
                            Console.WriteLine(total);
                }
                else if (product == "water")
                {
                            price = 0.70;
                            total = quantity * price;
                            Console.WriteLine(total);
                }
                else if (product == "beer")
                {
                            price = 1.10;
                            total = quantity * price;
                            Console.WriteLine(total);
                }
                else if (product == "sweets")
                {
                            price = 1.35;
                            total = quantity * price;
                            Console.WriteLine(total);
                }
                else if (product == "peanuts")
                {
                            price = 1.55;
                            total = quantity * price;
                            Console.WriteLine(total);
                }
            }
        }
    }
}