using System;

namespace Kissaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on kisseohjelma.");
            Cat myCat = new Cat("tofi", 2);
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
                Console.WriteLine("Anna kissalle ruokaa painamalla k, lopeta painamalla e:");
                string k = Console.ReadLine();
                if (k == "k")
                    x = x + 1;
                else if (k == "e")
                    break;
                Console.Clear();
            } while (x < 10);
            
            return x;
        }
    }
}
