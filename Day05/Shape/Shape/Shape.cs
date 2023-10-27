using System.Runtime.ConstrainedExecution;

namespace Shape1.Abstract;

public abstract class Shape
{
    public Shape() {
    }

    private static double Surface()
    {
        return 0;
    }

    private static double Perimeter()
    {
        return 0;
    }
    public double checkNull(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentNullException("Value must be greater that a 0");
        }
        return value;

    }
}
public class Triangle : Shape
{
    public Triangle(double a, double b, double c)
    {
        Perimeter();
        Surface();
    }

    public double a {
        get {
            return a;
        }
        set {
            checkNull(a);
            
        } 
    }
    public double b { 
        get { 
            return b;
        } 
        set { 
            checkNull(b);
        } 
    }
    public double c {
        get {
            return c;
                }
        set {
            checkNull(c);
        }
    }
    public double Per { get {
            return Per;
        }
        set {
            
        } 
    }

    public bool checkInequality()
    {
        if (a + b >= c)
        {
            return true;
        }

        return false;
    }
    public double Perimeter()
    {
       checkInequality();
       Per = a + b + c;
       return Per;
    }
    public double Surface()
    {
        double P = Per / 2;
        double surface = Math.Sqrt(P*(P-a)*(P-b)*(P-c));
        return surface;
    }
    
}
public class Rectangle : Shape {
    public double a
    {
        get
        {
            return a;
        }
        set
        {
            checkNull(a);

        }
    }
    public double b
    {
        get
        {
            return b;
        }
        set
        {
            checkNull(b);
        }
    }
    public double Perimeter()
    {
       double Per = (a + b) * 2;
       return Per;
    }
    public double Surface()
    {
        double Sur = a * b;
        return Sur;

    }

}
public class Circle : Shape {
    public double r
    {
        get
        {
            return r;
        }
        set
        {
            checkNull(r);

        }
    }
    public double Perimeter()
    {
        double Per = 2 * r * Math.PI;
        return Per;
    }
    public double Surface()
    {
        double Sur = r   *  r * Math.PI;
        return Sur;

    }

}