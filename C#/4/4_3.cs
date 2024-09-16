//Initiate for the Session
class UserSession
{
    public bool IsLoggedIn { get; set; } = true;
    public string Token { get; set; } = "abc123";
}

UserSession userSession = new UserSession();

//Reset and logout
void Logout()
{
    userSession.IsLoggedIn = false;
    userSession.Token = null;
    Console.WriteLine("User logged out.");
}

Logout();
