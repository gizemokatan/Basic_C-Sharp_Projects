using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define two numbers
            int num1 = 7;
            int num2 = 3;

            // Addition
            int addition = num1 + num2;
            Console.WriteLine("Addition result: " + addition); // Output: 12

            // Subtraction
            int difference = num1 - num2;
            Console.WriteLine("Subtraction result: " + difference); // Output: -2

            // Multiplication
            int product = num1 * num2;
            Console.WriteLine("Multiplication result: " + product); // Output: 35

            // Division
            int quotient = num1 / num2; // 12 ÷ 3 = 4
            Console.WriteLine("Division result: " + quotient); // Output: 4

            // Modulus
            int remainder = num1 % num2; // 7 % 3 = 1
            Console.WriteLine("Modulus result: " + remainder); // Output: 1

            //Different Data Types
            int num1 = 7;
            float num2 = 5.5f;
            float total = num1 + num2;
            int total = num1 + (Int32)num2;
            Console.WriteLine("Total: " + total); // Output: 12

            //Math Casting
            double num1 = 7.03230923;
            float num2 = 5.9f;
            //double total = num1 + num2;
            float total = (float)num1 + num2;
            Console.WriteLine("Total after casting: " + total); // Output: 12.932309
            
            //Casting With Math 
            decimal num1=7.03230923m;
            int num2 = 5;
            decimal total = num1 + num2; // Output is 12.03230923

            decimal num1= 7.03230923m;
            sbyte num2 = 5;
            decimal total = num1 + num2; // Output is 12.03230923


            // Console close wait
            Console.ReadKey();
        }
    }
}