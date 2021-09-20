using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace Data
{
    public class BankConetxt : DbContext
    {
        public DbSet<Client> Clients {  get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BankOfSheepsTest1;")
                .LogTo(message => Debug.WriteLine(message), Microsoft.Extensions.Logging.LogLevel.Information)
                .EnableSensitiveDataLogging();
                ;
        }
    }
}
