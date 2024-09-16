using System;

class Program
{
    static void Main()
    {
        double x = 3;
        double y = 4;
        double r = calculation(x, y);
        Console.WriteLine("Computed value: " + r);
    }

    static double calculation(double a, double b)
    {
        double resultD = Math.Sqrt(a * a + b * b);
        Console.WriteLine("The result is: " + resultD);
        return resultD;
    }
}
