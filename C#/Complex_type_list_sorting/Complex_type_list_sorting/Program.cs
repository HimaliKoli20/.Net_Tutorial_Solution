using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Complex_type_list_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 10,
                Name = "Sara",
                Salary = 30000
            };
            Customer customer2 = new Customer()
            {
                ID = 11,
                Name = "John",
                Salary = 15000
            };
            Customer customer3 = new Customer()
            {
                ID = 12,
                Name = "Mike",
                Salary = 20000
            };

            List<Customer> listcustomers = new List<Customer>();
            listcustomers.Add(customer1);
            listcustomers.Add(customer2);
            listcustomers.Add(customer3);

            Console.WriteLine("List before soting");
            foreach(Customer customer in listcustomers)
            {
                Console.WriteLine("Id = {0} , Name = {1} , Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }
            listcustomers.Sort();

            Console.WriteLine("List after soting by Salary");
            foreach (Customer customer in listcustomers)
            {
                Console.WriteLine("Id = {0} , Name = {1} , Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }

            SortByName sortByName = new SortByName();
            listcustomers.Sort(sortByName);
            Console.WriteLine("List after soting by Name");
            foreach (Customer customer in listcustomers)
            {
                Console.WriteLine("Id = {0} , Name = {1} , Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }
        }
    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x , Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


        public int CompareTo(Customer other)
        {
            /*if(this.Salary > other.Salary)
            { return 1; }
            else if(this.Salary < other.Salary)
            { return -1; }
            else
            { return 0; }*/

             return this.Salary.CompareTo(other.Salary);
        }

    }
    
}
