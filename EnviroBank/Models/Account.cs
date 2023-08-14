using System.ComponentModel.DataAnnotations;

namespace EnviroBank.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public long AccountNumber { get; set; }
        public long AccountHolder { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public string AccountStatus { get; set; }
        public decimal AvailableBalance { get; set; }


    }
}
