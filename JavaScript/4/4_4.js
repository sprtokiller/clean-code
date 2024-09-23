function updateInventory(product, quantity) {
  let inventoryAfterSale = inventory[product] -= quantity;
  console.log(inventoryAfterSale + " units of " + product + " sold.");
}

updateInventory("Widget", 5);