using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasAndCircumferences
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            if (length <= 0 || width <= 0) 
            {
                throw new ArgumentException("Length and width has to be positive");
            }
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }

        public override double Circumference()
        {
            return 2 * (length + width);
        }
    }
}
