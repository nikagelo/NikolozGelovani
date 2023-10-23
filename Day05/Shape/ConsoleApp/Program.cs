using Shape1.Abstract;
Console.WriteLine("Enter the shape");
string? input = Console.ReadLine();
double trianglePerimeter, triangleSurface, rectPerimeter, rectSurface, circlePerimeter, circleSurface;

switch (input)
{
    case "1":
        Triangle triangle = new Triangle();
        Console.WriteLine("Enter the first side");
        string? TriangleSide1 = Console.ReadLine();
        triangle.a = Convert.ToDouble(TriangleSide1);
        Console.WriteLine("Enter the second side");
        string? TriangleSide2 = Console.ReadLine();
        triangle.b = Convert.ToDouble(TriangleSide2);
        Console.WriteLine("Enter the third side");
        string? TriangleSide3 = Console.ReadLine();
        triangle.c = Convert.ToDouble(TriangleSide3);
       
        trianglePerimeter = triangle.Perimeter(triangle.a, triangle.b, triangle.c);
        triangleSurface = triangle.Surface(triangle.a, triangle.b, triangle.c);
      
        break;
    case "2":
        Rectangle rect = new();
        Console.WriteLine("Enter the first side");
        string? rectSide1 = Console.ReadLine();
        rect.a = Convert.ToDouble(rectSide1);
        Console.WriteLine("Enter the second side");
        string? rectSide2 = Console.ReadLine();
        rect.b = Convert.ToDouble(rectSide2);
        rectPerimeter = rect.Perimeter(rect.a, rect.b);
        rectSurface = rect.Surface(rect.a, rect.b);
        Console.WriteLine($"Perimeter = {rectPerimeter}, Surface = {rectSurface}, ");

        break;
    case "3":
        Circle circle = new Circle();
        Console.WriteLine("Enter the radius of circle");
        string? circleSide = Console.ReadLine();
        circle.r = Convert.ToDouble(circleSide);
        circlePerimeter = circle.Perimeter(circle.r);
        circleSurface = circle.Surface(circle.r);
        Console.WriteLine($"Perimeter = {circlePerimeter}, Surface = {circleSurface}, ");
        break;
}