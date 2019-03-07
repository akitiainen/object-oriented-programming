using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    interface IProducts
    {
        void AddProduct(Product product);
        void PrintProducts();
    }

    interface ICustomers
    {
        void AddCustomer(Customer customer);
        void PrintCustomers();
    }
    class Store : IProducts, ICustomers
    {
        public string name;
        public double revenue;

        public List<Customer> customerList = new List<Customer>()
            {
            };

        public List<Product> productList = new List<Product>()
            {
            };

        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
        }

        void IProducts.AddProduct(Product product)
        {
            productList.Add(product);
        }

        void ICustomers.AddCustomer(Customer customer)
        {
            customerList.Add(customer);
        }

        void IProducts.PrintProducts()
        {
            foreach (var p in productList)
            {
                Console.WriteLine(p);
            }
        }

        void ICustomers.PrintCustomers()
        {
            foreach (var c in customerList)
            {
                Console.WriteLine(c);
            }
        }

        public override string ToString()
        {
            return $"store name: {name}\n" +
                $"revenue: {revenue}\n" +
                $"customers: {customerList.Count}\n" +
                $"products: {productList.Count}";
        }
    }
}
