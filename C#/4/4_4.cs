 Dictionary<string, int> inventory = new Dictionary<string, int>
{
    { "Widget", 10 }
};

void UpdateInventory(string product, int quantity)
{
    product -= quantity;
    Console.WriteLine(quantity + " units of " + product + " sold.");
}

UpdateInventory(inventory["Widget"], 5);
