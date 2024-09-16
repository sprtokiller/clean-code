using System;

class Program
{
    static void Main()
    {
        double x = 3;
        double y = 4;
        double r = c(x, y);
        Console.WriteLine("Computed value: " + r);
    }

    static double c(double a, double b)
    {
        double d = Math.Sqrt(a * a + b * b);
        Console.WriteLine("The result is: " + d);
        return d;
    }
}
