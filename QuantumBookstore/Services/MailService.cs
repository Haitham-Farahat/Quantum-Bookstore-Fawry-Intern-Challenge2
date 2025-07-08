using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bookstore.Services
{
    internal class MailService
    {
        public static void Send(string email)
        {
            Console.WriteLine($"Quantum book store: EBook sent to {email}");
        }
    }
}
