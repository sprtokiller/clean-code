void ProcessTransactions(List<Transaction> transactions)
{
    foreach (var transaction in transactions)
    {
        if (transaction.Type == "credit")
        {
            CreditPaymant();
        }
        else if (transaction.Type == "debit")
        {
            DebitPaymant();
        }
        else
        {
            Console.WriteLine("Unknown transaction type: " + transaction.Type);
        }
    }
}
void DebitPaymant()
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
void CreditPaymant()
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
