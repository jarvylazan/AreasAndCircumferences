using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasAndCircumferences
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius has to be positive");
            }
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Circumference()
        {
            return 2 * Math.PI * radius;
        }
    }
}