using System;
using CheckbookRegister.Models;

namespace CheckbookRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Accounts();
            Console.WriteLine("Press any key to add a transaction...");

            Console.Write("Select type of transaction:\nC:Credit\nD:Debit\n=>");
            string select = Console.ReadLine();

            switch (select.ToUpper())
            {
                case "C":
                    Console.Clear();
                    account.AddCreditTx();
                    Console.Read();
                    break;
                default:
                    break;


            }
        }
    }
}