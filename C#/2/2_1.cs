using System;

class Program
{

    static void Main()
    {
        
        int product = Multiply(4, 5);
        Console.WriteLine("Product is: " + product);
    }

    // This method multiplies two numbers
    static int Multiply(int a, int b)
    {
        return a * b;
    }
}
