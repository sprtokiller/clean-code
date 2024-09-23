int maxRetries = 3;
int attempt = 0;
string Connect = "Connected successfully.";
string RetryConnect = "Retrying connection...";
string FailedConnect = "Failed to connect after 3 attempts.";

while (attempt < maxRetries)
{
    if (TryConnect())
    {
        Console.WriteLine(Connect);
        break;
    }
    else
    {
        Console.WriteLine(RetryConnect);
        attempt++;
    }
}

if (attempt == maxRetries)
{
    Console.WriteLine(FailedConnect);
}
