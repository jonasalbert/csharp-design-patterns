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

        }

        public PayrollProcessFlyweight GetFlyweight(ennSteps steps)
        {
            if (_flyweights.ContainsKey(steps))
                return (PayrollProcessFlyweight)_flyweights[steps];

            PayrollProcessFlyweight f = null;

            if (steps == ennSteps.Attendance)
                f = new AttendanceFlyweight();
            else if (steps == ennSteps.Incentives)
                f = new IncentivesFlyweight();
            else if (steps== ennSteps.Leaves)
                f = new LeavesFlyweight();
            else if (steps == ennSteps.Premiums) 
                f = new PremiumsFlyweight();
            else if (steps == ennSteps.GrossIncome) 
                f = new GrossIncomeFlyweight();
            else if (steps == ennSteps.Tax) 
                f = new TaxFlyweight();
            else if (steps == ennSteps.Net)
                f = new NetFlyweight();
            else if (steps == ennSteps.BankTransmittal)
                f = new BankTransmittalFlyweight();

            _flyweights.Add(steps, f);
            return f;
        }


    }
}
