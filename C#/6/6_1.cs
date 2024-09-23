for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Name: " + user.FirstName + " " + user.LastName);
    Console.WriteLine("Email: " + user.Email);
    Console.WriteLine("Role: " + user.Role);

}

if (user.IsActive)
{
    Console.WriteLine("Name: " + user.FirstName + " " + user.LastName);
    Console.WriteLine("Email: " + user.Email);
    Console.WriteLine("Status: Active");
}
