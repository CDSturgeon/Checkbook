using System;
using CodeLouisvilleLibrary;
using CheckbookRegister.Models;

namespace CheckbookRegister
{
    public class Checkbook : CodeLouisvilleAppBase
    {
        public Checkbook() : base("The Checkbook Console") { }

        Accounts account = new Accounts();

        protected override bool Main()
        {
            string title = "*****************************\n" +
                                   "***** Checkbook Console *****\n" +
                                   "*****************************";

            var mainMenu = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("1","Add Transaction"),
                new KeyValuePair<string, string>("2","View Transactions"),
                new KeyValuePair<string, string>("3","View Account Balance"),
                new KeyValuePair<string, string>("Q","Quit")
            };

            //Master Loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine(title + Environment.NewLine);
                
                string select = Prompt4MenuItem("Select an option", mainMenu);

                switch (select)
                {
                    case "1":
                        AddTrasaction();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("List of Credit Transactions:");
                        account.DispalyCreditTx();
                        Console.WriteLine("\nList of Debit Transactions:");
                        account.DispalyDebitTx();
                        break;
                    case "Q":
                        return false;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;

                }
            }
        }

        private void AddTrasaction()
        {
            string title = "*****************************\n" +
                           "***** Add a Transaction *****\n" +
                           "*****************************";

            var txMenu = new List<KeyValuePair<string, string>>
            {

                new KeyValuePair<string,string>("C","Credit"),
                new KeyValuePair<string, string>("D", "Debit"),
                new KeyValuePair<string, string>("M","Main Menu")
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine(title + Environment.NewLine);

                string select = Prompt4MenuItem("Select an option", txMenu);

                switch (select)
                {
                    case "C":
                        Console.Clear();
                        account.AddCreditTx();
                        account.DispalyCreditTx();
                        Console.Read();
                        break;
                    case "D":
                        Console.Clear();
                        account.AddDebitTx();
                        account.DispalyDebitTx();
                        Console.Read();
                        break;
                    case "M":
                        return;
                }
            }
        }
    }
}