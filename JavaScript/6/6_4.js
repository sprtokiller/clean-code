let sum = 0;
for (let i = 0; i < 6; i++) {
    sum += values[i] * weights[i];
}

console.log("Weighted sum: " + sum);
