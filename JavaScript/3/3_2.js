const BASEPRICE = 10
const DISCOUNT = 0.95
const MEMBERDISCOUNT = 0.9

let finalPrice = BASEPRICE * DISCOUNT; // Apply 5% discount
if (isMember) {
    finalPrice = BASEPRICE * MEMBERDISCOUNT; // Members get 10% discount
}
console.log("Final price: $" + finalPrice);
