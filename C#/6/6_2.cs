if (grade >= 90)
{
    Console.WriteLine("Grade: A");
    CongratulateStudent();
}
else if (grade >= 80)
{
    Console.WriteLine("Grade: B");
    CongratulateStudent();
}
else if (grade >= 70)
{
    Console.WriteLine("Grade: C");
}
else if (grade >= 60)
{
    Console.WriteLine("Grade: D");
}
else
{
    Console.WriteLine("Grade: F");
}
UpdateRecords();