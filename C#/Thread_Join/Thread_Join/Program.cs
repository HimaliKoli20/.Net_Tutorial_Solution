using System;
using System.Threading;

namespace Thread_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Fuction stated");
            Thread thread1 = new Thread(Program.Thread1Function);
            thread1.Start();

            Thread thread2 = new Thread(Program.Thread2Function);
            thread2.Start();

            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread 1 function completed in 1 sec");
            }
            else
            {
                Console.WriteLine("Thread 1 function is not completed in 1 sec");
            }
            thread2.Join();
            Console.WriteLine("Thread 2 function completed");

            if(thread1.IsAlive)
            {
                Console.WriteLine("Thread 1 function is still doing it's job");
            }            

            Console.WriteLine("Main function completed");
           
        }
        public static void Thread1Function()
        {
            Console.WriteLine("Thread1 Function started ");
            Thread.Sleep(5000);
            Console.WriteLine("Thread 1 function is about to return");
            Console.WriteLine("Thread 1 function is completed");
        }
        public static void Thread2Function()
        {
            Console.WriteLine("Thread2 Function started ");
        }
    }
    
}
