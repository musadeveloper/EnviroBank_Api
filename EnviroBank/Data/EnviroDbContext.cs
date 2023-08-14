using EnviroBank.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EnviroBank.Data
{
    public class EnviroDbContext : DbContext
    {

        public EnviroDbContext(DbContextOptions<EnviroDbContext> options) : base(options)
        {
        }

        public DbSet<Holder> Holders { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Holder>().HasData(
                new Holder
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    DOB = new DateTime(1990, 1, 15),
                    IdNumber = "971234567890",
                    ResidentialAddress = "123 Main Street",
                    MobileNumber = 791234569,
                    EmailAddress = "john@gmail.com",
                    Password = "password1"
                },
                new Holder
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    DOB = new DateTime(1985, 5, 20),
                    IdNumber = "979876543210",
                    ResidentialAddress = "456 Elm Street",
                    MobileNumber = 791234569,
                    EmailAddress = "jane@gmail.com",
                    Password = "password2"
                },
                new Holder
                {
                    Id = 3,
                    FirstName = "Michael",
                    LastName = "Johnson",
                    DOB = new DateTime(1978, 8, 10),
                    IdNumber = "974567890123",
                    ResidentialAddress = "789 Oak Street",
                    MobileNumber = 791234569,
                    EmailAddress = "michael@gmail.com",
                    Password = "password3"
                }, new Holder
                {
                    Id = 4,
                    FirstName = "Sarah",
                    LastName = "Williams",
                    DOB = new DateTime(1992, 3, 25),
                    IdNumber = "975678901234",
                    ResidentialAddress = "567 Pine Street",
                    MobileNumber = 791234569,
                    EmailAddress = "sarah@gmail.com",
                    Password = "password4"
                },
                new Holder
                {
                    Id = 5,
                    FirstName = "David",
                    LastName = "Miller",
                    DOB = new DateTime(1983, 9, 8),
                    IdNumber = "972345678901",
                    ResidentialAddress = "890 Birch Street",
                    MobileNumber = 791234569,
                    EmailAddress = "david@gmail.com",
                    Password = "password5"
                },
                new Holder
                {
                    Id = 6,
                    FirstName = "Jennifer",
                    LastName = "Brown",
                    DOB = new DateTime(1995, 12, 18),
                    IdNumber = "976789012345",
                    ResidentialAddress = "789 Cedar Street",
                    MobileNumber = 791234569,
                    EmailAddress = "jennifer@gmail.com",
                    Password = "password6"
                },
                new Holder
                {
                    Id = 7,
                    FirstName = "Christopher",
                    LastName = "Lee",
                    DOB = new DateTime(1987, 6, 30),
                    IdNumber = "973456789012",
                    ResidentialAddress = "123 Maple Road",
                    MobileNumber = 791234569,
                    EmailAddress = "chris@gmail.com",
                    Password = "password7"
                },
                new Holder
                {
                    Id = 8,
                    FirstName = "Linda",
                    LastName = "Clark",
                    DOB = new DateTime(1974, 11, 5),
                    IdNumber = "978901234567",
                    ResidentialAddress = "456 Oak Road",
                    MobileNumber = 791234569,
                    EmailAddress = "linda@gmail.com",
                    Password = "password8"
                },
                new Holder
                {
                    Id = 9,
                    FirstName = "Daniel",
                    LastName = "Hall",
                    DOB = new DateTime(1998, 2, 12),
                    IdNumber = "974567890123",
                    ResidentialAddress = "789 Elm Road",
                    MobileNumber = 791234569,
                    EmailAddress = "daniel@gmail.com",
                    Password = "password9"
                },
                new Holder
                {
                    Id = 10,
                    FirstName = "Emily",
                    LastName = "Brown",
                    DOB = new DateTime(2000, 12, 3),
                    IdNumber = "977890123456",
                    ResidentialAddress = "567 Maple Street",
                    MobileNumber = 791234569,
                    EmailAddress = "emily@gmail.com",
                    Password = "password10"
                }

            );

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    Id = 1,
                    AccountNumber = 1234567895,
                    AccountHolder = 1,
                    AccountType = "Savings",
                    AccountName = "Personal Savings",
                    AccountStatus = "Active",
                    AvailableBalance = 1000.00m
                },
                new Account
                {
                    Id = 2,
                    AccountNumber = 9876543214,
                    AccountHolder = 2,
                    AccountType = "Cheque",
                    AccountName = "Checking Account",
                    AccountStatus = "Active",
                    AvailableBalance = 1500.00m
                },
                new Account
                {
                    Id = 3,
                    AccountNumber = 5678901237,
                    AccountHolder = 3,
                    AccountType = "Savings",
                    AccountName = "Emergency Savings",
                    AccountStatus = "Active",
                    AvailableBalance = 5000.00m
                },
                new Account
                {
                    Id = 4,
                    AccountNumber = 2345678904,
                    AccountHolder = 4,
                    AccountType = "Fixed",
                    AccountName = "Investment Portfolio",
                    AccountStatus = "Active",
                    AvailableBalance = 20000.00m
                },
                new Account
                {
                    Id = 5,
                    AccountNumber = 8901234566,
                    AccountHolder = 5,
                    AccountType = "Savings",
                    AccountName = "Vacation Fund",
                    AccountStatus = "Active",
                    AvailableBalance = 3000.00m
                },
                new Account
                {
                    Id = 6,
                    AccountNumber = 4567890122,
                    AccountHolder = 6,
                    AccountType = "Cheque",
                    AccountName = "Business Checking",
                    AccountStatus = "Active",
                    AvailableBalance = 2500.00m
                },
                new Account
                {
                    Id = 7,
                    AccountNumber = 123456786,
                    AccountHolder = 7,
                    AccountType = "Savings",
                    AccountName = "Retirement Savings",
                    AccountStatus = "Active",
                    AvailableBalance = 10000.00m
                },
                new Account
                {
                    Id = 8,
                    AccountNumber = 7890123458,
                    AccountHolder = 8,
                    AccountType = "Fixed",
                    AccountName = "Stock Portfolio",
                    AccountStatus = "Active",
                    AvailableBalance = 50000.00m
                },
                new Account
                {
                    Id = 9,
                    AccountNumber = 3456789015,
                    AccountHolder = 9,
                    AccountType = "Savings",
                    AccountName = "Education Fund",
                    AccountStatus = "Active",
                    AvailableBalance = 0.00m
                },
                new Account
                {
                    Id = 10,
                    AccountNumber = 9012345672,
                    AccountHolder = 10,
                    AccountType = "Cheque",
                    AccountName = "Secondary Checking",
                    AccountStatus = "Inactive",
                    AvailableBalance = 1800.00m
                },
                new Account
                {
                    Id = 11,
                    AccountNumber = 4567890128,
                    AccountHolder = 1,
                    AccountType = "Cheque",
                    AccountName = "Main Checking",
                    AccountStatus = "Active",
                    AvailableBalance = 3500.00m
                },
                new Account
                {
                    Id = 12,
                    AccountNumber = 7890123459,
                    AccountHolder = 2,
                    AccountType = "Savings",
                    AccountName = "Savings for Goals",
                    AccountStatus = "Active",
                    AvailableBalance = 8000.00m
                },
                new Account
                {
                    Id = 13,
                    AccountNumber = 1234567898,
                    AccountHolder = 3,
                    AccountType = "Fixed",
                    AccountName = "Diversified Portfolio",
                    AccountStatus = "Active",
                    AvailableBalance = 25000.00m
                },
                new Account
                {
                    Id = 14,
                    AccountNumber = 5678901237,
                    AccountHolder = 4,
                    AccountType = "Cheque",
                    AccountName = "Personal Checking",
                    AccountStatus = "Active",
                    AvailableBalance = 1200.00m
                },
                new Account
                {
                    Id = 15,
                    AccountNumber = 2345678903,
                    AccountHolder = 5,
                    AccountType = "Savings",
                    AccountName = "Dream Vacation Fund",
                    AccountStatus = "Active",
                    AvailableBalance = 6000.00m
                },
                new Account
                {
                    Id = 16,
                    AccountNumber = 8901234565,
                    AccountHolder = 6,
                    AccountType = "Fixed",
                    AccountName = "Long-Term Investments",
                    AccountStatus = "Active",
                    AvailableBalance = 40000.00m
                },
                new Account
                {
                    Id = 17,
                    AccountNumber = 123456786,
                    AccountHolder = 7,
                    AccountType = "Savings",
                    AccountName = "Emergency Fund",
                    AccountStatus = "Active",
                    AvailableBalance = 3000.00m
                },
                new Account
                {
                    Id = 18,
                    AccountNumber = 7890123458,
                    AccountHolder = 8,
                    AccountType = "Cheque",
                    AccountName = "Business Operating",
                    AccountStatus = "Active",
                    AvailableBalance = 0.00m
                },
                new Account
                {
                    Id = 19,
                    AccountNumber = 3456789011,
                    AccountHolder = 9,
                    AccountType = "Savings",
                    AccountName = "Future Planning",
                    AccountStatus = "Active",
                    AvailableBalance = 12000.00m
                },
                new Account
                {
                    Id = 20,
                    AccountNumber = 9012345677,
                    AccountHolder = 10,
                    AccountType = "Fixed",
                    AccountName = "Investment Portfolio",
                    AccountStatus = "Inactive",
                    AvailableBalance = 70000.00m
                }


            );
        }


    }
}
