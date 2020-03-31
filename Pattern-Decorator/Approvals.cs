using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Decorator
{
    public class Approvals : PrimeItem
    {
        public void Add(string name, int primeFormula)
        {
            this.List.Add(new Approvals() { Name = name, PrimeFormula=primeFormula, PrimeFormulaOrig = primeFormula });
        }
        public override void Display()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("List of Approvals");
            Console.WriteLine("-------------------------------------");
            foreach (Approvals approval in this.List)
            {
                Console.WriteLine(String.Format("{0}\t\t\t{1}", approval.Name, approval.PrimeFormula));
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}
