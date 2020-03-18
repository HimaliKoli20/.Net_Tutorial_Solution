using System;

namespace Nullable_type
{
    class Program
    {
        static void Main(string[] args)
        {
            int no_of_students = 100;
            int? failed_stud = null;
            if(failed_stud==null)
            {
                Console.WriteLine("No Student is failed");
            }
            else
            {
                Console.WriteLine("Some Students are failed");
            }
        }
    }
}
