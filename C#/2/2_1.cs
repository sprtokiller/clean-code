using System;



class Program
{
    /* 
     * File 2_1.cs
     * @author 
     *
     *
     *Utility function for  multiplication and printed
     */
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
