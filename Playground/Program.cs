﻿using System;
using System.Collections.Generic;
using Pattern_Bridge;
using Pattern_Decorator;
using Pattern_Flyweight;
using Pattern_State;
using static Pattern_Flyweight.PayrollProcessFactory;

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
            Console.WriteLine("1. Bridge Pattern");
            Console.WriteLine("2. Decorator Pattern");
            Console.WriteLine("3. Flyweight Pattern");
            Console.WriteLine("4. State Pattern");
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
                    doBridgePattern();                    
                    break;
                case 2:
                    doDecoratorPattern();                    
                    break;
                case 3:
                    doFlyweightPattern();
                    break;
                case 4:
                    doStatePattern();                    
                    break;
                default:
                    doMainMenu();
                    break;
            }
        }


        //PATTERN: State
        //________________________________________________________________________________
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
            foreach(ModelApprover approver in CollectionApprover.Instance.List)
            {
                approval.TakeAction(approver);
            }
            Console.ReadKey();
            doMainMenu();

        }
            
        //PATTERN: Flyweight
        //________________________________________________________________________________
        private static void doFlyweightPattern()
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("      Samples - Flyweight Pattern");
            Console.WriteLine("**********************************");
            Console.WriteLine("1. Simple Operation");
            Console.WriteLine("2. Payroll Process");
            Console.WriteLine("**********************************");
            Console.Write("select a sample: ");
            int menu = int.Parse(Console.ReadLine());

            if (menu.Equals(1)) flyweightPatternSimpleOperation();
            else if (menu.Equals(2)) flyweightPatternPayrollProcess();
        }
        private static void flyweightPatternSimpleOperation()
        {
            Console.Clear();

            // Arbitrary extrinsic state
            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new
              UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);

            Console.ReadKey();
            doMainMenu();
        }
        private static void flyweightPatternPayrollProcess()
        {
            Console.Clear();

            PayrollProcessFactory factory = new PayrollProcessFactory();
            foreach (ModelApprover employee in CollectionApprover.Instance.List)
            {
                Console.WriteLine("______________________________________________________________");

                PayrollProcessFlyweight attendance = factory.GetFlyweight(ennSteps.Attendance);
                attendance.Process(employee.Name);

                PayrollProcessFlyweight incentives = factory.GetFlyweight(ennSteps.Incentives);
                incentives.Process(employee.Name);

                PayrollProcessFlyweight leaves = factory.GetFlyweight(ennSteps.Leaves);
                leaves.Process(employee.Name);

                PayrollProcessFlyweight grossIncome = factory.GetFlyweight(ennSteps.GrossIncome);
                grossIncome.Process(employee.Name);

                PayrollProcessFlyweight premiums = factory.GetFlyweight(ennSteps.Premiums);
                premiums.Process(employee.Name);

                PayrollProcessFlyweight tax = factory.GetFlyweight(ennSteps.Tax);
                tax.Process(employee.Name);

                PayrollProcessFlyweight net = factory.GetFlyweight(ennSteps.Net);
                net.Process(employee.Name);

            }
            Console.WriteLine("______________________________________________________________");
            BankTransmittalFlyweight bankTransmittal = new BankTransmittalFlyweight();
            bankTransmittal.Process("COMPANY_SALARY.txt");

            Console.ReadKey();
            doMainMenu();
        }

        //PATTERN: Decorator
        //________________________________________________________________________________
        private static void doDecoratorPattern()
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("   Samples - Decorator Pattern");
            Console.WriteLine("**********************************");
            Console.WriteLine("1. Library System");
            Console.WriteLine("2. Prime - Synchronization");
            Console.WriteLine("**********************************");
            Console.Write("select a sample: ");
            int menu = int.Parse(Console.ReadLine());

            if (menu.Equals(1)) decoratorPatternLibrarySystem();
            else if (menu.Equals(2)) decoratorPatternPrimeSync();
        }
        private static void decoratorPatternLibrarySystem()
        {
            Console.Clear();

            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display

            Console.WriteLine("\nMaking video borrowable:");
            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            Console.ReadKey();
            doMainMenu();
        }
        private static void decoratorPatternPrimeSync()
        {
            Console.Clear();

            Approvals approval = new Approvals();
            approval.Add("John Doe", 210);
            approval.Add("Jane Doe", 210);
            approval.Display();

            Console.WriteLine("");
            
            Permissions permission = new Permissions();
            permission.Add("Bjarne Stroustrup", 210);
            //permission.Add("Yukihiro Matsumoto", 210);
            permission.Display();

            // Sync the approval to different locations.
            Synchronizable synchronize = new Synchronizable(approval);
            synchronize.Sync();

            // Sync the permission to different locations.
            synchronize = new Synchronizable(permission);
            synchronize.Sync();

            Console.ReadKey();
            doMainMenu();
        }

        //PATTERN: Bridge
        //________________________________________________________________________________
        private static void doBridgePattern()
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("      Samples - Bridge Pattern");
            Console.WriteLine("**********************************");
            Console.WriteLine("1. Record Navigation");
            Console.WriteLine("2. Record Navigation (Generic)");
            Console.WriteLine("**********************************");
            Console.Write("select a sample: ");
            int menu = int.Parse(Console.ReadLine());

            if (menu.Equals(1)) bridgePatternRecordNavigation();
            else if (menu.Equals(2)) bridgePattern();
        }
        private static void bridgePatternRecordNavigation()
        {
            Console.Clear();

            // Create RefinedAbstraction
            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomersData();

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            Console.ReadKey();
            doMainMenu();
        }
        private static void bridgePattern()
        {
            Console.Clear();

            // Exercise the bridge: Employee
            Employees employees = new Employees();
            employees.Data = new RepositoryEmployee();            
            employees.Show();
            employees.Next();
            employees.Show();
            employees.Next();
            employees.Show();
            employees.Add(new Employee() { Id = Guid.NewGuid(), FirstName="John", LastName="Doe", MiddleName="" });
            employees.ShowAll();

            Console.WriteLine();
            Console.WriteLine();

            // Exercise the bridge: Employee
            Locations locations = new Locations();
            locations.Data = new RepositoryLocation();
            locations.Show();
            locations.Next();
            locations.Show();
            locations.Next();
            locations.Show();
            locations.Add(new Location() { Id = Guid.NewGuid(), Name="CDO", Prime=11 } );
            locations.ShowAll();

            Console.ReadKey();
            doMainMenu();
        }

    }



}
