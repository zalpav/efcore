using System;

namespace BankIS.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Address ostrava = new Address("Ostrava", "Václavovická 21");
            //ostrava.City = "Ostrava";
            //ostrava.Street = "Václavovická 21";

            //Client c1 = new Client();

            //c1.Name = "Pepa Čech";
            //c1.Age = 43;

            ////c1.HomeAddress = new Address();
            ////c1.HomeAddress.Street = "Žižkova 15";
            ////c1.HomeAddress.City = "Praha";
            //c1.HomeAddress = ostrava;
            //c1.Print();


            //Client c2 = new Client();
            //c2.Name = "Jan Nový";
            //c2.Age = 25;
            //c2.HomeAddress = new Address("Paladského 21", "Brno");
            ////c2.HomeAddress.Street = "Paladského 21";
            ////c2.HomeAddress.City = "Brno";
            //c2.Print();


            Client c1 = new Client("Jan Pech", 28, new Address(street: "Jermanova 32", city: "Olomouc"));
            Client c2 = new Client("Ondřej Lexa", 35, new Address("Koněvova 46", "Brno"));

            c1.SaveToFile("klient1.txt");
            c2.SaveToFile("klient2.txt");

            c1.Print();
            c2.Print();
 
            Console.WriteLine("c1: " + c1.ToString() );
            Console.WriteLine("c2: " + c2.ToString());
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
