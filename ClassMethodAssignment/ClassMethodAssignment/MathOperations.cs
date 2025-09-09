using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public static class MathOperations
    {
        public static void DivideByTwo(int number, out int result)
        {
            result = number / 2;
        }

        // overloaded method: divide by two but return as double
        public static void DivideByTwo(double number, out double result)
        {
            result = number / 2.0;
        }
    }
}

