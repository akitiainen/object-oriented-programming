using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    interface IProduct
    {
        void GetProduct();
        void CalculateTotal();
    }
    class Product : IProduct
    {
        protected string name;
        protected double price;
        protected int count;

        void IProduct.GetProduct()
        {

        }

        void IProduct.CalculateTotal()
        {

        }
    }
}
