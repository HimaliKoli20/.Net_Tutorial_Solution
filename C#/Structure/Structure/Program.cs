using System;

namespace Structure
{
    public struct Student
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public Student(int Id , string Name)
        {
            this._id = Id;
            this._name = Name;
        }
        public void Print()
        {
            Console.WriteLine("Student ID = {0} \nStudent Name = {1}", this._id, this._name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student(50, "Richa");
            Student S1 = new Student
            {
                Id = 20,
                Name = "Dhriti"
            };
            S1.Print();
            S.Print();
        }
    }
}
