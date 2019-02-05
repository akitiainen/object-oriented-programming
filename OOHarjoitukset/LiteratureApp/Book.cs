﻿using System;
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
        
        public Book(string title, string author, string publisher, double price)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.price = price;
            
        }
        public Book()
        {
            Console.WriteLine("Syötä kirjan nimi:");
            title = Console.ReadLine();
            Console.WriteLine("Syötä kirjailija:");
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
                s = $"title:\t\t{title}\nauthor:\t\t{author}\npublisher:\t{publisher}\n" +
                    $"price:\t\t{price.ToString("c", CultureInfo.CurrentCulture)}\n" +
                    $"theme:\t\t{theme}\n____________________________________\n";
            }
            return s;
        }

        public static void ChangeTheme()
        {
            Console.WriteLine("Annas uus teema");
            theme = Console.ReadLine();
        }
    }
}
