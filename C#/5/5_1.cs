void AnalyzeData(List<int> data)
{
    if (data == null || data.Count == 0)
    {
        Console.WriteLine("Data is empty or undefined.");
        return;
    }

    int total = 0;
    foreach (int value in data)
    {
        if (value <= 0)
        {
            Console.WriteLine($"Non-positive value encountered: {value}");
            continue;
        }

        total += value % 2 == 0 ? value : -value;
    }
    
    Console.WriteLine($"Final total: {total}");
}
