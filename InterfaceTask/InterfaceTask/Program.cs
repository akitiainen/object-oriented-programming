using System;
using System.Collections.Generic;
using System.Globalization;

namespace InterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> productList = new List<Product>()
            {
                new Product("kalja", 110, 733),
                new Product("olut", 13.25, 999),
                new Product("bishe", 28, 55),
            };

            List<Customer> customerList = new List<Customer>()
            {
                new Customer("iids", 5000),
                new Customer("ags", 1200),
                new Customer("pate", 3)
            };

            Store store = new Store("Akin kalia kauppa", 100500);

            
            foreach (var item in productList)
            {
                store.AddProduct(item);
            }
            
            foreach (var item in customerList)
            {
                store.AddCustomer(item);
            }

            while (true)
            {
                Console.Clear();
                Intro();
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(store.ToString());
                        Console.WriteLine("_________________________\n");
                        Console.WriteLine("Paina näppäintä jatkaaksesi...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        store.PrintCustomers();
                        Console.WriteLine("Paina näppäintä jatkaaksesi...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        store.PrintProducts();
                        Console.WriteLine("Paina näppäintä jatkaaksesi...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.X:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void Intro()
        {
            Console.WriteLine("Tämä ohjelma kertoo kaupan tilanteen.\n" +
                "1. Tulosta kaupan tiedot\n" +
                "2. Tulosta asiakkaiden tiedot\n" +
                "3. Tulosta tuotetiedot\n" +
                "X. Poistu ohjelmasta");
        }
    }
}
