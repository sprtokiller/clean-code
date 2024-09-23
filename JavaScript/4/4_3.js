
let userSession = {
  isLoggedIn: true,
  token: "abc123"
};


function logout(currentSession) {
  const newSession = {
      isLoggedIn: false,
      token: null
  };
  console.log("User logged out.");
  return newSession;
}
userSession = logout(userSession); 