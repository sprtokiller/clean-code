new function print() {
    Console.WriteLine("Name: " + user.FirstName + " " + user.LastName\n"Email: " + user.Email\n"Role: " + user.Role);
}
if (user.IsActive)
{
    print();
    Console.WriteLine("Status: Active");
}
