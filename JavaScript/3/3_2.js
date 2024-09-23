const Discount = 0.95; 
const MemDiscount = 0.9; //members discount

let finalPrice = basePrice * Discount; // Apply 5% discount
if (isMember) {
  finalPrice = basePrice * MemDiscount; // Members get 10% discount
}
console.log("Final price: $" + finalPrice);
