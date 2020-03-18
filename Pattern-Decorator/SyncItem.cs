using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Decorator
{
    public abstract class SyncItem
    {
        private static int _primeFormula = 1;

        public int PrimeFormula 
        {
            get { return _primeFormula; }
            set { _primeFormula = value; }
        }
        public abstract void Sync(int prime);

    }
}
