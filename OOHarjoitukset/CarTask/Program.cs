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
                Console.Clear();
                Intro2();
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        ShowInfo(auto);
                        break;

                    case ConsoleKey.D2:
                        Acc(auto);
                        break;

                    case ConsoleKey.D3:
                        Break(auto);
                        break;

                    case ConsoleKey.X:
                        Environment.Exit(0);
                        break;
                }

            } while (true);
        }

        static void Intro()
        {
            Console.WriteLine("Tämä on auto-ohjelma.");
        }

        static void Intro2()
        {
            Console.WriteLine("1. Näytä auton tiedot 2. Lisää auton nopeutta 3. Vähennä auton nopeutta\n" +
                "Paina X lopettaaksesi ohjelman.");
        }
        
        static void Acc(Car car)
        {
            int speed;
            Console.Clear();
            Console.WriteLine("lissääppä noppeutta antamalla numeroita");
            while (!int.TryParse(Console.ReadLine(), out speed))
            {
                Console.Clear();
                Console.WriteLine("yritäppä uusiks ja laita kuule numeroita");
            }
            car.Accelerate(speed);
            Console.WriteLine("Paina enter jatkaaksesi.");
            Console.ReadKey();
        }

        static void Break(Car car)
        {
            Console.Clear();
            car.Brake();
            Console.WriteLine("Paina enter jatkaaksesi.");
            Console.ReadKey();
        }

        static void ShowInfo(Car car)

        {
            Console.Clear();
            car.ShowCarInfo();
            Console.WriteLine("Paina enter jatkaaksesi.");
            Console.ReadKey();
        }
    }
}
