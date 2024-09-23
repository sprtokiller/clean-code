//Checks if user is over the age of 18, if not access is denied
if (user.age > 18) {
  grantAccess();
} else {
  denyAccess();
}
 