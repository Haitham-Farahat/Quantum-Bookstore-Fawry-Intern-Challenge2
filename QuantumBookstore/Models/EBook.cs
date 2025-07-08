using Quantum_Bookstore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bookstore.Models
{
    internal class EBook:Book
    {
        public string FileType { get; private set; }

        public EBook(string isbn, string title, string author, int year, decimal price, string fileType)
            : base(isbn, title, author, year, price)
        {
            FileType = fileType;
        }

        public override void Buy(int quantity, string email, string address)
        {
            Console.WriteLine($"Quantum book store: EBook bought. Total = {Price * quantity:C}");
            MailService.Send(email);
        }
    }
}
