using Shape1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Triangle : Shape
    {
        private double a, b, c;
        public Triangle(double side1, double side2, double side3)
        {
            if (side1<=0||side2<=0||side2<=0)
            {
                throw new ArgumentOutOfRangeException("Input must be greater than 0");
            }
            if (side1+side2<side3)
            {
                throw new ArithmeticException("This triangle can not be exist");
            }
            a = side1;
            b = side2;
            c = side3;
        }

        public override double Perimeter()
        {
            return a+b+c;
        }

        public override double Surface()
        {
            double halfP = Perimeter() / 2;
            return Math.Sqrt(halfP*(halfP-a)*(halfP-b)*(halfP-c));
        }
    }
}
