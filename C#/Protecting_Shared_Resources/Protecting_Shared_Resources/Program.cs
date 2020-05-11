using System;
using System.Threading;


namespace Protecting_Shared_Resources
{ 
    class Program
    {
        static int Total = 0;
        public static void Main()
        {
            Thread thread1 = new Thread(Program.AddOneMillion);
            Thread thread2 = new Thread(Program.AddOneMillion);
            Thread thread3 = new Thread(Program.AddOneMillion);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
            
            Console.WriteLine("Total = " + Total);
        }

        static object _lock = new object();
        public static void AddOneMillion()
        {
           
            //Method1
            /*for (int i = 1; i <= 1000000; i++)
            {
                Total++;
            }*/

            //Method2
            /*for (int i = 1; i <= 1000000; i++)
            {
                Interlocked.Increment(ref Total);
            }*/

            //Method3
            for (int i = 1; i <= 1000000; i++)
            {
                lock (_lock)
                {
                    Total++;
                }
            }
        }
    }
}
