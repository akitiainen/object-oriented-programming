using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    interface ICustomer
    {
        Customer GetCustomer(string name);
        double GetBonus();
    }
    class Customer : ICustomer
    {
        public string name;
        public double purchases;

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        public override string ToString()
        {
            return $"Name: {name}\tPurchases: {purchases:F2} €";
        }

        Customer ICustomer.GetCustomer(string name)
        {
            if (name == this.name)
                return this;
            else
                return null;
        }

        double ICustomer.GetBonus()
        {
            if (purchases <= 1000)
                return purchases * 0.02;
            else if (purchases <= 2000)
                return purchases * 0.03;
            else
                return purchases * 0.05;
        }
    }
}
