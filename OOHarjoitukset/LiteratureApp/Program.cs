using System;
using System.Collections.Generic;

namespace LiteratureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Book> list = new List<Book>
            {
                new Book(),
                new Book("Harry Potter ja Viisasten Kivi", "J.K. Rowling", "Tammi", 24.95)
            };
            Console.Clear();
            Console.WriteLine("Hae kirjaa nimellä:");
            string search = Console.ReadLine();
            foreach (Book book in list)
            {
                Console.WriteLine(book.GetBook(search));
            }
            Book.ChangeTheme();
            Console.WriteLine("Paina näppäintä vaihtaaksesi teemaa");
            Console.ReadKey();
            Console.Clear();
            foreach (Book book in list)
            {
                Console.WriteLine(book.GetBook(book.title));
            }
        }
    }
}
