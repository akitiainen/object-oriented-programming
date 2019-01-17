using System;


namespace CompanyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("TÄS OIS PARI VIRMAA\n" +
                "______________________\n");
            Company firm = new Company("iidan muansiirtovirma",
                                       "Sorakatu 32, 87300, Lappajärvi",
                                       "0700 123 123",
                                       100000.00M,
                                       78334.43M);

            Company enterprise = new Company(firm);
            enterprise.title = "akin muansiirtovirma";
            enterprise.income = 300456.34M;


            Console.WriteLine(firm.ToString());
            Console.WriteLine(firm.Profit());
            Console.WriteLine("__________________________________\n");
            Console.WriteLine(enterprise.ToString());
            Console.WriteLine(enterprise.Profit());
        }
    }
}
