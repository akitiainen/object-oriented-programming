using System;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Vehicle firstVehicle = new Vehicle()
            {
                Type = "lääh puuh tyllerö",
                Brand = "iids",
                Year = 1999,
                Price = 10005000.02
            };

            Vehicle secondVehicle = new Vehicle()
            {
                Type = "pojan pyllerö",
                Brand = "aki",
                Year = 1996,
                Price = 7
            };

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

            firstVehicle.PrintInfo();
            Console.WriteLine("_______________________________\n");
            secondVehicle.PrintInfo();
            Console.WriteLine("_______________________________\n");
            Console.WriteLine(firstCar.Equals(firstCar));
        }
    }
}
