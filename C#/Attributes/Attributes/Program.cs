using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(10, 20);
            int Sum = Calculator.Add(new List<int>() { 10, 20, 30 });
            Console.WriteLine(Sum);
        }
    }
    public class Calculator
    {
        [Obsolete]
        public static int Add(int FN , int SN)
        {
            return FN + SN;
        }
        public static int Add(List<int> Numbers)
        {
            int sum=0;
            foreach (int Number in Numbers)
            {
                sum = sum + Number;
            }
            return sum;
        }
    }
}
