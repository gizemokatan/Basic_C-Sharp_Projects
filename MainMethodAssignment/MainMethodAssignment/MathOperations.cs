using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    // This class will have 3 methods with the same name "DoMath"
    public class MathOperations
    {
        // 1. Method: takes an int, adds 10, returns int
        public int DoMath(int number)
        {
            return number + 10;
        }

        // 2. Method: takes a decimal, subtracts 2, returns int
        public int DoMath(decimal number)
        {
            return (int)(number - 2);
        }

        // 3. Method: takes a string, tries to convert to int, multiplies by 3, returns int
        public int DoMath(string text)
        {
            int converted = Convert.ToInt32(text); // convert string to int
            return converted * 3;
        }
    }
}