let BASEPRICE = 10;
let finalPrice = BASEPRICE * 0.95; // Apply 5% discount

if (isMember) {
    finalPrice = BASEPRICE * 0.90; // Members get 10% discount
}
console.log("Final price: $" + finalPrice);
