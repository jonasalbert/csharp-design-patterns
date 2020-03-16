﻿using System;
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

        //https://www.geeksforgeeks.org/print-all-prime-factors-of-a-given-number/
        private List<int> ListOfApproversPrime(int primeFormula)
        {
            int n = primeFormula;
            List<int> listOfPrime = new List<int>();

            // Print the number of 2s that divide n 
            while (n % 2 == 0)
            {
                listOfPrime.Add(2);
                n /= 2;
            }

            // n must be odd at this point. So we can 
            // skip one element (Note i = i +2) 
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, print i and divide n 
                while (n % i == 0)
                {
                    listOfPrime.Add(i);
                    n /= i;
                }
            }

            // This condition is to handle the case whien 
            // n is a prime number greater than 2 
            if (n > 2)
                listOfPrime.Add(n);

            return listOfPrime;
        }
        private int ReComputePrimeFormula(int primeToRemove)
        {
            List<int> listOfPrime = new List<int>(this.ListOfApproversPrime(this.PrimeFormula));
            listOfPrime.Remove(primeToRemove);

            int newPrime = 1;
            foreach (int p in listOfPrime) newPrime = newPrime * p;

            return newPrime;
        }
        private void StateChangeCheck()
        {
            List<int> primeFormula = this.ListOfApproversPrime(this.PrimeFormula);
            List<int> primeFormulaOrig = this.ListOfApproversPrime(this.PrimeFormulaOrig);

            // If the approvers count is zero then the state is completed.
            if (primeFormula.Count.Equals(0))
            {
                _approval.State = new CompletedState(this);
            }
        }
    }
}