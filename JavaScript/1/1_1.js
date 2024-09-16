function CalculateTriangleHypotenuse(pendant1, pendant2) {
  return Math.sqrt(pendant1 * pendant1 + pendant2 * pendant2);
}

let testTrianglePendant1 = 3;
let testTrianglePendant2 = 4;
let testTriangleHypotenuse = CalculateTriangleHypotenuse(trianglePendant1, trianglePendant2);
console.log(`Computed triangle hypotenuse: ${triangleHypotenuse}`);
