function calculateWeightedSum(values, weights) {
    let sum = 0;
  
    for (let i = 0; i < values.length; i++) {
      sum += values[i] * weights[i];
    }
  
    return sum;
  }
  
  
  let sum = calculateWeightedSum(values, weights);
  console.log("Weighted sum: " + sum);
  