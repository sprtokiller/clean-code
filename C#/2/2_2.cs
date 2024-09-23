// Checking age for sections accesses
if (user.Age > 18)
{
    // Access for all sections
    GrantAccess();
}
else
{
    // Access for only kid section
    DenyAccess();
}
