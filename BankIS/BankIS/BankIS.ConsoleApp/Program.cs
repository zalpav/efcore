using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (BankContext context = new BankContext())
            {
                //context.Clients.FromSqlRaw("SELECT * ");

                var cnt = context.Clients.Count();
                Console.WriteLine($"Počet klientů v seznamu: {cnt}");
                Console.WriteLine();

                //najit nejstarsiho klienta
                //var oldest = context.Clients.OrderByDescending(c => c.Age).First();

                //oldest.Print();

                //context.Remove(oldest);
                //context.SaveChanges();

                //context.SaveChanges();

                // LINQ

                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item}");
                //}
            }
        }

    }
}