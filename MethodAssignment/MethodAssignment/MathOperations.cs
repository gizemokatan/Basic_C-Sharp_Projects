using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MethodAssignment
{
    // This class has one method that takes two ints, one is optional
    public class MathOperations
    {
        // method takes two numbers, second is optional with default value = 0
        public int AddNumbers(int firstNumber, int secondNumber = 0)
        {
            // add the two numbers together and return result
            return firstNumber + secondNumber;
        }
    }
}
