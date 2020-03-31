using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class OnGoingState: BaseState
    {
        public OnGoingState(State state)
            : this(state.PrimeFormula, state.Approval)
        {

        }
        public OnGoingState(int primeFormula, Approval approval)
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
            // If more than 1 who take action to approve then state is ongoing.
            else if (primeFormula.Count <= primeFormulaOrig.Count-2)
            {
                _approval.State = new OnGoingState(this);
            }
        }

    }
}