using System;
using System.Collections.Generic;

  


namespace Generic_Queue_Collection_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 51,
                Name = "Ruhi",
                Gender = "Female"
            };
            Customer customer2 = new Customer()
            {
                Id = 45,
                Name = "Kiyara",
                Gender = "Female"
            };
            Customer customer3 = new Customer()
            {
                Id = 63,
                Name = "Viraj",
                Gender = "Male"
            };
            Customer customer4 = new Customer()
            {
                Id = 39,
                Name = "Nishad",
                Gender = "Male"
            };
            Customer customer5 = new Customer()
            {
                Id = 28,
                Name = "Isha",
                Gender = "Female"
            };

            Stack<Customer> stackCustomer = new Stack<Customer>();   //LIFO
            stackCustomer.Push(customer1);
            stackCustomer.Push(customer2);
            stackCustomer.Push(customer3);
            stackCustomer.Push(customer4);
            stackCustomer.Push(customer5);
            //Part 1
            /*foreach (Customer c in stackCustomer)
            {
                Console.WriteLine(c.Id + "-" + c.Name);
            }

            //Part 2
            Console.WriteLine("Total items in the stack  : {0}", stackCustomer.Count);
            Customer c1 = stackCustomer.Pop();                  //Remove and retirn the vlaue
            Console.WriteLine(c1.Id + "-" + c1.Name);
            Console.WriteLine("Total items left in the stack : {0}", stackCustomer.Count);
            */

            //Part 3
            Customer c2 = stackCustomer.Peek();    //Returns value without removing it and always return 1st value in the queue
            Console.WriteLine(c2.Id + "-" + c2.Name);








            /*          
          
            //Part 2
            Customer c1 = queuecustomers.Peek();    //Returns value without removing it and always return 1st value in the queue
            Console.WriteLine(c1.Id + "-" + c1.Name);
            //Part 3
            

            //Part 4
            if (queuecustomers.Contains(customer3))
            {
                Console.WriteLine("customer3 exists ");
            }
            else
            {
                Console.WriteLine("customer3 does not exists");
            }*/
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}

