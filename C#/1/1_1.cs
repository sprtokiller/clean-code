using System;

class Program
{
    static void Main()
    {
        double sizeA = 3;
        double sizeB = 4;
        double hipotums = pythagoreanTheorem(sizeA, sizeB);
        Console.WriteLine("Computed value: " + hipotums);
    }

    static double pythagoreanTheorem(double a, double b)
    {
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine("The result is: " + c);
        return c;
    }
}
