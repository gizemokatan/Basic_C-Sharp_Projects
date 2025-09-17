using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Employee object and set first and last name
            Employee emp = new Employee();
            emp.FirstName = "Sample";
            emp.LastName = "Student";

            // call SayName() method (implemented in Employee)
            emp.SayName();

            // wait before closing
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
