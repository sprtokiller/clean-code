 Dictionary<string, int> inventory = new Dictionary<string, int>
{
    { "Widget", 10 }
};

int UpdateInventory(string product, int quantity)
{
    product -= quantity;

    return product - quantity;
}

UpdateInventory(inventory["Widget"], 5);
Console.WriteLine(quantity + " units of " + product + " sold.");