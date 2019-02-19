using System;
using System.Collections.Generic;
using System.Text;

namespace LiteratureApp
{
    class Author
    {
        private string _name;
        private string _birthday;
        public Book _book;

        public Author()
        {
            this._name = string.Empty;
            this._birthday = string.Empty;
            this._book = new Book();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        public Book Book
        {
            get { return _book; }
            set { _book = value; }
        }

        public void PrintAuthor()
        {
            Console.WriteLine($"author:\t\t{this.Name}\n" +
                $"birthday:\t{this.Birthday}");
            this.Book.PrintBook();
        }
    }
}
