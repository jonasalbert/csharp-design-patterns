using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class CompletedState: BaseState
    {
        public CompletedState(State state)
            : this(state.PrimeFormula, state.Approval)
        {

        }
        public CompletedState(int primeFormula, Approval approval)
        {
            this.PrimeFormula = primeFormula;
            this.Approval = approval;
        }
        public override void TakeAction(ModelApprover approver)
        {
            this.PrimeFormula = this.ReComputePrimeFormula(approver.Prime);
            this.StateChangeCheck();
        }
        private void StateChangeCheck()
        {
            List<int> primeFormula = this.ListOfPrime(this.PrimeFormula);
            List<int> primeFormulaOrig = this.ListOfPrime(this.PrimeFormulaOrig);

            // If the approvers count is zero then the state is completed.
            if (primeFormula.Count.Equals(0))
            {
                _approval.State = new CompletedState(this);
            }
        }
    }
}