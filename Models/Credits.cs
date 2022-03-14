using System;
using CheckbookRegister.Interfaces;

namespace CheckbookRegister.Models
{
    public class Credits:ITransactions
    {
        //fields
        private int id;
        private double amount;
        private string description;
        private string date;

        //Properties
        public int ID { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }

        public void Credit() { }
    }
}