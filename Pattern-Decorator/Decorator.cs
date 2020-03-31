using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Decorator
{
    public abstract class Decorator : PrimeItem
    {
        protected PrimeItem _primeItem;

        public Decorator(PrimeItem primeItem)
        {
            this._primeItem = primeItem;
        }

        public override void Display()
        {
        }
    }
}
