// <copyright file="Rectangle.cs" company="Alain Junior McCutcheon">
// Copyright (c) Alain Junior McCutcheon. All rights reserved.
// </copyright>

namespace AreasAndCircumferences
{
    public class Rectangle : Shape
    {
        private readonly double length;
        private readonly double width;

        // Constructor
        public Rectangle(double length, double width)
        {
            // The exception if the user inputed a negative number
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Length and width has to be positive");
            }

            this.length = length;
            this.width = width;
        }

        // Calculate area
        public override double Area()
        {
            return this.length * this.width;
        }

        // Calculate perimeter
        public override double Perimeter()
        {
            return 2 * (this.length + this.width);
        }
    }
}
