int totalScore = 0;

void AddScore(int points)
{
    totalScore += points;
    Console.WriteLine("Total score is now: " + totalScore);
}

AddScore(5);
AddScore(10);
