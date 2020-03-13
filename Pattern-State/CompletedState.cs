using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class CompletedState: State
    {
        public CompletedState(State state)
            : this(state.PrimeFormula, state.Approval)
        {

        }
        public CompletedState(double primeFormula, Approval approval)
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
        }
    }
}