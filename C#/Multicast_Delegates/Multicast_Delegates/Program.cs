using System;

namespace Multicast_Delegates
{
    //Points to more than one function
    //If return type is other that void then delegate returns the value of the last invoked method
    //It makes implimentation of observer design pattern(publish/subscribe) very simple
    public delegate void Sample();
    class Program
    {
        static void Main(string[] args)
        {
            Sample sam1, sam2, sam3 , sam4; 
            sam1 = new Sample(PrintMethod1);
            sam2 = new Sample(PrintMethod2);
            sam3 = new Sample(PrintMethod3);

            sam4 = sam1 + sam2 + sam3;
            //sam4 = sam1 + sam2 + sam3 - sam2;
            //sam4 += sam1;

            sam4();
        }

        public static void PrintMethod1()
        {
            Console.WriteLine("PrintMethod1 Invoked");
        }
        public static void PrintMethod2()
        {
            Console.WriteLine("PrintMethod2 Invoked");
        }
        public static void PrintMethod3()
        {
            Console.WriteLine("PrintMethod3 Invoked");
        }

    }
}
