using System;
using System.Collections.Generic;
using System.Text;

namespace PartialMethod
{
    public partial class SamplePartialClass
    {
        partial void SampleMethod()                                        // Implimentation
        {                                                                 // Partial methods are private by default
            Console.WriteLine("Sample Method Invoked");                  // Return type must be void
        }
        
    }
}
