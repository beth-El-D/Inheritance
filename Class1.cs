using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mnbv
{

    internal class Class1
    {
    }

    abstract class IShape1
    {
        abstract public double calculateArea();
        abstract public double calculatePerimeter();
    }

    class Circle : IShape1
    {
        public double radius { get; set; }
        public static double PI = 3.14;
        public double area { get; set; }
        public double perimeter { get; set; }

        public override double calculateArea()
        {
            area = PI * (radius * radius);
            return area;
        }

        public override double calculatePerimeter()
        {
            perimeter = 2 * PI * radius;
            return perimeter;
        }
    }

    class rectangle : IShape1
    {

        public double length { get; set; }
        public double width { get; set; }
        public double area { get; set; }
        public double perimeter { get; set; }


        public override double calculateArea()
        {
            area = length * width;
            return area;
        }

        public override double calculatePerimeter()
        {
            perimeter = 2 * (length + width);
            return perimeter;
        }
    }

}


