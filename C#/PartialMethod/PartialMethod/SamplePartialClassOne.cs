using System;
using System.Collections.Generic;
using System.Text;

namespace PartialMethod
{
    public partial class SamplePartialClass
    {
        partial void SampleMethod(); //Defination
        
        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            SampleMethod();
        }
    }
}
