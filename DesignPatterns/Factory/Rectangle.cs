using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class Rectangle
    {
        double Length, width;
        public Rectangle(double x, double y)
        {
            this.Length = x;
            this.width = y;
        }
        public double CalcArea()
        {
            return Length;
            
        }
    }
}
