public class Program
{
    static void Main(string[] args)
    {
        int grade = 85;

        string gradeLetter = GetGradeLetter(grade);
        Console.WriteLine("Grade: " + gradeLetter);

        if (grade >= 80)
        {
            CongratulateStudent();
        }

        UpdateRecords();
    }

    static string GetGradeLetter(int grade)
    {
        if (grade >= 90) return "A";
        else if (grade >= 80) return "B";
        else if (grade >= 70) return "C";
        else if (grade >= 60) return "D";
        else return "F";
    }

    static void CongratulateStudent()
    {
        Console.WriteLine("Congratulations!");
    }

    static void UpdateRecords()
    {
        Console.WriteLine("Records updated.");
    }
}