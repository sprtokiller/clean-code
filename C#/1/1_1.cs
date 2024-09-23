using System;

class Program
{
    static void Main()
    {
        double x = 3;
        double y = 4;
        double sqrtPoweronTwoResult = getSqrtOfPowerOn2(x, y);
        Console.WriteLine("Computed value: " + sqrtPoweronTwoResult);
    }

    static double getSqrtOfPowerOn2(double a, double b)
    {
        double sqrtResult = Math.Sqrt(a * a + b * b);
        Console.WriteLine("The result is: " + sqrtResult);
        return sqrtResult;
    }
}
