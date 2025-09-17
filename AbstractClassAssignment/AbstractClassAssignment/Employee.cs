using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Employee class inherits Person
    public class Employee : Person
    {
        // override SayName method from Person
        public override void SayName()
        {
            // write full name to console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
