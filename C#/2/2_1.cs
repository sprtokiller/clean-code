using System;

class Program
{
    static void Main()
    {
        // calculating number of prpduct
        int product = Multiply(4, 5);
        Console.WriteLine("Product is: " + product);
    }

    // function for calculating the nubmer of product
    static int Multiply(int a, int b)
    {
        return a * b;
    }
}
