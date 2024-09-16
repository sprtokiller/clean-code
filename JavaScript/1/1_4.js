function CalculateCircleArea(radius) {
  return 3.14 * radius * radius;
}

function CalculateCircleCircumference(radius) {
  return 2 * 3.14 * radius;
}

let testCircle = {radius: 5, area: undefined, circumference: undefined}
circle.circumference = CalculateCircleCircumference(circle.radius);
circle.area = CalculateCircleArea(circle.radius);

console.log(`Calculated circle area: ${circle.area}`);
console.log(`Calculated circle area: ${circle.circumference}`);
