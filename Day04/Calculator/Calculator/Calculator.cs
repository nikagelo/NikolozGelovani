namespace CalculatorClass;
public class Calculator
{
    public float Add(float a, float b) { 
        float sum = a+ b;
        Console.WriteLine("a + b = "+sum);
        return sum;

    }
    public float Subtract(float a, float b)
    {
        float minus = a - b;
        Console.WriteLine("a - b = " + minus);
        return minus;

    }
    public float Multiply(float a, float b)
    {
        float product = a * b;
        Console.WriteLine("a * b = " + product);
        return product;
    }
    public float Divide(float a, float b)
    {
        float left = a / b;
        Console.WriteLine("a / b = " + left);
        return left;

    }
}