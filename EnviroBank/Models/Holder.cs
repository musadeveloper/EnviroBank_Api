using System.ComponentModel.DataAnnotations;

namespace EnviroBank.Models
{
    public class Holder
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string IdNumber { get; set; }
        public string ResidentialAddress { get; set; }
        public int MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }



    }
}
