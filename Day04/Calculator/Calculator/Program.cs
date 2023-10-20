using CalculatorClass;
internal class Program
{
    private static void Main(string[] args)
    {
        int sum = (int)Calculator.Add(5, 6);
        int substract = (int)Calculator.Subtract(5, 6);
        int multiply = (int)Calculator.Multiply(5, 6);
        int divide = (int)Calculator.Divide(5, 6);
    }
    }