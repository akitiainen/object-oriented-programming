using System;
using System.Collections.Generic;
using System.Text;

namespace CarTask
{
    class Car
    {
        public string brand;
        public int speed;

        public Car()
        {
            this.brand = null;
            this.speed = 0;
        }

        public void AskData()
        {
            Console.WriteLine("Syötä auton merkki: ");
            this.brand = Console.ReadLine();
            Console.WriteLine("Kuis kovaa auto kulkee???");
            while(!int.TryParse(Console.ReadLine(), out this.speed))
            {
                Console.Clear();
                Console.WriteLine("yritäppä uusiks ja laita kuule numeroita");

            }
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"auton merkki: {this.brand}\nauton nopeus: {this.speed}");
        }
    }
}
