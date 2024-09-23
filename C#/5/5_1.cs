void AnalyzeData(List<int> data)
{
    if (data != null && data.Count > 0)
    {
        int total = 0;
        foreach (int value in data)
        {
            CalculateValue(total, value);
        } 
    }
    else
    {
        Console.WriteLine("Data is empty or undefined.");
    }
    Console.WriteLine("Final total: " + total);
}

int CalculateValue (int total,int value)
    {
        if (value > 0)
        {
            if (value % 2 == 0)
            {
                total += value;
            }
            else
            {
                total -= value;
            }
        }
        else
        {
            Console.WriteLine("Non-positive value encountered: " + value);
        }
    }
    
