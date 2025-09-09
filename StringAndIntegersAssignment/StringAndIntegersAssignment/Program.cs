using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple list of integers
            List<int> numbers = new List<int>() { 2,4,6,8,10,20};

            // Ask user for a number
            Console.Write("Please enter a number to divide the list items by: ");
            string userInput = Console.ReadLine();

            try
            {
                // Convert the input string to an integer
                int divisor = int.Parse(userInput);

                // Loop through each number in the list
                foreach (int num in numbers)
                {
                    // Divide the number by the user input
                    int result = divisor / num;

                    // Print the result
                    Console.WriteLine (divisor + " / " + num + " = " + result);
                }
            }

            catch (FormatException ex)
            {
                // If the user types letters instead of numbers
                Console.WriteLine("Format error: " + ex.Message);
            }

            catch (DivideByZeroException ex)
            {
                // If the user types 0
                Console.WriteLine("Divide by zero error: " + ex.Message);
            }

            catch (Exception ex)
            {
                // Any other error will come here
                Console.WriteLine("Other error: " + ex.Message);
            }

            Console.WriteLine("The program continued after try/catch.");
        }
    }

