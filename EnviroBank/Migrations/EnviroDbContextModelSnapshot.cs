﻿// <auto-generated />
using System;
using EnviroBank.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnviroBank.Migrations
{
    [DbContext(typeof(EnviroDbContext))]
    partial class EnviroDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EnviroBank.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("AccountHolder")
                        .HasColumnType("bigint");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("AccountNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("AccountStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("AvailableBalance")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountHolder = 1L,
                            AccountName = "Personal Savings",
                            AccountNumber = 1234567895L,
                            AccountStatus = "Active",
                            AccountType = "Savings",
                            AvailableBalance = 1000.00m
                        },
                        new
                        {
                            Id = 2,
                            AccountHolder = 2L,
                            AccountName = "Checking Account",
                            AccountNumber = 9876543214L,
                            AccountStatus = "Active",
                            AccountType = "Cheque",
                            AvailableBalance = 1500.00m
                        },
                        new
                        {
                            Id = 3,
                            AccountHolder = 3L,
                            AccountName = "Emergency Savings",
                            AccountNumber = 5678901237L,
                            AccountStatus = "Active",
                            AccountType = "Savings",
                            AvailableBalance = 5000.00m
                        },
                        new
                        {
                            Id = 4,
                            AccountHolder = 4L,
                            AccountName = "Investment Portfolio",
                            AccountNumber = 2345678904L,
                            AccountStatus = "Active",
                            AccountType = "Fixed",
                            AvailableBalance = 20000.00m
                        },
                        new
                        {
                            Id = 5,
                            AccountHolder = 5L,
                            AccountName = "Vacation Fund",
                            AccountNumber = 8901234566L,
                            AccountStatus = "Active",
                            AccountType = "Savings",
                            AvailableBalance = 3000.00m
                        },
                        new
                        {
                            Id = 6,
                            AccountHolder = 6L,
                            AccountName = "Business Checking",
                            AccountNumber = 4567890122L,
                            AccountStatus = "Active",
                            AccountType = "Cheque",
                            AvailableBalance = 2500.00m
                        },
                        new
                        {
                            Id = 7,
                            AccountHolder = 7L,
                            AccountName = "Retirement Savings",
                            AccountNumber = 123456786L,
                            AccountStatus = "Active",
                            AccountType = "Savings",
                            AvailableBalance = 10000.00m
                        },
                        new
                        {
                            Id = 8,
                            AccountHolder = 8L,
                            AccountName = "Stock Portfolio",
                            AccountNumber = 7890123458L,
                            AccountStatus = "Active",
                            AccountType = "Fixed",
                            AvailableBalance = 50000.00m
                        },
                        new
                        {
                            Id = 9,
                            AccountHolder = 9L,
                            AccountName = "Education Fund",
                            AccountNumber = 3456789015L,
                            AccountStatus = "Active",
                            AccountType = "Savings",
                            AvailableBalance = 0.00m
                        },
                        new
                        {
                            Id = 10,
                            AccountHolder = 10L,
                            AccountName = "Secondary Checking",
                            AccountNumber = 9012345672L,
                            AccountStatus = "Inactive",
                            AccountType = "Cheque",
                            AvailableBalance = 1800.00m
                        },
                        new
                        {
                            Id = 11,
                            AccountHolder = 1L,
                            AccountName = "Main Checking",
                            AccountNumber = 4567890128L,
                            AccountStatus = "Active",
                            AccountType = "Cheque",
                            AvailableBalance = 3500.00m
                        },
                        new
                        {
                            Id = 12,
                            AccountHolder = 2L,
                            AccountName = "Savings for Goals",
                            AccountNumber = 7890123459L,
                            AccountStatus = "Active",
                            AccountType = "Savings",
                            AvailableBalance = 8000.00m
                        },
                        new
                        {
                            Id = 13,
                            AccountHolder = 3L,
                            AccountName = "Diversified Portfolio",
                            AccountNumber = 1234567898L,
                            AccountStatus = "Active",
                            AccountType = "Fixed",
                            AvailableBalance = 25000.00m
                        },
                        new
                        {
                            Id = 14,
                            AccountHolder = 4L,
                            AccountName = "Personal Checking",
                            AccountNumber = 5678901237L,
                            AccountStatus = "Active",
                            AccountType = "Cheque",
                            AvailableBalance = 1200.00m
                        },
                        new
                        {
                            Id = 15,
                            AccountHolder = 5L,
                            AccountName = "Dream Vacation Fund",
                            AccountNumber = 2345678903L,
                            AccountStatus = "Active",
                            AccountType = "Savings",
                            AvailableBalance = 6000.00m
                        },
                        new
                        {
                            Id = 16,
                            AccountHolder = 6L,
                            AccountName = "Long-Term Investments",
                            AccountNumber = 8901234565L,
                            AccountStatus = "Active",
                            AccountType = "Fixed",
                            AvailableBalance = 40000.00m
                        },
                        new
                        {
                            Id = 17,
                            AccountHolder = 7L,
                            AccountName = "Emergency Fund",
                            AccountNumber = 123456786L,
                            AccountStatus = "Active",
                            AccountType = "Savings",
                            AvailableBalance = 3000.00m
                        },
                        new
                        {
                            Id = 18,
                            AccountHolder = 8L,
                            AccountName = "Business Operating",
                            AccountNumber = 7890123458L,
                            AccountStatus = "Active",
                            AccountType = "Cheque",
                            AvailableBalance = 0.00m
                        },
                        new
                        {
                            Id = 19,
                            AccountHolder = 9L,
                            AccountName = "Future Planning",
                            AccountNumber = 3456789011L,
                            AccountStatus = "Active",
                            AccountType = "Savings",
                            AvailableBalance = 12000.00m
                        },
                        new
                        {
                            Id = 20,
                            AccountHolder = 10L,
                            AccountName = "Investment Portfolio",
                            AccountNumber = 9012345677L,
                            AccountStatus = "Inactive",
                            AccountType = "Fixed",
                            AvailableBalance = 70000.00m
                        });
                });

            modelBuilder.Entity("EnviroBank.Models.Holder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ResidentialAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Holders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(1990, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "john@gmail.com",
                            FirstName = "John",
                            IdNumber = "971234567890",
                            LastName = "Doe",
                            MobileNumber = 791234569,
                            Password = "password1",
                            ResidentialAddress = "123 Main Street"
                        },
                        new
                        {
                            Id = 2,
                            DOB = new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "jane@gmail.com",
                            FirstName = "Jane",
                            IdNumber = "979876543210",
                            LastName = "Smith",
                            MobileNumber = 791234569,
                            Password = "password2",
                            ResidentialAddress = "456 Elm Street"
                        },
                        new
                        {
                            Id = 3,
                            DOB = new DateTime(1978, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "michael@gmail.com",
                            FirstName = "Michael",
                            IdNumber = "974567890123",
                            LastName = "Johnson",
                            MobileNumber = 791234569,
                            Password = "password3",
                            ResidentialAddress = "789 Oak Street"
                        },
                        new
                        {
                            Id = 4,
                            DOB = new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "sarah@gmail.com",
                            FirstName = "Sarah",
                            IdNumber = "975678901234",
                            LastName = "Williams",
                            MobileNumber = 791234569,
                            Password = "password4",
                            ResidentialAddress = "567 Pine Street"
                        },
                        new
                        {
                            Id = 5,
                            DOB = new DateTime(1983, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "david@gmail.com",
                            FirstName = "David",
                            IdNumber = "972345678901",
                            LastName = "Miller",
                            MobileNumber = 791234569,
                            Password = "password5",
                            ResidentialAddress = "890 Birch Street"
                        },
                        new
                        {
                            Id = 6,
                            DOB = new DateTime(1995, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "jennifer@gmail.com",
                            FirstName = "Jennifer",
                            IdNumber = "976789012345",
                            LastName = "Brown",
                            MobileNumber = 791234569,
                            Password = "password6",
                            ResidentialAddress = "789 Cedar Street"
                        },
                        new
                        {
                            Id = 7,
                            DOB = new DateTime(1987, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "chris@gmail.com",
                            FirstName = "Christopher",
                            IdNumber = "973456789012",
                            LastName = "Lee",
                            MobileNumber = 791234569,
                            Password = "password7",
                            ResidentialAddress = "123 Maple Road"
                        },
                        new
                        {
                            Id = 8,
                            DOB = new DateTime(1974, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "linda@gmail.com",
                            FirstName = "Linda",
                            IdNumber = "978901234567",
                            LastName = "Clark",
                            MobileNumber = 791234569,
                            Password = "password8",
                            ResidentialAddress = "456 Oak Road"
                        },
                        new
                        {
                            Id = 9,
                            DOB = new DateTime(1998, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "daniel@gmail.com",
                            FirstName = "Daniel",
                            IdNumber = "974567890123",
                            LastName = "Hall",
                            MobileNumber = 791234569,
                            Password = "password9",
                            ResidentialAddress = "789 Elm Road"
                        },
                        new
                        {
                            Id = 10,
                            DOB = new DateTime(2000, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "emily@gmail.com",
                            FirstName = "Emily",
                            IdNumber = "977890123456",
                            LastName = "Brown",
                            MobileNumber = 791234569,
                            Password = "password10",
                            ResidentialAddress = "567 Maple Street"
                        });
                });

            modelBuilder.Entity("EnviroBank.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountNumber")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
