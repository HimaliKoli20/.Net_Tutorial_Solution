using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 2.143F;
            float h = 123455324412334.123F;   // too large value
            int b = Convert.ToInt32(a);
            int c = (int)h;
            Console.WriteLine(b);
            Console.WriteLine(c);

            string val_1 = "100";
            string val_2 = "100AB";
            int value_1 = int.Parse(val_1);
            Console.WriteLine(value_1);

            int value_2 = 0;
            bool istrue = int.TryParse(val_2, out value_2);
            if(istrue)
            {
                Console.WriteLine(value_2);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
