using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TicketPriceProgram
{
    class Ticket
    {
        public double price = 16;
        public double discount = 0;
        public Ticket()
        {

        }

        public void Calculator(Person person)
        {
            if (person.Age < 7)
                discount = 1;
            else if (person.Age < 15 || person.Age > 65)
                discount = 0.5;
            this.price = this.price - this.price * this.discount;
        }

        public void PrintTicketPrice()
        {
            Console.WriteLine($"Lipun hinta on {price.ToString("c", CultureInfo.CurrentCulture)}");
        }
    }
}
