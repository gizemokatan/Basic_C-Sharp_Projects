using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    // This class has one void method that takes two integers
    public class MathOperations
    {
        // void method: does a math operation on first number, prints the second number
        public void DoOperation(int firstNumber, int secondNumber)
        {
            // do a math operation with firstNumber
            int result = firstNumber * 2;

            // show the math operation result
            Console.WriteLine("First number * 2 = " + result);

            // display the second number directly to the screen
            Console.WriteLine("Second number is: " + secondNumber);
        }
    }
}

