using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace PartialClass
{
    public class Customer
    {
        private string _firstname;
        private string _lastname;

        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }

        public string GetFullname()
        {
            return _firstname + "," + _lastname;
        }
    }   
}