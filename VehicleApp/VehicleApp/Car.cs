using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace VehicleApp
{
    class Car : Vehicle
    {
        protected double engineSize;
        protected string model;
        protected int doorAmount;

        public Car()
        {
        }

        //public Car(double engineSize, string model, int doorAmount, string type, string brand, double year, double price)
        //{
        //    this.engineSize = engineSize;
        //    this.model = model;
        //    this.doorAmount = doorAmount;
        //    this.type = type;
        //    this.brand = brand;
        //    this.year = year;
        //    this.price = price;
        //}

        public double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Doors
        {
            get { return doorAmount; }
            set { doorAmount = value; }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Engine size:\t{engineSize:F1}\n" +
                $"Model:\t\t{model}\n" +
                $"Doors:\t\t{doorAmount}");
        }

        public override string ToString()
        {
            return $"Type:\t\t{type}\n" +
                $"Brand:\t\t{brand}\n" +
                $"Year:\t\t{year}\n" +
                $"Price\t\t{price.ToString("c", CultureInfo.CurrentCulture)}\n" +
                $"Engine size:\t{engineSize:F1}\n" +
                $"Model:\t\t{model}\n" +
                $"Doors:\t\t{doorAmount}";
        }

        public override bool Equals(object obj)
        {
            Car carObj = obj as Car;

            if (carObj == null)
                return false;
            else
            {
                return this.model.Equals(carObj.model) && this.brand.Equals(carObj.brand)
                    && this.doorAmount.Equals(carObj.doorAmount) && this.engineSize.Equals(carObj.engineSize)
                    && this.price.Equals(carObj.price) && this.type.Equals(carObj.type)
                    && this.year.Equals(carObj.year);
            }
        }
    }
}
