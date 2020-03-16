using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Flyweight
{
    public class PayrollProcessFactory
    {
        public enum ennSteps: int
        {
            Attendance=1, 
            Incentives=2,
            Leaves=3,
            Premiums=4,
            GrossIncome=5,
            Tax=6,
            Net=7,
            BankTransmittal=8
        }

        private Hashtable _flyweights = new Hashtable();

        public PayrollProcessFactory()
        {
            _flyweights.Add(ennSteps.Attendance, new AttendanceFlyweight());
            _flyweights.Add(ennSteps.Incentives, new IncentivesFlyweight());
            _flyweights.Add(ennSteps.Leaves, new LeavesFlyweight());
            _flyweights.Add(ennSteps.Premiums, new PremiumsFlyweight());
            _flyweights.Add(ennSteps.GrossIncome, new GrossIncomeFlyweight());
            _flyweights.Add(ennSteps.Tax, new TaxFlyweight());
            _flyweights.Add(ennSteps.Net, new NetFlyweight());
            _flyweights.Add(ennSteps.BankTransmittal, new BankTransmittalFlyweight());
        }

        public PayrollProcessFlyweight GetFlyweight(ennSteps steps)
        {
            return (PayrollProcessFlyweight)_flyweights[steps];
        }


    }
}
