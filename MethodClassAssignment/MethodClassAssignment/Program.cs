using MethodClassAssignment;
using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object of MathOperations class
            MathOperations math = new MathOperations();

            // call the method in the normal way
            math.DoOperation(5, 10);

            // call the method by specifying parameter names
            math.DoOperation(firstNumber: 7, secondNumber: 20);

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
