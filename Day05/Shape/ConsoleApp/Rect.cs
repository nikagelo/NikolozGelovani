using Shape1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Rect : Shape
    {
        private double firstSide, secondSide;
        public Rect(double side1, double side2)
        {
            if (side1<=0||side2<=0)
            {
                throw new ArgumentOutOfRangeException("Input must be greater than 0");
            }

            firstSide = side1;
           secondSide = side2; 
        }

        public override double Perimeter()
        {
            return 2*(firstSide+secondSide);
        }

        public override double Surface()
        {
            return firstSide*secondSide;
        }
    }
}
