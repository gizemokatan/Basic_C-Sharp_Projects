using ClassMethodAssignment;
using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user to enter a number
            Console.WriteLine("Please enter a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // call the method that divides by two (int version)
            int intResult;
            MathOperations.DivideByTwo(userNumber, out intResult);

            // show the result of int division
            Console.WriteLine("Result (int version): " + intResult);

            // call the overloaded method with double
            double doubleResult;
            MathOperations.DivideByTwo((double)userNumber, out doubleResult);

            // show the result of double division
            Console.WriteLine("Result (double version): " + doubleResult);

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
