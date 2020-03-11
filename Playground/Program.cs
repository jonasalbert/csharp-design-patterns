using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**********************************");
            Console.WriteLine("        DESIGN PATTERNS");
            Console.WriteLine("**********************************");
            Console.WriteLine("1. State Pattern");
            Console.WriteLine("2. Flyweight Pattern");
            Console.WriteLine("3. Bridge Pattern");
            Console.WriteLine("4. Decorator Pattern");
            Console.WriteLine("**********************************");
            Console.Write("select a demo (1 to 4): ");
            var menu = Console.ReadLine();

            Console.WriteLine("selected menu is " + menu);

            //Account account = new Account("Juan dela Cruz");
            //account.Deposit(500.0);
            //account.Deposit(300.0);
            //account.Deposit(550.0);
            //account.PayInterest();
            //account.Withdraw(2000.0);
            //account.Withdraw(1100.0);
            //Console.ReadKey();
        }
    }

}
