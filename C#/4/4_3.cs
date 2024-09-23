class UserSession
{
    public bool IsLoggedIn { get; set; } = true;
    public string Token { get; set; } = "abc123";
}

UserSession userSession = new UserSession();

UserSession Logout()
{
    return new UserSession
    {
        IsLoggedIn = false,
        Token = null
    };
}

UserSession = Logout();
