using System;
using System.Threading;


namespace ThreadStart_Delegate
{
    class Program
    {
        public static void Main()
        {
            //Thread T1 = new Thread(Number.PrintNumbers);
            //Thread T1 = new Thread(delegate() { Number.PrintNumbers(); });      //using delegate
            //Thread T1 = new Thread(()=>Number.PrintNumbers());                  //using lambda exp
            Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));

            T1.Start();
        }
    }

    class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
