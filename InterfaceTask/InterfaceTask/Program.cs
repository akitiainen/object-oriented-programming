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
                new Product("kalja", 100500, 13),
                new Product("olut", 13.25, 5),
                new Product("bishe", 100000000, 1)
            };

            List<Customer> customerList = new List<Customer>()
            {
                new Customer("iids", 5000),
                new Customer("ags", 1200),
                new Customer("pate", 3)
            };

            productList.ForEach(Console.WriteLine);
            Console.WriteLine("____________________________\n");

            foreach (IProduct item in productList)
            {
                Console.WriteLine(item.CalculateTotal().ToString("c", CultureInfo.CurrentCulture));
            }

            Console.WriteLine("____________________________\n");

            int i = 0;
            foreach (ICustomer item in customerList)
            {

                Console.WriteLine($"{customerList[i]}\tBonus: {item.GetBonus().ToString("c", CultureInfo.CurrentCulture)}");
                i++;
            }
            /*product.ToString();
            Console.WriteLine(product.GetProduct("iids"));
            Console.WriteLine(product.CalculateTotal().ToString("c", CultureInfo.CurrentCulture));*/
        }
    }
}
