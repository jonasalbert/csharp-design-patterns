using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Juan dela Cruz");
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.0);
            account.Withdraw(1100.0);
            Console.ReadKey();
        }
    }

}
