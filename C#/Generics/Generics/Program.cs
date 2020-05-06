using System;

namespace Generics

{
    //It makes code independent of data type
    //Code resuability
    class Program
    {
        static void Main(string[] args)
        {
            bool AreTheyEqual = Calculator.AreEqual<string>("A", "B");
            if (AreTheyEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }
    }
    public class Calculator
    {
        public static bool AreEqual<T>(T Value1, T Value2)    //T stands for Data type
        {
            return Value1.Equals(Value2);
        }
    }

}
