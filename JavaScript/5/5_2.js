function processCredit(transaction) {
    if (transaction.amount > 1000) {
      applyBonus(transaction);
    } else {
      applyStandardProcessing(transaction);
    }
  }
 
  function processDebit(transaction) {
    if (transaction.amount > 500) {
      requireApproval(transaction);
    } else {
      deductAmount(transaction);
    }
  }
 
  function UnknownTransaction(transaction) {
    console.log("Unknown transaction type: " + transaction.type);
  }
 
  function processTransactions(transactions) {
    for (let i = 0; i < transactions.length; i++) {
      let transaction = transactions[i];
     
      if (transaction.type === "credit") {
        processCredit(transaction);
      } else if (transaction.type === "debit") {
        processDebit(transaction);  
      } else {
        handleUnknownTransaction(transaction);
      }
    }
  }