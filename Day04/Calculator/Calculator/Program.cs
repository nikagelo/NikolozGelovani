﻿using CalculatorClass;
internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        calc.Add(5, 6);
        calc.Subtract(5, 6);
        calc.Multiply(5, 6);
        calc.Divide(5, 6);
    }
}