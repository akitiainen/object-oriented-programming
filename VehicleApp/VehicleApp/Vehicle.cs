using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace VehicleApp
{
    abstract class Vehicle
    {
        protected string type;
        protected string brand;
        protected double year;
        protected double price;

        public Vehicle()
        {
        }

        public Vehicle(string type, string brand, double year, double price)
        {
            this.type = type;
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Type:\t\t{type}\n" +
                $"Brand:\t\t{brand}\n" +
                $"Year:\t\t{year}\n" +
                $"Price\t\t{price.ToString("c", CultureInfo.CurrentCulture)}");
        }
    }


}
