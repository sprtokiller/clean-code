int MAX_ATTEMPTS = 3;
int ATTEMPT = 0;
while (ATTEMPT < MAX_ATTEMPTS)
{
    if (TryConnect())
    {
        Console.WriteLine("Connected successfully.");
        break;
    }
    else
    {
        Console.WriteLine("Retrying connection...");
        ATTEMPT++;
    }
}

if (ATTEMPT == MAX_ATTEMPTS)
{
    Console.WriteLine("Failed to connect after 3 attempts.");
}
