using Microsoft.EntityFrameworkCore;
using System;

namespace BankIS.ConsoleApp
{
    public class BankContext : DbContext
    {
        public DbSet<Client> Clients {  get; set; }

        public DbSet<Address> Adressess { get; set; }

        //public string DbPath { get; private set; }
        //public BankContext()
        //{
        //    var folder = Environment.SpecialFolder.LocalApplicationData;
        //    var path = Environment.GetFolderPath(folder);
        //    DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}bankdb01.db";
        //}


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
             //options.UseSqlite($"Data Source=bankdb01.db");
            options.UseSqlServer($"Server=(localdb)\\MSSQLLocalDB;Initial Catalog=bankdb01");
        }
    }
}
