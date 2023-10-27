using Shape1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(double r) {
            if (r <= 0) {
                throw new ArgumentOutOfRangeException("Input must be greater than 0");
            }
            radius = r;
        
        }
        public override double Perimeter()
        {
            return radius*2*Math.PI;
        }

        public override double Surface()
        {
            return Math.PI*Math.Pow(radius, 2);
        }
    }
}
