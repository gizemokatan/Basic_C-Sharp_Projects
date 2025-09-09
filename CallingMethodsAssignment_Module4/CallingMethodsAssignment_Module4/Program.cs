using System;

namespace CallingMethodsAssignment_Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            // make a new object of MathOperations
            MathOperations math = new MathOperations();

            // ask the user for a number
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // call first method
            int result1 = math.MultiplyByTwo(number);
            Console.WriteLine("Multiply by 2: " + result1);

            // call second method
            int result2 = math.SquareNumber(number);
            Console.WriteLine("Square of number: " + result2);

            // call third method
            int result3 = math.AddTen(number);
            Console.WriteLine("Add 10: " + result3);

            Console.ReadLine();
        }
    }
}
