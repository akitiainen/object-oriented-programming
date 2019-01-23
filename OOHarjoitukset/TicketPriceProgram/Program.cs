using System;

namespace TicketPriceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Person newPerson = CreatePerson();
            Ticket ticket = CreateTicket(newPerson);
            PrintInfo(newPerson, ticket);
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
            firstPerson.AskStudent();
            return firstPerson;
        }

        static Ticket CreateTicket(Person x)
        {
            Ticket ticket = new Ticket();
            ticket.Calculator(x);
            return ticket;
        }

        static void PrintInfo(Person x, Ticket y)
        {
            x.Print();
            y.PrintTicketPrice();
        }
    }
}
