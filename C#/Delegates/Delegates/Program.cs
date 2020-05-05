using System;

namespace Delegates
{
    // A delegate is a type safe function pointer
    public delegate void HelloDelegate(string msg); //  This delegate will point to any method having same return type and takes string parameter

    class Program
    {
        public static void Hello(string smsg)
        {
            Console.WriteLine(smsg);
        }
        public static void Main(string[] args)
        {
            HelloDelegate H_Del = new HelloDelegate(Hello);
            H_Del("Hey there!");
           // Hello("Heyyy");
        }
    }
}
