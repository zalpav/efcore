using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BankIS.MVC_WebApp.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

       /// <summary>
        /// Debetní operace jsou záporné hodnoty
        /// Kreditní operace jsou kladné
        /// </summary>
        public TransactionType Type { get; set; }

         public double Value { get; set; }

        public int ClientID { get; set; }

        public Client Client { get; set; }
    }

    public enum TransactionType
    {
        [Description("Debetní operace (odchozí)")]
        DEBIT,

        [Description("Kreditní operace (příchozí)")]
        CREDIT
    }
}
