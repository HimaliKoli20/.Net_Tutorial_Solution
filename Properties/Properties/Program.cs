using System;

namespace Properties
{
    class Student
    {
        private int _Id;
        private string _Name;
        private int _Age;

        public void SetId(int Id)
            
        {
            if (Id <= 0)
            {
                Console.WriteLine("Invalid ID");
            }
            this._Id = Id;

        }
        public int GetId()
        {
            return this._Id;
        }
        public void SetName(string Name)
        {
            if(string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("");
            }
            this._Name = Name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name; 
        }
        public void SetAge(int Age)
        {
            if(Age <=3)
            {
                Console.WriteLine("Invalid Age");
            }
            this._Age = Age;
        }
        public int GetAge()
        {
            return this._Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.SetId(10);
            S.SetName("Kiara");
            S.SetAge(5); 
            Console.WriteLine("Student ID is {0}. ", S.GetId());
            Console.WriteLine("Student Name is {0}.", S.GetName());
            Console.WriteLine("{0} ",S.GetName() +" is "+ S.GetAge()+" years old.");
        }
    }
}
