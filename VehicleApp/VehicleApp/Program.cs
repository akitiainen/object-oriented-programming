using System;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Car firstCar = new Car()
            {
                Type = "Coupé",
                Brand = "Porsche",
                Year = 1987,
                Price = 100500,
                EngineSize = 3.0,
                Model = "911",
                Doors = 3
            };

            Car copyCar = firstCar;

            firstCar.PrintInfo();
            Console.WriteLine("_______________________________\n");
            if(firstCar.Equals(copyCar))
                Console.WriteLine("autot o samat");
            else
                Console.WriteLine("autot o erit");
        }
    }
}
