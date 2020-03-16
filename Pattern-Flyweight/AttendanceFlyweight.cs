using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Flyweight
{
    public class AttendanceFlyweight : PayrollProcessFlyweight
    {
        public override void Process(string name)
        {
            Console.WriteLine("Attendance have been processed: " + name);
        }
    }
}
