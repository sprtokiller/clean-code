static void weight (string value, string weight)
{
    double sum = 0;

    for (int i = 0; i < value.Length; i++)
    {
        int addValue = value[i];
        for (int j = 0; j < weight.Length; j++)
        {
            int addWeight = weight[j];
            sum += addValue * addWeight;
        }
    }

    Console.WriteLine("Weighted sum: " + sum);
}
