using System;
using System.Collections.Generic;

namespace Sort_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> Number = new List<int> { 5, 4, 9, 2, 7, 3, 6, 1, 0, 8 };
            Console.WriteLine("Numbers before sort");
            foreach(int num in Number)
            {
                Console.Write(num);
                Console.Write("  ");
            }

            Console.WriteLine("\n");
            Number.Sort();

            Console.WriteLine("Numbers after sort");
            foreach (int num in Number)
            {
                Console.Write(num);
                Console.Write("  ");
            }

            Console.WriteLine("\n");
            Number.Reverse();

            Console.WriteLine("Numbers in descending order ");
            foreach (int num in Number)
            {
                Console.Write(num);
                Console.Write("  ");
            }
            Console.WriteLine("\n");
            */

            List<string> alphabet = new List<string> { "H", "B", "Z", "G", "K" };

            Console.WriteLine("Alphabets before sort ");
            foreach (string alpha in alphabet)
            {
                Console.Write(alpha);
                Console.Write("  ");
            }

            Console.WriteLine("\n");
            alphabet.Sort();
            Console.WriteLine("Alphabets after sort ");
            foreach (string alpha in alphabet)
            {
                Console.Write(alpha);
                Console.Write("  ");
            }

            Console.WriteLine("\n");
            alphabet.Reverse();
            Console.WriteLine("Alphabets in descending order ");
            foreach (string alpha in alphabet)
            {
                Console.Write(alpha);
                Console.Write("  ");
            }
        }
    }
}
