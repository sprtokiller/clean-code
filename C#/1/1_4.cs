using System;

class Program
{
    static void Main()
    {
        size(5);
    }

    static void size(double r)
    {
        double areaOfACircle = 3.14 * r * r;
        double circumferenceOfACircle = 2 * 3.14 * r;
        Console.WriteLine("Area: " + areaOfACircle);
        Console.WriteLine("Circumference: " + circumferenceOfACircle);
    }
}
