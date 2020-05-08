using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer()
            {
                Id = 1,
                Name = "Mark",
                Salary = 10000,
                Type = "RetailCustomer"
            };
            Customer C2 = new Customer()
            {
                Id = 2,
                Name = "Nick",
                Salary = 50000,
                Type = "CorporateCustomer"
            };
            Customer C3 = new Customer()
            {
                Id = 3,
                Name = "Sara",
                Salary = 20000,
                Type = "RetailCustomer"
            };
            Customer C4 = new Customer()
            {
                Id = 4,
                Name = "Sara",
                Salary = 30000,
                Type = "CorporateCustomer"
            };
            List<Customer> RetailCustomer = new List<Customer>();
            RetailCustomer.Add(C1);
            RetailCustomer.Add(C3);

            List<Customer> CorporateCustomer = new List<Customer>();
            RetailCustomer.Add(C2);
            RetailCustomer.Add(C4);

            RetailCustomer.InsertRange(3, CorporateCustomer);
            foreach(Customer c in RetailCustomer)
            {
                Console.WriteLine("Id = {0} , Name = {1} , Salary = {2} , Type = {3}", c.Id, c.Name, c.Salary , c.Type);
            }

        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }

    }

}
           
    

