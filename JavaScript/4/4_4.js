function updateInventory(product, quantity) {
  inventory[product] -= quantity;
}
function printInventory(product) {
  console.log(inventory[product] + " units of " + product + " sold.");
}

updateInventory("Widget", 5);
printInventory("Widget");
