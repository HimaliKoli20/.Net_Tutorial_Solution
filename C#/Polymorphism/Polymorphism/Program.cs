using System;

namespace Polymorphism
{
    class Bollywood
    {
        public string movie = "Baaghi";
        public virtual void Print()
        {
            Console.WriteLine(movie);
        }
    }
    class Action_film : Bollywood
    {
        public override void Print()
        {
            Console.WriteLine(movie+ " 2");
        }
    }
    class Comedy_movie : Bollywood
    {
        public override void Print()
        {
            Console.WriteLine(movie + " 3");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bollywood[] films = new Bollywood[3];

            films[0] = new Bollywood();
            films[1] = new Action_film();
            films[2] = new Comedy_movie();

            foreach(Bollywood i in films)
            {
                i.Print();
            }
        }
    }
}
