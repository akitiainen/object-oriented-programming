using System;

namespace LiteratureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book ass = new Book();
            Console.Clear();
            Console.WriteLine(ass.GetBook(ass));

        }
    }
}
