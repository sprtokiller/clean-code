public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public bool IsActive { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        User user = new User
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            Role = "Admin",
            IsActive = true
        };

        PrintUserInfo(user);

        if (user.IsActive)
        {
            PrintUserStatus(user);
        }
    }

    static void PrintUserInfo(User user)
    {
        Console.WriteLine("Name: " + user.FirstName + " " + user.LastName);
        Console.WriteLine("Email: " + user.Email);
        Console.WriteLine("Role: " + user.Role);
    }

    static void PrintUserStatus(User user)
    {
        Console.WriteLine("Status: Active");
    }
}