﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class Circle
    {
        double radius;

        public Circle(double r)
        {
            this.radius = r;
        }

        public double CalcArea()
        {
            return Math.PI * (radius);
       }

        internal string calcArea()
        {
            throw new NotImplementedException();
        }
    }
}
