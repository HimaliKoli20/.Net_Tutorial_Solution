using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
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

            Dictionary<int, Customer> DictionaryOfCustomer = new Dictionary<int, Customer>();
            DictionaryOfCustomer.Add(C1.Id, C1);
            DictionaryOfCustomer.Add(C2.Id, C2);
            DictionaryOfCustomer.Add(C3.Id, C3);

            Customer Cust2= DictionaryOfCustomer[2];

            Customer[] customers = new Customer[3];

            customers[0] = C1;
            customers[1] = C2;
            customers[2] = C3;
            
            //Customer cust;

            Dictionary<int, Customer> custdict = customers.ToDictionary(cust => cust.Id, cust => cust);


            //Console.WriteLine("Id = {0}, Name = {1} , Salary = {2}", Cust2.Id, Cust2.Name, Cust2.Salary);

            foreach(KeyValuePair<int,Customer> keyvaluepair in DictionaryOfCustomer)
            {
                Console.WriteLine("Customer Information of Id {0}", keyvaluepair.Key);
                Customer customer = keyvaluepair.Value;
                Console.WriteLine("Id = {0} , Name = {1} , Salary = {2} ", customer.Id, customer.Name, customer.Salary);
                Console.WriteLine();
            }

            
            /*if(DictionaryOfCustomer.TryGetValue(1 , out cust))
            {
                Console.WriteLine("Id = {0} , Name = {1} , Salary = {2} ", cust.Id, cust.Name, cust.Salary);
            }
            else
            {
                Console.WriteLine("The key is not found");
            }*/

            //Console.WriteLine("The total customers are {0}", DictionaryOfCustomer.Count);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}
