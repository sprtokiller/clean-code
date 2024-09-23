//Function with the values of the array
function logArrayValues(array) {
    for (let index = 0; index < array.length; index++) {
      console.log(`Value at index ${index}: ${array[index]}`);
    }
  }
  const numbers = [5, 10, 15, 20, 25];
  logArrayValues(numbers);
