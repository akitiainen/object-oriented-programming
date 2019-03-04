using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace InterfaceTask
{
    interface IProduct
    {
        Product GetProduct(string name);
        double CalculateTotal();
    }
    class Product : IProduct
    {
        public string name;
        public double price;
        public int amount;

        

        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"Name: {name}\tPrice: {price:F2} €\tAmount: {amount}";
        }

        Product IProduct.GetProduct(string name)
        {
            if (this.name == name)
                return this;
            else
                return null;
        }

        double IProduct.CalculateTotal()
        {
            return price * Convert.ToDouble(amount);
        }
    }
}
