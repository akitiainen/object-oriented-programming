using System;

namespace LiteratureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book book = new Book("Harry Potter ja Viisasten Kivi", "J.K. Rowling", "Tammi", 24.95);
            Book book2 = new Book();
            Console.Clear();
            Console.WriteLine(book.GetBook(book));
            Console.WriteLine(book2.GetBook(book2));
            Book.ChangeTheme();
            Console.WriteLine("Paina näppäintä vaihtaaksesi teemaa");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(book.GetBook(book));
            Console.WriteLine(book2.GetBook(book2));

        }
    }
}
