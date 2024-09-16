void ProcessTransactions(List<Transaction> transactions)
{
    foreach (var transaction in transactions)
    {
        //For credit type, >1000 - get bonus
        if (transaction.Type == "credit")
        {
            if (transaction.Amount > 1000)
            {
                ApplyBonus(transaction);
            }
            else
            {
                ApplyStandardProcessing(transaction);
            }
        }
        //For debit type, >1000 - get bonus
        else if (transaction.Type == "debit")
        {
            if (transaction.Amount > 500)
            {
                RequireApproval(transaction);
            }
            else
            {
                DeductAmount(transaction);
            }
        }
        else //Error
        {
            Console.WriteLine("Unknown transaction type: " + transaction.Type);
        }
    }
}
