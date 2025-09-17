using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // Generic Employee class with type parameter T
    public class Employee<T>
    {
        // Property called Things which is a list of type T
        public List<T> Things { get; set; }
    }
}