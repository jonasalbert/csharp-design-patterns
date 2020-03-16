using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Flyweight
{
    public class IncentivesFlyweight: PayrollProcessFlyweight
    {
        public override void Process(string name)
        {
            Console.WriteLine("Incentives have been processed: " + name);
        }
    }
}
