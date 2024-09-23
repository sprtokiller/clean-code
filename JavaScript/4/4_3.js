let userSession = {
  isLoggedIn,
  token
};

function login() {
  userSession.isLoggedIn = true;
  userSession.token = "abc123"
  console.log("User logged in.");
}

function logout() {
  userSession.isLoggedIn = false;
  userSession.token = null;
  console.log("User logged out.");
}

login();
logout();
