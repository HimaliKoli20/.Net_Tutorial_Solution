using System;

namespace Other_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional Operator
            int a = 5, b = 7;
            if(a==5 && b==10)
            {
                Console.WriteLine("Both conditions are true");
            }
            if(a == 5 || b == 10)
            {
                Console.WriteLine("Any one or both conditions are true");
            }

            // Ternary Operator
            int num = 15;
            bool Isnum15 = num == 15 ? true : false;
            Console.WriteLine("Number == 15 is {0} ", Isnum15);
        }
    }
}
