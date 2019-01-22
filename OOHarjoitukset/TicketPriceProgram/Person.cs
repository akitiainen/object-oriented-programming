using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPriceProgram
{
    class Person
    {
        private int _age;
        public bool conscript = false;
        public bool mtk = false;
        public bool student = false;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 130)
                    Console.WriteLine("Ikä pitää olla välillä 0 ja 130.");
                else
                    _age = value;
            }
        }

        public Person()
        {
            _age = -1;
        }

        public void AskConscript()
        {
            Console.Clear();
            Console.WriteLine("Oletko varusmies? K/E");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.K)
                conscript = true;
            else if (input.Key == ConsoleKey.E)
                conscript = false;
            else
                Console.WriteLine("homo");
        }

        public void AskMTK()
        {
            Console.Clear();
            Console.WriteLine("Oletko MTK:n jäsen? K/E");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.K)
                mtk = true;
            else if (input.Key == ConsoleKey.E)
                mtk = false;
            else
                Console.WriteLine("homo");
        }

        public void Print()
        {
            Console.WriteLine(_age);
        }
    }
}
