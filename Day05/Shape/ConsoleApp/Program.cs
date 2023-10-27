using ConsoleApp;
using Shape1.Abstract;
Console.WriteLine("Enter the shape");
string? input = Console.ReadLine();

switch (input)
{
    case "1":
        Console.WriteLine("Enter the first side of triangle");
        double TriangleSide1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second side of triangle");
        double TriangleSide2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the third side of triangle");
        double TriangleSide3 = Convert.ToDouble(Console.ReadLine());
        Shape triangle = new Triangle(TriangleSide1, TriangleSide2, TriangleSide3);
        Console.WriteLine($"Perimeter of this triangle is {triangle.Perimeter()}");
        Console.WriteLine($"Surface of this triangle is {triangle.Surface()}");
        break;
    case "2":
        Console.WriteLine("Enter the first side of rectangle");
        double RectSide1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second side of rectangle");
        double RectSide2 = Convert.ToDouble(Console.ReadLine());
        Shape rect = new Rect(RectSide1, RectSide2);
        Console.WriteLine($"Perimeter of this triangle is {rect.Perimeter()}");
        Console.WriteLine($"Surface of this triangle is {rect.Surface()}");

        break;
    case "3":
        Console.WriteLine("Enter the radius of circle");
        double radius = Convert.ToDouble(Console.ReadLine());
        Shape circle = new Circle(radius);
        Console.WriteLine($"Perimeter of this triangle is {circle.Perimeter()}");
        Console.WriteLine($"Surface of this triangle is {circle.Surface()}");
        break;

    default:
        Console.WriteLine("Please enter number between 1 to 3");
        break;
}