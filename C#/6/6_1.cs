info(user.FirstName, user.LastName, user.Email, user.Role);

if (user.IsActive)
{
    info(user.FirstName, user.LastName, user.Email, user.Role);
}

void info(string firstName,string lastName, string email, string role)
{
    Console.WriteLine("Name: " + firstName + " " + lastName);
    Console.WriteLine("Email: " + email);
    Console.WriteLine("Role: " + role);
}