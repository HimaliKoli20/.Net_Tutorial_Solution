using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClass
{
    //Partial Keyword is must.
    public partial class PartialCustomer
    {
        private string _firstname;
        private string _lastname;

        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
    }
}