double sum = 0;
int num = 0;
for (int i = 0; i < 6; i++)
{
    sum += values[num] * weights[num];
    num++;
}   

Console.WriteLine("Weighted sum: " + sum);
