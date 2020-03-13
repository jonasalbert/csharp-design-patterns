using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class Approval
    {
        private State _state;
        private static int _primeFormula = 1;

        public Approval(int primeFormula, List<ModelApprover> approvers) 
        {            
            _state = new StartedState(primeFormula, this);
            _state.Approvers = approvers;
        }

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void TakeAction(ModelApprover approver)
        {
            _state.TakeAction(approver);
            Console.WriteLine("Approver: " + approver.Name);
            Console.WriteLine("Approver's prime: " + approver.Prime);
            Console.WriteLine("Prime Formula: " + _state.PrimeFormula);
            Console.WriteLine("State: " + _state.GetType().Name);
        }

    }
}