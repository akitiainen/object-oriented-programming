using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace VehicleApp
{
    class Vehicle
    {
        protected string _type;
        protected string _brand;
        protected string _year;
        protected double _price;

        public Vehicle()
        {
            
        }



        public virtual void PrintInfo()
        {
            Console.WriteLine($"brand:t\t{_brand}" +
                $"manufacturing year:\t{_year}" +
                $"price\t\t{_price.ToString("c", CultureInfo.CurrentCulture)}");
        }
    }


}
