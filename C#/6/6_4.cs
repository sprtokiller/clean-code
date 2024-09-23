double sum = 0;

for (int i = 0; i < values.Length; i++)
{
    sum += values[i] * weights[i];
}

Console.WriteLine("Weighted sum: " + sum);