using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankIS.ConsoleApp
{
    public class Client : IDisposable
    {
        static int Counter = 0;

        public Client()
        {
            HomeAddress = new Address();
            Counter = Counter + 1;
        }

        public Client(string street, string city, string jmeno = "nezadano", int age = -1)
        {
            HomeAddress = new Address();
            HomeAddress.Street = street;
            HomeAddress.City = city;
            Name = jmeno;
            Age = age;
            Counter = Counter + 1;
        }

        public Client(string jmeno = "nezadano", int age = -1)
        {
            HomeAddress = new Address();
            Name = jmeno;
            Age = age;
            Counter = Counter + 1;
        }


        /// <summary>
        /// Jméno klienta
        /// </summary>
        public string Name { get; set; }

        private int _age;
        private bool _isOverAge = false;
        public int Age 
        {
            get
            {
                if (_isOverAge)
                    return _age;
                else
                    return -2;
            } 
            set
            {
                if (value >= 18)
                    _isOverAge = true;
                else
                    _isOverAge = false;

                _age = value;
            }
        }

        public Address HomeAddress { get; set; }

        /// <summary>
        /// Vytiskne do konzole jmeno a adresu klienta
        /// </summary>
        public void Print()
        {
            Console.WriteLine( ToString() );
        }

        public void Print(string prefix)
        {
            Console.WriteLine(prefix + " " + ToString());
        }


        public void SaveToFile(string pathToFile)
        {
            File.WriteAllText(pathToFile, ToString());
        }

        public override string ToString()
        {
            return $"{Name};{Age};{HomeAddress.Street};{HomeAddress.City}";
        }

        public void Dispose()
        {
            // zavreni network spojeni atd.   
        }
    }
}
