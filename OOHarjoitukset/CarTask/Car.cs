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
            Console.WriteLine($"auton merkki: {this.brand}\n auton nopeus: {this.speed}");
        }

        public void Accelerate(int iSpeed)
        {
           
                
                if (iSpeed >= 0)
                {
                    this.speed += iSpeed;
                    Console.WriteLine($"Nopeutta lisättiin {iSpeed}. Uusi nopeus on nyt {this.speed} km/h. \n");
                }
                else if (iSpeed == 0)
                    Console.WriteLine("Ei muutosta nopeuteen.");
                else
                    Console.WriteLine("Negatiivista muutosta ei sallita.");
            
        }

        public void Brake()
        {
            this.speed = Convert.ToInt32(speed*0.9) ;
            Console.WriteLine($"Nopeutta hidastettiin 10%. Uusi nopeus on {this.speed}");
        }
    }
}
