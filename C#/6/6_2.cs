static void grading (int grade)
{
    switch (grade)
    {
        case grade >= 90:
            Console.WriteLine("Grade: A");
            break;
        case grade >= 80:
            Console.WriteLine("Grade: B");
            break;
        case grade >= 70:
            Console.WriteLine("Grade: C");
            break;
        case grade >= 60:
            Console.WriteLine("Grade: ");
            break;
    }

    if (grade >= 80)
    {
        CongratulateStudent();
    }

    UpdateRecords();
}
