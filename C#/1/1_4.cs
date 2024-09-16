using System;

class Program
{
    static void Main()
    {
        CircleCalc(5);
    }

    static void CircleCalc(double r)
    {
        double AreaCalc = 3.14 * r * r;
        double CircumferenceCalc = 2 * 3.14 * r;
        Console.WriteLine("Area: " + AreaCalc);
        Console.WriteLine("Circumference: " + CircumferenceCalc);
    }
}
