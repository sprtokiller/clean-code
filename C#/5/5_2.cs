void ProcessTransactions(List<Transaction> transactions)
{
    foreach (var transaction in transactions)
    {
        switch (transaction.Type)
        {
            case "credit":
                if (transaction.Amount > 1000)
                    ApplyBonus(transaction);
                else
                    ApplyStandardProcessing(transaction);
                break;

            case "debit":
                if (transaction.Amount > 500)
                    RequireApproval(transaction);
                else
                    DeductAmount(transaction);
                break;

            default:
                Console.WriteLine($"Unknown transaction type: {transaction.Type}");
                break;
        }
    }
}