using Quantum_Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bookstore.Tests
{
    internal class BookstoreTest1
    {
        public static void Run()
        {
            BookInventory inventory = new();

            inventory.AddBook(new PaperBook("0000", "C#", "Mohamady", 2008, 50, 10));
            inventory.AddBook(new EBook("1111", "SQL", "Desoky", 1999, 30, "pdf"));
            inventory.AddBook(new ShowcaseBook("2222", "CPP", "Nasim", 1994, 0));

            inventory.BuyBook("0000", 2, "haisam_2@gmail.com", "Cairo");
            inventory.BuyBook("1111", 1, "ali_6@gmail.com", "Alex");
            inventory.BuyBook("2222", 1, "samy_20@gmail.com", "Giza");

            inventory.RemoveOutdatedBooks(20);
        }
    }
}
