using System;

namespace BankIS.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Client c1 = new Client();

            c1.Name = "Pepa Čech";
            c1.Age = 43;

            c1.Print();


            Client c2 = new Client();
            c2.Name = "Jan Nový";
            c2.Age = 25;
            c2.Print();

            Console.ReadLine();

        }
    }
}
