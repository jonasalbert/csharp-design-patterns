using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Bridge
{
    public class Employee: BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
    }
}