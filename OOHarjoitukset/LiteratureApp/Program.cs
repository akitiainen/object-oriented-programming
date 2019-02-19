using System;
using System.Collections.Generic;

namespace LiteratureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book book1 = new Book("Harry Potter ja Viisasten Kivi", "J.K. Rowling", "Tammi", 24.95, "Fantasia");
            Book book2 = new Book("Velho ja Leijona", "C.S. Lewis", "Otava", 35, "Fantasia");

            Author author = new Author
            {
                Name = "J.K. Rowling",
                Birthday = "31.7.1965",
                Book = book1
            };

            Author author2 = new Author
            {
                Name = "C.S. Lewis",
                Birthday = "29.11.1898",
                Book = book2
            };

            while (true)
            {
                Intro();
                
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        book1.GetBook(book1.title);
                        book2.GetBook(book2.title);
                        Console.WriteLine("Paina näppäintä palataksesi alkuvalikkoon...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Book.ChangeTheme();
                        Console.WriteLine("Paina näppäintä vaihtaaksesi teemaa");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        book1.Price = book1._price;
                        book2.Price = book2._price;
                        Console.WriteLine("Kirjojen uudet hinnat ovat nyt laskettu!");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        author.PrintAuthor();
                        author2.PrintAuthor();
                        Console.WriteLine("Paina näppäintä jatkaaksesi...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.X:
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                }
                Console.Clear();
            }
        }

        static void Intro()
        {
            Console.WriteLine("1. tulosta lista kirjoista\n" +
                "2. vaihda kirjojen teema\n" +
                "3. laske kirjoille alennus\n" +
                "4. tulosta kirjailijoiden tiedot\n" +
                "X. poistu ohjelmasta");
        }
    }
}
