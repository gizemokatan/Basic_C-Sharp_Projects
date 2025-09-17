using PolymorphismAssignment;
using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new Employee object and set some values
            Employee emp = new Employee();
            emp.FirstName = "Sample";
            emp.LastName = "Student";
            emp.Id = 1;

            // call SayName from Person (implemented in Employee)
            emp.SayName();

            // POLYMORPHISM: create an object of type IQuittable
            IQuittable worker = emp;

            // call Quit() using the interface reference
            worker.Quit();

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
