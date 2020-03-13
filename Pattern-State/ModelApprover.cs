using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class ModelApprover
    {
        private string _name = "";
        private int _prime = 1;
        private string _action = "";
        private int _order = 1;

        public string Name
        {
            get { return _name; }
            set { _name = value;  }
        }

        public int Prime
        {
            get { return _prime; }
            set { _prime = value; }
        }

        public int Order
        {
            get { return _order; }
            set { _order = value; }
        }

        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }

    }
}