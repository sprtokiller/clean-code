using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 10, 15, 20, 25 };
        IndexValues(arr);
    }

    static void IndexValues(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Value at index " + i + ": " + a[i]);
        }
    }
}
