using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        // Properties for Employee
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload == operator
        public static bool operator == (Employee emp1, Employee emp2)
        {
            // Check if both objects are null
            if (emp1 is null && emp2 is null)
                return true;

            // Check if one of them is null
            if (emp1 is null || emp2 is null)
                return false;

            // Compare only Id
            return emp1.Id == emp2.Id;
        }

        // Overload != operator
        public static bool operator != (Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
