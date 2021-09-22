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

            foreach (var client in clients)
            {
                client.Print();
            }

            //Client.SaveClientsToFile(clients, file);


            // LINQ

            int minAge = 20;
            int maxAge = 40;

            var result = clients.Where(client => client.Age > minAge);
             result = result.Where(client => client.Age < maxAge);

            Console.WriteLine($"Order by Age: ");
            foreach (var name in result)
            {
                //client.Print();
                Console.WriteLine(name);
            }


            //var result = clients.Where(client => client.Age > 30).ToList();
            //Console.WriteLine($"Over {age}: ");

            //var result = clients.Where(client => client.HomeAddress.City == "Brno")
            //                    .OrderBy(c => c.Name)
            //                    .ToList();

            //var result = clients.Select(c => new { c.Name })
            //                    .ToString();

            //Console.WriteLine($"Order by Age: ");

            //foreach (var name in result)
            //{
            //    //client.Print();
            //    Console.WriteLine(name);
            //}

            //var maxAge = clients//.Where(client => client.HomeAddress.City == "Brno")
            //                    //.OrderBy(c => c.Name)
            //                    .Max(c => c.Age);

            //Console.WriteLine(maxAge);

            //var resultMax = clients.Where(client => client.Age == clients.Max(c => c.Age))
            //                        .ToList();


            //Console.WriteLine($"Max Age: { resultMax[0].ToString() }");


            Console.ReadLine();
        }

    }
}
