function PythagorasSentece(a, b) {
  let result = Math.sqrt(a * a + b * b);
  console.log("The result is: " + result);
  return result;
}

let a = 3;
let b = 4;
let result = PythagorasSentece(a, b);
console.log("Computed value: " + result);
