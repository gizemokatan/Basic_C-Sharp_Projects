using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    // Person class has FirstName and LastName
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // method that writes full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}