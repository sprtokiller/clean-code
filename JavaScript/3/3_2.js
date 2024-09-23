
const DISCOUNT = 0.95;    // 5% sale
const MEMBER_DISCOUNT = 0.90;  // 10% sale for member

let finalPrice = basePrice * DISCOUNT; 
if (isMember) {
    finalPrice = basePrice * MEMBER_DISCOUNT; //
}

console.log("Final price: $" + finalPrice);
