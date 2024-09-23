using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 10, 15, 20, 25 };
        valueP(arr);
    }

    static void valueP(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Value at index " + i + ": " + a[i]);
        }
    }
}
