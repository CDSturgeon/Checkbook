using System;
namespace CheckbookRegister.Interfaces
{
    public interface ITransactions
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public DateOnly Date { get; set; }
    }
}