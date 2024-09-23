printUser(user);

printUser(user);

if (user.isActive) {
    printUser(user);
}

function printUser(user) {
    console.log("Name: " + user.firstName + " " + user.lastName);
    console.log("Email: " + user.email);
    console.log("Role: " + user.role);
    console.log("Status: " + user.isActive);
}
