using System;

namespace StructAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an object of type Number
            Number myNumber = new Number();

            // Assign a value to the Amount property
            myNumber.Amount = 253.36m;

            Console.WriteLine("The amount is: " + myNumber.Amount);
            Console.ReadLine();
        }
    }
}
