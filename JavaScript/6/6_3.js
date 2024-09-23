function createEmail(to, subject, body, customProperties = {}) {
  let email = {
    to: to,
    subject: subject,
    body: body,
    sentAt: new Date(),
    status: "sent",
    ...customProperties 
  };
  logEmail(email);
  return email;
}


let welcomeEmail = createEmail("newuser@example.com", "Welcome!", "Thank you for joining.", { isWelcomeEmail: true });


let passwordResetEmail = createEmail("user@example.com", "Reset Password", "Click here to reset your password.", { isPasswordReset: true });
