using System;

class Program
{
    static void Main()
    {
        s(5);
    }

    static void s(double r)
    {
        double a = 3.14 * r * r;
        double c = 2 * 3.14 * r;
        Console.WriteLine("Area: " + a);
        Console.WriteLine("Circumference: " + c);
    }
}
