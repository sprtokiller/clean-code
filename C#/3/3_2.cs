const double NON_MEMBER_DISCOUNT = 0.95; // 5% discount for non-members
const double MEMBER_DISCOUNT = 0.90;    // 10% discount for members

double finalPrice = basePrice * NON_MEMBER_DISCOUNT;
if (isMember)
{
    finalPrice = basePrice * MEMBER_DISCOUNT;
}

Console.WriteLine("Final price: $" + finalPrice);