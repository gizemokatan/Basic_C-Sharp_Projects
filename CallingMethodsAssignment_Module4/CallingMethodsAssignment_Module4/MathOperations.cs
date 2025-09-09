using System;

namespace CallingMethodsAssignment_Module4
{
    // very simple math class for beginners
    public class MathOperations
    {
        // this method multiplies the number by 2
        public int MultiplyByTwo(int number)
        {
            return number * 2;
        }

        // this method returns the square of the number
        public int SquareNumber(int number)
        {
            return number * number;
        }

        // this method adds 10 to the number
        public int AddTen(int number)
        {
            return number + 10;
        }
    }
}
