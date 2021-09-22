﻿using System;
using System.Collections.Generic;
using System.IO;


namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var c1 = new Client(city: "Brno", street: "Kopečná 23", jmeno: "Martin Novák", age: 55);
            var c2 = new Client("Tovární 13", "Ostrava", "Martina Veselá", 33);
            var c3 = new Client("Česká 21", "Ostrava", "Petr Roth", 24);
            var c4 = new Client("Dlouhá 5", "Zlín", "Roman Šulc", 36);
            var c5 = new Client("Paseky 434", "Lukov", "Martin Guts", 41);

            List<Client> clients = new List<Client>();
            clients.Add(c1);
            clients.Add(c2);
            clients.Add(c3);
            clients.Add(c4);
            clients.Add(c5);

            var cnt = clients.Count;

            global::System.Console.WriteLine($"Pocet klientu v seznamu:  {cnt}");

            foreach(var client in clients )
            {
                client.Print();
            }


            // připravte metodu "SaveToFile(string filePath) na klientovi

            Console.WriteLine("c1: " + c1.ToString());

            c1.Print();

            Console.WriteLine();
            var num = int.Parse("32");

            var spojene = string.Join(", ", "Slovo1", "Slovo2", "tři", "atd..");
            Console.WriteLine(spojene);
            
            c2.Print();

            Console.ReadLine();

            c1.SaveToFile("klient1.txt");
            c2.SaveToFile("klient2.txt");

            bool allowed = Address.IsCityAllowed("xxx");

            double cos = Math.Cos(3.2);


            string[] pole_stringu = new string[23];

            List<string> list = new List<string>();

            pole_stringu[5] = "sesty prvek";
            
            list.Add("prvni item");

//            List<Client> clients = new List<Client>();

            clients.Add(c1);
            clients.Add(c2);

            foreach(var client in clients)
            {
                client.Age = 22;
                client.Print();
            }

        }

    }
}
