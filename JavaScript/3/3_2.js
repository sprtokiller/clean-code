let discountMember = 0.90
let discountNonMember =  0.95
let finalPrice = basePrice * discountNonMember; // Apply 5% discount
if (isMember) {
    finalPrice = basePrice * discountMember; // Members get 10% discount
}
console.log("Final price: $" + finalPrice);
