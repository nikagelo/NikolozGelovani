using ConsoleApp1;
Console.WriteLine("Enter the first side of a first triangle: ");
double left1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second side of a first triangle: ");
double left2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the third side of a first triangle: ");
double left3 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the first side of a second triangle: ");
double right1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second side of a second triangle: ");
double right2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the third side of a second triangle: ");
double right3 = double.Parse(Console.ReadLine());


Triangle leftTriangle = new Triangle(left1, left2, left3);
Triangle rightTriangle = new Triangle(right1, right2, right3);
Triangle sumTriangle = leftTriangle +  rightTriangle;
Console.WriteLine("First triangle is EQUAL to the second triangle: " + (leftTriangle == rightTriangle));
Console.WriteLine("First triangle is NOT equal to the second triangle: " + (leftTriangle != rightTriangle));
Console.WriteLine("First triangle is GREATER than the second triangle: " + (leftTriangle > rightTriangle));
Console.WriteLine("First triangle is NOT GREATER than the second triangle: " + (leftTriangle < rightTriangle));
Triangle sameSide = (Triangle)5;
Console.WriteLine("Side of equilateral triangle: " + sameSide.getPerimeter()/3);
