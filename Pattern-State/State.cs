using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    abstract class State
    {
        protected Approval approval;


        public Approval Approval
        {
            get { return approval; }
            set { approval = value; }
        }

    }
}
