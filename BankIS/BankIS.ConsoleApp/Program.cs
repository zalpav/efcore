using System;
using System.Collections.Generic;
using System.IO;
//using System.Net.Http;
using System.Linq;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var file = "dataset_1.txt";
            Console.WriteLine($"Načítám klienty z {file}");

            var clients = Client.LoadClients(file);

            var cnt = clients.Count;
            Console.WriteLine($"Počet klientů v seznamu: {cnt}");

            foreach(var client in clients)
            {
                client.Print();
            }

            //Client.SaveClientsToFile(clients, file);


            // LINQ

            int age = 45;
            //var result = clients.Where(client => client.Age > 30).ToList();
            //Console.WriteLine($"Over {age}: ");

            var result = clients.Where(client => client.HomeAddress.City == "Brno")
                                .OrderBy(c => c.Name)
                                .ToList();
            Console.WriteLine($"Order by Age: ");

            foreach ( var client in result)
            {
                client.Print();
            }

            Console.ReadLine();
        }

    }
}
