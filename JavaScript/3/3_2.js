const REGULAR_DISCOUNT_RATE = 0.95; // 5% discount for non-members
const MEMBER_DISCOUNT_RATE = 0.90;  // 10% discount for members
let finalPrice = basePrice * REGULAR_DISCOUNT_RATE; 
if (isMember) {
    finalPrice = basePrice * MEMBER_DISCOUNT_RATE; 
}
console.log("Final price: $" + finalPrice);
