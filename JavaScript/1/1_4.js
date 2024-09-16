function calculateCircleProperties(radius) {
  const PI = 3.14;
  const area = PI * radius * radius;
  const circumference = 2 * PI * radius;
  
  console.log("Area: " + area);
  console.log("Circumference: " + circumference);
}

calculateCircleProperties(5);