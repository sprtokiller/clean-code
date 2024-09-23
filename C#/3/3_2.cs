double normalFinalPrice = basePrice * 0.95; // Apply 5% discount
double memberFinalPrice = basePrice* 0.90; // Members get 10% discount

if (isMember)
{
    Console.WriteLine("Final price: $" + memberFinalPrice);
} else {
    Console.WriteLine("Final price: $" + normalFinalPrice);
    }
