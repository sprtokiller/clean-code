function CalcCircumference(num1, num2) {
  let result = Math.sqrt(num1 * num1 + num2 * num2);
  console.log("The result is: " + result);
  return result;
}
 
let x = 3;
let y = 4;
let r = CalcCircumference(x, y);
console.log("Computed value: " + r);