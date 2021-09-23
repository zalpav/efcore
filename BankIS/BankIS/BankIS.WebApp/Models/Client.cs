using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankIS.MVC_WebApp.Models
{
    public class Client
    {

        public Client()
        {
            HomeAddress = new Address();
        }

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Jméno klienta
        /// </summary>
        /// 
        [MaxLength(100)]
        public string FirstName { get; set; }

        //[Required]
        [MaxLength(100), Required]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public Address HomeAddress { get; set; }

        public List<Transaction> Transactions { get; set; }

        [NotMapped]
        //public int Age() { get; set; }
        public int Age
        {
            get
                {
                return GetAge();
            }
        }

        //[NotMapped]
        public int GetAge()
        {
            if(DateOfBirth.HasValue)
            {
                return DateTime.Now.Year - DateOfBirth.Value.Year;
            }
            else
            {
                return -1;
            }
        }


        /// <summary>
        /// Vytiskne do konzole jmeno a adresu klienta
        /// </summary>
        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public void Print(string prefix)
        {
            Console.WriteLine(prefix + " " + ToString());
        }

        public void SaveToFile(string pathToFile)
        {
            File.WriteAllText(pathToFile, ToString());
        }

        public override string ToString()
        {
            return $"{FirstName};{LastName};{DateOfBirth};{HomeAddress.Street};{HomeAddress.City}";
        }



        public static void SaveClientsToFile(IEnumerable<Client> clients, string file)
        {
            foreach (var client in clients)
            {
                var clientWithNewLine = client.ToString() + Environment.NewLine;
                File.AppendAllText(file, clientWithNewLine);
            }
        }

    }
}
