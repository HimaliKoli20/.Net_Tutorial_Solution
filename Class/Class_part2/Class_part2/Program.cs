using System;

namespace Class_part2
{
    class Circle
    {
        static float _pi = 3.141F;
        int _radius;
        public Circle(int Radius)
        {
            this._radius = Radius;
        }
        public float Area()
        {
            return Circle._pi * this._radius * this._radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle C = new Circle(5);
            float area = C.Area();
            Console.WriteLine("Area = {0}", area);
        }
    }
}
