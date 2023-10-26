using SQLite;
using SQLiteDataAcessLibrary.Models;

namespace SQLiteDataAcessLibrary.Services;

public class TransactionService
{

    private SQLiteAsyncConnection _dbConnection;

    public async Task InitializeAsync()
    {
        await SetUpDb();
    }

    private async Task SetUpDb()
    {
        if (_dbConnection == null)
        {
            string dbPath = Path.Combine(Environment.
                GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Finance.db3");

            _dbConnection = new SQLiteAsyncConnection(dbPath);
            await _dbConnection.CreateTableAsync<Transaction>();
        }
    }

    public async Task<int> AddTransaction(Transaction transaction)
    {
        return await _dbConnection.InsertAsync(transaction);
    }

    public async Task<int> DeleteTransaction(Transaction transaction)
    {
        return await _dbConnection.DeleteAsync(transaction);
    }

    public async Task<Transaction> GetTransaction(int transactionId)
    {
        return await _dbConnection.Table<Transaction>().FirstOrDefaultAsync(x => x.Id == transactionId);
    }

    public async Task<Transaction> GetTransactionByDescription(string transactionDesctiption)
    {
        return await _dbConnection.Table<Transaction>().Where(x => x.Description == transactionDesctiption).FirstOrDefaultAsync();
    }

    public async Task<List<Transaction>> GetTransactions()
    {
        return await _dbConnection.Table<Transaction>().ToListAsync();
    }

    public async Task<int> UpdateTransaction(Transaction transaction)
    {
        return await _dbConnection.UpdateAsync(transaction);
    }
}
