using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Employee inherits from Person and also implements IQuittable
    public class Employee : Person, IQuittable
    {
        // simple Id property for demo
        public int Id { get; set; }

        // implement SayName from Person
        public override void SayName()
        {
            // write the full name to the console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // implement Quit from IQuittable
        public void Quit()
        {
            Console.WriteLine("Employee " + FirstName + " " + LastName + " has quit the job.");
        }
    }
}
