using System;

namespace Kissaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on iidaohjelma.");
            Cat myCat = new Cat("iids", 2);
            myCat.GainWeight(Gain());
            myCat.PrintWeight();
            Console.WriteLine("_________________________________________");
            //Cat myNewCat = new Cat("tofi" , 3);
            //myNewCat.GainWeight(Gain());
            //myNewCat.PrintWeight();

            Console.ReadKey();
        }

        static int Gain()
        {
            int x = 0;
            do
            {
                Console.WriteLine("Anna iidalle ruokaa painamalla k, lopeta painamalla e:");
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.K)
                {
                    x += 1;
                    Console.Clear();
                }
                else if (input.Key == ConsoleKey.E)
                    break;

            } while (x < 15);
            
            return x;
        }
    }
}
