using Quantum_Bookstore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bookstore.Models
{
    public class PaperBook:Book
    {
        public int Stock { get; private set; }

        public PaperBook(string isbn, string title, string author, int year, decimal price, int stock)
            : base(isbn, title, author, year, price)
        {
            Stock = stock;
        }

        public override void Buy(int quantity, string email, string address)
        {
            if (quantity > Stock)
                throw new Exception("Quantum book store: Not enough stock");

            Stock -= quantity;
            Console.WriteLine($"Quantum book store: Paper book bought. Total = {Price * quantity:C}");

            ShippingService.Send(address);
        }
    }
}
