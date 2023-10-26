using SQLite;
using SQLiteDataAcessLibrary.Models;

namespace SQLiteDataAcessLibrary.Services;

public class BalanceService
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
            await _dbConnection.CreateTableAsync<BalanceModel>();
        }
    }

    public async Task<int> AddBalance(BalanceModel balance)
    {
        return await _dbConnection.InsertAsync(balance);
    }

    public async Task<int> DeleteBalance(BalanceModel balance)
    {
        return await _dbConnection.DeleteAsync(balance);
    }

    public async Task<Transaction> GetBalance(int BalanceId)
    {
        return await _dbConnection.Table<Transaction>().FirstOrDefaultAsync(x => x.Id == BalanceId);
    }

    public async Task<List<BalanceModel>> GetTransactions()
    {
        return await _dbConnection.Table<BalanceModel>().ToListAsync();
    }

    public async Task<int> UpdateTransaction(BalanceModel balance)
    { 
        return await _dbConnection.UpdateAsync(balance);
    }
}
