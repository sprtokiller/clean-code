using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 10, 15, 20, 25 };
        p(arr);
    }

    static void p(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Value at index " + i + ": " + a[i]);
        }
    }
}
