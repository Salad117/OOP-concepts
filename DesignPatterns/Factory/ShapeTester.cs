using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            double length, width, radius;
            Console.WriteLine("Enter Length: ");
            length= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            width= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            //circle
            Circle c = new Circle(radius);
            Console.WriteLine("Area:" + c.calcArea());

            Rectangle rc = new Rectangle(length, width);
            Console.WriteLine("Area: " + rc.CalcArea());

            Console.Read();

        }
    }
}
