using System;

namespace Input_from_user
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", firstname, lastname);
        }
    }
}
