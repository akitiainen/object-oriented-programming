using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LiteratureApp
{
    class Book
    {
        public string title;
        public string author;
        public string publisher;
        public double price;
        public static string theme;

        public Book()
        {
            Console.WriteLine("Syötä kirjan nimi:");
            title = Console.ReadLine();
            Console.WriteLine("Syötä kirjailijan:");
            author = Console.ReadLine();
            Console.WriteLine("Syötä julkaisija:");
            publisher = Console.ReadLine();
            Console.WriteLine("Syötä kirjan hinta:");
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("syötä hinta numeroina");
            }
            Console.WriteLine("Syötä kirjan teema:");
            theme = Console.ReadLine();
        }

        public string GetBook(Book book)
        {
            string s = string.Empty;
            if (book.title != title)
            {
                s = "väärä kirja lol";
            }
            else
            {
                s = $"title:\t{title}\nauthor:\t{author}\npublisher:\t{publisher}\n" +
                    $"price:\t{price.ToString("c", CultureInfo.CurrentCulture)}\n" +
                    $"theme:\t{theme}";
            }
            return s;
        }

        public static void ChangeTheme()
        {

        }
    }
}
