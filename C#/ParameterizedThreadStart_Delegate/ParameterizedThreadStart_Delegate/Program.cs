using System;
using System.Threading;

namespace ParameterizedThreadStart_Delegate
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Please enter the target number : ");            
            object target = Console.ReadLine();
            Console.WriteLine();

           // ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Number.PrintNumbers);
            Thread T1 = new Thread(Number.PrintNumbers);
            
            T1.Start(target);
        }
    }

    class Number
    {
        public static void PrintNumbers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}