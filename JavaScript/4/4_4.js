function updateInventory(product, quantity) {
  console.log(quantity + " units of " + product + " sold.");
  return inventory[product] = quantity
}

const ProductName = "Widget"
inventory[product] = updateInventory(ProductName, 5);
