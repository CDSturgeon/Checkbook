using System;
using CheckbookRegister.Misc;

namespace CheckbookRegister.Models
{
    public class Accounts
    {
        //fields
        private int accountID;
        private List<Credits> credits = new List<Credits>();
        private List<Debits> debits = new List<Debits>();
        private double balance;

        //properties
        public int AccountID { get; set; }
        public double Balance { get; set; }

        public void AddCreditTx()
        {
            var txCredit = new Credits();

            Console.Write("Date (mm/dd/yyyy): ");
            txCredit.Date = Validation.Date(Console.ReadLine());
            Console.Write("Amount: ");
            txCredit.Amount = double.Parse(Console.ReadLine());//need to add validation
            Console.Write("Description: ");
            txCredit.Description = Console.ReadLine();

            credits.Add(txCredit);
        }

        public void DispalyCreditTx()
        {
            foreach (var item in credits)
                Console.WriteLine(item.Date + "\t" + item.Amount + "\t" + item.Description);
        }

        public void AddDebitTx()
        {
            var txDebit = new Debits();

            Console.Write("Date (mm/dd/yyyy): ");
            txDebit.Date = Validation.Date(Console.ReadLine());
            Console.Write("Amount: ");
            txDebit.Amount = double.Parse(Console.ReadLine());//need to add validation
            Console.Write("Description: ");
            txDebit.Description = Console.ReadLine();

            debits.Add(txDebit);
        }

        public void DispalyDebitTx()
        {
            foreach (var item in debits)
                Console.WriteLine(item.Date + "\t" + item.Amount + "\t" + item.Description);
        }
    }
}