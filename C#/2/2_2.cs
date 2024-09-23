// Check if the user is over 18
if (user.Age > 18)
{
    GrantAccess();
}
else
{
    // User is under 18, deny access
    DenyAccess();
}
