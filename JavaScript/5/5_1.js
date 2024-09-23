function isValidData(data) {
    return data && data.length > 0;
  }
 
  function processValue(value, total) {
    if (value > 0) {
      if (value % 2 === 0) {
        return total + value;  
      } else {
        return total - value;  
      }
    } else {
      console.log("Non-positive value encountered: " + value);
      return total;
    }
  }
 
  function analyzeData(data) {
    if (!isValidData(data)) {
      console.error("Data is empty or undefined.");
      return;
    }
 
    let total = 0;
    for (let i = 0; i < data.length; i++) {
      total = processValue(data[i], total);  
    }
 
    console.log("Final total: " + total);
  }