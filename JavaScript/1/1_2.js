function WriteAllArrayIndexes(arr) {
	for (let i = 0; i < arr.length; i++) {
		console.log(`Value at index ${i}: ${arr[i]}`);
	}
}

let testArray = [5, 10, 15, 20, 25];
WriteAllArrayIndexes(testArray);
