using Quantum_Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bookstore
{
    internal class BookInventory
    {
        private List<Book> books = new();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Quantum book store: Book added successfully.");
        }

        public void RemoveOutdatedBooks(int maxAge)
        {
            int currentYear = DateTime.Now.Year;
            books.RemoveAll(book => currentYear - book.PublishedYear > maxAge);
            Console.WriteLine("Quantum book store: Outdated books removed.");
        }

        public void BuyBook(string isbn, int quantity, string email, string address)
        {
            var book = books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null)
            {
                Console.WriteLine("Quantum book store: Book not found.");
                return;
            }

            try
            {
                book.Buy(quantity, email, address);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Quantum book store: {ex.Message}");
            }
        }
    }
}
