using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class StartedState : State
    {
        public StartedState(State state)
            : this(state.PrimeFormula, state.Approval)
        {

        }
        public StartedState(double primeFormula, Approval approval)
        {
            this.PrimeFormula = primeFormula;
            this.Approval = approval;
        }

        public override void TakeAction(ModelApprover approver)
        {
            this.Approvers.Remove(approver);
            this.PrimeFormula = this.getPrimeFormula();
            this.StateChangeCheck();
        }

        private int getPrimeFormula()
        {
            int primeFormula = 1;
            foreach (ModelApprover approver in this.Approvers)
            {
                primeFormula = primeFormula * approver.Prime;
            }
            return primeFormula;
        }

        private void StateChangeCheck()
        {
            // If the first approver takes an action then the state just started.
            if (this.Approvers.Count.Equals(1))
            {
                _approval.State = new StartedState(this);
            }
            else
            {
                _approval.State = new OnGoingState(this);
            }
        }

    }
}