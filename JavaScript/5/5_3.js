function evaluateCondition(a) {
    if (a > 0) {
      var size = a < 10 ? "less than 10" : "10 or more";
      var parity = a % 2 === 0 ? "even" : "odd";
      console.log("a is positive, " + size + ", and " + parity + ".");
    } else if (a === 0) {
      console.log("a is zero.");
    } else {
      console.log("a is negative.");
    }
  }
  
  
