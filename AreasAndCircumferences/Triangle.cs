using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasAndCircumferences
{
    public class Triangle : Shape
    {
        double side1;
        double side2;
        double side3;
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("All of the sides must be positive");
            }
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double Area()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public override double Circumference()
        {
            return side1 + side2 + side3;
        }
    }
}