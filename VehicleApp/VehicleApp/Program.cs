using System;
using System.Collections.Generic;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car(3.0, "911", 3, "Coupé", "Porsche", 1987, 100500),
                new Car(2.0, "Avensis", 5, "Sedan", "Toyota", 2008, 1000),
                new Truck(5, "sporttine", 3, "tyllerö", "iids", 1999, 100500, 65, 12)
            };

            while (true)
            {
                Intro();
                var input = Console.ReadKey();
                switch (input.Key)
                {

                    case ConsoleKey.D1:
                        Console.Clear();
                        foreach (var item in vehicles)
                        {
                            item.PrintInfo();
                            Console.WriteLine("_______________________________\n");
                        }
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        if (vehicles[0].Equals(vehicles[1]))
                            Console.WriteLine("listan ensimmäinen auto on sama kuin toinen auto");
                        else
                            Console.WriteLine("listan ensimmäinen auto on eri kuin toinen auto");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Truck truck = (Truck)vehicles[2];
                        truck.CalculateConsumption();
                        Console.WriteLine("_______________________________\n");
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
            Console.WriteLine("Tämä on ajoneuvo-ohjelma\n" +
                "1. Tulosta lista ajoneuvoista\n" +
                "2. Vertaile listan ajoneuvoja\n" +
                "3. Laske rekka-tyypin ajoneuvojen kulutus\n" +
                "X. Lopeta ohjelma");
        }
    }
}
