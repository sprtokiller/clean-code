let arr = [5, 10, 15, 20, 25];
function listArray(selArr) {
    for (let i = 0; i < selArr.length; i++) {
        console.log("Value at index " + i + ": " + selArr[i]); // vypisuje pořadí dokud nedojde na konec
    }
}
listArray(arr);
