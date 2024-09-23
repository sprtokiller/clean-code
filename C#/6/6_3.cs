using System;

void SendEmail(string to, string subject, string body)
{
    Email email = new Email
    {
        To = to,
        Subject = subject,
        Body = body,
        SentAt = DateTime.Now,
        Status = "sent"
    };
    LogEmail(email);
}

for (int i = 0; i < 2; i++)
{
    Email welcomeEmail = new Email();
    SendEmail("newuser@example.com", "Welcome!", "Thank you for joining.");
    welcomeEmail.IsWelcomeEmail = true;
    LogEmail(welcomeEmail);
}
