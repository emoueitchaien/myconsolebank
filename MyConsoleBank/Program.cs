using System;

namespace MyConsoleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("Mohan Pradhan", 10000);
            Console.WriteLine($"Account {account.number} created for {account.owner} with balance ${account.balance}");

            account.MakeDeposit(2000, DateTime.Now, "Deposit 2");

            account.MakeWithdrawl(6000, DateTime.Now, "Gaming PC");

            account.MakeDeposit(3000, DateTime.Now, "Deposit 3");

            account.MakeWithdrawl(1000, DateTime.Now, "Trip Fun");

            Console.WriteLine(account.GetStatement());

            ////Negative Balance Deposit and Withdrawl causes Exception which should be handled as follow
            //try
            //{
            //    var account2 = new Account("Manoj", -15000);
            //    Console.WriteLine($"Account {account2.number} created for {account2.owner} with balance ${account2.balance}");
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    //Console.WriteLine("Negative Balance is Prohibited!");
            //    Console.WriteLine(e.Message);
            //}
            //try
            //{
            //    account.MakeWithdrawl(-6000, DateTime.Now, "Gaming PC");
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    //Console.WriteLine("Negative Balance is Prohibited!");
            //    Console.WriteLine(e.Message);
            //}
            //catch (InvalidOperationException e)
            //{
            //    //Console.WriteLine("Insufficeint Balance!");
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
