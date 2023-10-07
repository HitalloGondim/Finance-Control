using SQLiteDataAcessLibrary.Models;

namespace SQLiteDataAcessLibrary.Services;

public interface ITransactionService
{
    Task InitializeAsync();

    Task<List<Transaction>> GetTransactions();

    Task<Transaction> GetTransaction(int transactionId);

    Task<Transaction> GetTransactionByDescription(string transactionDescription);

    Task<int> AddTransaction(Transaction transaction);

    Task<int> UpdateTransaction(Transaction transaction);

    Task<int> DeleteTransaction(Transaction transaction);
}
