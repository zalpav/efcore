using System;
using System.Collections.Generic;
using System.Text;

namespace BankIS.ConsoleApp
{
    public class Client
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
