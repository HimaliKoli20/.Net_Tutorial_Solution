using System;

namespace While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a target value");
            int num = int.Parse(Console.ReadLine());
            int even = 0;
            while(even <= num)
            {
                if(even%2==0)
                {
                    Console.Write("{0}  ", even);                  
                }
                even ++;
            }
        }
    }
}
