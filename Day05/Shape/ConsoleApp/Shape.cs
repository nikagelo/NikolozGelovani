using System.Runtime.ConstrainedExecution;

namespace Shape1.Abstract;

public abstract class Shape
{
    public int x = 0;
    public double  _a, _b, _c, _r, _Per;
    public Shape() {
    }

    public static double Surface()
    {
        return 0;
    }

    public static double Perimeter()
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
    public Triangle()
    {
        Perimeter(a, b, c);
        Surface(a, b, c);
    }

    public double a {
        get {
            return _a;
        }
        set {
            _a = value;
            checkNull(_a);
            
        } 
    }
    public double b { 
        get { 
            return _b;
        } 
        set { 
            _b = value;
            checkNull(b);
        } 
    }
    public double c {
        get {
            return _c;
                }
        set {
            _c = value;
            checkNull(_c);
        }
    }
    public double Per { get {
            return _Per;
        }
        set {
            
        } 
    }

    public bool checkInequality()
    {
        if (_a + _b >= _c)
        {
            return true;
        }
        else
        {
            throw new Exception("This triangle can not exist");
        }
    }
    public double Perimeter(double a, double b, double c)
    {
    
       checkInequality();
       _Per = a + b + c;
       return _Per;
    }
    public double Surface(double a, double b, double c)
    {
        double P = _Per / 2;
        double _surface = Math.Sqrt(P*(P-a)*(P-b)*(P-c));
        return _surface;
    }
    
}
public class Rectangle : Shape {
    public double a
    {
        get
        {
            return _a;
        }
        set
        {
            _a = value;
            checkNull(a);

        }
    }
    public double b
    {
        get
        {
            return _b;
        }
        set
        {
            _b = value;
            checkNull(b);
        }
    }
    public double Perimeter(double a, double b)
    {
       double Per = (a + b) * 2;
       return Per;
    }
    public double Surface(double a, double b)
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
            return _r;
        }
        set
        {
            _r = value;
            checkNull(r);

        }
    }
    public double Perimeter(double r)
    {
        double Per = 2 * r * Math.PI;
        return Per;
    }
    public double Surface( double r)
    {
        double Sur = r   *  r * Math.PI;
        return Sur;

    }

}