using System;

namespace Interfaces
{
    // Interfaces don't have access modifers. They are public by default
    // Interfaces have only declaration and no implementation.
    interface ICustomer
    {
        void Print();
    }

    interface IStudent
    {
        void Print1();
    }

    // Class cannot inherit from more than one base class but it can inherit from more than one interface
    class Customer: ICustomer , IStudent
    {
        public void Print()
        {
            Console.Write("Hello");
        }
        void IStudent.Print1()
        {
            Console.WriteLine(" BE EXTC");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C = new Customer();
            C.Print();
            ((IStudent)C).Print1();   //Explicit Interface(It is uses when both the interfaces have same method name)
        }
    }
}
