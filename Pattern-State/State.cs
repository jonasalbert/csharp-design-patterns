using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public abstract class State
    {
        protected Approval _approval;
        private static double _primeFormula=1;
        private static List<ModelApprover> _approvers = new List<ModelApprover>();

        public Approval Approval
        {
            get { return _approval; }
            set { _approval = value; }
        }

        public double PrimeFormula
        {
            get { return _primeFormula; }
            set { _primeFormula = value; }
        }
        public List<ModelApprover> Approvers
        {
            get { return _approvers; }
            set { _approvers = value; }
        }

        public abstract void TakeAction(ModelApprover prime);

    }
}
