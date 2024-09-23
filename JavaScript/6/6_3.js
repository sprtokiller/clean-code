function sendEmail(to, subject, body) {
  let email = {
    to,
    subject,
    body,
    sentAt: new Date(),
    status: "sent",
  };
  logEmail(email);
  return email;
}

// Send a welcome email with an additional property
let welcomeEmail = sendEmail(
  "newuser@example.com",
  "Welcome!",
  "Thank you for joining.",
  { isWelcomeEmail: true }
);

// Send a password reset email with an additional property
let passwordResetEmail = sendEmail(
  "user@example.com",
  "Reset Password",
  "Click here to reset your password.",
  { isPasswordReset: true }
);
