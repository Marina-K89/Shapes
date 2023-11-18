using System;
using Shapes;
using static System.Console;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle { Radius = 5 };
            WriteLine("Square of circle is " + circle.Square());

            Triangle triangle = new Triangle { Side1 = 3, Side2 = 4, Side3 = 5 };
            WriteLine("Square of triangle is " + triangle.Square());
        }
    }
}
