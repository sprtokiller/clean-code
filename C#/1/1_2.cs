using System;

class Program
{
    static void Main()
    {
        int[] arrNumber = { 5, 10, 15, 20, 25 };
        printed(arrNumber);
    }

    static void printed(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Value at index " + i + ": " + a[i]);
        }
    }
}
