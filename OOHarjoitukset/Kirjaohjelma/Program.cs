using System;

namespace Kirjaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Intro();
            Book newBook = new Book("Aapinen",
                                    "Mikael Agricola",
                                    "00001",
                                    17.50M);
            Book newBook2 = new Book("lol xd", "iids", "10500", 1000500.12M);
            var input = Console.ReadKey();
            switch (input.Key)
            {
                
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine(newBook.PrintInfo());
                    Console.WriteLine(newBook2.PrintInfo());
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine(newBook.CompareBooks(newBook2));
                    break;
            }

            
            Console.ReadKey();
        }

        static void Intro()
        {
            Console.WriteLine("Tämä on kirjaohjelma. Valitse aliohjelma painamalla numeroa\n" +
                                "1. Tulostaa tallennetut kirjat\n" +
                                "2. Vertailee kirjojen hintoja");
        }
    }
}
