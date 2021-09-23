using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankIS.MVC_WebApp
{
    public class Address
    {
        public Address()
        {

        }
        public Address(string street, string city)
        {
            Street = street;
            City = city;
        }

        public int Id { get; set; }
        public string Street { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public void Print()
        {
            Console.WriteLine("Ulice: {0}, Město {1}", Street, City);
        }

    }
}