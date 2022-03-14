using System;
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
            Console.Write("Date: ");
            txCredit.Date = Console.ReadLine();
            Console.Write("Amount: ");
            txCredit.Amount = double.Parse(Console.ReadLine());
            Console.Write("Description: ");
            txCredit.Description = Console.ReadLine();

            credits.Add(txCredit);
            foreach (var item in credits)
                Console.WriteLine(item.Date +"\t"+item.Description+"\t"+item.Amount);
        }
    }
}