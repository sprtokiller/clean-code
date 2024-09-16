// Check if the user is over 18 because our site content should not be available for user before 18
if (user.Age > 18)
{
    GrantAccess();
}
else
{
    DenyAccess();
}
