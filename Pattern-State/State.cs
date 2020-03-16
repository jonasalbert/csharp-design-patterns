using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public abstract class State
    {
        protected Approval _approval;
        private static int _primeFormula = 1;
        private static int _primeFormulaOrig = 1;

        public Approval Approval
        {
            get { return _approval; }
            set { _approval = value; }
        }

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

        public abstract void TakeAction(ModelApprover prime);

    }
}
