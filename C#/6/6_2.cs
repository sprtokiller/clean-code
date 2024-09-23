void ProcessGrade(int grade)
{
    if (grade >= 90)
        HandleGrade("A", true);
    else if (grade >= 80)
        HandleGrade("B", true);
    else if (grade >= 70)
        HandleGrade("C", false);
    else if (grade >= 60)
        HandleGrade("D", false);
    else
        HandleGrade("F", false);
}

void HandleGrade(string gradeLetter, bool shouldCongratulate)
{
    Console.WriteLine("Grade: " + gradeLetter);

    if (shouldCongratulate)
    {
        CongratulateStudent();
    }

    UpdateRecords();
}