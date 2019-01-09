using System;

namespace Kirjaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kirjaohjelma\n");
            
            Book newBook = new Book("Aapinen",
                                    "Mikael Agricola",
                                    "00001",
                                    17.50M);
            Console.WriteLine(newBook.PrintInfo());
            Console.ReadKey();

            Book newBook2 = new Book("lol xd", "iids", "10500", 1000500.12M);
            Console.WriteLine(newBook2.PrintInfo());
            Console.ReadKey();

            Console.WriteLine(newBook.CompareBooks(newBook2));
            Console.ReadKey();
        }
    }
}
