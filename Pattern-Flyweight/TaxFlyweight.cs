using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Flyweight
{
    public class TaxFlyweight: PayrollProcessFlyweight
    {
        public override void Process(string name)
        {
            Console.WriteLine("Tax have been processed: " + name);
        }
    }
}
