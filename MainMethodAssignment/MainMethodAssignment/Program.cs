using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object of MathOperations class
            MathOperations math = new MathOperations();

            // call the int method
            int intResult = math.DoMath(5);
            Console.WriteLine("Result of int method: " + intResult);

            // call the decimal method
            int decimalResult = math.DoMath(7.5m);
            Console.WriteLine("Result of decimal method: " + decimalResult);

            // call the string method
            int stringResult = math.DoMath("4");
            Console.WriteLine("Result of string method: " + stringResult);

            Console.ReadLine();
        }
    }
}
