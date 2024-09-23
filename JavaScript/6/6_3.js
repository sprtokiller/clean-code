function createEmail(to, subject, body, type) {
  let email = {
    to: to,
    subject: subject,
    body: body,
    sentAt: new Date(),
    status: "sent"
  };

  if (type === "welcome") {
    email.isWelcomeEmail = true;
  } else if (type === "passwordReset") {
    email.isPasswordReset = true;
  }

  logEmail(email);
  return email;
}

