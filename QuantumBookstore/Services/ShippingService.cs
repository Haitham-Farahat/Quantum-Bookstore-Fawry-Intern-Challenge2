using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bookstore.Services
{
    internal class ShippingService
    {
        public static void Send(string address)
        {
            Console.WriteLine($"Quantum book store: Book is being shipped to {address}");
        }
    }
}
