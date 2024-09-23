function MathEquation(a, b) {
  let equation = Math.sqrt(a * a + b * b);
  console.log("The result is: " + equation);
  return equation;
}

let x = 3;
let y = 4;
let result = MathEquation(x, y);
console.log("Computed value: " + result);
