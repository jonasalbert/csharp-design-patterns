using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Flyweight
{
    public class GrossIncomeFlyweight: PayrollProcessFlyweight
    {
        public override void Process(string name)
        {
            Console.WriteLine("Gross Income have been processed: " + name);
        }
    }
}
