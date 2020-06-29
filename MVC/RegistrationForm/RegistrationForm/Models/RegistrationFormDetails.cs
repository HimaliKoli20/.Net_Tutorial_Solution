using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationForm.Models
{
    public class RegistrationFormDetails
    {
        public string FirstName {get;set;}
        public string LastName  {get;set;}
        public string PhoneNumber { get;set;}
        public string Email { get;set;}
        public string DOB  { get;set;}
        public string Gender { get;set;}
        public string Qualification { get;set;}
        public string Branch { get;set;}
        public string YearOfPassing { get;set;}
        public string CurrentEmploymentStatus { get;set;}
        public string TotalWorkExperience { get;set;}
        public string InterestedJobProfiles { get;set;}
    }
}