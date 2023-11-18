using System;

namespace Shapes
{
    public class Circle : ISquare
    {
        private double radius;        

        public Circle(double r)
        {
            if (r <= 0)
                throw new Exception("Radius of circle must be greater than zero.");

            radius = r;            
        }

        public double Square() => Math.PI * radius * radius;        
    }
}
