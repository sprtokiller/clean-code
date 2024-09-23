void EvaluateCondition(int a)
{
    if (a == 0)
    {
        Console.WriteLine("a is zero.");
        return;
    }

    if (a < 0)
    {
        Console.WriteLine("a is negative.");
        return;
    }

    string parity = a % 2 == 0 ? "even" : "odd";

    if (a < 10)
        Console.WriteLine($"a is positive, less than 10, and {parity}.");
    else
        Console.WriteLine($"a is positive, 10 or more, and {parity}.");
}