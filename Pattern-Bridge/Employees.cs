using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Bridge
{
    public class Employees: EmployeeBase
    {
        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine("Show All: Employee");
            Console.WriteLine("-----------------------------------------------------------------------");
            base.ShowAll();
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}