using System;

namespace CarTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Car auto = new Car();
            auto.AskData();
            Car car = new Car();
            do
            {
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("lissääppä noppeutta antamalla numeroita");
                        auto.Accelerate(int.Parse(Console.ReadLine()));
                        break;

                }

            } while (true);
            

            
            
        }

        static void Intro()
        {
            Console.WriteLine("Tämä on iida-ohjelma.");
        }
    }
}
