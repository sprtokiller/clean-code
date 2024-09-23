function evaluateCondition(a) {
  if (a > 0) {
    if (a < 10) {
      if (a % 2 === 0) {
        console.log("a is even.");
      } else {
        console.log("a is odd.");
      }
      console.log("a is less than 10.");
    } else {
      if (a % 2 === 0) {
        console.log("a is even.");
      } else {
        console.log("a is odd.");
      }
      console.log("a is 10 or more.");
    }
    console.log("a is positive.");
  } else {
    console.log("a is negative or zero.");
  }
}
