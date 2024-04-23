using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasAndCircumferences
{
    public class Triangle : Shape
    {
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;

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
            double s = (this.side1 + this.side2 + this.side3) / 2;
            return Math.Sqrt(s * (s - this.side1) * (s - this.side2) * (s - this.side3));
        }

        public override double Perimeter()
        {
            return this.side1 + this.side2 + this.side3;
        }
    }
}