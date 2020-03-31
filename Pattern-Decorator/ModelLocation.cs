using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Decorator
{
    public class ModelLocation
    {
        private string _name;
        private int _prime = 1;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Prime
        {
            get { return _prime; }
            set { _prime = value; }
        }

    }
}