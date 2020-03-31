using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Decorator
{
    public class Permissions : PrimeItem
    {
        public void Add(string name, int primeFormula)
        {
            this.List.Add(new Permissions() { Name = name, PrimeFormula = primeFormula, PrimeFormulaOrig = primeFormula });
        }
        public override void Display()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("List of Permissions");
            Console.WriteLine("-------------------------------------");
            foreach (Permissions permissions in this.List)
            {
                Console.WriteLine(String.Format("{0}\t\t{1}", permissions.Name, permissions.PrimeFormula));
            }
            Console.WriteLine("-------------------------------------");
        }

    }
}
