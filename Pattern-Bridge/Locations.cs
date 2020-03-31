using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Bridge
{
    public class Locations: LocationBase
    {
        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine("Show All: Locations");
            Console.WriteLine("-----------------------------------------------------------------------");
            base.ShowAll();
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}