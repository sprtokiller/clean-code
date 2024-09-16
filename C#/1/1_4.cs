using System;

class Program
{
    static void Main()
    {
        calculate(5);
    }


    static void calculate(double r)
    {
        double area = 3.14 * r * r;
        double circumference = 2 * 3.14 * r;
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Circumference: " + circumference);
    }
}
