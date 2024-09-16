
Dictionary<string, int> inventory = new Dictionary<string, int>
{
    { "Widget", 10 }
};
// calculate the amount of products sold
void UpdateInventory(string product, int quantity)
{
    inventory[product] -= quantity;
    Console.WriteLine(quantity + " units of " + product + " sold.");
}

UpdateInventory("Widget", 5);
