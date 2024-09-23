using System;

class Program
{
    static void Main()
    {
        int x = 3;
        int y = 4;
        int r = c(x, y);
        Console.WriteLine("Computed value: " + r);
    }

    static double priklad(double a, double b)
    {
        double vysledek = Math.Sqrt(a * a + b * b);
        Console.WriteLine("The result is: " + vysledek);
        return vysledek;
    }
}
