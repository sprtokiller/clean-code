using System;

class Program
{
    static void Main()
    {
        int x = 3;
        int y = 4;
        int c = 5;
        int r = c * (x + y);
        Console.WriteLine("Computed value: " + r);
    }

    static double c(double a, double b)
    {
        double d = Math.Sqrt(a * a + b * b);
        Console.WriteLine("The result is: " + d);
        return d;
    }
}
