const userSession = {
  isLoggedIn: true,
  token: "abc123"
};
//Fucntion will log out the user by updating the session state.
function logout() {
  userSession.isLoggedIn = false;
  userSession.token = null;
  console.log("User logged out.");
}

logout();
