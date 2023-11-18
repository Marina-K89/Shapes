using System;


namespace Shapes
{
    public class Triangle : ISquare
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Length of triangle sides must be greater than zero.");

            side1 = a;
            side2 = b;
            side3 = c;
        }

        public double SemiPerimeter() 
        {
            return (side1 + side2 + side3) / 2;            
        }


        public double Square()
        {
            double semiPer = SemiPerimeter();
            return Math.Sqrt(semiPer * (semiPer - side1) * (semiPer - side2) * (semiPer - side3));
        }     

        public bool IsRigthAngled()
        {
            double s1 = side1 * side1;
            double s2 = side2 * side2;
            double s3 = side3 * side3;

            return ((s1 == s2 + s3) || (s2 == s1 + s3) || (s3 == s1 + s2));                        
        }
    }
}
