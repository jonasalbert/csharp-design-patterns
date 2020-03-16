using System;
using System.Collections.Generic;

using Pattern_State;

namespace Playground
{
    class Program
    {
        // A function to print all prime  
        // factors of a given number n 
        // https://www.geeksforgeeks.org/print-all-prime-factors-of-a-given-number/
        public static void primeFactors(int n)
        {
            // Print the number of 2s that divide n 
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }

            // n must be odd at this point. So we can 
            // skip one element (Note i = i +2) 
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, print i and divide n 
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }

            // This condition is to handle the case whien 
            // n is a prime number greater than 2 
            if (n > 2)
                Console.Write(n);
        }
        static void Main(string[] args)
        {
            doMainMenu();
        }

        private static void doMainMenu()
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("        DESIGN PATTERNS");
            Console.WriteLine("**********************************");
            Console.WriteLine("1. State Pattern");
            Console.WriteLine("2. Flyweight Pattern");
            Console.WriteLine("3. Bridge Pattern");
            Console.WriteLine("4. Decorator Pattern");
            Console.WriteLine("0. EXIT");
            Console.WriteLine("**********************************");
            Console.Write("select a demo (1 to 4): ");
            int selected = 0;
            int.TryParse(Console.ReadLine(), out selected);

            switch (selected)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    doStatePattern();
                    break;
                default:
                    doMainMenu();
                    break;
            }
        }

        private static void doStatePattern()
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("      Samples - State Pattern");
            Console.WriteLine("**********************************");
            Console.WriteLine("1. Bank Transaction");
            Console.WriteLine("2. Prime - Approval Hierarchy");
            Console.WriteLine("**********************************");
            Console.Write("select a sample: ");
            int menu = int.Parse(Console.ReadLine());

            if (menu.Equals(1)) statePatternSampleBankTransaction();
            else if (menu.Equals(2)) statePatternSamplePrimeApprovalHierarchy();
        }


        private static void statePatternSampleBankTransaction()
        {
            Console.Clear();
            Account account = new Account("Juan dela Cruz");
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.0);
            account.Withdraw(1100.0);
            Console.ReadKey();
            doMainMenu();
        }
        private static void statePatternSamplePrimeApprovalHierarchy()
        {
            Console.Clear();
            Approval approval = new Approval(210);
            foreach(ModelApprover approver in DataApprover.Instance.List)
            {
                approval.TakeAction(approver);
            }
            Console.ReadKey();
            doMainMenu();

        }




    }

    

}
