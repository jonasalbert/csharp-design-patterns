using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Flyweight
{
    public class BankTransmittalFlyweight: PayrollProcessFlyweight
    {
        public override void Process(string name)
        {
            Console.WriteLine(name + " has been generated.");
        }
    }
}
