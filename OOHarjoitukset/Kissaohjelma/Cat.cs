using System;
using System.Collections.Generic;
using System.Text;

namespace Kissaohjelma
{
    class Cat
    {
        public string name;
        public int weight;

        public Cat()
        {
            this.weight = 1;
        }

        public Cat(string name, int weightValue)
        {
            this.name = name;
            this.weight = weightValue;
            Console.WriteLine($"Luotu kissa {this.name}");
            Console.WriteLine($"Kissan {this.name} paino on {this.weight} kg");
            
        }

        public void PrintWeight()
        {
            Console.Clear();
            if (this.weight > 9)
                Console.WriteLine($"Syötit kissaa {this.name} liikaa ja nyt se on läski.");
            else if (this.weight < 5)
                Console.WriteLine($"{this.name} jäi alipainoiseksi ja kuoli :(");
            else
                Console.WriteLine($"Kissan {this.name} paino on nyt {this.weight} kg");
        }

        public void GainWeight(int value)
        {
            this.weight += value;
        }
    }
}
