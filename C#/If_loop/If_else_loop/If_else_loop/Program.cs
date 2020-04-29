using System;

namespace If_else_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //part1
            Console.WriteLine("Enter any number ");
            int num = int.Parse(Console.ReadLine());
            if(num==1)
            {
                Console.WriteLine("Number = 1");
            }
            else if (num == 2)
            {
                Console.WriteLine("Number = 2");
            }
            else if (num == 3)
            {
                Console.WriteLine("Number = 3");
            }
            else 
            {
                Console.WriteLine("Number is not between 1 and 3 ");
            }

            //part2
            Console.WriteLine("Enter num1 ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2 ");
            int num2 = int.Parse(Console.ReadLine());
            if(num1==3||num2==6)
            {
                Console.WriteLine("Number is 3 or 6");
            }
            else
            {
                Console.WriteLine("Number is neither 3 nor 6");
            }
            if (num1 == 5 && num2 == 10)
            {
                Console.WriteLine("Numbers are 5 and 10");
            }
            

        }
    }
}
