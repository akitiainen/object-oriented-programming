using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Kirjaohjelma
{
    class Book
    {
        public string title;
        public string author;
        public string id;
        public decimal price;

        public Book(string title, string author, string id, decimal price)
        {
            this.title = title;   
            this.author = author;
            this.id = id;
            this.price = price;
        }

        public string PrintInfo()
        {
            return  $"Kirjan nimi: {this.title}\n" +
                    $"Kirjoittaja: {this.author}\n" +
                    $"Kirjan id-numero: {this.id}\n" +
                    $"Kirjan hinta: {this.price.ToString("C", CultureInfo.CurrentCulture)}\n";
        }

        public string CompareBooks(Book book)
        {
            string text = string.Empty;

            if (this.price > book.price)
                text = $"{this.title} on kalliimpi kuin {book.title}";
            else if (this.price == book.price)
                text = $"Kirjat {this.title} ja {book.title} ovat saman hintaisia.";
            else
                text = $"{book.title} on kalliimpi kuin {this.title}";
            return text;
        }
        

        
    }
}
