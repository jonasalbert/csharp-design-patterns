using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Flyweight
{
    public class PremiumsFlyweight: PayrollProcessFlyweight
    {
        public override void Process(string name)
        {
            Console.WriteLine("Premiums have been processed: "+ name);
        }
    }
}
