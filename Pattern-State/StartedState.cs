using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class StartedState : BaseState
    {
        public StartedState(State state)
            : this(state.PrimeFormula, state.Approval)
        {

        }
        public StartedState(int primeFormula, Approval approval)
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

            // If the first approver takes an action then the state just started.
            if (primeFormula.Count == (primeFormulaOrig.Count-1))
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