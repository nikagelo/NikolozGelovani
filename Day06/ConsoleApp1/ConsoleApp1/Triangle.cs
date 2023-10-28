using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangle
    {
        private double firstSide, secondSide, thirdSide;
        public Triangle(double side1, double side2, double side3) {
            if (!checkInequality(side1, side2, side3))
            {
                throw new ArgumentException("This triangle can not exist");
            }
            if (side1 <= 0||side2<=0||side3<=0)
            {
                throw new ArgumentOutOfRangeException("Input must be greater than 0");
            }
            
            firstSide = side1;
            secondSide = side2;
            thirdSide = side3;
        }
        private bool checkInequality(double s1, double s2, double s3)
        {
            return (s1 + s2 >= s3);
        }
        public double getPerimeter() { 
        return firstSide + secondSide + thirdSide;
        }
        public double getArea() {
            double halfP = getPerimeter() / 2;
            return Math.Sqrt(halfP*(halfP-firstSide)*(halfP-secondSide)*(halfP-thirdSide));
        }
        public static bool operator ==(Triangle left, Triangle right)
        {
            return left.firstSide == right.firstSide && left.secondSide == right.secondSide && left.thirdSide == right.thirdSide;
        }
        public static bool operator !=(Triangle left, Triangle right)
        {
            return left.firstSide != right.firstSide || left.secondSide != right.secondSide || left.thirdSide != right.thirdSide;
        }
        public static bool operator >(Triangle left, Triangle right) { 
            return left.getArea() > right.getArea();
        }
        public static bool operator <(Triangle left, Triangle right)
        {
            return left.getArea() < right.getArea();
        }
        public static Triangle operator +(Triangle left, Triangle right)
        {
            double sumTriangle = left.getArea()+right.getArea();
            double rightSide = Math.Sqrt(sumTriangle);
            return new Triangle(left.firstSide, left.secondSide, rightSide);
        }
        public static explicit operator Triangle(double side)
        {

            return new Triangle(side, side, side);
        }
    }
}