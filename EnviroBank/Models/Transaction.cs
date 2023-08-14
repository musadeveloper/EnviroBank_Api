using System.ComponentModel.DataAnnotations;

namespace EnviroBank.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}