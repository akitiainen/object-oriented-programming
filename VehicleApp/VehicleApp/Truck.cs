using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleApp
{
    class Truck : Car
    {
        protected int loadWeight;
        protected int consumptionPerKg;

        public Truck()
        {
            loadWeight = 0;
            consumptionPerKg = 0;
        }

        public Truck(double engineSize, string model, int doorAmount, string type, string brand, double year, double price, int loadWeight, int consumptionPerKg):
            base(engineSize, model, doorAmount, type, brand, year, price)
        {
            this.loadWeight = loadWeight;
            this.consumptionPerKg = consumptionPerKg;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void CalculateConsumption()
        {
            Console.WriteLine($"{this.ToString()}\n" +
                $"Consumption:\t{loadWeight * consumptionPerKg} l/100km");
        }
    }
}
