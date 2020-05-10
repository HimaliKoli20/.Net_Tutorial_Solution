using System;
using System.Threading;


namespace PassingData_to_the_ThreadFunction
{
    class Program
    {
        public static void Main()
        {
            
            Console.Write("Please enter the target number : ");           
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Number number = new Number(target);

            // Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            Thread T1 = new Thread(number.PrintNumbers);

            T1.Start();
        }
    }

    class Number
    {
        int _target;
        public Number(int target)
        {
            this._target = target;
        }

        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
