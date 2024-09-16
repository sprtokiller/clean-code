int totalScore = 0;
//Calculate score by points
void AddScore(int points)
{
    totalScore += points;
    Console.WriteLine("Total score is now: " + totalScore);
}
//Try adding scores
AddScore(10);
AddScore(20);
