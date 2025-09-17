using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Employee object and set properties
            Employee emp = new Employee();
            emp.FirstName = "Sample";
            emp.LastName = "Student";
            emp.Id = 1; // example id

            // call SayName() method from Person class
            emp.SayName();

            // wait for user before closing
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
