using System;

class Program
{
    static void Main()
    {
        // This function multiplies two numbers to get the final product number
        int product = Multiply(4, 5);
        Console.WriteLine("Product is: " + product);
    }

    // This function multiplies two numbers and is created to shorten the code 
    static int Multiply(int a, int b)
    {
        return a * b;
    }
}
