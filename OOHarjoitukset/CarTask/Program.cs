using System;

namespace CarTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car();
            auto.AskData();
            Console.ReadKey();
            auto.ShowCarInfo();
            Console.ReadKey();
        }
    }
}
