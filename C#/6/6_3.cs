sing System;

public class Email
{
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public DateTime SentAt { get; set; }
    public string Status { get; set; }
    public bool IsWelcomeEmail { get; set; }
    public bool IsPasswordReset { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        SendWelcomeEmail("newuser@example.com");
        SendPasswordResetEmail("user@example.com");
    }

    static void SendEmail(Email email)
    {
        email.SentAt = DateTime.Now;
        email.Status = "sent";
        LogEmail(email);
    }

    static void SendWelcomeEmail(string to)
    {
        Email welcomeEmail = new Email
        {
            To = to,
            Subject = "Welcome!",
            Body = "Thank you for joining.",
            IsWelcomeEmail = true
        };
        SendEmail(welcomeEmail);
    }

    static void SendPasswordResetEmail(string to)
    {
        Email passwordResetEmail = new Email
        {
            To = to,
            Subject = "Reset Password",
            Body = "Click here to reset your password.",
            IsPasswordReset = true
        };
        SendEmail(passwordResetEmail);
    }

    static void LogEmail(Email email)
    {
        Console.WriteLine($"Email to {email.To} logged. Subject: {email.Subject}, Status: {email.Status}");
    }
}