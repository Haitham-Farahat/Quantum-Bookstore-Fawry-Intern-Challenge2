using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bookstore.Models
{
    internal class ShowcaseBook:Book
    {
        public ShowcaseBook(string isbn, string title, string author, int year, decimal price)
        : base(isbn, title, author, year, price)
        {
        }

        public override void Buy(int quantity, string email, string address)
        {
            throw new Exception("Quantum book store: Showcase books are not for sale.");
        }
    }
}
