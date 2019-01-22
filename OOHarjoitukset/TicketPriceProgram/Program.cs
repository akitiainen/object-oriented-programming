using System;

namespace TicketPriceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = CreatePerson();
            PrintPerson(newPerson);
        }

        static Person CreatePerson()
        {
            int age;
            Person firstPerson = new Person();
            Console.WriteLine("Syötä ikäsi: ");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("ei ole numero lol");
            }
            firstPerson.Age = age;
            firstPerson.AskConscript();
            firstPerson.AskMTK();
            return firstPerson;
        }

        static void PrintPerson(Person x)
        {
            x.Print();
        }
    }
}
