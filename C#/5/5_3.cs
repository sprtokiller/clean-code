void EvaluateCondition(int a)
{
    if (a > 0)
    {
        if (a < 10)
        {
            mod2(a, "a is positive, less than 10, and even.", "a is positive, less than 10, and odd.");
        }
        else
        {
            mod2(a, "a is positive, 10 or more, and even.", "a is positive, 10 or more, and odd.");
        }
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

void mod2 (int value,string message1, string message2)
{
    if (value % 2 == 0)
    {
        Console.WriteLine(message1);
    }
    else
    {
        Console.WriteLine(message2);
    }
}
