void EvaluateCondition(int a)
{
    if (a > 0)
    {
        EvaluatePositive(a);
    }
    else if (a == 0)
    {
        Console.WriteLine("a is zero.");
    }
    else
    {
        Console.WriteLine("a is negative.");
    }
}

void EvaluatePositive(int a)
{
    string range = a < 10 ? "less than 10" : "10 or more";
    string parity = a % 2 == 0 ? "even" : "odd";
    
    Console.WriteLine($"a is positive, {range}, and {parity}.");
}
