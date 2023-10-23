using Shape1.Abstract;
Console.WriteLine("Enter the shape");
string?  input = Console.ReadLine();
double a, b, c, perimeter, surface;

switch (input) {
    case "1":
        Console.WriteLine("Enter the first side");
        string? side1 = Console.ReadLine();
        a = Convert.ToDouble(side1);
        Console.WriteLine("Enter the second side");
        string? side2 = Console.ReadLine();
        b = Convert.ToDouble(side2);
        Console.WriteLine("Enter the third side");
        string? side3 = Console.ReadLine();
        c = Convert.ToDouble(side3);
        Triangle triangle = new Triangle(a, b, c);
        perimeter = triangle.Perimeter();
        surface = triangle.Surface();
        break;
    case "2":
        Console.WriteLine("test");
        break;
    case "3":
        Console.WriteLine("123");
        break;
}