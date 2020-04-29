using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Odd_num(15);

            Console.WriteLine("");
            int sum = Program.Add(23, 52);
            Console.WriteLine("Sum = {0} ", sum);

            int result = 0;
            Sub(20, 10, out result);
            Console.WriteLine("Subtraction = {0}", result);

            ParamsMethod(1, 2, 3, 4, 5);
        }
        public void Odd_num(int n)
        {
            Console.WriteLine("Odd numbers are ");
            for(int i = 1; i<=n; i+=2)
            {
                Console.Write("{0}   ", i);
            }
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static void Sub(int num3 , int num4 , out int result)
        {
            result = num3 - num4;
        }

        public static void ParamsMethod(params int[] num)
        {
            Console.WriteLine("There are {0} elements in an array", num.Length);
            foreach(int i in num)
            {
                Console.Write("{0}   ", i);
            }
        }
    }
}
