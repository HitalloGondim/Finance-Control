 using SQLite;

namespace SQLiteDataAcessLibrary.Models
{
    [Table("Contatos")]
    public class Transaction
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
        [NotNull, MaxLength(200)]
        public string? Description { get; set; }

        [MaxLength(100)]
        public string? Category { get; set; }

        [NotNull]
        public Decimal Balance { get; set; }

        [NotNull]
        public DateTime Date { get; set; }

    }
}
