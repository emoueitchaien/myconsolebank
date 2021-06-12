using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleBank
{
    public class Transaction
    {
        public decimal amount { get; }
        public DateTime date { get; }
        public string remarks { get; }

        public Transaction(decimal amount, DateTime date, string remarks)
        {
            this.amount = amount;
            this.date = date;
            this.remarks = remarks;
        }
    }
}
