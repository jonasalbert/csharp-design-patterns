using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Flyweight
{
    public class LeavesFlyweight: PayrollProcessFlyweight
    {
        public override void Process(string name)
        {
            Console.WriteLine("Leaves have been processed: " + name);
        }
    }
}
