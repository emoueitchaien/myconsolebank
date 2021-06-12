using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleBank
{
    public class Account
    {
        public string number { get; }
        public string owner { get; set; }

        public List<Transaction> transactions = new List<Transaction>();
        public decimal balance
        {
            get
            {
                decimal balance = 0;
                foreach (var transaction in transactions)
                {
                    balance += transaction.amount;
                }
                return balance;
            }
        }
        private static int seedAccountNumber = 1234567890;


        public Account(string name, decimal initialBalance)
        {
            this.number = seedAccountNumber++.ToString();
            this.owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string remarks)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Negative Deposit Not Allowed!");
            }
            var deposit = new Transaction(amount, date, remarks);
            transactions.Add(deposit);
        }

        public void MakeWithdrawl(decimal amount, DateTime date, string remarks)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Negative Withdrawl Not Allowed!");
            }
            if (balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient Balance");
            }
            var withdraw = new Transaction(-amount, date, remarks);
            transactions.Add(withdraw);

        }

        public string GetStatement()
        {
            var history = new StringBuilder();
            decimal balance = 0;
            history.AppendLine("\nDate\t\tAmount\t\tRemarks");
            foreach (var transaction in transactions)
            {
                history.AppendLine($"{transaction.date.ToShortDateString()}\t{transaction.amount}\t\t{transaction.remarks}");
                balance += transaction.amount;
            }
            history.AppendLine($"\nRemaining Balance : {balance}");
            return history.ToString();
        }
    }
}
