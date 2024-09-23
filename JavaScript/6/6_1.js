function logUserInfo(user) {
    console.log("Name: " + user.firstName + " " + user.lastName);
    console.log("Email: " + user.email);
    console.log("Role: " + user.role);
}

logUserInfo(user);

if (user.isActive) {
    logUserInfo(user);
    console.log("Status: Active");
}
