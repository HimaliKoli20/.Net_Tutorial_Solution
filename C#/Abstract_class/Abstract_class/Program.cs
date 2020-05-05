using System;

namespace Abstract_class
{
    /* Abstract class does not provide implimentation
     It can only be used as base class
    s It cannot be sealed
     Can have access modifiers and members are private by default*/
    public abstract class Fruit
    {
        public abstract void Print();
    }

    // Non Abstract class has to provide implimentation for abstract class
    public class List 
    {
        public void Print()
        {
            Console.WriteLine("-Mango \n-Pineapple \n-Cherry \n-Banana");
        }
    }


    class Program : Fruit
    {
        public override void Print()
        {
            Console.WriteLine("List Of Fruits");
        }
        
        static void Main(string[] args)
        {
            Program P = new Program();
            P.Print();
            List L = new List();
            L.Print();
        }
    }
}
