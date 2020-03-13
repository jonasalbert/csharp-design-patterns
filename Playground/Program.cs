using System;
using System.Collections.Generic;

using Pattern_State;

namespace Playground
{
    class Program
    {
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

            List<ModelApprover> list = DataApprover.Instance.DataSource.ConvertAll(
                x => new ModelApprover { Action = x.Action, Name = x.Name, Order = x.Order, Prime = x.Prime }
            );

            Approval approval = new Approval(210, list);
            foreach(ModelApprover approver in DataApprover.Instance.DataSource)
            {
                approval.TakeAction(approver);
            }
            Console.ReadKey();
            doMainMenu();

        }




    }

    

}
