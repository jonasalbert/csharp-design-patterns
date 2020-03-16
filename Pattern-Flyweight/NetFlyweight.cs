using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Flyweight
{
    public class NetFlyweight: PayrollProcessFlyweight
    {
        public override void Process(string name)
        {
            Console.WriteLine("Net have been processed: " + name);
        }
    }
}
