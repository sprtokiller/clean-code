const everyoneDiscount = 0.95;
const membershipDiscount = 0.90;

let finalPrice = basePrice * everyoneDiscount; // Apply 5% discount
if (isMember) {
    finalPrice = basePrice * membershipDiscount; // Members get 10% discount
}
console.log("Final price: $" + finalPrice);
