using System;
using System.Collections.Generic;

namespace LiteratureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                List<Book> list = new List<Book>();
                list.Add(new Book("Harry Potter ja Viisasten Kivi", "J.K. Rowling", "Tammi", 24.95));
                Intro();
                foreach (Book book in list)
                {
                    book.Price = book._price;
                }
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        list.Add(new Book());
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        foreach (Book book in list)
                        {
                            Console.WriteLine(book.GetBook(book.title));
                        }
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Hae kirjaa nimellä:");
                        string search = Console.ReadLine();
                        break;

                    case ConsoleKey.D4:
                        break;

                    case ConsoleKey.X:
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                }
                Console.ReadKey();
                Console.Clear();
                

                
                Book.ChangeTheme();
                Console.WriteLine("Paina näppäintä vaihtaaksesi teemaa");
                Console.ReadKey();
                Console.Clear();
                
            }
        }

        static void Intro()
        {
            Console.WriteLine("1. luo uusi kirja\n" +
                "2. tulosta lista kirjoista\n" +
                "3. etsi kirjaa nimellä\n" +
                "4. vaihda kirjojen teema\n" +
                "X. poistu ohjelmasta");
        }
    }
}
