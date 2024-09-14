int maxRetries = 3;
int attempt = 0;
while (attempt < maxRetries)
{
    if (TryConnect())
    {
        Console.WriteLine("Connected successfully.");
        break;
    }
    else
    {
        Console.WriteLine("Retrying connection...");
        attempt++;
    }
}

if (attempt == maxRetries)
{
    Console.WriteLine("Failed to connect after 3 attempts.");
}
