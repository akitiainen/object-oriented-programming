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
                new Product("iids", 100500, 13),
                new Product("ags", 13.25, 5),
                new Product("doge", 100000000, 1)
            };

            productList.ForEach(Console.WriteLine);
            foreach (IProduct item in productList)
            {
                Console.WriteLine(item.CalculateTotal().ToString("c", CultureInfo.CurrentCulture));
            }
            /*product.ToString();
            Console.WriteLine(product.GetProduct("iids"));
            Console.WriteLine(product.CalculateTotal().ToString("c", CultureInfo.CurrentCulture));*/
        }
    }
}
