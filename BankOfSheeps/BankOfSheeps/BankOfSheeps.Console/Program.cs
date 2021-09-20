using Data;
using System;

namespace BankOfSheeps.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Bank of Sheeps!");

            BankConetxt context = new BankConetxt();


            context.Clients.Add(new Domain.Client() { Name = "Alice" });

            context.SaveChanges();
        }
    }
}
