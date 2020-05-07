using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Indexers
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Company
    {
        private List<Employee> ListOfEmployees;

        public Company()
        {
            ListOfEmployees = new List<Employee>();


            ListOfEmployees.Add(new Employee() { ID = 1, Name = "Mike", Gender = "Male" });
            ListOfEmployees.Add(new Employee() { ID = 2, Name = "Sara", Gender = "Female" });
            ListOfEmployees.Add(new Employee() { ID = 3, Name = "Mary", Gender = "Female" });
            ListOfEmployees.Add(new Employee() { ID = 4, Name = "John", Gender = "Male" });
            ListOfEmployees.Add(new Employee() { ID = 5, Name = "Nick", Gender = "Male" });

        }

        public string this[int Id]
        {
            get
            {
                return ListOfEmployees.FirstOrDefault(emp => emp.ID == Id).Name;
            }
            set
            {
                ListOfEmployees.FirstOrDefault(emp => emp.ID == Id).Name = value;
            }
        }
            

    }
}