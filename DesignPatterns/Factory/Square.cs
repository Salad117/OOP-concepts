﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class Square
    {
        double side;
        public Square(double x)
        {
            this.side = x;
        }
        public double CalcArea()
        {
            return this.side;
        }
    }
}
