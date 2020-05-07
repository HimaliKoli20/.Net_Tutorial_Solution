using System;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNum(20, 8 , 45 , 50, 78);
        }

        public static void AddNum(int Num1 , int Num2 , params object[] restOfNum) //params parameter must be the last parameter
        {
            int result = Num1 + Num2;
            if(restOfNum != null)
            {
                foreach(int i in restOfNum)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = {0} ", result);
        }
    }
}
