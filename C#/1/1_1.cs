using System;

class Program
{
    static void Main()
    {
        double a = 3;
        double b = 4;
        double c = c(a, b);
        Console.WriteLine("Computed value: " + c);
    }

    static double pythagorasSentence(double a, double b)
    {
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine("The result is: " + c);
        return c;
    }
}
