using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BankIS.ConsoleApp
{
    public class Client
    {
        public Client(string name, int age, Address address)
        {
            Name = name;
            Age = age;
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
                Console.WriteLine( ToString() );
//                Console.WriteLine(HomeAddress.City);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Adresa nezdána");
            }
        }

        public void SaveToFile(string pathToFile)
        {
            File.WriteAllText(pathToFile, ToString() );
        }

        public override string ToString()
        {
            return $"{Name};{Age};{HomeAddress.City};{HomeAddress.Street}";
        }
    }
}
