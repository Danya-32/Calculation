using System;
using System.Globalization;

public class Calculator
{
    public double Memory { get; private set; }

    public void MemoryAdd(double value)
    {
        Memory += value;
    }

    public void MemoryClear()
    {
        Memory = 0;
    }

    public double MemoryRecall()
    {
        return Memory;
    }

    public double PerformOperation(string operation, double firstNumber, double secondNumber)
    {
        switch (operation)
        {
            case "+":
                return firstNumber + secondNumber;
            case "-":
                return firstNumber - secondNumber;
            case "*":
                return firstNumber * secondNumber;
            case "/":
                if (secondNumber == 0) throw new DivideByZeroException();
                return firstNumber / secondNumber;
            case "%":
                return firstNumber % secondNumber;
            case "^":
                return Math.Pow(firstNumber, secondNumber);
            default:
                throw new InvalidOperationException("Invalid operation");
        }
    }

    public double Sqrt(double number)
    {
        return Math.Sqrt(number);
    }

    public double Sin(double number)
    {
        return Math.Sin(number);
    }

    public double Cos(double number)
    {
        return Math.Cos(number);
    }

    public double Floor(double number)
    {
        return Math.Floor(number);
    }

    public double Ceil(double number)
    {
        return Math.Ceiling(number);
    }
}
