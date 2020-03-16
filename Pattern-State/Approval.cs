using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class Approval
    {
        private State _state;

        public Approval(int primeFormula) 
        {
            Console.WriteLine("Prime Formula: "+ primeFormula);
            _state = new StartedState(primeFormula, this);
            _state.PrimeFormulaOrig = primeFormula;
        }

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void TakeAction(ModelApprover approver)
        {
            _state.TakeAction(approver);
            Console.WriteLine("______________________________________");
            Console.WriteLine("Approver: " + approver.Name);
            Console.WriteLine("Approver's prime: " + approver.Prime);
            Console.WriteLine("Prime Formula: " + _state.PrimeFormula);
            Console.WriteLine("State: " + _state.GetType().Name);
        }

    }
}