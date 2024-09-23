Dictionary<string, int> inventory = new Dictionary<string, int>
{
    { "Widget", 10 }
};

void UpdateInventory(string product, int quantity)
{
    return inventory[product] -= quantity;
}

inventory[product] = UpdateInventory("Widget", 5);
