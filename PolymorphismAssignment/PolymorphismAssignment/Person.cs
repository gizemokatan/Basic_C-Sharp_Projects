using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // abstract class: cannot be instantiated directly
    public abstract class Person
    {
        // first name property
        public string FirstName { get; set; }

        // last name property
        public string LastName { get; set; }

        // abstract method: must be implemented by derived classes
        public abstract void SayName();
    }
}
