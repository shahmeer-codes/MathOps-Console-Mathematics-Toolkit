using System;

namespace MathOps;

public static class MathOperations
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        return a / b;
    }

    public static double SquareRoot(double number)
    {
        return Math.Sqrt(number);
    }

    public static double Minimum(double a, double b)
    {
        return Math.Min(a, b);
    }

    public static double Maximum(double a, double b)
    {
        return Math.Max(a, b);
    }

    public static double Power(double number, double exponent)
    {
        return Math.Pow(number, exponent);
    }

    public static double Absolute(double number)
    {
        return Math.Abs(number);
    }

    public static double Remainder(double a, double b)
    {
        return a % b;
    }

    public static double Round(double number, int decimals)
    {
        return Math.Round(number, decimals);
    }

    public static double Ceiling(double number)
    {
        return Math.Ceiling(number);
    }

    public static double Floor(double number)
    {
        return Math.Floor(number);
    }

    public static double Sine(double degrees)
    {
        double radians = degrees * Math.PI / 180;
        return Math.Sin(radians);
    }

    public static double Cosine(double degrees)
    {
        double radians = degrees * Math.PI / 180;
        return Math.Cos(radians);
    }

    public static double Tangent(double degrees)
    {
        double radians = degrees * Math.PI / 180;
        return Math.Tan(radians);
    }

    public static double NaturalLog(double number)
    {
        return Math.Log(number);
    }

    public static double Log10(double number)
    {
        return Math.Log10(number);
    }
}
