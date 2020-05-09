using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Compex_type_list_sorting_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 21,
                Name = "Raksha",
                Salary = 50000
            };
            Customer customer2 = new Customer()
            {
                Id = 25,
                Name = "Isha",
                Salary = 40000
            };
            Customer customer3 = new Customer()
            {
                Id = 19,
                Name = "Vishal",
                Salary = 20000
            };

            List<Customer> listcustomers = new List<Customer>();

            listcustomers.Add(customer1);
            listcustomers.Add(customer2);
            listcustomers.Add(customer3);

            Comparison<Customer> comparisonOfCustomer = new Comparison<Customer>(CustomerComparison);
            Console.WriteLine("Customer list before sorting ");
            foreach(Customer c in listcustomers)
            {
                Console.WriteLine(c.Id);
            }

            //listcustomers.Sort(comparisonOfCustomer);
            //listcustomers.Sort(delegate (Customer c1, Customer c2) { return c1.Id.CompareTo(c2.Id); });
            listcustomers.Sort((x, y) => x.Id.CompareTo(y.Id));
            Console.WriteLine("Customer list after sorting using lambda expresion");
            foreach (Customer c in listcustomers)
            {
                Console.WriteLine(c.Id);
            }
        }
        private static int CustomerComparison(Customer x , Customer y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}
