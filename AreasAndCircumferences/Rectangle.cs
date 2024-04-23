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
        private readonly double length;
        private readonly double width;

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
            return this.length * this.width;
        }

        public override double Perimeter()
        {
            return 2 * (this.length + this.width);
        }
    }
}
