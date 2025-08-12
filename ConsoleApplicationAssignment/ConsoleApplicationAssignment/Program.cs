using System;

namespace UserInputMathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes an input from the user, multiplies it by 50
            Console.Write("Enter a number to multiply by 50: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            double result1 = input1 * 50;
            Console.WriteLine("Result: " + result1);

            // Takes an input from the user, adds 25 to it
            Console.Write("Enter a number to add 25: ");
            double input2 = Convert.ToDouble(Console.ReadLine());
            double result2 = input2 + 25;
            Console.WriteLine("Result: " + result2);

            // Takes an input from the user, divides it by 12.5
            Console.Write("Enter a number to divide by 12.5: ");
            double input3 = Convert.ToDouble(Console.ReadLine()); 
            double result3 = input3 / 12.5;
            Console.WriteLine("Result: " + result3);

            // Takes an input from the user, check if it's greater than 50
            Console.Write("Enter a number to check if it is greater than 50: ");
            double input4 = Convert.ToDouble(Console.ReadLine());
            bool isGreaterThan50 = input4 > 50;
            Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);

            // Takes an input from the user,display the remainder when divided by 7
            Console.Write("Enter a number to get the remainder when divided by 7: ");
            int input5 = Convert.ToInt32(Console.ReadLine());
            int remainder = input5 % 7;
            Console.WriteLine("Remainder: " + remainder);

            Console.ReadLine();
        }
    }
}
