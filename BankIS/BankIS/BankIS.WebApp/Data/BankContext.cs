using BankIS.MVC_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankIS.MVC_WebApp.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Address> Adressess { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        //public string DbPath { get; private set; }
        //public BankContext()
        //{
        //    var folder = Environment.SpecialFolder.LocalApplicationData;
        //    var path = Environment.GetFolderPath(folder);
        //    DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}bankdb01.db";
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Client>()
                .HasIndex(c => c.LastName);
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    //options.UseSqlite($"Data Source=bankdb01.db");
        //    options.UseSqlServer($"Server=(localdb)\\MSSQLLocalDB;Initial Catalog=bankdb-mvc");

        //    base.OnConfiguring(optionsBuilder: );

        //}
    }
}

