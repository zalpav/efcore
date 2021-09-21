using System;
using System.Collections.Generic;
using System.Text;

namespace BankIS.ConsoleApp
{
    public class Client
    {
        public Client(string Name, int Age, Address address)
        {
            HomeAddress = address;
        }
        /// <summary>
        /// Jméno klienta
        /// </summary>
        public string Name { get; set; }

        public int Age { get; set; }

        public Address HomeAddress { get; set; }

        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            if (HomeAddress != null && !string.IsNullOrEmpty(HomeAddress.Street))
            {
                Console.WriteLine(HomeAddress.Street);
                Console.WriteLine(HomeAddress.City);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Adresa nezdána");
            }
        }
    }
}
