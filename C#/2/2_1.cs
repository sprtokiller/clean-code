using System;

class Program
{
    // Funkce pro výpočet produktu
    static void Main()
    {
        int product = Multiply(4, 5);
        Console.WriteLine("Product is: " + product);
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
}
