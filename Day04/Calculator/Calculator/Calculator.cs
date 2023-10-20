namespace CalculatorClass;
public static class Calculator
{
    public static float Add(float a, float b) { 
        float sum = a+ b;
        Console.WriteLine("a + b = "+sum);
        return sum;

    }
    public static float Subtract(float a, float b)
    {
        float minus = a - b;
        Console.WriteLine("a - b = " + minus);
        return minus;

    }
    public static float Multiply(float a, float b)
    {
        float product = a * b;
        Console.WriteLine("a * b = " + product);
        return product;
    }
    public static float Divide(float a, float b)
    {
        float left = a / b;
        Console.WriteLine("a / b = " + left);
        return left;

    }
}
