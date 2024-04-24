// <copyright file="Shape.cs" company="Jarvy Lazan">
// Copyright (c) Jarvy Lazan. All rights reserved.
// </copyright>

namespace AreasAndCircumferences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        // The two abstract methods to be overriden
        public abstract double Area();

        public abstract double Perimeter();
   }
}
