using System;
using System.Collections.Generic;
using System.Text;

namespace BankIS.ConsoleApp
{
    public class Address
    {
        // Konstruktor
        public Address()
        {

        }
        public Address ( string street, string city)
        {
            Street = street;
            City = city;
        }
        public string Street { get; set; }
        public string City { get; set; }
    }
}
