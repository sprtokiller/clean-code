function TypeOutUserInfo(user) {
    console.log("Name: " + user.firstName + " " + user.lastName);
    console.log("Email: " + user.email);
    console.log("Role: " + user.role);
};

TypeOutUserInfo(user);

if (user.isActive) {
    console.log("Name: " + user.firstName + " " + user.lastName);
    console.log("Email: " + user.email);
    console.log("Status: Active");
}
