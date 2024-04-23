﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasAndCircumferences
{
    public class Circle : Shape
    {
        private readonly double radius;

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
            return Math.PI * this.radius * this.radius;
        }

        public override double Circumference()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}