function displayUserInfo(user, status = null) {
    console.log("Name: " + user.firstName + " " + user.lastName);
    console.log("Email: " + user.email);
    console.log("Role: " + user.role);
    
    if (status) {
      console.log("Status: " + status);
    }
  }
  

  displayUserInfo(user);
  displayUserInfo(user);
  
  if (user.isActive) {
    displayUserInfo(user, "Active");
  }
  