using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[3];
            customer[0] = new Customer
            {
                Name = "Richa",
                Gender = Gender.Female
            };
            customer[1] = new Customer
            {
                Name = "Sam",
                Gender = Gender.Male
            };
            customer[2] = new Customer
            {
                Name = "Kiran",
                Gender = Gender.Unknown
            };
            foreach (Customer customer1 in customer)
            {
                Console.WriteLine("Name = {0} and Gender = {1} ", customer1.Name, customer1.Gender);
            }
        }
    }
    /*public static string GetGender(Gender gender)
    {
        switch (gender)
        {
            case Gender.Unknown:
                return "Unknown";

            case Gender.Male:
                return "Male";

            case Gender.Female:
                return "Female";

            default:
                return "Invalid gender";

        }
    }*/

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}

