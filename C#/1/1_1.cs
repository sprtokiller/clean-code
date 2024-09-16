using System;

class Program
{
    static void Main()
    {
        double a = 3;
        double b = 4;
        double c = PythagorC(x, y);
        Console.WriteLine("Computed value: " + r);
    }

    static double PythagorC(double a, double b)
    {
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine("The result is: " + c);
        return c;
    }
}
