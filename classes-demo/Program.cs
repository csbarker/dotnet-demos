using System;
using classes;

namespace classes_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Callum", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance");

            account.MakeWithdrawl(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            // TEST: Initial deposits must be positive
            try
            {
                var invalid_account = new BankAccount("Invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine();
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            // TEST: Balances must not be able to go into negative
            try
            {
                account.MakeWithdrawl(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine();
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
