using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of MathOperations class
            MathOperations math = new MathOperations();

            // ask user for the first number
            Console.WriteLine("Please enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // ask user for the second number
            Console.WriteLine("Please enter the second number (or just press Enter to skip):");
            string input2 = Console.ReadLine();

            int result;

            if (string.IsNullOrWhiteSpace(input2))
            {
                // if user skipped, only pass the first number
                result = math.AddNumbers(num1);
            }
            else
            {
                // if user typed something, convert it to int and pass both numbers
                int num2 = Convert.ToInt32(input2);
                result = math.AddNumbers(num1, num2);
            }

            Console.WriteLine("The result is: " + result);
            Console.ReadLine();
        }
    }
}
