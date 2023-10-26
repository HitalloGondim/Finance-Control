 using SQLite;

namespace SQLiteDataAcessLibrary.Models;

[Table("Transacations")]
public class Transaction
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    
    [NotNull, MaxLength(200)]
    public string? Description { get; set; }

    [MaxLength(100)]
    public string? Category { get; set; }

    [NotNull]
    public Decimal Value { get; set; }

    [NotNull]
    public DateTime Date { get; set; }

}
