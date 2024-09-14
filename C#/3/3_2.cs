double finalPrice = basePrice * 0.95; // Apply 5% discount
if (isMember)
{
    finalPrice = basePrice * 0.90; // Members get 10% discount
}
Console.WriteLine("Final price: $" + finalPrice);
