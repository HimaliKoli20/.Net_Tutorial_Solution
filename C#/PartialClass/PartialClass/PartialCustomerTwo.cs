using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClass
{
    public partial class PartialCustomer
    {
        public string GetFullname()
        {
            return _firstname + "," + _lastname;
        }
    }
}