using OperatorsAssignment;
using System;

namespace OperatorsAssignment
{
    public class Program
    {
        static void Main (string[] args)
        {
            // Create first employee
            Employee employee1 = new Employee { Id = 1, FirstName = "Gizem", LastName = "Okatan" };

            // Create second employee
            Employee employee2 = new Employee { Id = 2, FirstName = "Mustafa", LastName = "Kemal" };

            // Compare them
            Console.WriteLine(employee1 == employee2);

            // Change second employee Id
            employee2.Id = 1;

            Console.WriteLine(employee1 == employee2); 
        }
    }
}