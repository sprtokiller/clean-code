using System;

class Program
{
    static void Main()
    {
        int[] multiplesOfFive = { 5, 10, 15, 20, 25 };
        getIndexValue(multiplesOfFive);
    }

    static void getIndexValue(int[] userArray)
    {
        for (int i = 0; i < userArray.Length; i++)
        {
            Console.WriteLine("Value at index " + i + ": " + userArray[i]);
        }
    }
}
