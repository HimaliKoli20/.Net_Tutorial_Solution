using System;
using System.Collections.Generic;

namespace Delegate_Usage
{ 
    //A function can be passed as a parameter using delegates
   
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { Id = 1, Name = "Sara", Salary = 1000, Experience = 2 });
            emplist.Add(new Employee() { Id = 2, Name = "Harsh", Salary = 2000, Experience = 1 });
            emplist.Add(new Employee() { Id = 3, Name = "Dhriti", Salary = 3000, Experience = 5 });
            emplist.Add(new Employee() { Id = 4, Name = "Viraj", Salary = 4000, Experience = 7 });
          

            Employee.PromoteEmp(emplist , emp => emp.Experience>=3);
        }

        
        delegate bool IsPromotable(Employee empl);

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public int Experience { get; set; }

            public static void PromoteEmp(List<Employee> emplist, IsPromotable is_Promotable)
            {
                foreach (Employee employee in emplist)
                {
                    if (is_Promotable(employee))
                    {
                        Console.WriteLine("Employee {0} gets promoted ",employee.Name);
                    }
                }
            }

        }
    }
}
