using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class OnGoingState: State
    {
        public OnGoingState(State state)
            : this(state.PrimeFormula, state.Approval)
        {

        }
        public OnGoingState(double primeFormula, Approval approval)
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
            // If the approvers count is zero then the state is completed.
            if (this.Approvers.Count == DataApprover.Instance.DataSource.Count)
            {
                _approval.State = new CompletedState(this);
            }
            // If the first approver takes an action then the state just started.
            else if (this.Approvers.Count>1)
            {
                _approval.State = new OnGoingState(this);
            }
        }

    }
}