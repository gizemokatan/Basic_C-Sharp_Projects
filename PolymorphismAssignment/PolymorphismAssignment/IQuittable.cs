using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // This interface declares a Quit method with no return type (void)
    public interface IQuittable
    {
        // any class that implements this interface must define Quit()
        void Quit();
    }
}
