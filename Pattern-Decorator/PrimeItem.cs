using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Decorator
{
    public abstract class PrimeItem
    {
        private int _primeFormula = 1;
        private int _primeFormulaOrig = 1;
        private string _name;
        private List<PrimeItem> _list = new List<PrimeItem>();

        public int PrimeFormula
        {
            get { return _primeFormula; }
            set { _primeFormula = value; }
        }
        public int PrimeFormulaOrig
        {
            get { return _primeFormulaOrig; }
            set { _primeFormulaOrig = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<PrimeItem> List
        {
            get { return _list; }
            set { _list = value; }
        }

        public abstract void Display();

    }
}
