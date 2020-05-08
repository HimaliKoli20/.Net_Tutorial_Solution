using System;
using System.Collections.Generic;

namespace ListCollectionClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer()
            {
                Id = 1,
                Name = "Mark",
                Salary = 10000
            };
            Customer C2 = new Customer()
            {
                Id = 2,
                Name = "Nick",
                Salary = 50000
            };
            Customer C3 = new Customer()
            {
                Id = 3,
                Name = "Sara",
                Salary = 20000
            };

            //List grow in size but array doesn't

            List<Customer> customers = new List<Customer>(2);

            customers.Add(C1);
            customers.Add(C2);
            customers.Add(C3);

            /*foreach(Customer c in customers)
            {
                Console.WriteLine("Id = {0} , Name = {1} , Salary ={2} ", c.Id, c.Name, c.Salary);
            }*/

            //Console.WriteLine("Index is {0} of C1 ", customers.IndexOf(C1));


            /*if(customers.Exists(cust => cust.Name.StartsWith("H")))
            {
                Console.WriteLine("Customer exist in the list");
            }
            else
            {
                Console.WriteLine("Customer does not exist in the list");
            }*/

            int Index = customers.FindLastIndex(cust => cust.Salary > 10000);
            Console.WriteLine("Index = " + Index);

        }   
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}

