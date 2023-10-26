using SQLite;

namespace SQLiteDataAcessLibrary.Models;

[Table("Balances")]
public class BalanceModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [NotNull]
    public Decimal Balance { get; set; }

    [NotNull]
    public DateTime BalanceDate { get; set;}
}
