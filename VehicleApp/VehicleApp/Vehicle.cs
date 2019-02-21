using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace VehicleApp
{
    class Vehicle
    {
        protected string type;
        protected string brand;
        protected double year;
        protected double price;

        public Vehicle()
        {
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
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
