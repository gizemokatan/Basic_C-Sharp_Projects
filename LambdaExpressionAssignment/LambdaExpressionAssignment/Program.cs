using LambdaExpressionAssignment;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeListApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Yellow" },
                new Employee { Id = 2, FirstName = "Daniel", LastName = "Bell" },
                new Employee { Id = 3, FirstName = "Anna", LastName = "Brown" },
                new Employee { Id = 4, FirstName = "Maria", LastName = "White" },
                new Employee { Id = 5, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 6, FirstName = "Adam", LastName = "Green" },
                new Employee { Id = 7, FirstName = "Nathan", LastName = "Black" },
                new Employee { Id = 8, FirstName = "Sam", LastName = "Hiller" },
                new Employee { Id = 9, FirstName = "Eric", LastName = "Taylor" },
                new Employee { Id = 10, FirstName = "Tom", LastName = "Miller" }
            };

            // Create new list with employees whose first name is "Joe"
            List<Employee> joesWithForeach = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joesWithForeach.Add(emp);
                }
            }

            // Print result from foreach
            Console.WriteLine("Employees named Joe (using foreach):");
            foreach (Employee joe in joesWithForeach)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }

            // Same action with lambda
            List<Employee> joesWithLambda = employees.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine("\nEmployees named Joe (using lambda):");
            foreach (Employee joe in joesWithLambda)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }

            // Employees with Id > 5
            List<Employee> idGreaterThanFive = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (Employee emp in idGreaterThanFive)
            {
                Console.WriteLine(emp.Id + " - " + emp.FirstName + " " + emp.LastName);
            }

            Console.ReadLine(); 
        }
    }
}
