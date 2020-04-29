using System;

namespace Class
{
    class Student
    {
        string _name;
        string _rank;
        public Student(string Name, string Rank)
        {
            this._name = Name;
            this._rank = Rank;
        }
        public void Print()
        {
            Console.WriteLine("Miss {0}", this._name + " has got " + this._rank +" rank" );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student("Richa", "First");
            S.Print();
        }
    }
}
