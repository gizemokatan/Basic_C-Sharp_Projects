using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // abstract class Person (cannot be instantiated directly)
    public abstract class Person
    {
        // property for first name
        public string FirstName { get; set; }

        // property for last name
        public string LastName { get; set; }

        // abstract method must be implemented in derived class
        public abstract void SayName();
    }
}
