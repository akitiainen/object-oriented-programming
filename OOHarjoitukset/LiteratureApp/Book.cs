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
        public double _price;
        public static string theme;

        public Book(string title, string author, string publisher, double price, string bookTheme)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            _price = price;
            theme = bookTheme;
        }

        public Book()
        {
        }

        public void GetBook(string title)
        {
            string s = string.Empty;
            if (this.title == title)
                s = $"title:\t\t{title}\nauthor:\t\t{author}\npublisher:\t{publisher}\n" +
                    $"price:\t\t{_price.ToString("c", CultureInfo.CurrentCulture)}\n" +
                    $"theme:\t\t{theme}\n____________________________________\n";
            else
                s = $"Kirjaa {title} ei löydy!";
            Console.WriteLine(s);
        }

        public void PrintBook()
        {
             Console.WriteLine($"title:\t\t{title}\npublisher:\t{publisher}\n" +
                    $"price:\t\t{_price.ToString("c", CultureInfo.CurrentCulture)}\n" +
                    $"theme:\t\t{theme}\n____________________________________\n");
        }

        public static void ChangeTheme()
        {
            Console.WriteLine("Annas uus teema");
            theme = Console.ReadLine();
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 30)
                {
                    _price = value * 0.9;
                }
                else
                {
                    _price = value;
                }
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
        }
    }
}
