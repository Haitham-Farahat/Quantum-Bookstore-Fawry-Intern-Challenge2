using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bookstore.Models
{
    public abstract class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }
        public decimal Price { get; set; }

        public Book(string isbn, string title, string author, int year, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            PublishedYear = year;
            Price = price;
        }

        public abstract void Buy(int quantity, string email, string address);
    }
}
