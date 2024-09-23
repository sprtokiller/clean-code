
const PRODUCT_NAME = "Widget"
const QUANTITY = 5

function updateInventory(product, quantity) {
  console.log(quantity + " units of " + product + " sold.");
  return inventory[product] - quantity
}
inventory[PRODUCT_NAME] = updateInventory("Widget", 5);
// idk