using System;

namespace Switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int coffee_cost = 0;
            Console.WriteLine("Welcome to Coffee House");
            Start:
            Console.WriteLine("Please select your coffee size - 1-small, 2-medium, 3-large");
            int coffee_size = int.Parse(Console.ReadLine());
            
            switch (coffee_size)
            {
                case 1:
                    coffee_cost += 10;
                    break;
                case 2:
                    coffee_cost += 20;
                    break;
                case 3:
                    coffee_cost += 30;
                    break;
                default:
                    Console.WriteLine("Please enter valid coffee size ");
                    goto Start;
            }
            Choice:
            Console.WriteLine("Anything else - Yes or no");
            string choice = Console.ReadLine();

            switch(choice.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Please select valid choice");
                    goto Choice;
            }
            
            Console.WriteLine("Your bill amount is {0} ", coffee_cost);
            Console.WriteLine("Thank you for visiting");
        }
    }
}
